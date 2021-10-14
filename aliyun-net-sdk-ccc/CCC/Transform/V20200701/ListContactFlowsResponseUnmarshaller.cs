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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ListContactFlowsResponseUnmarshaller
    {
        public static ListContactFlowsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListContactFlowsResponse listContactFlowsResponse = new ListContactFlowsResponse();

			listContactFlowsResponse.HttpResponse = _ctx.HttpResponse;
			listContactFlowsResponse.Code = _ctx.StringValue("ListContactFlows.Code");
			listContactFlowsResponse.HttpStatusCode = _ctx.IntegerValue("ListContactFlows.HttpStatusCode");
			listContactFlowsResponse.Message = _ctx.StringValue("ListContactFlows.Message");
			listContactFlowsResponse.RequestId = _ctx.StringValue("ListContactFlows.RequestId");

			ListContactFlowsResponse.ListContactFlows_Data data = new ListContactFlowsResponse.ListContactFlows_Data();
			data.PageNumber = _ctx.IntegerValue("ListContactFlows.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListContactFlows.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListContactFlows.Data.TotalCount");

			List<ListContactFlowsResponse.ListContactFlows_Data.ListContactFlows_ContactFlow> data_list = new List<ListContactFlowsResponse.ListContactFlows_Data.ListContactFlows_ContactFlow>();
			for (int i = 0; i < _ctx.Length("ListContactFlows.Data.List.Length"); i++) {
				ListContactFlowsResponse.ListContactFlows_Data.ListContactFlows_ContactFlow contactFlow = new ListContactFlowsResponse.ListContactFlows_Data.ListContactFlows_ContactFlow();
				contactFlow.ContactFlowId = _ctx.StringValue("ListContactFlows.Data.List["+ i +"].ContactFlowId");
				contactFlow.CreatedTime = _ctx.StringValue("ListContactFlows.Data.List["+ i +"].CreatedTime");
				contactFlow.Definition = _ctx.StringValue("ListContactFlows.Data.List["+ i +"].Definition");
				contactFlow.Description = _ctx.StringValue("ListContactFlows.Data.List["+ i +"].Description");
				contactFlow.DraftId = _ctx.StringValue("ListContactFlows.Data.List["+ i +"].DraftId");
				contactFlow.Editor = _ctx.StringValue("ListContactFlows.Data.List["+ i +"].Editor");
				contactFlow.InstanceId = _ctx.StringValue("ListContactFlows.Data.List["+ i +"].InstanceId");
				contactFlow.Name = _ctx.StringValue("ListContactFlows.Data.List["+ i +"].Name");
				contactFlow.Published = _ctx.BooleanValue("ListContactFlows.Data.List["+ i +"].Published");
				contactFlow.Type = _ctx.StringValue("ListContactFlows.Data.List["+ i +"].Type");
				contactFlow.UpdatedTime = _ctx.StringValue("ListContactFlows.Data.List["+ i +"].UpdatedTime");

				List<string> contactFlow_numberList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListContactFlows.Data.List["+ i +"].NumberList.Length"); j++) {
					contactFlow_numberList.Add(_ctx.StringValue("ListContactFlows.Data.List["+ i +"].NumberList["+ j +"]"));
				}
				contactFlow.NumberList = contactFlow_numberList;

				data_list.Add(contactFlow);
			}
			data.List = data_list;
			listContactFlowsResponse.Data = data;
        
			return listContactFlowsResponse;
        }
    }
}
