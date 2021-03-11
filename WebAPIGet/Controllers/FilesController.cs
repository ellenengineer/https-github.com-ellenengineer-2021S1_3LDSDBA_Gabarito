using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIGet.Controllers
{
    [Route("fapen/files")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        // GET: api/<FilesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string arquivo = "Produtos.txt";
            string diretorio = @"C:\Fapen\";
            string caminho = diretorio + arquivo;

            List<string> lstProdutos = new List<string>();
            if (System.IO.File.Exists(caminho))
            {
                try
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(caminho))
                    {
                        String linha;


                        // Lê linha por linha até o final do arquivo
                        while ((linha = sr.ReadLine()) != null)
                        {
                            lstProdutos.Add(linha);
                        }
                        return lstProdutos;
                    }
                }
                catch (Exception ex)
                {
                    return new string[] { ex.Message };
                }
            }
            else
            {
                return new string[] { "arquivo não localizado" };
            }

        }

        // GET api/<FilesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FilesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FilesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FilesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
