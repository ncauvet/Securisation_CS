using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto
{
    public class MoleculeDto
    {
        public bool AllergyAlert { get; set; }
        public bool Homeopathy { get; set; }
        public int? Id { get; set; }
        public string Name { get; set; }
        //public SubstanceRole Role { get; }
    }
    public class MoleculeDtoHelper
    {
        internal static MoleculeDto vidalToDto(VidalAPI.Domain.Molecule nativeMolecule)
        {
            MoleculeDto dto = new MoleculeDto();
            dto.AllergyAlert = nativeMolecule.AllergyAlert;
            dto.Homeopathy = nativeMolecule.Homeopathy;
            dto.Id = nativeMolecule.Id;
            dto.Name = nativeMolecule.Name;
            return dto;
        }
        internal static List<MoleculeDto> vidalToDtoList(VidalAPI.Domain.MoleculeList nativeMolecules)
        {
            List<MoleculeDto> Molecules = new List<MoleculeDto>();
            foreach (VidalAPI.Domain.Molecule Molecule in nativeMolecules)
            {
                Molecules.Add(vidalToDto(Molecule));
            }
            return Molecules;
        }

        internal static MoleculeDto vidalToDto(ServiceMolecule.molecule wsMolecule)
        {
            MoleculeDto dto = new MoleculeDto();
            dto.AllergyAlert = wsMolecule.allergyAlert;
            dto.Homeopathy = wsMolecule.homeopathy;
            dto.Id = wsMolecule.id;
            dto.Name = wsMolecule.name;
            return dto;

        }
        internal static List<MoleculeDto> vidalToDtoList(ServiceMolecule.ArrayOfMolecule wsMolecules)
        {
            List<MoleculeDto> Molecules = new List<MoleculeDto>();
            foreach (ServiceMolecule.molecule Molecule in wsMolecules)
            {
                Molecules.Add(vidalToDto(Molecule));
            }
            return Molecules;
        }
    }
}
