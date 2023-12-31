﻿using System.Xml;
using xmlParserASP.Models;

namespace xmlParserASP.Services;

public class ReadAttributesTo3Columns
{
    public void ReadAttrXMLTo3Columns()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load(PathListVarModel.Path);

        XmlNodeList itemsList = doc.GetElementsByTagName("item");
        XmlNodeList paramListForCount = doc.GetElementsByTagName("param");

        int paramsCount = paramListForCount.Count;

        string[,] array = new string[paramsCount + 1, 5];
        int paramIndex = 1;
        array[0, 0] = "product_id";
        array[0, 1] = "attribute_group";
        array[0, 2] = "attribute_id";
        array[0, 3] = "text(ru-ru)";
        array[0, 4] = "text(uk-ua)";

        int itemIndex = 0;

        foreach (XmlNode item in itemsList)
        {
            string modelID = item.SelectSingleNode("model")?.InnerText;

            XmlNodeList paramList = item.SelectNodes("param");

            foreach (XmlNode param in paramList)
            {
                string paramName = param.Attributes["name"]?.Value;
                string paramValue = param.InnerText;
                string paramId = "4";
                string paramGroup = "Характеристики";

                array[paramIndex, 0] = modelID;
                array[paramIndex, 1] = paramGroup;
                array[paramIndex, 2] = paramName;
                array[paramIndex, 3] = paramValue;
                array[paramIndex, 4] = paramId;

                paramIndex++;
            }

            itemIndex++;
        }

        PathListVarModel.SheetAtributes = array;
    }
}