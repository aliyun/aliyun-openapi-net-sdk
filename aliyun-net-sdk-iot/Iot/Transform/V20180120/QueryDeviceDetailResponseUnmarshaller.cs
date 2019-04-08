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
    public class QueryDeviceDetailResponseUnmarshaller
    {
        public static QueryDeviceDetailResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDeviceDetailResponse queryDeviceDetailResponse = new QueryDeviceDetailResponse();

			queryDeviceDetailResponse.HttpResponse = context.HttpResponse;
			queryDeviceDetailResponse.RequestId = context.StringValue("QueryDeviceDetail.RequestId");
			queryDeviceDetailResponse.Success = context.BooleanValue("QueryDeviceDetail.Success");
			queryDeviceDetailResponse.Code = context.StringValue("QueryDeviceDetail.Code");
			queryDeviceDetailResponse.ErrorMessage = context.StringValue("QueryDeviceDetail.ErrorMessage");

			QueryDeviceDetailResponse.QueryDeviceDetail_Data data = new QueryDeviceDetailResponse.QueryDeviceDetail_Data();
			data.IotId = context.StringValue("QueryDeviceDetail.Data.IotId");
			data.ProductKey = context.StringValue("QueryDeviceDetail.Data.ProductKey");
			data.ProductName = context.StringValue("QueryDeviceDetail.Data.ProductName");
			data.DeviceName = context.StringValue("QueryDeviceDetail.Data.DeviceName");
			data.DeviceSecret = context.StringValue("QueryDeviceDetail.Data.DeviceSecret");
			data.FirmwareVersion = context.StringValue("QueryDeviceDetail.Data.FirmwareVersion");
			data.GmtCreate = context.StringValue("QueryDeviceDetail.Data.GmtCreate");
			data.UtcCreate = context.StringValue("QueryDeviceDetail.Data.UtcCreate");
			data.GmtActive = context.StringValue("QueryDeviceDetail.Data.GmtActive");
			data.UtcActive = context.StringValue("QueryDeviceDetail.Data.UtcActive");
			data.GmtOnline = context.StringValue("QueryDeviceDetail.Data.GmtOnline");
			data.UtcOnline = context.StringValue("QueryDeviceDetail.Data.UtcOnline");
			data.Status = context.StringValue("QueryDeviceDetail.Data.Status");
			data.IpAddress = context.StringValue("QueryDeviceDetail.Data.IpAddress");
			data.NodeType = context.IntegerValue("QueryDeviceDetail.Data.NodeType");
			data.Region = context.StringValue("QueryDeviceDetail.Data.Region");
			data.Owner = context.BooleanValue("QueryDeviceDetail.Data.Owner");
			data.Nickname = context.StringValue("QueryDeviceDetail.Data.Nickname");
			queryDeviceDetailResponse.Data = data;
        
			return queryDeviceDetailResponse;
        }
    }
}
