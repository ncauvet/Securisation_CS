using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso
{
    public enum SummarizedRedundantInteractionAlertDto
    {
        HAS_ALERT = 0,
        NO_ALERT = 1,
        UNKNOWN_ALERT = 2,
    }
    public class SummarizedRedundantInteractionAlertDtoHelper
    {
        internal static SummarizedRedundantInteractionAlertDto? nativeToSummarizedRedundantInteractionAlertDto(VidalAPI.Domain.SummarizedRedundantInteractionAlert nativeSummarizedRedundantInteractionAlert)
        {
            switch (nativeSummarizedRedundantInteractionAlert)
            {
                case VidalAPI.Domain.SummarizedRedundantInteractionAlert.SUMMARIZEDREDUNDANTINTERACTIONALERT_HAS_ALERT: return SummarizedRedundantInteractionAlertDto.HAS_ALERT;
                case VidalAPI.Domain.SummarizedRedundantInteractionAlert.SUMMARIZEDREDUNDANTINTERACTIONALERT_NO_ALERT: return SummarizedRedundantInteractionAlertDto.NO_ALERT;
                case VidalAPI.Domain.SummarizedRedundantInteractionAlert.SUMMARIZEDREDUNDANTINTERACTIONALERT_UNKNOWN_ALERT: return SummarizedRedundantInteractionAlertDto.UNKNOWN_ALERT;
                
            }
            return null;
        }

        internal static SummarizedRedundantInteractionAlertDto? wsToSummarizedRedundantInteractionAlertDto(ServiceAnalysis.SummarizedRedundantInteractionAlert? wsSummarizedRedundantInteractionAlert)
        {
            switch (wsSummarizedRedundantInteractionAlert)
            {
                case ServiceAnalysis.SummarizedRedundantInteractionAlert.HAS_ALERT: return SummarizedRedundantInteractionAlertDto.HAS_ALERT;
                case ServiceAnalysis.SummarizedRedundantInteractionAlert.NO_ALERT: return SummarizedRedundantInteractionAlertDto.NO_ALERT;
                case ServiceAnalysis.SummarizedRedundantInteractionAlert.UNKNOWN_ALERT: return SummarizedRedundantInteractionAlertDto.UNKNOWN_ALERT;
            }
            return null;
        }

        internal static ServiceAnalysis.SummarizedRedundantInteractionAlert? dtoToAnalysisService(SummarizedRedundantInteractionAlertDto? SummarizedRedundantInteractionAlert)
        {
            switch (SummarizedRedundantInteractionAlert)
            {
                case SummarizedRedundantInteractionAlertDto.HAS_ALERT: return ServiceAnalysis.SummarizedRedundantInteractionAlert.HAS_ALERT;
                case SummarizedRedundantInteractionAlertDto.NO_ALERT: return ServiceAnalysis.SummarizedRedundantInteractionAlert.NO_ALERT;
                case SummarizedRedundantInteractionAlertDto.UNKNOWN_ALERT: return ServiceAnalysis.SummarizedRedundantInteractionAlert.UNKNOWN_ALERT;
                
            }
            return null;
        }

        internal static VidalAPI.Domain.SummarizedRedundantInteractionAlert dtoToNative(SummarizedRedundantInteractionAlertDto? SummarizedRedundantInteractionAlert)
        {
            switch (SummarizedRedundantInteractionAlert)
            {
                case SummarizedRedundantInteractionAlertDto.HAS_ALERT: return VidalAPI.Domain.SummarizedRedundantInteractionAlert.SUMMARIZEDREDUNDANTINTERACTIONALERT_HAS_ALERT;
                case SummarizedRedundantInteractionAlertDto.NO_ALERT: return VidalAPI.Domain.SummarizedRedundantInteractionAlert.SUMMARIZEDREDUNDANTINTERACTIONALERT_NO_ALERT;
                case SummarizedRedundantInteractionAlertDto.UNKNOWN_ALERT: return VidalAPI.Domain.SummarizedRedundantInteractionAlert.SUMMARIZEDREDUNDANTINTERACTIONALERT_UNKNOWN_ALERT;
                

            }
            return VidalAPI.Domain.SummarizedRedundantInteractionAlert.SUMMARIZEDREDUNDANTINTERACTIONALERT_JNULL;
        }

    }
}
