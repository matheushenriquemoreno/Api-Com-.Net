﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sistemaGerenciamentoAssistenciaTecnica.Model;
using sistemaGerenciamentoAssistenciaTecnica.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaGerenciamentoAssistenciaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipamentoClienteController : BaseController<EquipamentoCliente>
    {
        public EquipamentoClienteController(IRepositoryBase<EquipamentoCliente> repositoryBase) : base(repositoryBase) { }
    }
}
