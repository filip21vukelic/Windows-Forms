
using System;
using System.Windows.Forms;

public class NarudzbaForm : Form
{
    CheckBox checkBoxDorucak, checkBoxRucak, checkBoxVecera, checkBoxSakrij;
    Button buttonPosalji;
    TextBox textBox1;

    public NarudzbaForm()
    {
        checkBoxDorucak = new CheckBox { Text = "Doručak" };
        checkBoxRucak = new CheckBox { Text = "Ručak" };
        checkBoxVecera = new CheckBox { Text = "Večera" };
        checkBoxSakrij = new CheckBox { Text = "Sakrij narudžbu" };
        buttonPosalji = new Button { Text = "Pošalji" };
        textBox1 = new TextBox { Multiline = true, Visible = true };

        buttonPosalji.Click += (s, e) =>
        {
            textBox1.Clear();
            textBox1.AppendText("Odabrali ste :" + Environment.NewLine);
            if (checkBoxDorucak.Checked) textBox1.AppendText("doručak" + Environment.NewLine);
            if (checkBoxRucak.Checked) textBox1.AppendText("ručak" + Environment.NewLine);
            if (checkBoxVecera.Checked) textBox1.AppendText("večera" + Environment.NewLine);
        };

        checkBoxSakrij.CheckedChanged += (s, e) => textBox1.Visible = !checkBoxSakrij.Checked;

        Controls.Add(checkBoxDorucak);
        Controls.Add(checkBoxRucak);
        Controls.Add(checkBoxVecera);
        Controls.Add(checkBoxSakrij);
        Controls.Add(buttonPosalji);
        Controls.Add(textBox1);
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new NarudzbaForm());
    }
}

