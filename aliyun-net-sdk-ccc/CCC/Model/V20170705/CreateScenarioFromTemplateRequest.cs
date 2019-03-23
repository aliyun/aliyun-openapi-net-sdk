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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class CreateScenarioFromTemplateRequest : RpcAcsRequest<CreateScenarioFromTemplateResponse>
    {
        public CreateScenarioFromTemplateRequest()
            : base("CCC", "2017-07-05", "CreateScenarioFromTemplate", "ccc", "openAPI")
        {
        }

        private string variables;

        private string instanceId;

        private string name;

        private string description;

        private string templateId;

        public string Variables
        {
            get
            {
                return variables;
            }
            set
            {
                variables = value;
                DictionaryUtil.Add(QueryParameters, "Variables", value);
            }
        }

        public string InstanceId
        {
            get
            {
                return instanceId;
            }
            set
            {
                instanceId = value;
                DictionaryUtil.Add(QueryParameters, "InstanceId", value);
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                DictionaryUtil.Add(QueryParameters, "Name", value);
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                DictionaryUtil.Add(QueryParameters, "Description", value);
            }
        }

        public string TemplateId
        {
            get
            {
                return templateId;
            }
            set
            {
                templateId = value;
                DictionaryUtil.Add(QueryParameters, "TemplateId", value);
            }
        }

        public override bool CheckShowJsonItemName()
        {
            return false;
        }

        public override CreateScenarioFromTemplateResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateScenarioFromTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}