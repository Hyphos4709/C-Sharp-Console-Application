# C-Sharp-Console-Application
Here is a console application that uses ascii art to create a UI that allows users to navigate through a list of options and enter values. 


So what have I done here and why do I find it really fun to talk about?

Heres the story, 

In our MVC section of the coding bootcamp I was in. We were tasked with creating a C# console application that would receive 4 values from the user and then return the average (as review before diving into the wonders of MVC!). After creating an initial version that simply asked the user for information, and then displayed the average, line by line working down. I came up with the idea to actually use ASCII art to create a grid of characters and manipulate them based on user input to provide a simple way to enter in the scores. 

In my main method function are the actual loops and switch/if statements that receive input from the user and allow them to navigate through the panel, manipulating scores as they work their way through. 

The rest of the application is used to format the ascii art into arrays with 6 string values each. These values (as each individual ascii art is 6 characters high no matter what but the width varies) would then allow me to concatenate the 0 index string of one ascii art to the 0 index string of another (as the console prints line by line). Then you would print the 1 index of both ascii arts, then the 2nd, and so on till you reach six and you ended up with a nicely printed ascii art section such as this...

 _______________________________________________________________________________________________________
|_______________________________________________________________________________________________________|
 |||  ______                          __                             |||                             |||    __
 ||| |  ____|                        /_ | _                          |||                             |||   / /
 ||| | |__   __  __ __ _  _ __ ___    | |(_)                         |||                             |||  / /
 ||| |  __|  \ \/ // _` || '_ ` _ \   | |                            |||                             ||| < <
 ||| | |____  >  <| (_| || | | | | |  | | _                          |||                             |||  \ \
 ||| |______|/_/\_\\__,_||_| |_| |_|  |_|(_)                         |||                             |||   \_\
 |||_________________________________________________________________|||_____________________________|||
 |||  __  __  _      _  _                                            |||                             |||
 ||| |  \/  |(_)    | || |                         _                 |||                             |||
 ||| | \  / | _   __| || |_  ___  _ __  _ __ ___  (_)                |||                             |||
 ||| | |\/| || | / _` || __|/ _ \| '__|| '_ ` _ \                    |||                             |||
 ||| | |  | || || (_| || |_|  __/| |   | | | | | | _                 |||                             |||
 ||| |_|  |_||_| \__,_| \__|\___||_|   |_| |_| |_|(_)                |||                             |||
 |||_________________________________________________________________|||_____________________________|||
 |||  ______                          ___                            |||                             |||
 ||| |  ____|                        |__ \  _                        |||                             |||
 ||| | |__   __  __ __ _  _ __ ___      ) |(_)                       |||                             |||
 ||| |  __|  \ \/ // _` || '_ ` _ \    / /                           |||                             |||
 ||| | |____  >  <| (_| || | | | | |  / /_  _                        |||                             |||
 ||| |______|/_/\_\\__,_||_| |_| |_| |____|(_)                       |||                             |||
 |||_________________________________________________________________|||_____________________________|||
 |||  ______  _                _   ______                            |||                             |||
 ||| |  ____|(_)              | | |  ____|                        _  |||                             |||
 ||| | |__    _  _ __    __ _ | | | |__   __  __ __ _  _ __ ___  (_) |||                             |||
 ||| |  __|  | || '_ \  / _` || | |  __|  \ \/ // _` || '_ ` _ \     |||                             |||
 ||| | |     | || | | || (_| || | | |____  >  <| (_| || | | | | | _  |||                             |||
 ||| |_|     |_||_| |_| \__,_||_| |______|/_/\_\\__,_||_| |_| |_|(_) |||                             |||
 |||_________________________________________________________________|||_____________________________|||
 
 
 Using my system for printing ascii art to the console I was able to take user commands, clear the console, and print a new version that represented what the user was trying to do. for instance moving the arrow up and down, and entering in percents for the test scores. 
 
  _______________________________________________________________________________________________________
|_______________________________________________________________________________________________________|
 |||  ______                          __                             |||                             |||
 ||| |  ____|                        /_ | _                          |||                             |||
 ||| | |__   __  __ __ _  _ __ ___    | |(_)                         |||                             |||
 ||| |  __|  \ \/ // _` || '_ ` _ \   | |                            |||                             |||
 ||| | |____  >  <| (_| || | | | | |  | | _                          |||                             |||
 ||| |______|/_/\_\\__,_||_| |_| |_|  |_|(_)                         |||                             |||
 |||_________________________________________________________________|||_____________________________|||
 |||  __  __  _      _  _                                            |||                             |||
 ||| |  \/  |(_)    | || |                         _                 |||                             |||
 ||| | \  / | _   __| || |_  ___  _ __  _ __ ___  (_)                |||                             |||
 ||| | |\/| || | / _` || __|/ _ \| '__|| '_ ` _ \                    |||                             |||
 ||| | |  | || || (_| || |_|  __/| |   | | | | | | _                 |||                             |||
 ||| |_|  |_||_| \__,_| \__|\___||_|   |_| |_| |_|(_)                |||                             |||
 |||_________________________________________________________________|||_____________________________|||
 |||  ______                          ___                            |||   ___    ___   _   __       |||    __
 ||| |  ____|                        |__ \  _                        |||  / _ \  / _ \ (_) / /       |||   / /
 ||| | |__   __  __ __ _  _ __ ___      ) |(_)                       ||| | (_) || (_) |   / /        |||  / /
 ||| |  __|  \ \/ // _` || '_ ` _ \    / /                           |||  \__, | \__, |  / /         ||| < <
 ||| | |____  >  <| (_| || | | | | |  / /_  _                        |||    / /    / /  / / _        |||  \ \
 ||| |______|/_/\_\\__,_||_| |_| |_| |____|(_)                       |||   /_/    /_/  /_/ (_)       |||   \_\
 |||_________________________________________________________________|||_____________________________|||
 |||  ______  _                _   ______                            |||                             |||
 ||| |  ____|(_)              | | |  ____|                        _  |||                             |||
 ||| | |__    _  _ __    __ _ | | | |__   __  __ __ _  _ __ ___  (_) |||                             |||
 ||| |  __|  | || '_ \  / _` || | |  __|  \ \/ // _` || '_ ` _ \     |||                             |||
 ||| | |     | || | | || (_| || | | |____  >  <| (_| || | | | | | _  |||                             |||
 ||| |_|     |_||_| |_| \__,_||_| |______|/_/\_\\__,_||_| |_| |_|(_) |||                             |||
 |||_________________________________________________________________|||_____________________________|||

So the only commands that are available are up arrow, down arrow, and enter. I did not add a try catch or a loop to prepare it for alternate keys (as I'd spent way to much time on this at the end of finishing what you see and needed to move on) so pushing anything else when outside of an exam(arrow visible) will break the application. Once insde it is set to receive other commands and not break, only allowing exam scores of 0% - 100%. And once back outside you can move up and down and change the other scores. 

I had a lot of fun building this and it was as far as I intend to go into a c# application. However I really wanted to share it because I thought someone else might find it interesting and learn something form it. If you have any questions after going through the code and playing with the app feel free to ask and I will respond as quick as possible(from lack of documention in code I'm sure you will)

Thanks for checking it out!
