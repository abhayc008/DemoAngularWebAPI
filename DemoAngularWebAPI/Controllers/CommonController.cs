using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoAngularWebAPI.Models;


namespace DemoAngularWebAPI.Controllers
{
    public class CommonController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetCountries()
        {
            APIResponse objAPIResponse = new APIResponse();
            try
            {
                List<Country> lstCountry = new List<Country> {
                new Country{ ID= 1, NAME="India" },
                new Country { ID= 2, NAME= "USA" },
                new Country { ID= 3, NAME= "Australia" } };


                objAPIResponse.STATUS = ResponseStatus.SUCCESS;
                objAPIResponse.DATA = lstCountry;
            }
            catch (Exception ex)
            {
                objAPIResponse.STATUS = ResponseStatus.SUCCESS;
                objAPIResponse.ERROR = new List<ERRORS> { new ERRORS { CODE = "ERR", MESSAGE = ex.Message, DESCIPTION = ex.StackTrace } };
            }

            return Ok(objAPIResponse);
        }

        [HttpGet]
        public IHttpActionResult GetStates(int COUNTRY_ID)
        {
            APIResponse objAPIResponse = new APIResponse();
            try
            {
                List<State> lstState = new List<State> {
                  new State { ID= 1, COUNTRY_ID= 1, NAME= "Andhra Pradesh" },
                  new State { ID= 2, COUNTRY_ID= 1, NAME= "Madhya Pradesh" },
                  new State { ID= 3, COUNTRY_ID= 2, NAME= "San Francisco"},
                  new State { ID= 4, COUNTRY_ID= 2, NAME= "Los Angeles"},
                  new State { ID= 5, COUNTRY_ID= 3, NAME= "New South Wales"},
                  new State { ID= 6, COUNTRY_ID= 3, NAME= "Victoria" } };

                lstState = lstState.Where(x => x.COUNTRY_ID == COUNTRY_ID).ToList();

                objAPIResponse.STATUS = ResponseStatus.SUCCESS;
                objAPIResponse.DATA = lstState;
            }
            catch (Exception ex)
            {
                objAPIResponse.STATUS = ResponseStatus.SUCCESS;
                objAPIResponse.ERROR = new List<ERRORS> { new ERRORS { CODE = "ERR", MESSAGE = ex.Message, DESCIPTION = ex.StackTrace } };
            }

            return Ok(objAPIResponse);
        }

        [HttpGet]
        public IHttpActionResult GetCities(int STATE_ID)
        {
            APIResponse objAPIResponse = new APIResponse();
            try
            {
                List<City> lstCity = new List<City> {
                new City{ ID= 1,  STATE_ID= 1, NAME="Guntur" },
                new City{ ID= 2,  STATE_ID= 1, NAME="Vijayawada" },
                new City{ ID= 3,  STATE_ID= 1, NAME="Nellore" },
                new City{ ID= 4,  STATE_ID= 1, NAME="Kadapa" },
                new City{ ID= 5,  STATE_ID= 2, NAME="Warangal" },
                new City{ ID= 6,  STATE_ID= 2, NAME="Hyderabad" },
                new City{ ID= 7,  STATE_ID= 2, NAME="Karimnagar" },
                new City{ ID= 8,  STATE_ID= 2, NAME="Kadapa" },
                new City{ ID= 9,  STATE_ID= 3, NAME="SOMA" },
                new City{ ID= 10, STATE_ID= 3, NAME="Richmond" },
                new City{ ID= 11, STATE_ID= 3, NAME="Sunset" },
                new City{ ID= 12, STATE_ID= 4, NAME="Burbank" },
                new City{ ID= 13, STATE_ID= 4, NAME="Hollywood" },
                new City{ ID= 14, STATE_ID= 5, NAME="Sunset" },
                new City{ ID= 15, STATE_ID= 5, NAME="Burbank" },
                new City{ ID= 16, STATE_ID= 5, NAME="Hollywood" },
                new City{ ID= 17, STATE_ID= 6, NAME="Benalla" },
                new City{ ID= 18, STATE_ID= 6, NAME="Melbourne" } };

                lstCity = lstCity.Where(x => x.STATE_ID == STATE_ID).ToList();

                objAPIResponse.STATUS = ResponseStatus.SUCCESS;
                objAPIResponse.DATA = lstCity;
            }
            catch (Exception ex)
            {
                objAPIResponse.STATUS = ResponseStatus.SUCCESS;
                objAPIResponse.ERROR = new List<ERRORS> { new ERRORS { CODE = "ERR", MESSAGE = ex.Message, DESCIPTION = ex.StackTrace } };
            }

            return Ok(objAPIResponse);
        }

    }
}
