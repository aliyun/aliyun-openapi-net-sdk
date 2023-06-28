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
    public class QueryPictureSearchAppsResponseUnmarshaller
    {
        public static QueryPictureSearchAppsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryPictureSearchAppsResponse queryPictureSearchAppsResponse = new QueryPictureSearchAppsResponse();

			queryPictureSearchAppsResponse.HttpResponse = _ctx.HttpResponse;
			queryPictureSearchAppsResponse.Code = _ctx.StringValue("QueryPictureSearchApps.Code");
			queryPictureSearchAppsResponse.ErrorMessage = _ctx.StringValue("QueryPictureSearchApps.ErrorMessage");
			queryPictureSearchAppsResponse.RequestId = _ctx.StringValue("QueryPictureSearchApps.RequestId");
			queryPictureSearchAppsResponse.Success = _ctx.BooleanValue("QueryPictureSearchApps.Success");

			QueryPictureSearchAppsResponse.QueryPictureSearchApps_Data data = new QueryPictureSearchAppsResponse.QueryPictureSearchApps_Data();
			data.CurrentPage = _ctx.IntegerValue("QueryPictureSearchApps.Data.CurrentPage");
			data.PageSize = _ctx.IntegerValue("QueryPictureSearchApps.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryPictureSearchApps.Data.Total");
			data.PageCount = _ctx.IntegerValue("QueryPictureSearchApps.Data.PageCount");

			List<QueryPictureSearchAppsResponse.QueryPictureSearchApps_Data.QueryPictureSearchApps_PageDataItem> data_pageData = new List<QueryPictureSearchAppsResponse.QueryPictureSearchApps_Data.QueryPictureSearchApps_PageDataItem>();
			for (int i = 0; i < _ctx.Length("QueryPictureSearchApps.Data.PageData.Length"); i++) {
				QueryPictureSearchAppsResponse.QueryPictureSearchApps_Data.QueryPictureSearchApps_PageDataItem pageDataItem = new QueryPictureSearchAppsResponse.QueryPictureSearchApps_Data.QueryPictureSearchApps_PageDataItem();
				pageDataItem.AppInstanceId = _ctx.StringValue("QueryPictureSearchApps.Data.PageData["+ i +"].AppInstanceId");
				pageDataItem.ModifiedTime = _ctx.LongValue("QueryPictureSearchApps.Data.PageData["+ i +"].ModifiedTime");
				pageDataItem.Description = _ctx.StringValue("QueryPictureSearchApps.Data.PageData["+ i +"].Description");
				pageDataItem.Version = _ctx.StringValue("QueryPictureSearchApps.Data.PageData["+ i +"].Version");
				pageDataItem.CreateTime = _ctx.LongValue("QueryPictureSearchApps.Data.PageData["+ i +"].CreateTime");
				pageDataItem.AppTemplateId = _ctx.StringValue("QueryPictureSearchApps.Data.PageData["+ i +"].AppTemplateId");
				pageDataItem.Name = _ctx.StringValue("QueryPictureSearchApps.Data.PageData["+ i +"].Name");

				data_pageData.Add(pageDataItem);
			}
			data.PageData = data_pageData;
			queryPictureSearchAppsResponse.Data = data;
        
			return queryPictureSearchAppsResponse;
        }
    }
}
