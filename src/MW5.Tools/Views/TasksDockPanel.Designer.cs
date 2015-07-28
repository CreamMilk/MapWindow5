﻿namespace MW5.Tools.Views
{
    partial class TasksDockPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolGroup = new System.Windows.Forms.ToolStripButton();
            this.toolClear = new System.Windows.Forms.ToolStripButton();
            this.tasksTreeView1 = new MW5.Tools.Views.TasksTreeView();
            this.toolStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksTreeView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolGroup,
            this.toolClear});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 0);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.ShowCaption = false;
            this.toolStripEx1.ShowItemToolTips = true;
            this.toolStripEx1.Size = new System.Drawing.Size(238, 37);
            this.toolStripEx1.TabIndex = 2;
            this.toolStripEx1.Text = "toolStripEx1";
            // 
            // toolGroup
            // 
            this.toolGroup.Checked = true;
            this.toolGroup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGroup.Image = global::MW5.Tools.Properties.Resources.img_group24;
            this.toolGroup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGroup.Name = "toolGroup";
            this.toolGroup.Padding = new System.Windows.Forms.Padding(3);
            this.toolGroup.Size = new System.Drawing.Size(34, 34);
            this.toolGroup.Text = "Group by Tool";
            this.toolGroup.ToolTipText = "Group by Tool";
            // 
            // toolClear
            // 
            this.toolClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolClear.Image = global::MW5.Tools.Properties.Resources.img_clear24;
            this.toolClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolClear.Name = "toolClear";
            this.toolClear.Padding = new System.Windows.Forms.Padding(3);
            this.toolClear.Size = new System.Drawing.Size(34, 34);
            this.toolClear.Text = "Clear All";
            // 
            // tasksTreeView1
            // 
            this.tasksTreeView1.ApplyStyle = true;
            this.tasksTreeView1.BeforeTouchSize = new System.Drawing.Size(238, 218);
            this.tasksTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tasksTreeView1.CanSelectDisabledNode = false;
            this.tasksTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.tasksTreeView1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tasksTreeView1.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.tasksTreeView1.HelpTextControl.Name = "helpText";
            this.tasksTreeView1.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.tasksTreeView1.HelpTextControl.TabIndex = 0;
            this.tasksTreeView1.HelpTextControl.Text = "help text";
            this.tasksTreeView1.Location = new System.Drawing.Point(0, 37);
            this.tasksTreeView1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.tasksTreeView1.Name = "tasksTreeView1";
            this.tasksTreeView1.ShowFocusRect = true;
            this.tasksTreeView1.ShowSuperTooltip = false;
            this.tasksTreeView1.Size = new System.Drawing.Size(238, 218);
            this.tasksTreeView1.TabIndex = 3;
            this.tasksTreeView1.Text = "_gisResultsTreeView1";
            // 
            // 
            // 
            this.tasksTreeView1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.tasksTreeView1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tasksTreeView1.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.tasksTreeView1.ToolTipControl.Name = "toolTip";
            this.tasksTreeView1.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.tasksTreeView1.ToolTipControl.TabIndex = 1;
            this.tasksTreeView1.ToolTipControl.Text = "toolTip";
            this.tasksTreeView1.ToolTipDuration = 0;
            // 
            // TasksDockPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tasksTreeView1);
            this.Controls.Add(this.toolStripEx1);
            this.Name = "TasksDockPanel";
            this.Size = new System.Drawing.Size(238, 255);
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksTreeView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton toolGroup;
        private System.Windows.Forms.ToolStripButton toolClear;
        private TasksTreeView tasksTreeView1;
    }
}
