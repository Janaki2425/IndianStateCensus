﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndianStatesCensusAnalyser.POCO;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyser
{
    internal class CensusAnalyser
    {
        public enum Country
        {
            INDIA,USA,BRAZIL
        }
        Dictionary<string, CensusDTO> dataMap;
        public Dictionary<string, CensusDTO> LoadCensusData(Country country,string csvFilePath,string dataHeaders)
        {
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
    }
}
