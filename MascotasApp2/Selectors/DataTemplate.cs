using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MascotasApp2.MVVM.Model;
using PropertyChanged;

namespace MascotasApp2.Selectors
{
    public class DataTemplateAdopt : DataTemplateSelector
    {
        protected override Microsoft.Maui.Controls.DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var animal = item as Animal;

            if(animal.IsAdopted)
            {
                Application.Current.Resources.TryGetValue("AdoptedView", out var adopted);
                return adopted as DataTemplate;
            }

            Application.Current.Resources.TryGetValue("NoAdoptedView", out var noadopted);
            return noadopted as DataTemplate;
        }
    }
}
