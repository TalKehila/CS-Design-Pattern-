using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdpterPattern
{
	internal class Linux :ILinux
	{
		public void LinuxUse() => Console.WriteLine("I User Linux");
	}
}
