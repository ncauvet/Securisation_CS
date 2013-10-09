using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso
{
	  public enum SummarizedInteractionAlertDto
    {
        TAKE_INTO_ACCOUNT = 0,
        PRECAUTION_USE = 1,
        DISADVISES_ASSOCIATION = 2,
        CONTRAINDICATIONS = 3,
        NO_ALERT = 4,
        UNKNOWN_ALERT = 5,
    }
    public class SummarizedInteractionAlertDtoHelper
    {
        internal static SummarizedInteractionAlertDto? nativeToSummarizedInteractionAlertDto(VidalAPI.Domain.SummarizedInteractionAlert nativeSummarizedInteractionAlert)
        {
            switch (nativeSummarizedInteractionAlert)
            {
                case VidalAPI.Domain.SummarizedInteractionAlert.SUMMARIZEDINTERACTIONALERT_CONTRAINDICATIONS: return SummarizedInteractionAlertDto.CONTRAINDICATIONS;
                case VidalAPI.Domain.SummarizedInteractionAlert.SUMMARIZEDINTERACTIONALERT_DISADVISES_ASSOCIATION: return SummarizedInteractionAlertDto.DISADVISES_ASSOCIATION;
                case VidalAPI.Domain.SummarizedInteractionAlert.SUMMARIZEDINTERACTIONALERT_NO_ALERT: return SummarizedInteractionAlertDto.NO_ALERT;
                case VidalAPI.Domain.SummarizedInteractionAlert.SUMMARIZEDINTERACTIONALERT_PRECAUTION_USE: return SummarizedInteractionAlertDto.PRECAUTION_USE;
                case VidalAPI.Domain.SummarizedInteractionAlert.SUMMARIZEDINTERACTIONALERT_TAKE_INTO_ACCOUNT: return SummarizedInteractionAlertDto.TAKE_INTO_ACCOUNT;
                case VidalAPI.Domain.SummarizedInteractionAlert.SUMMARIZEDINTERACTIONALERT_UNKNOWN_ALERT: return SummarizedInteractionAlertDto.UNKNOWN_ALERT;
            }
            return null;
        }

        internal static SummarizedInteractionAlertDto? wsToSummarizedInteractionAlertDto(ServiceAnalysis.SummarizedInteractionAlert? wsSummarizedInteractionAlert)
        {
            switch (wsSummarizedInteractionAlert)
            {
                case ServiceAnalysis.SummarizedInteractionAlert.CONTRAINDICATIONS: return SummarizedInteractionAlertDto.CONTRAINDICATIONS;
                case ServiceAnalysis.SummarizedInteractionAlert.DISADVISES_ASSOCIATION: return SummarizedInteractionAlertDto.DISADVISES_ASSOCIATION;
                case ServiceAnalysis.SummarizedInteractionAlert.NO_ALERT: return SummarizedInteractionAlertDto.NO_ALERT;
                case ServiceAnalysis.SummarizedInteractionAlert.PRECAUTION_USE: return SummarizedInteractionAlertDto.PRECAUTION_USE;
                case ServiceAnalysis.SummarizedInteractionAlert.TAKE_INTO_ACCOUNT: return SummarizedInteractionAlertDto.TAKE_INTO_ACCOUNT;
                case ServiceAnalysis.SummarizedInteractionAlert.UNKNOWN_ALERT: return SummarizedInteractionAlertDto.UNKNOWN_ALERT;
            }
            return null;
        }

        internal static ServiceAnalysis.SummarizedInteractionAlert? dtoToAnalysisService(SummarizedInteractionAlertDto? SummarizedInteractionAlert)
        {
            switch (SummarizedInteractionAlert)
            {
                case SummarizedInteractionAlertDto.CONTRAINDICATIONS: return ServiceAnalysis.SummarizedInteractionAlert.CONTRAINDICATIONS;
                case SummarizedInteractionAlertDto.DISADVISES_ASSOCIATION: return ServiceAnalysis.SummarizedInteractionAlert.DISADVISES_ASSOCIATION;
                case SummarizedInteractionAlertDto.NO_ALERT: return ServiceAnalysis.SummarizedInteractionAlert.NO_ALERT;
                case SummarizedInteractionAlertDto.PRECAUTION_USE: return ServiceAnalysis.SummarizedInteractionAlert.PRECAUTION_USE;
                case SummarizedInteractionAlertDto.TAKE_INTO_ACCOUNT: return ServiceAnalysis.SummarizedInteractionAlert.TAKE_INTO_ACCOUNT;
                case SummarizedInteractionAlertDto.UNKNOWN_ALERT: return ServiceAnalysis.SummarizedInteractionAlert.UNKNOWN_ALERT;
            }
            return null;
        }

        internal static VidalAPI.Domain.SummarizedInteractionAlert dtoToNative(SummarizedInteractionAlertDto? SummarizedInteractionAlert)
        {
            switch (SummarizedInteractionAlert)
            {
                case SummarizedInteractionAlertDto.CONTRAINDICATIONS: return VidalAPI.Domain.SummarizedInteractionAlert.SUMMARIZEDINTERACTIONALERT_CONTRAINDICATIONS;
                case SummarizedInteractionAlertDto.DISADVISES_ASSOCIATION: return VidalAPI.Domain.SummarizedInteractionAlert.SUMMARIZEDINTERACTIONALERT_DISADVISES_ASSOCIATION;
                case SummarizedInteractionAlertDto.NO_ALERT: return VidalAPI.Domain.SummarizedInteractionAlert.SUMMARIZEDINTERACTIONALERT_NO_ALERT;
                case SummarizedInteractionAlertDto.PRECAUTION_USE: return VidalAPI.Domain.SummarizedInteractionAlert.SUMMARIZEDINTERACTIONALERT_PRECAUTION_USE;
                case SummarizedInteractionAlertDto.TAKE_INTO_ACCOUNT: return VidalAPI.Domain.SummarizedInteractionAlert.SUMMARIZEDINTERACTIONALERT_TAKE_INTO_ACCOUNT;
                case SummarizedInteractionAlertDto.UNKNOWN_ALERT: return VidalAPI.Domain.SummarizedInteractionAlert.SUMMARIZEDINTERACTIONALERT_UNKNOWN_ALERT;

            }
            return VidalAPI.Domain.SummarizedInteractionAlert.SUMMARIZEDINTERACTIONALERT_JNULL;
        }

    }
}
