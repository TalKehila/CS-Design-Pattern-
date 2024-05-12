using Desing_Patterns.Abstract_Factory;
using Desing_Patterns.Strategy;

//Single TONE PROGRAM!!!!


//SingleTone obj = SingleTone.Instance();
//SingleTone obj2 = SingleTone.Instance();

//if (obj == obj2)
//{
//    Console.WriteLine("these obj are the same"); // the should be the same even they another instance and object 
//}
//int val = 0;




// FACTORY 

//Ping ping = new Ping();  //we dont need make insance from specpic class becouse we use INetwork interface

//NetwordFactory factory = new NetwordFactory();
//var ping = factory.GetNetworkInstance("ping");
//var dns = factory.GetNetworkInstance("dns");
//var arp = factory.GetNetworkInstance("arp");

//ping.SendRequsest("232232", 4);
//dns.SendRequsest("24534232", 5);
//arp.SendRequsest("23212121232", 7);



//FACADE 
//NetwordFacade networkFacade = new NetwordFacade("8.8.8.8" ,"UDP");
//networkFacade.BuildNetworkLayer();
//networkFacade.SendPacketOverNetwork();




//ADAPTER PATTERN 
//INetworkClient network = new NetworkClient();
//network.SendRequest("5.5.5.5");

//IDataProccessor dataProc= new DataProccessor();
//dataProc.SendNetWorkRequest("6.5.4.3.3", "34f2f3e");

//NetworkDatapter adapter = new NetworkDatapter(dataProc);// need to implement interface
//adapter.SendRequest("7,7,7,7");





//PROXY PATTERN
//ISuperSecretDB database = new SuperSecretDBProxy("testdb","passwod");
//database.DisplayDatabaseName();






//CHAIN of responsivility

//Ichain obj1 = new SendSSH();
//Ichain obj2 = new SendPing();
//Ichain obj3 = new SendARP();
//// if we dont set them we cant next beocuse we dont know who is the object 
//obj1.SetNext(obj2);
//obj2.SetNext(obj3);
//NetworkModel request = new NetworkModel("8.8.8.8", false);
//obj1.SendRequest(request);





//Strategy PATTERN 
//Context contextARP = new Context(new AARP());
//Context contextPING = new Context(new PPing());
//Context contextDNS = new Context(new DDns());

//contextARP.ExecuteStrategy();
//contextPING.ExecuteStrategy();
//contextDNS.ExecuteStrategy();





//ABSTRACT FACTORY
// to look at interface movement ad look at Class weapon !!!!!!!!!
//Hero h = new HeroElf();
//Hero h2 = new DwarfHero();
////h2.DisplayInfo();
////h.DisplayInfo();

//List<Hero> heroes = new List<Hero> { h, h2 };
//heroes.ForEach(h => h.DisplayInfo());




