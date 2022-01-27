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
    public class CreateEnvHsfTrafficControlResponseUnmarshaller
    {
        public static CreateEnvHsfTrafficControlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateEnvHsfTrafficControlResponse createEnvHsfTrafficControlResponse = new CreateEnvHsfTrafficControlResponse();

			createEnvHsfTrafficControlResponse.HttpResponse = _ctx.HttpResponse;
			createEnvHsfTrafficControlResponse.RequestId = _ctx.StringValue("CreateEnvHsfTrafficControl.RequestId");
			createEnvHsfTrafficControlResponse.Code = _ctx.IntegerValue("CreateEnvHsfTrafficControl.Code");
			createEnvHsfTrafficControlResponse.Message = _ctx.StringValue("CreateEnvHsfTrafficControl.Message");

			CreateEnvHsfTrafficControlResponse.CreateEnvHsfTrafficControl_Data data = new CreateEnvHsfTrafficControlResponse.CreateEnvHsfTrafficControl_Data();
			data.AppId = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.AppId");
			data.LabelAdviceId = _ctx.LongValue("CreateEnvHsfTrafficControl.Data.LabelAdviceId");
			data.Kind = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.Kind");
			data.LabelType = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.LabelType");
			data.PointcutId = _ctx.LongValue("CreateEnvHsfTrafficControl.Data.PointcutId");
			data.RegionId = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.RegionId");

			CreateEnvHsfTrafficControlResponse.CreateEnvHsfTrafficControl_Data.CreateEnvHsfTrafficControl_Metadata metadata = new CreateEnvHsfTrafficControlResponse.CreateEnvHsfTrafficControl_Data.CreateEnvHsfTrafficControl_Metadata();
			metadata.Name = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.Metadata.Name");
			metadata._Namespace = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.Metadata.Namespace");
			metadata.Labels = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.Metadata.Labels");

			CreateEnvHsfTrafficControlResponse.CreateEnvHsfTrafficControl_Data.CreateEnvHsfTrafficControl_Metadata.CreateEnvHsfTrafficControl_Spec spec = new CreateEnvHsfTrafficControlResponse.CreateEnvHsfTrafficControl_Data.CreateEnvHsfTrafficControl_Metadata.CreateEnvHsfTrafficControl_Spec();
			spec.ConditionType = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.ConditionType");
			spec.Enable = _ctx.BooleanValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.Enable");
			spec.Group = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.Group");
			spec.MethodName = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.MethodName");
			spec.Order = _ctx.LongValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.Order");
			spec.Percent = _ctx.IntegerValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.Percent");
			spec.ServiceName = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.ServiceName");
			spec.TriggerPolicy = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.TriggerPolicy");
			spec.Type = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.Type");
			spec.Selector = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.Selector");

			List<string> spec_paramTypes = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateEnvHsfTrafficControl.Data.Metadata.Spec.ParamTypes.Length"); i++) {
				spec_paramTypes.Add(_ctx.StringValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.ParamTypes["+ i +"]"));
			}
			spec.ParamTypes = spec_paramTypes;

			List<CreateEnvHsfTrafficControlResponse.CreateEnvHsfTrafficControl_Data.CreateEnvHsfTrafficControl_Metadata.CreateEnvHsfTrafficControl_Spec.CreateEnvHsfTrafficControl_PurposesItem> spec_purposes = new List<CreateEnvHsfTrafficControlResponse.CreateEnvHsfTrafficControl_Data.CreateEnvHsfTrafficControl_Metadata.CreateEnvHsfTrafficControl_Spec.CreateEnvHsfTrafficControl_PurposesItem>();
			for (int i = 0; i < _ctx.Length("CreateEnvHsfTrafficControl.Data.Metadata.Spec.Purposes.Length"); i++) {
				CreateEnvHsfTrafficControlResponse.CreateEnvHsfTrafficControl_Data.CreateEnvHsfTrafficControl_Metadata.CreateEnvHsfTrafficControl_Spec.CreateEnvHsfTrafficControl_PurposesItem purposesItem = new CreateEnvHsfTrafficControlResponse.CreateEnvHsfTrafficControl_Data.CreateEnvHsfTrafficControl_Metadata.CreateEnvHsfTrafficControl_Spec.CreateEnvHsfTrafficControl_PurposesItem();
				purposesItem.Type = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.Purposes["+ i +"].Type");

				spec_purposes.Add(purposesItem);
			}
			spec.Purposes = spec_purposes;

			List<CreateEnvHsfTrafficControlResponse.CreateEnvHsfTrafficControl_Data.CreateEnvHsfTrafficControl_Metadata.CreateEnvHsfTrafficControl_Spec.CreateEnvHsfTrafficControl_ConditionsItem> spec_conditions = new List<CreateEnvHsfTrafficControlResponse.CreateEnvHsfTrafficControl_Data.CreateEnvHsfTrafficControl_Metadata.CreateEnvHsfTrafficControl_Spec.CreateEnvHsfTrafficControl_ConditionsItem>();
			for (int i = 0; i < _ctx.Length("CreateEnvHsfTrafficControl.Data.Metadata.Spec.Conditions.Length"); i++) {
				CreateEnvHsfTrafficControlResponse.CreateEnvHsfTrafficControl_Data.CreateEnvHsfTrafficControl_Metadata.CreateEnvHsfTrafficControl_Spec.CreateEnvHsfTrafficControl_ConditionsItem conditionsItem = new CreateEnvHsfTrafficControlResponse.CreateEnvHsfTrafficControl_Data.CreateEnvHsfTrafficControl_Metadata.CreateEnvHsfTrafficControl_Spec.CreateEnvHsfTrafficControl_ConditionsItem();
				conditionsItem.Id = _ctx.LongValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.Conditions["+ i +"].Id");
				conditionsItem.Strategy = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.Conditions["+ i +"].Strategy");
				conditionsItem.Type = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.Conditions["+ i +"].Type");
				conditionsItem.Index = _ctx.IntegerValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.Conditions["+ i +"].Index");
				conditionsItem.Key = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.Conditions["+ i +"].Key");
				conditionsItem._Operator = _ctx.StringValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.Conditions["+ i +"].Operator");

				List<string> conditionsItem_values = new List<string>();
				for (int j = 0; j < _ctx.Length("CreateEnvHsfTrafficControl.Data.Metadata.Spec.Conditions["+ i +"].Values.Length"); j++) {
					conditionsItem_values.Add(_ctx.StringValue("CreateEnvHsfTrafficControl.Data.Metadata.Spec.Conditions["+ i +"].Values["+ j +"]"));
				}
				conditionsItem.Values = conditionsItem_values;

				spec_conditions.Add(conditionsItem);
			}
			spec.Conditions = spec_conditions;
			metadata.Spec = spec;
			data.Metadata = metadata;
			createEnvHsfTrafficControlResponse.Data = data;
        
			return createEnvHsfTrafficControlResponse;
        }
    }
}
