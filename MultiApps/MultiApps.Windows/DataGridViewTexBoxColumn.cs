using System.Windows.Forms;

namespace MultiApps.Windows
{
    internal class DataGridViewTexBoxColumn : DataGridViewColumn
    {
        public string DataPropertyName { get; set; }
        public string HaaderText { get; set; }
    }
}