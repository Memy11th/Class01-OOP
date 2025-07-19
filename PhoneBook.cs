using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class01_OOP
{
    internal struct PhoneBook
    {
        #region Attributes
        string[] Names;
        int[] PhoneNumero;
        int Size;
        #endregion

        #region Constructor 
            public PhoneBook(int size)
        {
            Size = size;
            Names = new string[Size];
            PhoneNumero = new int[Size];
        }
        #endregion

        #region Methods
            public void AddNewPerson(int Index,string Name,int Num)
        {
            Names[Index] = Name;
            PhoneNumero[Index] = Num;
        }
        #endregion
    }
}
