using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bollywood.Desktop;
using Bollywood.Database;
using Bollywood.Entities; 

namespace Bollywood.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Mydatabase db = new Mydatabase())
            {
                var directors = db.Directors;
                foreach (var director in directors)
                {
                    Console.WriteLine(director.LastName);
                }

            }
        }
    }
}
