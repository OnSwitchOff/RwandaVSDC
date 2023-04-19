using RwandaVSDC.Models.Common;
using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.ValueObjects
{
    public class ImportItemStatusValueObject : ValueObject<ImportItemStatusValueObject>
    {
        private static readonly string CodeClassification = "26";
        private static readonly string CodeClassificationName = "Import item Status";

        private const string CODE_NAME_1 = "Unsent";
        private const string CODE_NAME_2 = "Waiting";
        private const string CODE_NAME_3 = "Approved";
        private const string CODE_NAME_4 = "Cancelled";

        private const string CODE_DESCRIPTION_1 = "";
        private const string CODE_DESCRIPTION_2 = "";
        private const string CODE_DESCRIPTION_3 = "";
        private const string CODE_DESCRIPTION_4 = "";

        private readonly string _code;
        private readonly int _sortOrder;
        private readonly string _codeName;
        private readonly string _codeDescription;

        public static readonly ImportItemStatusValueObject Unsent = Create(ImportItemStatus.Unsent);
        public static readonly ImportItemStatusValueObject Waiting = Create(ImportItemStatus.Waiting);
        public static readonly ImportItemStatusValueObject Approved = Create(ImportItemStatus.Approved);
        public static readonly ImportItemStatusValueObject Cancelled = Create(ImportItemStatus.Cancelled);

        private ImportItemStatusValueObject(string code, int sortOrder, string codeName, string codeDescription)
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

        public static ImportItemStatusValueObject Create(ImportItemStatus importItemStatus)
        {
            switch (importItemStatus)
            {
                case ImportItemStatus.Unsent:
                    return new ImportItemStatusValueObject("1", (int)importItemStatus, CODE_NAME_1, CODE_DESCRIPTION_1);
                case ImportItemStatus.Waiting:
                    return new ImportItemStatusValueObject("2", (int)importItemStatus, CODE_NAME_2, CODE_DESCRIPTION_2);
                case ImportItemStatus.Approved:
                    return new ImportItemStatusValueObject("3", (int)importItemStatus, CODE_NAME_3, CODE_DESCRIPTION_3);
                case ImportItemStatus.Cancelled:
                    return new ImportItemStatusValueObject("4", (int)importItemStatus, CODE_NAME_4, CODE_DESCRIPTION_4);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected override bool EqualsCore(ImportItemStatusValueObject other)
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
