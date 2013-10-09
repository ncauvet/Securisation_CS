using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto
{
    public class UcdDto
    {
        public string Code { get; set; }
        public string Code13 { get; set; }
        public bool Ghs { get; set; }
        public float? GhsPrice { get; set; }
        public int? Id { get; set; }
       // public MarketStatus MarketStatus { get; }
        public float? MaxUcdRangePrice { get; set; }
        public float? MinUcdRangePrice { get; set; }
        public string Name { get; set; }
        public bool Retrocession { get; set; }
        public float? RetrocessionPrice { get; set; }
        public bool SafetyAlert { get; set; }
    }
    public class UcdDtoHelper
    {
        internal static UcdDto vidalToDto(VidalAPI.Domain.Ucd nativeUcd)
        {
            UcdDto dto = new UcdDto();
            dto.Code = nativeUcd.Code;
            dto.Code13 = nativeUcd.Code13;
            dto.Ghs = nativeUcd.Ghs;
            dto.GhsPrice = nativeUcd.GhsPrice;
            dto.Id = nativeUcd.Id;
            dto.MaxUcdRangePrice = nativeUcd.MaxUcdRangePrice;
            dto.MinUcdRangePrice = nativeUcd.MinUcdRangePrice;
            dto.Name = nativeUcd.Name;
            dto.Retrocession = nativeUcd.Retrocession;
            dto.RetrocessionPrice = nativeUcd.RetrocessionPrice;
            dto.SafetyAlert = nativeUcd.SafetyAlert;
            return dto;
        }
        internal static List<UcdDto> vidalToDtoList(VidalAPI.Domain.UcdList nativeUcds)
        {
            List<UcdDto> Ucds = new List<UcdDto>();
            foreach (VidalAPI.Domain.Ucd Ucd in nativeUcds)
            {
                Ucds.Add(vidalToDto(Ucd));
            }
            return Ucds;
        }

        internal static UcdDto vidalToDto(ServiceUcd.ucd wsUcd)
        {
            UcdDto dto = new UcdDto();
            dto.Code = wsUcd.code;
            dto.Code13 = wsUcd.code13;
            dto.Ghs = wsUcd.ghs;
            dto.GhsPrice = wsUcd.ghsPrice;
            dto.Id = wsUcd.id;
            dto.MaxUcdRangePrice = wsUcd.maxUcdRangePrice;
            dto.MinUcdRangePrice = wsUcd.minUcdRangePrice;
            dto.Name = wsUcd.name;
            dto.Retrocession = wsUcd.retrocession;
            dto.RetrocessionPrice = wsUcd.retrocessionPrice;
            dto.SafetyAlert = wsUcd.safetyAlert;
            return dto;

        }
        internal static List<UcdDto> vidalToDtoList(ServiceUcd.ArrayOfUcd wsUcds)
        {
            List<UcdDto> Ucds = new List<UcdDto>();
            foreach (ServiceUcd.ucd Ucd in wsUcds)
            {
                Ucds.Add(vidalToDto(Ucd));
            }
            return Ucds;
        }
    }
}
