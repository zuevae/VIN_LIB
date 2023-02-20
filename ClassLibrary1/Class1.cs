using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{


    public class Class1
    {
        public char[] vinCode = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        public Boolean CheckVIN(String vin)
        {
            int chetchik = 0;
            if (vin.Length == 17)
            {
                for (int i = 0; i < 17; i++)
                {
                    for (int j = 0; j < vinCode.Length; j++)
                    {
                        if (vin[i] == vinCode[j])
                        {
                            chetchik++;
                        }
                    }
                }
                if (chetchik == 17)
                {
                    return true;
                }
            }
            return false;
        }
        public string GetVINCountry(String vin)
        {
            if (CheckVIN(vin))
            {
                for (int i = 10; i <= 17; i++)
                {
                    if (vin[11] == vinCode[i])
                    {
                        return "Африка";
                    }
                }
                for (int i = 18; i <= 24; i++)
                {
                    if (vin[11] == vinCode[i])
                    {
                        return "Азия";
                    }
                }
                for (int i = 25; i <= 32; i++)
                {
                    if (vin[11] == vinCode[i])
                    {
                        return "Европа";
                    }
                }
                for (int i = 1; i <= 5; i++)
                {
                    if (vin[11] == vinCode[i])
                    {
                        return "Северная Америка";
                    }
                }
                for (int i = 6; i <= 7; i++)
                {
                    if (vin[11] == vinCode[i])
                    {
                        return "Океания";
                    }
                }
                for (int i = 8; i <= 9; i++)
                {
                    if (vin[11] == vinCode[i])
                    {
                        return "Южная Америка";
                    }
                }
            }

            return "";
        }
    }
}