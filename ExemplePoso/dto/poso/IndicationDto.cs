using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto
{
    public class IndicationDto
    {
        public int? Id;
        public string Name;

        public IndicationDto(ServicePoso.indication indic){
            this.Id = indic.id;
            this.Name = indic.name;
        }
        public IndicationDto(VidalAPI.Domain.Indication indic)
        {
            this.Id = indic.Id;
            this.Name = indic.Name;
        }
    }
   
}
