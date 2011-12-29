using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace Clime.Model
{
    enum ContinentsEnum {
        Africa,
        Antarctica,
        Asia,
        Australia,
        Europe,
        NorthAmerica,
        SouthAmerica,
        Special,
        DontKnow,
        Trash
    }

    class GeographyRepository : DependencyObject
    {
        public List<string> Continents { get; set; }
        public List<Country> Countries { get; set; }
        public List<City> Cities { get; set; }

        public void CreateAll()
        {
            // todo
            CreateAllDesign();
        }

        public void CreateAllDesign()
        {
            Continents = new List<string>();
            Countries = new List<Country>();
            Cities = new List<City>();

            AddContinents();
            AddDummiesCountries();
            AddDummiesCities(100);
        }

        public void AddContinents()
        {
            Continents.Add("Whole World");
            Continents.Add("Africa");
            Continents.Add("Antarctica");
            Continents.Add("Asia");
            Continents.Add("Australia");
            Continents.Add("Europe");
            Continents.Add("North America");
            Continents.Add("South America");
        }

        public void AddDummiesCountries()
        {
            Countries.Add(new Country(ContinentsEnum.Special, "All", "Any country ", "catalonia.png"));
            Countries.Add(new Country(ContinentsEnum.Europe, "AD", "Andorra ", "ad.png"));
            Countries.Add(new Country(ContinentsEnum.Asia, "AE", "United Arab Emirates ", "ae.png"));
            Countries.Add(new Country(ContinentsEnum.Asia, "AF", "Afghanistan ", "af.png"));
            Countries.Add(new Country(ContinentsEnum.NorthAmerica, "AG", "Antigua and Barbuda ", "ag.png"));
            Countries.Add(new Country(ContinentsEnum.NorthAmerica, "AI", "Anguilla ", "ai.png"));
            Countries.Add(new Country(ContinentsEnum.Europe, "AL", "Albania ", "al.png"));
            Countries.Add(new Country(ContinentsEnum.Europe, "AM", "Armenia ", "am.png"));
            Countries.Add(new Country(ContinentsEnum.Africa, "AO", "Angola ", "ao.png"));
            Countries.Add(new Country(ContinentsEnum.Antarctica, "AQ", "Antarctica ", "aq.png"));
            Countries.Add(new Country(ContinentsEnum.SouthAmerica, "AR", "Argentina ", "ar.png"));
            Countries.Add(new Country(ContinentsEnum.Australia, "AS", "American Samoa ", "as.png"));
            Countries.Add(new Country(ContinentsEnum.Europe, "AT", "Austria ", "at.png"));
            Countries.Add(new Country(ContinentsEnum.Australia, "AU", "Australia ", "au.png"));
            Countries.Add(new Country(ContinentsEnum.NorthAmerica, "AW", "Aruba ", "aw.png"));
            Countries.Add(new Country(ContinentsEnum.Trash, "AX", "Aland Islands ", "ax.png"));
            Countries.Add(new Country(ContinentsEnum.Europe, "AZ", "Azerbaijan ", "az.png"));
            //Countries.Add(new Country("BA", "Bosnia and Herzegovina ", "ba.png"));
            //Countries.Add(new Country("BB", "Barbados ", "bb.png"));
            //Countries.Add(new Country("BD", "Bangladesh ", "bd.png"));
            //Countries.Add(new Country("BE", "Belgium ", "be.png"));
            //Countries.Add(new Country("BF", "Burkina Faso ", "bf.png"));
            //Countries.Add(new Country("BG", "Bulgaria ", "bg.png"));
            //Countries.Add(new Country("BH", "Bahrain ", "bh.png"));
            //Countries.Add(new Country("BI", "Burundi ", "bi.png"));
            //Countries.Add(new Country("BJ", "Benin ", "bj.png"));
            //Countries.Add(new Country("BL", "Saint Barthélemy ", "bl.png"));
            //Countries.Add(new Country("BM", "Bermuda ", "bm.png"));
            //Countries.Add(new Country("BN", "Brunei Darussalam ", "bn.png"));
            //Countries.Add(new Country("BO", "Bolivia, Plurinational State of ", "bo.png"));
            //Countries.Add(new Country("BQ", "Bonaire, Sint Eustatius and Saba ", "bq.png"));
            //Countries.Add(new Country("BR", "Brazil ", "br.png"));
            //Countries.Add(new Country("BS", "Bahamas ", "bs.png"));
            //Countries.Add(new Country("BT", "Bhutan ", "bt.png"));
            //Countries.Add(new Country("BV", "Bouvet Island ", "bv.png"));
            //Countries.Add(new Country("BW", "Botswana ", "bw.png"));
            //Countries.Add(new Country("BY", "Belarus ", "by.png"));
            //Countries.Add(new Country("BZ", "Belize ", "bz.png"));
            //Countries.Add(new Country("CA", "Canada ", "ca.png"));
            //Countries.Add(new Country("CC", "Cocos (Keeling) Islands ", "cc.png"));
            //Countries.Add(new Country("CD", "Congo, the Democratic Republic of the ", "cd.png"));
            //Countries.Add(new Country("CF", "Central African Republic ", "cf.png"));
            //Countries.Add(new Country("CG", "Congo ", "cg.png"));
            //Countries.Add(new Country("CH", "Switzerland ", "ch.png"));
            //Countries.Add(new Country("CI", "Côte d'Ivoire ", "ci.png"));
            //Countries.Add(new Country("CK", "Cook Islands ", "ck.png"));
            //Countries.Add(new Country("CL", "Chile ", "cl.png"));
            //Countries.Add(new Country("CM", "Cameroon ", "cm.png"));
            //Countries.Add(new Country("CN", "China ", "cn.png"));
            //Countries.Add(new Country("CO", "Colombia ", "co.png"));
            //Countries.Add(new Country("CR", "Costa Rica ", "cr.png"));
            //Countries.Add(new Country("CU", "Cuba ", "cu.png"));
            //Countries.Add(new Country("CV", "Cape Verde ", "cv.png"));
            //Countries.Add(new Country("CW", "Curaçao ", "cw.png"));
            //Countries.Add(new Country("CX", "Christmas Island ", "cx.png"));
            //Countries.Add(new Country("CY", "Cyprus ", "cy.png"));
            //Countries.Add(new Country("CZ", "Czech Republic ", "cz.png"));
            //Countries.Add(new Country("DE", "Germany ", "de.png"));
            //Countries.Add(new Country("DJ", "Djibouti ", "dj.png"));
            //Countries.Add(new Country("DK", "Denmark ", "dk.png"));
            //Countries.Add(new Country("DM", "Dominica ", "dm.png"));
            //Countries.Add(new Country("DO", "Dominican Republic ", "do.png"));
            //Countries.Add(new Country("DZ", "Algeria ", "dz.png"));
            //Countries.Add(new Country("EC", "Ecuador ", "ec.png"));
            //Countries.Add(new Country("EE", "Estonia ", "ee.png"));
            //Countries.Add(new Country("EG", "Egypt ", "eg.png"));
            //Countries.Add(new Country("EH", "Western Sahara ", "eh.png"));
            //Countries.Add(new Country("ER", "Eritrea ", "er.png"));
            //Countries.Add(new Country("ES", "Spain ", "es.png"));
            //Countries.Add(new Country("ET", "Ethiopia ", "et.png"));
            //Countries.Add(new Country("FI", "Finland ", "fi.png"));
            //Countries.Add(new Country("FJ", "Fiji ", "fj.png"));
            //Countries.Add(new Country("FK", "Falkland Islands (Malvinas) ", "fk.png"));
            //Countries.Add(new Country("FM", "Micronesia, Federated States of ", "fm.png"));
            //Countries.Add(new Country("FO", "Faroe Islands ", "fo.png"));
            //Countries.Add(new Country("FR", "France ", "fr.png"));
            //Countries.Add(new Country("GA", "Gabon ", "ga.png"));
            //Countries.Add(new Country("GB", "United Kingdom ", "gb.png"));
            //Countries.Add(new Country("GD", "Grenada ", "gd.png"));
            //Countries.Add(new Country("GE", "Georgia ", "ge.png"));
            //Countries.Add(new Country("GF", "French Guiana ", "gf.png"));
            //Countries.Add(new Country("GG", "Guernsey ", "gg.png"));
            //Countries.Add(new Country("GH", "Ghana ", "gh.png"));
            //Countries.Add(new Country("GI", "Gibraltar ", "gi.png"));
            //Countries.Add(new Country("GL", "Greenland ", "gl.png"));
            //Countries.Add(new Country("GM", "Gambia ", "gm.png"));
            //Countries.Add(new Country("GN", "Guinea ", "gn.png"));
            //Countries.Add(new Country("GP", "Guadeloupe ", "gp.png"));
            //Countries.Add(new Country("GQ", "Equatorial Guinea ", "gq.png"));
            //Countries.Add(new Country("GR", "Greece ", "gr.png"));
            //Countries.Add(new Country("GS", "South Georgia and the South Sandwich Islands ", "gs.png"));
            //Countries.Add(new Country("GT", "Guatemala ", "gt.png"));
            //Countries.Add(new Country("GU", "Guam ", "gu.png"));
            //Countries.Add(new Country("GW", "Guinea-Bissau ", "gw.png"));
            //Countries.Add(new Country("GY", "Guyana ", "gy.png"));
            //Countries.Add(new Country("HK", "Hong Kong ", "hk.png"));
            //Countries.Add(new Country("HM", "Heard Island and McDonald Islands ", "hm.png"));
            //Countries.Add(new Country("HN", "Honduras ", "hn.png"));
            //Countries.Add(new Country("HR", "Croatia ", "hr.png"));
            //Countries.Add(new Country("HT", "Haiti ", "ht.png"));
            //Countries.Add(new Country("HU", "Hungary ", "hu.png"));
            //Countries.Add(new Country("ID", "Indonesia ", "id.png"));
            //Countries.Add(new Country("IE", "Ireland ", "ie.png"));
            //Countries.Add(new Country("IL", "Israel ", "il.png"));
            //Countries.Add(new Country("IM", "Isle of Man ", "im.png"));
            //Countries.Add(new Country("IN", "India ", "in.png"));
            //Countries.Add(new Country("IO", "British Indian Ocean Territory ", "io.png"));
            //Countries.Add(new Country("IQ", "Iraq ", "iq.png"));
            //Countries.Add(new Country("IR", "Iran, Islamic Republic of ", "ir.png"));
            //Countries.Add(new Country("IS", "Iceland ", "is.png"));
            //Countries.Add(new Country("IT", "Italy ", "it.png"));
            //Countries.Add(new Country("JE", "Jersey ", "je.png"));
            //Countries.Add(new Country("JM", "Jamaica ", "jm.png"));
            //Countries.Add(new Country("JO", "Jordan ", "jo.png"));
            //Countries.Add(new Country("JP", "Japan ", "jp.png"));
            //Countries.Add(new Country("KE", "Kenya ", "ke.png"));
            //Countries.Add(new Country("KG", "Kyrgyzstan ", "kg.png"));
            //Countries.Add(new Country("KH", "Cambodia ", "kh.png"));
            //Countries.Add(new Country("KI", "Kiribati ", "ki.png"));
            //Countries.Add(new Country("KM", "Comoros ", "km.png"));
            //Countries.Add(new Country("KN", "Saint Kitts and Nevis ", "kn.png"));
            //Countries.Add(new Country("KP", "Korea, Democratic People's Republic of ", "kp.png"));
            //Countries.Add(new Country("KR", "Korea, Republic of ", "kr.png"));
            //Countries.Add(new Country("KW", "Kuwait ", "kw.png"));
            //Countries.Add(new Country("KY", "Cayman Islands ", "ky.png"));
            //Countries.Add(new Country("KZ", "Kazakhstan ", "kz.png"));
            //Countries.Add(new Country("LA", "Lao People's Democratic Republic ", "la.png"));
            //Countries.Add(new Country("LB", "Lebanon ", "lb.png"));
            //Countries.Add(new Country("LC", "Saint Lucia ", "lc.png"));
            //Countries.Add(new Country("LI", "Liechtenstein ", "li.png"));
            //Countries.Add(new Country("LK", "Sri Lanka ", "lk.png"));
            //Countries.Add(new Country("LR", "Liberia ", "lr.png"));
            //Countries.Add(new Country("LS", "Lesotho ", "ls.png"));
            //Countries.Add(new Country("LT", "Lithuania ", "lt.png"));
            //Countries.Add(new Country("LU", "Luxembourg ", "lu.png"));
            //Countries.Add(new Country("LV", "Latvia ", "lv.png"));
            //Countries.Add(new Country("LY", "Libya ", "ly.png"));
            //Countries.Add(new Country("MA", "Morocco ", "ma.png"));
            //Countries.Add(new Country("MC", "Monaco ", "mc.png"));
            //Countries.Add(new Country("MD", "Moldova, Republic of ", "md.png"));
            //Countries.Add(new Country("ME", "Montenegro ", "me.png"));
            //Countries.Add(new Country("MF", "Saint Martin (French part) ", "mf.png"));
            //Countries.Add(new Country("MG", "Madagascar ", "mg.png"));
            //Countries.Add(new Country("MH", "Marshall Islands ", "mh.png"));
            //Countries.Add(new Country("MK", "Macedonia, the former Yugoslav Republic of ", "mk.png"));
            //Countries.Add(new Country("ML", "Mali ", "ml.png"));
            //Countries.Add(new Country("MM", "Myanmar ", "mm.png"));
            //Countries.Add(new Country("MN", "Mongolia ", "mn.png"));
            //Countries.Add(new Country("MO", "Macao ", "mo.png"));
            //Countries.Add(new Country("MP", "Northern Mariana Islands ", "mp.png"));
            //Countries.Add(new Country("MQ", "Martinique ", "mq.png"));
            //Countries.Add(new Country("MR", "Mauritania ", "mr.png"));
            //Countries.Add(new Country("MS", "Montserrat ", "ms.png"));
            //Countries.Add(new Country("MT", "Malta ", "mt.png"));
            //Countries.Add(new Country("MU", "Mauritius ", "mu.png"));
            //Countries.Add(new Country("MV", "Maldives ", "mv.png"));
            //Countries.Add(new Country("MW", "Malawi ", "mw.png"));
            //Countries.Add(new Country("MX", "Mexico ", "mx.png"));
            //Countries.Add(new Country("MY", "Malaysia ", "my.png"));
            //Countries.Add(new Country("MZ", "Mozambique ", "mz.png"));
            //Countries.Add(new Country("NA", "Namibia ", "na.png"));
            //Countries.Add(new Country("NC", "New Caledonia ", "nc.png"));
            //Countries.Add(new Country("NE", "Niger ", "ne.png"));
            //Countries.Add(new Country("NF", "Norfolk Island ", "nf.png"));
            //Countries.Add(new Country("NG", "Nigeria ", "ng.png"));
            //Countries.Add(new Country("NI", "Nicaragua ", "ni.png"));
            //Countries.Add(new Country("NL", "Netherlands ", "nl.png"));
            //Countries.Add(new Country("NO", "Norway ", "no.png"));
            //Countries.Add(new Country("NP", "Nepal ", "np.png"));
            //Countries.Add(new Country("NR", "Nauru ", "nr.png"));
            //Countries.Add(new Country("NU", "Niue ", "nu.png"));
            //Countries.Add(new Country("NZ", "New Zealand ", "nz.png"));
            //Countries.Add(new Country("OM", "Oman ", "om.png"));
            //Countries.Add(new Country("PA", "Panama ", "pa.png"));
            //Countries.Add(new Country("PE", "Peru ", "pe.png"));
            //Countries.Add(new Country("PF", "French Polynesia ", "pf.png"));
            //Countries.Add(new Country("PG", "Papua New Guinea ", "pg.png"));
            //Countries.Add(new Country("PH", "Philippines ", "ph.png"));
            //Countries.Add(new Country("PK", "Pakistan ", "pk.png"));
            //Countries.Add(new Country("PL", "Poland ", "pl.png"));
            //Countries.Add(new Country("PM", "Saint Pierre and Miquelon ", "pm.png"));
            //Countries.Add(new Country("PN", "Pitcairn ", "pn.png"));
            //Countries.Add(new Country("PR", "Puerto Rico ", "pr.png"));
            //Countries.Add(new Country("PS", "Palestinian Territory, Occupied ", "ps.png"));
            //Countries.Add(new Country("PT", "Portugal ", "pt.png"));
            //Countries.Add(new Country("PW", "Palau ", "pw.png"));
            //Countries.Add(new Country("PY", "Paraguay ", "py.png"));
            //Countries.Add(new Country("QA", "Qatar ", "qa.png"));
            //Countries.Add(new Country("RE", "Réunion ", "re.png"));
            //Countries.Add(new Country("RO", "Romania ", "ro.png"));
            //Countries.Add(new Country("RS", "Serbia ", "rs.png"));
            //Countries.Add(new Country("RU", "Russian Federation ", "ru.png"));
            //Countries.Add(new Country("RW", "Rwanda ", "rw.png"));
            //Countries.Add(new Country("SA", "Saudi Arabia ", "sa.png"));
            //Countries.Add(new Country("SB", "Solomon Islands ", "sb.png"));
            //Countries.Add(new Country("SC", "Seychelles ", "sc.png"));
            //Countries.Add(new Country("SD", "Sudan ", "sd.png"));
            //Countries.Add(new Country("SE", "Sweden ", "se.png"));
            //Countries.Add(new Country("SG", "Singapore ", "sg.png"));
            //Countries.Add(new Country("SH", "Saint Helena, Ascension and Tristan da Cunha ", "sh.png"));
            //Countries.Add(new Country("SI", "Slovenia ", "si.png"));
            //Countries.Add(new Country("SJ", "Svalbard and Jan Mayen ", "sj.png"));
            //Countries.Add(new Country("SK", "Slovakia ", "sk.png"));
            //Countries.Add(new Country("SL", "Sierra Leone ", "sl.png"));
            //Countries.Add(new Country("SM", "San Marino ", "sm.png"));
            //Countries.Add(new Country("SN", "Senegal ", "sn.png"));
            //Countries.Add(new Country("SO", "Somalia ", "so.png"));
            //Countries.Add(new Country("SR", "Suriname ", "sr.png"));
            //Countries.Add(new Country("SS", "South Sudan ", "ss.png"));
            //Countries.Add(new Country("ST", "Sao Tome and Principe ", "st.png"));
            //Countries.Add(new Country("SV", "El Salvador ", "sv.png"));
            //Countries.Add(new Country("SX", "Sint Maarten (Dutch part) ", "sx.png"));
            //Countries.Add(new Country("SY", "Syrian Arab Republic ", "sy.png"));
            //Countries.Add(new Country("SZ", "Swaziland ", "sz.png"));
            //Countries.Add(new Country("TC", "Turks and Caicos Islands ", "tc.png"));
            //Countries.Add(new Country("TD", "Chad ", "td.png"));
            //Countries.Add(new Country("TF", "French Southern Territories ", "tf.png"));
            //Countries.Add(new Country("TG", "Togo ", "tg.png"));
            //Countries.Add(new Country("TH", "Thailand ", "th.png"));
            //Countries.Add(new Country("TJ", "Tajikistan ", "tj.png"));
            //Countries.Add(new Country("TK", "Tokelau ", "tk.png"));
            //Countries.Add(new Country("TL", "Timor-Leste ", "tl.png"));
            //Countries.Add(new Country("TM", "Turkmenistan ", "tm.png"));
            //Countries.Add(new Country("TN", "Tunisia ", "tn.png"));
            //Countries.Add(new Country("TO", "Tonga ", "to.png"));
            //Countries.Add(new Country("TR", "Turkey ", "tr.png"));
            //Countries.Add(new Country("TT", "Trinidad and Tobago ", "tt.png"));
            //Countries.Add(new Country("TV", "Tuvalu ", "tv.png"));
            //Countries.Add(new Country("TW", "Taiwan, Province of China ", "tw.png"));
            //Countries.Add(new Country("TZ", "Tanzania, United Republic of ", "tz.png"));
            //Countries.Add(new Country("UA", "Ukraine ", "ua.png"));
            //Countries.Add(new Country("UG", "Uganda ", "ug.png"));
            //Countries.Add(new Country("UM", "United States Minor Outlying Islands ", "um.png"));
            //Countries.Add(new Country("US", "United States ", "us.png"));
            //Countries.Add(new Country("UY", "Uruguay ", "uy.png"));
            //Countries.Add(new Country("UZ", "Uzbekistan ", "uz.png"));
            //Countries.Add(new Country("VA", "Holy See (Vatican City State) ", "va.png"));
            //Countries.Add(new Country("VC", "Saint Vincent and the Grenadines ", "vc.png"));
            //Countries.Add(new Country("VE", "Venezuela, Bolivarian Republic of ", "ve.png"));
            //Countries.Add(new Country("VG", "Virgin Islands, British ", "vg.png"));
            //Countries.Add(new Country("VI", "Virgin Islands, U.S. ", "vi.png"));
            //Countries.Add(new Country("VN", "Viet Nam ", "vn.png"));
            //Countries.Add(new Country("VU", "Vanuatu ", "vu.png"));
            //Countries.Add(new Country("WF", "Wallis and Futuna ", "wf.png"));
            //Countries.Add(new Country("WS", "Samoa ", "ws.png"));
            //Countries.Add(new Country("YE", "Yemen ", "ye.png"));
            //Countries.Add(new Country("YT", "Mayotte ", "yt.png"));
            //Countries.Add(new Country("ZA", "South Africa ", "za.png"));
            //Countries.Add(new Country("ZM", "Zambia ", "zm.png"));
            //Countries.Add(new Country("ZW", "Zimbabwe ", "zw.png"));
        }

        private static readonly Random random = new Random();
        private void AddDummiesCities(int citiesCount)
        {
            for (var i = 0; i < citiesCount; ++i)
            {
                var count = Countries[random.Next(Countries.Count - 1) + 1];
                var x = (int)count.ContinentId + 1;
                x = (x >= Continents.Count) ? Continents.Count - 1 : x;
                var cont = Continents[x];
                var name = "" + cont[0] + cont[1] + count.Name.ToLower()[0];

                for (var n = 0; n < 10; ++n)
                {
                    if (random.Next(10) < n)
                        break;

                    name += (char)('a' + random.Next(26));
                }

                Cities.Add(new City(count.CountryCode, name, count.FlagImageUrl, count));
            }
        }
    }
}
