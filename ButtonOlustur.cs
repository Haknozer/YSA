using System;
using System.Drawing;
using System.Windows.Forms;
using YSA;

public class ButtonOlustur
{
    public Button[,] buttons = new Button[7, 5];
    private Form form;
    private int btnSize = 40;

    public SinirAglari aglar;
    public Label a_label, b_label, c_label, d_label, e_label;
    public ButtonOlustur(Form form, Point baslangicNoktasi, SinirAglari aglar, Label aLabel, Label bLabel,Label clabel,Label dlabel,Label elabel)
    {
        this.form = form;
        this.aglar = aglar;
        this.a_label = aLabel;
        this.b_label = bLabel;
        this.c_label = clabel;
        this.d_label = dlabel; 
        this.e_label = elabel;
        Olustur(baslangicNoktasi);
    }

    private void Olustur(Point start)
    {
        for (int y = 0; y < 7; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                Button btn = new Button();
                btn.Width = btn.Height = btnSize;
                btn.Left = start.X + x * btnSize;
                btn.Top = start.Y + y * btnSize;
                btn.BackColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Tag = new Point(y, x);
                btn.Click += Btn_Click;

                buttons[y, x] = btn;
                form.Controls.Add(btn);
            }
        }
    }

    private void Btn_Click(object sender, EventArgs e)
    {
        Button btn = sender as Button;
        btn.BackColor = (btn.BackColor == Color.White) ? Color.Black : Color.White;

        double[] input = vektör();
        double[] output = aglar.Tahmin(input);

        Label[] labels = [a_label,b_label,c_label,d_label,e_label];
        String[] karakter = ["A", "B", "C", "D", "E"];
        for (int i = 0; i < 5; i++)
        {
            labels[i].Text = $"{karakter[i]}: {output[i]}";
        }
    }

    public double[] vektör()
    {
        double[] input = new double[35];
        for (int y = 0; y < 7; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                input[y * 5 + x] = buttons[y, x].BackColor == Color.Black ? 1.0f : 0.0f;
            }
        }
        return input;
    }

    public void Temizle()
    {
        for (int y = 0; y < 7; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                buttons[y, x].BackColor = Color.White;
            }
        }
    }
}
