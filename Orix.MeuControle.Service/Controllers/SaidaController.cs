﻿using Orix.MeuControle.Domain.Mapa;
using Orix.MeuControle.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Orix.MeuControle.Service.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SaidaController : ApiController
    {
        SaidaRepository _repository = new SaidaRepository();
        // GET: api/v1/Saida
        public IEnumerable<SaidaDomainModel> Get()
        {
            return _repository.Listar();
        }

        // GET: api/v1/Saida/5
        public SaidaDomainModel Get(int id)
        {
            return _repository.Buscar(id);
        }

        // POST: api/v1/Saida
        public SaidaDomainModel Post([FromBody]SaidaDomainModel value)
        {
            return _repository.Cadastrar(value);
        }

        // PUT: api/v1/Saida/5
        public void Put([FromBody]SaidaDomainModel value)
        {
            _repository.Editar(value);
        }

        // DELETE: api/v1/Saida/5
        public void Delete(int id)
        {
            _repository.Excluir(id);
        }
    }
}
