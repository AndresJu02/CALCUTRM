using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Toast
{
    public static async void Show(string message, int duration = 800)
    {
        Form toast = new Form();
        toast.FormBorderStyle = FormBorderStyle.None;
        toast.StartPosition = FormStartPosition.Manual;
        toast.BackColor = Color.Black;
        toast.ForeColor = Color.White;
        toast.Size = new Size(180, 40); // << tamaño ajustable
        toast.TopMost = true;

        // Ubicar cerca del mouse
        toast.Location = new Point(Cursor.Position.X - 90, Cursor.Position.Y - 60);

        Label lbl = new Label();
        lbl.Text = message;
        lbl.Dock = DockStyle.Fill;
        lbl.TextAlign = ContentAlignment.MiddleCenter;
        lbl.ForeColor = Color.White;

        toast.Controls.Add(lbl);

        // Bordes redondeados (opcional)
        toast.Region = System.Drawing.Region.FromHrgn(
            CreateRoundRectRgn(0, 0, toast.Width, toast.Height, 10, 10)
        );

        toast.Show();

        await Task.Delay(duration); // << duración ajustable

        toast.Close();
    }

    [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn(
        int left, int top, int right, int bottom, int width, int height
    );
}
