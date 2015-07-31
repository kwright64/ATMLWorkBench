﻿/*
* Copyright (c) 2014 Universal Technical Resource Services, Inc.
*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v. 2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at http://mozilla.org/MPL/2.0/.
*/
namespace ATMLCommonLibrary.forms
{
    partial class SignalFunctionTypeForm
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
            this.signalFunctionTypeControl = new ATMLCommonLibrary.controls.signal.SignalFunctionTypeControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.signalFunctionTypeControl);
            this.panel1.Size = new System.Drawing.Size(530, 505);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(468, 524);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(387, 524);
            // 
            // lblDenoteRequiredField
            // 
            this.lblDenoteRequiredField.Location = new System.Drawing.Point(1, 534);
            // 
            // signalFunctionTypeControl1
            // 
            this.signalFunctionTypeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signalFunctionTypeControl.Location = new System.Drawing.Point(0, 0);
            this.signalFunctionTypeControl.Name = "signalFunctionTypeControl1";
            this.signalFunctionTypeControl.Size = new System.Drawing.Size(530, 505);
            this.signalFunctionTypeControl.TabIndex = 0;
            // 
            // SignalFunctionTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 548);
            this.Name = "SignalFunctionTypeForm";
            this.Text = "Signal Function Type";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.signal.SignalFunctionTypeControl signalFunctionTypeControl;
    }
}