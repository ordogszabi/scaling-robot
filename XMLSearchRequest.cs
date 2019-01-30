using System.Collections.Generic;
using System.Xml;
using System;

namespace XmlAutomation
{
    public partial class XMLSearchRequest : XMLBase
    {
        public static void SetUpSearchParameters(Dictionary<string, string> searchParams)
        {
            SearchParams = searchParams;
        }

        public static void SetUpRoomSearchParameters(List<Dictionary<string, string>> roomSearchParams)
        {
            RoomSearchParams = roomSearchParams;
        }

        public static void SetUpRequest()
        {
            XMLSearchReq = BuildRequest();
        }

        internal static string BuildRequest()
        {
            return XMLRequestBody();
        }

        public static void GetResponse()
        {
            //-----For live XML searches
            XMLSearchRes = SendXMLRequest.GetXMLResponse(XMLSearchReq);

            ////----For debugging purposes and when there is no connection, there is a predifined xml search response
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(@"..\WebTestDemo\Framework\Search\DummyXMLSearchResponse.xml");
            //XMLSearchRes = xmlDoc.InnerXml;
        }

        //public static bool ActualDetailsMatchExpected(List<Dictionary<string, string>> expectedDetails, AssertType assertType, DetailsCheck detailsCheck)
        //{
        //    XMLSearchResponse xmlSearchResponse = new XMLSearchResponse();
        //    if (detailsCheck == DetailsCheck.Property)
        //    {
        //        // This comment line is obsolete! Indexing expectedDetails with 0 as there will always be only 1 expected property to be returned (at least at this point)
        //        ExpectedPropertyDetails = expectedDetails;
        //        expectedPropertyDetailsCount = ExpectedPropertyDetails.Count;
        //    }
        //    else if (detailsCheck == DetailsCheck.Room || detailsCheck == DetailsCheck.RoomAdjustment)
        //    {
        //        ExpectedRoomsDetails = expectedDetails;
        //    }

        //    if (ExpectedPropertyDetails == null)
        //        expectedPropertyDetailsCount = 1;


        //    DetailsMatch = xmlSearchResponse.CheckXMLResponse(XMLSearchRes, detailsCheck, assertType);
        //    return DetailsMatch;
        //}
        public static void BuildSearchDetailsListToBeCompared(string endpoint)
        {
            // XMLSearchResponseToCompare.BuildSearchListToBeCompared(endpoint);
        }

    }
}