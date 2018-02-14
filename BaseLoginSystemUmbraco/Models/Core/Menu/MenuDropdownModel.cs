using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace BaseLoginSystemUmbraco.Models.Core.Menu {
    public class MenuDropdownModel {
        public string Text { get; }
        public List<IPublishedContent> Children { get; }

        public MenuDropdownModel(IPublishedContent page) {
            Text = page.GetPropertyValue<string>("text", "");
            Children = page.Children.ToList();
        }
    }
}