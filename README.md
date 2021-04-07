# KeyStrokeLogger
This program is a key logger made for ethical reasons in use for penetration testing and grabbing keystrokes
It starts by grabing a exe at random from all the files in the subdirectory's of %appdata% it then hijacks that file and adds it self to startup it will then log all of the users keyboard inputs until its log file "Log.txt" hits a file size of 100000 bytes once this limit is hit it clears the file. this code can be expanded on by simply adding a function to send "Log.txt" its file where it logs all of the users keystrokes to a server.
