using System.Runtime.InteropServices;

namespace AdpterPattern
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var player = new Player();
			var win = new Win();
			var linux = new Linux();
			WinToLinux wl = new WinToLinux(linux);
			
			



			player.Play(win);
			player.Play(wl);

		}
	}
}
