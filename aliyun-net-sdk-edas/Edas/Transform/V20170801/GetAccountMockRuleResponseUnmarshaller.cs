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
    public class GetAccountMockRuleResponseUnmarshaller
    {
        public static GetAccountMockRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAccountMockRuleResponse getAccountMockRuleResponse = new GetAccountMockRuleResponse();

			getAccountMockRuleResponse.HttpResponse = _ctx.HttpResponse;
			getAccountMockRuleResponse.Code = _ctx.StringValue("GetAccountMockRule.Code");
			getAccountMockRuleResponse.Message = _ctx.StringValue("GetAccountMockRule.Message");
			getAccountMockRuleResponse.Success = _ctx.BooleanValue("GetAccountMockRule.Success");

			GetAccountMockRuleResponse.GetAccountMockRule_Data data = new GetAccountMockRuleResponse.GetAccountMockRule_Data();
			data.PageNumber = _ctx.IntegerValue("GetAccountMockRule.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("GetAccountMockRule.Data.PageSize");
			data.TotalSize = _ctx.IntegerValue("GetAccountMockRule.Data.TotalSize");

			List<GetAccountMockRuleResponse.GetAccountMockRule_Data.GetAccountMockRule_MseMockRules> data_result = new List<GetAccountMockRuleResponse.GetAccountMockRule_Data.GetAccountMockRule_MseMockRules>();
			for (int i = 0; i < _ctx.Length("GetAccountMockRule.Data.Result.Length"); i++) {
				GetAccountMockRuleResponse.GetAccountMockRule_Data.GetAccountMockRule_MseMockRules mseMockRules = new GetAccountMockRuleResponse.GetAccountMockRule_Data.GetAccountMockRule_MseMockRules();
				mseMockRules.Id = _ctx.IntegerValue("GetAccountMockRule.Data.Result["+ i +"].Id");
				mseMockRules.Name = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].Name");
				mseMockRules.Region = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].Region");
				mseMockRules.Enable = _ctx.BooleanValue("GetAccountMockRule.Data.Result["+ i +"].Enable");
				mseMockRules.Status = _ctx.IntegerValue("GetAccountMockRule.Data.Result["+ i +"].Status");
				mseMockRules.ProviderAppId = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].ProviderAppId");
				mseMockRules.ProviderAppName = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].ProviderAppName");
				mseMockRules.ConsumerAppId = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].ConsumerAppId");
				mseMockRules.ConsumerAppName = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].ConsumerAppName");
				mseMockRules.GmtCreate = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].GmtCreate");
				mseMockRules.GmtModified = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].GmtModified");

				List<GetAccountMockRuleResponse.GetAccountMockRule_Data.GetAccountMockRule_MseMockRules.GetAccountMockRule_DubboMockItem> mseMockRules_dubboMockItems = new List<GetAccountMockRuleResponse.GetAccountMockRule_Data.GetAccountMockRule_MseMockRules.GetAccountMockRule_DubboMockItem>();
				for (int j = 0; j < _ctx.Length("GetAccountMockRule.Data.Result["+ i +"].DubboMockItems.Length"); j++) {
					GetAccountMockRuleResponse.GetAccountMockRule_Data.GetAccountMockRule_MseMockRules.GetAccountMockRule_DubboMockItem dubboMockItem = new GetAccountMockRuleResponse.GetAccountMockRule_Data.GetAccountMockRule_MseMockRules.GetAccountMockRule_DubboMockItem();
					dubboMockItem.MethodName = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].DubboMockItems["+ j +"].MethodName");
					dubboMockItem.Oper = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].DubboMockItems["+ j +"].Oper");
					dubboMockItem.ExceptionClassName = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].DubboMockItems["+ j +"].ExceptionClassName");
					dubboMockItem.ServiceName = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].DubboMockItems["+ j +"].ServiceName");
					dubboMockItem._Value = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].DubboMockItems["+ j +"].Value");
					dubboMockItem.Version = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].DubboMockItems["+ j +"].Version");
					dubboMockItem.ExecuteCondition = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].DubboMockItems["+ j +"].ExecuteCondition");
					dubboMockItem.Group = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].DubboMockItems["+ j +"].Group");

					List<string> dubboMockItem_paramTypes = new List<string>();
					for (int k = 0; k < _ctx.Length("GetAccountMockRule.Data.Result["+ i +"].DubboMockItems["+ j +"].ParamTypes.Length"); k++) {
						dubboMockItem_paramTypes.Add(_ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].DubboMockItems["+ j +"].ParamTypes["+ k +"]"));
					}
					dubboMockItem.ParamTypes = dubboMockItem_paramTypes;

					mseMockRules_dubboMockItems.Add(dubboMockItem);
				}
				mseMockRules.DubboMockItems = mseMockRules_dubboMockItems;

				List<GetAccountMockRuleResponse.GetAccountMockRule_Data.GetAccountMockRule_MseMockRules.GetAccountMockRule_SpringCloudMockItem> mseMockRules_scMockItems = new List<GetAccountMockRuleResponse.GetAccountMockRule_Data.GetAccountMockRule_MseMockRules.GetAccountMockRule_SpringCloudMockItem>();
				for (int j = 0; j < _ctx.Length("GetAccountMockRule.Data.Result["+ i +"].ScMockItems.Length"); j++) {
					GetAccountMockRuleResponse.GetAccountMockRule_Data.GetAccountMockRule_MseMockRules.GetAccountMockRule_SpringCloudMockItem springCloudMockItem = new GetAccountMockRuleResponse.GetAccountMockRule_Data.GetAccountMockRule_MseMockRules.GetAccountMockRule_SpringCloudMockItem();
					springCloudMockItem.ExceptionClassName = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].ScMockItems["+ j +"].ExceptionClassName");
					springCloudMockItem.ExecuteCondition = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].ScMockItems["+ j +"].ExecuteCondition");
					springCloudMockItem.Method = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].ScMockItems["+ j +"].Method");
					springCloudMockItem.Oper = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].ScMockItems["+ j +"].Oper");
					springCloudMockItem.Path = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].ScMockItems["+ j +"].Path");
					springCloudMockItem.ServiceName = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].ScMockItems["+ j +"].ServiceName");
					springCloudMockItem._Value = _ctx.StringValue("GetAccountMockRule.Data.Result["+ i +"].ScMockItems["+ j +"].Value");

					mseMockRules_scMockItems.Add(springCloudMockItem);
				}
				mseMockRules.ScMockItems = mseMockRules_scMockItems;

				data_result.Add(mseMockRules);
			}
			data.Result = data_result;
			getAccountMockRuleResponse.Data = data;
        
			return getAccountMockRuleResponse;
        }
    }
}
