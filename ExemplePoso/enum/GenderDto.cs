using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso
{
	public enum GenderDto
	{
        MALE = 0,
        FEMALE = 1,
	}
    public class GenderDtoHelper{
        internal static GenderDto? nativeToBrestFeedingDto(VidalAPI.Domain.Gender nativeBreast)
        {
            switch (nativeBreast)
            {
                case VidalAPI.Domain.Gender.GENDER_FEMALE: return GenderDto.FEMALE;
                case VidalAPI.Domain.Gender.GENDER_MALE: return GenderDto.MALE;
                
            }
            return null;
        }

        internal static GenderDto? vidalToDto(ServiceAnalysis.Gender wsBreast)
        {
            switch (wsBreast)
            {
                case ServiceAnalysis.Gender.FEMALE: return GenderDto.FEMALE;
                case ServiceAnalysis.Gender.MALE: return GenderDto.MALE;
                
            }
            return null;
        }

        internal static ServiceAnalysis.Gender? dtoToAnalysisService(GenderDto? breast)
        {
            switch (breast)
            {
                case GenderDto.FEMALE: return ServiceAnalysis.Gender.FEMALE;
                case GenderDto.MALE: return ServiceAnalysis.Gender.MALE;
                
            }
            return null;
        }
        
        internal static VidalAPI.Domain.Gender dtoToNative(GenderDto? breast)
        {
            switch (breast)
            {
                case GenderDto.FEMALE: return VidalAPI.Domain.Gender.GENDER_FEMALE;
                case GenderDto.MALE: return VidalAPI.Domain.Gender.GENDER_MALE;
                
               }
            return VidalAPI.Domain.Gender.GENDER_JNULL;
        }
        internal static ServicePoso.Gender? dtoToPosoService(GenderDto? breast)
        {
            switch (breast)
            {
                case GenderDto.FEMALE: return ServicePoso.Gender.FEMALE;
                case GenderDto.MALE: return ServicePoso.Gender.MALE;

            }
            return null;
        }
        
    }
    

}
