# Deploy C# Web Application to Amazon Web Services (AWS)


Must need
--------------
- DotNetCore CLI
- Elastic Beanstalk CLI

How to deploy 
----------------

 - Open <strong>Bash</strong> (if you have Mac or Linux) or <strong>PowerShell</strong> (if you have Windows)
 - Go to your project folder (where the Program.cs is)
 - `dotnet publish -o foldername`
    - Choose something meaningful
 - Zip the published app
    - Worth to give the same name as the folder has
    - PowerShell:
	    - `Compress-Archive ./foldername/* name.zip`
    - Bash:
	    - `zip -r name.zip ./foldername/*`

 - Create an aws-windows-deployment-manifest.json
    - PowerShell:
	    - `code aws-windows-deployment-manifest.json`
- It requires to have Visual Studio Code installed
    - Bash:
	    - `vim aws-windows-deployment-manifest.json`
- Copy the below code snippet in the recently created file
    - "name": could be anything
    - "appBundle": <strong>must be the same as you named your zip earlier</strong>

```json
{
    "manifestVersion": 1,
    "deployments": {
        "aspNetCoreWeb": [
        {
            "name": "dotnet-core",
            "parameters": {
                "appBundle": "foldername.zip",
                "iisPath": "/",
                "iisWebSite": "Default Web Site"
            }
        }
        ]
    }
}
```

 - `eb init -p IIS10.0`
     - or just `eb init` & choose <strong>IIS</strong> & choose <strong>10.0</strong>
 - Choose a region
 - `eb create environmentname`
    - Choose something meaningful environment name i.e. <strong>"dev-env"</strong>
 - Wait! "It may take a while"
 - ![what you should see](https://lh3.googleusercontent.com/-yF8RZGHFQDQ/WiUlhjMQWMI/AAAAAAAAFLE/V5502hH5JgEDnJbMc459y5BIwXAITIVEwCLcBGAs/s0/successfull_deploy.PNG "successfull_deploy.PNG")
 - If you want to deploy a new version
    - You need to run `dotnet publish -o foldername` again (same foldername as earlier)
    - Zip it again just like first time
    - `eb deploy`
