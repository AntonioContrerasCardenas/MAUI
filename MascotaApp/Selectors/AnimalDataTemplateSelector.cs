using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MascotaApp.MVVM.Model;
using PropertyChanged;

namespace MascotaApp.Selectors
{
    [AddINotifyPropertyChangedInterface]
    public class AnimalDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var animal = item as Animal;
            if (animal.IsAdopted)
            {
                Application.Current.Resources.TryGetValue("AdoptadoStyle", out var adoptadoStyle);
                return adoptadoStyle as DataTemplate;
            }else
            {
                Application.Current.Resources.TryGetValue("NodoptadoStyle", out var adoptadoStyle);
                return adoptadoStyle as DataTemplate;
            }
            return new DataTemplate();
        }
    }
}
