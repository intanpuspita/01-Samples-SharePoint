using System;
using System.Windows.Forms;
using Microsoft.SharePoint;
using System.Data;
using System.Collections.Specialized;
using System.Xml;
using Microsoft.SharePoint.Client;
using SP = Microsoft.SharePoint.Client;

namespace ListSharePoint
{
    public partial class FormSP : System.Windows.Forms.Form
    {
        public FormSP()
        {
            InitializeComponent();
        }

        private String siteurl;
        private String subsite;
        private String listname;

        /**
         * Note : Retrieve list of sub sites
         * 
         **/
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            siteurl = txtsite.Text;

            try
            {
                if (String.IsNullOrEmpty(siteurl.Trim()))
                    throw new Exception("Please fill site URL");

                using (SPSite site = new SPSite(siteurl))
                {
                    foreach (SPWeb web in site.RootWeb.GetSubwebsForCurrentUser())
                    {
                        cmbsubsite.Items.Add(web.Name);
                    }
                }
                btnsite.Enabled = false;

                lblsubsite.Visible = true;
                cmbsubsite.Visible = true;
                btnsubsite1.Visible = true;
                lblmessage1.Visible = false;
            }
            catch (Exception ex)
            {
                lblmessage1.Text = ex.Message;
                lblmessage1.Visible = true;
            }
        }

        /**
         * Note : Retrieve list of list
         * 
         **/
        private void btnsubsite1_Click(object sender, EventArgs e)
        {
            subsite = cmbsubsite.Text;

            try
            {
                if (String.IsNullOrEmpty(subsite))
                    throw new Exception("Please choose subsite");

                using (SPSite site = new SPSite(siteurl))
                {
                    using (SPWeb web = site.OpenWeb(subsite))
                    {
                        foreach (SPList lists in web.Lists)
                        {
                            cmblist.Items.Add(lists.Title);
                        }
                    }
                }
                btnsubsite1.Enabled = false;

                lbllist.Visible = true;
                cmblist.Visible = true;
                btnlist.Visible = true;
                lblmessage2.Visible = false;
            }
            catch(Exception ex)
            {
                lblmessage2.Text = ex.Message;
                lblmessage2.Visible = true;
            }
        }

        public void btnlist_Click(object sender, EventArgs e)
        {
            listname = cmblist.Text;

            try 
            {
                if (String.IsNullOrEmpty(listname))
                    throw new Exception("Please choose subsite");

                using (SPSite site = new SPSite(siteurl))
                {
                    using (SPWeb web = site.OpenWeb(subsite))
                    {
                        SPList list = web.Lists[listname];
                        SPView view = list.DefaultView;

                        SPListItemCollection items = list.GetItems();
                        StringCollection viewFields = view.ViewFields.ToStringCollection();

                        DataTable dt = new DataTable();
                        DataRow dtrow;
                        Int16 i = 1;

                        foreach (SPListItem item in items)
                        {
                            dtrow = dt.NewRow();
                            
                            foreach (string fieldname in viewFields)
                            {
                                string decodefield = XmlConvert.DecodeName(fieldname);

                                if (i == 1)
                                    dt.Columns.Add(decodefield);

                                SPField field = list.Fields.GetField(decodefield);
                                if (field.Type == SPFieldType.Calculated && item[decodefield] != null) 
                                {
                                    SPFieldCalculated cf = (SPFieldCalculated)item.Fields[decodefield];
                                    dtrow[decodefield] = cf.GetFieldValueAsText(item[decodefield]);
                                }
                                else if (field.Type == SPFieldType.Lookup && item[decodefield] != null)
                                    dtrow[decodefield] = new SPFieldLookupValue(item[decodefield].ToString()).LookupValue;
                                else
                                    dtrow[decodefield] = item[decodefield];
                            }

                            dt.Rows.Add(dtrow);
                            i++;
                        }
                        gridlist.DataSource = dt;
                    }
                }
                lblmessage3.Visible = false;
            }
            catch (Exception ex)
            {
                lblmessage3.Text = ex.Message;
                lblmessage3.Visible = true;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(siteurl))
                    throw new Exception("Plase choose site collection in previous tab");

                String title = txttitle.Text;
                String name = txtname.Text;
                String allowance = txtallowance.Text;
                String level = txtlevel.Text;

                if (String.IsNullOrEmpty(title) || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(allowance) || String.IsNullOrEmpty(level))
                    throw new Exception("Please fill all data");

                ClientContext clientContext = new ClientContext(siteurl + "//" + subsite);
                SP.List oList = clientContext.Web.Lists.GetByTitle("Resource_Level");
                
                /** for "edit" function **/
                //ListItem oListItem = oList.GetItemById(title);

                /** Uncomment below code for "add" function **/
                ListItemCreationInformation itemCreateInfo = new ListItemCreationInformation();
                ListItem oListItem = oList.AddItem(itemCreateInfo);

                oListItem["Title"] = title;
                oListItem["Name"] = name;
                oListItem["Allowance"] = allowance;
                oListItem["Level"] = level;

                oListItem.Update();

                clientContext.ExecuteQuery();

                txttitle.Text = "";
                txtname.Text = "";
                txtallowance.Text = "";
                txtlevel.Text = "";

                lblmessage5.Text = "Data saved successfully";
                lblmessage4.Visible = false;
                lblmessage5.Visible = true;

            }
            catch (Exception ex)
            {
                lblmessage4.Text = ex.Message;
                lblmessage5.Visible = false;
                lblmessage4.Visible = true;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 selectedRowCount = gridlist.Rows.GetRowCount(DataGridViewElementStates.Selected);

                if (selectedRowCount > 1)
                    throw new Exception("Please select only one record");
                else if (selectedRowCount == 1)
                {
                    string ID = gridlist.SelectedRows[0].Index.ToString();

                    string value = gridlist.SelectedRows[0].Cells[1].Value.ToString();

                    ClientContext clientContext = new ClientContext(siteurl + "//" + subsite);
                    SP.List oList = clientContext.Web.Lists.GetByTitle("Resource_Level");
                    ListItem oListItem = oList.GetItemById(value);

                    oListItem.DeleteObject();

                    clientContext.ExecuteQuery();

                    lblmessage6.Text = "Data deleted succesfully";
                    lblmessage6.ForeColor = System.Drawing.Color.Green;
                    lblmessage6.Visible = true;

                    btnlist.PerformClick();
                }
                else
                    throw new Exception("Please select at least one record");
            }
            catch (Exception ex)
            {
                lblmessage6.Text = ex.Message;
                lblmessage6.ForeColor = System.Drawing.Color.Red;
                lblmessage6.Visible = true;
            }
        }
    }
}
