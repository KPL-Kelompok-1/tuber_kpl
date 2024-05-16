// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using Model;
using FrontEnd;
using Newtonsoft.Json;
class Program
{
    static void Main()
    {
        LoginPage login = new LoginPage();
        login.Display();
    }
}

