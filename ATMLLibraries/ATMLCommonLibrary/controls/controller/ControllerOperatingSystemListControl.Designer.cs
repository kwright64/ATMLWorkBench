/*
* Copyright (c) 2014 Universal Technical Resource Services, Inc.
* 
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v. 2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at http://mozilla.org/MPL/2.0/.
*/

namespace ATMLCommonLibrary.controls.controller
{
    partial class ControllerOperatingSystemListControl
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
            this.SuspendLayout();
            // 
            // ControllerOperatingSystemListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ControllerOperatingSystemListControl";
            this.TooltipTextAddButton = "Press to add a new Operating System";
            this.TooltipTextDeleteButton = "Press to delete the selected Operating System";
            this.TooltipTextEditButton = "Press to edit the selected Operating System";
            this.ResumeLayout(false);

        }

        #endregion
    }
}
