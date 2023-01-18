using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace semana6
{
    public partial class MainPage : ContentPage
    {
        private const string Url = "http://192.168.17.58/moviles/post.php";
        private readonly HttpClient estudiante = new HttpClient();
        private ObservableCollection<semana6.Datos> _post;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnGet_Clicked(object sender, EventArgs e)
        {
            var content = await estudiante.GetStringAsync(Url);
            List<semana6.Datos> posts = JsonConvert.DeserializeObject<List<semana6.Datos>>(content);
            _post = new ObservableCollection<semana6.Datos>(posts);
            MyListView.ItemsSource = _post;


        }


    }
}
