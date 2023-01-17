using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBatiment
{
    internal class Building
    {
        #region Attribute
        private string _adresse;
        #endregion
        #region Constructor
        public Building()
        {
        }
        public Building(string adresse)
        {
            Adresse = adresse;
        }
        #endregion
        #region Get & Set Adress
        public string Adresse { get => _adresse; set => _adresse = value; }
        #endregion
        #region Method
        public void ToString()
        {
            Console.WriteLine($"L'adresse du batiment est : {Adresse}");
        } 
        #endregion
    }
}
