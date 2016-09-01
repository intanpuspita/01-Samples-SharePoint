using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SPWebServices
{
    class Program
    {
        static void Main(string[] args)
        {
            SPReference.Lists client = new SPReference.Lists();
            client.Credentials = System.Net.CredentialCache.DefaultCredentials;
            client.Url = "http://mtpc513:26583/projects/_vti_bin/Lists.asmx";

            try
            {
                string listName = "{D7562349-8FFD-4A6F-9B84-AF84D4FAAC3C}";
                string viewName = "{6D6A5845-83E1-4960-9A25-BCD4C68BCC9E}";
                string rowlimit = "100";

                // Instantiate an XmlDocument object
                System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
                System.Xml.XmlElement query = xmlDoc.CreateElement("Query");
                System.Xml.XmlElement viewFields = xmlDoc.CreateElement("ViewFields");
                System.Xml.XmlElement queryOptions = xmlDoc.CreateElement("QueryOptions");

                /*Use CAML query*/
                query.InnerXml = "<Where><Gt><FieldRef Name=\"ID\" />" +
                "<Value Type=\"Counter\">0</Value></Gt></Where>";
                viewFields.InnerXml = "<FieldRef Name=\"Name\" />" +
                                      "<FieldRef Name=\"Allowance\" />" +
                                      "<FieldRef Name=\"Level\" />";
                queryOptions.InnerXml = "";

                System.Xml.XmlNode nodes = client.GetListItems(listName, viewName, query, viewFields, rowlimit, null, null);

                foreach (System.Xml.XmlNode node in nodes)
                {
                    if (node.Name == "rs:data")
                    {
                        for (int i = 0; i < node.ChildNodes.Count; i++)
                        {
                            if (node.ChildNodes[i].Name == "z:row")
                            {
                                Console.WriteLine(node.ChildNodes[i].Attributes["ows_Name"].Value + " " + node.ChildNodes[i].Attributes["ows_Allowance"].Value + " " + node.ChildNodes[i].Attributes["ows_Level"].Value);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
