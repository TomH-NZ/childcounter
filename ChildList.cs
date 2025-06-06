namespace childcounter;

public class ChildList : IChild //rename to ChildList
{

    public List<string> List(int childTotal) // rename to something that reflects the object better
    {
        
        var childList = new List<string>();

        for (var count = 1; count <= childTotal;)
        {
            childList.Add($"Child {count}");
            count++;
        }

        return childList;
    }

}
