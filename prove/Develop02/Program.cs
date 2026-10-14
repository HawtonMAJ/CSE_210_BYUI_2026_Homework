using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.ChooseWhereToGo();
    }
    
}