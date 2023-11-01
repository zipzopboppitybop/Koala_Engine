using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SmoothBrainEditor.GameProject
{
    public class Project : ViewModelBase
    {
        public static string Extension { get; } = ".koala";
        public string Name { get; private set; }
        public string Path { get; private set; }
        public string FullPath => $"{Path}{Name}{Extension}";

        private ReadOnlyObservableCollection<Scene> scenes = new ObservableCollection<Scene>();

        public ReadOnlyObservableCollection<Scene> Scenes { get; }
    }
}
