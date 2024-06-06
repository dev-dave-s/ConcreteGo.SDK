using ConcreteGo.SDK.Models.Items;
using ConcreteGo.SDK.Models.Orders;
using ConcreteGo.SDK.Models.Processing;
using ConcreteGo.SDK.Models.Tickets;
using ConcreteGo.SDK.Models.Trucks;
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

        //public async Task Login2Async()
        //{



        //}

        #endregion

        #region Items

        public async Task<List<ItemRet>?> GetItemsAsync(ItemRequestOptions options)
        {
            var requestElementName = "ItemQueryRq";
            
            await ManageLogin();
            var request = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XProcessingInstruction("webcretexml", "version=\"1.0\""),
                new XElement("WebcreteXML",
                new XElement("WebcreteXMLMsgsRq",
                new XElement(requestElementName, ""))));

            if (options != null && request.Root != null) 
            {
                //List Only
                if(options.ListOnly != null)
                {
                    var element = new XElement("ListOnly", options.ListOnly.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if(requestElement != null)
                    {
                        requestElement.Add(element);
                    }                                         
                }
                //Codes
                if(options.Codes != null && options.Codes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if(requestElement != null)
                    {
                        foreach (var code in options.Codes)
                        {
                            requestElement.Add(new XElement("Code", code));
                        };
                    }
                }
                //LocationCodes
                if(options.LocationCodes != null && options.LocationCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if(requestElement != null)
                    {
                        foreach(var locationCode in options.LocationCodes)
                        {
                            requestElement.Add(new XElement("LocationCode", locationCode));
                        }
                    }
                }
                //CategoryIds
                if(options.CategoryIds != null && options.CategoryIds.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var categoryId in options.CategoryIds)
                        {
                            requestElement.Add(new XElement("CategoryID", categoryId));
                        }
                    }
                }
                //CategoryCodes
                if (options.CategoryCodes != null && options.CategoryCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var categoryCode in options.CategoryCodes)
                        {
                            requestElement.Add(new XElement("CategoryCode", categoryCode));
                        }
                    }
                }
                //IsConstituent
                if (options.IsConstituent != null)
                {
                    var element = new XElement("IsConstituent", options.IsConstituent.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //KeepInInventory
                if (options.KeepInInventory != null)
                {
                    var element = new XElement("KeepInInventory", options.KeepInInventory.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //IsResaleable
                if (options.IsResaleable != null)
                {
                    var element = new XElement("IsResaleable", options.IsResaleable.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //DoNotAllowTicketing
                if (options.DoNotAllowTicketing != null)
                {
                    var element = new XElement("DoNotAllowTicketing", options.DoNotAllowTicketing.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //Taxable
                if (options.Taxable != null)
                {
                    var element = new XElement("Taxable", options.Taxable.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //FromUpdateDate
                if (options.FromUpdateDate != null)
                {
                    var element = new XElement("FromUpdateDate", options.FromUpdateDate.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //ToUpdateDate
                if (options.ToUpdateDate != null)
                {
                    var element = new XElement("ToUpdateDate", options.ToUpdateDate.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //FromCreateDate
                if (options.FromCreateDate != null)
                {
                    var element = new XElement("FromCreateDate", options.FromCreateDate.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //ToCreateDate
                if (options.ToCreateDate != null)
                {
                    var element = new XElement("ToCreateDate", options.ToCreateDate.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //MaxReturned
                if (options.MaxReturned != null)
                {
                    var element = new XElement("MaxReturned", options.MaxReturned.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //IncludeRetElement
                if (options.IncludeRetElements != null && options.IncludeRetElements.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var includeRetElement in options.IncludeRetElements)
                        {
                            requestElement.Add(new XElement("IncludeRetElement", includeRetElement));
                        }
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

        #endregion

        #region Orders

        public async Task<List<OrderRet>?> GetOrdersAsync(OrderRequestOptions options)
        {
            var requestElementName = "OrderQueryRq";

            await ManageLogin();
            var request = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XProcessingInstruction("webcretexml", "version=\"1.0\""),
                new XElement("WebcreteXML",
                new XElement("WebcreteXMLMsgsRq",
                new XElement(requestElementName, ""))));

            if (options != null && request.Root != null)
            {
                //FromOrderDate
                if (options.FromOrderDate != null)
                {
                    var element = new XElement("FromOrderDate", options.FromOrderDate.Value.ToString("yyyy-MM-dd"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //ToOrderDate
                if (options.ToOrderDate != null)
                {
                    var element = new XElement("ToOrderDate", options.ToOrderDate.Value.ToString("yyyy-MM-dd"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //FromUpdateTime
                if (options.FromUpdateTime != null)
                {
                    var element = new XElement("FromUpdateTime", options.FromUpdateTime.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //ToUpdateTime
                if (options.ToUpdateTime != null)
                {
                    var element = new XElement("ToUpdateTime", options.ToUpdateTime.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //OrderIDs
                if (options.OrderIDs != null && options.OrderIDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.OrderIDs)
                        {
                            requestElement.Add(new XElement("OrderID", item));
                        };
                    }
                }
                //OrderCodes
                if (options.OrderCodes != null && options.OrderCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.OrderCodes)
                        {
                            requestElement.Add(new XElement("OrderCode", item));
                        };
                    }
                }
                //PlantCodes
                if (options.PlantCodes != null && options.PlantCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.PlantCodes)
                        {
                            requestElement.Add(new XElement("PlantCode", item));
                        };
                    }
                }
                //CustomerCodes
                if (options.CustomerCodes != null && options.CustomerCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.CustomerCodes)
                        {
                            requestElement.Add(new XElement("CustomerCode", item));
                        };
                    }
                }
                //ProjectCodes
                if (options.ProjectCodes != null && options.ProjectCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.ProjectCodes)
                        {
                            requestElement.Add(new XElement("ProjectCode", item));
                        };
                    }
                }
                //Reviewed
                if (options.Reviewed != null)
                {
                    var element = new XElement("Reviewed", options.Reviewed.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //IncludeRemovedOrder
                if (options.IncludeRemovedOrder != null)
                {
                    var element = new XElement("IncludeRemovedOrder", options.IncludeRemovedOrder.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //IncludeRetElements
                if (options.IncludeRetElements != null && options.IncludeRetElements.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.IncludeRetElements)
                        {
                            requestElement.Add(new XElement("IncludeRetElement", item));
                        };
                    }
                }
                //FailOnOrderLock
                if (options.FailOnOrderLock != null)
                {
                    var element = new XElement("FailOnOrderLock", options.FailOnOrderLock.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
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

            List<OrderRet>? result = null;
            try
            {
                result = DeserializeList<OrderRet>(response.ProcessRequestResult, "OrderQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;
        }

        #endregion

        #region Tickets

        public async Task<List<TicketRet>?> GetTicketsAsync(TicketRequestOptions options)
        {
            var requestElementName = "TicketQueryRq";

            await ManageLogin();
            var request = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XProcessingInstruction("webcretexml", "version=\"1.0\""),
                new XElement("WebcreteXML",
                new XElement("WebcreteXMLMsgsRq",
                new XElement(requestElementName, ""))));

            if (options != null && request.Root != null)
            {
                //FromOrderDate
                if (options.FromOrderDate != null)
                {
                    var element = new XElement("FromOrderDate", options.FromOrderDate.Value.ToString("yyyy-MM-dd"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //ToOrderDate
                if (options.ToOrderDate != null)
                {
                    var element = new XElement("ToOrderDate", options.ToOrderDate.Value.ToString("yyyy-MM-dd"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //FromTicketTime
                if (options.FromTicketTime != null)
                {
                    var element = new XElement("FromTicketTime", options.FromTicketTime.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //ToTicketTime
                if (options.ToTicketTime != null)
                {
                    var element = new XElement("ToTicketTime", options.ToTicketTime.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //FromUpdateTime
                if (options.FromUpdateTime != null)
                {
                    var element = new XElement("FromUpdateTime", options.FromUpdateTime.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //ToUpdateTime
                if (options.ToUpdateTime != null)
                {
                    var element = new XElement("ToUpdateTime", options.ToUpdateTime.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //FromLoadTime
                if (options.FromLoadTime != null)
                {
                    var element = new XElement("FromLoadTime", options.FromLoadTime.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //ToLoadTime
                if (options.ToLoadTime != null)
                {
                    var element = new XElement("ToLoadTime", options.ToLoadTime.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //FromCreatedDate
                if (options.FromCreatedDate != null)
                {
                    var element = new XElement("FromCreatedDate", options.FromCreatedDate.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //ToCreatedDate
                if (options.ToCreatedDate != null)
                {
                    var element = new XElement("ToCreatedDate", options.ToCreatedDate.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //OrderIDs
                if (options.OrderIDs != null && options.OrderIDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.OrderIDs)
                        {
                            requestElement.Add(new XElement("OrderID", item));
                        };
                    }
                }
                //TicketIDs
                if (options.TicketIDs != null && options.TicketIDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.TicketIDs)
                        {
                            requestElement.Add(new XElement("TicketID", item));
                        };
                    }
                }
                //TicketCodes
                if (options.TicketCodes != null && options.TicketCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.TicketCodes)
                        {
                            requestElement.Add(new XElement("TicketCode", item));
                        };
                    }
                }
                //PlantCodes
                if (options.PlantCodes != null && options.PlantCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.PlantCodes)
                        {
                            requestElement.Add(new XElement("PlantCode", item));
                        };
                    }
                }
                //CustomerCodes
                if (options.CustomerCodes != null && options.CustomerCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.CustomerCodes)
                        {
                            requestElement.Add(new XElement("CustomerCode", item));
                        };
                    }
                }
                //ProjectCodes
                if (options.ProjectCodes != null && options.ProjectCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.ProjectCodes)
                        {
                            requestElement.Add(new XElement("ProjectCode", item));
                        };
                    }
                }
                //MixCodes
                if (options.MixCodes != null && options.MixCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.MixCodes)
                        {
                            requestElement.Add(new XElement("MixCode", item));
                        };
                    }
                }
                //List Only
                if (options.ListOnly != null)
                {
                    var element = new XElement("ListOnly", options.ListOnly.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //OrderBy
                if (options.OrderBy != null)
                {
                    var element = new XElement("OrderBy", options.OrderBy);
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //Reviewed
                if (options.Reviewed != null)
                {
                    var element = new XElement("Reviewed", options.Reviewed.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //IncludeRemovedTicket
                if (options.IncludeRemovedTicket != null)
                {
                    var element = new XElement("IncludeRemovedTicket", options.IncludeRemovedTicket.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //IncludeSuspendedTicket
                if (options.IncludeSuspendedTicket != null)
                {
                    var element = new XElement("IncludeSuspendedTicket", options.IncludeSuspendedTicket.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //IncludeInvoicedTicket
                if (options.IncludeInvoicedTicket != null)
                {
                    var element = new XElement("IncludeInvoicedTicket", options.IncludeInvoicedTicket.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //WithBatchWeightsOnly
                if (options.WithBatchWeightsOnly != null)
                {
                    var element = new XElement("WithBatchWeightsOnly", options.WithBatchWeightsOnly.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //IncludeRetElement
                if (options.IncludeRetElements != null && options.IncludeRetElements.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var includeRetElement in options.IncludeRetElements)
                        {
                            requestElement.Add(new XElement("IncludeRetElement", includeRetElement));
                        }
                    }
                }
                //MarkOrderAsInvoiced
                if (options.MarkOrderAsInvoiced != null)
                {
                    var element = new XElement("MarkOrderAsInvoiced", options.MarkOrderAsInvoiced.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //MarkTicketAsInvoiced
                if (options.MarkTicketAsInvoiced != null)
                {
                    var element = new XElement("MarkTicketAsInvoiced", options.MarkTicketAsInvoiced.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //FailOnOrderLock
                if (options.FailOnOrderLock != null)
                {
                    var element = new XElement("FailOnOrderLock", options.FailOnOrderLock.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
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

            List<TicketRet>? result = null;
            try
            {
                result = DeserializeList<TicketRet>(response.ProcessRequestResult, "TicketQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;
        }

        #endregion

        #region Trucks

        public async Task<List<TruckRet>?> GetTrucksAsync(TruckRequestOptions options)
        {
            var requestElementName = "TruckQueryRq";

            await ManageLogin();
            var request = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XProcessingInstruction("webcretexml", "version=\"1.0\""),
                new XElement("WebcreteXML",
                new XElement("WebcreteXMLMsgsRq",
                new XElement(requestElementName, ""))));

            if (options != null && request.Root != null)
            {
                //IDs
                if (options.Ids != null && options.Ids.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.Ids)
                        {
                            requestElement.Add(new XElement("ID", item));
                        };
                    }
                }
                //Code
                if (options.Codes != null && options.Codes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.Codes)
                        {
                            requestElement.Add(new XElement("Code", item));
                        };
                    }
                }
                //PlantIDs
                if (options.PlantIDs != null && options.PlantIDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.PlantIDs)
                        {
                            requestElement.Add(new XElement("PlantID", item));
                        };
                    }
                }
                //PlantCodes
                if (options.PlantCodes != null && options.PlantCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.PlantCodes)
                        {
                            requestElement.Add(new XElement("PlantCode", item));
                        };
                    }
                }
                //ListOnly
                if (options.ListOnly != null)
                {
                    var element = new XElement("ListOnly", options.ListOnly.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //ListOnly
                if (options.IncludeInactive != null)
                {
                    var element = new XElement("IncludeInactive", options.IncludeInactive.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //FromStatusTimeStamp
                if (options.FromStatusTimeStamp != null)
                {
                    var element = new XElement("FromStatusTimeStamp", options.FromStatusTimeStamp.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //ToStatusTimeStamp
                if (options.ToStatusTimeStamp != null)
                {
                    var element = new XElement("ToStatusTimeStamp", options.ToStatusTimeStamp.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //FromLocationUpdateTime
                if (options.FromLocationUpdateTime != null)
                {
                    var element = new XElement("FromLocationUpdateTime", options.FromLocationUpdateTime.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //ToLocationUpdateTime
                if (options.ToLocationUpdateTime != null)
                {
                    var element = new XElement("ToLocationUpdateTime", options.ToLocationUpdateTime.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
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

            List<TruckRet>? result = null;
            try
            {
                result = DeserializeList<TruckRet>(response.ProcessRequestResult, "TruckQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;
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
                Type = typeof(T),
                IsNullable = true
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
                            return default;
                            //return result.Response.FirstOrDefault();
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
