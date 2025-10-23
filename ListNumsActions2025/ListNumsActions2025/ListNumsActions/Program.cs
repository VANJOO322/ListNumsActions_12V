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
                        if (element.Contains(nums))
                        {
                            Console.WriteLine("YES");
                        }
                        else
                        {
                            Console.WriteLine("NO");
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

                    case "countl":
                        int limit = int.Parse(cmd[1]);
                        int countL = nums.Count(x => x > limit);
                        Console.WriteLine(countL);
                        break;


                    default:
                        break;
                }
            }
        }
    }
}
