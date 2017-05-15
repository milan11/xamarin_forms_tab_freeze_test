using Xamarin.Forms;

namespace App5
{
    public partial class App : Application
    {

        private TabbedPage tp;

        private int count_button;
        private int count_list;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(CreateTabbedPage());
        }

        private Page CreateTabbedPage()
        {
            tp = new TabbedPage();
            {
                ContentPage page = new ContentPage();
                page.Title = "Page 1";

                StackLayout sl = new StackLayout();
                sl.Children.Add(new Label() { Text = "This is page 1" });

                Label counter_button = new Label();
                sl.Children.Add(counter_button);

                Label counter_list = new Label();
                sl.Children.Add(counter_list);

                {
                    Button button = new Button() { Text = "Button" };
                    button.Clicked += (sender, e) =>
                    {
                        ++count_button;
                        counter_button.Text = "Button clicked: " + count_button;
                    };
                    sl.Children.Add(button);
                }

                {
                    ListView list = new ListView();
                    list.HasUnevenRows = true;
                    list.ItemsSource = new string[] { "List item" };
                    list.ItemTapped += (sender, e) =>
                    {
                        ++count_list;
                        counter_list.Text = "List clicked: " + count_list;
                    };
                    sl.Children.Add(list);
                }

                page.Content = sl;
                tp.Children.Add(page);
            }

            {
                ContentPage page = new ContentPage();
                page.Title = "Page 2";

                StackLayout sl = new StackLayout();
                sl.Children.Add(new Label() { Text = "This is page 2" });

                page.Content = sl;
                tp.Children.Add(page);
            }

            return tp;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
