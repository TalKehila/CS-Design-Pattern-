using StatePokemon.Pokedex;
using StatePokemon.Pokemon;
using System.Windows;

namespace StatePokemon
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		readonly PPokemon pokemon = new PPokemon(new Pichu());
		public MainWindow()
		{
			InitializeComponent();
		}

		private void DisEvolve(object sender, RoutedEventArgs e)
		{
			tbState.Text =pokemon.DisEvolve();
		}

		private void EvolveMe(object sender, RoutedEventArgs e)
		{
			tbState.Text = pokemon.Evolve();

		}
	}
}