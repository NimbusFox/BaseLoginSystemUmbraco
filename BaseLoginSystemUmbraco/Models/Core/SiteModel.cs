using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace BaseLoginSystemUmbraco.Models.Core {
    public class SiteModel : MasterModel {
        public SitePagesModel Pages { get; }
        public IPublishedContent Menu { get; }

        public SiteModel(IPublishedContent page) : base(page) {
            Pages = new SitePagesModel(page);
            Menu = page.GetPropertyValue("menu", new List<IPublishedContent>()).FirstOrDefault();
        }
    }
}