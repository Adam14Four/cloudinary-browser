
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox RootContainer;
	
	private global::Gtk.Table AuthInfoContainer;
	
	private global::Gtk.Entry entry2;
	
	private global::Gtk.Entry entry3;
	
	private global::Gtk.Entry entry4;
	
	private global::Gtk.Label label2;
	
	private global::Gtk.Label label3;
	
	private global::Gtk.Label label4;
	
	private global::Gtk.Button LoginBtn;
	
	private global::Gtk.ScrolledWindow scrolledwindow1;
	
	private global::Gtk.Table InfoListContainer;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Cloudinary Browser");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.AllowShrink = true;
		this.DefaultWidth = 800;
		this.DefaultHeight = 600;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.RootContainer = new global::Gtk.VBox ();
		this.RootContainer.Name = "RootContainer";
		this.RootContainer.Spacing = 6;
		// Container child RootContainer.Gtk.Box+BoxChild
		this.AuthInfoContainer = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
		this.AuthInfoContainer.Name = "AuthInfoContainer";
		this.AuthInfoContainer.RowSpacing = ((uint)(6));
		this.AuthInfoContainer.ColumnSpacing = ((uint)(6));
		// Container child AuthInfoContainer.Gtk.Table+TableChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '●';
		this.AuthInfoContainer.Add (this.entry2);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.AuthInfoContainer [this.entry2]));
		w1.LeftAttach = ((uint)(1));
		w1.RightAttach = ((uint)(2));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child AuthInfoContainer.Gtk.Table+TableChild
		this.entry3 = new global::Gtk.Entry ();
		this.entry3.CanFocus = true;
		this.entry3.Name = "entry3";
		this.entry3.IsEditable = true;
		this.entry3.InvisibleChar = '●';
		this.AuthInfoContainer.Add (this.entry3);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.AuthInfoContainer [this.entry3]));
		w2.TopAttach = ((uint)(1));
		w2.BottomAttach = ((uint)(2));
		w2.LeftAttach = ((uint)(1));
		w2.RightAttach = ((uint)(2));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child AuthInfoContainer.Gtk.Table+TableChild
		this.entry4 = new global::Gtk.Entry ();
		this.entry4.CanFocus = true;
		this.entry4.Name = "entry4";
		this.entry4.IsEditable = true;
		this.entry4.InvisibleChar = '●';
		this.AuthInfoContainer.Add (this.entry4);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.AuthInfoContainer [this.entry4]));
		w3.TopAttach = ((uint)(2));
		w3.BottomAttach = ((uint)(3));
		w3.LeftAttach = ((uint)(1));
		w3.RightAttach = ((uint)(2));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child AuthInfoContainer.Gtk.Table+TableChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.Xalign = 1F;
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Cloud Name:");
		this.label2.Justify = ((global::Gtk.Justification)(1));
		this.AuthInfoContainer.Add (this.label2);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.AuthInfoContainer [this.label2]));
		w4.XOptions = ((global::Gtk.AttachOptions)(4));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child AuthInfoContainer.Gtk.Table+TableChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.Xalign = 1F;
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("API Key:");
		this.label3.Justify = ((global::Gtk.Justification)(1));
		this.AuthInfoContainer.Add (this.label3);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.AuthInfoContainer [this.label3]));
		w5.TopAttach = ((uint)(1));
		w5.BottomAttach = ((uint)(2));
		w5.XOptions = ((global::Gtk.AttachOptions)(4));
		w5.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child AuthInfoContainer.Gtk.Table+TableChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.Xalign = 1F;
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("API Secret:");
		this.label4.Justify = ((global::Gtk.Justification)(1));
		this.AuthInfoContainer.Add (this.label4);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.AuthInfoContainer [this.label4]));
		w6.TopAttach = ((uint)(2));
		w6.BottomAttach = ((uint)(3));
		w6.XOptions = ((global::Gtk.AttachOptions)(4));
		w6.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child AuthInfoContainer.Gtk.Table+TableChild
		this.LoginBtn = new global::Gtk.Button ();
		this.LoginBtn.CanFocus = true;
		this.LoginBtn.Name = "LoginBtn";
		this.LoginBtn.UseUnderline = true;
		this.LoginBtn.Label = global::Mono.Unix.Catalog.GetString ("Login");
		this.AuthInfoContainer.Add (this.LoginBtn);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.AuthInfoContainer [this.LoginBtn]));
		w7.TopAttach = ((uint)(2));
		w7.BottomAttach = ((uint)(3));
		w7.LeftAttach = ((uint)(2));
		w7.RightAttach = ((uint)(3));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		this.RootContainer.Add (this.AuthInfoContainer);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.RootContainer [this.AuthInfoContainer]));
		w8.Position = 0;
		w8.Expand = false;
		w8.Fill = false;
		// Container child RootContainer.Gtk.Box+BoxChild
		this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
		this.scrolledwindow1.CanFocus = true;
		this.scrolledwindow1.Name = "scrolledwindow1";
		this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow1.Gtk.Container+ContainerChild
		global::Gtk.Viewport w9 = new global::Gtk.Viewport ();
		w9.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport.Gtk.Container+ContainerChild
		this.InfoListContainer = new global::Gtk.Table (((uint)(1)), ((uint)(1)), false);
		this.InfoListContainer.Name = "InfoListContainer";
		this.InfoListContainer.RowSpacing = ((uint)(6));
		this.InfoListContainer.ColumnSpacing = ((uint)(6));
		w9.Add (this.InfoListContainer);
		this.scrolledwindow1.Add (w9);
		this.RootContainer.Add (this.scrolledwindow1);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.RootContainer [this.scrolledwindow1]));
		w12.Position = 1;
		this.Add (this.RootContainer);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.LoginBtn.Clicked += new global::System.EventHandler (this.LoginClicked);
	}
}
