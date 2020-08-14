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
using Aliyun.Acs.teambition_aliyun.Model.V20200226;

namespace Aliyun.Acs.teambition_aliyun.Transform.V20200226
{
    public class ListScenarioFieldConfigResponseUnmarshaller
    {
        public static ListScenarioFieldConfigResponse Unmarshall(UnmarshallerContext context)
        {
			ListScenarioFieldConfigResponse listScenarioFieldConfigResponse = new ListScenarioFieldConfigResponse();

			listScenarioFieldConfigResponse.HttpResponse = context.HttpResponse;
			listScenarioFieldConfigResponse.Successful = context.BooleanValue("ListScenarioFieldConfig.Successful");
			listScenarioFieldConfigResponse.ErrorCode = context.StringValue("ListScenarioFieldConfig.ErrorCode");
			listScenarioFieldConfigResponse.ErrorMsg = context.StringValue("ListScenarioFieldConfig.ErrorMsg");
			listScenarioFieldConfigResponse.RequestId = context.StringValue("ListScenarioFieldConfig.RequestId");

			List<ListScenarioFieldConfigResponse.ListScenarioFieldConfig_ScenarioFieldConfig> listScenarioFieldConfigResponse_object = new List<ListScenarioFieldConfigResponse.ListScenarioFieldConfig_ScenarioFieldConfig>();
			for (int i = 0; i < context.Length("ListScenarioFieldConfig.Object.Length"); i++) {
				ListScenarioFieldConfigResponse.ListScenarioFieldConfig_ScenarioFieldConfig scenarioFieldConfig = new ListScenarioFieldConfigResponse.ListScenarioFieldConfig_ScenarioFieldConfig();
				scenarioFieldConfig.Id = context.StringValue("ListScenarioFieldConfig.Object["+ i +"].Id");
				scenarioFieldConfig.Type = context.StringValue("ListScenarioFieldConfig.Object["+ i +"].Type");

				listScenarioFieldConfigResponse_object.Add(scenarioFieldConfig);
			}
			listScenarioFieldConfigResponse._Object = listScenarioFieldConfigResponse_object;
        
			return listScenarioFieldConfigResponse;
        }
    }
}
