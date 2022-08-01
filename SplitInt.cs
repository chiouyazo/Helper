// Input is a Int (e.g. 123) and it Splits it into each number

List<int> Nums = new List<int>();
int Input = 123
while (Input > 0)
{
    Nums.Add(Input % 10);
    Input /= 10; 
}