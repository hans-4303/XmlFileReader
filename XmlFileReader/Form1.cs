using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlFileReader
{
    public partial class Form1 : Form
    {
        public List<Student> stuList = new List<Student>();

        public Form1()
        {
            InitializeComponent();

            InitEvent();
        }
    }
}
