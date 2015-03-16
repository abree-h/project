namespace LevelEditor
{
    partial class LevelEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showWalkableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletedSelectedTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCtrlDesign = new System.Windows.Forms.TabControl();
            this.tPageDesign = new System.Windows.Forms.TabPage();
            this.tPageCode = new System.Windows.Forms.TabPage();
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.tCtrlDesign.SuspendLayout();
            this.tPageDesign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.layersToolStripMenuItem,
            this.tilesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exportMapToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Save Map As...";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.designViewToolStripMenuItem,
            this.codeViewToolStripMenuItem,
            this.showGridToolStripMenuItem,
            this.showWalkableToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // designViewToolStripMenuItem
            // 
            this.designViewToolStripMenuItem.Name = "designViewToolStripMenuItem";
            this.designViewToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.designViewToolStripMenuItem.Text = "Design View";
            // 
            // codeViewToolStripMenuItem
            // 
            this.codeViewToolStripMenuItem.Name = "codeViewToolStripMenuItem";
            this.codeViewToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.codeViewToolStripMenuItem.Text = "Code View";
            // 
            // showGridToolStripMenuItem
            // 
            this.showGridToolStripMenuItem.Name = "showGridToolStripMenuItem";
            this.showGridToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.showGridToolStripMenuItem.Text = "Show Grid";
            // 
            // showWalkableToolStripMenuItem
            // 
            this.showWalkableToolStripMenuItem.Name = "showWalkableToolStripMenuItem";
            this.showWalkableToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.showWalkableToolStripMenuItem.Text = "Show Walkable";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // exportMapToolStripMenuItem
            // 
            this.exportMapToolStripMenuItem.Name = "exportMapToolStripMenuItem";
            this.exportMapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportMapToolStripMenuItem.Text = "Export Map";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.deselectToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // deselectToolStripMenuItem
            // 
            this.deselectToolStripMenuItem.Name = "deselectToolStripMenuItem";
            this.deselectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deselectToolStripMenuItem.Text = "Deselect";
            // 
            // layersToolStripMenuItem
            // 
            this.layersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLayerToolStripMenuItem,
            this.deleteLayerToolStripMenuItem});
            this.layersToolStripMenuItem.Name = "layersToolStripMenuItem";
            this.layersToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.layersToolStripMenuItem.Text = "Layers";
            // 
            // addLayerToolStripMenuItem
            // 
            this.addLayerToolStripMenuItem.Name = "addLayerToolStripMenuItem";
            this.addLayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addLayerToolStripMenuItem.Text = "Add Layer";
            // 
            // deleteLayerToolStripMenuItem
            // 
            this.deleteLayerToolStripMenuItem.Name = "deleteLayerToolStripMenuItem";
            this.deleteLayerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteLayerToolStripMenuItem.Text = "Delete Layer";
            // 
            // tilesToolStripMenuItem
            // 
            this.tilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTileToolStripMenuItem,
            this.createTileToolStripMenuItem,
            this.deletedSelectedTileToolStripMenuItem,
            this.clearTilesToolStripMenuItem});
            this.tilesToolStripMenuItem.Name = "tilesToolStripMenuItem";
            this.tilesToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.tilesToolStripMenuItem.Text = "Tiles";
            // 
            // addTileToolStripMenuItem
            // 
            this.addTileToolStripMenuItem.Name = "addTileToolStripMenuItem";
            this.addTileToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addTileToolStripMenuItem.Text = "Add Tile";
            // 
            // createTileToolStripMenuItem
            // 
            this.createTileToolStripMenuItem.Name = "createTileToolStripMenuItem";
            this.createTileToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.createTileToolStripMenuItem.Text = "Create Tile";
            // 
            // deletedSelectedTileToolStripMenuItem
            // 
            this.deletedSelectedTileToolStripMenuItem.Name = "deletedSelectedTileToolStripMenuItem";
            this.deletedSelectedTileToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.deletedSelectedTileToolStripMenuItem.Text = "Deleted Selected Tile";
            // 
            // clearTilesToolStripMenuItem
            // 
            this.clearTilesToolStripMenuItem.Name = "clearTilesToolStripMenuItem";
            this.clearTilesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.clearTilesToolStripMenuItem.Text = "Clear Tiles";
            // 
            // tCtrlDesign
            // 
            this.tCtrlDesign.Controls.Add(this.tPageDesign);
            this.tCtrlDesign.Controls.Add(this.tPageCode);
            this.tCtrlDesign.Location = new System.Drawing.Point(0, 27);
            this.tCtrlDesign.Name = "tCtrlDesign";
            this.tCtrlDesign.SelectedIndex = 0;
            this.tCtrlDesign.Size = new System.Drawing.Size(557, 308);
            this.tCtrlDesign.TabIndex = 1;
            // 
            // tPageDesign
            // 
            this.tPageDesign.Controls.Add(this.pbMap);
            this.tPageDesign.Location = new System.Drawing.Point(4, 22);
            this.tPageDesign.Name = "tPageDesign";
            this.tPageDesign.Padding = new System.Windows.Forms.Padding(3);
            this.tPageDesign.Size = new System.Drawing.Size(549, 282);
            this.tPageDesign.TabIndex = 0;
            this.tPageDesign.Text = "Design";
            this.tPageDesign.UseVisualStyleBackColor = true;
            // 
            // tPageCode
            // 
            this.tPageCode.Location = new System.Drawing.Point(4, 22);
            this.tPageCode.Name = "tPageCode";
            this.tPageCode.Padding = new System.Windows.Forms.Padding(3);
            this.tPageCode.Size = new System.Drawing.Size(549, 282);
            this.tPageCode.TabIndex = 1;
            this.tPageCode.Text = "Code";
            this.tPageCode.UseVisualStyleBackColor = true;
            // 
            // pbMap
            // 
            this.pbMap.BackColor = System.Drawing.Color.Gray;
            this.pbMap.Location = new System.Drawing.Point(6, 6);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(70, 52);
            this.pbMap.TabIndex = 0;
            this.pbMap.TabStop = false;
            // 
            // gbTools
            // 
            this.gbTools.Location = new System.Drawing.Point(564, 49);
            this.gbTools.Name = "gbTools";
            this.gbTools.Size = new System.Drawing.Size(103, 282);
            this.gbTools.TabIndex = 2;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "Tools";
            // 
            // LevelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 393);
            this.Controls.Add(this.gbTools);
            this.Controls.Add(this.tCtrlDesign);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LevelEditor";
            this.ShowIcon = false;
            this.Text = "Level Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tCtrlDesign.ResumeLayout(false);
            this.tPageDesign.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showWalkableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletedSelectedTileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTilesToolStripMenuItem;
        private System.Windows.Forms.TabControl tCtrlDesign;
        private System.Windows.Forms.TabPage tPageDesign;
        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.TabPage tPageCode;
        private System.Windows.Forms.GroupBox gbTools;
    }
}

