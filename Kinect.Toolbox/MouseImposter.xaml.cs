using System;
using System.Windows.Controls;

namespace Kinect.Toolbox
{
    /// <summary>
    /// Interaction logic for MouseImposter.xaml
    /// </summary>
    public partial class MouseImposter : UserControl
    {
        public event Action OnProgressionCompleted;
        
        public MouseImposter()
        {
            InitializeComponent();
        }

        public int Progression
        {
            set
            {
                if (value == 0 || value > 100)
                {
                    progressBar.Visibility = System.Windows.Visibility.Collapsed;
                    if (value > 100 && OnProgressionCompleted != null)
                        OnProgressionCompleted();
                }
                else
                {
                    progressBar.Visibility = System.Windows.Visibility.Visible;
                    progressBar.Value = value;
                }
            }
        }
    }
}
