using RwandaVSDC.Models.Common;
using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.ValueObjects
{
    public class ProductTypeValueObject: ValueObject<ProductTypeValueObject>
    {
        private static readonly string CodeClassification = "24";
        private static readonly string CodeClassificationName = "Product Type";

        private const string CODE_NAME_1 = "Raw Material";
        private const string CODE_NAME_2 = "Finished Product";
        private const string CODE_NAME_3 = "Service";

        private const string CODE_DESCRIPTION_1 = "Raw Material";
        private const string CODE_DESCRIPTION_2 = "Finished Product";
        private const string CODE_DESCRIPTION_3 = "Service without stock";

        private readonly string _code;
        private readonly int _sortOrder;
        private readonly string _codeName;
        private readonly string _codeDescription;

        public static readonly ProductTypeValueObject RawMaterial = Create(ProductType.RawMaterial);
        public static readonly ProductTypeValueObject FinishedProduct = Create(ProductType.FinishedProduct);
        public static readonly ProductTypeValueObject Service = Create(ProductType.Service);

        private ProductTypeValueObject(int sortOrder, string codeName, string codeDescription)
        {
            _code = sortOrder.ToString();
            _sortOrder = sortOrder;
            _codeName = codeName;
            _codeDescription = codeDescription;
        }

        public string Code => _code;
        public int SortOrder => _sortOrder;
        public string CodeName => _codeName;
        public string CodeDescription => _codeDescription;

        public static ProductTypeValueObject Create(ProductType productType)
        {
            switch (productType)
            {
                case ProductType.RawMaterial:
                    return new ProductTypeValueObject((int)productType, CODE_NAME_1, CODE_DESCRIPTION_1);
                case ProductType.FinishedProduct:
                    return new ProductTypeValueObject((int)productType, CODE_NAME_2, CODE_DESCRIPTION_2);
                case ProductType.Service:
                    return new ProductTypeValueObject((int)productType, CODE_NAME_3, CODE_DESCRIPTION_3);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected override bool EqualsCore(ProductTypeValueObject other)
        {
            return _code == other._code &&
                   _sortOrder == other._sortOrder &&
                   _codeName == other._codeName &&
                   _codeDescription == other._codeDescription;
        }

        protected override int GetHashCodeCore()
        {
            return HashCode.Combine(_code, _sortOrder, _codeName, _codeDescription);
        }
    }
}
