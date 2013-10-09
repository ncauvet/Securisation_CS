using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExemplePoso.dto;
using ExemplePoso.dto.poso;

namespace ExemplePoso
{
    class VidalHelperWS : ExemplePoso.IVidalHelper 
    {
        private static ServiceProduct.productServiceClient productService;
        private static ServiceAllergy.allergyServiceClient allergyService;
        private static ServiceAnalysis.drugPrescriptionAnalysisServiceClient analysisService;
        private static ServiceCim10.cim10ServiceClient cim10Service;
        private static ServiceCNG.commonNameGroupServiceClient cngService;
        private static ServiceMolecule.moleculeServiceClient moleculeService;
        private static ServicePack.packServiceClient packService;
        private static ServicePoso.posologyServiceClient posoService;
        private static ServicePrescribable.prescribableServiceClient prescribableService;
        private static ServiceUcd.ucdServiceClient ucdService;
        private static ServiceSmr.smrServiceClient smrService;

        public VidalHelperWS(string p)
        {
            productService = new ServiceProduct.productServiceClient("ProductServiceHttpPort", p + "ProductService");
            allergyService = new ServiceAllergy.allergyServiceClient("AllergyServiceHttpPort", p + "AllergyService");
            analysisService = new ServiceAnalysis.drugPrescriptionAnalysisServiceClient("DrugPrescriptionAnalysisServiceHttpPort", p + "DrugPrescriptionAnalysisService"); ;
            cim10Service = new ServiceCim10.cim10ServiceClient("Cim10ServiceHttpPort", p + "Cim10Service");
            cngService = new ServiceCNG.commonNameGroupServiceClient("CommonNameGroupServiceHttpPort", p + "CommonNameGroupService");
            moleculeService = new ServiceMolecule.moleculeServiceClient("MoleculeServiceHttpPort", p + "MoleculeService");
            packService = new ServicePack.packServiceClient("PackServiceHttpPort", p + "PackService");
            posoService = new ServicePoso.posologyServiceClient("PosologyServiceHttpPort", p + "PosologyService");
            prescribableService = new ServicePrescribable.prescribableServiceClient("PrescribableServiceHttpPort", p + "PrescribableService");
            ucdService = new ServiceUcd.ucdServiceClient("UcdServiceHttpPort1", p + "UcdService");
            smrService = new ServiceSmr.smrServiceClient("SmrServiceHttpPort", p + "SmrService"); ;
        
         }





        public  List<ProductDto> ProductService_searchByName(string p)
        {
           return ProductDtoHelper.vidalToDtoList(productService.searchByName(p));
        }

       public List<CNGDto> CngService_SearchByName(string p)
        {
            return CNGDtoHelper.vidalToDtoList(cngService.searchByName(p)) ;
        }

       public List<PackDto> PackService_searchByName(string p)
        {
            return PackDtoHelper.vidalToDtoList(packService.searchByName(p));
        }

       public List<UcdDto> UcdService_searchByName(string p)
        {
            return UcdDtoHelper.vidalToDtoList(ucdService.searchByName(p));
        }

      public string AnalysisService_patientFromObjToJson(
          DateTime dateTime,
          GenderDto? gender, int weight, int height, int amen, BreastFeedingDto? breast, int creatin, HepaticInsufficiencyDto? hepatic, List<int> allergiesI, List<int> moleculesI, List<int> cimsI)
        {
        ServiceAnalysis.ArrayOfInt allergies = new ServiceAnalysis.ArrayOfInt();
        foreach(int i in allergiesI){
             allergies.Add(i);
         }
        ServiceAnalysis.ArrayOfInt molecules = new ServiceAnalysis.ArrayOfInt();
        foreach (int i in moleculesI)
        {
            molecules.Add(i);
        }
        ServiceAnalysis.ArrayOfInt cims = new ServiceAnalysis.ArrayOfInt();
        foreach (int i in cimsI)
        {
            cims.Add(i);
        } 
          
          return analysisService.patientFromObjToJson(dateTime, GenderDtoHelper.dtoToAnalysisService(gender), weight, height, amen, BreastFeedingDtoHelper.dtoToAnalysisService(breast), creatin, HepaticDtoHelper.dtoToAnalysisService(hepatic), allergies, molecules, cims);
        }

