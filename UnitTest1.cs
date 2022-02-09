using IndianStatesCensusAnalyser;
using IndianStatesCensusAnalyser.POCO;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Collections.Generic;
using static IndianStatesCensusAnalyser.Censusanalyser;
namespace CensusAnalyserTest
{
    public class Tests
    {
        static string indianStateCensusHeaders = "State,Population,AreainSqkm,Densitypersqkm";
        static string indianStateCodeHeaders = "State,StateCode";
        static string indianStateCensusFilePath = "C:/Users/91936/source/repos/IndianStatesCensusAnalyser/CensusAnalyserTest/CSVFiles/IndiaStateCensusData.csv";
        static string wrongHeaderIndianCensusFilePath = "C:/Users/91936/source/repos/IndianStatesCensusAnalyser/CensusAnalyserTest/CSVFiles/WrongIndiaStateCensusData.csv";
        static string delimiterIndianCensusFilePath = "C:/Users/91936/source/repos/IndianStatesCensusAnalyser/CensusAnalyserTest/CSVFiles/DelimiterIndiaStateCensusData.csv";
        static string wrongIndianCensusFilePath = "C:/Users/91936/source/repos/IndianStatesCensusAnalyser/CensusAnalyserTest/CSVFiles/IndiaData.csv";
        static string wrongIndianCensusFileType = "C:/Users/91936/source/repos/IndianStatesCensusAnalyser/CensusAnalyserTes/CSVFiles/IndiaStateCensusData.txt";
        static string indianStateCodeFilePath = "C:/Users/91936/source/repos/IndianStatesCensusAnalyser/CensusAnalyserTest/CSVFiles/IndiaStateCode.csv";
        static string wrongIndianStateCodeFileType = "C:/Users/91936/source/repos/IndianStatesCensusAnalyser/CensusAnalyserTest/CSVFiles/IndiaStateCode.txt";
        static string delimiterIndianStateCodeFilePath = "C:/Users/91936/source/repos/IndianStatesCensusAnalyser/CensusAnalyserTest/CSVFiles/DelimiterIndiaStateCode.csv";
        static string wrongHeaderStateCodeFilePath = "C:/Users/91936/source/repos/IndianStatesCensusAnalyser/CensusAnalyserTest/CSVFiles/WrongIndiaStateCode.csv";

        IndianStateCensusAnalyser.CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;

        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser.CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();


        }

        [Test]
        public void WhenReadedShouldReturnCensusDataCount()
        {
            totalRecord = censusAnalyser.LoadCensusData(Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            stateRecord = censusAnalyser.LoadCensusData(Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            Assert.AreEqual(29, totalRecord.Count);
            Assert.AreEqual(37, stateRecord.Count);
        }
        [Test]
        public void WrongDataFile_WhenReadedeshouldShowCustomException()
        {
            var censusException = Assert.Throws<CensusAnalyserException>({)=>censusAnalyser.LoadCensusData(Country.INDIA, wrongIndianStateCensusFilePath.IndianStateCensusHeaders);
            var stateException = Assert.Throws<CensusAnalyserException>({)=>censusAnalyser.LoadCensusData(Country.INDIA, wrongIndianStateCensusFilePath.IndianStateCodeHeaders);
            Assert.AreEqual(CensusAnalyserException.ExceptionType.FILE_NOT_FOUND, censusException.eType);
             Assert.AreEqual(CensusAnalyserException.ExceptionType.FILE_NOT_FOUND, stateException.eType);


                }

                [Test]
                public void WrongDataFileType_WhenReadedeshouldShowCustomException()
                {
                var censusException = Assert.Throws<CensusAnalyserException>({)=>censusAnalyser.LoadCensusData(Country.INDIA, wrongIndianStateCensusFileType.IndianStateCensusHeaders);
                var censusException = Assert.Throws<CensusAnalyserException>({)=>censusAnalyser.LoadCensusData(Country.INDIA, wrongIndianStateCensusFileType.IndianStateCodeHeaders);
                 Assert.AreEqual(CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE, censusException.eType);
                 Assert.AreEqual(CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE, stateException.eType);


                }

                [Test]

                public void WhenNotProperShouldReturnException()
                {
                var censusException = Assert.Throws<CensusAnalyserException>({)=>censusAnalyser.LoadCensusData(Country.INDIA, delimiterIndianStateCensusFileType.IndianStateCensusHeaders);
                var stateException = Assert.Throws<CensusAnalyserException>({)=>censusAnalyser.LoadCensusData(Country.INDIA, delimiterIndianStateCensusFileType.IndianStateCodeHeaders);
                    Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_DELIMITER, censusException.eType);
                    Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_DELIMITER, stateException.eType);

                 

                }
                [Test]
               public void WhenHeaderNotProperShouldReturnException()
                {
                var censusException = Assert.Throws<CensusAnalyserException>({)=>censusAnalyser.LoadCensusData(Country.INDIA, WrongHeaderIndianStateCensusFileType.IndianStateCensusHeaders);
                var stateException = Assert.Throws<CensusAnalyserException>({)=>censusAnalyser.LoadCensusData(Country.INDIA, WrongHeaderIndianStateCensusFileType.IndianStateCodeHeaders);
                    Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_HEADER, censusException.eType);
                    Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_HEADER, stateException.eType);


                }
            }
        }
    }
}

        
            
        
    













            
        