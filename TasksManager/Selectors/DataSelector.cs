using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksManager.MVVM.Model;

namespace TasksManager.Selectors
{
    public class DataSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var a  = (TaskItem)item;

            if (a.IsCompleted)
            {
                App.Current.Resources.TryGetValue("Completed", out var v);
                return v as DataTemplate;
            }else
            {
                App.Current.Resources.TryGetValue("NoCompleted", out var v);
                return v as DataTemplate;
            }
        }
        
    }
}
