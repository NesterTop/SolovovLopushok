using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        
        private int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            try
            {
                float p = width * length;
                float result = p * productType + materialType;

                return (int)result;
            }

            catch
            {
                return 0;
            }
        }

        public bool CheckGetQuantity(int productType, int materialType, int count, float width, float length)
        {
            int result = GetQuantityForProduct(productType, materialType, count, width, length);

            if (result != 0) return true;
            else return false;
        }
    }
}
