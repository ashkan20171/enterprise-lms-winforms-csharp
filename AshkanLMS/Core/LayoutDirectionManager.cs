using System.Drawing;
using System.Windows.Forms;

namespace AshkanLMS.Core
{
    /// <summary>
    /// Single source of truth for direction. Persian is fully RTL; English is fully LTR.
    /// The main shell keeps physical coordinates (RightToLeftLayout=false) so the sidebar
    /// can be deterministically placed on the correct side without WinForms double-mirroring.
    /// </summary>
    public static class LayoutDirectionManager
    {
        public static bool IsRtl { get { return AppSession.Persian; } }

        public static void Apply(Form form)
        {
            bool rtl = IsRtl;
            form.RightToLeft = rtl ? RightToLeft.Yes : RightToLeft.No;
            form.RightToLeftLayout = false;
            ApplyRecursive(form, rtl);
        }

        public static void ApplyTo(Control root)
        {
            ApplyRecursive(root, IsRtl);
        }

        public static void ApplyRecursive(Control parent, bool rtl)
        {
            parent.RightToLeft = rtl ? RightToLeft.Yes : RightToLeft.No;
            foreach (Control c in parent.Controls)
            {
                c.RightToLeft = rtl ? RightToLeft.Yes : RightToLeft.No;

                Label label = c as Label;
                if (label != null) label.TextAlign = rtl ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft;

                Button button = c as Button;
                if (button != null) button.TextAlign = rtl ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft;

                TextBox textBox = c as TextBox;
                if (textBox != null) textBox.TextAlign = rtl ? HorizontalAlignment.Right : HorizontalAlignment.Left;

                MaskedTextBox masked = c as MaskedTextBox;
                if (masked != null) masked.TextAlign = rtl ? HorizontalAlignment.Right : HorizontalAlignment.Left;

                ListView list = c as ListView;
                if (list != null) list.RightToLeftLayout = rtl;

                TreeView tree = c as TreeView;
                if (tree != null) tree.RightToLeftLayout = rtl;

                DataGridView grid = c as DataGridView;
                if (grid != null)
                {
                    grid.RightToLeft = rtl ? RightToLeft.Yes : RightToLeft.No;
                    grid.ColumnHeadersDefaultCellStyle.Alignment = rtl ? DataGridViewContentAlignment.MiddleRight : DataGridViewContentAlignment.MiddleLeft;
                    grid.DefaultCellStyle.Alignment = rtl ? DataGridViewContentAlignment.MiddleRight : DataGridViewContentAlignment.MiddleLeft;
                }

                FlowLayoutPanel flow = c as FlowLayoutPanel;
                if (flow != null) flow.FlowDirection = rtl ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;

                TableLayoutPanel table = c as TableLayoutPanel;
                if (table != null) table.RightToLeft = rtl ? RightToLeft.Yes : RightToLeft.No;

                ApplyRecursive(c, rtl);
            }
        }
    }
}
