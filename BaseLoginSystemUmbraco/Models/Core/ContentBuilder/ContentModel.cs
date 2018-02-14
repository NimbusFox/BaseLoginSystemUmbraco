using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace BaseLoginSystemUmbraco.Models.Core.ContentBuilder {
    public class ContentModel {
        public string Content { get; }

        public ContentModel(IPublishedContent page) {
            Content = page.GetPropertyValue<string>("editor", "");
        }

        public HtmlString GetHtml() {
            return new HtmlString(Content);
        }
    }
}