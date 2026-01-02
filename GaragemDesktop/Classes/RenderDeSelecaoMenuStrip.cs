using System.Drawing;
using System.Windows.Forms;

public class MaroonMenuRenderer : ToolStripProfessionalRenderer
{
    private Color dark = Color.FromArgb(30, 30, 30);
    private Color maroon = Color.FromArgb(139, 0, 0);
    private Color maroonHover = Color.FromArgb(110, 0, 0);

    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    {
        Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);

        Color back =
            e.Item.Selected || e.Item.Pressed
            ? maroonHover
            : dark;

        using (SolidBrush brush = new SolidBrush(back))
            e.Graphics.FillRectangle(brush, rect);
    }

    protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
    {
        bool isSubMenu = e.Item.Owner is ToolStripDropDown;

        if (isSubMenu)
        {
            // Submenu: texto sempre branco
            e.TextColor = Color.White;
        }
        else
        {
            // Menu principal
            e.TextColor =
                e.Item.Selected || e.Item.Pressed
                ? Color.White
                : Color.FromArgb(30, 30, 30);
        }

        base.OnRenderItemText(e);
    }


    protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
    {
        if (e.Item is ToolStripMenuItem item)
        {
            // 👉 NORMAL = imagem padrão (dark)
            // 👉 HOVER = imagem do Tag (branca)
            if ((item.Selected || item.Pressed) && item.Tag is Image imgHover)
            {
                e.Graphics.DrawImage(imgHover, e.ImageRectangle);
            }
            else if (item.Image != null)
            {
                e.Graphics.DrawImage(item.Image, e.ImageRectangle);
            }
        }
    }

    protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
    {
        // remove qualquer borda
    }
}
