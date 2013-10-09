using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto.poso
{
    public class PrescriptionLineAnalysisDto
    {
        public List<AlertDto> AlertList;
        public double? Dose;
        public SummarizedDrugDto Drug;
        public int? Dur;
        public DurationTypeDto? DurUnit;
        public PosologyFrequencyTypeDto? PosologyFrequency;
        public string Unit;

        public PrescriptionLineAnalysisDto(ServiceAnalysis.prescriptionLineAnalysis line)
        {
            this.AlertList = AlertDtoHelper.vidalToAlertDtoList(line.alertList);
            this.Dose = line.dose;
            this.Drug = line.drug != null ? new SummarizedDrugDto(line.drug) : null;
            this.Dur = line.dur;
            this.DurUnit = DurationTypeDtoHelper.vidalToDto(line.durUnit);
            this.PosologyFrequency = PosologyFrequencyTypeDtoHelper.wsToPosologyFrequencyTypeDto(line.posologyFrequency);
            this.Unit = line.unit;
        }
        public PrescriptionLineAnalysisDto(VidalAPI.Domain.PrescriptionLineAnalysis line)
        {
            this.AlertList = AlertDtoHelper.vidalToAlertDtoList(line.AlertList);
            this.Dose = line.Dose;
            this.Drug = line.Drug != null ? new SummarizedDrugDto(line.Drug) : null;
            this.Dur = line.Dur;
            this.DurUnit = DurationTypeDtoHelper.vidalToDto(line.DurUnit);
            this.PosologyFrequency = PosologyFrequencyTypeDtoHelper.nativeToPosologyFrequencyTypeDto(line.PosologyFrequency);
            this.Unit = line.Unit;
        }
    }

    public class PrescriptionLineAnalysisDtoHelper
    {

        internal static List<PrescriptionLineAnalysisDto> vidalToDtoList(ServiceAnalysis.ArrayOfPrescriptionLineAnalysis wsLines)
        {
            List<PrescriptionLineAnalysisDto> Result = new List<PrescriptionLineAnalysisDto>();
            foreach (ServiceAnalysis.prescriptionLineAnalysis line in wsLines)
            {
                Result.Add(new PrescriptionLineAnalysisDto(line));
            }
            return Result;
        }

        internal static List<PrescriptionLineAnalysisDto> vidalToDtoList(VidalAPI.Domain.PrescriptionLineAnalysisList lines)
        {
            List<PrescriptionLineAnalysisDto> Result = new List<PrescriptionLineAnalysisDto>();
            foreach (VidalAPI.Domain.PrescriptionLineAnalysis line in lines)
            {
                Result.Add(new PrescriptionLineAnalysisDto(line));
            }
            return Result;
        }

    }

}
