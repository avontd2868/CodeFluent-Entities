﻿[%@ template inherits="CodeFluent.Producers.UI.BaseTemplate" %]
[%@ namespace name="System" %]
[%@ namespace name="System.Collections.Generic" %]
[%@ namespace name="CodeFluent.Model" %]
[%@ namespace name="CodeFluent.Runtime" %]
[%@ namespace name="CodeFluent.Runtime.Utilities" %]
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:[%=System.Environment.Version%]
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using [%=Producer.SyncfusionWPFAssemblyNamespace%].Controls;
using [%=Producer.SyncfusionWPFAssemblyNamespace%].Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace [%=Producer.SyncfusionWPFAssemblyNamespace%].ViewModels
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
	    [%for (int i = 0; i < Producer.Project.Entities.Count; i++) { %]
            	Applications.Add(new ApplicationTile() { Name = "[%= Producer.Project.Entities[i].Name %]", Color = "[%= SyncfusionResources.GetColor(i) %]", View = new [%= Producer.Project.Entities[i].Name %]View(), Header = "[%= Producer.Project.Entities[i].Name.ToUpper() %]" });
	   [% } %]
        }
    }
}

[%@Member 
public class SyncfusionResources
{
	static Random Rand = new Random();

	public static string GetColor(int index)
	{
		Dictionary<int, string> colorDictionary = new Dictionary<int, string>();
		colorDictionary.Add(0, "#ff0078");
		colorDictionary.Add(1, "#7439d6");
		colorDictionary.Add(2, "#ffd374");
		colorDictionary.Add(3, "#58d185");

		return colorDictionary[index % 4];
	}
}
%]
