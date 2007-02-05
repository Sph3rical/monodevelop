// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.VersionControl.Dialogs {
    
    
    public partial class EditRepositoryDialog {
        
        private Gtk.VBox vbox1;
        
        private Gtk.Table table1;
        
        private Gtk.Entry entryName;
        
        private Gtk.Label label11;
        
        private Gtk.Label label8;
        
        private Gtk.ComboBox versionControlType;
        
        private Gtk.HSeparator hseparator2;
        
        private Gtk.EventBox repoEditorContainer;
        
        private Gtk.Button button10;
        
        private Gtk.Button button24;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize();
            // Widget MonoDevelop.VersionControl.Dialogs.EditRepositoryDialog
            this.Name = "MonoDevelop.VersionControl.Dialogs.EditRepositoryDialog";
            this.Title = Mono.Unix.Catalog.GetString("Repository Configuration");
            this.DefaultWidth = 500;
            // Internal child MonoDevelop.VersionControl.Dialogs.EditRepositoryDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Events = ((Gdk.EventMask)(256));
            w1.Name = "dialog-vbox3";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog-vbox3.Gtk.Box+BoxChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            this.vbox1.BorderWidth = ((uint)(6));
            // Container child vbox1.Gtk.Box+BoxChild
            this.table1 = new Gtk.Table(((uint)(2)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.entryName = new Gtk.Entry();
            this.entryName.CanFocus = true;
            this.entryName.Name = "entryName";
            this.entryName.IsEditable = true;
            this.entryName.InvisibleChar = '●';
            this.table1.Add(this.entryName);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.table1[this.entryName]));
            w2.TopAttach = ((uint)(1));
            w2.BottomAttach = ((uint)(2));
            w2.LeftAttach = ((uint)(1));
            w2.RightAttach = ((uint)(2));
            w2.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table1.Gtk.Table+TableChild
            this.label11 = new Gtk.Label();
            this.label11.Name = "label11";
            this.label11.Xalign = 0F;
            this.label11.LabelProp = Mono.Unix.Catalog.GetString("Type:");
            this.table1.Add(this.label11);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table1[this.label11]));
            w3.XOptions = ((Gtk.AttachOptions)(4));
            w3.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table1.Gtk.Table+TableChild
            this.label8 = new Gtk.Label();
            this.label8.Name = "label8";
            this.label8.Xalign = 0F;
            this.label8.LabelProp = Mono.Unix.Catalog.GetString("Name:");
            this.table1.Add(this.label8);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table1[this.label8]));
            w4.TopAttach = ((uint)(1));
            w4.BottomAttach = ((uint)(2));
            w4.XOptions = ((Gtk.AttachOptions)(4));
            w4.YOptions = ((Gtk.AttachOptions)(0));
            // Container child table1.Gtk.Table+TableChild
            this.versionControlType = Gtk.ComboBox.NewText();
            this.versionControlType.Name = "versionControlType";
            this.table1.Add(this.versionControlType);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table1[this.versionControlType]));
            w5.LeftAttach = ((uint)(1));
            w5.RightAttach = ((uint)(2));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            this.vbox1.Add(this.table1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox1[this.table1]));
            w6.Position = 0;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hseparator2 = new Gtk.HSeparator();
            this.hseparator2.Name = "hseparator2";
            this.vbox1.Add(this.hseparator2);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox1[this.hseparator2]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.repoEditorContainer = new Gtk.EventBox();
            this.repoEditorContainer.Name = "repoEditorContainer";
            this.vbox1.Add(this.repoEditorContainer);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox1[this.repoEditorContainer]));
            w8.Position = 2;
            w1.Add(this.vbox1);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(w1[this.vbox1]));
            w9.Position = 0;
            // Internal child MonoDevelop.VersionControl.Dialogs.EditRepositoryDialog.ActionArea
            Gtk.HButtonBox w10 = this.ActionArea;
            w10.Events = ((Gdk.EventMask)(256));
            w10.Name = "GtkDialog_ActionArea";
            w10.Spacing = 10;
            w10.BorderWidth = ((uint)(5));
            w10.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child GtkDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button10 = new Gtk.Button();
            this.button10.CanDefault = true;
            this.button10.CanFocus = true;
            this.button10.Name = "button10";
            this.button10.UseStock = true;
            this.button10.UseUnderline = true;
            this.button10.Label = "gtk-cancel";
            this.AddActionWidget(this.button10, -6);
            Gtk.ButtonBox.ButtonBoxChild w11 = ((Gtk.ButtonBox.ButtonBoxChild)(w10[this.button10]));
            w11.Expand = false;
            w11.Fill = false;
            // Container child GtkDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button24 = new Gtk.Button();
            this.button24.CanDefault = true;
            this.button24.CanFocus = true;
            this.button24.Name = "button24";
            this.button24.UseStock = true;
            this.button24.UseUnderline = true;
            this.button24.Label = "gtk-ok";
            this.AddActionWidget(this.button24, -5);
            Gtk.ButtonBox.ButtonBoxChild w12 = ((Gtk.ButtonBox.ButtonBoxChild)(w10[this.button24]));
            w12.Position = 1;
            w12.Expand = false;
            w12.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultHeight = 414;
            this.Show();
            this.versionControlType.Changed += new System.EventHandler(this.OnVersionControlTypeChanged);
            this.entryName.Changed += new System.EventHandler(this.OnEntryNameChanged);
        }
    }
}
