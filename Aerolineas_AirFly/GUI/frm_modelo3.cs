﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerolineas_AirFly.GUI
{
    public partial class frm_modelo3 : Form
    {
        public frm_modelo3()
        {
            InitializeComponent();
            cmb_clase_modelo3.Items.Add("Seleccione una clase");
            cmb_clase_modelo3.Items.Add("Primera clase");
            cmb_clase_modelo3.Items.Add("Clase Economica plus");
            cmb_clase_modelo3.Items.Add("Clase Economica");
        }
    }
}
