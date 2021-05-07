using System;
using System.Collections.Generic;
using System.Text;

namespace oop.model
{
    /// <summary>
    /// Diákok dolgozatának értékelése
    /// </summary>
    class DiakErtekeles
    {
        /// <summary>
        /// A diák neve
        /// </summary>
        private string nev;
        /// <summary>
        /// A diák dolgozatának eredménye
        /// </summary>
        private int eredmeny;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="eredmeny"></param>
        public DiakErtekeles()
        {
            this.nev = string.Empty;
            this.eredmeny = 0;
        }

        /// <summary>
        /// Diák név tulajdonsága amelyet a felhasználó ad meg
        /// </summary>
        public string Nev
        {
            set
            {
                nev = value;
            }
        }

        /// <summary>
        /// Diák dolgozatban elért eredménye amit a felhasználó ad meg
        /// </summary>
        public int Eredmeny
        {
            set
            {
                eredmeny = value;
            }
        }

        /// <summary>
        /// Az eredmény alapján a diák jegye
        /// </summary>
        public int Ertekeles
        {
            get
            {
                if (eredmeny > 85)
                    return 5;
                else if (eredmeny > 70)
                    return 4;
                else if (eredmeny > 55)
                    return 3;
                else if (eredmeny > 40)
                    return 2;
                else
                    return 1;
            }
        }


        /// <summary>
        /// Az elért eredmény alapján a szöveges értékelés
        /// </summary>
        public string SzovegesErtekeles
        {
            get
            {
                string szovegesErtkeles = nev + " diák ";
                switch (Ertekeles)
                {
                    case 5:
                        szovegesErtkeles += "jeles";
                        break;
                    case 4:
                        szovegesErtkeles += "jó";
                        break;
                    case 3:
                        szovegesErtkeles += "közepes";
                        break;
                    case 2:
                        szovegesErtkeles += "elégséges";
                        break;
                    case 1:
                        szovegesErtkeles += "elégtelen";
                        break;
                }
                szovegesErtkeles += " eredményt ért el.";
                return szovegesErtkeles;
            }
        }
    }
}
