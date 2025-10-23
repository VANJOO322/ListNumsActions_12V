        namespace ListNumsActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins": int index= int.Parse(cmd[1]);
                        int num = int.Parse(cmd[2]);
                        nums.Insert(index,num);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                    case "contains": int element= int.Parse(cmd[1]);
                        if (nums.Contains(element))
                        {
                            Console.WriteLine("NO");
                        }
                        else
                        {
                            Console.WriteLine("YES");
                        }
                        break;
                     
                    case "del":
                        int elementd = int.Parse(cmd[1]);
                        nums.Remove(elementd); 
                        break;


                    case "remove":
                        int indexr = int.Parse(cmd[1]);
                        if (indexr >= 0 && indexr < nums.Count)
                        {
                            nums.RemoveAt(indexr);
                        }
                        break;

                    case "add":
                        int num1 = int.Parse(cmd[1]);

                        int num2 = int.Parse(cmd[2]);
                        int result = num1 + num2;
                        nums.Add(result);    
                        break;

                    case "odds":
                        int cods = nums.Count(x => x % 2 != 0);
                        Console.WriteLine(cods);
                        break;

                    case "sumall":
                        int sum = nums.Sum();
                        Console.WriteLine(sum);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
