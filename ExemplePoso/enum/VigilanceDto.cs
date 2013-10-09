using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso
{
	public enum VigilanceDto
	{
        //VIGILANCE_JNULL = -1,
        VIGILANCE_0 = 0,
        VIGILANCE_1 = 1,
        VIGILANCE_2 = 2,
        VIGILANCE_3 = 3,
        VIGILANCE_5 = 4,
        UNSPECIFIED = 5,
	}
    public class VigilanceDtoHelper
    {
        internal static VigilanceDto? vidalToDto(VidalAPI.Domain.Vigilance nativeVigilance)
        {
            switch (nativeVigilance)
            {
                case VidalAPI.Domain.Vigilance.VIGILANCE_UNSPECIFIED: return VigilanceDto.UNSPECIFIED;
                case VidalAPI.Domain.Vigilance.VIGILANCE_VIGILANCE_0: return VigilanceDto.VIGILANCE_0;
                case VidalAPI.Domain.Vigilance.VIGILANCE_VIGILANCE_1: return VigilanceDto.VIGILANCE_1;
                case VidalAPI.Domain.Vigilance.VIGILANCE_VIGILANCE_2: return VigilanceDto.VIGILANCE_2;
                case VidalAPI.Domain.Vigilance.VIGILANCE_VIGILANCE_3: return VigilanceDto.VIGILANCE_3;
                case VidalAPI.Domain.Vigilance.VIGILANCE_VIGILANCE_5: return VigilanceDto.VIGILANCE_5;
            }
            return null;
        }

        internal static VigilanceDto? vidalToDto(ServiceProduct.Vigilance? wsVigilance)
        {
            switch (wsVigilance)
            {
                case ServiceProduct.Vigilance.UNSPECIFIED: return VigilanceDto.UNSPECIFIED;
                case ServiceProduct.Vigilance.VIGILANCE_0: return VigilanceDto.VIGILANCE_0;
                case ServiceProduct.Vigilance.VIGILANCE_1: return VigilanceDto.VIGILANCE_1;
                case ServiceProduct.Vigilance.VIGILANCE_2: return VigilanceDto.VIGILANCE_2;
                case ServiceProduct.Vigilance.VIGILANCE_3: return VigilanceDto.VIGILANCE_3;
                case ServiceProduct.Vigilance.VIGILANCE_5: return VigilanceDto.VIGILANCE_5;
            }
            return null;
        }

        internal static ServiceProduct.Vigilance? dtoToProductService(VigilanceDto? Vigilance)
        {
            switch (Vigilance)
            {
                case VigilanceDto.UNSPECIFIED: return ServiceProduct.Vigilance.UNSPECIFIED;
                case VigilanceDto.VIGILANCE_0: return ServiceProduct.Vigilance.VIGILANCE_0;
                case VigilanceDto.VIGILANCE_1: return ServiceProduct.Vigilance.VIGILANCE_1;
                case VigilanceDto.VIGILANCE_2: return ServiceProduct.Vigilance.VIGILANCE_2;
                case VigilanceDto.VIGILANCE_3: return ServiceProduct.Vigilance.VIGILANCE_3;
                case VigilanceDto.VIGILANCE_5: return ServiceProduct.Vigilance.VIGILANCE_5;
            }
            return null;
        }

        internal static VidalAPI.Domain.Vigilance dtoToNative(VigilanceDto? Vigilance)
        {
            switch (Vigilance)
            {
                case VigilanceDto.UNSPECIFIED: return VidalAPI.Domain.Vigilance.VIGILANCE_UNSPECIFIED;
                case VigilanceDto.VIGILANCE_0: return VidalAPI.Domain.Vigilance.VIGILANCE_VIGILANCE_0;
                case VigilanceDto.VIGILANCE_1: return VidalAPI.Domain.Vigilance.VIGILANCE_VIGILANCE_1;
                case VigilanceDto.VIGILANCE_2: return VidalAPI.Domain.Vigilance.VIGILANCE_VIGILANCE_2;
                case VigilanceDto.VIGILANCE_3: return VidalAPI.Domain.Vigilance.VIGILANCE_VIGILANCE_3;
                case VigilanceDto.VIGILANCE_5: return VidalAPI.Domain.Vigilance.VIGILANCE_VIGILANCE_5;

            }
            return VidalAPI.Domain.Vigilance.VIGILANCE_JNULL;
        }

    }
}
