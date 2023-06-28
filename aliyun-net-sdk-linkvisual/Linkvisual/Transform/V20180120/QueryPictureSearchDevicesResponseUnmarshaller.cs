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
    public class QueryPictureSearchDevicesResponseUnmarshaller
    {
        public static QueryPictureSearchDevicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryPictureSearchDevicesResponse queryPictureSearchDevicesResponse = new QueryPictureSearchDevicesResponse();

			queryPictureSearchDevicesResponse.HttpResponse = _ctx.HttpResponse;
			queryPictureSearchDevicesResponse.Code = _ctx.StringValue("QueryPictureSearchDevices.Code");
			queryPictureSearchDevicesResponse.ErrorMessage = _ctx.StringValue("QueryPictureSearchDevices.ErrorMessage");
			queryPictureSearchDevicesResponse.RequestId = _ctx.StringValue("QueryPictureSearchDevices.RequestId");
			queryPictureSearchDevicesResponse.Success = _ctx.BooleanValue("QueryPictureSearchDevices.Success");

			QueryPictureSearchDevicesResponse.QueryPictureSearchDevices_Data data = new QueryPictureSearchDevicesResponse.QueryPictureSearchDevices_Data();
			data.CurrentPage = _ctx.IntegerValue("QueryPictureSearchDevices.Data.CurrentPage");
			data.PageSize = _ctx.IntegerValue("QueryPictureSearchDevices.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryPictureSearchDevices.Data.Total");
			data.PageCount = _ctx.IntegerValue("QueryPictureSearchDevices.Data.PageCount");

			List<QueryPictureSearchDevicesResponse.QueryPictureSearchDevices_Data.QueryPictureSearchDevices_SearchData> data_pageData = new List<QueryPictureSearchDevicesResponse.QueryPictureSearchDevices_Data.QueryPictureSearchDevices_SearchData>();
			for (int i = 0; i < _ctx.Length("QueryPictureSearchDevices.Data.PageData.Length"); i++) {
				QueryPictureSearchDevicesResponse.QueryPictureSearchDevices_Data.QueryPictureSearchDevices_SearchData searchData = new QueryPictureSearchDevicesResponse.QueryPictureSearchDevices_Data.QueryPictureSearchDevices_SearchData();
				searchData.NickName = _ctx.StringValue("QueryPictureSearchDevices.Data.PageData["+ i +"].NickName");
				searchData.IotId = _ctx.StringValue("QueryPictureSearchDevices.Data.PageData["+ i +"].IotId");

				data_pageData.Add(searchData);
			}
			data.PageData = data_pageData;
			queryPictureSearchDevicesResponse.Data = data;
        
			return queryPictureSearchDevicesResponse;
        }
    }
}
