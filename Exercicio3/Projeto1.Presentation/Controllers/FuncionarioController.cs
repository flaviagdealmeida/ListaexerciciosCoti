using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto1.Presentation.Models;
using Projeto1.Entities_;
using Projeto1.BLL_;
using Projeto1.DAL_;

namespace Projeto1.Presentation.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(FuncionarioCadastroModel model)
        {


            if (ModelState.IsValid)
            {
                try
                {

                    Funcionario funcionario = new Funcionario();
                    funcionario.Nome = model.Nome;
                    funcionario.Salario = model.Salario;
                    funcionario.DataAdmissao = model.DataAdmissao;


                    FuncionarioBusiness business = new FuncionarioBusiness();
                    business.CadastrarFuncionario(funcionario);

                    TempData["Mensagem"] = $"Funcionario {funcionario.Nome} cadastrado com sucesso !!! ";
                    ModelState.Clear();

                    return RedirectToAction("Cadastro");

                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }


            return View();
        }

        public ActionResult Consulta()
        {
            List<FuncionarioConsultaModel> listagem = new List<FuncionarioConsultaModel>();


            try
            {
                FuncionarioBusiness business = new FuncionarioBusiness();
                foreach (Funcionario funcionario in business.BuscarTodosFuncionarios())
                {
                    FuncionarioConsultaModel model = new FuncionarioConsultaModel();
                    model.IdFuncionario = funcionario.IdFuncionario;
                    model.Nome = funcionario.Nome;
                    model.Salario = funcionario.Salario;
                    model.DataAdmissao = funcionario.DataAdmissao;

                    listagem.Add(model);

                }

            }
            catch (Exception e)
            {
                TempData["Mensagem"] = e.Message;
                throw;
            }

            return View(listagem);
        }

        public ActionResult Edicao(int Id)
        {

            FuncionarioEdicaoModel model = new FuncionarioEdicaoModel();

            try
            {
                FuncionarioBusiness business = new FuncionarioBusiness();
                Funcionario funcionario = business.BuscarTodosFuncionariosPorId(Id);

                model.IdFuncionario = funcionario.IdFuncionario;
                model.Nome = funcionario.Nome;
                model.Salario = funcionario.Salario;
                model.DataAdmissao = funcionario.DataAdmissao;
            }
            catch (Exception e) 
            {

                TempData["Mensagem"] = e.Message;
            }
            return View(model);


        }

        [HttpPost]
        public ActionResult Edicao(FuncionarioEdicaoModel model)

        {
            if (ModelState.IsValid)
            {
                try
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.IdFuncionario = model.IdFuncionario;
                    funcionario.Nome = model.Nome;
                    funcionario.Salario = model.Salario;
                    funcionario.DataAdmissao = model.DataAdmissao;

                    FuncionarioBusiness business = new FuncionarioBusiness();
                    business.AtualizarFuncionario(funcionario);

                    TempData["Mensagem"] = "Funcionario atualizado com sucesso";
                    return RedirectToAction("Consulta");
                }
                catch (Exception e)
                {

                    TempData["Mensagem"] = e.Message;

                }

            }
            return View();

        }
        public ActionResult Exclusao(int Id)
        {
            try
            {
                FuncionarioBusiness business = new FuncionarioBusiness();
                business.ExcluirFuncionario(Id);

                TempData["Mensagem"] = "Funcionário excluído com sucesso";
            }catch(Exception e)
            {
                TempData["Mensagem"] = e.Message;
            }
            return RedirectToAction("Consulta");
        }



    }
}