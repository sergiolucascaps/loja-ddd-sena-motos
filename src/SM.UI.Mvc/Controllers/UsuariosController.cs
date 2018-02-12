using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SM.Application.ViewModels;
using SM.UI.Mvc.Models;
using SM.Application;
using SM.UI.Mvc.ExtensionMethods;
using SM.UI.Mvc.Enumeradores;
using System.Threading;
using SM.UI.Mvc.Classes;

namespace SM.UI.Mvc.Controllers
{
    //[RoutePrefix("administrativo-usuarios")]
    public class UsuariosController : Controller
    {
        private readonly UsuarioAppService _usuarioAppService;

        public UsuariosController()
        {
            _usuarioAppService = new UsuarioAppService();
        }

        // GET: Usuarios
        //[Route("listar")]
        public ActionResult Index()
        {
            return View(_usuarioAppService.ObterTodos().Where(u => !u.Flg_Inativo).OrderBy(u => u.Nme_Usuario));
        }
        
        // GET: Usuarios/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                //this.AddToastMessage("Não foi possível exibir os detalhes deste usuário, por favor tente novamente", "Problema ao ver detalhes", ToastType.Error, true);
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

        // GET: Usuarios/Create
        //[Route("incluir-novo")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Route("incluir-novo")]
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

        // GET: Usuarios/Edit/5
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

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Usuarios/Delete/5
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

        // POST: Usuarios/Delete/5
        [ValidateAntiForgeryToken]
        //[Route("{id:guid}/excluir")]
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