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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListBaselineStatusesResponseUnmarshaller
    {
        public static ListBaselineStatusesResponse Unmarshall(UnmarshallerContext context)
        {
			ListBaselineStatusesResponse listBaselineStatusesResponse = new ListBaselineStatusesResponse();

			listBaselineStatusesResponse.HttpResponse = context.HttpResponse;
			listBaselineStatusesResponse.Success = context.BooleanValue("ListBaselineStatuses.Success");
			listBaselineStatusesResponse.ErrorCode = context.StringValue("ListBaselineStatuses.ErrorCode");
			listBaselineStatusesResponse.ErrorMessage = context.StringValue("ListBaselineStatuses.ErrorMessage");
			listBaselineStatusesResponse.HttpStatusCode = context.IntegerValue("ListBaselineStatuses.HttpStatusCode");
			listBaselineStatusesResponse.RequestId = context.StringValue("ListBaselineStatuses.RequestId");

			ListBaselineStatusesResponse.ListBaselineStatuses_Data data = new ListBaselineStatusesResponse.ListBaselineStatuses_Data();
			data.PageNumber = context.IntegerValue("ListBaselineStatuses.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListBaselineStatuses.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListBaselineStatuses.Data.TotalCount");

			List<ListBaselineStatusesResponse.ListBaselineStatuses_Data.ListBaselineStatuses_BaselineStatusesItem> data_baselineStatuses = new List<ListBaselineStatusesResponse.ListBaselineStatuses_Data.ListBaselineStatuses_BaselineStatusesItem>();
			for (int i = 0; i < context.Length("ListBaselineStatuses.Data.BaselineStatuses.Length"); i++) {
				ListBaselineStatusesResponse.ListBaselineStatuses_Data.ListBaselineStatuses_BaselineStatusesItem baselineStatusesItem = new ListBaselineStatusesResponse.ListBaselineStatuses_Data.ListBaselineStatuses_BaselineStatusesItem();
				baselineStatusesItem.BaselineName = context.StringValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].BaselineName");
				baselineStatusesItem.BaselineId = context.LongValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].BaselineId");
				baselineStatusesItem.Bizdate = context.LongValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].Bizdate");
				baselineStatusesItem.Owner = context.StringValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].Owner");
				baselineStatusesItem.ExpTime = context.LongValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].ExpTime");
				baselineStatusesItem.FinishTime = context.LongValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].FinishTime");
				baselineStatusesItem.EndCast = context.LongValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].EndCast");
				baselineStatusesItem.SlaTime = context.LongValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].SlaTime");
				baselineStatusesItem.Priority = context.IntegerValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].Priority");
				baselineStatusesItem.ProjectId = context.LongValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].ProjectId");
				baselineStatusesItem.Buffer = context.LongValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].Buffer");
				baselineStatusesItem.Status = context.StringValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].Status");
				baselineStatusesItem.FinishStatus = context.StringValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].FinishStatus");
				baselineStatusesItem.InGroupId = context.IntegerValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].InGroupId");

				data_baselineStatuses.Add(baselineStatusesItem);
			}
			data.BaselineStatuses = data_baselineStatuses;
			listBaselineStatusesResponse.Data = data;
        
			return listBaselineStatusesResponse;
        }
    }
}
