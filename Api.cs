using System.Text.Json;
// https://7annld7mde.execute-api.ap-southeast2.amazonaws.com/main/game

namespace childcounter;

public class Api : IApi
{
    /*public static async Task<Data> GetChildDataAsync()
    {
        const string apiUrl = "https://7annld7mde.execute-api.ap-southeast2.amazonaws.com/main/game";
        
        using HttpClient apiClient = new();
        var jsonResponse = await apiClient.GetStringAsync(apiUrl);

        return JsonSerializer.Deserialize<Data>(jsonResponse);
    }*/

    public Data GetChildDataAsync()
    {
        var childData = new Data
        {
            Id = 1,
            ChildCount = 7,
            Eliminate = 13
        };
        
        return childData;
    }
    
}