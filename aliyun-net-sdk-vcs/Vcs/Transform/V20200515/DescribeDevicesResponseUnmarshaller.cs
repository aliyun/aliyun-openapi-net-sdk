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
    public class DescribeDevicesResponseUnmarshaller
    {
        public static DescribeDevicesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDevicesResponse describeDevicesResponse = new DescribeDevicesResponse();

			describeDevicesResponse.HttpResponse = context.HttpResponse;
			describeDevicesResponse.Code = context.StringValue("DescribeDevices.Code");
			describeDevicesResponse.Message = context.StringValue("DescribeDevices.Message");
			describeDevicesResponse.RequestId = context.StringValue("DescribeDevices.RequestId");

			DescribeDevicesResponse.DescribeDevices_Data data = new DescribeDevicesResponse.DescribeDevices_Data();
			data.PageNum = context.IntegerValue("DescribeDevices.Data.PageNum");
			data.PageSize = context.IntegerValue("DescribeDevices.Data.PageSize");
			data.TotalCount = context.IntegerValue("DescribeDevices.Data.TotalCount");
			data.TotalPage = context.IntegerValue("DescribeDevices.Data.TotalPage");

			List<DescribeDevicesResponse.DescribeDevices_Data.DescribeDevices_Record> data_records = new List<DescribeDevicesResponse.DescribeDevices_Data.DescribeDevices_Record>();
			for (int i = 0; i < context.Length("DescribeDevices.Data.Records.Length"); i++) {
				DescribeDevicesResponse.DescribeDevices_Data.DescribeDevices_Record record = new DescribeDevicesResponse.DescribeDevices_Data.DescribeDevices_Record();
				record.InProtocol = context.StringValue("DescribeDevices.Data.Records["+ i +"].InProtocol");
				record.CreateTime = context.StringValue("DescribeDevices.Data.Records["+ i +"].CreateTime");
				record.DeviceAddress = context.StringValue("DescribeDevices.Data.Records["+ i +"].DeviceAddress");
				record.DeviceId = context.StringValue("DescribeDevices.Data.Records["+ i +"].DeviceId");
				record.DeviceName = context.StringValue("DescribeDevices.Data.Records["+ i +"].DeviceName");
				record.DeviceType = context.StringValue("DescribeDevices.Data.Records["+ i +"].DeviceType");
				record.Latitude = context.StringValue("DescribeDevices.Data.Records["+ i +"].Latitude");
				record.Longitude = context.StringValue("DescribeDevices.Data.Records["+ i +"].Longitude");
				record.Status = context.StringValue("DescribeDevices.Data.Records["+ i +"].Status");
				record.Vendor = context.StringValue("DescribeDevices.Data.Records["+ i +"].Vendor");
				record.CorpId = context.StringValue("DescribeDevices.Data.Records["+ i +"].CorpId");

				data_records.Add(record);
			}
			data.Records = data_records;
			describeDevicesResponse.Data = data;
        
			return describeDevicesResponse;
        }
    }
}
