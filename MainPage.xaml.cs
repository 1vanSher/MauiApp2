using System.Windows.Input;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<task> task = App.Db.GetAll();
            tasklist.ItemsSource = task;
        }
        private void Delete(object sender, EventArgs e)
        {
            List<task> task = App.Db.GetAll();
            tasklist.ItemsSource = task;
        }
    }
}