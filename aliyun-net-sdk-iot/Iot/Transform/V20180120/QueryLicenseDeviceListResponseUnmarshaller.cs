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
    public class QueryLicenseDeviceListResponseUnmarshaller
    {
        public static QueryLicenseDeviceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryLicenseDeviceListResponse queryLicenseDeviceListResponse = new QueryLicenseDeviceListResponse();

			queryLicenseDeviceListResponse.HttpResponse = _ctx.HttpResponse;
			queryLicenseDeviceListResponse.RequestId = _ctx.StringValue("QueryLicenseDeviceList.RequestId");
			queryLicenseDeviceListResponse.Success = _ctx.BooleanValue("QueryLicenseDeviceList.Success");
			queryLicenseDeviceListResponse.Code = _ctx.StringValue("QueryLicenseDeviceList.Code");
			queryLicenseDeviceListResponse.ErrorMessage = _ctx.StringValue("QueryLicenseDeviceList.ErrorMessage");

			QueryLicenseDeviceListResponse.QueryLicenseDeviceList_Data data = new QueryLicenseDeviceListResponse.QueryLicenseDeviceList_Data();
			data.PageSize = _ctx.IntegerValue("QueryLicenseDeviceList.Data.PageSize");
			data.PageId = _ctx.IntegerValue("QueryLicenseDeviceList.Data.PageId");
			data.Total = _ctx.IntegerValue("QueryLicenseDeviceList.Data.Total");

			List<QueryLicenseDeviceListResponse.QueryLicenseDeviceList_Data.QueryLicenseDeviceList_Item> data_deviceList = new List<QueryLicenseDeviceListResponse.QueryLicenseDeviceList_Data.QueryLicenseDeviceList_Item>();
			for (int i = 0; i < _ctx.Length("QueryLicenseDeviceList.Data.DeviceList.Length"); i++) {
				QueryLicenseDeviceListResponse.QueryLicenseDeviceList_Data.QueryLicenseDeviceList_Item item = new QueryLicenseDeviceListResponse.QueryLicenseDeviceList_Data.QueryLicenseDeviceList_Item();
				item.ProductName = _ctx.StringValue("QueryLicenseDeviceList.Data.DeviceList["+ i +"].ProductName");
				item.LicenseCode = _ctx.StringValue("QueryLicenseDeviceList.Data.DeviceList["+ i +"].LicenseCode");
				item.ProductKey = _ctx.StringValue("QueryLicenseDeviceList.Data.DeviceList["+ i +"].ProductKey");
				item.DeviceName = _ctx.StringValue("QueryLicenseDeviceList.Data.DeviceList["+ i +"].DeviceName");
				item.ExpiryTime = _ctx.LongValue("QueryLicenseDeviceList.Data.DeviceList["+ i +"].ExpiryTime");
				item.GmtCreate = _ctx.LongValue("QueryLicenseDeviceList.Data.DeviceList["+ i +"].GmtCreate");
				item.IotId = _ctx.StringValue("QueryLicenseDeviceList.Data.DeviceList["+ i +"].IotId");

				data_deviceList.Add(item);
			}
			data.DeviceList = data_deviceList;
			queryLicenseDeviceListResponse.Data = data;
        
			return queryLicenseDeviceListResponse;
        }
    }
}
