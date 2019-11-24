using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.Clases.Utils.Form
{
    class ComboBoxFiller<TItem, TItemValue>
    {
        private ComboBox comboBox;
        //private IList<TItem> items;
        private Func<TItem, string> displayValueFunction;
        private Func<TItem, TItemValue> itemValueFunction;

        private ComboBoxFiller(ComboBox comboBox)
        {
            this.comboBox = comboBox;
        }

        #region Public methods
        public static ComboBoxFiller<TItem, TItemValue> Fill(ComboBox comboBox)
        {
            return new ComboBoxFiller<TItem, TItemValue>(comboBox);
        }

        public ComboBoxFiller<TItem, TItemValue> ValueAs(Func<TItem, string> displayValueFunction)
        {
            this.displayValueFunction = displayValueFunction;
            return this;
        }

        public ComboBoxFiller<TItem, TItemValue> KeyAs(Func<TItem, TItemValue> keyFunction)
        {
            this.itemValueFunction = keyFunction;
            return this;
        }

        public ComboBoxFiller<TItem, TItemValue> With(IList<TItem> items)
        {
            foreach (TItem item in items)
            {
                ComboBoxItem<TItemValue> newItem = new ComboBoxItem<TItemValue>();
                newItem.Text = displayValueFunction(item);
                newItem.Value = itemValueFunction(item);

                comboBox.Items.Add(newItem);
            }

            return this;
        }

        public void Check(int index)
        {
            comboBox.SelectedIndex = index;
        }

        public void CheckByDBId(int index)
        {
            comboBox.SelectedIndex = index - 1;
        }

        public void CheckFirst()
        {
            comboBox.SelectedIndex = 0;
        }
        #endregion
    }
}
