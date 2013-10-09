using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso
{
    public enum SummarizedAllergyAlertDto
    {
        HAS_ALERT = 0,
        NO_ALERT = 1,
        UNKNOWN_ALERT = 2,
    }
    public class SummarizedAllergyAlertDtoHelper
    {
        internal static SummarizedAllergyAlertDto? nativeToSummarizedAllergyAlertDto(VidalAPI.Domain.SummarizedAllergyAlert nativeSummarizedAllergyAlert)
        {
            switch (nativeSummarizedAllergyAlert)
            {
                case VidalAPI.Domain.SummarizedAllergyAlert.SUMMARIZEDALLERGYALERT_HAS_ALERT: return SummarizedAllergyAlertDto.HAS_ALERT;
                case VidalAPI.Domain.SummarizedAllergyAlert.SUMMARIZEDALLERGYALERT_NO_ALERT: return SummarizedAllergyAlertDto.NO_ALERT;
                case VidalAPI.Domain.SummarizedAllergyAlert.SUMMARIZEDALLERGYALERT_UNKNOWN_ALERT: return SummarizedAllergyAlertDto.UNKNOWN_ALERT;
                
            }
            return null;
        }

        internal static SummarizedAllergyAlertDto? wsToSummarizedAllergyAlertDto(ServiceAnalysis.SummarizedAllergyAlert? wsSummarizedAllergyAlert)
        {
            switch (wsSummarizedAllergyAlert)
            {
                case ServiceAnalysis.SummarizedAllergyAlert.HAS_ALERT: return SummarizedAllergyAlertDto.HAS_ALERT;
                case ServiceAnalysis.SummarizedAllergyAlert.NO_ALERT: return SummarizedAllergyAlertDto.NO_ALERT;
                case ServiceAnalysis.SummarizedAllergyAlert.UNKNOWN_ALERT: return SummarizedAllergyAlertDto.UNKNOWN_ALERT;
                
            }
            return null;
        }

        internal static ServiceAnalysis.SummarizedAllergyAlert? dtoToAnalysisService(SummarizedAllergyAlertDto? SummarizedAllergyAlert)
        {
            switch (SummarizedAllergyAlert)
            {
                case SummarizedAllergyAlertDto.HAS_ALERT: return ServiceAnalysis.SummarizedAllergyAlert.HAS_ALERT;
                case SummarizedAllergyAlertDto.NO_ALERT: return ServiceAnalysis.SummarizedAllergyAlert.NO_ALERT;
                case SummarizedAllergyAlertDto.UNKNOWN_ALERT: return ServiceAnalysis.SummarizedAllergyAlert.UNKNOWN_ALERT;
                
            }
            return null;
        }

        internal static VidalAPI.Domain.SummarizedAllergyAlert dtoToNative(SummarizedAllergyAlertDto? SummarizedAllergyAlert)
        {
            switch (SummarizedAllergyAlert)
            {
                case SummarizedAllergyAlertDto.HAS_ALERT: return VidalAPI.Domain.SummarizedAllergyAlert.SUMMARIZEDALLERGYALERT_HAS_ALERT;
                case SummarizedAllergyAlertDto.NO_ALERT: return VidalAPI.Domain.SummarizedAllergyAlert.SUMMARIZEDALLERGYALERT_NO_ALERT;
                case SummarizedAllergyAlertDto.UNKNOWN_ALERT: return VidalAPI.Domain.SummarizedAllergyAlert.SUMMARIZEDALLERGYALERT_UNKNOWN_ALERT;
                
            }
            return VidalAPI.Domain.SummarizedAllergyAlert.SUMMARIZEDALLERGYALERT_JNULL;
        }

    }
}
