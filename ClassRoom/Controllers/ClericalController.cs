﻿using System;
using ApplicationService.DataProviders;
using ApplicationService.DTOS;
using Microsoft.AspNetCore.Mvc;

namespace ClassRoom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClericalController : Controller
    {
        public ClericalController(IClerkDataProvider clerkDataProvider)
        {
            _clerkDataProvider = clerkDataProvider;
        }

        private readonly IClerkDataProvider _clerkDataProvider;

        [HttpPost("Add")]
        public void Add(ClerkDTO clerk)
        {
            throw new Exception("khata dar samte server" );
            return _clerkDataProvider.Add(clerk);
        }

        [HttpGet("GetByUserNameAndPassword")]
        public ClerkDTO GetByUserNameAndPassword(string userName, string password)
        {
          return _clerkDataProvider.GetByUserNameAndPassword(userName, password);
        }

    }
}
