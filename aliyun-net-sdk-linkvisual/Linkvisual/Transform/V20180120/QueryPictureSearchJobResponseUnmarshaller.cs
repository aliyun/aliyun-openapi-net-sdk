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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryPictureSearchJobResponseUnmarshaller
    {
        public static QueryPictureSearchJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryPictureSearchJobResponse queryPictureSearchJobResponse = new QueryPictureSearchJobResponse();

			queryPictureSearchJobResponse.HttpResponse = _ctx.HttpResponse;
			queryPictureSearchJobResponse.Code = _ctx.StringValue("QueryPictureSearchJob.Code");
			queryPictureSearchJobResponse.ErrorMessage = _ctx.StringValue("QueryPictureSearchJob.ErrorMessage");
			queryPictureSearchJobResponse.RequestId = _ctx.StringValue("QueryPictureSearchJob.RequestId");
			queryPictureSearchJobResponse.Success = _ctx.BooleanValue("QueryPictureSearchJob.Success");

			QueryPictureSearchJobResponse.QueryPictureSearchJob_Data data = new QueryPictureSearchJobResponse.QueryPictureSearchJob_Data();
			data.CurrentPage = _ctx.IntegerValue("QueryPictureSearchJob.Data.CurrentPage");
			data.PageSize = _ctx.IntegerValue("QueryPictureSearchJob.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryPictureSearchJob.Data.Total");
			data.PageCount = _ctx.IntegerValue("QueryPictureSearchJob.Data.PageCount");

			List<QueryPictureSearchJobResponse.QueryPictureSearchJob_Data.QueryPictureSearchJob_PageDataItem> data_pageData = new List<QueryPictureSearchJobResponse.QueryPictureSearchJob_Data.QueryPictureSearchJob_PageDataItem>();
			for (int i = 0; i < _ctx.Length("QueryPictureSearchJob.Data.PageData.Length"); i++) {
				QueryPictureSearchJobResponse.QueryPictureSearchJob_Data.QueryPictureSearchJob_PageDataItem pageDataItem = new QueryPictureSearchJobResponse.QueryPictureSearchJob_Data.QueryPictureSearchJob_PageDataItem();
				pageDataItem.EndTime = _ctx.LongValue("QueryPictureSearchJob.Data.PageData["+ i +"].EndTime");
				pageDataItem.StartTime = _ctx.LongValue("QueryPictureSearchJob.Data.PageData["+ i +"].StartTime");
				pageDataItem.JobStatus = _ctx.IntegerValue("QueryPictureSearchJob.Data.PageData["+ i +"].JobStatus");
				pageDataItem.SearchPicUrl = _ctx.StringValue("QueryPictureSearchJob.Data.PageData["+ i +"].SearchPicUrl");
				pageDataItem.CreateTime = _ctx.LongValue("QueryPictureSearchJob.Data.PageData["+ i +"].CreateTime");
				pageDataItem.JobId = _ctx.StringValue("QueryPictureSearchJob.Data.PageData["+ i +"].JobId");
				pageDataItem.Threshold = _ctx.FloatValue("QueryPictureSearchJob.Data.PageData["+ i +"].Threshold");

				data_pageData.Add(pageDataItem);
			}
			data.PageData = data_pageData;
			queryPictureSearchJobResponse.Data = data;
        
			return queryPictureSearchJobResponse;
        }
    }
}
