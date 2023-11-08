namespace MauiAppBmi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int count = 0;

        void Button_Clicked(object sender, EventArgs e)
        {
            double weightInLbs = Convert.ToDouble(In_Weight.Text);
            double heightInInches = Convert.ToDouble(In_Height.Text);


            double bmi = ((weightInLbs / (heightInInches * heightInInches)) * 703);
            Out_Text.Text = bmi.ToString();
        }



    }
}