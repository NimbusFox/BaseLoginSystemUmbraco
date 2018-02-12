using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;

namespace BaseLoginSystemUmbraco.Models.Core {
    public class SiteModel : MasterModel {
        public SitePages Pages { get; }

        public SiteModel(IPublishedContent page) : base(page) {
            Pages = new SitePages(page);
        }
    }
}