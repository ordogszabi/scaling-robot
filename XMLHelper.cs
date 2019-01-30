using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

<<<<<<< HEAD
helyi valtozas
=======
remote change
>>>>>>> 8cd600cf108b07202b9cfebcdba878a19cd41393

namespace XmlAutomation
{
    public enum XPath
    {
        CurrencyID,
        PropertyReferenceID,
        RoomType,
        Success,
        Exception,
        Adjustments,
        Errata,
        PropertyResult,
        TotalProperties,
        PropertyID,
        PropertyName,
        Rating,
        OurRating,
        Country,
        Region,
        Resort,
        RoomTypeName,
        Seq,
        MealBasisID,
        RoomView,
        PropertyRoomTypeID,
        BookingToken,
        AdjustmentType,
        AdjustmentName,
        ErratumSubject,
        ErratumDescription,
        Strapline,
        Description,
        MealBasis,
        SubTotal,
        Discount,
        OnRequest,
        Total,
        Commission,
        Adults,
        Children,
        Infants,
        OptionalSupplements,
        AdjustmentSpecialOfferTypeID,
        AdjustmentContractArrangementID,
        SpecialOfferApplied
    }

    class XMLHelper
    {
        internal static string CreateXpath(XPath xpath)
        {
            string xpathString = "";
            switch (xpath)
            {
                #region ResponseLevelNodes
                case XPath.PropertyResult:
                    xpathString = "SearchResponse/PropertyResults/PropertyResult";
                    break;
                case XPath.CurrencyID:
                    xpathString = "SearchResponse/CurrencyID";
                    break;
                #endregion

                #region PropertyLevelNodes
                //PropertyLevel
                case XPath.TotalProperties:
                    xpathString = "TotalProperties";
                    break;
                case XPath.PropertyID:
                    xpathString = "PropertyID";
                    break;
                case XPath.PropertyReferenceID:
                    xpathString = "PropertyReferenceID";
                    break;
                case XPath.PropertyName:
                    xpathString = "PropertyName";
                    break;
                case XPath.Rating:
                    xpathString = "Rating";
                    break;
                case XPath.OurRating:
                    xpathString = "OurRating";
                    break;
                case XPath.Country:
                    xpathString = "Country";
                    break;
                case XPath.Region:
                    xpathString = "Region";
                    break;
                case XPath.Resort:
                    xpathString = "Resort";
                    break;
                case XPath.Strapline:
                    xpathString = "Strapline";
                    break;
                case XPath.Description:
                    xpathString = "Description";
                    break;
                case XPath.RoomType:
                    xpathString = "RoomTypes/RoomType";
                    break;
                #endregion

                #region RoomLevelNodes
                case XPath.Seq:
                    xpathString = "Seq";
                    break;
                case XPath.PropertyRoomTypeID:
                    xpathString = "PropertyRoomTypeID";
                    break;
                case XPath.BookingToken:
                    xpathString = "BookingToken";
                    break;
                case XPath.MealBasisID:
                    xpathString = "MealBasisID";
                    break;
                case XPath.RoomTypeName:
                    xpathString = "RoomType";
                    break;
                case XPath.RoomView:
                    xpathString = "RoomView";
                    break;
                case XPath.MealBasis:
                    xpathString = "MealBasis";
                    break;
                case XPath.SubTotal:
                    xpathString = "SubTotal";
                    break;
                case XPath.Discount:
                    xpathString = "Discount";
                    break;
                case XPath.SpecialOfferApplied:
                    xpathString = "SpecialOfferApplied";
                    break;
                case XPath.OnRequest:
                    xpathString = "OnRequest";
                    break;
                case XPath.Total:
                    xpathString = "Total";
                    break;
                case XPath.Commission:
                    xpathString = "Commission";
                    break;
                case XPath.Adults:
                    xpathString = "Adults";
                    break;
                case XPath.Children:
                    xpathString = "Children";
                    break;
                case XPath.Infants:
                    xpathString = "Infants";
                    break;
                case XPath.OptionalSupplements:
                    xpathString = "OptionalSupplements";
                    break;
                case XPath.Adjustments:
                    xpathString = "Adjustments/Adjustment";
                    break;
                case XPath.Errata:
                    xpathString = "Errata/Erratum";
                    break;
                #endregion

                #region AdjustmentLevelNodes
                case XPath.AdjustmentType:
                    xpathString = "AdjustmentType";
                    break;
                case XPath.AdjustmentName:
                    xpathString = "AdjustmentName";
                    break;
                //Total node is shared with the room level node!!
                case XPath.AdjustmentSpecialOfferTypeID:
                    xpathString = "SpecialOfferTypeID";
                    break;
                case XPath.AdjustmentContractArrangementID:
                    xpathString = "ContractArrangementID";
                    break;
                #endregion

                #region ErrataLevelNodes
                case XPath.ErratumSubject:
                    xpathString = "Subject";
                    break;
                case XPath.ErratumDescription:
                    xpathString = "Description";
                    break;
                    #endregion
            }
            return xpathString;
        }

