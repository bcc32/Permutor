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
    public partial class Form1 : Form
    {
        private static IComparer<Object> NUMERICAL;
        private static IComparer<Object> LEXICOGRAPHICAL;
        private IComparer<Object> comparer;

        delegate Object InputParser(String line);
        private InputParser parser;

        delegate bool Reorderer(ref List<Object> data, IComparer<Object> comparer);
        private static Reorderer forwards = Permute.NextPermutation;
        private static Reorderer backwards = Permute.PreviousPermutation;

        public Form1()
        {
            InitializeComponent();
            NUMERICAL = new NumericalComparer();
            LEXICOGRAPHICAL = new LexicographicalComparer();
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
            {
                comparer = NUMERICAL;
                parser = ParseNumber;
            }
            else if (radioButton_numerical.Checked)
            {
                comparer = LEXICOGRAPHICAL;
                parser = ParseString;
            }
            else
                throw new WarningException("invalid comparator selected");
        }

        private Object ParseNumber(String line)
        {
            try
            {
                Object o = (Object)Double.Parse(line);
                return o;
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

        private Object ParseString(String line)
        {
            return (Object)line;
        }

        private void Reorder(Reorderer del)
        {
            try
            {
                List<Object> items = textBox_items.Lines.Select(a => parser(a)).ToList();
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
    }

    class NumericalComparer : IComparer<Object>
    {
        int IComparer<Object>.Compare(Object a, Object b)
        {
            return Comparer<Double>.Default.Compare((Double)a, (Double)b);
        }
    }

    class LexicographicalComparer : IComparer<Object>
    {
        int IComparer<Object>.Compare(Object a, Object b)
        {
            return Comparer<String>.Default.Compare((String)a, (String)b);
        }
    }
}
