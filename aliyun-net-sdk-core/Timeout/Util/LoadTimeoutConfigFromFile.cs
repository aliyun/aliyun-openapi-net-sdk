﻿/*
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
using System.IO;
using System.Reflection;
using System.Text;

using Aliyun.Acs.Core.Exceptions;

using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Aliyun.Acs.Core.Timeout.Util
{
    internal class LoadTimeoutConfigFromFile
    {
        private const string ConfigFileLocation = "timeout_config.json";
        private JObject currentJsonData;

        public int GetSpecificApiReadTimeoutValue(string product, string version, string actionName)
        {
            try
            {
                JObject jsonData;

                if (currentJsonData == null)
                {
                    var currentNamespace = MethodBase.GetCurrentMethod().DeclaringType.Namespace;
                    var assembly = Assembly.GetExecutingAssembly();

                    var resourceName = string.Format("{0}.{1}", currentNamespace, ConfigFileLocation);

                    using (var stream = assembly.GetManifestResourceStream(resourceName))
                    using (var streamReader = new StreamReader(stream))
                    {
                        var data = streamReader.ReadToEnd();
                        jsonData = JObject.Parse(data);

                        currentJsonData = jsonData;
                    }
                }
                else
                {
                    jsonData = currentJsonData;
                }

                if (jsonData[product] == null
                    || jsonData[product][version] == null
                    || jsonData[product][version][actionName] == null)
                {
                    return 0;
                }

                return jsonData[product][version][actionName].ToObject<int>();
            }
            catch (Exception e)
            {
                throw new ClientException("LoadJsonFileError", e.ToString());
            }
        }
    }
}
