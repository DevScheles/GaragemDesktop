using System.Drawing;
using System.Windows.Forms;

public class MenuStripRenderer : ToolStripProfessionalRenderer
{
    public MenuStripRenderer() : base(new MenuStripColors()) { }

    // REMOVE A BORDA AZUL DO ITEM
    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    {
        if (e.Item.Selected || e.Item.Pressed)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(139, 0, 0))) // MAROON
            {
                e.Graphics.FillRectangle(brush, new Rectangle(Point.Empty, e.Item.Size));
            }
        }
    }

    // REMOVE QUALQUER BORDA
    protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
    {
        // NÃO DESENHA BORDA
    }
}

public class MenuStripColors : ProfessionalColorTable
{
    public override Color MenuItemBorder
        => Color.FromArgb(139, 0, 0); // mesma cor

    public override Color MenuBorder
        => Color.FromArgb(139, 0, 0);

    public override Color ToolStripBorder
        => Color.FromArgb(139, 0, 0);

    public override Color MenuItemSelected
        => Color.FromArgb(139, 0, 0);

    public override Color MenuItemPressedGradientBegin
        => Color.FromArgb(110, 0, 0);

    public override Color MenuItemPressedGradientEnd
        => Color.FromArgb(110, 0, 0);

    public override Color MenuItemSelectedGradientBegin
        => Color.FromArgb(139, 0, 0);

    public override Color MenuItemSelectedGradientEnd
        => Color.FromArgb(139, 0, 0);

    // REMOVE AQUELA FAIXA DA ESQUERDA (IMAGEM)
    public override Color ImageMarginGradientBegin
        => Color.FromArgb(20, 20, 20);

    public override Color ImageMarginGradientMiddle
        => Color.FromArgb(20, 20, 20);

    public override Color ImageMarginGradientEnd
        => Color.FromArgb(20, 20, 20);
}
