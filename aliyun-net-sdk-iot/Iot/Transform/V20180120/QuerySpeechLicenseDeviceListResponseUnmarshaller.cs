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
    public class QuerySpeechLicenseDeviceListResponseUnmarshaller
    {
        public static QuerySpeechLicenseDeviceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySpeechLicenseDeviceListResponse querySpeechLicenseDeviceListResponse = new QuerySpeechLicenseDeviceListResponse();

			querySpeechLicenseDeviceListResponse.HttpResponse = _ctx.HttpResponse;
			querySpeechLicenseDeviceListResponse.RequestId = _ctx.StringValue("QuerySpeechLicenseDeviceList.RequestId");
			querySpeechLicenseDeviceListResponse.Success = _ctx.BooleanValue("QuerySpeechLicenseDeviceList.Success");
			querySpeechLicenseDeviceListResponse.Code = _ctx.StringValue("QuerySpeechLicenseDeviceList.Code");
			querySpeechLicenseDeviceListResponse.ErrorMessage = _ctx.StringValue("QuerySpeechLicenseDeviceList.ErrorMessage");

			QuerySpeechLicenseDeviceListResponse.QuerySpeechLicenseDeviceList_Data data = new QuerySpeechLicenseDeviceListResponse.QuerySpeechLicenseDeviceList_Data();
			data.PageSize = _ctx.IntegerValue("QuerySpeechLicenseDeviceList.Data.PageSize");
			data.PageId = _ctx.IntegerValue("QuerySpeechLicenseDeviceList.Data.PageId");
			data.Total = _ctx.IntegerValue("QuerySpeechLicenseDeviceList.Data.Total");

			List<QuerySpeechLicenseDeviceListResponse.QuerySpeechLicenseDeviceList_Data.QuerySpeechLicenseDeviceList_Item> data_deviceList = new List<QuerySpeechLicenseDeviceListResponse.QuerySpeechLicenseDeviceList_Data.QuerySpeechLicenseDeviceList_Item>();
			for (int i = 0; i < _ctx.Length("QuerySpeechLicenseDeviceList.Data.DeviceList.Length"); i++) {
				QuerySpeechLicenseDeviceListResponse.QuerySpeechLicenseDeviceList_Data.QuerySpeechLicenseDeviceList_Item item = new QuerySpeechLicenseDeviceListResponse.QuerySpeechLicenseDeviceList_Data.QuerySpeechLicenseDeviceList_Item();
				item.ProductName = _ctx.StringValue("QuerySpeechLicenseDeviceList.Data.DeviceList["+ i +"].ProductName");
				item.ProductKey = _ctx.StringValue("QuerySpeechLicenseDeviceList.Data.DeviceList["+ i +"].ProductKey");
				item.DeviceName = _ctx.StringValue("QuerySpeechLicenseDeviceList.Data.DeviceList["+ i +"].DeviceName");
				item.ExpiryTime = _ctx.LongValue("QuerySpeechLicenseDeviceList.Data.DeviceList["+ i +"].ExpiryTime");
				item.IotId = _ctx.StringValue("QuerySpeechLicenseDeviceList.Data.DeviceList["+ i +"].IotId");
				item.LicenseStatus = _ctx.StringValue("QuerySpeechLicenseDeviceList.Data.DeviceList["+ i +"].LicenseStatus");
				item.DeviceStatus = _ctx.StringValue("QuerySpeechLicenseDeviceList.Data.DeviceList["+ i +"].DeviceStatus");
				item.InSpecifiedGroup = _ctx.BooleanValue("QuerySpeechLicenseDeviceList.Data.DeviceList["+ i +"].InSpecifiedGroup");

				data_deviceList.Add(item);
			}
			data.DeviceList = data_deviceList;
			querySpeechLicenseDeviceListResponse.Data = data;
        
			return querySpeechLicenseDeviceListResponse;
        }
    }
}
