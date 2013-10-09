using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto
{
    public class Cim10Dto
    {
        public string Code { get; set; }
        public int? Id { get; set;}
        public string Name { get; set;}
    }
    public class Cim10DtoHelper
    {
        internal static Cim10Dto vidalToDto(VidalAPI.Domain.Cim10 nativeCim10)
        {
            Cim10Dto dto = new Cim10Dto();
            dto.Code = nativeCim10.Code;
            dto.Id = nativeCim10.Id;
            dto.Name = nativeCim10.Name;
            return dto;
        }
        internal static List<Cim10Dto> vidalToDtoList(VidalAPI.Domain.Cim10List nativeCim10s)
        {
            List<Cim10Dto> Cim10s = new List<Cim10Dto>();
            foreach (VidalAPI.Domain.Cim10 Cim10 in nativeCim10s)
            {
                Cim10s.Add(vidalToDto(Cim10));
            }
            return Cim10s;
        }

        internal static Cim10Dto vidalToDto(ServiceCim10.cim10 wsCim10)
        {
            Cim10Dto dto = new Cim10Dto();
            dto.Code = wsCim10.code;
            dto.Id = wsCim10.id;
            dto.Name = wsCim10.name;
            return dto;

        }
        internal static List<Cim10Dto> vidalToDtoList(ServiceCim10.ArrayOfCim10 wsCim10s)
        {
            List<Cim10Dto> Cim10s = new List<Cim10Dto>();
            foreach (ServiceCim10.cim10 Cim10 in wsCim10s)
            {
                Cim10s.Add(vidalToDto(Cim10));
            }
            return Cim10s;
        }
    }
}
