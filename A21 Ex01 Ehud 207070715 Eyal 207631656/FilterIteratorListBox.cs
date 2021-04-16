using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A21_Ex02_Ehud_207070715_Eyal_207631656
{
    public class FilterIteratorListBox<T>
    {
        private readonly Func<T, string, bool> r_SearchStrategy;

        public IEnumerable<T> ItemsList { get; set; }

        public ListBox ItemsListBox { get; set; }

        public TextBox SearchTextBox { get; set; }

        public FilterIteratorListBox(ListBox i_ItemsListBox, TextBox i_SearchTextBox, IEnumerable<T> i_ItemsList, Func<T, string,bool> i_SearchStrategy)
        {
            r_SearchStrategy = i_SearchStrategy;
            ItemsList = i_ItemsList;
            ItemsListBox = i_ItemsListBox;
            SearchTextBox = i_SearchTextBox;
            fillItemsListbox(ItemsList);
            SearchTextBox.Text = "Search...";
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
        }

        private void fillItemsListbox(IEnumerable<T> i_ItemsList)
        {
            ItemsListBox.Invoke(new Action(() => ItemsListBox.Items.Clear()));
            foreach (T item in i_ItemsList)
            {
                ItemsListBox.Invoke(new Action(() => ItemsListBox.Items.Add(item)));
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<T> filteredItems = from item in ItemsList
                                           where r_SearchStrategy(item, SearchTextBox.Text)
                                           select item;
            fillItemsListbox(filteredItems);
        }
    }
}
