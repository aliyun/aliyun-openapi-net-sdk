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

using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Aliyun.Acs.Core.Reader
{
    public class XmlReader : IReader
    {
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        public Dictionary<string, string> Read(string xml, string endpoint)
        {
            var doc = XDocument.Parse(xml);

            Read(doc.Root, endpoint, false);
            return _dictionary;
        }

        private void Read(XElement element, string path, bool appendPath)
        {
            path = appendPath ? path + "." + element.Name : path;
            if (!element.HasElements)
            {
                _dictionary.Add(path, element.Value);
                return;
            }

            var listElements = element.Elements(((XElement) element.FirstNode).Name).ToArray();
            if (listElements.Length > 1 && element.Elements().Count() == listElements.Length)
            {
//be list
                ElementsAsList(element.Elements(), path);
            }
            else if (listElements.Length == 1 && element.Elements().Count() == 1)
            {
//may be list
                ElementsAsList(listElements, path); //as list
                Read((XElement) element.FirstNode, path, true); //as not list
            }
            else
            {
//not list
                foreach (var childElement in element.Elements())
                    Read(childElement, path, true);
            }
        }

        private void ElementsAsList(IEnumerable<XElement> listElements, string path)
        {
            var xElements = listElements as XElement[] ?? listElements.ToArray();
            _dictionary.Add(path + ".Length", xElements.Length.ToString());
            for (var i = 0; i < xElements.Length; i++)
                Read(xElements.ElementAt(i), $"{path}[{i}]", false);
        }
    }
}