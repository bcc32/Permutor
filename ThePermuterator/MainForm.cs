using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PermuteUtil;

namespace ThePermuterator
{
    public partial class MainForm : Form
    {
        private static IComparer<String> NUMERICAL;
        private static IComparer<String> LEXICOGRAPHICAL;
        private IComparer<String> comparer;

        delegate bool Reorderer<T>(ref List<T> data, IComparer<T> comparer);
        private static Reorderer<String> forwards = Permute.NextPermutation;
        private static Reorderer<String> backwards = Permute.PreviousPermutation;

        public MainForm()
        {
            InitializeComponent();
            NUMERICAL = new NumericalComparer();
            LEXICOGRAPHICAL = StringComparer.CurrentCulture;
            UpdateType();
        }

        private void radioButton_numerical_CheckedChanged(object sender, EventArgs e)
        {
            UpdateType();
        }

        private void radioButton_lexicographical_CheckedChanged(object sender, EventArgs e)
        {
            UpdateType();
        }

        private void button_Forwards_Click(object sender, EventArgs e)
        {
            Reorder(forwards);
        }

        private void button_Backwards_Click(object sender, EventArgs e)
        {
            Reorder(backwards);
        }

        private void UpdateType()
        {
            if (radioButton_numerical.Checked)
                comparer = NUMERICAL;
            else if (radioButton_lexicographical.Checked)
                comparer = LEXICOGRAPHICAL;
            else
                throw new WarningException("invalid comparator selected");
        }

        private static Double ParseNumber(String line)
        {
            try
            {
                return Double.Parse(line);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input: " + line);
                throw;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Too big: " + line);
                throw;
            }
        }

        private void Reorder(Reorderer<String> del)
        {
            try
            {
                List<String> items = textBox_items.Lines.ToList();
                if (!del(ref items, comparer))
                {
                    MessageBox.Show("No more permutations", "End of permutations");
                }
                textBox_items.Lines = items.Select(a => a.ToString()).ToArray();
            }
            catch (FormatException)
            {
                // do nothing
            }
            catch (OverflowException)
            {
                // do nothing
            }
        }

        class NumericalComparer : Comparer<String>
        {
            override public int Compare(String a, String b)
            {
                Double x = ParseNumber(a);
                Double y = ParseNumber(b);
                return Comparer<Double>.Default.Compare(x, y);
            }
        }
    }
}
