/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml;

namespace Aliyun.Acs.Core.Reader
{
    public class XmlReader : IReader
    {
        Dictionary<String, String> dictionary = new Dictionary<String, String>();

        public Dictionary<String, String> Read(String xml, String endpoint)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            Read(doc.ChildNodes[1], endpoint, false);
            return dictionary;
        }

        private void Read(XmlNode element, String path, bool appendPath)
        {
            path = appendPath ? path + "." + element.Name : path;
            if (element.InnerText.Equals(element.InnerXml))
            {
                dictionary.Add(path, element.InnerText);
                return;
            }
            XmlNodeList listElements = element.SelectNodes(element.FirstChild.Name);
            if (listElements.Count > 1 && element.ChildNodes.Count == listElements.Count)
            {//be list
                ElementsAsList(element.ChildNodes, path);
            }
            else if (listElements.Count == 1 && element.ChildNodes.Count == 1)
            {//may be list
                ElementsAsList(listElements, path);//as list
                Read(element.FirstChild, path, true);//as not list
            }
            else
            {//not list
                foreach (XmlNode childElement in element.ChildNodes)
                {
                    Read(childElement, path, true);
                }
            }
        }

        private void ElementsAsList(XmlNodeList listElements, String path)
        {
            dictionary.Add(path + ".Length", listElements.Count.ToString());
            for (int i = 0; i < listElements.Count; i++)
            {
                Read(listElements[i], path + "[" + i + "]", false);
            }
        }

    }
}
