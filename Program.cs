// See https://aka.ms/new-console-template for more information
using static System.Net.WebRequestMethods;
using System.Net.Http;
using Newtonsoft.Json.Linq;

Console.WriteLine("Hello, World!");
var kanyeURL = "https://api.kanye.rest";
var client = new HttpClient();
var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
Console.WriteLine(kanyeQuote); 