using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Model
{
    /// <summary>
    /// Diákok dolgozatának értékelése
    /// </summary>
    class StudentMark
    {
        /// <summary>
        /// A diák neve
        /// </summary>
        private string name;
        /// <summary>
        /// A diák dolgozatának ponteredménye
        /// </summary>
        private int point;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="eredmeny"></param>
        public StudentMark()
        {
            this.name = string.Empty;
            this.point = 0;
        }

        /// <summary>
        /// Diák név tulajdonsága amelyet a felhasználó ad meg
        /// </summary>
        public string Name
        {
        }

        /// <summary>
        /// Diák dolgozatban elért eredménye amit a felhasználó ad meg
        /// </summary>
        public int Point
        {
        }

        /// <summary>
        /// Az eredmény alapján a diák jegye
        /// </summary>
        public int Mark
        {
            get
            {
                if (point > 85)
                    return 5;
                else 
            }
        }


        /// <summary>
        /// Az elért eredmény alapján a szöveges értékelés
        /// </summary>
        public string MarkString
        {
            get
            {
                string markString = name + " diák ";
                switch (Mark)
                {
                }
                markString += " eredményt ért el.";
                return markString;
            }
        }
    }
}
