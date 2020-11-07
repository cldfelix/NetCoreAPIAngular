using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreAPIAngular.Domain.Entities;
using NetCoreAPIAngular.Repository;

namespace NetCoreAPIAngular.WebAPI.Controllers
{
    [ApiController]
    [Route("v1/api/[controller]")]
    public class APITestsController : BaseAPIController<Evento>
    {
     
        private readonly ILogger<APITestsController> _logger;

        public APITestsController(DataContext context, ILogger<APITestsController> logger) : base(context) {
            _logger = logger;
        }

      

    }
}
