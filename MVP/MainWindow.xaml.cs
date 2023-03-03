using System;
using System.Windows;

// View

namespace MVP
{    
    public partial class MainWindow : Window
    {
        public EventHandler myEvent = null;

        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler MyEvent
        {
            add { MyEvent += value; }   
            remove { MyEvent -= value; }    
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            myEvent.Invoke(sender, e);
        }
    }
}
