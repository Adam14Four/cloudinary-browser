using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void LoginClicked (object sender, EventArgs e)
	{
		var label = new Label ("Login pressed!") { Visible = true };
		InfoListContainer.Attach (label, 0, 1, InfoListContainer.NRows, InfoListContainer.NRows + 1);
	}
}
