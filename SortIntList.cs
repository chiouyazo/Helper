int n = Nums.Count;
for (int i = 0; i < n - 1; i++)
{
    for (int j = 0; j < n - i - 1; j++)
    {
        if (Nums[j] > Nums[j + 1])
        {
            int temp = Nums[j];
            Nums[j] = Nums[j + 1];
            Nums[j + 1] = temp;
        }
    }
                    
}
                