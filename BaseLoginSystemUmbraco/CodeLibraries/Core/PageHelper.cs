using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseLoginSystemUmbraco.Models;
using Umbraco.Core.Models;

namespace BaseLoginSystemUmbraco.CodeLibraries.Core {
    public class PageHelper {
        public static string GetTitle(IPublishedContent page) {
            var root = GlobalHelper.GetRoot(page);

            var output = "";

            var rootModel = new MasterModel(root);

            output += rootModel.Title;

            if (root != page) {
                var pageModel = new MasterModel(page);

                output += " - " + pageModel.Title;
            }

            return output;
        }
    }
}