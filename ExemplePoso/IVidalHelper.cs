using System;
using ExemplePoso.dto.poso;
using ExemplePoso.dto;
using System.Collections.Generic;
namespace ExemplePoso
{
    public interface IVidalHelper
    {
         System.Collections.Generic.List<ExemplePoso.dto.AllergyDto> AllergyService_searchByName(string p);
         PrescriptionAnalysisDto AnalysisService_getAlerts(string patient, List<string> prescr);
         string AnalysisService_getAlertsAsHTML(string patient, List<string> prescr);
         List<DrugSummarizedAlertCoupleDto> AnalysisService_getSummarizedAlert(string patient,List<string> prescr);
         
         string AnalysisService_patientFromObjToJson(DateTime dateTime, GenderDto? gender, int weight, int height, int amen, BreastFeedingDto? breast, int creatin, HepaticInsufficiencyDto? hepatic, List<int> allergies, List<int> molecules, List<int> cims);
         string AnalysisService_prescriptionLineInActivePrincipleDosesFromObjToJson(double dose, DoseUnitDto doseUnit, PosologyFrequencyTypeDto freq, List<int> indications, List<int> routes, int id, DrugTypeDto type, int p, DurationTypeDto durationType);
         string AnalysisService_prescriptionLineInDosesFromObjToJson(double dose, int unit, PosologyFrequencyTypeDto freq, List<int> indications, List<int> routes, int id, DrugTypeDto type, int p, DurationTypeDto durationType);
         
        List<Cim10Dto> Cim10Service_searchByName(string p);
         List<CNGDto> CngService_SearchByName(string p);
         List<MoleculeDto> MoleculeService_searchOnlySecuredMoleculeByName(string p);
         System.Collections.Generic.List<PackDto> PackService_searchByName(string p);
         System.Collections.Generic.List<NumberOfDosesDto> PosoService_searchDosesByProductId(int productId, GenderDto? gender, float ageF, float weight, int height, int creatin, HepaticInsufficiencyDto? hepatic, List<int> indications, List<int> routes);
         System.Collections.Generic.List<PosologyUnitDto> PosoService_searchPosologyUnitByCommonNameGroupId(int drugId);
         System.Collections.Generic.List<PosologyUnitDto> PosoService_searchPosologyUnitByProductId(int drugId);
         System.Collections.Generic.List<BrandedPrescribableDto> PrescribableService_searchBrandedPrescribableByName(string p);
         System.Collections.Generic.List<ProductDto> ProductService_searchByName(string p);
         ExemplePoso.dto.ProductDto ProductService_searchByUcdId(int ucdId);
         string SmrService_getSmrAsmrAsHTML(int nullable);
         List<UcdDto> UcdService_searchByName(string p);

         ProductDto searchByProductId(int p);

         List<string> getProductIndicator(int nullable);

         List<string> getVMPIndicator(int p);

         List<string> getDocumentsByProductId(int? nullable);

         List<string> searchCIAlert(int p, DateTime dateOfBirth, int weight, BreastFeedingDto? breastfeeding, int weeksOfAmenorrhoea, int creatinClearance, GenderDto? gender);

         List<string> searchPEAlert(int p, DateTime dateOfBirth, int weight, BreastFeedingDto? breastfeeding, int weeksOfAmenorrhoea, int creatinClearance, GenderDto? gender);

         Object circuitMedic(int Ucdid);

         Object compo(int UcdId);
         //TODO only for WS Do it for native
         ServiceAnalysis.ArrayOfCodedReco recos(List<string> prescription, String patient);
    }
}
