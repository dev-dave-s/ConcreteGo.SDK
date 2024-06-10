using ConcreteGo.SDK.Models.AccountingCategories;
using ConcreteGo.SDK.Models.Company;
using ConcreteGo.SDK.Models.CreditCodes;
using ConcreteGo.SDK.Models.Divisions;
using ConcreteGo.SDK.Models.Employees;
using ConcreteGo.SDK.Models.ItemCategories;
using ConcreteGo.SDK.Models.Items;
using ConcreteGo.SDK.Models.ItemTypes;
using ConcreteGo.SDK.Models.Locations;
using ConcreteGo.SDK.Models.Orders;
using ConcreteGo.SDK.Models.Plants;
using ConcreteGo.SDK.Models.PriceCategories;
using ConcreteGo.SDK.Models.Processing;
using ConcreteGo.SDK.Models.TaxLocations;
using ConcreteGo.SDK.Models.TaxAuthority;
using ConcreteGo.SDK.Models.TaxCodes;
using ConcreteGo.SDK.Models.Tickets;
using ConcreteGo.SDK.Models.Trucks;
using ConcreteGo.SDK.Models.UOMs;
using ConcreteGo.SDK.Models.Version;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using WebcreteAPI;
using ConcreteGo.SDK.Models.Customers;

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

        #endregion

        #region Accounting Categories

        public async Task<List<AccountingCategoryRet>?> GetAccountingCategories(AccountingCategoryOptions? options = null)
        {
            var requestElementName = "AccountingCategoryQueryRq";

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
                if (options.IDs != null && options.IDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.IDs)
                        {
                            requestElement.Add(new XElement("ID", item));
                        };
                    }
                }
                //Codes
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

            List<AccountingCategoryRet>? result = null;
            try
            {
                result = Deserialize<AccountingCategoryRet>(response.ProcessRequestResult, "AccountingCategoryQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;

        }

        #endregion

        #region Customers

        public async Task<List<CustomerRet>?> GetCustomersAsync(CustomerOptions? options = null)
        {
            var requestElementName = "CustomerQueryRq";

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
                if (options.IDs != null && options.IDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.IDs)
                        {
                            requestElement.Add(new XElement("ID", item));
                        };
                    }
                }
                //Codes
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
                //Names
                if (options.Names != null && options.Names.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.Names)
                        {
                            requestElement.Add(new XElement("Name", item));
                        };
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
                //InActive
                if (options.InActive != null)
                {
                    var element = new XElement("InActive", options.InActive.Value.ToString());
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //FromSetupDate
                if (options.FromSetupDate != null)
                {
                    var element = new XElement("FromSetupDate", options.FromSetupDate.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        requestElement.Add(element);
                    }
                }
                //ToSetupDate
                if (options.ToSetupDate != null)
                {
                    var element = new XElement("ToSetupDate", options.ToSetupDate.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
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
                //SalesAnalysisCodes
                if (options.SalesAnalysisCodes != null && options.SalesAnalysisCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.SalesAnalysisCodes)
                        {
                            requestElement.Add(new XElement("SalesAnalysisCode", item));
                        };
                    }
                }
                //SalesmanCodes
                if (options.SalesmanCodes != null && options.SalesmanCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.SalesmanCodes)
                        {
                            requestElement.Add(new XElement("SalesmanCode", item));
                        };
                    }
                }
                //SalesmanNames
                if (options.SalesmanNames != null && options.SalesmanNames.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.SalesmanNames)
                        {
                            requestElement.Add(new XElement("SalesmanName", item));
                        };
                    }
                }
                //PriceCategoryCodes
                if (options.PriceCategoryCodes != null && options.PriceCategoryCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.PriceCategoryCodes)
                        {
                            requestElement.Add(new XElement("PriceCategoryCode", item));
                        };
                    }
                }
                //PricingPlantCodes
                if (options.PricingPlantCodes != null && options.PricingPlantCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.PricingPlantCodes)
                        {
                            requestElement.Add(new XElement("PricingPlantCode", item));
                        };
                    }
                }
                //TermsCodes
                if (options.TermsCodes != null && options.TermsCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.TermsCodes)
                        {
                            requestElement.Add(new XElement("TermsCode", item));
                        };
                    }
                }
                //ZoneCodes
                if (options.ZoneCodes != null && options.ZoneCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.ZoneCodes)
                        {
                            requestElement.Add(new XElement("ZoneCode", item));
                        };
                    }
                }
                //StatementCycles
                if (options.StatementCycles != null && options.StatementCycles.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.StatementCycles)
                        {
                            requestElement.Add(new XElement("StatementCycle", item));
                        };
                    }
                }
                //AccountingCategoryCodes
                if (options.AccountingCategoryCodes != null && options.AccountingCategoryCodes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.AccountingCategoryCodes)
                        {
                            requestElement.Add(new XElement("AccountingCategoryCodes", item));
                        };
                    }
                }
                //IncludeRetElement
                if (options.IncludeRetElement != null && options.IncludeRetElement.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.IncludeRetElement)
                        {
                            requestElement.Add(new XElement("IncludeRetElement", item));
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

            List<CustomerRet>? result = null;
            try
            {
                result = Deserialize<CustomerRet>(response.ProcessRequestResult, "CustomerQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;

        }

        #endregion

        #region Employees

        public async Task<List<EmployeeRet>?> GetEmployeesAsync(EmployeeOptions? options = null)
        {
            var requestElementName = "EmployeeQueryRq";

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
                if (options.IDs != null && options.IDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.IDs)
                        {
                            requestElement.Add(new XElement("ID", item));
                        };
                    }
                }
                //Codes
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
                //PlantTypes
                if (options.PlantTypes != null && options.PlantTypes.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.PlantTypes)
                        {
                            requestElement.Add(new XElement("PlantType", item));
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
                //IncludeInactive
                if (options.IncludeInactive != null)
                {
                    var element = new XElement("IncludeInactive", options.IncludeInactive.Value.ToString());
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

            List<EmployeeRet>? result = null;
            try
            {
                result = Deserialize<EmployeeRet>(response.ProcessRequestResult, "EmployeeQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;

        }

        #endregion

        #region Company

        public async Task<List<CompanyRet>> GetCompanyAsync()
        {
            var requestElementName = "CompanyQueryRq";

            await ManageLogin();
            var request = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XProcessingInstruction("webcretexml", "version=\"1.0\""),
                new XElement("WebcreteXML",
                new XElement("WebcreteXMLMsgsRq",
                new XElement(requestElementName, ""))));

            var response = new ProcessRequestResponse();
            try
            {
                response = await _api.ProcessRequestAsync(_ticketHeader, request.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Error processing request: " + ex.Message);
            }

            List<CompanyRet>? result = null;
            try
            {
                result = Deserialize<CompanyRet>(response.ProcessRequestResult, "CompanyQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;

        }

        #endregion

        #region CreditCodes

        public async Task<List<CreditCodeRet>?> GetCreditCodesAsync(CreditCodeOptions? options = null)
        {
            var requestElementName = "CreditCodeQueryRq";

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
                if (options.IDs != null && options.IDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.IDs)
                        {
                            requestElement.Add(new XElement("ID", item));
                        };
                    }
                }
                //Codes
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

            List<CreditCodeRet>? result = null;
            try
            {
                result = Deserialize<CreditCodeRet>(response.ProcessRequestResult, "CreditCodeQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;

        }

        #endregion

        #region Divisions

        public async Task<List<DivisionRet>?> GetDivisionsAsync(DivisionRequestOptions? options = null)
        {
            var requestElementName = "DivisionQueryRq";

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
                if (options.IDs != null && options.IDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.IDs)
                        {
                            requestElement.Add(new XElement("ID", item));
                        };
                    }
                }
                //Codes
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
                //Names
                if (options.Names != null && options.Names.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.Names)
                        {
                            requestElement.Add(new XElement("Name", item));
                        };
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

            List<DivisionRet>? result = null;
            try
            {
                result = Deserialize<DivisionRet>(response.ProcessRequestResult, "DivisionQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;

        }

        #endregion

        #region Items

        public async Task<List<ItemRet>?> GetItemsAsync(ItemRequestOptions? options = null)
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
                result = Deserialize<ItemRet>(response.ProcessRequestResult, "ItemQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }
            
            return result;
        }

        #endregion

        #region Item Categories

        public async Task<List<ItemCategoryRet>?> GetItemCategoriesAsync(ItemCategoryOptions? options = null)
        {
            var requestElementName = "ItemCategoryQueryRq";

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
                if (options.IDs != null && options.IDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.IDs)
                        {
                            requestElement.Add(new XElement("ID", item));
                        };
                    }
                }
                //Codes
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

            List<ItemCategoryRet>? result = null;
            try
            {
                result = Deserialize<ItemCategoryRet>(response.ProcessRequestResult, "ItemCategoryQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;

        }

        #endregion

        #region Item Types

        public async Task<List<ItemTypeRet>?> GetItemTypesAsync(ItemTypeOptions? options = null)
        {
            var requestElementName = "ItemTypeQueryRq";

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
                if (options.IDs != null && options.IDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.IDs)
                        {
                            requestElement.Add(new XElement("ID", item));
                        };
                    }
                }
                //Codes
                if (options.Names != null && options.Names.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.Names)
                        {
                            requestElement.Add(new XElement("Name", item));
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

            List<ItemTypeRet>? result = null;
            try
            {
                result = Deserialize<ItemTypeRet>(response.ProcessRequestResult, "ItemTypeQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;

        }

        #endregion

        #region Item Categories

        public async Task<List<LocationRet>?> GetLocationsAsync(LocationOptions? options = null)
        {
            var requestElementName = "LocationQueryRq";

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
                if (options.IDs != null && options.IDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.IDs)
                        {
                            requestElement.Add(new XElement("ID", item));
                        };
                    }
                }
                //Codes
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
                //Names
                if (options.Names != null && options.Names.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.Names)
                        {
                            requestElement.Add(new XElement("Name", item));
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

            List<LocationRet>? result = null;
            try
            {
                result = Deserialize<LocationRet>(response.ProcessRequestResult, "LocationQueryRs");
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
                result = Deserialize<OrderRet>(response.ProcessRequestResult, "OrderQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;
        }

        #endregion

        #region Plants

        public async Task<List<PlantRet>?> GetPlantsAsync(PlantOptions? options = null)
        {
            var requestElementName = "PlantQueryRq";

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
                if (options.IDs != null && options.IDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.IDs)
                        {
                            requestElement.Add(new XElement("ID", item));
                        };
                    }
                }
                //Codes
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

            List<PlantRet>? result = null;
            try
            {
                result = Deserialize<PlantRet>(response.ProcessRequestResult, "PlantQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;

        }

        #endregion

        #region Price Categories

        public async Task<List<PriceCategoryRet>?> GetPriceCategories(PriceCategoryOptions? options = null)
        {
            var requestElementName = "PriceCategoryQueryRq";

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
                if (options.IDs != null && options.IDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.IDs)
                        {
                            requestElement.Add(new XElement("ID", item));
                        };
                    }
                }
                //Codes
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

            List<PriceCategoryRet>? result = null;
            try
            {
                result = Deserialize<PriceCategoryRet>(response.ProcessRequestResult, "PriceCategoryQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;

        }

        #endregion

        #region Tax Authorities

        public async Task<List<TaxAuthorityRet>?> GetTaxAuthoritiesAsync(CreditCodeOptions? options = null)
        {
            var requestElementName = "TaxAuthorityQueryRq";

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
                if (options.IDs != null && options.IDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.IDs)
                        {
                            requestElement.Add(new XElement("ID", item));
                        };
                    }
                }
                //Codes
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

            List<TaxAuthorityRet>? result = null;
            try
            {
                result = Deserialize<TaxAuthorityRet>(response.ProcessRequestResult, "TaxAuthorityQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;

        }

        #endregion

        #region Tax Codes

        public async Task<List<TaxCodeRet>?> GetTaxCodesAsync(CreditCodeOptions? options = null)
        {
            var requestElementName = "TaxCodeQueryRq";

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
                if (options.IDs != null && options.IDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.IDs)
                        {
                            requestElement.Add(new XElement("ID", item));
                        };
                    }
                }
                //Codes
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

            List<TaxCodeRet>? result = null;
            try
            {
                result = Deserialize<TaxCodeRet>(response.ProcessRequestResult, "TaxCodeQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;

        }

        #endregion

        #region Tax Locations

        public async Task<List<TaxLocationRet>?> GetTaxLocationsAsync(CreditCodeOptions? options = null)
        {
            var requestElementName = "TaxLocationQueryRq";

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
                if (options.IDs != null && options.IDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.IDs)
                        {
                            requestElement.Add(new XElement("ID", item));
                        };
                    }
                }
                //Codes
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

            List<TaxLocationRet>? result = null;
            try
            {
                result = Deserialize<TaxLocationRet>(response.ProcessRequestResult, "TaxLocationQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;

        }

        #endregion

        #region Tickets

        public async Task<List<TicketRet>?> GetTicketsAsync(TicketRequestOptions? options = null)
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
                result = Deserialize<TicketRet>(response.ProcessRequestResult, "TicketQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;
        }

        #endregion

        #region Trucks

        public async Task<List<TruckRet>?> GetTrucksAsync(TruckRequestOptions? options = null!)
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
                result = Deserialize<TruckRet>(response.ProcessRequestResult, "TruckQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;
        }

        public async Task<List<TruckRet>?> AddOrUpdateTruck(TruckAddOrUpdateRq data)
        {
            var requestElementName = "TruckUpdateRq";

            await ManageLogin();
            var request = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XProcessingInstruction("webcretexml", "version=\"1.0\""),
                new XElement("WebcreteXML",
                new XElement("WebcreteXMLMsgsRq",
                new XElement(requestElementName, ""))));

            if (request.Root != null)
            {
                var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);


                var requestData = XElement.Parse(Serialize(data));
                if (requestElement != null)
                {
                    requestElement.Add(requestData);
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
                result = Deserialize<TruckRet>(response.ProcessRequestResult, "TruckUpdateRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;
        }

        #endregion

        #region UOMs

        public async Task<List<UOMRet>?> GetUOMsAsync(UOMRequestOptions? options = null)
        {
            var requestElementName = "UOMQueryRq";

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
                if (options.IDs != null && options.IDs.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.IDs)
                        {
                            requestElement.Add(new XElement("ID", item));
                        };
                    }
                }
                //Codes
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
                //Names
                if (options.Names != null && options.Names.Any())
                {
                    var requestElement = request.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == requestElementName);
                    if (requestElement != null)
                    {
                        foreach (var item in options.Names)
                        {
                            requestElement.Add(new XElement("Name", item));
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

            List<UOMRet>? result = null;
            try
            {
                result = Deserialize<UOMRet>(response.ProcessRequestResult, "UOMQueryRs");
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return result;

        }

        #endregion

        #region Version

        public async Task<VersionRet?> GetVersionAsync()
        {
            var requestElementName = "VersionQueryRq";

            await ManageLogin();
            var request = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XProcessingInstruction("webcretexml", "version=\"1.0\""),
                new XElement("WebcreteXML",
                new XElement("WebcreteXMLMsgsRq",
                new XElement(requestElementName, ""))));

            var response = new ProcessRequestResponse();
            try
            {
                response = await _api.ProcessRequestAsync(_ticketHeader, request.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Error processing request: " + ex.Message);
            }

            var result = new VersionRet();

            try
            {
                var xDoc = XDocument.Parse(response.ProcessRequestResult);
                if (xDoc.Root != null)
                {
                    var concreteGoVersion = xDoc.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == "ConcreteGoVersion");
                    var webcreteVersion = xDoc.Root.Descendants().FirstOrDefault(x => x.Name.LocalName == "WebcreteVersion");
                    result.ConcreteGoVersion = concreteGoVersion.Value;
                    result.WebcreteVersion = webcreteVersion.Value;
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deserializing xml response: " + ex.Message);
            }

            return null;
        }

        #endregion

        #region Helpers

        private List<T>? Deserialize<T>(string xml, string rootElement)
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

        private string Serialize<T>(T data)
        {
            var xmlGenericResponseAttributes = new XmlAttributes { XmlRoot = new XmlRootAttribute { Namespace = "", IsNullable = true } };


            var ser = new XmlSerializer(typeof(T));
            using(var writer = new StringWriter())
            {
                ser.Serialize(writer, data);
                return writer.ToString();
            }
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

        private static string FixXmlBool(string xmlText)
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
