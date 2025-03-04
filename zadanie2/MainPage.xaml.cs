namespace zadanie2
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
           
        }

        private void OnResetButtonClicked(object sender, EventArgs e)
        {
            mojSlider.Value = 50;
        }
        private void OnFontSizeChange(object sender, ValueChangedEventArgs e)
        {
           mylabel.FontSize = e.NewValue;
        }
        private void OnBackgroundColorChange(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            this.BackgroundColor = Color.FromRgb(value, value, value);
        }
        private void OnFontSizeStepperChange(object sender, ValueChangedEventArgs e)
        {
            mylabel.FontSize = e.NewValue;
        }
        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
           progressbar.Progress = e.NewValue;
        }



    }

}
