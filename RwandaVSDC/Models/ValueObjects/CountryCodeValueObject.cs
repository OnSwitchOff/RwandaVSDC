using RwandaVSDC.Models.Common;
using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.ValueObjects
{
    public class CountryCodeValueObject: ValueObject<CountryCodeValueObject>
    {
        private static readonly string CodeClassification = "05";
        private static readonly string CodeClassificationName = "Nation";

        private readonly string _code;
        private readonly int _sortOrder;
        private readonly string _codeName;
        private readonly string _codeDescription;

        private CountryCodeValueObject(string code, int sortOrder, string codeName, string codeDescription)
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

        public static CountryCodeValueObject Create(CountryCode countryCode)
        {
            switch (countryCode)
            {
                case CountryCode.AC:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ASCENSION ISLAND", "ASCENSION ISLAND");
                case CountryCode.AD:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ANDORRA", "ANDORRA");
                case CountryCode.AE:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "UNITED ARAB EMIRATES", "UNITED ARAB EMIRATES");
                case CountryCode.AG:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ANTIGUA AND BARBUDA", "ANTIGUA AND BARBUDA");
                case CountryCode.AI:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ANGUILLA", "ANGUILLA");
                case CountryCode.AL:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ALBANIA", "ALBANIA");
                case CountryCode.AM:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ARMENIA", "ARMENIA");
                case CountryCode.AN:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "NETHERLANDS ANTILLES", "NETHERLANDS ANTILLES");
                case CountryCode.AO:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ANGOLA", "ANGOLA");
                case CountryCode.AQ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ANTARCTICA", "ANTARCTICA");
                case CountryCode.AR:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ARGENTINA", "ARGENTINA");
                case CountryCode.AS:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "AMERICAN SAMOA", "AMERICAN SAMOA");
                case CountryCode.AT:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "AUSTRIA", "AUSTRIA");
                case CountryCode.AU:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "AUSTRALIA", "AUSTRALIA");
                case CountryCode.AW:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ARUBA", "ARUBA");
                case CountryCode.AX:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ALAND ISLANDS", "ALAND ISLANDS");
                case CountryCode.AZ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "AZERBAIJAN", "AZERBAIJAN");
                case CountryCode.BA:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BOSNIA AND HERZEGOVINA", "BOSNIA AND HERZEGOVINA");
                case CountryCode.BB:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BARBADOS", "BARBADOS");
                case CountryCode.BD:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BANGLADESH", "BANGLADESH");
                case CountryCode.BE:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BELGIUM", "BELGIUM");
                case CountryCode.BF:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BURKINA FASO", "BURKINA FASO");
                case CountryCode.BG:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BULGARIA", "BULGARIA");
                case CountryCode.BH:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BAHRAIN", "BAHRAIN");
                case CountryCode.BI:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BURUNDI", "BURUNDI");
                case CountryCode.BJ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BENIN", "BENIN");
                case CountryCode.BM:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BERMUDA", "BERMUDA");
                case CountryCode.BN:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BRUNEI DARUSSALAM", "BRUNEI DARUSSALAM");
                case CountryCode.BO:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BOLIVIA", "BOLIVIA");
                case CountryCode.BR:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BRAZIL", "BRAZIL");
                case CountryCode.BS:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BAHAMAS", "BAHAMAS");
                case CountryCode.BT:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BHUTAN", "BHUTAN");
                case CountryCode.BV:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BOUVET ISLAND", "BOUVET ISLAND");
                case CountryCode.BW:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BOTSWANA", "BOTSWANA");
                case CountryCode.BY:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BELARUS", "BELARUS");
                case CountryCode.BZ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BELIZE", "BELIZE");
                case CountryCode.CA:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "CANADA", "CANADA");
                case CountryCode.CC:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "COCOS (KEELING) ISLANDS", "COCOS (KEELING) ISLANDS");
                case CountryCode.CD:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "CONGO, DEMOCRATIC REPUBLIC", "CONGO, DEMOCRATIC REPUBLIC");
                case CountryCode.CF:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "CENTRAL AFRICAN REPUBLIC", "CENTRAL AFRICAN REPUBLIC");
                case CountryCode.CG:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "CONGO", "CONGO");
                case CountryCode.CH:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SWITZERLAND", "SWITZERLAND");
                case CountryCode.CI:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "COTE D'IVOIRE (IVORY COAST)", "COTE D'IVOIRE (IVORY COAST)");
                case CountryCode.CK:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "COOK ISLANDS", "COOK ISLANDS");
                case CountryCode.CL:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "CHILE", "CHILE");
                case CountryCode.CM:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "CAMEROON", "CAMEROON");
                case CountryCode.CN:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "CHINA", "CHINA");
                case CountryCode.CO:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "COLOMBIA", "COLOMBIA");
                case CountryCode.CR:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "COSTA RICA", "COSTA RICA");
                case CountryCode.CS:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "CZECHOSLOVAKIA (FORMER)", "CZECHOSLOVAKIA (FORMER)");
                case CountryCode.CU:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "CUBA", "CUBA");
                case CountryCode.CV:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "CAPE VERDE", "CAPE VERDE");
                case CountryCode.CX:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "CHRISTMAS ISLAND", "CHRISTMAS ISLAND");
                case CountryCode.CY:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "CYPRUS", "CYPRUS");
                case CountryCode.CZ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "CZECH REPUBLIC", "CZECH REPUBLIC");
                case CountryCode.DE:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "GERMANY", "GERMANY");
                case CountryCode.DJ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "DJIBOUTI", "DJIBOUTI");
                case CountryCode.DK:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "DENMARK", "DENMARK");
                case CountryCode.DM:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "DOMINICA", "DOMINICA");
                case CountryCode.DO:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "DOMINICAN REPUBLIC", "DOMINICAN REPUBLIC");
                case CountryCode.DZ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ALGERIA", "ALGERIA");
                case CountryCode.EC:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ECUADOR", "ECUADOR");
                case CountryCode.EE:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ESTONIA", "ESTONIA");
                case CountryCode.EG:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "EGYPT", "EGYPT");
                case CountryCode.EH:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "WESTERN SAHARA", "WESTERN SAHARA");
                case CountryCode.ER:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ERITREA", "ERITREA");
                case CountryCode.ES:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SPAIN", "SPAIN");
                case CountryCode.ET:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ETHIOPIA", "ETHIOPIA");
                case CountryCode.EU:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "EUROPEAN UNION", "EUROPEAN UNION");
                case CountryCode.FI:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "FINLAND", "FINLAND");
                case CountryCode.FJ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "FIJI", "FIJI");
                case CountryCode.FK:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "FALKLAND ISLANDS (MALVINAS)", "FALKLAND ISLANDS (MALVINAS)");
                case CountryCode.FM:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MICRONESIA", "MICRONESIA");
                case CountryCode.FO:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "FAROE ISLANDS", "FAROE ISLANDS");
                case CountryCode.FR:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "FRANCE", "FRANCE");
                case CountryCode.FX:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "FRANCE, METROPOLITAN", "FRANCE, METROPOLITAN");
                case CountryCode.GA:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "GABON", "GABON");
                case CountryCode.GB:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "GREAT BRITAIN (UK)", "GREAT BRITAIN (UK)");
                case CountryCode.GD:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "GRENADA", "GRENADA");
                case CountryCode.GE:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "GEORGIA", "GEORGIA");
                case CountryCode.GF:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "FRENCH GUIANA", "FRENCH GUIANA");
                case CountryCode.GG:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "GUERNSEY", "GUERNSEY");
                case CountryCode.GH:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "GHANA", "GHANA");
                case CountryCode.GI:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "GIBRALTAR", "GIBRALTAR");
                case CountryCode.GL:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "GREENLAND", "GREENLAND");
                case CountryCode.GM:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "GAMBIA", "GAMBIA");
                case CountryCode.GN:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "GUINEA", "GUINEA");
                case CountryCode.GP:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "GUADELOUPE", "GUADELOUPE");
                case CountryCode.GQ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "EQUATORIAL GUINEA", "EQUATORIAL GUINEA");
                case CountryCode.GR:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "GREECE", "GREECE");
                case CountryCode.GS:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "S. GEORGIA AND S. SANDWICH ISLS.", "S. GEORGIA AND S. SANDWICH ISLS.");
                case CountryCode.GT:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "GUATEMALA", "GUATEMALA");
                case CountryCode.GU:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "GUAM", "GUAM");
                case CountryCode.GW:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "GUINEA BISSAU", "GUINEA BISSAU");
                case CountryCode.GY:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "GUYANA", "GUYANA");
                case CountryCode.HK:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "HONG KONG", "HONG KONG");
                case CountryCode.HM:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "HEARD AND MCDONALD ISLANDS", "HEARD AND MCDONALD ISLANDS");
                case CountryCode.HN:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "HONDURAS", "HONDURAS");
                case CountryCode.HR:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "CROATIA (HRVATSKA)", "CROATIA (HRVATSKA)");
                case CountryCode.HT:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "HAITI", "HAITI");
                case CountryCode.HU:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "HUNGARY", "HUNGARY");
                case CountryCode.ID:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "INDONESIA", "INDONESIA");
                case CountryCode.IE:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "IRELAND", "IRELAND");
                case CountryCode.IL:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ISRAEL", "ISRAEL");
                case CountryCode.IM:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ISLE OF MAN", "ISLE OF MAN");
                case CountryCode.IN:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "INDIA", "INDIA");
                case CountryCode.IO:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BRITISH INDIAN OCEAN TERRITORY", "BRITISH INDIAN OCEAN TERRITORY");
                case CountryCode.IQ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "IRAQ", "IRAQ");
                case CountryCode.IR:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "IRAN", "IRAN");
                case CountryCode.IS:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ICELAND", "ICELAND");
                case CountryCode.IT:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ITALY", "ITALY");
                case CountryCode.JE:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "JERSEY", "JERSEY");
                case CountryCode.JM:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "JAMAICA", "JAMAICA");
                case CountryCode.JO:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "JORDAN", "JORDAN");
                case CountryCode.JP:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "JAPAN", "JAPAN");
                case CountryCode.KE:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "KENYA", "KENYA");
                case CountryCode.KG:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "KYRGYZSTAN", "KYRGYZSTAN");
                case CountryCode.KH:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "CAMBODIA", "CAMBODIA");
                case CountryCode.KI:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "KIRIBATI", "KIRIBATI");
                case CountryCode.KM:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "COMOROS", "COMOROS");
                case CountryCode.KN:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SAINT KITTS AND NEVIS", "SAINT KITTS AND NEVIS");
                case CountryCode.KP:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "NORTH KOREA", "NORTH KOREA");
                case CountryCode.KR:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SOUTH KOREA", "SOUTH KOREA");
                case CountryCode.KW:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "KUWAIT", "KUWAIT");
                case CountryCode.KY:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "CAYMAN ISLANDS", "CAYMAN ISLANDS");
                case CountryCode.KZ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "KAZAKHSTAN", "KAZAKHSTAN");
                case CountryCode.LA:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "LAOS", "LAOS");
                case CountryCode.LB:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "LEBANON", "LEBANON");
                case CountryCode.LC:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SAINT LUCIA", "SAINT LUCIA");
                case CountryCode.LI:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "LIECHTENSTEIN", "LIECHTENSTEIN");
                case CountryCode.LK:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SRI LANKA", "SRI LANKA");
                case CountryCode.LR:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "LIBERIA", "LIBERIA");
                case CountryCode.LS:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "LESOTHO", "LESOTHO");
                case CountryCode.LT:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "LITHUANIA", "LITHUANIA");
                case CountryCode.LU:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "LUXEMBOURG", "LUXEMBOURG");
                case CountryCode.LV:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "LATVIA", "LATVIA");
                case CountryCode.LY:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "LIBYA", "LIBYA");
                case CountryCode.MA:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MOROCCO", "MOROCCO");
                case CountryCode.MC:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MONACO", "MONACO");
                case CountryCode.MD:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MOLDOVA", "MOLDOVA");
                case CountryCode.ME:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MONTENEGRO", "MONTENEGRO");
                case CountryCode.MG:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MADAGASCAR", "MADAGASCAR");
                case CountryCode.MH:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MARSHALL ISLANDS", "MARSHALL ISLANDS");
                case CountryCode.MK:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "F.Y.R.O.M. (MACEDONIA)", "F.Y.R.O.M. (MACEDONIA)");
                case CountryCode.ML:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MALI", "MALI");
                case CountryCode.MM:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MYANMAR", "MYANMAR");
                case CountryCode.MN:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MONGOLIA", "MONGOLIA");
                case CountryCode.MO:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MACAU", "MACAU");
                case CountryCode.MP:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "NORTHERN MARIANA ISLANDS", "NORTHERN MARIANA ISLANDS");
                case CountryCode.MQ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MARTINIQUE", "MARTINIQUE");
                case CountryCode.MR:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MAURITANIA", "MAURITANIA");
                case CountryCode.MS:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MONTSERRAT", "MONTSERRAT");
                case CountryCode.MT:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MALTA", "MALTA");
                case CountryCode.MU:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MAURITIUS", "MAURITIUS");
                case CountryCode.MV:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MALDIVES", "MALDIVES");
                case CountryCode.MW:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MALAWI", "MALAWI");
                case CountryCode.MX:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MEXICO", "MEXICO");
                case CountryCode.MY:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MALAYSIA", "MALAYSIA");
                case CountryCode.MZ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MOZAMBIQUE", "MOZAMBIQUE");
                case CountryCode.NA:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "NAMIBIA", "NAMIBIA");
                case CountryCode.NC:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "NEW CALEDONIA", "NEW CALEDONIA");
                case CountryCode.NE:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "NIGER", "NIGER");
                case CountryCode.NF:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "NORFOLK ISLAND", "NORFOLK ISLAND");
                case CountryCode.NG:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "NIGERIA", "NIGERIA");
                case CountryCode.NI:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "NICARAGUA", "NICARAGUA");
                case CountryCode.NL:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "NETHERLANDS", "NETHERLANDS");
                case CountryCode.NO:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "NORWAY", "NORWAY");
                case CountryCode.NP:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "NEPAL", "NEPAL");
                case CountryCode.NR:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "NAURU", "NAURU");
                case CountryCode.NT:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "NEUTRAL ZONE", "NEUTRAL ZONE");
                case CountryCode.NU:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "NIUE", "NIUE");
                case CountryCode.NZ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "NEW ZEALAND (AOTEAROA)", "NEW ZEALAND (AOTEAROA)");
                case CountryCode.OM:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "OMAN", "OMAN");
                case CountryCode.PA:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "PANAMA", "PANAMA");
                case CountryCode.PE:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "PERU", "PERU");
                case CountryCode.PF:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "FRENCH POLYNESIA", "FRENCH POLYNESIA");
                case CountryCode.PG:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "PAPUA NEW GUINEA", "PAPUA NEW GUINEA");
                case CountryCode.PH:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "PHILIPPINES", "PHILIPPINES");
                case CountryCode.PK:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "PAKISTAN", "PAKISTAN");
                case CountryCode.PL:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "POLAND", "POLAND");
                case CountryCode.PM:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ST. PIERRE AND MIQUELON", "ST. PIERRE AND MIQUELON");
                case CountryCode.PN:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "PITCAIRN", "PITCAIRN");
                case CountryCode.PR:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "PUERTO RICO", "PUERTO RICO");
                case CountryCode.PS:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "PALESTINIAN TERRITORY, OCCUPIED", "PALESTINIAN TERRITORY, OCCUPIED");
                case CountryCode.PT:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "PORTUGAL", "PORTUGAL");
                case CountryCode.PW:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "PALAU", "PALAU");
                case CountryCode.PY:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "PARAGUAY", "PARAGUAY");
                case CountryCode.QA:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "QATAR", "QATAR");
                case CountryCode.RE:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "REUNION", "REUNION");
                case CountryCode.RO:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ROMANIA", "ROMANIA");
                case CountryCode.RS:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SERBIA", "SERBIA");
                case CountryCode.RU:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "RUSSIAN FEDERATION", "RUSSIAN FEDERATION");
                case CountryCode.RW:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "RWANDA", "RWANDA");
                case CountryCode.SA:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SAUDI ARABIA", "SAUDI ARABIA");
                case CountryCode.SB:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SOLOMON ISLANDS", "SOLOMON ISLANDS");
                case CountryCode.SC:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SEYCHELLES", "SEYCHELLES");
                case CountryCode.SD:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SUDAN", "SUDAN");
                case CountryCode.SE:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SWEDEN", "SWEDEN");
                case CountryCode.SG:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SINGAPORE", "SINGAPORE");
                case CountryCode.SH:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ST. HELENA", "ST. HELENA");
                case CountryCode.SI:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SLOVENIA", "SLOVENIA");
                case CountryCode.SJ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SVALBARD & JAN MAYEN ISLANDS", "SVALBARD & JAN MAYEN ISLANDS");
                case CountryCode.SK:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SLOVAK REPUBLIC", "SLOVAK REPUBLIC");
                case CountryCode.SL:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SIERRA LEONE", "SIERRA LEONE");
                case CountryCode.SM:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SAN MARINO", "SAN MARINO");
                case CountryCode.SN:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SENEGAL", "SENEGAL");
                case CountryCode.SO:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SOMALIA", "SOMALIA");
                case CountryCode.SR:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SURINAME", "SURINAME");
                case CountryCode.ST:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SAO TOME AND PRINCIPE", "SAO TOME AND PRINCIPE");
                case CountryCode.SU:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "USSR (FORMER)", "USSR (FORMER)");
                case CountryCode.SV:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "EL SALVADOR", "EL SALVADOR");
                case CountryCode.SY:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SYRIA", "SYRIA");
                case CountryCode.SZ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SWAZILAND", "SWAZILAND");
                case CountryCode.TC:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "TURKS AND CAICOS ISLANDS ", "TURKS AND CAICOS ISLANDS ");
                case CountryCode.TD:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "CHAD", "CHAD");
                case CountryCode.TF:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "FRENCH SOUTHERN TERRITORIES", "FRENCH SOUTHERN TERRITORIES");
                case CountryCode.TG:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "TOGO", "TOGO");
                case CountryCode.TH:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "THAILAND", "THAILAND");
                case CountryCode.TJ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "TAJIKISTAN", "TAJIKISTAN");
                case CountryCode.TK:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "TOKELAU", "TOKELAU");
                case CountryCode.TM:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "TURKMENISTAN", "TURKMENISTAN");
                case CountryCode.TN:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "TUNISIA", "TUNISIA");
                case CountryCode.TO:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "TONGA", "TONGA");
                case CountryCode.TP:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "EAST TIMOR", "EAST TIMOR");
                case CountryCode.TR:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "TURKEY", "TURKEY");
                case CountryCode.TT:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "TRINIDAD AND TOBAGO", "TRINIDAD AND TOBAGO");
                case CountryCode.TV:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "TUVALU", "TUVALU");
                case CountryCode.TW:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "TAIWAN", "TAIWAN");
                case CountryCode.TZ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "TANZANIA", "TANZANIA");
                case CountryCode.UA:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "UKRAINE", "UKRAINE");
                case CountryCode.UG:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "UGANDA", "UGANDA");
                case CountryCode.UK:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "UNITED KINGDOM", "UNITED KINGDOM");
                case CountryCode.UM:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "US MINOR OUTLYING ISLANDS", "US MINOR OUTLYING ISLANDS");
                case CountryCode.US:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "UNITED STATES", "UNITED STATES");
                case CountryCode.UY:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "URUGUAY", "URUGUAY");
                case CountryCode.UZ:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "UZBEKISTAN", "UZBEKISTAN");
                case CountryCode.VA:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "VATICAN CITY STATE (HOLY SEE)", "VATICAN CITY STATE (HOLY SEE)");
                case CountryCode.VC:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SAINT VINCENT & THE GRENADINES", "SAINT VINCENT & THE GRENADINES");
                case CountryCode.VE:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "VENEZUELA", "VENEZUELA");
                case CountryCode.VG:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "BRITISH VIRGIN ISLANDS", "BRITISH VIRGIN ISLANDS");
                case CountryCode.VI:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "VIRGIN ISLANDS (U.S.)", "VIRGIN ISLANDS (U.S.)");
                case CountryCode.VN:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "VIET NAM", "VIET NAM");
                case CountryCode.VU:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "VANUATU", "VANUATU");
                case CountryCode.WF:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "WALLIS AND FUTUNA ISLANDS", "WALLIS AND FUTUNA ISLANDS");
                case CountryCode.WS:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SAMOA", "SAMOA");
                case CountryCode.YE:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "YEMEN", "YEMEN");
                case CountryCode.YT:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "MAYOTTE", "MAYOTTE");
                case CountryCode.YU:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SERBIA AND MONTENEGRO (FORMER)", "SERBIA AND MONTENEGRO (FORMER)");
                case CountryCode.ZA:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "SOUTH AFRICA", "SOUTH AFRICA");
                case CountryCode.ZM:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ZAMBIA", "ZAMBIA");
                case CountryCode.ZR:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "(ZAIRE) SEE CD CONGO, DEMOCRATIC REPUBLIC", "(ZAIRE) SEE CD CONGO, DEMOCRATIC REPUBLIC");
                case CountryCode.ZW:
                    return new CountryCodeValueObject(countryCode.ToString(), (int)countryCode, "ZIMBABWE", "ZIMBABWE");
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected override bool EqualsCore(CountryCodeValueObject other)
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
