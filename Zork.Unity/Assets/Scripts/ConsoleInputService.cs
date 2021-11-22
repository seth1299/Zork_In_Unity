using System;
using Zork.Common;

namespace Zork
{
	internal class ConsoleInputService: IInputService
	{
		public event EventHandler<string> InputReceived;
		
		public void ProcessInput()
		{
			string inputString = Console.ReadLine().Trim().ToUpper();
			if (string.IsNullOrWhiteSpace(inputString) == false)
			{ 
				InputReceived?.Invoke(this, inputString);
            }
		}
	}
}