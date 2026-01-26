// See https://aka.ms/new-console-template for more information
using WebPush;
var keys = VapidHelper.GenerateVapidKeys();
Console.WriteLine(keys.PublicKey);
Console.WriteLine(keys.PrivateKey);
