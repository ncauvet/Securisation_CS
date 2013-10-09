using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto.poso
{
    public class SimplePosologyAlertDto
    {
        public IndicationDto Indication;
        public MessageDto PosologyAlert;

        public SimplePosologyAlertDto(ServicePoso.simplePosologyAlert alert)
        {
            this.Indication = alert.indication!=null?new IndicationDto(alert.indication):null;
            this.PosologyAlert = alert.posologyAlert!=null?new MessageDto(alert.posologyAlert.messageType, alert.posologyAlert.text):null;
        }
        public SimplePosologyAlertDto(VidalAPI.Domain.SimplePosologyAlert alert)
        {
            this.Indication = alert.Indication!=null?new IndicationDto(alert.Indication):null;
            this.PosologyAlert = alert.PosologyAlert!=null?new MessageDto(alert.PosologyAlert.MessageType, alert.PosologyAlert.Text):null;
        }
    }

    public class SimplePosologyAlertDtoHelper
    {

        internal static List<SimplePosologyAlertDto> vidalToRouteDtoList(ServicePoso.ArrayOfSimplePosologyAlert wsAlerts)
        {
            List<SimplePosologyAlertDto> Routes = new List<SimplePosologyAlertDto>();
            foreach (ServicePoso.simplePosologyAlert Alert in wsAlerts)
            {
                Routes.Add(new SimplePosologyAlertDto(Alert));
            }
            return Routes;
        }

        internal static List<SimplePosologyAlertDto> vidalToRouteDtoList(VidalAPI.Domain.SimplePosologyAlertList nativeAlerts)
        {
            List<SimplePosologyAlertDto> result = new List<SimplePosologyAlertDto>();
            foreach (VidalAPI.Domain.SimplePosologyAlert Alert in nativeAlerts)
            {
                result.Add(new SimplePosologyAlertDto(Alert));
            }
            return result;
        }
    }
}
