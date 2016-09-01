Add-Type -Path "C:\Program Files\Common Files\microsoft shared\Web Server Extensions\15\ISAPI\Microsoft.SharePoint.Client.dll"  
Add-Type -Path "C:\Program Files\Common Files\microsoft shared\Web Server Extensions\15\ISAPI\Microsoft.SharePoint.Client.Runtime.dll"  
  
$siteURL = "https://my365trial.sharepoint.com"  
$userId = "intanpuspita@my365trial.onmicrosoft.com"  
$pwd = Read-Host -Prompt "Enter password" -AsSecureString  
$creds = New-Object Microsoft.SharePoint.Client.SharePointOnlineCredentials($userId, $pwd)  
$ctx = New-Object Microsoft.SharePoint.Client.ClientContext($siteURL)  
$ctx.credentials = $creds  
try{  
	$lists = $ctx.web.Lists  
	$list = $lists.GetByTitle("Ingredients")  
	$listItems = $list.GetItems([Microsoft.SharePoint.Client.CamlQuery]::CreateAllItemsQuery()) 
	$ctx.load($listItems)  
	  
	$ctx.executeQuery()  
	foreach($listItem in $listItems)  
	{  
		Write-Host "ID - " $listItem["ID"] "Title - " $listItem["Title"]  
	} 
}  
catch{  
	write-host "$($_.Exception.Message)" -foregroundcolor red  
}  