using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso
{
	public enum DoseUnitDto
    {
        MG = 0,
        G = 1,
        ML = 2,
        MCG = 3,
        U = 4,
        KU = 5,
        MU = 6,
        MMOL = 7,
    }
    public class DoseUnitDtoHelper{
        internal static DoseUnitDto? nativeToDoseUnitDto(VidalAPI.Domain.DoseUnit nativeDoseUnit)
        {
            switch (nativeDoseUnit)
            {
                case VidalAPI.Domain.DoseUnit.DOSEUNIT_G: return DoseUnitDto.G;
                case VidalAPI.Domain.DoseUnit.DOSEUNIT_KU: return DoseUnitDto.KU;
                case VidalAPI.Domain.DoseUnit.DOSEUNIT_MCG: return DoseUnitDto.MCG;
                case VidalAPI.Domain.DoseUnit.DOSEUNIT_MG: return DoseUnitDto.MG;
                case VidalAPI.Domain.DoseUnit.DOSEUNIT_ML: return DoseUnitDto.ML;
                case VidalAPI.Domain.DoseUnit.DOSEUNIT_MMOL: return DoseUnitDto.MMOL;
                case VidalAPI.Domain.DoseUnit.DOSEUNIT_MU: return DoseUnitDto.MU;
                case VidalAPI.Domain.DoseUnit.DOSEUNIT_U: return DoseUnitDto.U;
            }
            return null;
        }

        internal static DoseUnitDto? wsToDoseUnitDto(ServiceAnalysis.DoseUnit wsDoseUnit)
        {
            switch (wsDoseUnit)
            {
                case ServiceAnalysis.DoseUnit.G: return DoseUnitDto.G;
                case ServiceAnalysis.DoseUnit.KU: return DoseUnitDto.KU;
                case ServiceAnalysis.DoseUnit.MCG: return DoseUnitDto.MCG;
                case ServiceAnalysis.DoseUnit.MG: return DoseUnitDto.MG;
                case ServiceAnalysis.DoseUnit.ML: return DoseUnitDto.ML;
                case ServiceAnalysis.DoseUnit.MMOL: return DoseUnitDto.MMOL;
                case ServiceAnalysis.DoseUnit.MU: return DoseUnitDto.MU;
                case ServiceAnalysis.DoseUnit.U: return DoseUnitDto.U;
            }
            return null;
        }

        internal static ServiceAnalysis.DoseUnit? dtoToAnalysisService(DoseUnitDto? DoseUnit)
        {
            switch (DoseUnit)
            {
                case DoseUnitDto.G: return ServiceAnalysis.DoseUnit.G;
                case DoseUnitDto.KU: return ServiceAnalysis.DoseUnit.KU;
                case DoseUnitDto.MCG: return ServiceAnalysis.DoseUnit.MCG;
                case DoseUnitDto.MG: return ServiceAnalysis.DoseUnit.MG;
                case DoseUnitDto.ML: return ServiceAnalysis.DoseUnit.ML;
                case DoseUnitDto.MMOL: return ServiceAnalysis.DoseUnit.MMOL;
                case DoseUnitDto.MU: return ServiceAnalysis.DoseUnit.MU;
                case DoseUnitDto.U: return ServiceAnalysis.DoseUnit.U;
            }
            return null;
        }
        internal static ServicePoso.DoseUnit? dtoToPosoService(DoseUnitDto? DoseUnit)
        {
            switch (DoseUnit)
            {
                case DoseUnitDto.G: return ServicePoso.DoseUnit.G;
                case DoseUnitDto.KU: return ServicePoso.DoseUnit.KU;
                case DoseUnitDto.MCG: return ServicePoso.DoseUnit.MCG;
                case DoseUnitDto.MG: return ServicePoso.DoseUnit.MG;
                case DoseUnitDto.ML: return ServicePoso.DoseUnit.ML;
                case DoseUnitDto.MMOL: return ServicePoso.DoseUnit.MMOL;
                case DoseUnitDto.MU: return ServicePoso.DoseUnit.MU;
                case DoseUnitDto.U: return ServicePoso.DoseUnit.U;
            }
            return null;
        }
        internal static VidalAPI.Domain.DoseUnit dtoToNative(DoseUnitDto? DoseUnit)
        {
            switch (DoseUnit)
            {
                case DoseUnitDto.G: return VidalAPI.Domain.DoseUnit.DOSEUNIT_G;
                case DoseUnitDto.KU: return VidalAPI.Domain.DoseUnit.DOSEUNIT_KU;
                case DoseUnitDto.MCG: return VidalAPI.Domain.DoseUnit.DOSEUNIT_MCG;
                case DoseUnitDto.MG: return VidalAPI.Domain.DoseUnit.DOSEUNIT_MG;
                case DoseUnitDto.ML: return VidalAPI.Domain.DoseUnit.DOSEUNIT_ML;
                case DoseUnitDto.MMOL: return VidalAPI.Domain.DoseUnit.DOSEUNIT_MMOL;
                case DoseUnitDto.MU: return VidalAPI.Domain.DoseUnit.DOSEUNIT_MU;
                case DoseUnitDto.U: return VidalAPI.Domain.DoseUnit.DOSEUNIT_U;
               }
            return VidalAPI.Domain.DoseUnit.DOSEUNIT_JNULL;
        }
    }
    

}
