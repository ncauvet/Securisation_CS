using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso
{
	public enum DrugTypeDto
	{
        COMMON_NAME_GROUP = 0,
        PRODUCT = 1,
        PACK = 2,
        UCD = 3,
        UNKNOWN = 4,
        ACCESSORY_RANGE = 5,
        BRANDED_PRESCRIBABLE=6,
	}
    public class DrugTypeDtoHelper{
        internal static DrugTypeDto? nativeToDrugTypeDto(VidalAPI.Domain.DrugType nativeDrugType)
        {
            switch (nativeDrugType)
            {
                case VidalAPI.Domain.DrugType.DRUGTYPE_ACCESSORY_RANGE: return DrugTypeDto.ACCESSORY_RANGE;
                case VidalAPI.Domain.DrugType.DRUGTYPE_COMMON_NAME_GROUP: return DrugTypeDto.COMMON_NAME_GROUP;
                case VidalAPI.Domain.DrugType.DRUGTYPE_PACK: return DrugTypeDto.PACK;
                case VidalAPI.Domain.DrugType.DRUGTYPE_PRODUCT: return DrugTypeDto.PRODUCT;
                case VidalAPI.Domain.DrugType.DRUGTYPE_UCD: return DrugTypeDto.UCD;
                case VidalAPI.Domain.DrugType.DRUGTYPE_UNKNOWN: return DrugTypeDto.UNKNOWN;
                case VidalAPI.Domain.DrugType.DRUGTYPE_BRANDED_PRESCRIBABLE: return DrugTypeDto.BRANDED_PRESCRIBABLE;
            }
            return null;
        }

        internal static DrugTypeDto? wsToDrugTypeDto(ServiceAnalysis.DrugType? wsDrugType)
        {
            switch (wsDrugType)
            {
                case ServiceAnalysis.DrugType.ACCESSORY_RANGE: return DrugTypeDto.ACCESSORY_RANGE;
                case ServiceAnalysis.DrugType.BRANDED_PRESCRIBABLE: return DrugTypeDto.BRANDED_PRESCRIBABLE;
                case ServiceAnalysis.DrugType.COMMON_NAME_GROUP: return DrugTypeDto.COMMON_NAME_GROUP;
                case ServiceAnalysis.DrugType.PACK: return DrugTypeDto.PACK;
                case ServiceAnalysis.DrugType.PRODUCT: return DrugTypeDto.PRODUCT;
                case ServiceAnalysis.DrugType.UCD: return DrugTypeDto.UCD;
                case ServiceAnalysis.DrugType.UNKNOWN: return DrugTypeDto.UNKNOWN;
            }
            return null;
        }

        internal static ServiceAnalysis.DrugType? dtoToAnalysisService(DrugTypeDto? DrugType)
        {
            switch (DrugType)
            {
                case DrugTypeDto.ACCESSORY_RANGE: return ServiceAnalysis.DrugType.ACCESSORY_RANGE;
                case DrugTypeDto.BRANDED_PRESCRIBABLE: return ServiceAnalysis.DrugType.BRANDED_PRESCRIBABLE;
                case DrugTypeDto.COMMON_NAME_GROUP: return ServiceAnalysis.DrugType.COMMON_NAME_GROUP;
                case DrugTypeDto.PACK: return ServiceAnalysis.DrugType.PACK;
                case DrugTypeDto.PRODUCT: return ServiceAnalysis.DrugType.PRODUCT;
                case DrugTypeDto.UCD: return ServiceAnalysis.DrugType.UCD;
                case DrugTypeDto.UNKNOWN: return ServiceAnalysis.DrugType.UNKNOWN;
            }
            return null;
        }
        
        internal static VidalAPI.Domain.DrugType dtoToNative(DrugTypeDto? DrugType)
        {
            switch (DrugType)
            {
                case DrugTypeDto.ACCESSORY_RANGE: return VidalAPI.Domain.DrugType.DRUGTYPE_ACCESSORY_RANGE;
                case DrugTypeDto.BRANDED_PRESCRIBABLE: return VidalAPI.Domain.DrugType.DRUGTYPE_BRANDED_PRESCRIBABLE;
                case DrugTypeDto.COMMON_NAME_GROUP: return VidalAPI.Domain.DrugType.DRUGTYPE_COMMON_NAME_GROUP;
                case DrugTypeDto.PACK: return VidalAPI.Domain.DrugType.DRUGTYPE_PACK;
                case DrugTypeDto.PRODUCT: return VidalAPI.Domain.DrugType.DRUGTYPE_PRODUCT;
                case DrugTypeDto.UCD: return VidalAPI.Domain.DrugType.DRUGTYPE_UCD;
                case DrugTypeDto.UNKNOWN: return VidalAPI.Domain.DrugType.DRUGTYPE_UNKNOWN;
               }
            return VidalAPI.Domain.DrugType.DRUGTYPE_JNULL;
        }

       
    }
    

}
