﻿using RwandaVSDC.Models.Common;
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
        public static readonly string CodeClassification = UnitOfQuantityCodes.CodeClassification;
        public static readonly string CodeClassificationName = UnitOfQuantityCodes.CodeClassificationName;

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

        public static UnitOfQuantityCodeValueObject Create(string unitOfQuantityCode)
        {
            if (!UnitOfQuantityCodes.Codes.ContainsKey(unitOfQuantityCode))
            {
                throw new ArgumentException($"Invalid unit of quantity code: {unitOfQuantityCode}");
            }

            CodeInfo unitOfQuantityCodeInfo = UnitOfQuantityCodes.Codes[unitOfQuantityCode];
            return new UnitOfQuantityCodeValueObject(unitOfQuantityCodeInfo.Code, unitOfQuantityCodeInfo.SortOrder, unitOfQuantityCodeInfo.CodeName, unitOfQuantityCodeInfo.CodeDescription);
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
