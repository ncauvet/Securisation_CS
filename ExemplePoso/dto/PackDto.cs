using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto
{
    public class PackDto
    {
       // public ActCode ActCode { get; }
        public string ActCodeValue { get; set; }
        public string Cip { get; set; }
        public string Cip13 { get; set; }
        public string Cis { get; set; }
        public bool CommunityAgrement { get; set; }
       // public DispensationPlace DispensationPlace { get; }
        public string Dose { get; set; }
        public string DoseUnit { get; set; }
        public string Ean { get; set; }
       // public GenericType GenericType { get; }
        public int? Id { get; set; }
       // public ListType List { get; }
        public string ListValue { get; set; }
        public float? ManufacturerPrice { get; set; }
       // public MarketStatus MarketStatus { get; }
       // public PrescriptionDuration MaxPrescriptionDuration { get; }
        public string Name { get; set; }
        public bool NarcoticPrescription { get; set; }
        public float? PharmacistPrice { get; set; }
        public float? PricePerDose { get; set; }
        public int? ProductId { get; set; }
        public float? PublicPrice { get; set; }
        public float? RefundingBase { get; set; }
        //public RefundRate RefundingRate { get; }
        public string RefundingRateValue { get; set; }
        public bool SafetyAlert { get; set; }
        public string ShortName { get; set; }
        public bool Tfr { get; set; }
        //public ProductType Type { get; }
        public float? UcdPrice { get; set; }
        //public VatRate VatRate { get; }
        public float? VatRateValue { get; set; }
    }
    public class PackDtoHelper
    {
        internal static PackDto vidalToDto(VidalAPI.Domain.Pack nativePack)
        {
            PackDto dto = new PackDto();
            dto.ActCodeValue = nativePack.ActCodeValue;
            dto.Cip = nativePack.Cip;
            dto.Cip13 = nativePack.Cip13;
            dto.Cis = nativePack.Cis;
            dto.CommunityAgrement = nativePack.CommunityAgrement;
            dto.Dose = nativePack.Dose;
            dto.DoseUnit = nativePack.DoseUnit;
            dto.Ean = nativePack.Ean;
            dto.Id = nativePack.Id;
            dto.ListValue = nativePack.ListValue;
            dto.ManufacturerPrice = nativePack.ManufacturerPrice;
            dto.Name = nativePack.Name;
            dto.NarcoticPrescription = nativePack.NarcoticPrescription;
            dto.PharmacistPrice = nativePack.PharmacistPrice;
            dto.PricePerDose = nativePack.PricePerDose;
            dto.ProductId = nativePack.ProductId;
            dto.PublicPrice = nativePack.PublicPrice;
            dto.RefundingBase = nativePack.RefundingBase;
            dto.RefundingRateValue = nativePack.RefundingRateValue;
            dto.SafetyAlert = nativePack.SafetyAlert;
            dto.ShortName = nativePack.ShortName;
            dto.Tfr = nativePack.Tfr;
            dto.UcdPrice = nativePack.UcdPrice;
            dto.VatRateValue = nativePack.VatRateValue;

            return dto;
        }
        internal static List<PackDto> vidalToDtoList(VidalAPI.Domain.PackList nativePacks)
        {
            List<PackDto> Packs = new List<PackDto>();
            foreach (VidalAPI.Domain.Pack Pack in nativePacks)
            {
                Packs.Add(vidalToDto(Pack));
            }
            return Packs;
        }

        internal static PackDto vidalToDto(ServicePack.pack wsPack)
        {
            PackDto dto = new PackDto();

            dto.ActCodeValue = wsPack.actCodeValue;
            dto.Cip = wsPack.cip;
            dto.Cip13 = wsPack.cip13;
            dto.Cis = wsPack.cis;
            dto.CommunityAgrement = wsPack.communityAgrement;
            dto.Dose = wsPack.dose;
            dto.DoseUnit = wsPack.doseUnit;
            dto.Ean = wsPack.ean;
            dto.Id = wsPack.id;
            dto.ListValue = wsPack.listValue;
            dto.ManufacturerPrice = wsPack.manufacturerPrice;
            dto.Name = wsPack.name;
            dto.NarcoticPrescription = wsPack.narcoticPrescription;
            dto.PharmacistPrice = wsPack.pharmacistPrice;
            dto.PricePerDose = wsPack.pricePerDose;
            dto.ProductId = wsPack.productId;
            dto.PublicPrice = wsPack.publicPrice;
            dto.RefundingBase = wsPack.refundingBase;
            dto.RefundingRateValue = wsPack.refundingRateValue;
            dto.SafetyAlert = wsPack.safetyAlert;
            dto.ShortName = wsPack.shortName;
            dto.Tfr = wsPack.tfr;
            dto.UcdPrice = wsPack.ucdPrice;
            dto.VatRateValue = wsPack.vatRateValue; return dto;
        }
        internal static List<PackDto> vidalToDtoList(ServicePack.ArrayOfPack wsPacks)
        {
            List<PackDto> Packs = new List<PackDto>();
            foreach (ServicePack.pack Pack in wsPacks)
            {
                Packs.Add(vidalToDto(Pack));
            }
            return Packs;
        }
    }
}
