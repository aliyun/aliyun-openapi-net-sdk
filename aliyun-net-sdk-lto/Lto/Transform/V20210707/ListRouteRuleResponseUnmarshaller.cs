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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class ListRouteRuleResponseUnmarshaller
    {
        public static ListRouteRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRouteRuleResponse listRouteRuleResponse = new ListRouteRuleResponse();

			listRouteRuleResponse.HttpResponse = _ctx.HttpResponse;
			listRouteRuleResponse.Code = _ctx.StringValue("ListRouteRule.Code");
			listRouteRuleResponse.HttpStatusCode = _ctx.IntegerValue("ListRouteRule.HttpStatusCode");
			listRouteRuleResponse.Message = _ctx.StringValue("ListRouteRule.Message");
			listRouteRuleResponse.RequestId = _ctx.StringValue("ListRouteRule.RequestId");
			listRouteRuleResponse.Success = _ctx.BooleanValue("ListRouteRule.Success");

			ListRouteRuleResponse.ListRouteRule_Data data = new ListRouteRuleResponse.ListRouteRule_Data();
			data.Num = _ctx.IntegerValue("ListRouteRule.Data.Num");
			data.Total = _ctx.IntegerValue("ListRouteRule.Data.Total");
			data.Size = _ctx.IntegerValue("ListRouteRule.Data.Size");

			List<ListRouteRuleResponse.ListRouteRule_Data.ListRouteRule_RouteRuleInfo> data_pageData = new List<ListRouteRuleResponse.ListRouteRule_Data.ListRouteRule_RouteRuleInfo>();
			for (int i = 0; i < _ctx.Length("ListRouteRule.Data.PageData.Length"); i++) {
				ListRouteRuleResponse.ListRouteRule_Data.ListRouteRule_RouteRuleInfo routeRuleInfo = new ListRouteRuleResponse.ListRouteRule_Data.ListRouteRule_RouteRuleInfo();
				routeRuleInfo.ContractName = _ctx.StringValue("ListRouteRule.Data.PageData["+ i +"].ContractName");
				routeRuleInfo.DeviceGroupId = _ctx.StringValue("ListRouteRule.Data.PageData["+ i +"].DeviceGroupId");
				routeRuleInfo.Remark = _ctx.StringValue("ListRouteRule.Data.PageData["+ i +"].Remark");
				routeRuleInfo.DeviceGroupName = _ctx.StringValue("ListRouteRule.Data.PageData["+ i +"].DeviceGroupName");
				routeRuleInfo.PrivacyRuleId = _ctx.StringValue("ListRouteRule.Data.PageData["+ i +"].PrivacyRuleId");
				routeRuleInfo.BizChainId = _ctx.LongValue("ListRouteRule.Data.PageData["+ i +"].BizChainId");
				routeRuleInfo.PrivacyRuleName = _ctx.StringValue("ListRouteRule.Data.PageData["+ i +"].PrivacyRuleName");
				routeRuleInfo.InvokeType = _ctx.StringValue("ListRouteRule.Data.PageData["+ i +"].InvokeType");
				routeRuleInfo.RouteRuleId = _ctx.StringValue("ListRouteRule.Data.PageData["+ i +"].RouteRuleId");
				routeRuleInfo.BizChainName = _ctx.StringValue("ListRouteRule.Data.PageData["+ i +"].BizChainName");
				routeRuleInfo.ContractTemplateId = _ctx.StringValue("ListRouteRule.Data.PageData["+ i +"].ContractTemplateId");
				routeRuleInfo.BlockChainType = _ctx.StringValue("ListRouteRule.Data.PageData["+ i +"].BlockChainType");
				routeRuleInfo.ChainUpMode = _ctx.StringValue("ListRouteRule.Data.PageData["+ i +"].ChainUpMode");

				data_pageData.Add(routeRuleInfo);
			}
			data.PageData = data_pageData;
			listRouteRuleResponse.Data = data;
        
			return listRouteRuleResponse;
        }
    }
}
