using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBatiment
{
    internal class House : Building
    {
        #region Attribute
        private int _nbRoom;
        #endregion
        #region Get & Set NbRoom
        public int NbRoom { get => _nbRoom; set => _nbRoom = value; }
        #endregion
        #region Constructor
        public House()
        {
        }
        public House(string adresse, int nbRoom) : base(adresse)
        {
            NbRoom = nbRoom;
        }
        #endregion
        #region Method
        public void ToString()
        {
            Console.WriteLine($"L'adresse est : {Adresse}");
            Console.WriteLine($"Le nombre de piéce est : {NbRoom}");
        } 
        #endregion
    }
}
