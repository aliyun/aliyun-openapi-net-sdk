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
    public class GetEnvTrafficControlResponseUnmarshaller
    {
        public static GetEnvTrafficControlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetEnvTrafficControlResponse getEnvTrafficControlResponse = new GetEnvTrafficControlResponse();

			getEnvTrafficControlResponse.HttpResponse = _ctx.HttpResponse;
			getEnvTrafficControlResponse.RequestId = _ctx.StringValue("GetEnvTrafficControl.RequestId");
			getEnvTrafficControlResponse.Code = _ctx.IntegerValue("GetEnvTrafficControl.Code");
			getEnvTrafficControlResponse.Message = _ctx.StringValue("GetEnvTrafficControl.Message");

			List<GetEnvTrafficControlResponse.GetEnvTrafficControl_DataItem> getEnvTrafficControlResponse_data = new List<GetEnvTrafficControlResponse.GetEnvTrafficControl_DataItem>();
			for (int i = 0; i < _ctx.Length("GetEnvTrafficControl.Data.Length"); i++) {
				GetEnvTrafficControlResponse.GetEnvTrafficControl_DataItem dataItem = new GetEnvTrafficControlResponse.GetEnvTrafficControl_DataItem();
				dataItem.Kind = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Kind");
				dataItem.AppId = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].AppId");
				dataItem.EnvName = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].EnvName");
				dataItem.Id = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Id");
				dataItem.LabelAdviceId = _ctx.LongValue("GetEnvTrafficControl.Data["+ i +"].LabelAdviceId");
				dataItem.LabelType = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].LabelType");
				dataItem.PointcutId = _ctx.LongValue("GetEnvTrafficControl.Data["+ i +"].PointcutId");
				dataItem.RegionId = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].RegionId");

				GetEnvTrafficControlResponse.GetEnvTrafficControl_DataItem.GetEnvTrafficControl_Metadata metadata = new GetEnvTrafficControlResponse.GetEnvTrafficControl_DataItem.GetEnvTrafficControl_Metadata();
				metadata.Name = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Metadata.Name");
				metadata._Namespace = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Metadata.Namespace");
				metadata.Labels = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Metadata.Labels");
				dataItem.Metadata = metadata;

				GetEnvTrafficControlResponse.GetEnvTrafficControl_DataItem.GetEnvTrafficControl_Spec spec = new GetEnvTrafficControlResponse.GetEnvTrafficControl_DataItem.GetEnvTrafficControl_Spec();
				spec.ShowName = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.ShowName");
				spec.Enable = _ctx.BooleanValue("GetEnvTrafficControl.Data["+ i +"].Spec.Enable");
				spec.ConditionType = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.ConditionType");
				spec.Selector = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.Selector");
				spec.TriggerPolicy = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.TriggerPolicy");
				spec.Type = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.Type");
				spec.Url = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.Url");
				spec.ServiceName = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.ServiceName");
				spec.Group = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.Group");
				spec.Version = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.Version");
				spec.MethodName = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.MethodName");
				spec.ClassName = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.ClassName");
				spec.TransmitSwitch = _ctx.BooleanValue("GetEnvTrafficControl.Data["+ i +"].Spec.TransmitSwitch");
				spec.TransmitLevel = _ctx.IntegerValue("GetEnvTrafficControl.Data["+ i +"].Spec.TransmitLevel");
				spec.Percent = _ctx.IntegerValue("GetEnvTrafficControl.Data["+ i +"].Spec.Percent");
				spec.Order = _ctx.LongValue("GetEnvTrafficControl.Data["+ i +"].Spec.Order");

				List<string> spec_paramTypes = new List<string>();
				for (int j = 0; j < _ctx.Length("GetEnvTrafficControl.Data["+ i +"].Spec.ParamTypes.Length"); j++) {
					spec_paramTypes.Add(_ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.ParamTypes["+ j +"]"));
				}
				spec.ParamTypes = spec_paramTypes;

				List<GetEnvTrafficControlResponse.GetEnvTrafficControl_DataItem.GetEnvTrafficControl_Spec.GetEnvTrafficControl_PurposesItem> spec_purposes = new List<GetEnvTrafficControlResponse.GetEnvTrafficControl_DataItem.GetEnvTrafficControl_Spec.GetEnvTrafficControl_PurposesItem>();
				for (int j = 0; j < _ctx.Length("GetEnvTrafficControl.Data["+ i +"].Spec.Purposes.Length"); j++) {
					GetEnvTrafficControlResponse.GetEnvTrafficControl_DataItem.GetEnvTrafficControl_Spec.GetEnvTrafficControl_PurposesItem purposesItem = new GetEnvTrafficControlResponse.GetEnvTrafficControl_DataItem.GetEnvTrafficControl_Spec.GetEnvTrafficControl_PurposesItem();
					purposesItem.Type = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.Purposes["+ j +"].Type");

					spec_purposes.Add(purposesItem);
				}
				spec.Purposes = spec_purposes;

				List<GetEnvTrafficControlResponse.GetEnvTrafficControl_DataItem.GetEnvTrafficControl_Spec.GetEnvTrafficControl_ConditionsItem> spec_conditions = new List<GetEnvTrafficControlResponse.GetEnvTrafficControl_DataItem.GetEnvTrafficControl_Spec.GetEnvTrafficControl_ConditionsItem>();
				for (int j = 0; j < _ctx.Length("GetEnvTrafficControl.Data["+ i +"].Spec.Conditions.Length"); j++) {
					GetEnvTrafficControlResponse.GetEnvTrafficControl_DataItem.GetEnvTrafficControl_Spec.GetEnvTrafficControl_ConditionsItem conditionsItem = new GetEnvTrafficControlResponse.GetEnvTrafficControl_DataItem.GetEnvTrafficControl_Spec.GetEnvTrafficControl_ConditionsItem();
					conditionsItem.Id = _ctx.LongValue("GetEnvTrafficControl.Data["+ i +"].Spec.Conditions["+ j +"].Id");
					conditionsItem.Strategy = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.Conditions["+ j +"].Strategy");
					conditionsItem.Type = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.Conditions["+ j +"].Type");
					conditionsItem.Index = _ctx.IntegerValue("GetEnvTrafficControl.Data["+ i +"].Spec.Conditions["+ j +"].Index");
					conditionsItem.Key = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.Conditions["+ j +"].Key");
					conditionsItem._Operator = _ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.Conditions["+ j +"].Operator");

					List<string> conditionsItem_values = new List<string>();
					for (int k = 0; k < _ctx.Length("GetEnvTrafficControl.Data["+ i +"].Spec.Conditions["+ j +"].Values.Length"); k++) {
						conditionsItem_values.Add(_ctx.StringValue("GetEnvTrafficControl.Data["+ i +"].Spec.Conditions["+ j +"].Values["+ k +"]"));
					}
					conditionsItem.Values = conditionsItem_values;

					spec_conditions.Add(conditionsItem);
				}
				spec.Conditions = spec_conditions;
				dataItem.Spec = spec;

				getEnvTrafficControlResponse_data.Add(dataItem);
			}
			getEnvTrafficControlResponse.Data = getEnvTrafficControlResponse_data;
        
			return getEnvTrafficControlResponse;
        }
    }
}
