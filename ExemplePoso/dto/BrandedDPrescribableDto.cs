using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto
{
    public class BrandedPrescribableDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public bool? SafetyAlert { get; set; }
    }

    public class BrandedPrescribableDtoHelper
    {
        internal static BrandedPrescribableDto vidalToDto(/*VidalAPI.Domain.BrandedPrescribable*/ Object nativeBrandedPrescribable)
        {
            BrandedPrescribableDto dto = new BrandedPrescribableDto();
          //  dto.Id =  nativeBrandedPrescribable.Id;
           // dto.Name = nativeBrandedPrescribable.Name;
           //dto.SafetyAlert =  nativeBrandedPrescribable.SafetyAlert;
            return dto;
        }
        internal static List<BrandedPrescribableDto> vidalToDtoList(/*VidalAPI.Domain.BrandedPrescribableList*/Object nativeBrandedPrescribables)
        {
            List<BrandedPrescribableDto> BrandedPrescribables = new List<BrandedPrescribableDto>();
           // foreach (VidalAPI.Domain.BrandedPrescribable BrandedPrescribable in nativeBrandedPrescribables)
            //{
              //  BrandedPrescribables.Add(vidalToDto(BrandedPrescribable));
            //}
            return BrandedPrescribables;
        }

        internal static BrandedPrescribableDto vidalToDto(ServicePrescribable.brandedPrescribable wsBrandedPrescribable)
        {
            BrandedPrescribableDto dto = new BrandedPrescribableDto();
            dto.Id = wsBrandedPrescribable.id;
            dto.Name = wsBrandedPrescribable.name;
            dto.SafetyAlert = wsBrandedPrescribable.safetyAlert;
            return dto;
        }
        internal static List<BrandedPrescribableDto> vidalToDtoList(ServicePrescribable.ArrayOfBrandedPrescribable wsBrandedPrescribables)
        {
            List<BrandedPrescribableDto> BrandedPrescribables = new List<BrandedPrescribableDto>();
            foreach (ServicePrescribable.brandedPrescribable BrandedPrescribable in wsBrandedPrescribables)
            {
                BrandedPrescribables.Add(vidalToDto(BrandedPrescribable));
            }
            return BrandedPrescribables;
        }
    }
}
