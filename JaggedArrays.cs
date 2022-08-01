// Loop Through a Jagged Array (Example from LeetCode)

int[][] accounts = new int[][] { new int[] { 1, 5 }, new int[] { 7, 3 }, new int[] { 3, 5 } };

public static int MaximumWealth(int[][] accounts) {
    int LastCurrentHighest = 0;
    for (int i = 0; i < accounts.Count(); i++)
    {
        int CurrentSum = 0;
        for (int j = 0; j < accounts[i].Count(); j++)
        {
            CurrentSum = CurrentSum + accounts[i][j];
        }
        if(CurrentSum > LastCurrentHighest)
        {
            LastCurrentHighest = CurrentSum;
        }
    }
    return LastCurrentHighest;
}