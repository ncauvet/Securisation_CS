using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto
{
    public class ReferenceDto
    {
        public DateTime? ReferenceDate;
        public string ReferenceName;
        public string ReferenceType;


        public ReferenceDto(ServiceAnalysis.reference reference)
        {
           // this.ReferenceDate = reference.referenceDate;
            this.ReferenceName = reference.referenceName;
            this.ReferenceType = reference.referenceType;

        }
        public ReferenceDto(VidalAPI.Domain.Reference reference)
        {
          //  this.ReferenceDate = reference.ReferenceDate;
            this.ReferenceName = reference.ReferenceName;
            this.ReferenceType = reference.ReferenceType;

        }
    }

    public class ReferenceDtoHelper
    {

        internal static List<ReferenceDto> vidalToReferenceDtoList(ServiceAnalysis.ArrayOfReference wsReferences)
        {
            List<ReferenceDto> result = new List<ReferenceDto>();
            foreach (ServiceAnalysis.reference reference in wsReferences)
            {
                result.Add(new ReferenceDto(reference));
            }
            return result;
        }
        internal static List<ReferenceDto> vidalToReferenceDtoList(VidalAPI.Domain.ReferenceList wsReferences)
        {
            List<ReferenceDto> result = new List<ReferenceDto>();
            foreach (VidalAPI.Domain.Reference reference in wsReferences)
            {
                result.Add(new ReferenceDto(reference));
            }
            return result;
        }

    }
}
