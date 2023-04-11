using RwandaVSDC.Models.Common;
using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.ValueObjects
{
    public class RegistrationTypeValueObject : ValueObject<RegistrationTypeValueObject>
    {
        private static readonly string CodeClassification = "31";
        private static readonly string CodeClassificationName = "Registration Type";

        private const string CODE_NAME_A = "Automatic";
        private const string CODE_NAME_M = "Manual";

        private const string CODE_DESCRIPTION_A = "Automatic";
        private const string CODE_DESCRIPTION_M = "Manual";

        private readonly string _code;
        private readonly int _sortOrder;
        private readonly string _codeName;
        private readonly string _codeDescription;

        public static readonly RegistrationTypeValueObject Automatic = Create(RegistrationType.Automatic);
        public static readonly RegistrationTypeValueObject Manual = Create(RegistrationType.Manual);

        private RegistrationTypeValueObject(string code, int sortOrder, string codeName, string codeDescription)
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

        public static RegistrationTypeValueObject Create(RegistrationType registrationType)
        {
            switch (registrationType)
            {
                case RegistrationType.Automatic:
                    return new RegistrationTypeValueObject("S", (int)registrationType, CODE_NAME_A, CODE_DESCRIPTION_A);
                case RegistrationType.Manual:
                    return new RegistrationTypeValueObject("R", (int)registrationType, CODE_NAME_M, CODE_DESCRIPTION_M);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected override bool EqualsCore(RegistrationTypeValueObject other)
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


