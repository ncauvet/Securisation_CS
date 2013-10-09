using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto.poso
{
    public class PosologyDurationDto
    {
        public DurationTypeDto? Type;
        public int Value;

        public PosologyDurationDto(ServicePoso.PosologyDuration posoDuration){
            this.Type = DurationTypeDtoHelper.vidalToDto(posoDuration.type != null?posoDuration.type : null);
            this.Value = posoDuration.value;
        }
        public PosologyDurationDto(VidalAPI.Domain.PosologyDuration posoDuration)
        {
            this.Type = DurationTypeDtoHelper.vidalToDto(posoDuration.Type);
            this.Value = posoDuration.Value;
        }
    }
    
    public class DurationRangeDto
    {
        public PosologyDurationDto Max;
        public PosologyDurationDto Min;

        public DurationRangeDto(ServicePoso.durationRange range)
        {
            this.Max = range.max != null?new PosologyDurationDto(range.max):null;
            this.Min = range.min != null?new PosologyDurationDto(range.min):null;
        }
        public DurationRangeDto(VidalAPI.Domain.DurationRange range)
        {
            this.Max = range.Max!=null?new PosologyDurationDto(range.Max):null;
            this.Min = range.Min!=null?new PosologyDurationDto(range.Min):null;
        }
    }
}
