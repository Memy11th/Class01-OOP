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
            if (Name is not null && PhoneNumero is not null)
            {
                if (Index <= 0 && Index < Names.Length)
                {
                    Names[Index] = Name;
                    PhoneNumero[Index] = Num;
                }
            }
            
        }

            // Getter Fn
            public int GetPhoneNum(string Name)
        {
            if(Name is not null && PhoneNumero is not null)
                for(int i = 0; i < Names.Length; i++)
                    if (Names[i] == Name)       
                        return PhoneNumero[i];
            return -1;
        }

            // Setter Fn 
            public int SetPhoneNum(string Name,int Num)
        {
            if (Name is not null && PhoneNumero != null)
                for (int i = 0; i < Names.Length; i++)
                    if (Names[i] == Name)
                    {
                        PhoneNumero[i] = Num;
                        return PhoneNumero[i];
                    }
            return -1;
        }
        #endregion

        #region Properties

            // Adding indexer property " Special property " .. deal with Object as if its array
            public int this[string Name]{
              get{
                if (Name is not null && PhoneNumero is not null)
                    for (int i = 0; i < Names.Length; i++)
                        if (Names[i] == Name)
                            return PhoneNumero[i];
                return -1;
            }
             }

        #endregion
    }
}
