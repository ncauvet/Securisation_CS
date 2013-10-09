using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ExemplePoso
{
    class ViewHelper
    {

        internal static Bitmap getLevelImage(IEnumerable<dto.AlertDto> alerts)
        {
            SeverityLevelDto highest = SeverityLevelDto.UNKNOWN;

            foreach (dto.AlertDto alert in alerts)
            {
                if (alert.Severity == SeverityLevelDto.LEVEL_4)
                {
                    highest = SeverityLevelDto.LEVEL_4;
                    break;
                }
                else if (alert.Severity == SeverityLevelDto.LEVEL_3)
                {
                    highest = SeverityLevelDto.LEVEL_3;
                }
                else if (alert.Severity == SeverityLevelDto.LEVEL_2 && highest != SeverityLevelDto.LEVEL_3)
                {
                    highest = SeverityLevelDto.LEVEL_2;
                }
                else if (alert.Severity == SeverityLevelDto.LEVEL_1 && highest != SeverityLevelDto.LEVEL_3 && highest != SeverityLevelDto.LEVEL_2)
                {
                    highest = SeverityLevelDto.LEVEL_1;
                }
                else if (alert.Severity == SeverityLevelDto.UNKNOWN && highest != SeverityLevelDto.LEVEL_3 && highest != SeverityLevelDto.LEVEL_2 && highest != SeverityLevelDto.LEVEL_1)
                {
                    highest = SeverityLevelDto.UNKNOWN;
                }
            }

            switch (highest)
            {
                case SeverityLevelDto.LEVEL_1: return Resource1.interaction10;
                case SeverityLevelDto.LEVEL_2: return Resource1.interaction20;
                case SeverityLevelDto.LEVEL_3: return Resource1.interaction30;
                case SeverityLevelDto.LEVEL_4: return Resource1.interaction40;
                case SeverityLevelDto.UNKNOWN: return Resource1.unknownIam;
            }
            return Resource1.unknownType;
        }

        internal static Image getVigilanceIcon(dto.ProductDto product)
        {
            switch (product.Vigilance)
            {
                case VigilanceDto.UNSPECIFIED: return Resource1.vigilanceOff;
                case VigilanceDto.VIGILANCE_0: return Resource1.vigilance0;
                case VigilanceDto.VIGILANCE_1: return Resource1.vigilance1;
                case VigilanceDto.VIGILANCE_2: return Resource1.vigilance2;
                case VigilanceDto.VIGILANCE_3: return Resource1.vigilance3;
                case VigilanceDto.VIGILANCE_5: return Resource1.vigilance4;
            }
            return Resource1.unknownType;
        }

        internal static Image getGenericIcon(dto.ProductDto product)
        {
            switch (product.GenericType)
            {
                case GenericTypeDto.GENERIC:return Resource1.genericLarge;
                case GenericTypeDto.REFERENT:return Resource1.genericReferenceLarge;
            }
            return Resource1.genericLargeOff;
        }
    }

}