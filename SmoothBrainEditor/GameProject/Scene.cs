using System;
using System.Collections.Generic;
using System.Text;

namespace SmoothBrainEditor.GameProject
{
    public class Scene : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get => _name;
            set 
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public Project Project { get; private set; }

    }
}
