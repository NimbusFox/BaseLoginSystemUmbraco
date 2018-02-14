using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;

namespace BaseLoginSystemUmbraco.Models.Core.Menu {
    public class MenuRootModel : MasterModel {
        public bool HasChildren { get; }
        public List<IPublishedContent> Children { get; }

        public MenuRootModel(IPublishedContent page) : base(page) {
            HasChildren = page.Children.Any();
            Children = page.Children.ToList();
        }
    }
}