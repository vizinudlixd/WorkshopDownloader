Plain workshop downloader made in an hour or so, use it in another project if you want

Works with one or multiple links (hit enter after each link)


1. Create a directory called steamcmd here WorkshopDownloader\bin\Debug\net7.0-windows
   Download SteamCMD and put it inside the steamcmd folder
2. Write your specific game's App ID to the textbox (for example Project zomboid= 108600, Cities:Skylines= 255710)
3. Put the raw links into the workshop link, if you are done with that hit format and if the second column only contains the numbers of the workshop mod hit download

It will open steamcmd, and download every link 1 by 1.
After it's done you can check the downloaded mods here:
WorkshopDownloader\bin\Debug\net7.0-windows\steamcmd\steamapps\workshop\content\<your appid>


Tested with project zomboid and cities:skylines (not working with anonymous login)


<b>Note that it won't work with certain games with logging in as anonymous since some of them requires to login with an account that owns the game
