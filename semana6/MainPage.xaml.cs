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
        private const string Url = "http://192.168.22.15/moviles/post.php";
        private readonly HttpClient cliente = new HttpClient();
        private ObservableCollection<semana6.Datos> post;
        public MainPage()
        {
            InitializeComponent();
            obtener();
        }

        public async void obtener()
        {
            var content = await cliente.GetStringAsync(url);
            List<semana6.Datos> posts = JsonConvert.DeserializeObject<List<semana6.Datos>>();
            posts = new ObservableCollection<semana6.Datos>(posts);
            MyListView.ItemsSource = post;

        }

        private void btnInsertar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }

        private void btnInsertar_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }

        private void btnGet_Clicked(object sender, EventArgs e)
        {
            var content = await client.GetStringAsync(Url);
            List<semana6.Ws.Datos> post = JsonConvert.DeserializeObject<List<semana6.Ws.Datos>>(content);
            _post = new ObservableCollection<semana6.Ws.Datos>(post);
        }
    }
}
