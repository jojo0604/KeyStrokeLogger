# KeyStrokeLogger
This program is a key logger made for ethical reasons in use for penetration testing and grabbing keystrokes.
It starts by searching for a exe in %appdata% and its subdirectories, then it hijacks that exe and adds it self to execute on startup. It then logs all of the users keyboard inputs in "Log.txt", once the file hits a file size of 100000 bytes it Decrypt the logs and send a email containing that data then will delete the decrypted logs and clear the "Logs.txt" file.
