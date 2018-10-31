using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgengryNEW
{
    public class MerchandiseRepository
    {
        List<Merchandise> merchandiseList = new List<Merchandise>();
        public void AddMerchandise(Merchandise merchandise)
        {
            merchandiseList.Add(merchandise);
        }

        public Merchandise GetMerchandise(string itemId)
        {
            Merchandise merchanDise = null;
            for (int i = 0; i < merchandiseList.Count; i++)
            {
                if (merchandiseList[i].ItemId == itemId)
                {
                    merchanDise = merchandiseList[i];
                }
            }
            return merchanDise;
        }

        public static double GetValueOfMerchandise(Merchandise merchandise)
        {
            double totalValue = 0.0;
            Book bookMerch;
            if(merchandise is Book)
            {
                bookMerch = (Book)merchandise;
                totalValue = bookMerch.Price;
            }
            

            if (merchandise is Amulet)
            {
                Amulet amuletMerch;
                amuletMerch = (Amulet)merchandise;
                Level q = amuletMerch.Quality;
                    if (q == Level.low)
                    {
                    totalValue = 12.5;

                    }

                    else if (q == Level.medium)
                    {
                        totalValue = 20.0;
                    }

                    else
                    {
                        totalValue = 27.5;
                    }
            }

            return totalValue;
        }
    }
}
