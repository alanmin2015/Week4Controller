using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Week4Controller.Controllers
{
    public class Week4Controller : ApiController
    {

        /// <summary>
        /// determines the speed of the race car
        /// </summary>
        /// <returns>The speed of the car</returns>
        /// <param name="TankSize">tank size in L</param>
        /// <param name="WheelDiameter">wheel diameter in inches</param>
        /// <example>
        /// GET: api/Week4/CarCalculator/50/25->75
        /// </example>

        [Route("api/week4/carcalculator/{TankSize}/{WheelDiameter}/{SpoilerHeight}")]
        [HttpGet]
        public string CarCalculator(int TankSize, int WheelDiameter, int SpoilerHeight)
        {
            if (TankSize > 60)
            {
                return " Not Valid";
            }

            else if (WheelDiameter<50) {
                return "Not Valid";
            }

            else if(WheelDiameter > 56)
            {
                return "Not Valid";
            }

            else if(SpoilerHeight > 20)
            {
                return "Not Valid";
            }

            else
            {
                return "Valid";
            }
        }
        /// <summary>
        /// Returns a message if the weeding is on budget
        /// </summary>
        /// <param name="NumGuests">The number of guests in the wedding</param>
        /// <param name="VenueSize">The venue size in square feet</param>
        /// <param name="Budget">The budget in CAD</param>
        /// <returns>If the weeding is under or over budget</returns>
        /// <example>
        /// Get:api/week4/weddingcalculator/10/2000/25000->"Weeding is under budget"
        /// Get:api/week4/weddingcalculator/20/2000/25000->"Weeding is over budget"
        /// </example>
        /// 

        [HttpGet]
        [Route("api/week4/weddingcalculator/{NumGuests}/{VenueSize}/{Budget}")]
        public string WeddingCalculator(int NumGuests, int VenueSize, int Budget)
        {
            int WeddingCost = NumGuests * VenueSize;

            if (WeddingCost > Budget)
            {
                return "Wedding is over budget";
            }
            else if(WeddingCost==Budget)
            {
                return "Wedding cost is the same as budget" ;
            }

            else
            {
                return "Wedding cost is under budget";
            }
            /// return "Number of Guests "+NumGuests+". Venue size is "+VenueSize+". Budget"+Budget;

        }

        [HttpGet]
        [Route("api/IfPractice/CoinComputer/{Nickles}/{Dimes}/{Quarters}/{Loonies}/{Twoonies}")]
        public string CoinComputer(int Nickles, int Dimes, int Quarters, int Loonies, int Twoonies)
        {
            double Total = Nickles * 0.05+ Dimes*0.1+ Quarters  * 0.25 + Loonies * 1+ Twoonies * 2;

            if (Total < 10.5)
            {
                return "False";
            }
            else
            {
                return "True";
            }
            /// return "Number of Guests "+NumGuests+". Venue size is "+VenueSize+". Budget"+Budget;

        }


        [HttpGet]
        [Route("api/IfPractice/PointQuadrant/{x}/{y}")]
        public string PointQuadrant(int x, int y)
        {
            
            if (x >0 && y>0)
            {
                return "1";
            }
            else if (x < 0 && y > 0)
            {
                return "2";
            }

            else if (x < 0 && y < 0)
            {
                return "3";
            }

            else if (x > 0 && y < 0)
            {
                return "4";
            }

            else
            {
                return "0";
            }
            /// return "Number of Guests "+NumGuests+". Venue size is "+VenueSize+". Budget"+Budget;

        }
    }
}
