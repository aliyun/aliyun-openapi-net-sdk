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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class GetMailTaskListResponseUnmarshaller
    {
        public static GetMailTaskListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMailTaskListResponse getMailTaskListResponse = new GetMailTaskListResponse();

			getMailTaskListResponse.HttpResponse = _ctx.HttpResponse;
			getMailTaskListResponse.RequestId = _ctx.StringValue("GetMailTaskList.RequestId");
			getMailTaskListResponse.Success = _ctx.BooleanValue("GetMailTaskList.Success");

			GetMailTaskListResponse.GetMailTaskList_Result result = new GetMailTaskListResponse.GetMailTaskList_Result();
			result.PageNum = _ctx.IntegerValue("GetMailTaskList.Result.PageNum");
			result.PageSize = _ctx.IntegerValue("GetMailTaskList.Result.PageSize");
			result.TotalNum = _ctx.IntegerValue("GetMailTaskList.Result.TotalNum");
			result.TotalPages = _ctx.IntegerValue("GetMailTaskList.Result.TotalPages");
			result.Pre = _ctx.IntegerValue("GetMailTaskList.Result.Pre");
			result.Next = _ctx.IntegerValue("GetMailTaskList.Result.Next");

			List<GetMailTaskListResponse.GetMailTaskList_Result.GetMailTaskList_DataItem> result_data = new List<GetMailTaskListResponse.GetMailTaskList_Result.GetMailTaskList_DataItem>();
			for (int i = 0; i < _ctx.Length("GetMailTaskList.Result.Data.Length"); i++) {
				GetMailTaskListResponse.GetMailTaskList_Result.GetMailTaskList_DataItem dataItem = new GetMailTaskListResponse.GetMailTaskList_Result.GetMailTaskList_DataItem();
				dataItem.MailId = _ctx.StringValue("GetMailTaskList.Result.Data["+ i +"].MailId");
				dataItem.Paused = _ctx.BooleanValue("GetMailTaskList.Result.Data["+ i +"].Paused");
				dataItem.BizOwnerUserId = _ctx.StringValue("GetMailTaskList.Result.Data["+ i +"].BizOwnerUserId");
				dataItem.BizOwnerName = _ctx.StringValue("GetMailTaskList.Result.Data["+ i +"].BizOwnerName");
				dataItem.SubscribeName = _ctx.StringValue("GetMailTaskList.Result.Data["+ i +"].SubscribeName");

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			getMailTaskListResponse.Result = result;
        
			return getMailTaskListResponse;
        }
    }
}
