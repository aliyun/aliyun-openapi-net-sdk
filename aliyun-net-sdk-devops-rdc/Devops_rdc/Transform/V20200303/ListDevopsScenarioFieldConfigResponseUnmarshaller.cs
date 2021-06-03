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

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class ListDevopsScenarioFieldConfigResponseUnmarshaller
    {
        public static ListDevopsScenarioFieldConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDevopsScenarioFieldConfigResponse listDevopsScenarioFieldConfigResponse = new ListDevopsScenarioFieldConfigResponse();

			listDevopsScenarioFieldConfigResponse.HttpResponse = _ctx.HttpResponse;
			listDevopsScenarioFieldConfigResponse.Successful = _ctx.BooleanValue("ListDevopsScenarioFieldConfig.Successful");
			listDevopsScenarioFieldConfigResponse.ErrorCode = _ctx.StringValue("ListDevopsScenarioFieldConfig.ErrorCode");
			listDevopsScenarioFieldConfigResponse.ErrorMsg = _ctx.StringValue("ListDevopsScenarioFieldConfig.ErrorMsg");
			listDevopsScenarioFieldConfigResponse.RequestId = _ctx.StringValue("ListDevopsScenarioFieldConfig.RequestId");

			List<ListDevopsScenarioFieldConfigResponse.ListDevopsScenarioFieldConfig_ScenarioFieldConfig> listDevopsScenarioFieldConfigResponse_object = new List<ListDevopsScenarioFieldConfigResponse.ListDevopsScenarioFieldConfig_ScenarioFieldConfig>();
			for (int i = 0; i < _ctx.Length("ListDevopsScenarioFieldConfig.Object.Length"); i++) {
				ListDevopsScenarioFieldConfigResponse.ListDevopsScenarioFieldConfig_ScenarioFieldConfig scenarioFieldConfig = new ListDevopsScenarioFieldConfigResponse.ListDevopsScenarioFieldConfig_ScenarioFieldConfig();
				scenarioFieldConfig.Id = _ctx.StringValue("ListDevopsScenarioFieldConfig.Object["+ i +"].Id");
				scenarioFieldConfig.Type = _ctx.StringValue("ListDevopsScenarioFieldConfig.Object["+ i +"].Type");
				scenarioFieldConfig.Name = _ctx.StringValue("ListDevopsScenarioFieldConfig.Object["+ i +"].Name");

				listDevopsScenarioFieldConfigResponse_object.Add(scenarioFieldConfig);
			}
			listDevopsScenarioFieldConfigResponse._Object = listDevopsScenarioFieldConfigResponse_object;
        
			return listDevopsScenarioFieldConfigResponse;
        }
    }
}
