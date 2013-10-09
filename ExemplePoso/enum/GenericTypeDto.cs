using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso
{
	public enum GenericTypeDto
	{
        GENERIC = 0,
        REFERENT = 1,
        NULL = 2,
	}
    public class GenericTypeDtoHelper
    {
        internal static GenericTypeDto? vidalToDto(VidalAPI.Domain.GenericType nativeGenericType)
        {
            switch (nativeGenericType)
            {
                case VidalAPI.Domain.GenericType.GENERICTYPE_GENERIC: return GenericTypeDto.GENERIC;
                case VidalAPI.Domain.GenericType.GENERICTYPE_NULL: return GenericTypeDto.NULL;
                case VidalAPI.Domain.GenericType.GENERICTYPE_REFERENT: return GenericTypeDto.REFERENT;
                
            }
            return null;
        }

        internal static GenericTypeDto? vidalToDto(ServiceProduct.GenericType? wsGenericType)
        {
            switch (wsGenericType)
            {
                case ServiceProduct.GenericType.GENERIC: return GenericTypeDto.GENERIC;
                case ServiceProduct.GenericType.NULL: return GenericTypeDto.NULL;
                case ServiceProduct.GenericType.REFERENT: return GenericTypeDto.REFERENT;
               
            }
            return null;
        }

        internal static ServiceProduct.GenericType? dtoToProductService(GenericTypeDto? GenericType)
        {
            switch (GenericType)
            {
                case GenericTypeDto.GENERIC: return ServiceProduct.GenericType.GENERIC;
                case GenericTypeDto.NULL: return ServiceProduct.GenericType.NULL;
                case GenericTypeDto.REFERENT: return ServiceProduct.GenericType.REFERENT;
                
            }
            return null;
        }

        internal static VidalAPI.Domain.GenericType dtoToNative(GenericTypeDto? GenericType)
        {
            switch (GenericType)
            {
                case GenericTypeDto.GENERIC: return VidalAPI.Domain.GenericType.GENERICTYPE_GENERIC;
                case GenericTypeDto.NULL: return VidalAPI.Domain.GenericType.GENERICTYPE_NULL;
                case GenericTypeDto.REFERENT: return VidalAPI.Domain.GenericType.GENERICTYPE_REFERENT;
               

            }
            return VidalAPI.Domain.GenericType.GENERICTYPE_JNULL;
        }

    }
}
