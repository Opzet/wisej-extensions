﻿///////////////////////////////////////////////////////////////////////////////
//
// (C) 2022 ICE TEA GROUP LLC - ALL RIGHTS RESERVED
//
// 
//
// ALL INFORMATION CONTAINED HEREIN IS, AND REMAINS
// THE PROPERTY OF ICE TEA GROUP LLC AND ITS SUPPLIERS, IF ANY.
// THE INTELLECTUAL PROPERTY AND TECHNICAL CONCEPTS CONTAINED
// HEREIN ARE PROPRIETARY TO ICE TEA GROUP LLC AND ITS SUPPLIERS
// AND MAY BE COVERED BY U.S. AND FOREIGN PATENTS, PATENT IN PROCESS, AND
// ARE PROTECTED BY TRADE SECRET OR COPYRIGHT LAW.
//
// DISSEMINATION OF THIS INFORMATION OR REPRODUCTION OF THIS MATERIAL
// IS STRICTLY FORBIDDEN UNLESS PRIOR WRITTEN PERMISSION IS OBTAINED
// FROM ICE TEA GROUP LLC.
//
///////////////////////////////////////////////////////////////////////////////

namespace Wisej.Web.Ext.NavigationBar
{
	/// <summary>
	/// Represents a menu item in the context menu displayed when the
	/// <see cref="NavigationBar.CompactView"/> is true and the user
	/// selects an item with child items.
	/// </summary>
	public class NavigationBarMenuItem : MenuItem
	{
		/// <summary>
		/// Returns or sets the <see cref="NavigationBarItem"/> that corresponds to this menu item.
		/// </summary>
		public NavigationBarItem Item { get; set; }

		#region Wisej Implementation

		protected override void OnWebRender(dynamic config)
		{
			base.OnWebRender((object)config);

			if (config.className == "wisej.web.menu.MenuItem")
				config.className = "wisej.web.ext.NavigationBarMenuItem";
		}

		#endregion
	}
}