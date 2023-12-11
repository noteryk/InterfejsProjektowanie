namespace InterfejsProjektowanie;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Button button = new Button
        {
            Text = "Kliknij tutaj aby zmienic kolor"
        };
        Button button2 = new Button
        {
            Text = "Tutaj takze zmienie swoj kolor"
        };

        Button button3 = new Button
        {
            Text = "Kliknij aby mnie obrocic",
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center
        };


        Label label = new Label
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };


        CheckBox checkBox = new CheckBox
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };

        Label label2 = new Label
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };

        Button button4 = new Button
        {
            Text = "Przytrzymaj mnie aby zmienic kolor tla",
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center
        };


        button.Clicked += (sender, e) =>
        {
            button.TextColor = Colors.Red;
            button2.TextColor = Colors.Red;
        };

        button2.Clicked += (sender, e) =>
        {
            button.TextColor = Colors.Red;
            button2.TextColor = Colors.Red;
        };


        button3.Clicked += async (sender, e) =>
        {
            await button3.RotateTo(180, 500);
            button.Rotation = 0;
        };

        checkBox.CheckedChanged += (sender, e) =>
        {
            if (checkBox.IsChecked)
            {
                label.Text = "Zaznaczono";
            }
            else
            {
                label.Text = "Nie zaznaczono";
            }
        };

        SearchBar searchBar = new SearchBar();
        searchBar.TextChanged += (sender, e) =>
        {
            label2.Text = searchBar.Text;
        };

        button4.Pressed += (sender, e) =>
        {
            button4.BackgroundColor = Colors.Red;
        };

        button4.Released += (sender, e) =>
        {
            button4.BackgroundColor = Colors.White;
        };


        Content = new StackLayout
        {
            Children = { 
                button, button2, button3, label, checkBox , label2, searchBar, button4
            }
        };
    }

}