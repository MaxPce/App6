using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var frutas = new List<Fruta>
        {
            new Fruta { Nombre = "Manzana", Categoria = "Frutas Rojas" },
            new Fruta { Nombre = "Plátano", Categoria = "Frutas Amarillas" },
            new Fruta { Nombre = "Naranja", Categoria = "Frutas Naranjas" },
            new Fruta { Nombre = "Fresa", Categoria = "Frutas Rojas" },
            new Fruta { Nombre = "Uva", Categoria = "Frutas Moradas" },
            new Fruta { Nombre = "Kiwi", Categoria = "Frutas Verdes" },
            new Fruta { Nombre = "Pera", Categoria = "Frutas Amarillas" },
            new Fruta { Nombre = "Mango", Categoria = "Frutas Amarillas" },
            new Fruta { Nombre = "Cereza", Categoria = "Frutas Rojas" },
            new Fruta { Nombre = "Limón", Categoria = "Frutas Amarillas" },
        };

            var groupedFrutas = frutas.GroupBy(f => f.Categoria)
                                      .Select(grp => new Grouping<string, Fruta>(grp.Key, grp));

            lvEstudiantes1.ItemsSource = groupedFrutas;

        }
    }

    public class Grouping<K, T> : ObservableCollection<T>
    {
        public K Key { get; private set; }

        public Grouping(K key, IEnumerable<T> items)
        {
            Key = key;
            foreach (var item in items)
            {
                Add(item);
            }
        }
    }

}
