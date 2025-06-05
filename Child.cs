namespace childcounter;

public class Child : IChild
{

    public List<string> ChildList(int childTotal)
    {
        
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
