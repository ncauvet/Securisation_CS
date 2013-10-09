using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplePoso.dto
{
    public class ProductDto
    {
        //  public AmmType AmmType { get; set; }
        public string Cis { get; set; }
        public int? CommonNameGroupId { get; set; }
        public bool DrugInSport { get; set; }
        public bool Exceptional { get; set; }
        public string Flavor { get; set; }
        public GenericTypeDto? GenericType { get; set; }
        public int? Id { get; set; }
        //  public ListType List { get; set; }
        public string ListValue { get; set; }
        //public MarketStatus MarketStatus { get; set; }
        public float? MaxUcdRangePrice { get; set; }
        public bool Midwife { get; set; }
        public float? MinUcdRangePrice { get; set; }
        public string Name { get; set; }
        public string PerVolume { get; set; }
        public string PerVolumeUnit { get; set; }
        //public RefundRate RefundingRate { get; set; }
        public string RefundingRateValue { get; set; }
        public bool SafetyAlert { get; set; }
        //public ProductType Type { get; set; }
        public VigilanceDto? Vigilance { get; set; }
    }
    public class ProductDtoHelper
    {
        internal static ProductDto vidalToDto(VidalAPI.Domain.Product nativeProduct)
        {
            ProductDto dto = new ProductDto();
            dto.Id = nativeProduct.Id;
            dto.Cis = nativeProduct.Cis;
            dto.CommonNameGroupId = nativeProduct.CommonNameGroupId;
            dto.DrugInSport = nativeProduct.DrugInSport;
            dto.Exceptional = nativeProduct.Exceptional;
            dto.Flavor = nativeProduct.Flavor;
            dto.ListValue = nativeProduct.ListValue;
            dto.MaxUcdRangePrice = nativeProduct.MaxUcdRangePrice;
            dto.Midwife = nativeProduct.Midwife;
            dto.MinUcdRangePrice = nativeProduct.MinUcdRangePrice;
            dto.Name = nativeProduct.Name;
            dto.PerVolume = nativeProduct.PerVolume;
            dto.PerVolumeUnit = nativeProduct.PerVolumeUnit;
            dto.RefundingRateValue = nativeProduct.RefundingRateValue;
            dto.SafetyAlert = nativeProduct.SafetyAlert;
            dto.Vigilance = VigilanceDtoHelper.vidalToDto(nativeProduct.Vigilance);
            dto.GenericType = GenericTypeDtoHelper.vidalToDto(nativeProduct.GenericType);
            return dto;
        }
        internal static List<ProductDto> vidalToDtoList(VidalAPI.Domain.ProductList nativeProducts)
        {
            List<ProductDto> products = new List<ProductDto>();
            foreach (VidalAPI.Domain.Product product in nativeProducts)
            {
                products.Add(vidalToDto(product));
            }
            return products;
        }

        internal static ProductDto vidalToDto(ServiceProduct.product wsProduct)
        {
            ProductDto dto = new ProductDto();
            dto.Id = wsProduct.id;
            dto.Cis = wsProduct.cis;
            dto.CommonNameGroupId = wsProduct.commonNameGroupId;
            dto.DrugInSport = wsProduct.drugInSport;
            dto.Exceptional = wsProduct.exceptional;
            dto.Flavor = wsProduct.flavor;
            dto.ListValue = wsProduct.listValue;
            dto.MaxUcdRangePrice = wsProduct.maxUcdRangePrice;
            dto.Midwife = wsProduct.midwife;
            dto.MinUcdRangePrice = wsProduct.minUcdRangePrice;
            dto.Name = wsProduct.name;
            dto.PerVolume = wsProduct.perVolume;
            dto.PerVolumeUnit = wsProduct.perVolumeUnit;
            dto.RefundingRateValue = wsProduct.refundingRateValue;
            dto.SafetyAlert = wsProduct.safetyAlert;
            dto.Vigilance = VigilanceDtoHelper.vidalToDto(wsProduct.vigilance);
            dto.GenericType = GenericTypeDtoHelper.vidalToDto(wsProduct.genericType);
            return dto;
        }
        internal static List<ProductDto> vidalToDtoList(ServiceProduct.ArrayOfProduct wsProducts)
        {
            List<ProductDto> products = new List<ProductDto>();
            foreach (ServiceProduct.product product in wsProducts)
            {
                products.Add(vidalToDto(product));
            }
            return products;
        }
    }
}
