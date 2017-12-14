using SM.UI.Mvc.Enumeradores;
using System;

namespace SM.UI.Mvc.Classes.toastr
{
    [Serializable]
    public class ToastMessage
    {
        public string       Title       { get; set; }
        public string       Message     { get; set; }
        public string       ToastType   { get; set; }
        public bool         IsSticky    { get; set; }
    }
}