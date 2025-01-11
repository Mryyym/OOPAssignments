using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignment
{
    struct PhoneBook
    {
        string[] names;
        long[] numbers;
        int size;

        public int Size
        {
            get { return size; }
        }

        //to get  person number by his namee
        public long getPersonNum(string Name)
        {
            if(names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (Name == names[i]) return numbers[i];
                }
            }
           return 0;
        }


        //to set  person number by his namee

        public void setPrsonNum(string Name, long Num)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (Name == names[i])
                    {
                        numbers[i] = Num;
                        return;
                    }
                }
            }
        }


        #region INDEXER

        public long this[string Name]
        {
            get
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name == names[i]) return numbers[i];
                    }
                }
                return 0;
            }
            set
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name == names[i])
                        {
                            numbers[i] = value;
                            return;
                        }
                    }
                }
            }
        }

        public string this[int index]
        {
            get { return $"{index} - {names[index]} - {numbers[index]}"; }
        }

        #endregion
        ///constructor
        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }

        public void AddPerson(int position, string name, long num)
        {
            {
                if (names is not null && numbers is not null)
                {
                    if (position >= 0 && position < size)
                    {
                        names[position] = name;
                        numbers[position] = num;
                    }
                }
            }


        } 
        
    }


        
}
