namespace PositiveAndNegativeNumbers
{
    public class program
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };

            {
                Console.Write("Array elements: \n");

                //foreach (var item in nums)
                //{
                //    Console.Write(item.ToString() + " ");
                //}
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write(nums[i].ToString() + " ");
                }
                var pos = nums.Where(n => n > 0);
                Console.Write("\n");

                Console.Write("\nNumber of positive numbers: " + pos.Count() +"\n\n");
                {
                    
                    var result = 0;

                    for (var i = 0; i < nums.Length; ++i)
                    {
                        if (nums[i] < 0)
                        {
                            result += nums[i];
                        }
                    }
                    Console.WriteLine("the sum of negative numbers are:" + result );
                }
            }
        }
    }
}
