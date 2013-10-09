using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso
{
	public enum BreastFeedingDto
	{
        NONE = 0,
        LESS_THAN_ONE_MONTH = 1,
        MORE_THAN_ONE_MONTH = 2,
        ALL = 3,
	}
    public class BreastFeedingDtoHelper{
        internal static BreastFeedingDto? nativeToBrestFeedingDto(VidalAPI.Domain.Breastfeeding nativeBreast)
        {
            switch (nativeBreast)
            {
                case VidalAPI.Domain.Breastfeeding.BREASTFEEDING_ALL: return BreastFeedingDto.ALL;
                case VidalAPI.Domain.Breastfeeding.BREASTFEEDING_LESS_THAN_ONE_MONTH: return BreastFeedingDto.LESS_THAN_ONE_MONTH;
                case VidalAPI.Domain.Breastfeeding.BREASTFEEDING_MORE_THAN_ONE_MONTH: return BreastFeedingDto.MORE_THAN_ONE_MONTH;
                case VidalAPI.Domain.Breastfeeding.BREASTFEEDING_NONE: return BreastFeedingDto.NONE;
            }
            return null;
        }

        internal static BreastFeedingDto? wsToBreastfeedingDto(ServiceAnalysis.Breastfeeding wsBreast)
        {
            switch (wsBreast)
            {
                case ServiceAnalysis.Breastfeeding.ALL: return BreastFeedingDto.ALL;
                case ServiceAnalysis.Breastfeeding.LESS_THAN_ONE_MONTH: return BreastFeedingDto.LESS_THAN_ONE_MONTH;
                case ServiceAnalysis.Breastfeeding.MORE_THAN_ONE_MONTH: return BreastFeedingDto.MORE_THAN_ONE_MONTH;
                case ServiceAnalysis.Breastfeeding.NONE: return BreastFeedingDto.NONE;
            }
            return null;
        }

        internal static ServiceAnalysis.Breastfeeding? dtoToAnalysisService(BreastFeedingDto? breast)
        {
            switch (breast)
            {
                case BreastFeedingDto.ALL: return ServiceAnalysis.Breastfeeding.ALL;
                case BreastFeedingDto.LESS_THAN_ONE_MONTH: return ServiceAnalysis.Breastfeeding.LESS_THAN_ONE_MONTH;
                case BreastFeedingDto.MORE_THAN_ONE_MONTH: return ServiceAnalysis.Breastfeeding.MORE_THAN_ONE_MONTH;
                case BreastFeedingDto.NONE: return ServiceAnalysis.Breastfeeding.NONE;
            }
            return null;
        }
        
        internal static VidalAPI.Domain.Breastfeeding dtoToNative(BreastFeedingDto? breast)
        {
            switch (breast)
            {
                case BreastFeedingDto.ALL: return VidalAPI.Domain.Breastfeeding.BREASTFEEDING_ALL;
                case BreastFeedingDto.LESS_THAN_ONE_MONTH: return VidalAPI.Domain.Breastfeeding.BREASTFEEDING_LESS_THAN_ONE_MONTH;
                case BreastFeedingDto.MORE_THAN_ONE_MONTH: return VidalAPI.Domain.Breastfeeding.BREASTFEEDING_MORE_THAN_ONE_MONTH;
                case BreastFeedingDto.NONE: return VidalAPI.Domain.Breastfeeding.BREASTFEEDING_NONE;
               }
            return VidalAPI.Domain.Breastfeeding.BREASTFEEDING_JNULL;
        }
    }
    

}
