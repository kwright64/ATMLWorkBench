﻿/*
* Copyright (c) 2014 Universal Technical Resource Services, Inc.
*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v. 2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at http://mozilla.org/MPL/2.0/.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATMLModelLibrary.model.common;
using ATMLModelLibrary.model.equipment;

namespace ATMLCommonLibrary.forms
{

    public partial class ContactForm : ATMLForm
    {
        private ManufacturerDataContact contact;
        public ManufacturerDataContact Contact
        {
            get
            { ControlsToData(); return contact; }
            set { contact = value; DataToControls();  }
        }

        public ContactForm()
        {
            InitializeComponent();
            contact = new ManufacturerDataContact();
        }

        public ContactForm( ManufacturerDataContact contact )
        {
            InitializeComponent();
            this.contact = contact;
        }


        private void DataToControls()
        {
            if (contact != null)
            {
                edtEmail.Value = contact.email;
                edtName.Value = contact.name;
                edtPhone.Value = contact.phoneNumber;
            }
        }

        private void ControlsToData()
        {
            if (contact == null)
                contact = new ManufacturerDataContact();
            contact.email = edtEmail.GetValue<string>();
            contact.name = edtName.GetValue<string>();
            contact.phoneNumber = edtPhone.GetValue<string>();
        }
			
    }
}
