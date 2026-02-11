using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        int answer = 1;
        var counts = new Dictionary<string, int>();

        int rowCount = clothes.GetLength(0);

        for (int i = 0; i < rowCount; i++) 
        {
            string type = clothes[i, 1];
            
            if (counts.TryGetValue(type, out int count)) 
            {
                counts[type] = count + 1;
            }
            else 
            {
                counts[type] = 1;
            }
        }

        foreach (int count in counts.Values) 
        {
            answer *= (count + 1);
        }

        return answer - 1;
    }
}


using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        int answer = 1;
        var counts = new Dictionary<string, int>();

        int rowCount = clothes.GetLength(0);

        for (int i = 0; i < rowCount; i++) 
        {
            string type = clothes[i, 1];
            
            if (counts.ContainsKey(type)) 
            {
                counts[type]++;
            }
            else 
            {
                counts[type] = 1;
            }
        }

        foreach (var pair in counts) 
        {
            answer *= (pair.Value + 1);
        }
        
        return answer - 1;
    }
}
