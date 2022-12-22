using System;
using System.Collections;
using System.Windows.Forms;

namespace FarmLab
{
    class MyUIntSorter : IComparer
    {
        public MyUIntSorter(int columnIndex, Mode sortingMode)
        {
            this.columnIndex = columnIndex;
            this.sortingMode = sortingMode;
        }

        public enum Mode
        {
            Ascend,
            Descend
        }

        int columnIndex;
        public int ColumnIndex 
        { 
            get { return columnIndex; }
            set { columnIndex = value; }
        }

        Mode sortingMode;
        public Mode SortingMode
        {
            get { return sortingMode; }
            set { sortingMode = value; }
        }

        public int Compare(object x, object y)
        {
            ListViewItem itemX = (ListViewItem)x;
            ListViewItem itemY = (ListViewItem)y;

            if (!uint.TryParse(itemX.SubItems[columnIndex].Text, out uint uintX))
                throw new Exception("Failed to parse ListView subitem to unsigned int");

            if (!uint.TryParse(itemY.SubItems[columnIndex].Text, out uint uintY))
                throw new Exception("Failed to parse ListView subitem to unsigned int");

            int result = 0;

            if (uintX < uintY)
                result = 1;
            else if (uintX > uintY)
                result = -1;

            if (sortingMode == Mode.Descend)
                result *= -1;

            return result;
        }
    }
}
