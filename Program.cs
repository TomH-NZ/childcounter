// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using System.Net.Http;
using childcounter;


var data = new Api().GetChildDataAsync();

List<string> childList = new List<string>();
int num;

for (num = 1; num <= data.ChildCount; num++)
{
    childList.Add($"Child {num}");
}

