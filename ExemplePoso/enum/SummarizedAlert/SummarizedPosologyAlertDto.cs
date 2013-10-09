using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso
{
    public enum SummarizedPosologyAlertDto
    {
       HAS_ALERT = 0,
       NO_ALERT = 1,
       UNKNOWN_ALERT = 2,
    }
    public class SummarizedPosologyAlertDtoHelper
    {
        internal static SummarizedPosologyAlertDto? nativeToSummarizedPosologyAlertDto(VidalAPI.Domain.SummarizedPosologyAlert nativeSummarizedPosologyAlert)
        {
            switch (nativeSummarizedPosologyAlert)
            {
                case VidalAPI.Domain.SummarizedPosologyAlert.SUMMARIZEDPOSOLOGYALERT_HAS_ALERT: return SummarizedPosologyAlertDto.HAS_ALERT;
                case VidalAPI.Domain.SummarizedPosologyAlert.SUMMARIZEDPOSOLOGYALERT_NO_ALERT: return SummarizedPosologyAlertDto.NO_ALERT;
                case VidalAPI.Domain.SummarizedPosologyAlert.SUMMARIZEDPOSOLOGYALERT_UNKNOWN_ALERT: return SummarizedPosologyAlertDto.UNKNOWN_ALERT;
            }
            return null;
        }

        internal static SummarizedPosologyAlertDto? wsToSummarizedPosologyAlertDto(ServiceAnalysis.SummarizedPosologyAlert? wsSummarizedPosologyAlert)
        {
            switch (wsSummarizedPosologyAlert)
            {
                case ServiceAnalysis.SummarizedPosologyAlert.HAS_ALERT: return SummarizedPosologyAlertDto.HAS_ALERT;
                case ServiceAnalysis.SummarizedPosologyAlert.NO_ALERT: return SummarizedPosologyAlertDto.NO_ALERT;
                case ServiceAnalysis.SummarizedPosologyAlert.UNKNOWN_ALERT: return SummarizedPosologyAlertDto.UNKNOWN_ALERT;
                
            }
            return null;
        }

        internal static ServiceAnalysis.SummarizedPosologyAlert? dtoToAnalysisService(SummarizedPosologyAlertDto? SummarizedPosologyAlert)
        {
            switch (SummarizedPosologyAlert)
            {
                case SummarizedPosologyAlertDto.HAS_ALERT: return ServiceAnalysis.SummarizedPosologyAlert.HAS_ALERT;
                case SummarizedPosologyAlertDto.NO_ALERT: return ServiceAnalysis.SummarizedPosologyAlert.NO_ALERT;
                case SummarizedPosologyAlertDto.UNKNOWN_ALERT: return ServiceAnalysis.SummarizedPosologyAlert.UNKNOWN_ALERT;
                
            }
            return null;
        }

        internal static VidalAPI.Domain.SummarizedPosologyAlert dtoToNative(SummarizedPosologyAlertDto? SummarizedPosologyAlert)
        {
            switch (SummarizedPosologyAlert)
            {
                case SummarizedPosologyAlertDto.HAS_ALERT: return VidalAPI.Domain.SummarizedPosologyAlert.SUMMARIZEDPOSOLOGYALERT_HAS_ALERT;
                case SummarizedPosologyAlertDto.NO_ALERT: return VidalAPI.Domain.SummarizedPosologyAlert.SUMMARIZEDPOSOLOGYALERT_NO_ALERT;
                case SummarizedPosologyAlertDto.UNKNOWN_ALERT: return VidalAPI.Domain.SummarizedPosologyAlert.SUMMARIZEDPOSOLOGYALERT_UNKNOWN_ALERT;
                
            }
            return VidalAPI.Domain.SummarizedPosologyAlert.SUMMARIZEDPOSOLOGYALERT_JNULL;
        }

    }
}
