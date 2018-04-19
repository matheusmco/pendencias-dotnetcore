using System;
using CommonLibrary.Helpers;
using CommonLibrary.Libraries;
using Microsoft.AspNetCore.Mvc;
using WAPendencia.Models;

namespace WAPendencia.Controllers
{
    [Route("api/[controller]")]
    public class PendenciaController : Controller
    {
        PendenciaBo bo = new PendenciaBo();
        [HttpPost]
        public object Gravar([FromBody]PendenciaModel pendencia)
        {
            try
            {
                return new
                {
                    resultado = bo.Gravar(pendencia)
                };
            }
            catch (RegraNegocioException ex) { return ExceptionLibrary.tratarRNException(ex.Message); }
            catch (Exception ex)
            {
                return ExceptionLibrary.tratarLogException("Gravar", "Problemas ao gravar pendência. Entre em contato com o administrador do sistema", ex);
            }
        }

        [HttpGet]
        public object Consultar([FromQuery] int pendenciaId)
        {
            try
            {
                return new
                {
                    resultado = bo.Consultar(pendenciaId)
                };
            }
            catch (RegraNegocioException ex) { return ExceptionLibrary.tratarRNException(ex.Message); }
            catch (Exception ex)
            {
                return ExceptionLibrary.tratarLogException("Consultar", "Problemas ao consultar pendência. Entre em contato com o administrador do sistema", ex);
            }
        }

        [HttpPost]
        public object Listar()
        {
            try
            {
                return new
                {
                    resultado = bo.Listar()
                };
            }
            catch (RegraNegocioException ex) { return ExceptionLibrary.tratarRNException(ex.Message); }
            catch (Exception ex)
            {
                return ExceptionLibrary.tratarLogException("Listar", "Problemas ao listar pendências. Entre em contato com o administrador do sistema", ex);
            }
        }

        [HttpGet]
        public object Excluir([FromQuery] int pendenciaId)
        {
            try
            {
                bo.Excluir(pendenciaId);
                return new { };
            }
            catch (RegraNegocioException ex) { return ExceptionLibrary.tratarRNException(ex.Message); }
            catch (Exception ex)
            {
                return ExceptionLibrary.tratarLogException("Gravar", "Problemas ao excluir pendência. Entre em contato com o administrador do sistema", ex);
            }
        }
    }
}
