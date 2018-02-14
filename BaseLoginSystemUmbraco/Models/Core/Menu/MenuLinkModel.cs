using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace BaseLoginSystemUmbraco.Models.Core.Menu {
    public class MenuLinkModel {
        public string Text { get; }
        public IPublishedContent Page { get; }
        public string Link { get; }
        public bool NewTab { get; }

        public MenuLinkModel(IPublishedContent page) {
            Text = page.GetPropertyValue<string>("text", "");
            Page = page.GetPropertyValue("page", new List<IPublishedContent>()).FirstOrDefault();
            Link = page.GetPropertyValue<string>("link", "");
            NewTab = page.GetPropertyValue("newTab", defaultValue: false);
        }

        public string GetUrl() {
            if (!Link.IsNullOrWhiteSpace()) {
                return Link;
            }

            if (Page != null) {
                return Page.UrlWithDomain();
            }

            return "";
        }
    }
}