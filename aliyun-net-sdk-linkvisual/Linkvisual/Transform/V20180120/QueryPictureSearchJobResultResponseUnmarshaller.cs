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
    public class QueryPictureSearchJobResultResponseUnmarshaller
    {
        public static QueryPictureSearchJobResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryPictureSearchJobResultResponse queryPictureSearchJobResultResponse = new QueryPictureSearchJobResultResponse();

			queryPictureSearchJobResultResponse.HttpResponse = _ctx.HttpResponse;
			queryPictureSearchJobResultResponse.Code = _ctx.StringValue("QueryPictureSearchJobResult.Code");
			queryPictureSearchJobResultResponse.ErrorMessage = _ctx.StringValue("QueryPictureSearchJobResult.ErrorMessage");
			queryPictureSearchJobResultResponse.RequestId = _ctx.StringValue("QueryPictureSearchJobResult.RequestId");
			queryPictureSearchJobResultResponse.Success = _ctx.BooleanValue("QueryPictureSearchJobResult.Success");

			QueryPictureSearchJobResultResponse.QueryPictureSearchJobResult_Data data = new QueryPictureSearchJobResultResponse.QueryPictureSearchJobResult_Data();
			data.CurrentPage = _ctx.IntegerValue("QueryPictureSearchJobResult.Data.CurrentPage");
			data.PageSize = _ctx.IntegerValue("QueryPictureSearchJobResult.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryPictureSearchJobResult.Data.Total");
			data.PageCount = _ctx.IntegerValue("QueryPictureSearchJobResult.Data.PageCount");

			List<QueryPictureSearchJobResultResponse.QueryPictureSearchJobResult_Data.QueryPictureSearchJobResult_SearchData> data_pageData = new List<QueryPictureSearchJobResultResponse.QueryPictureSearchJobResult_Data.QueryPictureSearchJobResult_SearchData>();
			for (int i = 0; i < _ctx.Length("QueryPictureSearchJobResult.Data.PageData.Length"); i++) {
				QueryPictureSearchJobResultResponse.QueryPictureSearchJobResult_Data.QueryPictureSearchJobResult_SearchData searchData = new QueryPictureSearchJobResultResponse.QueryPictureSearchJobResult_Data.QueryPictureSearchJobResult_SearchData();
				searchData.PicUrl = _ctx.StringValue("QueryPictureSearchJobResult.Data.PageData["+ i +"].PicUrl");
				searchData.EventTime = _ctx.LongValue("QueryPictureSearchJobResult.Data.PageData["+ i +"].EventTime");
				searchData.GatewayIotId = _ctx.StringValue("QueryPictureSearchJobResult.Data.PageData["+ i +"].GatewayIotId");
				searchData.VectorId = _ctx.StringValue("QueryPictureSearchJobResult.Data.PageData["+ i +"].VectorId");
				searchData.DeviceNickName = _ctx.StringValue("QueryPictureSearchJobResult.Data.PageData["+ i +"].DeviceNickName");
				searchData.Threshold = _ctx.FloatValue("QueryPictureSearchJobResult.Data.PageData["+ i +"].Threshold");
				searchData.IotId = _ctx.StringValue("QueryPictureSearchJobResult.Data.PageData["+ i +"].IotId");

				data_pageData.Add(searchData);
			}
			data.PageData = data_pageData;
			queryPictureSearchJobResultResponse.Data = data;
        
			return queryPictureSearchJobResultResponse;
        }
    }
}
