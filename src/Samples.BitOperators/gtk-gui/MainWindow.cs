
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.Table table1;

	private global::Gtk.Label label6;

	private global::Gtk.Label label7;

	private global::Gtk.Entry num1;

	private global::Gtk.Entry num2;

	private global::Gtk.HBox hbox4;

	private global::Gtk.Button btnAnd;

	private global::Gtk.Button btnOr;

	private global::Gtk.Button btnXor;

	private global::Gtk.Button btnClear;

	private global::Gtk.Button btnNot;

	private global::Gtk.HBox hbox5;

	private global::Gtk.Label lbloutputNum1;

	private global::Gtk.Entry outputNum1;

	private global::Gtk.HBox hbox6;

	private global::Gtk.Label lblOp;

	private global::Gtk.Label lblMsg;

	private global::Gtk.HBox hbox8;

	private global::Gtk.Label lblSum;

	private global::Gtk.Entry outputSum;

	private global::Gtk.HBox hbox7;

	private global::Gtk.HSeparator hseparator2;

	private global::Gtk.HBox hbox9;

	private global::Gtk.Label lbloutputNum2;

	private global::Gtk.Entry outputNum2;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Bit Operators with C#");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(8));
		this.Resizable = false;
		this.AllowGrow = false;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.label6 = new global::Gtk.Label();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Enter an unsigned integer: ");
		this.table1.Add(this.label6);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.label6]));
		w1.XOptions = ((global::Gtk.AttachOptions)(4));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label7 = new global::Gtk.Label();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Enter a second unsigned: ");
		this.table1.Add(this.label7);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.label7]));
		w2.TopAttach = ((uint)(1));
		w2.BottomAttach = ((uint)(2));
		w2.XOptions = ((global::Gtk.AttachOptions)(4));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.num1 = new global::Gtk.Entry();
		this.num1.CanFocus = true;
		this.num1.Name = "num1";
		this.num1.IsEditable = true;
		this.num1.InvisibleChar = '•';
		this.table1.Add(this.num1);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.num1]));
		w3.LeftAttach = ((uint)(1));
		w3.RightAttach = ((uint)(2));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.num2 = new global::Gtk.Entry();
		this.num2.CanFocus = true;
		this.num2.Name = "num2";
		this.num2.IsEditable = true;
		this.num2.InvisibleChar = '•';
		this.table1.Add(this.num2);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.num2]));
		w4.TopAttach = ((uint)(1));
		w4.BottomAttach = ((uint)(2));
		w4.LeftAttach = ((uint)(1));
		w4.RightAttach = ((uint)(2));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox1.Add(this.table1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table1]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Homogeneous = true;
		this.hbox4.Spacing = 6;
		this.hbox4.BorderWidth = ((uint)(2));
		// Container child hbox4.Gtk.Box+BoxChild
		this.btnAnd = new global::Gtk.Button();
		this.btnAnd.CanFocus = true;
		this.btnAnd.Name = "btnAnd";
		this.btnAnd.UseUnderline = true;
		this.btnAnd.Label = global::Mono.Unix.Catalog.GetString("AND");
		this.hbox4.Add(this.btnAnd);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.btnAnd]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.btnOr = new global::Gtk.Button();
		this.btnOr.CanFocus = true;
		this.btnOr.Name = "btnOr";
		this.btnOr.UseUnderline = true;
		this.btnOr.Label = global::Mono.Unix.Catalog.GetString("OR");
		this.hbox4.Add(this.btnOr);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.btnOr]));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.btnXor = new global::Gtk.Button();
		this.btnXor.CanFocus = true;
		this.btnXor.Name = "btnXor";
		this.btnXor.UseUnderline = true;
		this.btnXor.Label = global::Mono.Unix.Catalog.GetString("XOR");
		this.hbox4.Add(this.btnXor);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.btnXor]));
		w8.Position = 2;
		w8.Expand = false;
		w8.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.btnClear = new global::Gtk.Button();
		this.btnClear.CanFocus = true;
		this.btnClear.Name = "btnClear";
		this.btnClear.UseUnderline = true;
		this.btnClear.Label = global::Mono.Unix.Catalog.GetString("Clear");
		this.hbox4.Add(this.btnClear);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.btnClear]));
		w9.PackType = ((global::Gtk.PackType)(1));
		w9.Position = 3;
		w9.Expand = false;
		w9.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.btnNot = new global::Gtk.Button();
		this.btnNot.CanFocus = true;
		this.btnNot.Name = "btnNot";
		this.btnNot.UseUnderline = true;
		this.btnNot.Label = global::Mono.Unix.Catalog.GetString("NOT");
		this.hbox4.Add(this.btnNot);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.btnNot]));
		w10.PackType = ((global::Gtk.PackType)(1));
		w10.Position = 4;
		w10.Expand = false;
		w10.Fill = false;
		this.vbox1.Add(this.hbox4);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.lbloutputNum1 = new global::Gtk.Label();
		this.lbloutputNum1.Name = "lbloutputNum1";
		this.lbloutputNum1.LabelProp = global::Mono.Unix.Catalog.GetString("[  ] = ");
		this.hbox5.Add(this.lbloutputNum1);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.lbloutputNum1]));
		w12.Position = 0;
		w12.Expand = false;
		w12.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.outputNum1 = new global::Gtk.Entry();
		this.outputNum1.CanFocus = true;
		this.outputNum1.Name = "outputNum1";
		this.outputNum1.IsEditable = false;
		this.outputNum1.InvisibleChar = '•';
		this.hbox5.Add(this.outputNum1);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.outputNum1]));
		w13.Position = 1;
		this.vbox1.Add(this.hbox5);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox5]));
		w14.Position = 2;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.lblOp = new global::Gtk.Label();
		this.lblOp.Name = "lblOp";
		this.hbox6.Add(this.lblOp);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.lblOp]));
		w15.Position = 0;
		this.vbox1.Add(this.hbox6);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox6]));
		w16.Position = 3;
		w16.Expand = false;
		w16.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.lblMsg = new global::Gtk.Label();
		this.lblMsg.Name = "lblMsg";
		this.lblMsg.LabelProp = global::Mono.Unix.Catalog.GetString("Running...");
		this.vbox1.Add(this.lblMsg);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.lblMsg]));
		w17.PackType = ((global::Gtk.PackType)(1));
		w17.Position = 4;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox8 = new global::Gtk.HBox();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.lblSum = new global::Gtk.Label();
		this.lblSum.Name = "lblSum";
		this.lblSum.LabelProp = global::Mono.Unix.Catalog.GetString("[  ] = ");
		this.hbox8.Add(this.lblSum);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.lblSum]));
		w18.Position = 0;
		w18.Expand = false;
		w18.Fill = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.outputSum = new global::Gtk.Entry();
		this.outputSum.CanFocus = true;
		this.outputSum.Name = "outputSum";
		this.outputSum.IsEditable = false;
		this.outputSum.InvisibleChar = '•';
		this.hbox8.Add(this.outputSum);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.outputSum]));
		w19.Position = 1;
		this.vbox1.Add(this.hbox8);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox8]));
		w20.PackType = ((global::Gtk.PackType)(1));
		w20.Position = 5;
		w20.Expand = false;
		w20.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.hseparator2 = new global::Gtk.HSeparator();
		this.hseparator2.Name = "hseparator2";
		this.hbox7.Add(this.hseparator2);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.hseparator2]));
		w21.Position = 0;
		this.vbox1.Add(this.hbox7);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox7]));
		w22.PackType = ((global::Gtk.PackType)(1));
		w22.Position = 6;
		w22.Expand = false;
		w22.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox9 = new global::Gtk.HBox();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 6;
		// Container child hbox9.Gtk.Box+BoxChild
		this.lbloutputNum2 = new global::Gtk.Label();
		this.lbloutputNum2.Name = "lbloutputNum2";
		this.lbloutputNum2.LabelProp = global::Mono.Unix.Catalog.GetString("[  ] = ");
		this.hbox9.Add(this.lbloutputNum2);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.lbloutputNum2]));
		w23.Position = 0;
		w23.Expand = false;
		w23.Fill = false;
		// Container child hbox9.Gtk.Box+BoxChild
		this.outputNum2 = new global::Gtk.Entry();
		this.outputNum2.CanFocus = true;
		this.outputNum2.Name = "outputNum2";
		this.outputNum2.IsEditable = false;
		this.outputNum2.InvisibleChar = '•';
		this.hbox9.Add(this.outputNum2);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.outputNum2]));
		w24.Position = 1;
		this.vbox1.Add(this.hbox9);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox9]));
		w25.PackType = ((global::Gtk.PackType)(1));
		w25.Position = 7;
		w25.Expand = false;
		w25.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 376;
		this.DefaultHeight = 287;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.btnAnd.Clicked += new global::System.EventHandler(this.btn_And);
		this.btnOr.Clicked += new global::System.EventHandler(this.btn_Or);
		this.btnXor.Clicked += new global::System.EventHandler(this.btn_xor);
		this.btnNot.Clicked += new global::System.EventHandler(this.btn_Not);
		this.btnClear.Clicked += new global::System.EventHandler(this.btn_clear);
	}
}
