﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DropDownAuto : MonoBehaviour
{
    enum Countries
    {
        Elegir_Pais,
        Afghanistan,

        Albania,

        Algeria,

        Andorra,

        Angola,

        AntiguaAndDeps,

        Argentina,

        Armenia,

        Australia,

        Austria,

        Azerbaijan,

        Bahamas,

        Bahrain,

        Bangladesh,

        Barbados,

        Belarus,

        Belgium,

        Belize,

        Benin,

        Bhutan,

        Bolivia,

        Bosnia_Herzegovina,

        Botswana,

        Brazil,

        Brunei,

        Bulgaria,

        Burkina,

        Burundi,

        Cambodia,

        Cameroon,

        Canada,

        CapeVerde,

        Central_African_Rep,

        Chad,

        Chile,

        China,

        Colombia,

        Comoros,

        Congo,

        Congo_Democratic_Rep,

        Costa_Rica,

        Croatia,

        Cuba,

        Cyprus,

        Czech_Republic,

        Denmark,

        Djibouti,

        Dominica,

        Dominican_Republic,

        East_Timor,

        Ecuador,

        Egypt,

        El_Salvador,

        Equatorial_Guinea,

        Eritrea,

        Estonia,

        Ethiopia,

        Fiji,

        Finland,

        France,

        Gabon,

        Gambia,

        Georgia,

        Germany,

        Ghana,

        Greece,

        Grenada,

        Guatemala,

        Guinea,

        Guinea_Bissau,

        Guyana,

        Haiti,

        Honduras,

        Hungary,

        Iceland,

        India,

        Indonesia,

        Iran,

        Iraq,

        Ireland_Republic,

        Israel,

        Italy,

        Ivory_Coast,

        Jamaica,

        Japan,

        Jordan,

        Kazakhstan,

        Kenya,

        Kiribati,

        Korea_North,

        Korea_South,

        Kosovo,

        Kuwait,

        Kyrgyzstan,

        Laos,

        Latvia,

        Lebanon,

        Lesotho,

        Liberia,

        Libya,

        Liechtenstein,

        Lithuania,

        Luxembourg,

        Macedonia,

        Madagascar,

        Malawi,

        Malaysia,

        Maldives,

        Mali,

        Malta,

        Marshall_Islands,

        Mauritania,

        Mauritius,

        Mexico,

        Micronesia,

        Moldova,

        Monaco,

        Mongolia,

        Montenegro,

        Morocco,

        Mozambique,

        Myanmar,
        Burma,

        Namibia,

        Nauru,

        Nepal,

        Netherlands,

        New_Zealand,

        Nicaragua,

        Niger,

        Nigeria,

        Norway,

        Oman,

        Pakistan,

        Palau,

        Panama,

        Papua_New_Guinea,

        Paraguay,

        Peru,

        Philippines,

        Poland,

        Portugal,

        Qatar,

        Romania,

        Russian_Federation,

        Rwanda,

        St_Kitts_Nevis,

        St_Lucia,

        Saint_Vincent_and_the_Grenadines,

        Samoa,

        San_Marino,

        Sao_Tome_Principe,

        Saudi_Arabia,

        Senegal,

        Serbia,

        Seychelles,

        Sierra_Leone,

        Singapore,

        Slovakia,

        Slovenia,

        Solomon_Islands,

        Somalia,

        South_Africa,

        South_Sudan,

        Spain,

        Sri_Lanka,

        Sudan,

        Suriname,

        Swaziland,

        Sweden,

        Switzerland,

        Syria,

        Taiwan,

        Tajikistan,

        Tanzania,

        Thailand,

        Togo,

        Tonga,

        Trinidad_Tobago,

        Tunisia,

        Turkey,
        Turkmenistan,

        Tuvalu,

        Uganda,

        Ukraine,

        United_Arab_Emirates,

        United_Kingdom,

        United_States,

        Uruguay,

        Uzbekistan,

        Vanuatu,

        Vatican_City,

        Venezuela,

        Vietnam,

        Yemen,

        Zambia,

        Zimbabwe,


    }

    public Dropdown DropCountries;
    public Text CountrySelected;

    void Start()
    {
        PopulateList();
    }
    public void Dropdown_IndexChanged(int index)
    {
        Countries name = (Countries)index;
        CountrySelected.text = name.ToString();
        if (index == 0)
        {
            CountrySelected.color = Color.red;
        }
        else
        {
            CountrySelected.color = Color.white;
        }
    }

    void PopulateList()
    {
        string[] enumNames = Enum.GetNames(typeof(Countries));
        List<string> names = new List<string>(enumNames);
        DropCountries.AddOptions(names);


    }
}

