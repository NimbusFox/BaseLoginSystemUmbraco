using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseLoginSystemUmbraco.Models.Core.ContentBuilder;
using BaseLoginSystemUmbraco.Models.Core.Menu;
using Umbraco.Core.Models;
using Umbraco.Web.Mvc;

namespace BaseLoginSystemUmbraco.Controllers.Core {
    public class ContentBuilderController : SurfaceController {
        public ActionResult MenuRoot(IPublishedContent page) {
            return PartialView("Core/Menu/MenuRoot", new MenuRootModel(page));
        }

        public ActionResult MenuLink(IPublishedContent page) {
            return PartialView("Core/Menu/MenuLink", new MenuLinkModel(page));
        }

        public ActionResult MenuDropDown(IPublishedContent page) {
            return PartialView("Core/Menu/MenuDropdown", new MenuDropdownModel(page));
        }

        public ActionResult Content(IPublishedContent page) {
            return PartialView("Core/ContentBuilder/Content", new ContentModel(page));
        }
    }
}