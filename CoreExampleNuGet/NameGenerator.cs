using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreExampleNuGet
{
    public class NameGenerator
    {
        public string GetName()
        {
            var random = new Random();

            switch (random.Next(1,5))
            {
                case 1:
                    return "Jean";
                case 2:
                    return "Pierre";
                case 3:
                    return "Jean-Pierre";
                case 4:
                    return "Jeannot";
                case 5:
                    return "Pierrot";
            }

            return "Unknown";
        }
    }
}
