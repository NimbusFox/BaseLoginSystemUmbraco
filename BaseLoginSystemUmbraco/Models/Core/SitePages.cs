using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace BaseLoginSystemUmbraco.Models.Core {
    public class SitePages {
        public IPublishedContent DefaultPage { get; }
        private List<IPublishedContent> defaultItem { get; } = new List<IPublishedContent>();

        public SitePages(IPublishedContent page) {
            DefaultPage = page.GetPropertyValue("defaultPage", defaultItem).FirstOrDefault();
        }
    }
}