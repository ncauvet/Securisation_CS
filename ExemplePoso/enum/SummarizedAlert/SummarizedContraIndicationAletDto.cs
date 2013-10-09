using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso
{
    public enum SummarizedContraIndicationAlertDto
    {
        RELATIVE_ALERT = 0,
        ABSOLUTE_ALERT = 1,
        UNKNOWN_ALERT = 2,
        NO_ALERT = 3,
    }
    public class SummarizedContraIndicationAlertDtoHelper
    {
        internal static SummarizedContraIndicationAlertDto? nativeToSummarizedContraIndicationAlertDto(VidalAPI.Domain.SummarizedContraIndicationAlert nativeSummarizedContraIndicationAlert)
        {
            switch (nativeSummarizedContraIndicationAlert)
            {
                case VidalAPI.Domain.SummarizedContraIndicationAlert.SUMMARIZEDCONTRAINDICATIONALERT_ABSOLUTE_ALERT: return SummarizedContraIndicationAlertDto.ABSOLUTE_ALERT;
                case VidalAPI.Domain.SummarizedContraIndicationAlert.SUMMARIZEDCONTRAINDICATIONALERT_NO_ALERT: return SummarizedContraIndicationAlertDto.NO_ALERT;
                case VidalAPI.Domain.SummarizedContraIndicationAlert.SUMMARIZEDCONTRAINDICATIONALERT_RELATIVE_ALERT: return SummarizedContraIndicationAlertDto.RELATIVE_ALERT;
                case VidalAPI.Domain.SummarizedContraIndicationAlert.SUMMARIZEDCONTRAINDICATIONALERT_UNKNOWN_ALERT: return SummarizedContraIndicationAlertDto.UNKNOWN_ALERT;
                
            }
            return null;
        }

        internal static SummarizedContraIndicationAlertDto? wsToSummarizedContraIndicationAlertDto(ServiceAnalysis.SummarizedContraIndicationAlert? wsSummarizedContraIndicationAlert)
        {
            switch (wsSummarizedContraIndicationAlert)
            {
                case ServiceAnalysis.SummarizedContraIndicationAlert.ABSOLUTE_ALERT: return SummarizedContraIndicationAlertDto.ABSOLUTE_ALERT;
                case ServiceAnalysis.SummarizedContraIndicationAlert.NO_ALERT: return SummarizedContraIndicationAlertDto.NO_ALERT;
                case ServiceAnalysis.SummarizedContraIndicationAlert.RELATIVE_ALERT: return SummarizedContraIndicationAlertDto.RELATIVE_ALERT;
                case ServiceAnalysis.SummarizedContraIndicationAlert.UNKNOWN_ALERT: return SummarizedContraIndicationAlertDto.UNKNOWN_ALERT;
                
            }
            return null;
        }

        internal static ServiceAnalysis.SummarizedContraIndicationAlert? dtoToAnalysisService(SummarizedContraIndicationAlertDto? SummarizedContraIndicationAlert)
        {
            switch (SummarizedContraIndicationAlert)
            {
                case SummarizedContraIndicationAlertDto.ABSOLUTE_ALERT: return ServiceAnalysis.SummarizedContraIndicationAlert.ABSOLUTE_ALERT;
                case SummarizedContraIndicationAlertDto.NO_ALERT: return ServiceAnalysis.SummarizedContraIndicationAlert.NO_ALERT;
                case SummarizedContraIndicationAlertDto.RELATIVE_ALERT: return ServiceAnalysis.SummarizedContraIndicationAlert.RELATIVE_ALERT;
                case SummarizedContraIndicationAlertDto.UNKNOWN_ALERT: return ServiceAnalysis.SummarizedContraIndicationAlert.UNKNOWN_ALERT;
                
            }
            return null;
        }

        internal static VidalAPI.Domain.SummarizedContraIndicationAlert dtoToNative(SummarizedContraIndicationAlertDto? SummarizedContraIndicationAlert)
        {
            switch (SummarizedContraIndicationAlert)
            {
                case SummarizedContraIndicationAlertDto.ABSOLUTE_ALERT: return VidalAPI.Domain.SummarizedContraIndicationAlert.SUMMARIZEDCONTRAINDICATIONALERT_ABSOLUTE_ALERT;
                case SummarizedContraIndicationAlertDto.NO_ALERT: return VidalAPI.Domain.SummarizedContraIndicationAlert.SUMMARIZEDCONTRAINDICATIONALERT_NO_ALERT;
                case SummarizedContraIndicationAlertDto.RELATIVE_ALERT: return VidalAPI.Domain.SummarizedContraIndicationAlert.SUMMARIZEDCONTRAINDICATIONALERT_RELATIVE_ALERT;
                case SummarizedContraIndicationAlertDto.UNKNOWN_ALERT: return VidalAPI.Domain.SummarizedContraIndicationAlert.SUMMARIZEDCONTRAINDICATIONALERT_UNKNOWN_ALERT; 
            }
            return VidalAPI.Domain.SummarizedContraIndicationAlert.SUMMARIZEDCONTRAINDICATIONALERT_JNULL;
        }

    }
}
