using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgengryNEW
{
    public class Utility
    {
        public static double GetValueOfBook(Book book)
        {            
            double bookvalue = book.Price;
            return bookvalue;
        }
        public static double GetValueOfAmulet(Amulet amulet)
        {
            Level q = amulet.Quality;
            if (q == Level.low)
            {
                return 12.5;
            }

            else if (q == Level.medium)
            {
                return 20.0;
            }

            else
            {
                return 27.5;
            }
        }
        public static double GetValueOfCourse(Course course)
        {
            int time = 0;
            for (int i = 0; i < course.DurationInMinutes; i+=60)
            {
                time++;
            }
            return time * 875;

            //for (courseTime > 0.0)
            //{
            //    if ()
            //    {
            //        courseTime = 875.00 * time;
            //    }
            //    time++;
            //}
            //return courseTime;
        }
    }
}
