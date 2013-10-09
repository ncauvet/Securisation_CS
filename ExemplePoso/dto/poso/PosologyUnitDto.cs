using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto
{
    public class PosologyUnitDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
    }
    public class PosologyUnitDtoHelper
    {
        internal static PosologyUnitDto vidalToDto(VidalAPI.Domain.PosologyUnit nativePosologyUnit)
        {
            PosologyUnitDto dto = new PosologyUnitDto();
            dto.Id = nativePosologyUnit.Id;
            dto.Name = nativePosologyUnit.Name;
            return dto;
        }
        internal static List<PosologyUnitDto> vidalToDtoList(VidalAPI.Domain.PosologyUnitList nativePosologyUnits)
        {
            List<PosologyUnitDto> PosologyUnits = new List<PosologyUnitDto>();
            foreach (VidalAPI.Domain.PosologyUnit PosologyUnit in nativePosologyUnits)
            {
                PosologyUnits.Add(vidalToDto(PosologyUnit));
            }
            return PosologyUnits;
        }

        internal static PosologyUnitDto vidalToDto(ServicePoso.posologyUnit wsPosologyUnit)
        {
            PosologyUnitDto dto = new PosologyUnitDto();
            dto.Id = wsPosologyUnit.id;
            dto.Name = wsPosologyUnit.name;
            return dto;

        }
        internal static List<PosologyUnitDto> vidalToDtoList(ServicePoso.ArrayOfPosologyUnit wsPosologyUnits)
        {
            List<PosologyUnitDto> PosologyUnits = new List<PosologyUnitDto>();
            foreach (ServicePoso.posologyUnit PosologyUnit in wsPosologyUnits)
            {
                PosologyUnits.Add(vidalToDto(PosologyUnit));
            }
            return PosologyUnits;
        }
    }
}
