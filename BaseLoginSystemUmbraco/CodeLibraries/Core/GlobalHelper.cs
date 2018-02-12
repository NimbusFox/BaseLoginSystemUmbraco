using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace BaseLoginSystemUmbraco.CodeLibraries.Core {
    public class GlobalHelper {
        public static IPublishedContent GetRoot() {
            var cs = ApplicationContext.Current.Services.ContentService;

            var data = GetNode(cs.GetRootContent().First().Id);

            return data;
        }

        public static IPublishedContent GetRoot(IPublishedContent page) {
            var current = page;

            while (current.Parent != null) {
                current = current.Parent;
            }

            return current;
        } 

        public static IPublishedContent GetNode(int nodeId) {
            return new UmbracoHelper(UmbracoContext.Current).TypedContent(nodeId);
        }
    }
}