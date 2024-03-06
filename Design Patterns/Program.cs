﻿//using Design_Patterns.Observer;
using Design_Patterns.Observer.Interfaces;
using Design_Patterns.Strategy;
using Design_Patterns.Strategy.Models;
using Design_Patterns.Template;
using System.Data;

namespace Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Observer
            //OnlineMarketPlace marketPlace = new OnlineMarketPlace();
            //ISubscribers ahmed = new Customer("Ahmed");
            //ISubscribers ali = new Customer("Ali");
            //ISubscribers mohamed = new Customer("Mohamed");

            //marketPlace.Subscribe(ahmed);
            //marketPlace.Subscribe(ali);

            //marketPlace.AddProduct(new Product("Iphone",100));
            //marketPlace.AddOffer(new Offer("new sale up to 50 %"));

            //marketPlace.UnSubscribe(ahmed);

            //marketPlace.AddOffer(new Offer("new sale up to 50 %"));
            #endregion

            #region Strategy

            //Product wallet = new Product("Wallet",100, new RegularPricingStrategy());
            //var walletPrice=  wallet.CalculatePrice();
            //Console.WriteLine(walletPrice);

            //Product jacket = new Product("JAcket",600, new GoldPricingStrategy());
            //var jacketPrice=  jacket.CalculatePrice();
            //Console.WriteLine(jacketPrice);

            #endregion

            #region Template
            //AbstractClass concrete1 = new Concorete1();
            //AbstractClass concrete2 = new Concrete2();

            //concrete1.TemplateMethod();
            //concrete2.TemplateMethod();
            #endregion


        }
    }
}
