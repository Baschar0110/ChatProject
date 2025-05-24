using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ChatingSystem
{
    class DBcontroller
    {
        public static bool AccountChecker(string name, string pw)
        {
            string pfad = "H:/NEW/ChatingSystem1/Login.txt"; // Pfad zur Datei
            try
            {
                using (StreamReader datei = new StreamReader(pfad))
                {
                    string zeile;
                    while ((zeile = datei.ReadLine()) != null)
                    {
                        string[] teile = zeile.Split(';');   
                        if (teile.Length == 2)
                        {
                            string dateiNickname = teile[0].Trim();
                            string dateiPasswort = teile[1].Trim();

                            if (name == dateiNickname && pw == dateiPasswort)
                            {
                                return true; // Erfolg
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Lesen der Datei: {ex.Message}");
            }
            return false; // Fehlschlag
        }
    }
}
    

