using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto
{
    public class RelatedElementDto
    {
        public int? Id { get; set; }
        public string Type { get; set; }
    }

    public class RelatedElementDtoHelper
    {
        internal static RelatedElementDto vidalToDto(VidalAPI.Domain.RelatedElement relativeElement)
        {
            RelatedElementDto dto = new RelatedElementDto();
            dto.Id = relativeElement.Id;
            dto.Type = relativeElement.Type;
            return dto;
        }
        internal static List<RelatedElementDto> vidalToDtoList(VidalAPI.Domain.RelatedElementList nativeRE)
        {
            List<RelatedElementDto> cngs = new List<RelatedElementDto>();
            //if (nativeRE != null && nativeRE.Count > 0)
            //{
                foreach (VidalAPI.Domain.RelatedElement cng in nativeRE)
                {
                    cngs.Add(vidalToDto(cng));
                }
            //}
            return cngs;
        }

        internal static RelatedElementDto vidalToDto(ServiceAnalysis.relatedElement wsRE)
        {
            RelatedElementDto dto = new RelatedElementDto();
            dto.Id = wsRE.id;
            dto.Type = wsRE.type;
            return dto;
        }
        internal static List<RelatedElementDto> vidalToDtoList(ServiceAnalysis.ArrayOfRelatedElement wsREs)
        {
            List<RelatedElementDto> cngs = new List<RelatedElementDto>();
            foreach (ServiceAnalysis.relatedElement RE in wsREs)
            {
                cngs.Add(vidalToDto(RE));
            }
            return cngs;
        }

        
    }
}
