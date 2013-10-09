using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto
{
    public class SummarizedDrugDto
    {
            public int? Id;
            public string Name;
            public DrugTypeDto? Type;
            public Boolean safetyAlert;

            public SummarizedDrugDto(ServiceAnalysis.summarizedDrug drug)
            {
                this.Id = drug.id;
                this.Name = drug.name;
                this.Type = DrugTypeDtoHelper.wsToDrugTypeDto(drug.type);
                this.safetyAlert = drug.safetyAlert;
            }
            public SummarizedDrugDto(VidalAPI.Domain.SummarizedDrug drug)
            {
                this.Id = drug.Id;
                this.Name = drug.Name;
                this.Type = DrugTypeDtoHelper.nativeToDrugTypeDto(drug.Type);
                this.safetyAlert = drug.SafetyAlert;

            }


    }
}
