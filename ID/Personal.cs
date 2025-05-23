using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ID
{
    public class Personal
    {
        private string idNo;

        public string id_No
        {
            set
            {
                bool isNum = true;

                if(value.Length == 11)
                {
                    for(int i = 0; i < value.Length; i++)
                    {
                        isNum = char.IsNumber(value[i]);

                        if (!isNum) 
                        {
                            break;
                        }
                    }

                    if (!isNum)
                    {
                        Console.WriteLine("Please enter numbers!");
                    }
                    else
                    {
                        idNo = value;
                    }
                }

                else
                {

                    Console.WriteLine("Enter 11 characters!");
                }
            }


            get
            {
                if (idNo != null)
                {
                    return idNo.Substring(0, 5) + "******";
                }
                else
                {
                    return "Invalid id";
                }
            }
        }
    }
}
