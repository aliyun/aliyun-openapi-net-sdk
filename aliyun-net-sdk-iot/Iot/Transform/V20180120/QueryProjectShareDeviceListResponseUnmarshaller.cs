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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryProjectShareDeviceListResponseUnmarshaller
    {
        public static QueryProjectShareDeviceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryProjectShareDeviceListResponse queryProjectShareDeviceListResponse = new QueryProjectShareDeviceListResponse();

			queryProjectShareDeviceListResponse.HttpResponse = _ctx.HttpResponse;
			queryProjectShareDeviceListResponse.RequestId = _ctx.StringValue("QueryProjectShareDeviceList.RequestId");
			queryProjectShareDeviceListResponse.Success = _ctx.BooleanValue("QueryProjectShareDeviceList.Success");
			queryProjectShareDeviceListResponse.Code = _ctx.StringValue("QueryProjectShareDeviceList.Code");
			queryProjectShareDeviceListResponse.ErrorMessage = _ctx.StringValue("QueryProjectShareDeviceList.ErrorMessage");

			QueryProjectShareDeviceListResponse.QueryProjectShareDeviceList_Data data = new QueryProjectShareDeviceListResponse.QueryProjectShareDeviceList_Data();
			data.PageSize = _ctx.IntegerValue("QueryProjectShareDeviceList.Data.PageSize");
			data.PageId = _ctx.IntegerValue("QueryProjectShareDeviceList.Data.PageId");
			data.Total = _ctx.IntegerValue("QueryProjectShareDeviceList.Data.Total");

			List<QueryProjectShareDeviceListResponse.QueryProjectShareDeviceList_Data.QueryProjectShareDeviceList_Items> data_deviceList = new List<QueryProjectShareDeviceListResponse.QueryProjectShareDeviceList_Data.QueryProjectShareDeviceList_Items>();
			for (int i = 0; i < _ctx.Length("QueryProjectShareDeviceList.Data.DeviceList.Length"); i++) {
				QueryProjectShareDeviceListResponse.QueryProjectShareDeviceList_Data.QueryProjectShareDeviceList_Items items = new QueryProjectShareDeviceListResponse.QueryProjectShareDeviceList_Data.QueryProjectShareDeviceList_Items();
				items.ProductKey = _ctx.StringValue("QueryProjectShareDeviceList.Data.DeviceList["+ i +"].ProductKey");
				items.DeviceName = _ctx.StringValue("QueryProjectShareDeviceList.Data.DeviceList["+ i +"].DeviceName");
				items.Sharable = _ctx.LongValue("QueryProjectShareDeviceList.Data.DeviceList["+ i +"].Sharable");
				items.IotId = _ctx.StringValue("QueryProjectShareDeviceList.Data.DeviceList["+ i +"].IotId");

				data_deviceList.Add(items);
			}
			data.DeviceList = data_deviceList;
			queryProjectShareDeviceListResponse.Data = data;
        
			return queryProjectShareDeviceListResponse;
        }
    }
}
