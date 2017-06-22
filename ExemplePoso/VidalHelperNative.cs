using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExemplePoso.dto;
using ExemplePoso.dto.poso;
using System.Threading;
using System.Windows.Forms;
using VidalAPI;
using VidalAPI.Domain;
using VidalAPI.Services;

namespace ExemplePoso
{
	class VidalHelperNative : ExemplePoso.IVidalHelper
	{
		static VidalAPI.ProductLine vidalProduct;

		public VidalHelperNative()
		{
			WorkerId workerObjet = new WorkerId();
			Thread worker = new Thread(workerObjet.DoWork);
			worker.Start();
		}

		public class WorkerId
		{
			public WorkerId()
			{
			}

			public void DoWork()
			{
				Console.WriteLine("worker thread: working...");
				List<string> vmoptions = new List<string>();
				vmoptions.Add("-Xms64m");
				vmoptions.Add("-Xmx128m");
				vmoptions.Add("-XX:PermSize=32m");
				vmoptions.Add("-XX:MaxPermSize=64m");
				vmoptions.Add("-Dcom.sun.management.jmxremote");

				vidalProduct = VidalAPI.ProductLine.GetProduct(VidalAPI.ProductLineID.VIDALEXPERT_PRODUCTID);//,vmoptions);

				MessageBox.Show("Initialisation terminée :) " + vidalProduct.Name + " " + vidalProduct.Version);
			}

			public void RequestStop()
			{
				//_shouldStop = true;
			}
			// Volatile is used as hint to the compiler that this data
			// member will be accessed by multiple threads.
			//private volatile bool _shouldStop;
		}

		public List<ProductDto> ProductService_searchByName(string p)
		{
			return ProductDtoHelper.vidalToDtoList(vidalProduct.GetService<VidalAPI.Services.ProductService>().SearchByName(p));
		}

		public List<CNGDto> CngService_SearchByName(string p)
		{
			return CNGDtoHelper.vidalToDtoList(vidalProduct.GetService<VidalAPI.Services.CommonNameGroupService>().SearchByName(p));
		}

		public List<PackDto> PackService_searchByName(string p)
		{
			return PackDtoHelper.vidalToDtoList(vidalProduct.GetService<VidalAPI.Services.PackService>().SearchByName(p));
		}

		public List<UcdDto> UcdService_searchByName(string p)
		{
			return UcdDtoHelper.vidalToDtoList(vidalProduct.GetService<VidalAPI.Services.UcdService>().SearchByName(p));
		}

		public string AnalysisService_patientFromObjToJson(DateTime dateTime, GenderDto? gender, int weight, int height, int amen, BreastFeedingDto? breast, int creatin, HepaticInsufficiencyDto? hepatic, List<int> allergies, List<int> molecules, List<int> cims)
		{
			return vidalProduct.GetService<VidalAPI.Services.DrugPrescriptionAnalysisService>().PatientFromObjToJson(dateTime, GenderDtoHelper.dtoToNative(gender), weight, height, amen, BreastFeedingDtoHelper.dtoToNative(breast), creatin, HepaticDtoHelper.dtoToNative(hepatic), allergies, molecules, cims);
		}

		public string AnalysisService_prescriptionLineInDosesFromObjToJson(double dose, int unit, PosologyFrequencyTypeDto freq, List<int> indications, List<int> routes, int id, DrugTypeDto type, int p, DurationTypeDto durationType)
		{
			VidalAPI.Domain.PosologyFrequencyType dtoFreq = PosologyFrequencyTypeDtoHelper.dtoToNative(freq);
			string result = vidalProduct.GetService<VidalAPI.Services.DrugPrescriptionAnalysisService>().PrescriptionLineInDosesFromObjToJson(dose, unit, dtoFreq, indications, routes, id, DrugTypeDtoHelper.dtoToNative(type), p, DurationTypeDtoHelper.dtoToNative(durationType));
			return result;
		}

		public string AnalysisService_prescriptionLineInActivePrincipleDosesFromObjToJson(double dose, DoseUnitDto doseUnit, PosologyFrequencyTypeDto freq, List<int> indications, List<int> routes, int id, DrugTypeDto type, int p, DurationTypeDto durationType)
		{
			return vidalProduct.GetService<VidalAPI.Services.DrugPrescriptionAnalysisService>().PrescriptionLineInActivePrincipleDosesFromObjToJson(dose, DoseUnitDtoHelper.dtoToNative(doseUnit), PosologyFrequencyTypeDtoHelper.dtoToNative(freq), indications, routes, id, DrugTypeDtoHelper.dtoToNative(type), p, DurationTypeDtoHelper.dtoToNative(durationType));
		}

		public ProductDto ProductService_searchByUcdId(int ucdId)
		{
			return ProductDtoHelper.vidalToDto(vidalProduct.GetService<VidalAPI.Services.ProductService>().SearchByUcdId(ucdId));
		}

