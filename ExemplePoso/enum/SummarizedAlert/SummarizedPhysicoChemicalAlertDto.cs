using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso
{
    public enum SummarizedPhysicoChemicalAlertDto
    {
        HAS_ALERT = 0,
        NO_ALERT = 1,
        UNKNOWN_ALERT = 2,
    }
    public class SummarizedPhysicoChemicalAlertDtoHelper
    {
        internal static SummarizedPhysicoChemicalAlertDto? nativeToSummarizedPhysicoChemicalAlertDto(VidalAPI.Domain.SummarizedPhysicoChemicalAlert nativeSummarizedPhysicoChemicalAlert)
        {
            switch (nativeSummarizedPhysicoChemicalAlert)
            {
                case VidalAPI.Domain.SummarizedPhysicoChemicalAlert.SUMMARIZEDPHYSICOCHEMICALALERT_HAS_ALERT: return SummarizedPhysicoChemicalAlertDto.HAS_ALERT;
                case VidalAPI.Domain.SummarizedPhysicoChemicalAlert.SUMMARIZEDPHYSICOCHEMICALALERT_NO_ALERT: return SummarizedPhysicoChemicalAlertDto.NO_ALERT;
                case VidalAPI.Domain.SummarizedPhysicoChemicalAlert.SUMMARIZEDPHYSICOCHEMICALALERT_UNKNOWN_ALERT: return SummarizedPhysicoChemicalAlertDto.UNKNOWN_ALERT;
                
            }
            return null;
        }

        internal static SummarizedPhysicoChemicalAlertDto? wsToSummarizedPhysicoChemicalAlertDto(ServiceAnalysis.SummarizedPhysicoChemicalAlert? wsSummarizedPhysicoChemicalAlert)
        {
            switch (wsSummarizedPhysicoChemicalAlert)
            {
                case ServiceAnalysis.SummarizedPhysicoChemicalAlert.HAS_ALERT: return SummarizedPhysicoChemicalAlertDto.HAS_ALERT;
                case ServiceAnalysis.SummarizedPhysicoChemicalAlert.NO_ALERT: return SummarizedPhysicoChemicalAlertDto.NO_ALERT;
                case ServiceAnalysis.SummarizedPhysicoChemicalAlert.UNKNOWN_ALERT: return SummarizedPhysicoChemicalAlertDto.UNKNOWN_ALERT;
                
            }
            return null;
        }

        internal static ServiceAnalysis.SummarizedPhysicoChemicalAlert? dtoToAnalysisService(SummarizedPhysicoChemicalAlertDto? SummarizedPhysicoChemicalAlert)
        {
            switch (SummarizedPhysicoChemicalAlert)
            {
                case SummarizedPhysicoChemicalAlertDto.HAS_ALERT: return ServiceAnalysis.SummarizedPhysicoChemicalAlert.HAS_ALERT;
                case SummarizedPhysicoChemicalAlertDto.NO_ALERT: return ServiceAnalysis.SummarizedPhysicoChemicalAlert.NO_ALERT;
                case SummarizedPhysicoChemicalAlertDto.UNKNOWN_ALERT: return ServiceAnalysis.SummarizedPhysicoChemicalAlert.UNKNOWN_ALERT;
                
            }
            return null;
        }

        internal static VidalAPI.Domain.SummarizedPhysicoChemicalAlert dtoToNative(SummarizedPhysicoChemicalAlertDto? SummarizedPhysicoChemicalAlert)
        {
            switch (SummarizedPhysicoChemicalAlert)
            {
                case SummarizedPhysicoChemicalAlertDto.HAS_ALERT: return VidalAPI.Domain.SummarizedPhysicoChemicalAlert.SUMMARIZEDPHYSICOCHEMICALALERT_HAS_ALERT;
                case SummarizedPhysicoChemicalAlertDto.NO_ALERT: return VidalAPI.Domain.SummarizedPhysicoChemicalAlert.SUMMARIZEDPHYSICOCHEMICALALERT_NO_ALERT;
                case SummarizedPhysicoChemicalAlertDto.UNKNOWN_ALERT: return VidalAPI.Domain.SummarizedPhysicoChemicalAlert.SUMMARIZEDPHYSICOCHEMICALALERT_UNKNOWN_ALERT;
                
            }
            return VidalAPI.Domain.SummarizedPhysicoChemicalAlert.SUMMARIZEDPHYSICOCHEMICALALERT_JNULL;
        }

    }
}
