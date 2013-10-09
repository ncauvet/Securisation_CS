using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso
{
	public enum HepaticInsufficiencyDto
	{
        NONE = 0,
        MODERATE = 1,
        SEVERE = 2,
	}
    public class HepaticDtoHelper{
        internal static HepaticInsufficiencyDto? nativeToHepaticDto(VidalAPI.Domain.HepaticInsufficiency hepatic)
        {
            switch (hepatic)
            {
                case VidalAPI.Domain.HepaticInsufficiency.HEPATICINSUFFICIENCY_MODERATE: return HepaticInsufficiencyDto.MODERATE;
                case VidalAPI.Domain.HepaticInsufficiency.HEPATICINSUFFICIENCY_NONE: return HepaticInsufficiencyDto.NONE;
                case VidalAPI.Domain.HepaticInsufficiency.HEPATICINSUFFICIENCY_SEVERE: return HepaticInsufficiencyDto.SEVERE;
            }
            return null;
        }

        internal static HepaticInsufficiencyDto? wsToHepaticDto(ServiceAnalysis.HepaticInsufficiency hepatic)
        {
            switch (hepatic)
            {
                case ServiceAnalysis.HepaticInsufficiency.MODERATE: return HepaticInsufficiencyDto.MODERATE;
                case ServiceAnalysis.HepaticInsufficiency.NONE: return HepaticInsufficiencyDto.NONE;
                case ServiceAnalysis.HepaticInsufficiency.SEVERE: return HepaticInsufficiencyDto.SEVERE;
            }
            return null;
        }

        internal static ServiceAnalysis.HepaticInsufficiency? dtoToAnalysisService(HepaticInsufficiencyDto? hepatic)
        {
            switch (hepatic)
            {
                case HepaticInsufficiencyDto.SEVERE: return ServiceAnalysis.HepaticInsufficiency.SEVERE;
                case HepaticInsufficiencyDto.NONE: return ServiceAnalysis.HepaticInsufficiency.NONE;
                case HepaticInsufficiencyDto.MODERATE: return ServiceAnalysis.HepaticInsufficiency.MODERATE;
            }
            return null;
        }
        internal static ServicePoso.HepaticInsufficiency? dtoToPosoService(HepaticInsufficiencyDto? hepatic)
        {
            switch (hepatic)
            {
                case HepaticInsufficiencyDto.MODERATE: return ServicePoso.HepaticInsufficiency.MODERATE;
                case HepaticInsufficiencyDto.NONE: return ServicePoso.HepaticInsufficiency.NONE;
                case HepaticInsufficiencyDto.SEVERE: return ServicePoso.HepaticInsufficiency.SEVERE;
            }
            return null;
        }
        internal static VidalAPI.Domain.HepaticInsufficiency dtoToNative(HepaticInsufficiencyDto? hepatic)
        {
            switch (hepatic)
            {
                case HepaticInsufficiencyDto.MODERATE: return VidalAPI.Domain.HepaticInsufficiency.HEPATICINSUFFICIENCY_MODERATE;
                case HepaticInsufficiencyDto.NONE: return VidalAPI.Domain.HepaticInsufficiency.HEPATICINSUFFICIENCY_NONE;
                case HepaticInsufficiencyDto.SEVERE: return VidalAPI.Domain.HepaticInsufficiency.HEPATICINSUFFICIENCY_SEVERE;
               }
            return VidalAPI.Domain.HepaticInsufficiency.HEPATICINSUFFICIENCY_JNULL;
        }
    }
    

}
