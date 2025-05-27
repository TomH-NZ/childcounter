// See https://aka.ms/new-console-template for more information

using childcounter;


var data = new Api().GetChildDataAsync();
var child = new Child();
var elimCount = data.Eliminate;
var eliminatedList = new List<string>();
var count = 1;

while (child.ChildList().Count > 1)
{
    if (data.Eliminate % data.ChildCount > 0)
    {
        elimCount = data.Eliminate - data.ChildCount;
    }

    if (data.Eliminate % data.ChildCount == 0)
    {
        elimCount = 0;
        eliminatedList.Add(child.ChildList()[elimCount]);
        child.ChildList().RemoveAt(elimCount );
    }
    else
    {
        eliminatedList.Add(child.ChildList()[elimCount - 1]);
        child.ChildList().RemoveAt(elimCount - 1);
    }
}

Console.WriteLine($"The game is {data.Id}");
Console.WriteLine($"The surviving child is {child.ChildList()[0]}");

//ToDo:
//Add unit tests
//Add calculation for Eliminate is more than 2 times greater than ChildCount, ie: Eliminate = 4, ChildCount = 2.