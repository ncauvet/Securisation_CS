using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso
{
    public enum PosologyFrequencyTypeDto
    {
        THIS_DAY = 0,
        PER_DAY = 1,
        PER_24_HOURS = 2,
        PER_WEEK = 3,
        PER_MONTH = 4,
        PER_YEAR = 5,
        PER_2_DAYS = 6,
        //PER_N_HOURS = 7, //equals PER_24_HOURS
        PER_HOUR = 8,
        PER_MINUTE = 9,
        //TYPE_66 = 10,//equals PER_24_HOURS
        //TYPE_46 = 11,//equals PER_24_HOURS
        //TYPE_44 = 12,//equals PER_24_HOURS
    }
    public class PosologyFrequencyTypeDtoHelper{
        internal static PosologyFrequencyTypeDto? nativeToPosologyFrequencyTypeDto(VidalAPI.Domain.PosologyFrequencyType? PosologyFrequencyType)
        {
            switch (PosologyFrequencyType)
            {
                case VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_2_DAYS: return PosologyFrequencyTypeDto.PER_2_DAYS;
                case VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_24_HOURS: return PosologyFrequencyTypeDto.PER_24_HOURS;
                case VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_DAY: return PosologyFrequencyTypeDto.PER_DAY;
                case VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_HOUR: return PosologyFrequencyTypeDto.PER_HOUR;
                case VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_MINUTE: return PosologyFrequencyTypeDto.PER_MINUTE;
                case VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_MONTH: return PosologyFrequencyTypeDto.PER_MONTH;
                case VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_N_HOURS: return PosologyFrequencyTypeDto.PER_24_HOURS;
                case VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_WEEK: return PosologyFrequencyTypeDto.PER_WEEK;
                case VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_YEAR: return PosologyFrequencyTypeDto.PER_YEAR;
                case VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_THIS_DAY: return PosologyFrequencyTypeDto.THIS_DAY;
                case VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_TYPE_44: return PosologyFrequencyTypeDto.PER_24_HOURS;
                case VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_TYPE_46: return PosologyFrequencyTypeDto.PER_24_HOURS;
                case VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_TYPE_66: return PosologyFrequencyTypeDto.PER_24_HOURS;
            }
            return null;
        }

        internal static PosologyFrequencyTypeDto? wsToPosologyFrequencyTypeDto(ServiceAnalysis.PosologyFrequencyType? PosologyFrequencyType)
        {
            switch (PosologyFrequencyType)
            {
                case ServiceAnalysis.PosologyFrequencyType.PER_2_DAYS: return PosologyFrequencyTypeDto.PER_2_DAYS;
                case ServiceAnalysis.PosologyFrequencyType.PER_24_HOURS: return PosologyFrequencyTypeDto.PER_24_HOURS;
                case ServiceAnalysis.PosologyFrequencyType.PER_DAY: return PosologyFrequencyTypeDto.PER_DAY;
                case ServiceAnalysis.PosologyFrequencyType.PER_HOUR: return PosologyFrequencyTypeDto.PER_HOUR;
                case ServiceAnalysis.PosologyFrequencyType.PER_MINUTE: return PosologyFrequencyTypeDto.PER_MINUTE;
                case ServiceAnalysis.PosologyFrequencyType.PER_MONTH: return PosologyFrequencyTypeDto.PER_MONTH;
                case ServiceAnalysis.PosologyFrequencyType.PER_N_HOURS: return PosologyFrequencyTypeDto.PER_24_HOURS;
                case ServiceAnalysis.PosologyFrequencyType.PER_WEEK: return PosologyFrequencyTypeDto.PER_WEEK;
                case ServiceAnalysis.PosologyFrequencyType.PER_YEAR: return PosologyFrequencyTypeDto.PER_YEAR;
                case ServiceAnalysis.PosologyFrequencyType.THIS_DAY: return PosologyFrequencyTypeDto.THIS_DAY;
                case ServiceAnalysis.PosologyFrequencyType.TYPE_44: return PosologyFrequencyTypeDto.PER_24_HOURS;
                case ServiceAnalysis.PosologyFrequencyType.TYPE_46: return PosologyFrequencyTypeDto.PER_24_HOURS;
                case ServiceAnalysis.PosologyFrequencyType.TYPE_66: return PosologyFrequencyTypeDto.PER_24_HOURS;
               
            }
            return null;
        }
      
        internal static ServiceAnalysis.PosologyFrequencyType? dtoToAnalysisService(PosologyFrequencyTypeDto? PosologyFrequencyType)
        {
            switch (PosologyFrequencyType)
            {
                case PosologyFrequencyTypeDto.PER_2_DAYS: return ServiceAnalysis.PosologyFrequencyType.PER_2_DAYS;
                case PosologyFrequencyTypeDto.PER_24_HOURS: return ServiceAnalysis.PosologyFrequencyType.PER_24_HOURS;
                case PosologyFrequencyTypeDto.PER_DAY: return ServiceAnalysis.PosologyFrequencyType.PER_DAY;
                case PosologyFrequencyTypeDto.PER_HOUR: return ServiceAnalysis.PosologyFrequencyType.PER_HOUR;
                case PosologyFrequencyTypeDto.PER_MINUTE: return ServiceAnalysis.PosologyFrequencyType.PER_MINUTE;
                case PosologyFrequencyTypeDto.PER_MONTH: return ServiceAnalysis.PosologyFrequencyType.PER_MONTH;
                case PosologyFrequencyTypeDto.PER_WEEK: return ServiceAnalysis.PosologyFrequencyType.PER_WEEK;
                case PosologyFrequencyTypeDto.PER_YEAR: return ServiceAnalysis.PosologyFrequencyType.PER_YEAR;
                case PosologyFrequencyTypeDto.THIS_DAY: return ServiceAnalysis.PosologyFrequencyType.THIS_DAY;
               
            }
            return null;
        }
        internal static ServicePoso.PosologyFrequencyType? dtoToPosoService(PosologyFrequencyTypeDto? PosologyFrequencyType)
        {
            switch (PosologyFrequencyType)
            {
                case PosologyFrequencyTypeDto.PER_2_DAYS: return ServicePoso.PosologyFrequencyType.PER_2_DAYS;
                case PosologyFrequencyTypeDto.PER_24_HOURS: return ServicePoso.PosologyFrequencyType.PER_24_HOURS;
                case PosologyFrequencyTypeDto.PER_DAY: return ServicePoso.PosologyFrequencyType.PER_DAY;
                case PosologyFrequencyTypeDto.PER_HOUR: return ServicePoso.PosologyFrequencyType.PER_HOUR;
                case PosologyFrequencyTypeDto.PER_MINUTE: return ServicePoso.PosologyFrequencyType.PER_MINUTE;
                case PosologyFrequencyTypeDto.PER_MONTH: return ServicePoso.PosologyFrequencyType.PER_MONTH;
                case PosologyFrequencyTypeDto.PER_WEEK: return ServicePoso.PosologyFrequencyType.PER_WEEK;
                case PosologyFrequencyTypeDto.PER_YEAR: return ServicePoso.PosologyFrequencyType.PER_YEAR;
                case PosologyFrequencyTypeDto.THIS_DAY: return ServicePoso.PosologyFrequencyType.THIS_DAY;
            }
            return null;
        }
        internal static VidalAPI.Domain.PosologyFrequencyType dtoToNative(PosologyFrequencyTypeDto? PosologyFrequencyType)
        {
            switch (PosologyFrequencyType)
            {
                case PosologyFrequencyTypeDto.PER_2_DAYS: return VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_2_DAYS;
                case PosologyFrequencyTypeDto.PER_24_HOURS: return VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_24_HOURS;
                case PosologyFrequencyTypeDto.PER_DAY: return VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_DAY;
                case PosologyFrequencyTypeDto.PER_HOUR: return VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_HOUR;
                case PosologyFrequencyTypeDto.PER_MINUTE: return VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_MINUTE;
                case PosologyFrequencyTypeDto.PER_MONTH: return VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_MONTH;
                case PosologyFrequencyTypeDto.PER_WEEK: return VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_WEEK;
                case PosologyFrequencyTypeDto.PER_YEAR: return VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_PER_YEAR;
                case PosologyFrequencyTypeDto.THIS_DAY: return VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_THIS_DAY;
               }
            return VidalAPI.Domain.PosologyFrequencyType.POSOLOGYFREQUENCYTYPE_JNULL;
        }

        
        internal static PosologyFrequencyTypeDto? wsToPosologyFrequencyTypeDto(ServicePoso.PosologyFrequencyType? PosologyFrequencyType)
        {
            switch (PosologyFrequencyType)
            {
                case ServicePoso.PosologyFrequencyType.PER_2_DAYS: return PosologyFrequencyTypeDto.PER_2_DAYS;
                case ServicePoso.PosologyFrequencyType.PER_24_HOURS: return PosologyFrequencyTypeDto.PER_24_HOURS;
                case ServicePoso.PosologyFrequencyType.PER_DAY: return PosologyFrequencyTypeDto.PER_DAY;
                case ServicePoso.PosologyFrequencyType.PER_HOUR: return PosologyFrequencyTypeDto.PER_HOUR;
                case ServicePoso.PosologyFrequencyType.PER_MINUTE: return PosologyFrequencyTypeDto.PER_MINUTE;
                case ServicePoso.PosologyFrequencyType.PER_MONTH: return PosologyFrequencyTypeDto.PER_MONTH;
                case ServicePoso.PosologyFrequencyType.PER_N_HOURS: return PosologyFrequencyTypeDto.PER_24_HOURS;
                case ServicePoso.PosologyFrequencyType.PER_WEEK: return PosologyFrequencyTypeDto.PER_WEEK;
                case ServicePoso.PosologyFrequencyType.PER_YEAR: return PosologyFrequencyTypeDto.PER_YEAR;
                case ServicePoso.PosologyFrequencyType.THIS_DAY: return PosologyFrequencyTypeDto.THIS_DAY;
                case ServicePoso.PosologyFrequencyType.TYPE_44: return PosologyFrequencyTypeDto.PER_24_HOURS;
                case ServicePoso.PosologyFrequencyType.TYPE_46: return PosologyFrequencyTypeDto.PER_24_HOURS;
                case ServicePoso.PosologyFrequencyType.TYPE_66: return PosologyFrequencyTypeDto.PER_24_HOURS;

            }
            return null;
        }

    }
    

}
