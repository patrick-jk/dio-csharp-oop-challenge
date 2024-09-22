using DesafioPOO.Models;

var smartphoneNokia = new Nokia("123456789", "Nokia 3310", "123456789", 16);
Console.WriteLine("Nokia:");
smartphoneNokia.Call();
smartphoneNokia.ReceiveCall();
smartphoneNokia.InstallApp("WhatsApp");

Console.WriteLine();

var smartphoneIphone = new Iphone("987654321", "iPhone 16", "987654321", 128);
Console.WriteLine("iPhone:");
smartphoneIphone.Call();
smartphoneIphone.ReceiveCall();
smartphoneIphone.InstallApp("Telegram");