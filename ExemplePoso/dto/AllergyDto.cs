using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto
{
    public class AllergyDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
    }
    public class AllergyDtoHelper
    {
        internal static AllergyDto vidalToDto(VidalAPI.Domain.Allergy nativeAllergy)
        {
            AllergyDto dto = new AllergyDto();
            dto.Id = nativeAllergy.Id;
            dto.Name = nativeAllergy.Name;
            return dto;
        }
        internal static List<AllergyDto> vidalToDtoList(VidalAPI.Domain.AllergyList nativeAllergys)
        {
            List<AllergyDto> Allergys = new List<AllergyDto>();
            foreach (VidalAPI.Domain.Allergy Allergy in nativeAllergys)
            {
                Allergys.Add(vidalToDto(Allergy));
            }
            return Allergys;
        }

        internal static AllergyDto vidalToDto(ServiceAllergy.allergy wsAllergy)
        {
            AllergyDto dto = new AllergyDto();
            dto.Id = wsAllergy.id;
            dto.Name = wsAllergy.name;
            return dto;

        }
        internal static List<AllergyDto> vidalToDtoList(ServiceAllergy.ArrayOfAllergy wsAllergys)
        {
            List<AllergyDto> Allergys = new List<AllergyDto>();
            foreach (ServiceAllergy.allergy Allergy in wsAllergys)
            {
                Allergys.Add(vidalToDto(Allergy));
            }
            return Allergys;
        }
    }
}
