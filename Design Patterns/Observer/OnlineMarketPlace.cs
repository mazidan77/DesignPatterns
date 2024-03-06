using Design_Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer
{
    public class OnlineMarketPlace
    {
        public List<ISubscribers> Subscribers { get; set; } = new List<ISubscribers>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Offer> Offers { get; set; } = new List<Offer>();


        public void Subscribe (ISubscribers subscriber)
        {
            Subscribers.Add(subscriber);
        } 
        
        public void UnSubscribe (ISubscribers subscriber)
        {
            Subscribers.Remove(subscriber);
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
            NotifySubscriber($"new product added {product.Name} at{product.Price} EGP");

        } 
        
        public void AddOffer(Offer offer)
        {
            Offers.Add(offer);
            NotifySubscriber($"new offer added {offer.Message} ");

        }

        private void NotifySubscriber(string Message)
        {
            foreach (var subsciber in Subscribers)
            {
                subsciber.Notify(Message);

            }

        }



    }
}
