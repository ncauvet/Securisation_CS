using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto
{
    public class AlertDto
    {
        public string Comment;
        public List<ReferenceDto> ReferenceList;
        public SeverityLevelDto? Severity;
        public string Title;
        public string Type;
        public List<RelatedElementDto> relatedElements;

        public AlertDto(ServiceAnalysis.alert alert)
        {
            this.Comment = alert.comment;
            this.ReferenceList =ReferenceDtoHelper.vidalToReferenceDtoList(alert.referenceList);
            this.Severity = SeverityLevelDtoHelper.wsToSeverityLevelDto(alert.severity);
            this.Title = alert.title;
            this.Type = alert.type;
            this.relatedElements =  RelatedElementDtoHelper.vidalToDtoList(alert.relatedElementList);
        }
        public AlertDto(VidalAPI.Domain.Alert alert)
        {
            this.Comment = alert.Comment;
            this.ReferenceList = ReferenceDtoHelper.vidalToReferenceDtoList(alert.ReferenceList);
            this.Severity = SeverityLevelDtoHelper.nativeToSeverityLevelDto(alert.Severity);
            this.Title = alert.Title;
            this.Type = alert.Type;
            this.relatedElements = RelatedElementDtoHelper.vidalToDtoList(alert.RelatedElementList);
        }
    }
    public class AlertDtoHelper
    {

        internal static List<AlertDto> vidalToAlertDtoList(ServiceAnalysis.ArrayOfAlert wsAlerts)
        {
            List<AlertDto> Result = new List<AlertDto>();
            foreach (ServiceAnalysis.alert Alert in wsAlerts)
            {
                Result.Add(new AlertDto(Alert));
            }
            return Result;
        }

        internal static List<AlertDto> vidalToAlertDtoList(VidalAPI.Domain.AlertList nativeAlerts)
        {
            List<AlertDto> result = new List<AlertDto>();
            foreach (VidalAPI.Domain.Alert Alert in nativeAlerts)
            {
                result.Add(new AlertDto(Alert));
            }
            return result;
        }
    }
}
