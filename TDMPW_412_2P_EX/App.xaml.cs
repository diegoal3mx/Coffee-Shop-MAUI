namespace TDMPW_412_2P_EX;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		
	}

    protected override Window CreateWindow(IActivationState activationState) =>
       new Window(new inicio())
       {
           Width = 347,
           Height = 600,
           X=500,
           Y=50,

       };
}
