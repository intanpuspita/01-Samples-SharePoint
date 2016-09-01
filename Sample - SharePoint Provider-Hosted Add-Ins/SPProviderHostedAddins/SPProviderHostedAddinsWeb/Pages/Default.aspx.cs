using Microsoft.IdentityModel.S2S.Tokens;
using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.UI.WebControls;
using System.Xml;

namespace SPProviderHostedAddinsWeb
{
    public partial class Default : System.Web.UI.Page
    {
        SharePointContextToken contextToken;
        string accessToken;
        Uri sharepointUrl;
        string siteName;
        string currentUser;
        List<string> listOfUsers = new List<string>();
        List<string> listOfLists = new List<string>();

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Uri redirectUrl;
            switch (SharePointContextProvider.CheckRedirectionStatus(Context, out redirectUrl))
            {
                case RedirectionStatus.Ok:
                    return;
                case RedirectionStatus.ShouldRedirect:
                    Response.Redirect(redirectUrl.AbsoluteUri, endResponse: true);
                    break;
                case RedirectionStatus.CanNotRedirect:
                    Response.Write("An error occurred while processing your request.");
                    Response.End();
                    break;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string contextTokenString = TokenHelper.GetContextTokenFromRequest(Request);

            if (contextTokenString != null)
            {
                contextToken = TokenHelper.ReadAndValidateContextToken(contextTokenString, Request.Url.Authority);
                sharepointUrl = new Uri(Request.QueryString["SPHostUrl"]);
                accessToken = TokenHelper.GetAccessToken(contextToken, sharepointUrl.Authority).AccessToken;

                // For simplicity, this sample assigns the access token to the button's CommandArgument property. 
                // In a production add-in, this would not be secure. The access token should be cached on the server-side.
                CSOM.CommandArgument = accessToken;
            }
            else if (!IsPostBack)
            {
                Response.Write("Could not find a context token");
                return;
            }
        }

        private void RetrieveWithCSOM(string accessToken)
        {
            if (IsPostBack)
            {
                sharepointUrl = new Uri(Request.QueryString["SPHostUrl"]);
            }

            ClientContext cc = TokenHelper.GetClientContextWithAccessToken(sharepointUrl.ToString(), accessToken);

            //Load the properties for the web object
            Web web = cc.Web;
            cc.Load(web);
            cc.ExecuteQuery();

            //Get the site name
            siteName = web.Title;

            //Get the current user
            cc.Load(web.CurrentUser);
            cc.ExecuteQuery();
            currentUser = cc.Web.CurrentUser.LoginName;

            //Load the lists from the web object
            ListCollection lists = web.Lists;
            cc.Load<ListCollection>(lists);
            cc.ExecuteQuery();

            //Load the current users from the web object
            UserCollection users = web.SiteUsers;
            cc.Load<UserCollection>(users);
            cc.ExecuteQuery();

            foreach (User siteuser in users)
            {
                listOfUsers.Add(siteuser.LoginName);
            }

            foreach (List list in lists)
            {
                listOfLists.Add(list.Title);
            }
        }

        protected void CSOM_Click(object sender, EventArgs e)
        {
            string commandAccessToken = ((LinkButton)sender).CommandArgument;
            RetrieveWithCSOM(commandAccessToken);
            WebTitleLabel.Text = siteName;
            CurrentUserLabel.Text = currentUser;
            UserList.DataSource = listOfUsers;
            UserList.DataBind();
            ListList.DataSource = listOfLists;
            ListList.DataBind();
        }
    }
}