using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp01
{
    public class CounterEventArgs:EventArgs
    {
        public int Counter { get; set; }

        public CounterEventArgs() { }

        CounterEventArgs(int counter)
        {
            Counter = counter;
        }
    }

    public partial class CounterUserControl : UserControl
    {
        public event EventHandler SomeEvent;
        public event EventHandler<CounterEventArgs> CounterEvent;

        public int Counter { get; set; } = 0;

        private int _counter = 0;

        public CounterUserControl()
        {
            InitializeComponent();
            counterLabel.Text = Counter.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Counter++;
            counterLabel.Text = Counter.ToString();

            _counter++;
            if(_counter >= 3)
            {
                
                if(SomeEvent != null)
                    SomeEvent.Invoke(sender, new EventArgs());

                if (CounterEvent != null)
                    CounterEvent.Invoke(sender, );
                _counter = 0;
            }
        }
    }
}