       public string AnalysisService_prescriptionLineInDosesFromObjToJson(double dose, int unit,PosologyFrequencyTypeDto freq, List<int> indicationsI, List<int> routesI, int id, DrugTypeDto type, int p, DurationTypeDto durationType)
        {
            ServiceAnalysis.ArrayOfInt indications = new ServiceAnalysis.ArrayOfInt();
            foreach (int i in indicationsI)
            {
                indications.Add(i);
            }
            ServiceAnalysis.ArrayOfInt routes = new ServiceAnalysis.ArrayOfInt();
            foreach (int i in routesI)
            {
                routes.Add(i);
            }
            
            
           return analysisService.prescriptionLineInDosesFromObjToJson(dose, unit, PosologyFrequencyTypeDtoHelper.dtoToAnalysisService(freq), indications, routes, id, DrugTypeDtoHelper.dtoToAnalysisService(type), p, DurationTypeDtoHelper.dtoToAnalysisService(durationType));
           // return analysisService.prescriptionLineInDosesFromObjToJson(dose, unit,ServiceAnalysis.PosologyFrequencyType.PER_DAY, indications, routes, id, ServiceAnalysis.DrugType.PRODUCT, p, ServiceAnalysis.DurationType.DAY);
      
        }

       public string AnalysisService_prescriptionLineInActivePrincipleDosesFromObjToJson(double dose, DoseUnitDto doseUnit, PosologyFrequencyTypeDto freq, List<int>indicationsI, List<int> routesI, int id, DrugTypeDto type, int p, DurationTypeDto durationType)
        {
            ServiceAnalysis.ArrayOfInt indications = new ServiceAnalysis.ArrayOfInt();
            foreach (int i in indicationsI)
            {
                indications.Add(i);
            }
            ServiceAnalysis.ArrayOfInt routes = new ServiceAnalysis.ArrayOfInt();
            foreach (int i in routesI)
            {
                routes.Add(i);
            }
            return analysisService.prescriptionLineInActivePrincipleDosesFromObjToJson(dose, DoseUnitDtoHelper.dtoToAnalysisService(doseUnit), PosologyFrequencyTypeDtoHelper.dtoToAnalysisService(freq), indications, routes, id, DrugTypeDtoHelper.dtoToAnalysisService(type), p, DurationTypeDtoHelper.dtoToAnalysisService(durationType));
           
        }

       public ProductDto ProductService_searchByUcdId(int ucdId)
        {
            return ProductDtoHelper.vidalToDto(productService.searchByUcdId(ucdId));
        }
       public string AnalysisService_getAlertsAsHTML(string patient, List<string>prescrI)
       {
           ServiceAnalysis.ArrayOfString prescr = stringListToServiceAnalysisStringList(prescrI);
           return analysisService.getAlertsAsHTML(patient, ( ServiceAnalysis.ArrayOfString)prescr);
       }
        public string SmrService_getSmrAsmrAsHTML(int nullable)
        {
           return smrService.getSmrAsmrAsHTML(nullable);
        }

        public List<AllergyDto> AllergyService_searchByName(string p)
        {
            return AllergyDtoHelper.vidalToDtoList(allergyService.searchByName(p));
        }

        public List<Cim10Dto> Cim10Service_searchByName(string p)
        {
            return Cim10DtoHelper.vidalToDtoList(cim10Service.searchByName(p));
        }

        public List<MoleculeDto> MoleculeService_searchOnlySecuredMoleculeByName(string p)
        {
            return MoleculeDtoHelper.vidalToDtoList(moleculeService.searchOnlySecuredMoleculeByName(p));
        }
        public List<NumberOfDosesDto> PosoService_searchDosesByProductId(int productId, GenderDto? gender, float ageF, float weight, int height, int creatin, HepaticInsufficiencyDto? hepatic, List<int>indicationsI, List<int>routesI)
        {
            ServicePoso.ArrayOfInt indications = new ServicePoso.ArrayOfInt();
            foreach (int i in indicationsI)
            {
                indications.Add(i);
            }
            ServicePoso.ArrayOfInt routes = new ServicePoso.ArrayOfInt();
            foreach (int i in routesI)
            {
                routes.Add(i);
            }
            try
            {
                ServicePoso.NumberOfDoses[] result = posoService.searchDosesByProductId(productId, GenderDtoHelper.dtoToPosoService(gender), ageF, weight, height, creatin, HepaticDtoHelper.dtoToPosoService(hepatic), indications, routes);
                return result != null ? NumberOfDosesDtoHelper.vidalToDtoList(result.ToList<ServicePoso.NumberOfDoses>()) : new List<NumberOfDosesDto>();
            }
            catch (Exception)
            { return null; }
         }
        public List<PosologyUnitDto> PosoService_searchPosologyUnitByProductId(int drugId)
        {
            return PosologyUnitDtoHelper.vidalToDtoList(posoService.searchPosologyUnitByProductId(drugId));
        }
        public List<BrandedPrescribableDto> PrescribableService_searchBrandedPrescribableByName(string p)
        {
            return  BrandedPrescribableDtoHelper.vidalToDtoList(prescribableService.searchBrandedPrescribableByName(p));
        }
        public List<PosologyUnitDto> PosoService_searchPosologyUnitByCommonNameGroupId(int drugId)
        {
            return PosologyUnitDtoHelper.vidalToDtoList(posoService.searchPosologyUnitByCommonNameGroupId(drugId).posologyUnits);
        }
        
