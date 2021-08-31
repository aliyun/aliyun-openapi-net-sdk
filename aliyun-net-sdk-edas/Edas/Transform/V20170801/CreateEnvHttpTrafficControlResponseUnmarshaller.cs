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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class CreateEnvHttpTrafficControlResponseUnmarshaller
    {
        public static CreateEnvHttpTrafficControlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateEnvHttpTrafficControlResponse createEnvHttpTrafficControlResponse = new CreateEnvHttpTrafficControlResponse();

			createEnvHttpTrafficControlResponse.HttpResponse = _ctx.HttpResponse;
			createEnvHttpTrafficControlResponse.RequestId = _ctx.StringValue("CreateEnvHttpTrafficControl.RequestId");
			createEnvHttpTrafficControlResponse.Code = _ctx.IntegerValue("CreateEnvHttpTrafficControl.Code");
			createEnvHttpTrafficControlResponse.Message = _ctx.StringValue("CreateEnvHttpTrafficControl.Message");

			CreateEnvHttpTrafficControlResponse.CreateEnvHttpTrafficControl_Data data = new CreateEnvHttpTrafficControlResponse.CreateEnvHttpTrafficControl_Data();
			data.AccountId = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.AccountId");
			data.AppId = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.AppId");
			data.EnvName = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.EnvName");
			data.LabelAdviceId = _ctx.LongValue("CreateEnvHttpTrafficControl.Data.LabelAdviceId");
			data.LabelType = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.LabelType");
			data.PointcutId = _ctx.LongValue("CreateEnvHttpTrafficControl.Data.PointcutId");
			data.RegionId = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.RegionId");
			data.TenantId = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.TenantId");

			CreateEnvHttpTrafficControlResponse.CreateEnvHttpTrafficControl_Data.CreateEnvHttpTrafficControl_Spec spec = new CreateEnvHttpTrafficControlResponse.CreateEnvHttpTrafficControl_Data.CreateEnvHttpTrafficControl_Spec();
			spec.ConditionType = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.Spec.ConditionType");
			spec.Order = _ctx.LongValue("CreateEnvHttpTrafficControl.Data.Spec.Order");
			spec.Percent = _ctx.IntegerValue("CreateEnvHttpTrafficControl.Data.Spec.Percent");
			spec.TriggerPolicy = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.Spec.TriggerPolicy");
			spec.Type = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.Spec.Type");
			spec.Url = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.Spec.Url");
			spec.Selector = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.Spec.Selector");
			spec.ServiceName = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.Spec.ServiceName");
			spec.Group = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.Spec.Group");
			spec.Version = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.Spec.Version");
			spec.MethodName = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.Spec.MethodName");
			spec.ClassName = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.Spec.ClassName");
			spec.TransmitSwitch = _ctx.BooleanValue("CreateEnvHttpTrafficControl.Data.Spec.TransmitSwitch");
			spec.TransmitLevel = _ctx.IntegerValue("CreateEnvHttpTrafficControl.Data.Spec.TransmitLevel");

			List<string> spec_paramTypes = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateEnvHttpTrafficControl.Data.Spec.ParamTypes.Length"); i++) {
				spec_paramTypes.Add(_ctx.StringValue("CreateEnvHttpTrafficControl.Data.Spec.ParamTypes["+ i +"]"));
			}
			spec.ParamTypes = spec_paramTypes;

			List<CreateEnvHttpTrafficControlResponse.CreateEnvHttpTrafficControl_Data.CreateEnvHttpTrafficControl_Spec.CreateEnvHttpTrafficControl_ConditionsItem> spec_conditions = new List<CreateEnvHttpTrafficControlResponse.CreateEnvHttpTrafficControl_Data.CreateEnvHttpTrafficControl_Spec.CreateEnvHttpTrafficControl_ConditionsItem>();
			for (int i = 0; i < _ctx.Length("CreateEnvHttpTrafficControl.Data.Spec.Conditions.Length"); i++) {
				CreateEnvHttpTrafficControlResponse.CreateEnvHttpTrafficControl_Data.CreateEnvHttpTrafficControl_Spec.CreateEnvHttpTrafficControl_ConditionsItem conditionsItem = new CreateEnvHttpTrafficControlResponse.CreateEnvHttpTrafficControl_Data.CreateEnvHttpTrafficControl_Spec.CreateEnvHttpTrafficControl_ConditionsItem();
				conditionsItem.Id = _ctx.LongValue("CreateEnvHttpTrafficControl.Data.Spec.Conditions["+ i +"].Id");
				conditionsItem.Strategy = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.Spec.Conditions["+ i +"].Strategy");
				conditionsItem.Type = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.Spec.Conditions["+ i +"].Type");
				conditionsItem.Index = _ctx.IntegerValue("CreateEnvHttpTrafficControl.Data.Spec.Conditions["+ i +"].Index");
				conditionsItem.Key = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.Spec.Conditions["+ i +"].Key");
				conditionsItem._Operator = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.Spec.Conditions["+ i +"].Operator");

				List<string> conditionsItem_values = new List<string>();
				for (int j = 0; j < _ctx.Length("CreateEnvHttpTrafficControl.Data.Spec.Conditions["+ i +"].Values.Length"); j++) {
					conditionsItem_values.Add(_ctx.StringValue("CreateEnvHttpTrafficControl.Data.Spec.Conditions["+ i +"].Values["+ j +"]"));
				}
				conditionsItem.Values = conditionsItem_values;

				spec_conditions.Add(conditionsItem);
			}
			spec.Conditions = spec_conditions;

			List<CreateEnvHttpTrafficControlResponse.CreateEnvHttpTrafficControl_Data.CreateEnvHttpTrafficControl_Spec.CreateEnvHttpTrafficControl_PurposesItem> spec_purposes = new List<CreateEnvHttpTrafficControlResponse.CreateEnvHttpTrafficControl_Data.CreateEnvHttpTrafficControl_Spec.CreateEnvHttpTrafficControl_PurposesItem>();
			for (int i = 0; i < _ctx.Length("CreateEnvHttpTrafficControl.Data.Spec.Purposes.Length"); i++) {
				CreateEnvHttpTrafficControlResponse.CreateEnvHttpTrafficControl_Data.CreateEnvHttpTrafficControl_Spec.CreateEnvHttpTrafficControl_PurposesItem purposesItem = new CreateEnvHttpTrafficControlResponse.CreateEnvHttpTrafficControl_Data.CreateEnvHttpTrafficControl_Spec.CreateEnvHttpTrafficControl_PurposesItem();
				purposesItem.Type = _ctx.StringValue("CreateEnvHttpTrafficControl.Data.Spec.Purposes["+ i +"].Type");

				spec_purposes.Add(purposesItem);
			}
			spec.Purposes = spec_purposes;
			data.Spec = spec;
			createEnvHttpTrafficControlResponse.Data = data;
        
			return createEnvHttpTrafficControlResponse;
        }
    }
}
