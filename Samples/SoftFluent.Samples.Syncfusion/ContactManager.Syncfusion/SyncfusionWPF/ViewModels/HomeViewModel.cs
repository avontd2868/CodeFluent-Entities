﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ContactManager.WPFSyncfusion.Controls;
using ContactManager.WPFSyncfusion.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.WPFSyncfusion.ViewModels
{
    public class HomeViewModel
    {
        private ObservableCollection<ApplicationTile> apps;

        public ObservableCollection<ApplicationTile> Applications
        {
            get { return apps; }
            set { apps = value; }
        }

        public HomeViewModel()
        {
            Applications = new ObservableCollection<ApplicationTile>();
	    
            	Applications.Add(new ApplicationTile() { Name = "Address",Icon = "/Resources/Monitor.png", Color = "#FF555BBE", View = new AddressView(), Header = "Address" });
	   
            	Applications.Add(new ApplicationTile() { Name = "Contact",Icon = "/Resources/Monitor.png", Color = "#FF36377C", View = new ContactView(), Header = "Contact" });
	   
            	Applications.Add(new ApplicationTile() { Name = "ContactSource",Icon = "/Resources/Twitter.png", Color = "#FF36377C", View = new ContactSourceView(), Header = "ContactSource" });
	   
            	Applications.Add(new ApplicationTile() { Name = "User",Icon = "/Resources/Twitter.png", Color = "#FFD68513", View = new UserView(), Header = "User" });
	   
        }
    }
}