        public PrescriptionAnalysisDto AnalysisService_getAlerts(string patient,  List<string>prescr)
        {
            if (prescr != null && prescr.Count > 0)
            {
                return analysisService != null ? new PrescriptionAnalysisDto(analysisService.getAlerts(patient, (ServiceAnalysis.ArrayOfString)prescr)) : null;
            }
            else return null;
        }

       public List<DrugSummarizedAlertCoupleDto> AnalysisService_getSummarizedAlert(string patient,List<string> prescrI)
        {
            ServiceAnalysis.ArrayOfString prescr = stringListToServiceAnalysisStringList(prescrI);
            return DrugSummarizedAlertCoupleDtoHelper.vidalToDtoList(analysisService.getSummarizedAlert(patient, prescr));
        }

       private static ServiceAnalysis.ArrayOfString stringListToServiceAnalysisStringList(List<string> prescrI)
       {
           ServiceAnalysis.ArrayOfString prescr = new ServiceAnalysis.ArrayOfString();
           foreach (string line in prescrI)
           {
               prescr.Add(line);
           }
           return prescr;
       }

      public ProductDto searchByProductId(int p)
       {
           return ProductDtoHelper.vidalToDto(productService.searchById(p));
       }

      public List<string> getProductIndicator(int productId)
      {
          List<string> result = new List<string>();
          ServiceProduct.ArrayOfInt ints = new ServiceProduct.ArrayOfInt();
          ints.Add(productId);
          ServiceProduct.ArrayOfProductIndicators indics =  productService.searchProductIndicatorsByProductIds(ints);
          foreach(ServiceProduct.productIndicators indicP in indics){
              foreach (ServiceProduct.indicator indic in indicP.indicators)
              {
                  result.Add(indic.indicatorValue);
              }
          }
          return result;
      }

      public List<string> getVMPIndicator(int p)
      {
          List<string> result = new List<string>();
          ServiceCNG.ArrayOfInt ints = new ServiceCNG.ArrayOfInt();
          ints.Add(p);
          ServiceCNG.ArrayOfCommonNameGroupIndicators indics = cngService.searchCommonNameGroupIndicatorsByCommonNameGroupIds(ints);
          foreach (ServiceCNG.commonNameGroupIndicators indicP in indics)
          {
              foreach (ServiceCNG.indicator indic in indicP.indicators)
              {
                  result.Add(indic.indicatorValue);
              }
          }
          return result;
      }
      public List<string> getDocumentsByProductId(int? nullable)
      {
          List<string> url = new List<String>();
         //ToDo 
          return url;
      }
      public List<string> searchCIAlert(int p, DateTime dateOfBirth, int weight, BreastFeedingDto? breastfeeding, int weeksOfAmenorrhoea, int creatinClearance, GenderDto? gender)
      {
          return new List<string>() ; //todo ;
      }

      public List<string> searchPEAlert(int p, DateTime dateOfBirth, int weight, BreastFeedingDto? breastfeeding, int weeksOfAmenorrhoea, int creatinClearance, GenderDto? gender){
          return new List<string>(); //todo ;
      }

      public Object circuitMedic(int ucdID)
      {
          return null;
      }
      public Object compo(int UcdId)
      {
          return null;
      }

      public ServiceAnalysis.ArrayOfCodedReco recos(List<string> prescription, String patient)
      {
          ServiceAnalysis.ArrayOfString strings = stringListToServiceAnalysisStringList(prescription);
          return analysisService.searchRecosByPrescriptions(patient, strings);
      }
    }
}
