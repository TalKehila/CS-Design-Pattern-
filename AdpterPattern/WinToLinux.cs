using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdpterPattern
{
	internal class WinToLinux : IWin
	{
		private readonly ILinux linux;

		public WinToLinux(ILinux linux)
        {
			this.linux = linux;
		}

		public void WinUse()
		{
			linux.LinuxUse();
		}
	}
}
