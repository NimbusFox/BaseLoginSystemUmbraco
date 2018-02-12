using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace BaseLoginSystemUmbraco.Models {
    public class MasterModel {
        public string Title { get; }

        public MasterModel(IPublishedContent page) {
            Title = page.GetPropertyValue<string>("title", "Title");
        }
    }
}