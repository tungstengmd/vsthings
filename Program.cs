namespace vsIntro
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("trans pride 2025\ni love you all, stay strong <3");
			Thread.Sleep(new TimeSpan(0, 0, 1));
			Console.Write("wait, who are you btw ?\n# ");
			var name = Console.ReadLine();
			if (name == "harlow" || name == "harley" || name == "hailey") {
				Console.WriteLine("oh, hai " + name + " ! where do i recognise that name ?");
			} else { 
				Console.WriteLine("oh, hai " + name + " !");
			}
		}
	}
}