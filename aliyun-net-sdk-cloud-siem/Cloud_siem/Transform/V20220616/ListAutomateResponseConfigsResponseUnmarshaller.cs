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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class ListAutomateResponseConfigsResponseUnmarshaller
    {
        public static ListAutomateResponseConfigsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAutomateResponseConfigsResponse listAutomateResponseConfigsResponse = new ListAutomateResponseConfigsResponse();

			listAutomateResponseConfigsResponse.HttpResponse = _ctx.HttpResponse;
			listAutomateResponseConfigsResponse.Success = _ctx.BooleanValue("ListAutomateResponseConfigs.Success");
			listAutomateResponseConfigsResponse.Code = _ctx.IntegerValue("ListAutomateResponseConfigs.Code");
			listAutomateResponseConfigsResponse.Message = _ctx.StringValue("ListAutomateResponseConfigs.Message");
			listAutomateResponseConfigsResponse.RequestId = _ctx.StringValue("ListAutomateResponseConfigs.RequestId");

			ListAutomateResponseConfigsResponse.ListAutomateResponseConfigs_Data data = new ListAutomateResponseConfigsResponse.ListAutomateResponseConfigs_Data();

			ListAutomateResponseConfigsResponse.ListAutomateResponseConfigs_Data.ListAutomateResponseConfigs_PageInfo pageInfo = new ListAutomateResponseConfigsResponse.ListAutomateResponseConfigs_Data.ListAutomateResponseConfigs_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("ListAutomateResponseConfigs.Data.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("ListAutomateResponseConfigs.Data.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.LongValue("ListAutomateResponseConfigs.Data.PageInfo.TotalCount");
			data.PageInfo = pageInfo;

			List<ListAutomateResponseConfigsResponse.ListAutomateResponseConfigs_Data.ListAutomateResponseConfigs_ResponseDataItem> data_responseData = new List<ListAutomateResponseConfigsResponse.ListAutomateResponseConfigs_Data.ListAutomateResponseConfigs_ResponseDataItem>();
			for (int i = 0; i < _ctx.Length("ListAutomateResponseConfigs.Data.ResponseData.Length"); i++) {
				ListAutomateResponseConfigsResponse.ListAutomateResponseConfigs_Data.ListAutomateResponseConfigs_ResponseDataItem responseDataItem = new ListAutomateResponseConfigsResponse.ListAutomateResponseConfigs_Data.ListAutomateResponseConfigs_ResponseDataItem();
				responseDataItem.Id = _ctx.LongValue("ListAutomateResponseConfigs.Data.ResponseData["+ i +"].Id");
				responseDataItem.GmtCreate = _ctx.StringValue("ListAutomateResponseConfigs.Data.ResponseData["+ i +"].GmtCreate");
				responseDataItem.GmtModified = _ctx.StringValue("ListAutomateResponseConfigs.Data.ResponseData["+ i +"].GmtModified");
				responseDataItem.Aliuid = _ctx.LongValue("ListAutomateResponseConfigs.Data.ResponseData["+ i +"].Aliuid");
				responseDataItem.SubUserId = _ctx.LongValue("ListAutomateResponseConfigs.Data.ResponseData["+ i +"].SubUserId");
				responseDataItem.RuleName = _ctx.StringValue("ListAutomateResponseConfigs.Data.ResponseData["+ i +"].RuleName");
				responseDataItem.AutoResponseType = _ctx.StringValue("ListAutomateResponseConfigs.Data.ResponseData["+ i +"].AutoResponseType");
				responseDataItem.ExecutionCondition = _ctx.StringValue("ListAutomateResponseConfigs.Data.ResponseData["+ i +"].ExecutionCondition");
				responseDataItem.ActionType = _ctx.StringValue("ListAutomateResponseConfigs.Data.ResponseData["+ i +"].ActionType");
				responseDataItem.ActionConfig = _ctx.StringValue("ListAutomateResponseConfigs.Data.ResponseData["+ i +"].ActionConfig");
				responseDataItem.Status = _ctx.IntegerValue("ListAutomateResponseConfigs.Data.ResponseData["+ i +"].Status");
				responseDataItem.DataType = _ctx.IntegerValue("ListAutomateResponseConfigs.Data.ResponseData["+ i +"].DataType");

				data_responseData.Add(responseDataItem);
			}
			data.ResponseData = data_responseData;
			listAutomateResponseConfigsResponse.Data = data;
        
			return listAutomateResponseConfigsResponse;
        }
    }
}
