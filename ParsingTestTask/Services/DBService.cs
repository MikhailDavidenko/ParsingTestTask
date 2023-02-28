using Microsoft.EntityFrameworkCore;
using ParsingTestTask.Model;

namespace ParsingTestTask.Services
{
    public class DBService
    {
        private ApplicationContext context;
        public DBService(ApplicationContext context)
        {
            this.context = context;
        }
        public bool CheckOffer()
        {
            return context.Offer.Any();
        }
        public Offer GetOffer()
        {
            return context.Offer.FirstOrDefault();
        }
        public void AddOffer(Offer offer)
        {
            context.Offer.Add(offer);
            context.SaveChanges();
        }
    }
}
