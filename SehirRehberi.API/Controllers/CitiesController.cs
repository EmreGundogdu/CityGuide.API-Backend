using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SehirRehberi.API.Data;
using SehirRehberi.API.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        IAppRepository _appRepository;
        IMapper _mapper;

        public CitiesController(IAppRepository appRepository,IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }
        public ActionResult GetCities()
        {
            var cities = _appRepository.GetCities();
            var citiesToReturn = _mapper.Map<List<CityForListDto>>(cities);
            return Ok(citiesToReturn);
        }
    }
}
