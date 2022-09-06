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
    public class QueryShareTaskDeviceListResponseUnmarshaller
    {
        public static QueryShareTaskDeviceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryShareTaskDeviceListResponse queryShareTaskDeviceListResponse = new QueryShareTaskDeviceListResponse();

			queryShareTaskDeviceListResponse.HttpResponse = _ctx.HttpResponse;
			queryShareTaskDeviceListResponse.RequestId = _ctx.StringValue("QueryShareTaskDeviceList.RequestId");
			queryShareTaskDeviceListResponse.Success = _ctx.BooleanValue("QueryShareTaskDeviceList.Success");
			queryShareTaskDeviceListResponse.Code = _ctx.StringValue("QueryShareTaskDeviceList.Code");
			queryShareTaskDeviceListResponse.ErrorMessage = _ctx.StringValue("QueryShareTaskDeviceList.ErrorMessage");

			QueryShareTaskDeviceListResponse.QueryShareTaskDeviceList_Data data = new QueryShareTaskDeviceListResponse.QueryShareTaskDeviceList_Data();
			data.PageSize = _ctx.IntegerValue("QueryShareTaskDeviceList.Data.PageSize");
			data.PageId = _ctx.IntegerValue("QueryShareTaskDeviceList.Data.PageId");
			data.Total = _ctx.IntegerValue("QueryShareTaskDeviceList.Data.Total");

			List<QueryShareTaskDeviceListResponse.QueryShareTaskDeviceList_Data.QueryShareTaskDeviceList_Items> data_deviceList = new List<QueryShareTaskDeviceListResponse.QueryShareTaskDeviceList_Data.QueryShareTaskDeviceList_Items>();
			for (int i = 0; i < _ctx.Length("QueryShareTaskDeviceList.Data.DeviceList.Length"); i++) {
				QueryShareTaskDeviceListResponse.QueryShareTaskDeviceList_Data.QueryShareTaskDeviceList_Items items = new QueryShareTaskDeviceListResponse.QueryShareTaskDeviceList_Data.QueryShareTaskDeviceList_Items();
				items.ProductKey = _ctx.StringValue("QueryShareTaskDeviceList.Data.DeviceList["+ i +"].ProductKey");
				items.DeviceName = _ctx.StringValue("QueryShareTaskDeviceList.Data.DeviceList["+ i +"].DeviceName");
				items.GmtAdded = _ctx.LongValue("QueryShareTaskDeviceList.Data.DeviceList["+ i +"].GmtAdded");
				items.IotId = _ctx.StringValue("QueryShareTaskDeviceList.Data.DeviceList["+ i +"].IotId");

				data_deviceList.Add(items);
			}
			data.DeviceList = data_deviceList;
			queryShareTaskDeviceListResponse.Data = data;
        
			return queryShareTaskDeviceListResponse;
        }
    }
}
