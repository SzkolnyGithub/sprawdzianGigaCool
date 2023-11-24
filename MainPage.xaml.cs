
namespace sprawdzian24._11Badowski4c;

public partial class MainPage : ContentPage
{
	int iterator = -1;
	bool active = false;
	List<string> zwierzeta = new List<string>();
	List<string> zwierzetaGat = new List<string>(); // ten sam indeks laczy nazwe zwierzecia z jego gatunkiem
	public MainPage()
	{
		InitializeComponent();
	}
	private void dodaj(object sender, EventArgs e)
	{
		if(imie.Text == "" || imie.Text == null)
		{
			DisplayAlert("Brak imienia", "Wprowadź imię", "OK");
			return;
		} else
		{
			inster(sender, e);
		}
		
	}
	private void inster(object sender, EventArgs e)
	{
        if (gatunek.IsToggled == false)
        {
            zwierzetaGat.Add("Kot");
            zwierzeta.Add(imie.Text);
            imie.Text = "";
            active = true;
        }
        else if (gatunek.IsToggled == true)
        {
            zwierzetaGat.Add("Pies");
            zwierzeta.Add(imie.Text);
            imie.Text = "";
            active = true;
        }
        if (active)
        {
            poprz.IsEnabled = true;
            nastep.IsEnabled = true;
        }
    }
	private void pop(object sender, EventArgs e) {
        iterator--;
        wstawPop(sender, e, iterator);
    }
	private void nast(object sender, EventArgs e) {
        iterator++;
        wstawNast(sender, e, iterator);
    }
	private void wstawNast(object sender, EventArgs e, int iter) {
        if(iter > zwierzeta.Count - 1)
        {
            iter = 0;
            iterator = 0;
        }
        gat.Text = zwierzetaGat[iter];
        imieZw.Text = zwierzeta[iter];
    }
    private void wstawPop(object sender, EventArgs e, int iter)
    {
        if(iter < 0)
        {
            iter = zwierzeta.Count - 1;
            iterator = zwierzeta.Count - 1;
        }
        gat.Text = zwierzetaGat[iter];
        imieZw.Text = zwierzeta[iter];
    }
}

