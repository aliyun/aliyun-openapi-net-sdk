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
        public static ListBaselineStatusesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBaselineStatusesResponse listBaselineStatusesResponse = new ListBaselineStatusesResponse();

			listBaselineStatusesResponse.HttpResponse = _ctx.HttpResponse;
			listBaselineStatusesResponse.Success = _ctx.BooleanValue("ListBaselineStatuses.Success");
			listBaselineStatusesResponse.ErrorCode = _ctx.StringValue("ListBaselineStatuses.ErrorCode");
			listBaselineStatusesResponse.ErrorMessage = _ctx.StringValue("ListBaselineStatuses.ErrorMessage");
			listBaselineStatusesResponse.HttpStatusCode = _ctx.IntegerValue("ListBaselineStatuses.HttpStatusCode");
			listBaselineStatusesResponse.RequestId = _ctx.StringValue("ListBaselineStatuses.RequestId");

			ListBaselineStatusesResponse.ListBaselineStatuses_Data data = new ListBaselineStatusesResponse.ListBaselineStatuses_Data();
			data.PageNumber = _ctx.IntegerValue("ListBaselineStatuses.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListBaselineStatuses.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListBaselineStatuses.Data.TotalCount");

			List<ListBaselineStatusesResponse.ListBaselineStatuses_Data.ListBaselineStatuses_BaselineStatusesItem> data_baselineStatuses = new List<ListBaselineStatusesResponse.ListBaselineStatuses_Data.ListBaselineStatuses_BaselineStatusesItem>();
			for (int i = 0; i < _ctx.Length("ListBaselineStatuses.Data.BaselineStatuses.Length"); i++) {
				ListBaselineStatusesResponse.ListBaselineStatuses_Data.ListBaselineStatuses_BaselineStatusesItem baselineStatusesItem = new ListBaselineStatusesResponse.ListBaselineStatuses_Data.ListBaselineStatuses_BaselineStatusesItem();
				baselineStatusesItem.BaselineName = _ctx.StringValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].BaselineName");
				baselineStatusesItem.BaselineId = _ctx.LongValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].BaselineId");
				baselineStatusesItem.Bizdate = _ctx.LongValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].Bizdate");
				baselineStatusesItem.Owner = _ctx.StringValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].Owner");
				baselineStatusesItem.ExpTime = _ctx.LongValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].ExpTime");
				baselineStatusesItem.FinishTime = _ctx.LongValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].FinishTime");
				baselineStatusesItem.EndCast = _ctx.LongValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].EndCast");
				baselineStatusesItem.SlaTime = _ctx.LongValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].SlaTime");
				baselineStatusesItem.Priority = _ctx.IntegerValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].Priority");
				baselineStatusesItem.ProjectId = _ctx.LongValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].ProjectId");
				baselineStatusesItem.Buffer = _ctx.LongValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].Buffer");
				baselineStatusesItem.Status = _ctx.StringValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].Status");
				baselineStatusesItem.FinishStatus = _ctx.StringValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].FinishStatus");
				baselineStatusesItem.InGroupId = _ctx.IntegerValue("ListBaselineStatuses.Data.BaselineStatuses["+ i +"].InGroupId");

				data_baselineStatuses.Add(baselineStatusesItem);
			}
			data.BaselineStatuses = data_baselineStatuses;
			listBaselineStatusesResponse.Data = data;
        
			return listBaselineStatusesResponse;
        }
    }
}
