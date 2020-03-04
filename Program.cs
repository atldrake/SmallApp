using System;
using System.Collections.Generic;

namespace SmallApp
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Promoter> promoters = new List<Promoter>(){new XSClubPromoter("Sarah", "Cobbinah", 0544669121), new XSClubPromoter("Sawda", "Is-haq", 0507326713), new OmniaClubPromoter("Firm","Tech", 0200271515)};
           foreach (var promoter in promoters)
           {
               promoter.Promote();
           }
           List<Writer> writers = new List<Writer>(){new BookWriter("Sarah", "Cobbinah"), new BookWriter("Sawda", "Is-haq"), new BlogWriter("Firm","Tech")};
           foreach (var writer in writers)
           {
               writer.Write();
           }
           List<IBodyBuilder> bodyBuilders = new List<IBodyBuilder>(){new XSClubPromoter("Sarah", "Cobbinah", 0544669121), new XSClubPromoter("Sawda", "Is-haq", 0507326713)};
           foreach (var bodyBuilder in bodyBuilders)
           {
               bodyBuilder.Workout();
           }
           List<IVlogger> vloggers  = new List<IVlogger>(){new XSClubPromoter("Sarah", "Cobbinah", 0544669121), new BookWriter("Sawda", "Is-haq")};
           foreach (var vlogger in vloggers)
           {
               vlogger.Vlog();
           }

        }
    }
}
