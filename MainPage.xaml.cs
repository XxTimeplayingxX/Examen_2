using Microsoft.Maui.Controls.Handlers.Compatibility;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ToDoListApp
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public ObservableCollection<Tasks> Tareas { get; set; } = new ObservableCollection<Tasks>();
        public Tasks MiTarea { get; set; }


        public MainPage()
        {
            InitializeComponent();
            MiTarea = new Tasks();
            BindingContext = this;
        }

        private void CreateOneTask()
        {
            var MiTarea = new Tasks()
            {
                TaskName = "Comprar Pan",
                Status = "Pendiente"
            };

            Tareas.Add(MiTarea);
        }
        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            var prueba = new Tasks()
            {
                TaskName = EntryTarea.Text,
                Status = EntryStatus.Text
            };
            Tareas.Add(prueba);
            EntryStatus.Text = "";
            EntryTarea.Text = "";

        }
    }
}