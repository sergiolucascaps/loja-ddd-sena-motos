using SM.Application.Interfaces;
using SM.Application.ViewModels;
using SM.UI.Mvc.Classes;
using SM.UI.Mvc.Enumeradores;
using SM.UI.Mvc.ExtensionMethods;
using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace SM.UI.Mvc.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioAppService _usuarioAppService;

        public UsuariosController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }
        
        public ActionResult Index()
        {
            return View(_usuarioAppService.ObterTodos().Where(u => !u.Flg_Inativo).OrderBy(u => u.Nme_Usuario));
        }
        
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var usuario = _usuarioAppService.ObterPorId(id.Value);

            if (usuario == null)
            {
                return HttpNotFound();
            }

            var folders = System.Configuration.ConfigurationManager.AppSettings["CaminhoImagensPerfil"];
            var pathAplicacao = AppDomain.CurrentDomain.BaseDirectory;
            var caminho = pathAplicacao + folders;

            var imgBase64 = Util.ReadFileOnServer(caminho + usuario.Idf_Usuario.ToString() + ".txt");
            usuario.Imagem = imgBase64;
            return View("_Details", usuario);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioUsuarioImagemViewModel objUsuarioUsuarioImagemViewModel)
        {
            if (ModelState.IsValid)
            {
                var folders = System.Configuration.ConfigurationManager.AppSettings["CaminhoImagensPerfil"];
                var pathAplicacao = AppDomain.CurrentDomain.BaseDirectory;
                var caminho = pathAplicacao + folders;

                Util.SaveTxtFileOnServer(caminho + objUsuarioUsuarioImagemViewModel.Idf_Usuario + ".txt", objUsuarioUsuarioImagemViewModel.Imagem );

                objUsuarioUsuarioImagemViewModel.Imagem = objUsuarioUsuarioImagemViewModel.Idf_Usuario.ToString();

                _usuarioAppService.Adicionar(objUsuarioUsuarioImagemViewModel);
                return RedirectToAction("Index");
            }

            return View(objUsuarioUsuarioImagemViewModel);
        }

        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var usuario = _usuarioAppService.ObterPorId(id.Value);
            if (usuario == null)
            {
                return HttpNotFound();
            }

            var folders = System.Configuration.ConfigurationManager.AppSettings["CaminhoImagensPerfil"];
            var pathAplicacao = AppDomain.CurrentDomain.BaseDirectory;
            var caminho = pathAplicacao + folders;

            var imgBase64 = Util.ReadFileOnServer(caminho + usuario.Idf_Usuario.ToString() + ".txt");
            usuario.Imagem = imgBase64;
            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioUsuarioImagemViewModel objUsuarioUsuarioImagemViewModel)
        {
            if (ModelState.IsValid)
            {
                var folders = System.Configuration.ConfigurationManager.AppSettings["CaminhoImagensPerfil"];
                var pathAplicacao = AppDomain.CurrentDomain.BaseDirectory;
                var caminho = pathAplicacao + folders;

                Util.SaveTxtFileOnServer(caminho + objUsuarioUsuarioImagemViewModel.Idf_Usuario + ".txt", objUsuarioUsuarioImagemViewModel.Imagem);

                objUsuarioUsuarioImagemViewModel.Imagem = objUsuarioUsuarioImagemViewModel.Idf_Usuario.ToString();

                _usuarioAppService.Atualizar(objUsuarioUsuarioImagemViewModel);
                return RedirectToAction("Index");
            }
            return View(objUsuarioUsuarioImagemViewModel);
        }

        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var usuario = _usuarioAppService.ObterPorId(id.Value);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View("_Delete", usuario);
        }

        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _usuarioAppService.Remover(id);
            this.AddToastMessage("O usuário foi deletado!", "Sucesso", ToastType.Success, false);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _usuarioAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}