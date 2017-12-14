using SM.UI.Mvc.Enumeradores;
using System;
using System.Collections.Generic;

namespace SM.UI.Mvc.Classes.toastr
{
    [Serializable]
    public class Toastr
    {
        public List<ToastMessage> ToastMessages { get; set; }

        public ToastMessage AddToastMessage(string message, string title, ToastType toastType, bool IsSticky)
        {
            var toast = new ToastMessage()
            {
                Title = title,
                Message = message,
                ToastType = toastType.ToString().ToLower(),
                IsSticky = IsSticky
            };
            ToastMessages.Add(toast);
            return toast;
        }

        public Toastr()
        {
            ToastMessages = new List<ToastMessage>();
        }
    }
}