using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto
{
    public class CNGDto
    {
        public int? Id { get; set; }
        public float? MaxUcdRangePrice { get; set; }
        public float? MinUcdRangePrice { get; set; }
        public string Name { get; set; }
    }

    public class CNGDtoHelper
    {
        internal static CNGDto vidalToDto(VidalAPI.Domain.CommonNameGroup nativeCNG)
        {
            CNGDto dto = new CNGDto();
            dto.Id =  nativeCNG.Id;
            dto.MaxUcdRangePrice = nativeCNG.MaxUcdRangePrice;
            dto.MinUcdRangePrice = nativeCNG.MinUcdRangePrice;
            dto.Name = nativeCNG.Name;
            return dto;
        }
        internal static List<CNGDto> vidalToDtoList(VidalAPI.Domain.CommonNameGroupList nativeCNGs)
        {
            List<CNGDto> cngs = new List<CNGDto>();
            foreach (VidalAPI.Domain.CommonNameGroup cng in nativeCNGs)
            {
                cngs.Add(vidalToDto(cng));
            }
            return cngs;
        }

        internal static CNGDto vidalToDto(ServiceCNG.commonNameGroup wsCNG)
        {
            CNGDto dto = new CNGDto();
            dto.Id = wsCNG.id;
            dto.MaxUcdRangePrice = wsCNG.maxUcdRangePrice;
            dto.MinUcdRangePrice = wsCNG.minUcdRangePrice;
            dto.Name = wsCNG.name;
            return dto;
        }
        internal static List<CNGDto> vidalToDtoList(ServiceCNG.ArrayOfCommonNameGroup wsCNGs)
        {
            List<CNGDto> cngs = new List<CNGDto>();
            foreach (ServiceCNG.commonNameGroup cng in wsCNGs)
            {
                cngs.Add(vidalToDto(cng));
            }
            return cngs;
        }
    }
}
