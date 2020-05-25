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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class ListDevicesResponseUnmarshaller
    {
        public static ListDevicesResponse Unmarshall(UnmarshallerContext context)
        {
			ListDevicesResponse listDevicesResponse = new ListDevicesResponse();

			listDevicesResponse.HttpResponse = context.HttpResponse;
			listDevicesResponse.Code = context.StringValue("ListDevices.Code");
			listDevicesResponse.Message = context.StringValue("ListDevices.Message");
			listDevicesResponse.RequestId = context.StringValue("ListDevices.RequestId");

			ListDevicesResponse.ListDevices_Data data = new ListDevicesResponse.ListDevices_Data();
			data.PageNumber = context.IntegerValue("ListDevices.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListDevices.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListDevices.Data.TotalCount");
			data.TotalPage = context.IntegerValue("ListDevices.Data.TotalPage");

			List<ListDevicesResponse.ListDevices_Data.ListDevices_Record> data_records = new List<ListDevicesResponse.ListDevices_Data.ListDevices_Record>();
			for (int i = 0; i < context.Length("ListDevices.Data.Records.Length"); i++) {
				ListDevicesResponse.ListDevices_Data.ListDevices_Record record = new ListDevicesResponse.ListDevices_Data.ListDevices_Record();
				record.AccessProtocolType = context.StringValue("ListDevices.Data.Records["+ i +"].AccessProtocolType");
				record.BitRate = context.StringValue("ListDevices.Data.Records["+ i +"].BitRate");
				record.CoverImageUrl = context.StringValue("ListDevices.Data.Records["+ i +"].CoverImageUrl");
				record.GbId = context.StringValue("ListDevices.Data.Records["+ i +"].GbId");
				record.DeviceAddress = context.StringValue("ListDevices.Data.Records["+ i +"].DeviceAddress");
				record.DeviceDirection = context.StringValue("ListDevices.Data.Records["+ i +"].DeviceDirection");
				record.DeviceSite = context.StringValue("ListDevices.Data.Records["+ i +"].DeviceSite");
				record.Latitude = context.StringValue("ListDevices.Data.Records["+ i +"].Latitude");
				record.Longitude = context.StringValue("ListDevices.Data.Records["+ i +"].Longitude");
				record.DeviceName = context.StringValue("ListDevices.Data.Records["+ i +"].DeviceName");
				record.Resolution = context.StringValue("ListDevices.Data.Records["+ i +"].Resolution");
				record.SipGBId = context.StringValue("ListDevices.Data.Records["+ i +"].SipGBId");
				record.SipPassword = context.StringValue("ListDevices.Data.Records["+ i +"].SipPassword");
				record.SipServerIp = context.StringValue("ListDevices.Data.Records["+ i +"].SipServerIp");
				record.SipServerPort = context.StringValue("ListDevices.Data.Records["+ i +"].SipServerPort");
				record.Status = context.IntegerValue("ListDevices.Data.Records["+ i +"].Status");
				record.DeviceType = context.StringValue("ListDevices.Data.Records["+ i +"].DeviceType");
				record.Vendor = context.StringValue("ListDevices.Data.Records["+ i +"].Vendor");
				record.CreateTime = context.StringValue("ListDevices.Data.Records["+ i +"].CreateTime");

				data_records.Add(record);
			}
			data.Records = data_records;
			listDevicesResponse.Data = data;
        
			return listDevicesResponse;
        }
    }
}
