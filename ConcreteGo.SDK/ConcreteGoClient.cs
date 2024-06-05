using ConcreteGo.SDK.Models.Items;
using ConcreteGo.SDK.Models.Processing;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using WebcreteAPI;

namespace ConcreteGo.SDK
{
    public class ConcreteGoClient
    {
        private readonly string _username;
        private readonly string _password;
        private readonly string _appId;
        private readonly string _appKey;
        private readonly string? _slug;
        private readonly WebcreteAPISoapClient _api = new WebcreteAPISoapClient(new WebcreteAPISoapClient.EndpointConfiguration());
        private TicketHeader? _ticketHeader;
        private DateTime? _loginTime;

        public ConcreteGoClient(string username, string password, string appId, string appKey, string? slug)
        {
            _username = username;
            _password = password;
            _appId = appId;
            _appKey = appKey;
            _slug = slug;
            
        }

        #region Login

        private async Task LoginAsync()
        {
            RSACryptoServiceProvider key = new RSACryptoServiceProvider();
            //Get public key to encrypt password.
            try
            {
                var publicKeyResponse = await _api.GetPublicKeyAsync(_appId, _appKey);
                _ticketHeader = publicKeyResponse.TicketHeader;
                key.FromXmlString(publicKeyResponse.GetPublicKeyResult);

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }

            //Encrypt credentials.
            UnicodeEncoding enc = new UnicodeEncoding();
            var encryptedPassword = key.Encrypt(enc.GetBytes(_password), false);

            //Attempt login.
            try
            {
                var loginResult = await _api.LoginAsync(_ticketHeader, _username, encryptedPassword, _slug);
                if (loginResult.LoginResult)
                {
                    _loginTime = DateTime.Now;
                }
                else
                {
                    throw new InvalidOperationException("Login failed.  Check credentials.");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }

        public async Task Login2Async()
        {



        }

        #endregion

        #region Items

        public async Task<List<ItemRet>?> GetItemsAsync(ItemRequestOptions options)
        {
            await ManageLogin();
            var request = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XProcessingInstruction("webcretexml", "version=\"1.0\""),
                new XElement("WebcreteXML",
                new XElement("WebcreteXMLMsgsRq",
                new XElement("ItemQueryRq", ""))));

            if (options != null && request.Root != null) 
            {
                //List Only
                if(options.ListOnly != null)
                {
                    var listOnly = new XElement("ListOnly", options.ListOnly.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == "ItemQueryRq");
                    if(requestElement != null)
                    {
                        requestElement.Add(listOnly);
                    }                     
                    
                }

                if(options.Codes != null && options.Codes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == "ItemQueryRq");
                    if(requestElement != null)
                    {
                        foreach (var code in options.Codes)
                        {
                            requestElement.Add(new XElement("Code", code));
                        };
                    }
                }
            }

            var response = new ProcessRequestResponse();
            try
            {
                response = await _api.ProcessRequestAsync(_ticketHeader, request.ToString());
            }
            catch (Exception ex) 
            {
                throw new Exception("Error processing request: " + ex.Message);
            }

            List<ItemRet>? result = null;
            try
            {
                result = DeserializeList<ItemRet>(response.ProcessRequestResult, "ItemQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }
            
            return result;
        }

        //public async Task GetItemsIncludingMixDesignAsync()
        //{
        //    await ManageLogin();
        //    var request = new XDocument(
        //        new XDeclaration("1.0", "utf-8", "yes"),
        //        new XProcessingInstruction("webcretexml", "version=\"1.0\""),
        //        new XElement("WebcreteXML",
        //        new XElement("WebcreteXMLMsgsRq",
        //        new XElement("ItemQueryRq", ""))));

        //    var response = new ProcessRequestResponse();
        //    try
        //    {
        //        response = await _api.ProcessRequestAsync(_ticketHeader, request.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error processing request: " + ex.Message);
        //    }

        //    List<ItemRet>? result = null;
        //    try
        //    {
        //        result = DeserializeList<ItemRet>(response.ProcessRequestResult, "ItemQueryRs");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error deserializing xml response: " + ex.Message);
        //    }

        //    return result;
        //}

        public async Task GetItemByItemCodeAsync()
        {

        }

        #endregion


        #region Helpers
        public static List<T>? DeserializeList<T>(string xml, string rootElement)
        {
            var boolFixedXml = FixXmlBool(xml);
            var xDoc = XDocument.Parse(boolFixedXml);
            var xmlGenericResponseAttributes = new XmlAttributes { XmlRoot = new XmlRootAttribute { ElementName = rootElement, IsNullable = true } };
            
            var xmlResponseListAttributes = new XmlAttributes();
            var xmlAttribute = new XmlElementAttribute
            {
                ElementName = typeof(T).Name,
                Type = typeof(T)
            };
            xmlResponseListAttributes.XmlElements.Add(xmlAttribute);
            var attributeOverrides = new XmlAttributeOverrides();
            attributeOverrides.Add(typeof(GenericResponse<T>), xmlGenericResponseAttributes);
            attributeOverrides.Add(typeof(GenericResponse<T>), "Response", xmlResponseListAttributes);
            
            var serlist = new XmlSerializer(typeof(GenericResponse<T>), attributeOverrides);
            if(xDoc.Root != null)
            {
                var node = xDoc.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == rootElement);
                if (node != null)
                {
                    using (var reader = node.CreateReader())
                    {
                        var result = (GenericResponse<T>?)serlist.Deserialize(reader);
                        if (result != null)
                        {
                            return result.Response;
                        }
                    }
                }
            }

            return null;
        }

        public static T? DeserializeItem<T>(string xml, string rootElement)
        {
            var boolFixedXml = FixXmlBool(xml);
            var xDoc = XDocument.Parse(boolFixedXml);
            var xmlGenericResponseAttributes = new XmlAttributes { XmlRoot = new XmlRootAttribute { ElementName = rootElement, IsNullable = true } };

            var xmlResponseListAttributes = new XmlAttributes();
            var xmlAttribute = new XmlElementAttribute
            {
                ElementName = typeof(T).Name,
                Type = typeof(T)
            };
            xmlResponseListAttributes.XmlElements.Add(xmlAttribute);
            var attributeOverrides = new XmlAttributeOverrides();
            attributeOverrides.Add(typeof(GenericResponse<T>), xmlGenericResponseAttributes);
            attributeOverrides.Add(typeof(GenericResponse<T>), "Response", xmlResponseListAttributes);

            var serlist = new XmlSerializer(typeof(GenericResponse<T>), attributeOverrides);
            if (xDoc.Root != null)
            {
                var node = xDoc.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == rootElement);
                if (node != null)
                {
                    using (var reader = node.CreateReader())
                    {
                        var result = (GenericResponse<T>?)serlist.Deserialize(reader);
                        if (result != null)
                        {
                            return result.Response.FirstOrDefault();
                        }
                    }
                }
            }

            return default;
        }

        private async Task ManageLogin()
        {
            //If not logged in, then login.
            if(_loginTime == null)
            {
                await LoginAsync();
                return;
            }

            //If login is old, refresh login.
            if((DateTime.Now - _loginTime.Value).TotalHours >= 4)
            {
                await LoginAsync();
            }
        }

        public static string FixXmlBool(string xmlText)
        {
            //ConcreteGoApi annoyingly has uppercase on bool values which disagrees with Deserialize.
            var response = string.Empty;
            try
            {
                response = xmlText.Replace("True", "true");
                response = response.Replace("False", "false");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return response;
        }

        #endregion
    }
}
