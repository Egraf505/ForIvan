using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestListView
{
    public partial class MainPage : ContentPage
    {
        List<Book> selectedBooks = new List<Book>();

        List<Book> books = new List<Book>() {
                new Book("1231","Толстой"),
                new Book("1231","Пущкин"),
                new Book("1231","Гоголь"),
                new Book("12","Толстой")
        };

        public MainPage()
        {
            InitializeComponent();            

            ListOfBooks.ItemsSource = books;
        }

        private void ListOfBooks_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                selectedBooks.Add((Book)e.Item);                
                CountOfBooks.Text = selectedBooks.Count.ToString();
            }
            ((ListView)sender).SelectedItem = null;
        }

        private async void GoToAPge_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SeelctBooks(selectedBooks));
        }
    }
}
