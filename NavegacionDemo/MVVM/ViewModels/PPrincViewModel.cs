using NavegacionDemo.MVVM.Models;
using System.Collections.ObjectModel;

namespace NavegacionDemo.MVVM.ViewModels
{
    public class PPrincViewModel
    {
        public ObservableCollection<Categoria> Categorias { get; set; }

        public PPrincViewModel()
        {
            Categorias = new ObservableCollection<Categoria>
            {
                new Categoria
                {
                    IDCategoria=1,
                    NombreCategoria = "Trabajo"
                },
                new Categoria
                {
                    IDCategoria=2,
                    NombreCategoria = "Casa"
                },
                new Categoria
                {
                    IDCategoria=2,
                    NombreCategoria = "Gimnasio"
                },
                new Categoria
                {
                    IDCategoria=2,
                    NombreCategoria = "Piso"
                }
            };
        }
    }
}