		public string AnalysisService_getAlertsAsHTML(string patient, List<string> prescr)
		{
			return vidalProduct.GetService<VidalAPI.Services.DrugPrescriptionAnalysisService>().GetAlertsAsHTML(patient, prescr);
		}

		public string SmrService_getSmrAsmrAsHTML(int nullable)
		{
			return vidalProduct.GetService<VidalAPI.Services.SmrService>().GetSmrAsmrAsHTML(nullable);
		}

		public List<AllergyDto> AllergyService_searchByName(string p)
		{
			return AllergyDtoHelper.vidalToDtoList(vidalProduct.GetService<VidalAPI.Services.AllergyService>().SearchByName(p));
		}

		public List<Cim10Dto> Cim10Service_searchByName(string p)
		{
			return Cim10DtoHelper.vidalToDtoList(vidalProduct.GetService<VidalAPI.Services.Cim10Service>().SearchByName(p));
		}

		public List<MoleculeDto> MoleculeService_searchOnlySecuredMoleculeByName(string p)
		{
			return MoleculeDtoHelper.vidalToDtoList(vidalProduct.GetService<VidalAPI.Services.MoleculeService>().SearchOnlySecuredMoleculeByName(p));
		}

		public List<NumberOfDosesDto> PosoService_searchDosesByProductId(int productId, GenderDto? gender, float ageF, float weight, int height, int creatin, HepaticInsufficiencyDto? hepatic, List<int> indications, List<int> routes)
		{
			VidalAPI.Domain.NumberOfDosesList result = vidalProduct.GetService<VidalAPI.Services.PosologyService>().SearchDosesByProductId(productId, GenderDtoHelper.dtoToNative(gender), ageF, weight, height, creatin, HepaticDtoHelper.dtoToNative(hepatic), indications, routes);
			return result != null ? NumberOfDosesDtoHelper.vidalToDtoList(result.ToList<VidalAPI.Domain.NumberOfDoses>()) : null;
		}

		public List<PosologyUnitDto> PosoService_searchPosologyUnitByProductId(int drugId)
		{
			return PosologyUnitDtoHelper.vidalToDtoList(vidalProduct.GetService<VidalAPI.Services.PosologyService>().SearchPosologyUnitByProductId(drugId));
		}

		public List<BrandedPrescribableDto> PrescribableService_searchBrandedPrescribableByName(string p)
		{
			return null;// BrandedPrescribableDtoHelper.vidalToDtoList(vidalProduct.GetService<VidalAPI.Services.PrescribableService>().SearchBrandedPrescribableByName(p));
		}

		public List<PosologyUnitDto> PosoService_searchPosologyUnitByCommonNameGroupId(int drugId)
		{
			return PosologyUnitDtoHelper.vidalToDtoList(vidalProduct.GetService<VidalAPI.Services.PosologyService>().SearchPosologyUnitByCommonNameGroupId(drugId).PosologyUnits);
		}

		public PrescriptionAnalysisDto AnalysisService_getAlerts(string patient, List<string> prescr)
		{
			return new PrescriptionAnalysisDto(vidalProduct.GetService<VidalAPI.Services.DrugPrescriptionAnalysisService>().GetAlertsWithoutAlertTypes(patient, prescr, new List<VidalAPI.Domain.AlertType> { }));//VidalAPI.Domain.AlertType .ALERTTYPE_WARNING}));
		}

		public List<DrugSummarizedAlertCoupleDto> AnalysisService_getSummarizedAlert(string patient, List<string> prescr)
		{
			return DrugSummarizedAlertCoupleDtoHelper.vidalToDtoList(vidalProduct.GetService<VidalAPI.Services.DrugPrescriptionAnalysisService>().GetSummarizedAlert(patient, prescr));
		}

		public ProductDto searchByProductId(int p)
		{
			return ProductDtoHelper.vidalToDto(vidalProduct.GetService<VidalAPI.Services.ProductService>().SearchById(p));
		}

		public List<string> getProductIndicator(int nullable)
		{
			List<string> result = new List<string>();
			VidalAPI.Domain.ProductIndicatorsList indics = vidalProduct.GetService<VidalAPI.Services.ProductService>().SearchProductIndicatorsByProductIds(new List<int> { nullable });
			foreach (VidalAPI.Domain.ProductIndicators indicP in indics)
			{
				foreach (VidalAPI.Domain.Indicator indic in indicP.Indicators)
				{
					result.Add(indic.IndicatorValue);
				}
			}
			return result;
		}

		public List<string> getVMPIndicator(int p)
		{
			List<string> result = new List<string>();
			VidalAPI.Domain.CommonNameGroupIndicatorsList indics = vidalProduct.GetService<VidalAPI.Services.CommonNameGroupService>().SearchCommonNameGroupIndicatorsByCommonNameGroupIds(new List<int> { p });
			foreach (VidalAPI.Domain.CommonNameGroupIndicators indicP in indics)
			{
				foreach (VidalAPI.Domain.Indicator indic in indicP.Indicators)
				{
					result.Add(indic.IndicatorValue);
				}
			}
			return result;
		}

