﻿[%@ template inherits="CodeFluent.Producers.UI.BaseTemplate" %]
[%@ namespace name="System" %]
[%@ namespace name="CodeFluent.Model" %]
[%@ namespace name="CodeFluent.Runtime" %]
[%@ namespace name="CodeFluent.Runtime.Utilities" %]

[%@ template
enumerable="Producer.Project.Entities"
enumerableItemName="entity"
enumerableTargetPathFunc='Path.Combine(Path.GetDirectoryName(TargetPath), entity.Name) + "View.xaml.cs"' %]
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:$clrversion$
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Input;
using CodeFluent.Runtime;
using [%=Producer.SyncfusionWPFAssemblyNamespace%].Runtime;

namespace [%=Producer.SyncfusionWPFAssemblyNamespace%].Controls
{
	public partial class [%=entity.Name%]View : UserControl, IEntityView
	{			        
		public [%=entity.Name%]View() 
		{
			InitializeComponent();
			Reload();
		}
		
		public void Reload()
		{
			try
			{
				Application.Current.MainWindow.Cursor = Cursors.Wait;
				this.GridFusion.ItemsSource = [%=entity.Set.ProxyClrFullTypeName%].[%=entity.LoadAllMethod.Name%]();
			}
			catch (CodeFluent.Runtime.CodeFluentRuntimeException)
			{
				MessageBox.Show("An error occured while trying to contact the service, please check that your service is running and that the .config file is correct", "");
				
			}
			finally
			{
				Application.Current.MainWindow.Cursor = Cursors.Arrow;
			}
		}
		
		public void Clear()
		{
			this.GridFusion.ItemsSource = null;
		}
	}
}