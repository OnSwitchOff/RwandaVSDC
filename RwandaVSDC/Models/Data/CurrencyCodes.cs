﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Data
{
    public static class CurrencyCodes
    {
        public static string CodeClassification = "33";
        public static string CodeClassificationName = "Currency";
        public static IReadOnlyDictionary<string, CodeInfo> Codes = InitDictionary();

        private static Dictionary<string, CodeInfo> InitDictionary()
        {
            return new Dictionary<string, CodeInfo>()
            {
                { "AED", new CodeInfo("AED", 1, "United Arab Emirates dirham","United Arab Emirates dirham") },
                { "AFN", new CodeInfo("AFN", 2, "Afghan afghani", "Afghan afghani") },
                { "ALL", new CodeInfo("ALL", 3, "Albanian lek", "Albanian lek") },
                { "AMD", new CodeInfo("AMD", 4, "Armenian dram", "Armenian dram") },
                { "ANG", new CodeInfo("ANG", 5, "Netherlands Antillean guilder", "Netherlands Antillean guilder") },
                { "AOA", new CodeInfo("AOA", 6, "Angolan kwanza","Angolan kwanza") },
                { "ARS", new CodeInfo("ARS", 7, "Argentine peso", "Argentine peso") },
                { "AUD", new CodeInfo("AUD", 8, "Australian dollar", "Australian dollar") },
                { "AWG", new CodeInfo("AWG", 9, "Aruban florin", "Aruban florin") },
                { "AZN", new CodeInfo("AZN", 10, "Azerbaijani manat", "Azerbaijani manat") },
                { "BAM", new CodeInfo("BAM", 11, "Bosnia and Herzegovina convertible mark","Bosnia and Herzegovina convertible mark") },
                { "BBD", new CodeInfo("BBD", 12, "Barbados dollar", "Barbados dollar") },
                { "BDT", new CodeInfo("BDT", 13, "Bangladeshi taka", "Bangladeshi taka") },
                { "BGN", new CodeInfo("BGN", 14, "Bulgarian lev", "Bulgarian lev") },
                { "BHD", new CodeInfo("BHD", 15, "Bahraini dinar", "Bahraini dinar") },
                { "BIF", new CodeInfo("BIF", 16, "Burundian franc", "Burundian franc") },
                { "BMD", new CodeInfo("BMD", 17, "Bermudian dollar","Bermudian dollar") },
                { "BND", new CodeInfo("BND", 18, "Brunei dollar", "Brunei dollar") },
                { "BOB", new CodeInfo("BOB", 19, "Boliviano", "Boliviano") },
                { "BOV", new CodeInfo("BOV", 20, "Bolivian Mvdol (funds code)", "Bolivian Mvdol (funds code)") },
                { "BRL", new CodeInfo("BRL", 21, "Brazilian real", "Brazilian real") },
                { "BSD", new CodeInfo("BSD", 22, "Bahamian dollar","Bahamian dollar") },
                { "BTN", new CodeInfo("BTN", 23, "Bhutanese ngultrum", "Bhutanese ngultrum") },
                { "BWP", new CodeInfo("BWP", 24, "Botswana pula", "Botswana pula") },
                { "BYN", new CodeInfo("BYN", 25, "New Belarusian ruble", "New Belarusian ruble") },
                { "BYR", new CodeInfo("BYR", 26, "Belarusian ruble", "Belarusian ruble") },
                { "BZD", new CodeInfo("BZD", 27, "Belize dollar","Belize dollar") },
                { "CAD", new CodeInfo("CAD", 28, "Canadian dollar", "Canadian dollar") },
                { "CDF", new CodeInfo("CDF", 29, "Congolese franc", "Congolese franc") },
                { "CHE", new CodeInfo("CHE", 30, "WIR Euro (complementary currency)", "WIR Euro (complementary currency)") },
                { "CHF", new CodeInfo("CHF", 31, "Swiss franc", "Swiss franc") },
                { "CHW", new CodeInfo("CHW", 32, "WIR Franc (complementary currency)","WIR Franc (complementary currency)") },
                { "CLF", new CodeInfo("CLF", 33, "Unidad de Fomento (funds code)", "Unidad de Fomento (funds code)") },
                { "CLP", new CodeInfo("CLP", 34, "Chilean peso", "Chilean peso") },
                { "CNY", new CodeInfo("CNY", 35, "Chinese yuan", "Chinese yuan") },
                { "COP", new CodeInfo("COP", 36, "Colombian peso", "Colombian peso") },
                { "COU", new CodeInfo("COU", 37, "Unidad de Valor Real (UVR) (funds code)","Unidad de Valor Real (UVR) (funds code)") },
                { "CRC", new CodeInfo("CRC", 38, "Costa Rican colon", "Costa Rican colon") },
                { "CUC", new CodeInfo("CUC", 39, "Cuban convertible peso", "Cuban convertible peso") },
                { "CUP", new CodeInfo("CUP", 40, "Cuban peso", "Cuban peso") },
                { "CVE", new CodeInfo("CVE", 41, "Cape Verde escudo", "Cape Verde escudo") },
                { "CZK", new CodeInfo("CZK", 42, "Czech koruna","Czech koruna") },
                { "DJF", new CodeInfo("DJF", 43, "Djiboutian franc", "Djiboutian franc") },
                { "DKK", new CodeInfo("DKK", 44, "Danish krone", "Danish krone") },
                { "DOP", new CodeInfo("DOP", 45, "Dominican peso", "Dominican peso") },
                { "DZD", new CodeInfo("DZD", 46, "Algerian dinar", "Algerian dinar") },
                { "EGP", new CodeInfo("EGP", 47, "Egyptian pound", "Egyptian pound") },
                { "ERN", new CodeInfo("ERN", 48, "Eritrean nakfa", "Eritrean nakfa") },
                { "ETB", new CodeInfo("ETB", 49, "Ethiopian birr", "Ethiopian birr") },
                { "EUR", new CodeInfo("EUR", 50, "Euro", "Euro") },
                { "FJD", new CodeInfo("FJD", 51, "Fiji dollar", "Fiji dollar") },
                { "FKP", new CodeInfo("FKP", 52, "Falkland Islands pound", "Falkland Islands pound") },
                { "GBP", new CodeInfo("GBP", 53, "Pound sterling", "Pound sterling") },
                { "GEL", new CodeInfo("GEL", 54, "Georgian lari", "Georgian lari") },
                { "GHS", new CodeInfo("GHS", 55, "Ghanaian cedi", "Ghanaian cedi") },
                { "GIP", new CodeInfo("GIP", 56, "Gibraltar pound", "Gibraltar pound") },
                { "GMD", new CodeInfo("GMD", 57, "Gambian dalasi", "Gambian dalasi") },
                { "GNF", new CodeInfo("GNF", 58, "Guinean franc", "Guinean franc") },
                { "GTQ", new CodeInfo("GTQ", 59, "Guatemalan quetzal", "Guatemalan quetzal") },
                { "GYD", new CodeInfo("GYD", 60, "Guyanese dollar", "Guyanese dollar") },
                { "HKD", new CodeInfo("HKD", 61, "Hong Kong dollar", "Hong Kong dollar") },
                { "HNL", new CodeInfo("HNL", 62, "Honduran lempira", "Honduran lempira") },
                { "HRK", new CodeInfo("HRK", 63, "Croatian kuna", "Croatian kuna") },
                { "HTG", new CodeInfo("HTG", 64, "Haitian gourde", "Haitian gourde") },
                { "HUF", new CodeInfo("HUF", 65, "Hungarian forint", "Hungarian forint") },
                { "IDR", new CodeInfo("IDR", 66, "Indonesian rupiah", "Indonesian rupiah") },
                { "ILS", new CodeInfo("ILS", 67, "Israeli new shekel", "Israeli new shekel") },
                { "INR", new CodeInfo("INR", 68, "Indian rupee", "Indian rupee") },
                { "IQD", new CodeInfo("IQD", 69, "Iraqi dinar", "Iraqi dinar") },
                { "IRR", new CodeInfo("IRR", 70, "Iranian rial", "Iranian rial") },
                { "ISK", new CodeInfo("ISK", 71, "Icelandic króna", "Icelandic króna") },
                { "JMD", new CodeInfo("JMD", 72, "Jamaican dollar", "Jamaican dollar") },
                { "JOD", new CodeInfo("JOD", 73, "Jordanian dinar", "Jordanian dinar") },
                { "JPY", new CodeInfo("JPY", 74, "Japanese yen", "Japanese yen") },
                { "KES", new CodeInfo("KES", 75, "Kenyan shilling", "Kenyan shilling") },
                { "KGS", new CodeInfo("KGS", 76, "Kyrgyzstani som", "Kyrgyzstani som") },
                { "KHR", new CodeInfo("KHR", 77, "Cambodian riel", "Cambodian riel") },
                { "KMF", new CodeInfo("KMF", 78, "Comoro franc", "Comoro franc") },
                { "KPW", new CodeInfo("KPW", 79, "North Korean won", "North Korean won") },
                { "KRW", new CodeInfo("KRW", 80, "South Korean won", "South Korean won") },
                { "KWD", new CodeInfo("KWD", 81, "Kuwaiti dinar", "Kuwaiti dinar") },
                { "KYD", new CodeInfo("KYD", 82, "Cayman Islands dollar", "Cayman Islands dollar") },
                { "KZT", new CodeInfo("KZT", 83, "Kazakhstani tenge", "Kazakhstani tenge") },
                { "LAK", new CodeInfo("LAK", 84, "Lao kip", "Lao kip") },
                { "LBP", new CodeInfo("LBP", 85, "Lebanese pound", "Lebanese pound") },
                { "LKR", new CodeInfo("LKR", 86, "Sri Lankan rupee", "Sri Lankan rupee") },
                { "LRD", new CodeInfo("LRD", 87, "Liberian dollar", "Liberian dollar") },
                { "LSL", new CodeInfo("LSL", 88, "Lesotho loti", "Lesotho loti") },
                { "LYD", new CodeInfo("LYD", 89, "Libyan dinar", "Libyan dinar") },
                { "MAD", new CodeInfo("MAD", 90, "Moroccan dirham", "Moroccan dirham") },
                { "MDL", new CodeInfo("MDL", 91, "Moldovan leu", "Moldovan leu") },
                { "MGA", new CodeInfo("MGA", 92, "Malagasy ariary", "Malagasy ariary ") },
                { "MKD", new CodeInfo("MKD", 93, "Macedonian denar", "Macedonian denar") },
                { "MMK", new CodeInfo("MMK", 94, "Myanmar kyat", "Myanmar kyat") },
                { "MNT", new CodeInfo("MNT", 95, "Mongolian tögrög", "Mongolian tögrög") },
                { "MOP", new CodeInfo("MOP", 96, "Macanese pataca", "Macanese pataca") },
                { "MRO", new CodeInfo("MRO", 97, "Mauritanian ouguiya", "Mauritanian ouguiya") },
                { "MUR", new CodeInfo("MUR", 98, "Mauritian rupee", "Mauritian rupee") },
                { "MVR", new CodeInfo("MVR", 99, "Maldivian rufiyaa", "Maldivian rufiyaa") },
                { "MWK", new CodeInfo("MWK", 100, "Malawian kwacha", "Malawian kwacha") },
                { "MXN", new CodeInfo("MXN", 101, "Mexican peso", "Mexican peso") },
                { "MXV", new CodeInfo("MXV", 102, "Mexican Unidad de Inversion (UDI) (funds code)", "Mexican Unidad de Inversion (UDI) (funds code)") },
                { "MYR", new CodeInfo("MYR", 103, "Malaysian ringgit", "Malaysian ringgit") },
                { "MZN", new CodeInfo("MZN", 104, "Mozambican metical", "Mozambican metical") },
                { "NAD", new CodeInfo("NAD", 105, "Namibian dollar", "Namibian dollar") },
                { "NGN", new CodeInfo("NGN", 106, "Nigerian naira", "Nigerian naira") },
                { "NIO", new CodeInfo("NIO", 107, "Nicaraguan córdoba", "Nicaraguan córdoba") },
                { "NOK", new CodeInfo("NOK", 108, "Norwegian krone", "Norwegian krone") },
                { "NPR", new CodeInfo("NPR", 109, "Nepalese rupee", "Nepalese rupee") },
                { "NZD", new CodeInfo("NZD", 110, "New Zealand dollar", "New Zealand dollar") },
                { "OMR", new CodeInfo("OMR", 111, "Omani rial", "Omani rial") },
                { "PAB", new CodeInfo("PAB", 112, "Panamanian balboa", "Panamanian balboa") },
                { "PEN", new CodeInfo("PEN", 113, "Peruvian Sol", "Peruvian Sol") },
                { "PGK", new CodeInfo("PGK", 114, "Papua New Guinean kina", "Papua New Guinean kina") },
                { "PHP", new CodeInfo("PHP", 115, "Philippine peso", "Philippine peso") },
                { "PKR", new CodeInfo("PKR", 116, "Pakistani rupee", "Pakistani rupee") },
                { "PLN", new CodeInfo("PLN", 117, "Polish złoty", "Polish złoty") },
                { "PYG", new CodeInfo("PYG", 118, "Paraguayan guaraní", "Paraguayan guaraní") },
                { "QAR", new CodeInfo("QAR", 119, "Qatari riyal", "Qatari riyal") },
                { "RON", new CodeInfo("RON", 120, "Romanian leu", "Romanian leu") },
                { "RSD", new CodeInfo("RSD", 121, "Serbian dinar", "Serbian dinar") },
                { "RUB", new CodeInfo("RUB", 122, "Russian ruble", "Russian ruble") },
                { "RWF", new CodeInfo("RWF", 123, "Rwandan franc", "Rwandan franc") },
                { "SAR", new CodeInfo("SAR", 124, "Saudi riyal", "Saudi riyal") },
                { "SBD", new CodeInfo("SBD", 125, "Solomon Islands dollar", "Solomon Islands dollar") },
                { "SCR", new CodeInfo("SCR", 126, "Seychelles rupee", "Seychelles rupee") },
                { "SDG", new CodeInfo("SDG", 127, "Sudanese pound", "Sudanese pound") },
                { "SEK", new CodeInfo("SEK", 128, "Swedish krona/kronor", "Swedish krona/kronor") },
                { "SGD", new CodeInfo("SGD", 129, "Singapore dollar", "Singapore dollar") },
                { "SHP", new CodeInfo("SHP", 130, "Saint Helena pound", "Saint Helena pound") },
                { "SLL", new CodeInfo("SLL", 131, "Sierra Leonean leone", "Sierra Leonean leone") },
                { "SOS", new CodeInfo("SOS", 132, "Somali shilling", "Somali shilling") },
                { "SRD", new CodeInfo("SRD", 133, "Surinamese dollar", "Surinamese dollar") },
                { "SSP", new CodeInfo("SSP", 134, "South Sudanese pound", "South Sudanese pound") },
                { "STD", new CodeInfo("STD", 135, "São Tomé and Príncipe dobra", "São Tomé and Príncipe dobra") },
                { "SVC", new CodeInfo("SVC", 136, "Salvadoran colón", "Salvadoran colón") },
                { "SYP", new CodeInfo("SYP", 137, "Syrian pound", "Syrian pound") },
                { "SZL", new CodeInfo("SZL", 138, "Swazi lilangeni", "Swazi lilangeni") },
                { "THB", new CodeInfo("THB", 139, "Thai baht", "Thai baht") },
                { "TJS", new CodeInfo("TJS", 140, "Tajikistani somoni", "Tajikistani somoni") },
                { "TMT", new CodeInfo("TMT", 141, "Turkmenistani manat", "Turkmenistani manat") },
                { "TND", new CodeInfo("TND", 142, "Tunisian dinar", "Tunisian dinar") },
                { "TOP", new CodeInfo("TOP", 143, "Tongan paʻanga", "Tongan paʻanga") },
                { "TRY", new CodeInfo("TRY", 144, "Turkish lira", "Turkish lira") },
                { "TTD", new CodeInfo("TTD", 145, "Trinidad and Tobago dollar", "Trinidad and Tobago dollar") },
                { "TWD", new CodeInfo("TWD", 146, "New Taiwan dollar", "New Taiwan dollar") },
                { "TZS", new CodeInfo("TZS", 147, "Tanzanian shilling", "Tanzanian shilling") },
                { "UAH", new CodeInfo("UAH", 148, "Ukrainian hryvnia", "Ukrainian hryvnia") },
                { "UGX", new CodeInfo("UGX", 149, "Ugandan shilling ", "Ugandan shilling ") },
                { "USD", new CodeInfo("USD", 150, "United States dollar", "United States dollar") },
                { "USN", new CodeInfo("USN", 151, "United States dollar (next day) (funds code)", "United States dollar (next day) (funds code)") },
                { "UYI", new CodeInfo("UYI", 152, "Uruguay Peso en Unidades Indexadas (URUIURUI) (funds code)", "Uruguay Peso en Unidades Indexadas (URUIURUI) (funds code)") },
                { "UYU", new CodeInfo("UYU", 153, "Uruguayan peso", "Uruguayan peso") },
                { "UZS", new CodeInfo("UZS", 154, "Uzbekistan som", "Uzbekistan som") },
                { "VEF", new CodeInfo("VEF", 155, "Venezuelan bolívar", "Venezuelan bolívar") },
                { "VND", new CodeInfo("VND", 156, "Vietnamese dong", "Vietnamese dong") },
                { "VUV", new CodeInfo("VUV", 157, "Vanuatu vatu", "Vanuatu vatu") },
                { "WST", new CodeInfo("WST", 158, "Samoan tala", "Samoan tala") },
                { "XAF", new CodeInfo("XAF", 159, "CFA franc BEAC", "CFA franc BEAC") },
                { "XAG", new CodeInfo("XAG", 160, "Silver (one troy ounce)", "Silver (one troy ounce)") },
                { "XAU", new CodeInfo("XAU", 161, "Gold (one troy ounce)", "Gold (one troy ounce)") },
                { "XBA", new CodeInfo("XBA", 162, "European ComCISite Unit (EURCO) (bond market unit)", "European ComCISite Unit (EURCO) (bond market unit)") },
                { "XBB", new CodeInfo("XBB", 163, "European Monetary Unit (E.M.U.-6) (bond market unit)", "European Monetary Unit (E.M.U.-6) (bond market unit)") },
                { "XBC", new CodeInfo("XBC", 164, "European Unit of Account 9 (E.U.A.-9) (bond market unit)", "European Unit of Account 9 (E.U.A.-9) (bond market unit)") },
                { "XBD", new CodeInfo("XBD", 165, "European Unit of Account 17 (E.U.A.-17) (bond market unit)", "European Unit of Account 17 (E.U.A.-17) (bond market unit)") },
                { "XCD", new CodeInfo("XCD", 166, "East Caribbean dollar", "East Caribbean dollar") },
                { "XDR", new CodeInfo("XDR", 167, "Special drawing rights", "Special drawing rights") },
                { "XOF", new CodeInfo("XOF", 168, "CFA franc BCEAO", "CFA franc BCEAO") },
                { "XPD", new CodeInfo("XPD", 169, "Palladium (one troy ounce)", "Palladium (one troy ounce)") },
                { "XPF", new CodeInfo("XPF", 170, "CFP franc (franc Pacifique)", "CFP franc (franc Pacifique)") },
                { "XPT", new CodeInfo("XPT", 171, "Platinum (one troy ounce)", "Platinum (one troy ounce)") },
                { "XSU", new CodeInfo("XSU", 172, "SUCRE", "SUCRE") },
                { "XTS", new CodeInfo("XTS", 173, "Code reserved for testing purCISes", "Code reserved for testing purCISes") },
                { "XUA", new CodeInfo("XUA", 174, "ADB Unit of Account", "ADB Unit of Account") },
                { "XXX", new CodeInfo("XXX", 175, "No currency", "No currency") },
                { "YER", new CodeInfo("YER", 176, "Yemeni rial", "Yemeni rial") },
                { "ZAR", new CodeInfo("ZAR", 177, "South African rand", "South African rand") },
                { "ZMW", new CodeInfo("ZMW", 178, "Zambian kwacha", "Zambian kwacha") },
                { "ZWL", new CodeInfo("ZWL", 179, "Zimbabwean dollar A/10", "Zimbabwean dollar A/10") }
            };
        }
    }
}
