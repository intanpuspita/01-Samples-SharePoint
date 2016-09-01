#This works on SharePoint Online sites!

$loadInfo1 = [System.Reflection.Assembly]::LoadWithPartialName("Microsoft.SharePoint.Client")
$loadInfo2 = [System.Reflection.Assembly]::LoadWithPartialName("Microsoft.SharePoint.Client.Runtime")
$webUrl = Read-Host -Prompt "HTTPS URL for your SP Online 2013 site" #"https://my365trial.sharepoint.com"
$username = Read-Host -Prompt "Email address for logging into that site" #intanpuspita@my365trial.onmicrosoft.com"
$password = Read-Host -Prompt "Password for $username" -AsSecureString


$ctx = New-Object Microsoft.SharePoint.Client.ClientContext($webUrl)
$ctx.Credentials = New-Object Microsoft.SharePoint.Client.SharePointOnlineCredentials($username, $password)
$web = $ctx.Web
$lists = $web.Lists
$ctx.Load($lists)
$ctx.ExecuteQuery()

$lists| select -Property Title