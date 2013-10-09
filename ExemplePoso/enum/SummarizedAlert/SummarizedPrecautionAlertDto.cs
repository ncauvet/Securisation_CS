using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso
{
    public enum SummarizedPrecautionAlertDto
    {
       HAS_ALERT = 0,
       NO_ALERT = 1,
       UNKNOWN_ALERT = 2,
    }
    public class SummarizedPrecautionAlertDtoHelper
    {
        internal static SummarizedPrecautionAlertDto? nativeToSummarizedPrecautionAlertDto(VidalAPI.Domain.SummarizedPrecautionAlert nativeSummarizedPrecautionAlert)
        {
            switch (nativeSummarizedPrecautionAlert)
            {
                case VidalAPI.Domain.SummarizedPrecautionAlert.SUMMARIZEDPRECAUTIONALERT_HAS_ALERT: return SummarizedPrecautionAlertDto.HAS_ALERT;
                case VidalAPI.Domain.SummarizedPrecautionAlert.SUMMARIZEDPRECAUTIONALERT_NO_ALERT: return SummarizedPrecautionAlertDto.NO_ALERT;
                case VidalAPI.Domain.SummarizedPrecautionAlert.SUMMARIZEDPRECAUTIONALERT_UNKNOWN_ALERT: return SummarizedPrecautionAlertDto.UNKNOWN_ALERT;
                
            }
            return null;
        }

        internal static SummarizedPrecautionAlertDto? wsToSummarizedPrecautionAlertDto(ServiceAnalysis.SummarizedPrecautionAlert? wsSummarizedPrecautionAlert)
        {
            switch (wsSummarizedPrecautionAlert)
            {
                case ServiceAnalysis.SummarizedPrecautionAlert.HAS_ALERT: return SummarizedPrecautionAlertDto.HAS_ALERT;
                case ServiceAnalysis.SummarizedPrecautionAlert.NO_ALERT: return SummarizedPrecautionAlertDto.NO_ALERT;
                case ServiceAnalysis.SummarizedPrecautionAlert.UNKNOWN_ALERT: return SummarizedPrecautionAlertDto.UNKNOWN_ALERT;
                
            }
            return null;
        }

        internal static ServiceAnalysis.SummarizedPrecautionAlert? dtoToAnalysisService(SummarizedPrecautionAlertDto? SummarizedPrecautionAlert)
        {
            switch (SummarizedPrecautionAlert)
            {
                case SummarizedPrecautionAlertDto.HAS_ALERT: return ServiceAnalysis.SummarizedPrecautionAlert.HAS_ALERT;
                case SummarizedPrecautionAlertDto.NO_ALERT: return ServiceAnalysis.SummarizedPrecautionAlert.NO_ALERT;
                case SummarizedPrecautionAlertDto.UNKNOWN_ALERT: return ServiceAnalysis.SummarizedPrecautionAlert.UNKNOWN_ALERT;
                
            }
            return null;
        }

        internal static VidalAPI.Domain.SummarizedPrecautionAlert dtoToNative(SummarizedPrecautionAlertDto? SummarizedPrecautionAlert)
        {
            switch (SummarizedPrecautionAlert)
            {
                case SummarizedPrecautionAlertDto.HAS_ALERT: return VidalAPI.Domain.SummarizedPrecautionAlert.SUMMARIZEDPRECAUTIONALERT_HAS_ALERT;
                case SummarizedPrecautionAlertDto.NO_ALERT: return VidalAPI.Domain.SummarizedPrecautionAlert.SUMMARIZEDPRECAUTIONALERT_NO_ALERT;
                case SummarizedPrecautionAlertDto.UNKNOWN_ALERT: return VidalAPI.Domain.SummarizedPrecautionAlert.SUMMARIZEDPRECAUTIONALERT_UNKNOWN_ALERT;
                
            }
            return VidalAPI.Domain.SummarizedPrecautionAlert.SUMMARIZEDPRECAUTIONALERT_JNULL;
        }

    }
}
