using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto
{
   public class DrugSummarizedAlertCoupleDto
    {
        public SummarizedAlertDto SummarizedAlert;
        public SummarizedDrugDto SummarizedDrug ;
        public DrugSummarizedAlertCoupleDto(ServiceAnalysis.DrugSummarizedAlertCouple couple)
        {
            this.SummarizedAlert = couple.summarizedAlert != null ? new SummarizedAlertDto(couple.summarizedAlert) : null;
            this.SummarizedDrug = couple.summarizedDrug != null ? new SummarizedDrugDto(couple.summarizedDrug) : null;
        }
        public DrugSummarizedAlertCoupleDto(VidalAPI.Domain.DrugSummarizedAlertCouple couple)
        {
            this.SummarizedAlert = couple.SummarizedAlert != null ? new SummarizedAlertDto(couple.SummarizedAlert) : null;
            this.SummarizedDrug = couple.SummarizedDrug != null ? new SummarizedDrugDto(couple.SummarizedDrug) : null;
        }
    }

   public class DrugSummarizedAlertCoupleDtoHelper
   {
       internal static List<DrugSummarizedAlertCoupleDto> vidalToDtoList(VidalAPI.Domain.DrugSummarizedAlertCoupleList nativeCouples)
       {
           List<DrugSummarizedAlertCoupleDto> result = new List<DrugSummarizedAlertCoupleDto>();
           foreach (VidalAPI.Domain.DrugSummarizedAlertCouple couple in nativeCouples)
           {
               result.Add(new DrugSummarizedAlertCoupleDto(couple) );
           }
           return result;
       }


       internal static List<DrugSummarizedAlertCoupleDto> vidalToDtoList(ServiceAnalysis.DrugSummarizedAlertCouple[] couples)
       {
           List<DrugSummarizedAlertCoupleDto> result = new List<DrugSummarizedAlertCoupleDto>();
           foreach (ServiceAnalysis.DrugSummarizedAlertCouple couple in couples)
           {
               result.Add(new DrugSummarizedAlertCoupleDto(couple));
           }
           return result;
       }

   }


    public class SummarizedAlertDto
    {
        public SummarizedAllergyAlertDto? AllergiesAlert ;
        public SummarizedContraIndicationAlertDto? ContraIndicationsAlert;
        public SummarizedInteractionAlertDto? InteractionsAlert;
        public SummarizedPhysicoChemicalAlertDto? PhysicoChemicalAlert;
        public SummarizedPosologyAlertDto? PosologyAlert;
        public SummarizedPrecautionAlertDto? PrecautionsAlert;
        public SummarizedRedundantInteractionAlertDto? RedundantInteractionsAlert;

        public SummarizedAlertDto(ServiceAnalysis.summarizedAlert alert)
        {
            this.AllergiesAlert = SummarizedAllergyAlertDtoHelper.wsToSummarizedAllergyAlertDto(alert.allergiesAlert);
            this.ContraIndicationsAlert =  SummarizedContraIndicationAlertDtoHelper.wsToSummarizedContraIndicationAlertDto(alert.contraIndicationsAlert);
            this.InteractionsAlert =  SummarizedInteractionAlertDtoHelper.wsToSummarizedInteractionAlertDto(alert.interactionsAlert);
            this.PhysicoChemicalAlert = SummarizedPhysicoChemicalAlertDtoHelper.wsToSummarizedPhysicoChemicalAlertDto(alert.physicoChemicalAlert);
            this.PosologyAlert =  SummarizedPosologyAlertDtoHelper.wsToSummarizedPosologyAlertDto(alert.posologyAlert);
            this.PrecautionsAlert =  SummarizedPrecautionAlertDtoHelper.wsToSummarizedPrecautionAlertDto(alert.precautionsAlert);
            this.RedundantInteractionsAlert = SummarizedRedundantInteractionAlertDtoHelper.wsToSummarizedRedundantInteractionAlertDto(alert.redundantInteractionsAlert);
        }
        public SummarizedAlertDto(VidalAPI.Domain.SummarizedAlert alert)
        {
            this.AllergiesAlert = SummarizedAllergyAlertDtoHelper.nativeToSummarizedAllergyAlertDto(alert.AllergiesAlert);
            this.ContraIndicationsAlert = SummarizedContraIndicationAlertDtoHelper.nativeToSummarizedContraIndicationAlertDto(alert.ContraIndicationsAlert);
            this.InteractionsAlert = SummarizedInteractionAlertDtoHelper.nativeToSummarizedInteractionAlertDto(alert.InteractionsAlert);
            this.PhysicoChemicalAlert = SummarizedPhysicoChemicalAlertDtoHelper.nativeToSummarizedPhysicoChemicalAlertDto(alert.PhysicoChemicalAlert);
            this.PosologyAlert = SummarizedPosologyAlertDtoHelper.nativeToSummarizedPosologyAlertDto(alert.PosologyAlert);
            this.PrecautionsAlert = SummarizedPrecautionAlertDtoHelper.nativeToSummarizedPrecautionAlertDto(alert.PrecautionsAlert);
            this.RedundantInteractionsAlert = SummarizedRedundantInteractionAlertDtoHelper.nativeToSummarizedRedundantInteractionAlertDto(alert.RedundantInteractionsAlert);
        }
    }
    
    
   
    
    
  


}
