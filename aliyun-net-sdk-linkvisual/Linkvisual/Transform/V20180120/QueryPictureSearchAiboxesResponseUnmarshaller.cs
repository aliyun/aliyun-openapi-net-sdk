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
    public class QueryPictureSearchAiboxesResponseUnmarshaller
    {
        public static QueryPictureSearchAiboxesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryPictureSearchAiboxesResponse queryPictureSearchAiboxesResponse = new QueryPictureSearchAiboxesResponse();

			queryPictureSearchAiboxesResponse.HttpResponse = _ctx.HttpResponse;
			queryPictureSearchAiboxesResponse.Code = _ctx.StringValue("QueryPictureSearchAiboxes.Code");
			queryPictureSearchAiboxesResponse.ErrorMessage = _ctx.StringValue("QueryPictureSearchAiboxes.ErrorMessage");
			queryPictureSearchAiboxesResponse.RequestId = _ctx.StringValue("QueryPictureSearchAiboxes.RequestId");
			queryPictureSearchAiboxesResponse.Success = _ctx.BooleanValue("QueryPictureSearchAiboxes.Success");

			QueryPictureSearchAiboxesResponse.QueryPictureSearchAiboxes_Data data = new QueryPictureSearchAiboxesResponse.QueryPictureSearchAiboxes_Data();
			data.CurrentPage = _ctx.IntegerValue("QueryPictureSearchAiboxes.Data.CurrentPage");
			data.PageSize = _ctx.IntegerValue("QueryPictureSearchAiboxes.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryPictureSearchAiboxes.Data.Total");
			data.PageCount = _ctx.IntegerValue("QueryPictureSearchAiboxes.Data.PageCount");

			List<QueryPictureSearchAiboxesResponse.QueryPictureSearchAiboxes_Data.QueryPictureSearchAiboxes_SearchData> data_pageData = new List<QueryPictureSearchAiboxesResponse.QueryPictureSearchAiboxes_Data.QueryPictureSearchAiboxes_SearchData>();
			for (int i = 0; i < _ctx.Length("QueryPictureSearchAiboxes.Data.PageData.Length"); i++) {
				QueryPictureSearchAiboxesResponse.QueryPictureSearchAiboxes_Data.QueryPictureSearchAiboxes_SearchData searchData = new QueryPictureSearchAiboxesResponse.QueryPictureSearchAiboxes_Data.QueryPictureSearchAiboxes_SearchData();
				searchData.NickName = _ctx.StringValue("QueryPictureSearchAiboxes.Data.PageData["+ i +"].NickName");
				searchData.IotId = _ctx.StringValue("QueryPictureSearchAiboxes.Data.PageData["+ i +"].IotId");

				data_pageData.Add(searchData);
			}
			data.PageData = data_pageData;
			queryPictureSearchAiboxesResponse.Data = data;
        
			return queryPictureSearchAiboxesResponse;
        }
    }
}
