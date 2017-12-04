# Deploy C# Web Application to Amazon Web Services (AWS)


Must need
--------------
- DotNetCore CLI
- Elastic Beanstalk CLI

How to deploy 
----------------

 - Open Bash or PowerShell. Go to your project folder (where the Program.cs is)
    - You can have real Bash (not just Git Bash) on Windows 10 (<a href="https://msdn.microsoft.com/en-us/commandline/wsl/install-win10">Linux subsystem</a>)
 - `dotnet publish -o foldername`
    - Choose something meaningful
    - Same in PowerShell & Bash
 - Zip the published app
    - Worth to give the same name as the folder has
    - From File Explorer
	    - Go to the recently created folder
	    - Choose all files
	    - Right click / Add to Archive
	    - The destination folder must be your project folder (you know Program.cs)
	    - ![how it should look like at the end](https://lh3.googleusercontent.com/-JXPKTFAZ22jlUgPfpi4MEdZ6Y5ojV6Aqds_nEtiZSNRQk092hH9BBr0kKdmdp4UKfANsXK8_DmV=s0 "zip.jpg")
    - In PowerShell
	    - Do not go anywhere
	    - `Compress-Archive ./foldername/* name.zip`
    - In Linux Bash:
	    - Do not go anywhere 
	    - `zip -r name.zip ./foldername/*`

 - Create an aws-windows-deployment-manifest.json
- In Bash: `vim aws-windows-deployment-manifest.json`
- In PowerShell: `code aws-windows-deployment-manifest.json`
    - It requires to have Visual Studio Code installed
- Copy the below code snippet in the JSON file
    - "name": could be anything
    - "appBundle": must be the same as you named your zip earlier

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

 - `eb init -p IIS10.0
     - or just `eb init`
     - choose IIS
     - choose 10.0
 - Choose a region
 - `eb create environmentname`
    - Choose something meaningful environment name i.e. "dev-env"
 - Wait! "It may take a while"
 - If you want to deploy a new version
    - You need to run `dotnet publish -o foldername` again (same foldername as earlier)
    - Zip it again just like first time
    - `eb deploy`
