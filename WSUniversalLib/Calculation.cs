using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        public static int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            if (count < 0)
            {
                return -1;
            }
            double rezult = width * length * count;
            if (rezult < 0)
            {
                return -1;
            }

            switch (productType)
            {
                case 1:
                    {
                        rezult = rezult * 1.1;
                    }
                    break;
                case 2:
                    {
                        rezult = rezult * 2.5;
                    }
                    break;
                case 3:
                    {
                        rezult = rezult * 8.43;
                    }
                    break;
                default:
                    return -1;
            }

            switch (materialType)
            {
                case 1:
                    {
                        rezult += (rezult / 100) * 0.3;
                    }
                    break;
                case 2:
                    {
                        rezult += (rezult / 100) * 0.12;
                    }
                    break;
                default:
                    return -1;
            }

            return (int)Math.Round(rezult); //округляем
        }

    }

}
