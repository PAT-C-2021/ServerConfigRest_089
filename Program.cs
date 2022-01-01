using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ServiceRest_20190140089_Prasetyo_Nur_Hidayat;

namespace ServerConfigRest_20190140089_PrasetyoNurHidayat
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObj = null;

            try
            {
                hostObj = new ServiceHost(typeof(TI_UMY));
                hostObj.Open();
                Console.WriteLine("Server Ready!");
                Console.ReadLine();
                hostObj.Close();
            }

            catch (Exception e)
            {
                hostObj = null;
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
