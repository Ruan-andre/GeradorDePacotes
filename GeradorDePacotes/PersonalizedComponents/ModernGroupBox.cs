using System.Drawing.Drawing2D;

namespace GeradorDePacotes.PersonalizedComponents
{
    public class ModernGroupBox : Panel
    {
        private string groupTitle = "groupTitle";
        private Color titleColor = Color.White;
        private Color titleBackgroundColor = Color.FromArgb(60, 63, 65);  // Fundo do título
        private Color borderColor = Color.FromArgb(28, 28, 28); // Cor da borda
        private Color backgroundColor = Color.FromArgb(45, 47, 49); // Fundo do corpo

        public string GroupTitle
        {
            get { return groupTitle; }
            set { groupTitle = value; this.Invalidate(); }  // Redesenha o controle quando o título for alterado
        }

        public Color TitleColor
        {
            get { return titleColor; }
            set { titleColor = value; this.Invalidate(); }
        }

        public Color TitleBackgroundColor
        {
            get { return titleBackgroundColor; }
            set { titleBackgroundColor = value; this.Invalidate(); }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; this.Invalidate(); }
        }

        public ModernGroupBox()
        {
            this.DoubleBuffered = true;  // Evita flickering
            this.Padding = new Padding(10, 40, 10, 10);  // Espaço para o título e borda
            this.BackColor = Color.Transparent;  // Transparente para suportar o fundo customizado
            this.Size = new Size(300, 200);  // Tamanho padrão
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;  // Suavizar as bordas

            // Desenhar sombra mais suave
            using (GraphicsPath shadowPath = GetRoundedPath(new Rectangle(5, 25, this.Width - 10, this.Height - 15), 10))
            {
                using (PathGradientBrush shadowBrush = new PathGradientBrush(shadowPath))
                {
                    shadowBrush.CenterColor = Color.FromArgb(50, Color.Black);
                    shadowBrush.SurroundColors = new Color[] { Color.Transparent };
                    shadowBrush.FocusScales = new PointF(0.9f, 0.8f);
                    g.FillPath(shadowBrush, shadowPath);
                }
            }

            // Desenhar o fundo do controle
            using (GraphicsPath backgroundPath = GetRoundedPath(new Rectangle(0, 20, this.Width - 1, this.Height - 1), 10))
            {
                using (SolidBrush backgroundBrush = new SolidBrush(backgroundColor))
                {
                    g.FillPath(backgroundBrush, backgroundPath);
                }

                // Desenhar a borda do controle
                using (Pen borderPen = new Pen(borderColor, 2))
                {
                    g.DrawPath(borderPen, backgroundPath);
                }
            }

            // Definir o retângulo da barra de título dentro dos limites
            int titleHeight = 30; // Altura da barra de título
            Rectangle titleRect = new Rectangle(0, 0, this.Width - 1, titleHeight);

            // Desenhar barra de título com fundo
            using (GraphicsPath titlePath = GetRoundedPath(titleRect, 10))
            {
                using (SolidBrush titleBrush = new SolidBrush(titleBackgroundColor))
                {
                    g.FillPath(titleBrush, titlePath);
                }

                // Desenhar borda do título dentro do controle
                using (Pen penTitle = new Pen(borderColor, 2))
                {
                    g.DrawPath(penTitle, titlePath);
                }
            }

            // Desenhar o texto do título com fonte e sombra melhorada
            using (SolidBrush textBrush = new SolidBrush(titleColor))
            {
                Font font = new Font("Segoe UI", 12, FontStyle.Bold);
                g.DrawString(groupTitle, font, textBrush, new Point(20, -1)); // Deslocamento de 20px do lado esquerdo
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);  // Top-left
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);  // Top-right
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);  // Bottom-right
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);  // Bottom-left

            path.CloseFigure();
            return path;
        }
    }
}
