using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso
{
	public enum DurationTypeDto
	{
        MINUTE = 0,
        HOUR = 1,
        DAY = 2,
        WEEK = 3,
        MONTH = 4,
        YEAR = 5,
        NULL = -1,
	}
    public class DurationTypeDtoHelper{
        internal static DurationTypeDto? vidalToDto(VidalAPI.Domain.DurationType nativeBreast)
        {
            switch (nativeBreast)
            {
                case VidalAPI.Domain.DurationType.DURATIONTYPE_DAY: return DurationTypeDto.DAY;
                case VidalAPI.Domain.DurationType.DURATIONTYPE_HOUR: return DurationTypeDto.HOUR;
                case VidalAPI.Domain.DurationType.DURATIONTYPE_WEEK: return DurationTypeDto.WEEK;
                case VidalAPI.Domain.DurationType.DURATIONTYPE_YEAR: return DurationTypeDto.YEAR;
                case VidalAPI.Domain.DurationType.DURATIONTYPE_MINUTE: return DurationTypeDto.MINUTE;
                case VidalAPI.Domain.DurationType.DURATIONTYPE_MONTH: return DurationTypeDto.MONTH;
            }
            return DurationTypeDto.NULL;
        }

        internal static DurationTypeDto? vidalToDto(ServiceAnalysis.DurationType? wsBreast)
        {
            switch (wsBreast)
            {
                
                case ServiceAnalysis.DurationType.DAY: return DurationTypeDto.DAY;
                case ServiceAnalysis.DurationType.HOUR: return DurationTypeDto.HOUR;
                case ServiceAnalysis.DurationType.WEEK: return DurationTypeDto.WEEK;
                case ServiceAnalysis.DurationType.YEAR: return DurationTypeDto.YEAR;
                case ServiceAnalysis.DurationType.MINUTE: return DurationTypeDto.MINUTE;
                case ServiceAnalysis.DurationType.MONTH: return DurationTypeDto.MONTH;
            }
            return null;
        }

       


        internal static ServiceAnalysis.DurationType? dtoToAnalysisService(DurationTypeDto? breast)
        {
            switch (breast)
            {
                
                case DurationTypeDto.DAY: return ServiceAnalysis.DurationType.DAY;
                case DurationTypeDto.HOUR: return ServiceAnalysis.DurationType.HOUR;
                case DurationTypeDto.WEEK: return ServiceAnalysis.DurationType.WEEK;
                case DurationTypeDto.YEAR: return ServiceAnalysis.DurationType.YEAR;
                case DurationTypeDto.MINUTE: return ServiceAnalysis.DurationType.MINUTE;
                case DurationTypeDto.MONTH: return ServiceAnalysis.DurationType.MONTH;
            }
            return null;
        }
        
        internal static VidalAPI.Domain.DurationType dtoToNative(DurationTypeDto? breast)
        {
            switch (breast)
            {
                case DurationTypeDto.DAY: return VidalAPI.Domain.DurationType.DURATIONTYPE_DAY;
                case DurationTypeDto.HOUR: return VidalAPI.Domain.DurationType.DURATIONTYPE_HOUR;
                case DurationTypeDto.WEEK: return VidalAPI.Domain.DurationType.DURATIONTYPE_WEEK;
                case DurationTypeDto.YEAR: return VidalAPI.Domain.DurationType.DURATIONTYPE_YEAR;
                case DurationTypeDto.MINUTE: return VidalAPI.Domain.DurationType.DURATIONTYPE_MINUTE;
                case DurationTypeDto.MONTH: return VidalAPI.Domain.DurationType.DURATIONTYPE_MONTH;
               }
            return VidalAPI.Domain.DurationType.DURATIONTYPE_JNULL;
        }

        
        internal static DurationTypeDto? vidalToDto(ServicePoso.DurationType? wsBreast)
        {
            switch (wsBreast)
            {

                case ServicePoso.DurationType.DAY: return DurationTypeDto.DAY;
                case ServicePoso.DurationType.HOUR: return DurationTypeDto.HOUR;
                case ServicePoso.DurationType.WEEK: return DurationTypeDto.WEEK;
                case ServicePoso.DurationType.YEAR: return DurationTypeDto.YEAR;
                case ServicePoso.DurationType.MINUTE: return DurationTypeDto.MINUTE;
                case ServicePoso.DurationType.MONTH: return DurationTypeDto.MONTH;
            }
            return null;
        }
    }
    

}
