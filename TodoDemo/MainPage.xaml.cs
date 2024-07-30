using System.Collections.ObjectModel;

namespace TodoDemo
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }

        public MainPage()
        {
            InitializeComponent();
            TodoItems = new ObservableCollection<TodoItem>();
            TodoListView.ItemsSource = TodoItems;
        }

        //Add Functionality
        private void OnSubmitClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TodoEntry.Text))
            {
                TodoItems.Add(new TodoItem { Task = TodoEntry.Text });
                TodoEntry.Text = string.Empty;
            }
        }

        //Delete Functionality
        private void OnDeleteClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var item = button?.CommandParameter as TodoItem;
            if (item != null)
            {
                TodoItems.Remove(item);
            }
        }
    }
    public class TodoItem
    {
        public string Task { get; set; }
    }

}
