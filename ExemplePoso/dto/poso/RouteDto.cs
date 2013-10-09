using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto
{
    public class RouteDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
    }
    public class RouteDtoHelper
    {
        internal static RouteDto nativeToRouteDto(VidalAPI.Domain.Route nativeRoute)
        {
            RouteDto dto = new RouteDto();
            dto.Id = nativeRoute.Id;
            dto.Name = nativeRoute.Name;
            dto.ParentId = nativeRoute.ParentId;
            return dto;
        }
        internal static List<RouteDto> vidalToRouteDtoList(VidalAPI.Domain.RouteList nativeRoutes)
        {
            List<RouteDto> Routes = new List<RouteDto>();
            foreach (VidalAPI.Domain.Route Route in nativeRoutes)
            {
                Routes.Add(nativeToRouteDto(Route));
            }
            return Routes;
        }

        internal static RouteDto RouteServiceToRouteDto(ServicePoso.route wsRoute)
        {
            RouteDto dto = new RouteDto();
            dto.Id = wsRoute.id;
            dto.Name = wsRoute.name;
            dto.Id = wsRoute.id;
            return dto;

        }
        internal static List<RouteDto> vidalToRouteDtoList(ServicePoso.ArrayOfRoute wsRoutes)
        {
            List<RouteDto> Routes = new List<RouteDto>();
            foreach (ServicePoso.route Route in wsRoutes)
            {
                Routes.Add(RouteServiceToRouteDto(Route));
            }
            return Routes;
        }
    }
}
