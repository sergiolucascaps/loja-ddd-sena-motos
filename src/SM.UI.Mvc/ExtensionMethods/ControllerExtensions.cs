using Newtonsoft.Json;
using SM.UI.Mvc.Classes.toastr;
using SM.UI.Mvc.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SM.UI.Mvc.ExtensionMethods
{
    public static class ControllerExtensions
    {
        public static ToastMessage AddToastMessage(this Controller controller, string message, string title, ToastType toastType = ToastType.Info, bool IsSticky = false)
        {
            Toastr toastr = controller.TempData["Toastr"] as Toastr;
            toastr = toastr ?? new Toastr();

            var toastMessage = toastr.AddToastMessage(message, title, toastType, IsSticky);
            controller.TempData["Toastr"] = toastr;
            return toastMessage;
        }
    }
}