        //internal static string CreateXpath(string xpath) test
        //{
        //    string xpathString = "";
        //    switch (xpath)
        //    {
        //        #region ResponseLevelNodes
        //        //case XPath.PropertyResult:
        //        //    xpathString = "SearchResponse/PropertyResults/PropertyResult";
        //        //    break;
        //        //case XPath.CurrencyID:
        //        //    xpathString = "SearchResponse/CurrencyID";
        //        //    break;
        //        #endregion

        //        #region PropertyLevelNodes
        //        //PropertyLevel
        //        case "TotalProperties":
        //            xpathString = "TotalProperties";
        //            break;
        //        case "PropertyID":
        //            xpathString = "PropertyID";
        //            break;
        //        case "PropertyReferenceID":
        //            xpathString = "PropertyReferenceID";
        //            break;
        //        case "PropertyName":
        //            xpathString = "PropertyName";
        //            break;
        //        case "Rating":
        //            xpathString = "Rating";
        //            break;
        //        case "OurRating":
        //            xpathString = "OurRating";
        //            break;
        //        case "Country":
        //            xpathString = "Country";
        //            break;
        //        case "Region":
        //            xpathString = "Region";
        //            break;
        //        case "Resort":
        //            xpathString = "Resort";
        //            break;
        //        case "SearchURL":
        //            xpathString = "SearchURL";
        //            break;
        //        case "Strapline":
        //            xpathString = "Strapline";
        //            break;
        //        case "Description":
        //            xpathString = "Description";
        //            break;
        //        case "CMSBaseURL":
        //            xpathString = "CMSBaseURL";
        //            break;
        //        case "MainImage":
        //            xpathString = "MainImage";
        //            break;
        //        case "MainImageThumbnail":
        //            xpathString = "MainImageThumbnail";
        //            break;
        //        #endregion

        //        #region RoomLevelNodes
        //        case "Seq":
        //            xpathString = "Seq";
        //            break;
        //        case "PropertyRoomTypeID":
        //            xpathString = "PropertyRoomTypeID";
        //            break;
        //        case "BookingToken":
        //            xpathString = "BookingToken";
        //            break;
        //        case "MealBasisID":
        //            xpathString = "MealBasisID";
        //            break;
        //        case "RoomType":
        //            xpathString = "RoomType";
        //            break;
        //        case "RoomView":
        //            xpathString = "RoomView";
        //            break;
        //        case "MealBasis":
        //            xpathString = "MealBasis";
        //            break;
        //        case "SubTotal":
        //            xpathString = "SubTotal";
        //            break;
        //        case "Discount":
        //            xpathString = "Discount";
        //            break;
        //        case "SpecialOfferApplied":
        //            xpathString = "SpecialOfferApplied";
        //            break;
        //        case "OnRequest":
        //            xpathString = "OnRequest";
        //            break;
        //        case "Total":
        //            xpathString = "Total";
        //            break;
        //        case "Commission":
        //            xpathString = "Commission";
        //            break;
        //        case "Adults":
        //            xpathString = "Adults";
        //            break;
        //        case "Children":
        //            xpathString = "Children";
        //            break;
        //        case "Infants":
        //            xpathString = "Infants";
        //            break;
        //        case "OptionalSupplements":
        //            xpathString = "OptionalSupplements";
        //            break;
        //        #endregion

        //        #region AdjustmentLevelNodes
        //        case "AdjustmentType":
        //            xpathString = "AdjustmentType";
        //            break;
        //        case "AdjustmentName":
        //            xpathString = "AdjustmentName";
        //            break;
        //        case "SpecialOfferTypeID":
        //            xpathString = "SpecialOfferTypeID";
        //            break;
        //        case "ContractArrangementID":
        //            xpathString = "ContractArrangementID";
        //            break;
        //        //Total node is shared with the room level node!!
        //        #endregion

        //        #region ErrataLevelNodes
        //        case "Subject":
        //            xpathString = "Subject";
        //            break;
        //        case "ErrataDescription":
        //            xpathString = "Description";
        //            break;
        //        #endregion


             
        //    }
        //    return xpathString;
        //}

        public static string GetSingleNodeValue(XmlNode propertyResponse, XPath xpath)
        {
            string elementValue = "";
            try
            {
                elementValue = propertyResponse.SelectSingleNode(CreateXpath(xpath)).InnerText;
            }
            catch
            {
                Console.WriteLine("Element {0} not exist in the response", xpath);
            }

            return elementValue;
        }

        public static string GetSingleNodeValue(XmlDocument xmlDoc, XPath xpath)
        {
            string elementValue = "";
            try
            {
                elementValue = xmlDoc.SelectSingleNode(CreateXpath(xpath)).InnerText;
            }
            catch
            {
                Console.WriteLine("Element {0} not exist in the response", xpath);
            }

            return elementValue;
        }
    }
}
