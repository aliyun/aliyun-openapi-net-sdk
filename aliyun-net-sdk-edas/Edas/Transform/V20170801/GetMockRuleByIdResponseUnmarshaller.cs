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
    public class GetMockRuleByIdResponseUnmarshaller
    {
        public static GetMockRuleByIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMockRuleByIdResponse getMockRuleByIdResponse = new GetMockRuleByIdResponse();

			getMockRuleByIdResponse.HttpResponse = _ctx.HttpResponse;
			getMockRuleByIdResponse.Code = _ctx.StringValue("GetMockRuleById.Code");
			getMockRuleByIdResponse.Message = _ctx.StringValue("GetMockRuleById.Message");
			getMockRuleByIdResponse.RequestId = _ctx.StringValue("GetMockRuleById.RequestId");
			getMockRuleByIdResponse.Success = _ctx.BooleanValue("GetMockRuleById.Success");

			GetMockRuleByIdResponse.GetMockRuleById_Data data = new GetMockRuleByIdResponse.GetMockRuleById_Data();
			data.AccountId = _ctx.StringValue("GetMockRuleById.Data.AccountId");
			data.Name = _ctx.StringValue("GetMockRuleById.Data.Name");
			data.ConsumerAppId = _ctx.StringValue("GetMockRuleById.Data.ConsumerAppId");
			data.ConsumerAppName = _ctx.StringValue("GetMockRuleById.Data.ConsumerAppName");
			data.Enable = _ctx.BooleanValue("GetMockRuleById.Data.Enable");
			data.ExtraJson = _ctx.StringValue("GetMockRuleById.Data.ExtraJson");
			data.Id = _ctx.LongValue("GetMockRuleById.Data.Id");
			data.ProviderAppId = _ctx.StringValue("GetMockRuleById.Data.ProviderAppId");
			data.ProviderAppName = _ctx.StringValue("GetMockRuleById.Data.ProviderAppName");
			data.Region = _ctx.StringValue("GetMockRuleById.Data.Region");
			data.Source = _ctx.StringValue("GetMockRuleById.Data.Source");

			List<GetMockRuleByIdResponse.GetMockRuleById_Data.GetMockRuleById_SpringCloudMockItem> data_scMockItems = new List<GetMockRuleByIdResponse.GetMockRuleById_Data.GetMockRuleById_SpringCloudMockItem>();
			for (int i = 0; i < _ctx.Length("GetMockRuleById.Data.ScMockItems.Length"); i++) {
				GetMockRuleByIdResponse.GetMockRuleById_Data.GetMockRuleById_SpringCloudMockItem springCloudMockItem = new GetMockRuleByIdResponse.GetMockRuleById_Data.GetMockRuleById_SpringCloudMockItem();
				springCloudMockItem.ExceptionClassName = _ctx.StringValue("GetMockRuleById.Data.ScMockItems["+ i +"].ExceptionClassName");
				springCloudMockItem.ExecuteCondition = _ctx.StringValue("GetMockRuleById.Data.ScMockItems["+ i +"].ExecuteCondition");
				springCloudMockItem.Method = _ctx.StringValue("GetMockRuleById.Data.ScMockItems["+ i +"].Method");
				springCloudMockItem.Oper = _ctx.StringValue("GetMockRuleById.Data.ScMockItems["+ i +"].Oper");
				springCloudMockItem.Path = _ctx.StringValue("GetMockRuleById.Data.ScMockItems["+ i +"].Path");
				springCloudMockItem.ServiceName = _ctx.StringValue("GetMockRuleById.Data.ScMockItems["+ i +"].ServiceName");
				springCloudMockItem._Value = _ctx.StringValue("GetMockRuleById.Data.ScMockItems["+ i +"].Value");

				data_scMockItems.Add(springCloudMockItem);
			}
			data.ScMockItems = data_scMockItems;

			List<GetMockRuleByIdResponse.GetMockRuleById_Data.GetMockRuleById_DubboMockItem> data_dubboMockItems = new List<GetMockRuleByIdResponse.GetMockRuleById_Data.GetMockRuleById_DubboMockItem>();
			for (int i = 0; i < _ctx.Length("GetMockRuleById.Data.DubboMockItems.Length"); i++) {
				GetMockRuleByIdResponse.GetMockRuleById_Data.GetMockRuleById_DubboMockItem dubboMockItem = new GetMockRuleByIdResponse.GetMockRuleById_Data.GetMockRuleById_DubboMockItem();
				dubboMockItem.ExceptionClassName = _ctx.StringValue("GetMockRuleById.Data.DubboMockItems["+ i +"].ExceptionClassName");
				dubboMockItem.ExecuteCondition = _ctx.StringValue("GetMockRuleById.Data.DubboMockItems["+ i +"].ExecuteCondition");
				dubboMockItem.MethodName = _ctx.StringValue("GetMockRuleById.Data.DubboMockItems["+ i +"].MethodName");
				dubboMockItem.Oper = _ctx.StringValue("GetMockRuleById.Data.DubboMockItems["+ i +"].Oper");
				dubboMockItem.Path = _ctx.StringValue("GetMockRuleById.Data.DubboMockItems["+ i +"].Path");
				dubboMockItem.ServiceName = _ctx.StringValue("GetMockRuleById.Data.DubboMockItems["+ i +"].ServiceName");
				dubboMockItem._Value = _ctx.StringValue("GetMockRuleById.Data.DubboMockItems["+ i +"].Value");
				dubboMockItem.Version = _ctx.StringValue("GetMockRuleById.Data.DubboMockItems["+ i +"].Version");
				dubboMockItem.Group = _ctx.StringValue("GetMockRuleById.Data.DubboMockItems["+ i +"].Group");
				dubboMockItem.ParamTypes = _ctx.StringValue("GetMockRuleById.Data.DubboMockItems["+ i +"].ParamTypes");
				dubboMockItem.ExceptionMessage = _ctx.StringValue("GetMockRuleById.Data.DubboMockItems["+ i +"].ExceptionMessage");

				data_dubboMockItems.Add(dubboMockItem);
			}
			data.DubboMockItems = data_dubboMockItems;
			getMockRuleByIdResponse.Data = data;
        
			return getMockRuleByIdResponse;
        }
    }
}