		public List<string> getDocumentsByProductId(int? nullable)
		{
			int productId = (int)nullable;
			DocumentType[] docTypeArray = { DocumentType.DOCUMENTTYPE_MONO, DocumentType.DOCUMENTTYPE_VDF,
				DocumentType.DOCUMENTTYPE_PGR, DocumentType.DOCUMENTTYPE_FIT, DocumentType.DOCUMENTTYPE_BUM };

			DocumentList documents = vidalProduct.GetService<VidalAPI.Services.DocumentService>()
				.GetDocumentsByDocumentTypesForProductId(docTypeArray, productId);
			List<string> url = new List<String>();
			foreach (Document doc in documents)
			{
				if (doc.UrlAsString != null)
				{
					url.Add(doc.UrlAsString);
				}
			}
			return url;
		}

		public List<string> searchCIAlert(int p, DateTime dateOfBirth, int weight, BreastFeedingDto? breastfeeding, int weeksOfAmenorrhoea, int creatinClearance, GenderDto? gender)
		{
			IEnumerable<int> productIds = new List<int> { p };
			List<string> result = new List<string>();
			VidalAPI.Domain.ProductContraIndicationEppList ciList = vidalProduct.GetService<VidalAPI.Services.ContraIndicationService>().SearchByProductsIdsAndEpp(productIds, dateOfBirth, weight, BreastFeedingDtoHelper.dtoToNative(breastfeeding), weeksOfAmenorrhoea, creatinClearance, GenderDtoHelper.dtoToNative(gender));
			if (ciList != null && ciList.ContraIndicationEPPCoupleList != null)
			{
				foreach (VidalAPI.Domain.ContraIndicationEPPCouple couple in ciList.ContraIndicationEPPCoupleList)
				{
					result.Add(couple.ContraIndication.Name);
					result.Add(couple.Epp.ToString());
					result.Add(couple.Product.Name);
					result.Add(couple.Type.ToString());
				}
			}
			if (ciList != null && ciList.Messages != null)
			{
				foreach (VidalAPI.Domain.Message messega in ciList.Messages)
				{
					result.Add(messega.MessageType.ToString());
					result.Add(messega.Text);
				}
			}
			return result;
		}

		public List<string> searchPEAlert(int p, DateTime dateOfBirth, int weight, BreastFeedingDto? breastfeeding, int weeksOfAmenorrhoea, int creatinClearance, GenderDto? gender)
		{
			IEnumerable<int> productIds = new List<int> { p };
			List<string> result = new List<string>();
			VidalAPI.Domain.ProductPrecautionEppList ciList = vidalProduct.GetService<VidalAPI.Services.PrecautionService>().SearchByProductIdsAndEpp(productIds, dateOfBirth, weight, BreastFeedingDtoHelper.dtoToNative(breastfeeding), weeksOfAmenorrhoea, creatinClearance, GenderDtoHelper.dtoToNative(gender));
			if (ciList != null && ciList.PrecautionEppCouples != null)
			{
				foreach (VidalAPI.Domain.PrecautionEPPCouple couple in ciList.PrecautionEppCouples)
				{
					result.Add(couple.Precaution.Name);
					result.Add(couple.Epp.ToString());
					result.Add(couple.Product.Name);
				}
			}
			if (ciList != null && ciList.Messages != null)
			{
				foreach (VidalAPI.Domain.Message messega in ciList.Messages)
				{
					result.Add(messega.MessageType.ToString());
					result.Add(messega.Text);
				}
			}
			return result;
		}

		public Object circuitMedic(int id)
		{
			VidalAPI.Domain.UcdPosologyUnitsAndItemsConcentrationsList result = vidalProduct.GetService<VidalAPI.Services.UcdService>().GetUcdsPosologyUnitsAndItemsConcentrationsByUcdIds(new List<int> { id });
			return result;
		}

		public Object compo(int ucdId)
		{
			VidalAPI.Domain.ItemCompositionsCoupleList result = vidalProduct.GetService<VidalAPI.Services.CompositionService>().SearchCompositionsByUcdIdAndSubstanceTypes(ucdId, new List<VidalAPI.Domain.SubstanceType> { VidalAPI.Domain.SubstanceType.SUBSTANCETYPE_ACTIVE_EXCIPIENT, VidalAPI.Domain.SubstanceType.SUBSTANCETYPE_ACTIVE_PRINCIPLE, VidalAPI.Domain.SubstanceType.SUBSTANCETYPE_EXCIPIENT });
			return result;
		}

		public ServiceAnalysis.ArrayOfCodedReco recos(List<string> prescription, String patient)
		{
			return null;
		}
	}
}
