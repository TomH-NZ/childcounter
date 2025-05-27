// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using System.Net.Http;
using childcounter;


var data = new Api().GetChildDataAsync();
var elimCount = data.Eliminate;
var childTotal = data.ChildCount;

// Possibly extract out to separate class and feed in data from api??
var childList = new List<string>();
var eliminatedList = new List<string>();
int count;

for (count = 1; count <= childTotal;)
{
    childList.Add($"Child {count}");
    count++;
}

while (childList.Count > 1)
{
    if ((data.Eliminate % data.ChildCount) > 0)
    {
        elimCount = data.Eliminate - data.ChildCount;
    }
    
    eliminatedList.Add(childList[elimCount]);
    childList.RemoveAt(elimCount);
}

Console.WriteLine($"The game is {data.Id}");
Console.WriteLine($"The surviving child is {childList[0]}");