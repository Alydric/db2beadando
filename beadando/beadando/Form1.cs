using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando
{
    public partial class Form1 : Form
    {
        private List<Car> cars;
        private CarTablakezelo carKezelo;

        private List<Tulaj> tulajs;
        private TulajKezelo tulajKezelo;

        public Form1()
        {
            InitializeComponent();
            carKezelo = new CarTablakezelo();
            tulajKezelo = new TulajKezelo();

            cars = carKezelo.Select();
            //feltoltComboBoxCars();

            tulajs = tulajKezelo.Select();
            //feltoltComboBoxTulajok();
        }

        

        
    }
}
