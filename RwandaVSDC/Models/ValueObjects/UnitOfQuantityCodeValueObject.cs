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
    public class UnitOfQuantityCodeValueObject: ValueObject<UnitOfQuantityCodeValueObject>
    {
        private readonly string _code;
        private readonly int _sortOrder;
        private readonly string _codeName;
        private readonly string _codeDescription;

        private UnitOfQuantityCodeValueObject(string code, int sortOrder, string codeName, string codeDescription)
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

        public static UnitOfQuantityCodeValueObject Create(string packagingUnitCode)
        {
            if (!UnityOfQuantityCodes.Codes.ContainsKey(packagingUnitCode))
            {
                throw new ArgumentException($"Invalid packaging unit code: {packagingUnitCode}");
            }

            CodeInfo unitOfQuantityCode = UnityOfQuantityCodes.Codes[packagingUnitCode];
            return new UnitOfQuantityCodeValueObject(unitOfQuantityCode.Code, unitOfQuantityCode.SortOrder, unitOfQuantityCode.CodeName, unitOfQuantityCode.CodeDescription);
        }

        protected override bool EqualsCore(UnitOfQuantityCodeValueObject other)
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
