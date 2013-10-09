using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExemplePoso.dto.poso;

namespace ExemplePoso.dto
{
    public class NumberOfDosesDto
    {
        public DurationRangeDto AbsoluteDurationRange;
        public List<SimplePosologyAlertDto> Alerts;
        public NumberOfDoseDto MaxAbsoluteNumberOfDose;
        public List<RouteDto> Routes;
        public DurationRangeDto UsualDurationRange;
        public NumberOfDoseRangeDto UsualNumberOfDoseRange;

        public NumberOfDosesDto(ServicePoso.NumberOfDoses doses){
            this.AbsoluteDurationRange = doses.absoluteDurationRange!=null?new DurationRangeDto(doses.absoluteDurationRange):null;
            this.Alerts = SimplePosologyAlertDtoHelper.vidalToRouteDtoList(doses.alerts);
            this.MaxAbsoluteNumberOfDose =doses.maxAbsoluteNumberOfDose!=null?new NumberOfDoseDto(doses.maxAbsoluteNumberOfDose):null;
            this.Routes = RouteDtoHelper.vidalToRouteDtoList(doses.routes);
            this.UsualDurationRange = doses.usualDurationRange!=null?new DurationRangeDto(doses.usualDurationRange):null;
            this.UsualNumberOfDoseRange = doses.usualNumberOfDoseRange!=null?new NumberOfDoseRangeDto(doses.usualNumberOfDoseRange):null;
        }

        public NumberOfDosesDto(VidalAPI.Domain.NumberOfDoses doses){
            this.AbsoluteDurationRange = doses.AbsoluteDurationRange!=null?new DurationRangeDto(doses.AbsoluteDurationRange):null;
            this.Alerts = SimplePosologyAlertDtoHelper.vidalToRouteDtoList(doses.Alerts);
            this.MaxAbsoluteNumberOfDose =doses.MaxAbsoluteNumberOfDose!=null?new NumberOfDoseDto(doses.MaxAbsoluteNumberOfDose):null;
            this.Routes = RouteDtoHelper.vidalToRouteDtoList(doses.Routes);
            this.UsualDurationRange = doses.UsualDurationRange!=null?new DurationRangeDto(doses.UsualDurationRange):null;
            this.UsualNumberOfDoseRange = doses.UsualNumberOfDoseRange!=null?new NumberOfDoseRangeDto(doses.UsualNumberOfDoseRange):null;
        }
    }
    public class NumberOfDosesDtoHelper
    {

        internal static List<NumberOfDosesDto> vidalToDtoList(List<VidalAPI.Domain.NumberOfDoses> nativeDoses)
        {
            List<NumberOfDosesDto> result = new List<NumberOfDosesDto>();
            foreach (VidalAPI.Domain.NumberOfDoses dose in nativeDoses)
            {
                result.Add(new NumberOfDosesDto(dose));
            }
            return result;
        }

        internal static List<NumberOfDosesDto> vidalToDtoList(List<ServicePoso.NumberOfDoses> nativeDoses)
        {
            List<NumberOfDosesDto> result = new List<NumberOfDosesDto>();
            foreach (ServicePoso.NumberOfDoses dose in nativeDoses)
            {
                result.Add(new NumberOfDosesDto(dose));
            }
            return result;
        }
    }
  
}
       
  

