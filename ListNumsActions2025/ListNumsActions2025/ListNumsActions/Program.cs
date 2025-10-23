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
                            Console.Writeline("YES");
                        }
                        else
                        {
                            Console.Writeline("NO");
                        }
                        break;


                    //TO DO
                    default:
                        break;
                }
            }
        }
    }
}
