// See https://aka.ms/new-console-template for more information

using childcounter;


var data = new Api().GetChildDataAsync();
var child = new Child();
var replaceMe = child.ChildList(data.ChildCount);
var elimCount = data.Eliminate;
var eliminatedList = new List<string>(); 

while (replaceMe.Count > 1)
{
    if (data.Eliminate % replaceMe.Count > 0)
    {
        elimCount = data.Eliminate % replaceMe.Count;
    }

    if (data.Eliminate % replaceMe.Count == 0)
    {
        elimCount = data.Eliminate - 1;
        eliminatedList.Add(replaceMe[elimCount]);
        replaceMe.RemoveAt(elimCount );
    }
    else
    {
        eliminatedList.Add(replaceMe[elimCount - 1]);
        replaceMe.RemoveAt(elimCount - 1);
    }
}

Console.WriteLine($"The game is {data.Id}");
Console.WriteLine($"The surviving child is {replaceMe[0]}");

//ToDo:
//Add unit tests
//Add calculation for Eliminate is more than 2 times greater than ChildCount, ie: Eliminate = 4, ChildCount = 2.
