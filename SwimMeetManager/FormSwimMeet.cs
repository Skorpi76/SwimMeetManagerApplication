using SwimMeetLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimMeetManager
{
    public partial class FormSwimMeet : Form
    {
        public List<SwimMeet> SwimMeets { set; get; }
        public FormSwimMeet()
        {
            InitializeComponent();
        }
    }
}
