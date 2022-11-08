using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reimbursment_App.Dtos.User;
using Reimbursment_App.Services.AuthenticationService;

namespace Reimbursment_App.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AuthControler : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthControler(IAuthRepository authRepo)
        {
            _authRepo = authRepo;

        }

        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegistrationDto request)
        {
            var response = await _authRepo.Register(
                new User
                {
                    Username = request.Username,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                    Role = request.Role
                }, request.Password
            );
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
        {
            var response = await _authRepo.Login(request.Username, request.Password);

            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

    }
}