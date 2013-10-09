using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto.poso
{
    public class PrescriptionAnalysisDto
    {
        public List<PrescriptionLineAnalysisDto> PrescriptionLineAnalysisList;

        public PrescriptionAnalysisDto(ServiceAnalysis.prescriptionAnalysis analysis)
        {
            this.PrescriptionLineAnalysisList =PrescriptionLineAnalysisDtoHelper.vidalToDtoList(analysis.prescriptionLineAnalysisList);
        }
        public PrescriptionAnalysisDto(VidalAPI.Domain.PrescriptionAnalysis analysis)
        {
            this.PrescriptionLineAnalysisList = analysis!=null?PrescriptionLineAnalysisDtoHelper.vidalToDtoList(analysis.PrescriptionLineAnalysisList):new List<PrescriptionLineAnalysisDto>();
        }
    }

   

 

    

    

   

}
