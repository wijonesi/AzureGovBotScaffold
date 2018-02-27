This lab assumes you have Visual Studio 2015 (or later) installed.

Goals for this lab:

•	Download the Azure Bot Framework scaffold project from GitHub
•	Download the Bot Emulator for testing
•	Configure the Q&A Maker database
•	Deploy your first Bot to Azure

DOWNLOADING THE SCAFFOLD PROJECT

The latest codebase for the Bot Framework scaffold project is hosted in GitHub.

GitHub URL: https://github.com/wijonesi/AzureGovBotScaffold

Click the Clone or download link, then select Download ZIP and save the file to your local workstation.
Extract all files to a folder on your workstation.
 
DOWNLOAD THE BOT EMULATOR

1.	Point your browser to https://github.com/Microsoft/BotFramework-Emulator/releases/tag/v3.5.35, and download and install the botframework-emulator-Setup-3.5.35.exe file.

2.	To test you bot locally, run the Visual Studio project in debug mode, and point the emulator to http://localhost:3979/api/messages


CONFIGURE THE Q&A MAKER DATABASE

1.	Point your browser to http://qnamaker.ai and sign in using your HackFest credentials.
 
2.	Click Create New Service
 
3.	Provide a name for your service, and enter a URL to a known FAQ page, then click Create.
 
4.	Verify your FAQ page has been ingested into the Q&A database, then click Publish.
 
5.	On the next page, click Publish again.
 
6.	You will need both the KnowledgebaseID (top GUID) and SubscriptionKey (bottom key) to plug into your Visual Studio project (GeneralQnAMakerDialog.cs)
 
7.	In your Visual Studio project, open the GeneralQnAMakerDialog.cs file, and plug in the KnowledgebaseID and SubscriptionKey to the parameters in the object instantiation.
 

DEPLOY YOUR BOT TO AZURE

Your bot will be deployed to Azure as a Web App, which falls under the Platform-as-a-Service (PaaS) category, meaning that you do not need to stand up a virtual machine, manage the OS, or install IIS!

1.	From Visual Studio, click the Build menu, and click Publish… Select the Microsoft Azure App Service option, select Create New, then click Publish.
 
2.	Ensure you are signed in, give your service a unique name, select an existing Resource Group, then click New… next to the App Service Plan.
 
3.	Give your App Service Plan a unique name, choose USGov Arizona as the Location, and choose the S1 (1 core, 1.75 GB RAM) Size, then click OK.
 
4.	Click Create and Visual Studio will now publish your project directly to Azure, which will take a few minutes. From this point forward, Visual Studio will remember your publish settings and deploy directly to Azure without any additional configuration.

5.	Once published, a browser will launch and open the location of your newly publish bot, which will look something like http://YOURSERVICE.azurewebsites.us/
a.	This URL can now be used with your Bot Emulator by copying and pasting it into the blue bar at the top of the emulator, and appending api/messages
