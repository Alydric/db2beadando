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
        
        private void FeltoltCbCars()
        {
            CbCars.BeginUpdate();
            CbCars.Items.Clear();

            foreach (Car car in cars)
            {
                CbCars.Items.Add(car);
            }
            CbCars.EndUpdate();
        }

        private void FeltoltCbTulajok()
        {
            CbTulajok.BeginUpdate();
            CbTulajok.Items.Clear();

            foreach (Tulaj tulaj in tulajs)
            {
                CbTulajok.Items.Add(tulaj);
            }
            CbTulajok.EndUpdate();
        }

        private void BtCarTorles_Click(object sender, EventArgs e)
        {
            if (CbCars.SelectedIndex == -1)
            {
                MessageBox.Show("Először válassz ki egy elemet!");
                return;
            }

            Car torlendo = (Car)CbCars.SelectedItem;

            int toroltRekordokDb = carKezelo.Delete(torlendo);
            MessageBox.Show(toroltRekordokDb + "rekord sikeresen törölve lett!");
            CbCars.SelectedItem = null;
            cars = carKezelo.Select();

            FeltoltCbCars();
        }

        private void BtTulajTorles_Click(object sender, EventArgs e)
        {
            if (CbTulajok.SelectedIndex == -1)
            {
                MessageBox.Show("Először válassz ki egy elemet!");
                return;
            }

            Tulaj torlendo = (Tulaj)CbTulajok.SelectedItem;

            int toroltRekordokDb = tulajKezelo.Delete(torlendo);
            MessageBox.Show(toroltRekordokDb + "rekord sikeresen törölve lett!");
            CbTulajok.SelectedItem = null;
            tulajs = tulajKezelo.Select();

            FeltoltCbTulajok();
        }

        private void BtCarInsert_Click(object sender, EventArgs e)
        {

        }

        private void BtTulajInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
