using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso
{
	public enum SeverityLevelDto
	{
        INFO = 0,
        LEVEL_1 = 1,
        LEVEL_2 = 2,
        LEVEL_3 = 3,
        LEVEL_4 = 4,
        UNKNOWN = 5,
	}
    public class SeverityLevelDtoHelper
    {
        internal static SeverityLevelDto? nativeToSeverityLevelDto(VidalAPI.Domain.SeverityLevel nativeSeverityLevel)
        {
            switch (nativeSeverityLevel)
            {
                case VidalAPI.Domain.SeverityLevel.SEVERITYLEVEL_INFO: return SeverityLevelDto.INFO;
                case VidalAPI.Domain.SeverityLevel.SEVERITYLEVEL_LEVEL_1: return SeverityLevelDto.LEVEL_1;
                case VidalAPI.Domain.SeverityLevel.SEVERITYLEVEL_LEVEL_2: return SeverityLevelDto.LEVEL_2;
                case VidalAPI.Domain.SeverityLevel.SEVERITYLEVEL_LEVEL_3: return SeverityLevelDto.LEVEL_3;
                case VidalAPI.Domain.SeverityLevel.SEVERITYLEVEL_LEVEL_4: return SeverityLevelDto.LEVEL_4;
                case VidalAPI.Domain.SeverityLevel.SEVERITYLEVEL_UNKNOWN: return SeverityLevelDto.UNKNOWN;
            }
            return null;
        }

        internal static SeverityLevelDto? wsToSeverityLevelDto(ServiceAnalysis.SeverityLevel? wsSeverityLevel)
        {
            switch (wsSeverityLevel)
            {
                case ServiceAnalysis.SeverityLevel.INFO: return SeverityLevelDto.INFO;
                case ServiceAnalysis.SeverityLevel.LEVEL_1: return SeverityLevelDto.LEVEL_1;
                case ServiceAnalysis.SeverityLevel.LEVEL_2: return SeverityLevelDto.LEVEL_2;
                case ServiceAnalysis.SeverityLevel.LEVEL_3: return SeverityLevelDto.LEVEL_3;
                case ServiceAnalysis.SeverityLevel.LEVEL_4: return SeverityLevelDto.LEVEL_4;
                case ServiceAnalysis.SeverityLevel.UNKNOWN: return SeverityLevelDto.UNKNOWN;
            }
            return null;
        }

        internal static ServiceAnalysis.SeverityLevel? dtoToAnalysisService(SeverityLevelDto? SeverityLevel)
        {
            switch (SeverityLevel)
            {
                case SeverityLevelDto.INFO: return ServiceAnalysis.SeverityLevel.INFO;
                case SeverityLevelDto.LEVEL_1: return ServiceAnalysis.SeverityLevel.LEVEL_1;
                case SeverityLevelDto.LEVEL_2: return ServiceAnalysis.SeverityLevel.LEVEL_2;
                case SeverityLevelDto.LEVEL_3: return ServiceAnalysis.SeverityLevel.LEVEL_3;
                case SeverityLevelDto.LEVEL_4: return ServiceAnalysis.SeverityLevel.LEVEL_4;
                case SeverityLevelDto.UNKNOWN: return ServiceAnalysis.SeverityLevel.UNKNOWN;
            }
            return null;
        }

        internal static VidalAPI.Domain.SeverityLevel dtoToNative(SeverityLevelDto? SeverityLevel)
        {
            switch (SeverityLevel)
            {
                case SeverityLevelDto.INFO: return VidalAPI.Domain.SeverityLevel.SEVERITYLEVEL_INFO;
                case SeverityLevelDto.LEVEL_1: return VidalAPI.Domain.SeverityLevel.SEVERITYLEVEL_LEVEL_1;
                case SeverityLevelDto.LEVEL_2: return VidalAPI.Domain.SeverityLevel.SEVERITYLEVEL_LEVEL_2;
                case SeverityLevelDto.LEVEL_3: return VidalAPI.Domain.SeverityLevel.SEVERITYLEVEL_LEVEL_3;
                case SeverityLevelDto.LEVEL_4: return VidalAPI.Domain.SeverityLevel.SEVERITYLEVEL_LEVEL_4;
                case SeverityLevelDto.UNKNOWN: return VidalAPI.Domain.SeverityLevel.SEVERITYLEVEL_UNKNOWN;

            }
            return VidalAPI.Domain.SeverityLevel.SEVERITYLEVEL_JNULL;
        }

    }
}
