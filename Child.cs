namespace childcounter;

public class Child
{
    public List<string> ChildList()
    {
        var data = new Api().GetChildDataAsync();
        var childTotal = data.ChildCount;
        
        var childList = new List<string>();

        int count;

        for (count = 1; count <= childTotal;)
        {
            childList.Add($"Child {count}");
            count++;
        }

        return childList;
    }

}