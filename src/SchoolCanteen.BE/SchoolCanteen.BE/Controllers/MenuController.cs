using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchoolCanteen.BE.Data.Entities;
using SchoolCanteen.BE.Data.Services;
using SchoolCanteen.BE.Dto;
using Swashbuckle.Swagger.Annotations;

namespace SchoolCanteen.BE.Controllers
{
    [RoutePrefix("api/v1/menu")]
    public class MenuController : ApiController
    {
        private readonly MenuService _menuService = new MenuService();

        [Route("getMenu")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(IEnumerable<Menu>))]
        public IEnumerable<MenuResponseDto> Get()
        {
            var menu = _menuService.GetAll();
            return Map(menu);
        }

        private IEnumerable<MenuResponseDto> Map(IEnumerable<Menu> menu)
        {
            return menu.Select(x => new MenuResponseDto
            {
                Id = x.Id,
                Date = x.Date,
                FoodPackets = x.FoodPackets.Select(fp => new MenuResponseDto.FoodPacketDto
                {
                    Id = fp.Id,
                    Price = fp.Price,
                    Title = fp.Title,
                    Desc = fp.Desc,
                }),
            });
        }
    }
}
