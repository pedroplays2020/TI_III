using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalLuz.Models;
namespace HospitalLuz.Controllers
{
    public class NovoController : Controller
    {
        
        public ActionResult AddCliente()
        {
            try
            {
                Cliente novo = new Cliente();
                return View(novo);
            }
            catch (Exception erro)
            {

                throw;
            }
        }

        [HttpPost]
        public ActionResult AddCliente(Cliente novo, HttpPostedFileBase fich)
        {
            try
            {
                using (StandTintIII_MBEntities db = new StandTintIII_MBEntities())
                {
                    db.Clientes.Add(novo);
                    db.SaveChanges();
                    if (fich.ContentLength > 0 && fich.ContentType.Contains("image")) {
                        string caminho = "~/fotos/" + novo.Idcli.ToString() + System.IO.Path.GetExtension(fich.FileName);
                        novo.fotopath = caminho;
                        fich.SaveAs(Server.MapPath(caminho));
                        db.SaveChanges();
                    }
                    return RedirectToAction("Index", "Novo", new { msg = "Registo inserido com sucesso" });
                }
            }
            catch (Exception erro)
            {

                return RedirectToAction("Index", "Novo", new { msg = erro.Message });
            }
        }


        public ActionResult Index()
        {
            using (StandTintIII_MBEntities db = new StandTintIII_MBEntities()) {
                List<Cliente> clientes = db.Clientes.ToList();
                return View(clientes);
            }
        
        }


    }
}