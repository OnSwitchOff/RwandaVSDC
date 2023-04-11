using RwandaVSDC.Models.Common;
using RwandaVSDC.Models.Data;
using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.ValueObjects
{
    internal class PackagingUnitCodeValueObject : ValueObject<PackagingUnitCodeValueObject>
    {
        public static readonly string CodeClassification = "17";
        public static readonly string CodeClassificationName = "Packaging Unit";

        private readonly string _code;
        private readonly int _sortOrder;
        private readonly string _codeName;
        private readonly string _codeDescription;

        private PackagingUnitCodeValueObject(string code, int sortOrder, string codeName, string codeDescription)
        {
            _code = code;
            _sortOrder = sortOrder;
            _codeName = codeName;
            _codeDescription = codeDescription;
        }

        public string Code => _code;
        public int SortOrder => _sortOrder;
        public string CodeName => _codeName;
        public string CodeDescription => _codeDescription;

        public static PackagingUnitCodeValueObject Create(PackagingUnitCode packagingUnitCode)
        {
            if (!PackagingUnitCodes.Codes.ContainsKey(packagingUnitCode))
            {
                throw new ArgumentException($"Invalid packaging unit code: {packagingUnitCode}");
            }

            CodeInfo unitOfQuantityCode = PackagingUnitCodes.Codes[packagingUnitCode];
            return new PackagingUnitCodeValueObject(unitOfQuantityCode.Code, unitOfQuantityCode.SortOrder, unitOfQuantityCode.CodeName, unitOfQuantityCode.CodeDescription);


        }

        protected override bool EqualsCore(PackagingUnitCodeValueObject other)
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
