using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto.poso
{
    public class NumberOfDoseDto
    {
        public PosologyFrequencyTypeDto? Type;
        public PosologyUnitDto Unit;
        public double Value;

        public NumberOfDoseDto(ServicePoso.numberOfDose nod){
            this.Type = PosologyFrequencyTypeDtoHelper.wsToPosologyFrequencyTypeDto(nod.type);
            this.Unit = PosologyUnitDtoHelper.vidalToDto(nod.unit);
            this.Value = nod.value;
        }
        public NumberOfDoseDto(VidalAPI.Domain.NumberOfDose nod)
        {
            this.Type = PosologyFrequencyTypeDtoHelper.nativeToPosologyFrequencyTypeDto(nod.Type);
            this.Unit = PosologyUnitDtoHelper.vidalToDto(nod.Unit);
            this.Value = nod.Value;
        }
    }

    public class NumberOfDoseRangeDto
    {
        public NumberOfDoseDto Max;
        public NumberOfDoseDto Min;

        public NumberOfDoseRangeDto(ServicePoso.numberOfDoseRange range){
            this.Max = range.max!=null?new NumberOfDoseDto(range.max):null;
            this.Min = range.min!=null?new NumberOfDoseDto(range.min):null;
        }
        public NumberOfDoseRangeDto(VidalAPI.Domain.NumberOfDoseRange range)
        {
            this.Max = range.Max!=null?new NumberOfDoseDto(range.Max):null;
            this.Min = range.Min!=null?new NumberOfDoseDto(range.Min):null;
        }
    }
}
