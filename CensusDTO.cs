using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyser.POCO
{
    internal class CensusDTO
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int pin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public long housingUnits;
        public double totalArea;
        public double waterArea;
        public double landArea;
        public double populationDensity;
        public double housingDensity;

        public CensusDTO(StateCodeDAO stateCodeDAO)
        {
            this.serialNumber = stateCodeDAO.serialNumber;
            this.stateName = stateCodeDAO.stateName;
            this.pin = stateCodeDAO.pin;
            this.stateCode = stateCodeDAO.stateCode;
        }
        public CensusDTO(CensusDataDAO censusDataDAO)
        {
            this.state = censusDataDAO.state;
            this.population = censusDataDAO.population;
            this.area = censusDataDAO.area;
            this.density = censusDataDAO.density;
        }

        //public CensusDTO(USCensusDAO uSCensusDAO)
        //{
        //    this.stateCode=uSCensusDAO.stateCode;
        //    this.stateName=uSCensusDAO.stateName;
        //    this.population=uSCensusDAO.population;
        //    this.housingUnits=uSCensusDAO.houseUnits;
        //    this.totalArea=uSCensusDAO.totalArea;
        //    this.waterArea=uSCensusDAO.waterArea;
        //    this.landArea=uSCensusDAO.landArea;
        //}









    }
}
