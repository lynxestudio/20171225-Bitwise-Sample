using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    delegate uint BitwisePredicate(uint first,uint second);

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }


    protected void btn_Or(object sender, EventArgs e)
    {
        try
        {
            uint first = Convert.ToUInt32(num1.Text);
            uint second = Convert.ToUInt32(num2.Text);
            BitwisePredicate bitwisePredicate = ((x, y) => (x | y));
            uint result = bitwisePredicate(first, second);
            DisplayNums(first, second, result);
            lblOp.Text = "Inclusive OR";
        }
        catch(FormatException)
        {
            lblMsg.Text = "Not an integer!";
        }
        catch(ApplicationException)
        {
            lblMsg.Text = " Something goes wrong! ";
        }


    }

    protected void btn_xor(object sender, EventArgs e)
    {
        try
        {
            uint first = Convert.ToUInt32(num1.Text);
            uint second = Convert.ToUInt32(num2.Text);
            BitwisePredicate bitwisePredicate = ((x, y) => (x ^ y));
            uint result = bitwisePredicate(first, second);
            DisplayNums(first, second, result);
            lblOp.Text = "exclusive OR";
        }
        catch(FormatException)
        {
            lblMsg.Text = "Not an integer!";
        }
        catch(ApplicationException)
        {
            lblMsg.Text = " Something goes wrong! ";
        }

    }

    protected void btn_Not(object sender, EventArgs e)
    {
        try
        {
            uint first = Convert.ToUInt32(num1.Text);
            uint second = Convert.ToUInt32(num2.Text);
            uint result = 0;
            DisplayNums(~first, ~second, result);
            lblOp.Text = "NOT";
        }
        catch(FormatException)
        {
            lblMsg.Text = "Not an integer!";
        }
        catch(ApplicationException)
        {
            lblMsg.Text = "Something goes wrong! ";
        }

    }

    protected void btn_And(object sender, EventArgs e)
    {
        try
        {
            uint first = Convert.ToUInt32(num1.Text);
            uint second = Convert.ToUInt32(num2.Text);
            BitwisePredicate bitwisePredicate = ((x, y) => (x & y));
            uint result = bitwisePredicate(first, second);
            DisplayNums(first, second, result);
            lblOp.Text = "AND";
        }
        catch(FormatException)
        {
            lblMsg.Text = "Not an integer!";
        }
        catch(ApplicationException)
        {
            lblMsg.Text = "Something goes wrong!";
        }

    }

    void DisplayNums(uint first, uint second, uint result)
    {
        ClearControls();
        outputNum1.Text = PrintBits(first);
        outputNum2.Text = PrintBits(second);
        if (result > 0)
            outputSum.Text = PrintBits(result);
        else
            outputSum.Text = string.Empty;
        lbloutputNum1.Text = "[ " + num1.Text + " ] = ";
        lbloutputNum2.Text = "[ " + num2.Text + " ] = ";
        lblSum.Text = "[ " + result.ToString() + " ]";
    }

    string PrintBits(uint number)
    {
        var valueArray = Convert.ToString(number, 2).PadLeft(32, '0');
        return valueArray;
    }

    void ClearControls()
    {
        outputNum1.Text = string.Empty;
        outputNum2.Text = string.Empty;
        outputSum.Text = string.Empty;
        lbloutputNum1.Text = "[ " + string.Empty + " ]";
        lbloutputNum2.Text = "[ " + string.Empty + " ]";
        lblOp.Text = string.Empty;
        lblSum.Text = "[ " + string.Empty + " ]";
        lblMsg.Text = string.Empty;
    }

    protected void btn_clear(object sender, EventArgs e)
    {
        ClearControls();
    }
}
