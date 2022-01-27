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
        public static QueryDeviceDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceDetailResponse queryDeviceDetailResponse = new QueryDeviceDetailResponse();

			queryDeviceDetailResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceDetailResponse.RequestId = _ctx.StringValue("QueryDeviceDetail.RequestId");
			queryDeviceDetailResponse.Success = _ctx.BooleanValue("QueryDeviceDetail.Success");
			queryDeviceDetailResponse.Code = _ctx.StringValue("QueryDeviceDetail.Code");
			queryDeviceDetailResponse.ErrorMessage = _ctx.StringValue("QueryDeviceDetail.ErrorMessage");

			QueryDeviceDetailResponse.QueryDeviceDetail_Data data = new QueryDeviceDetailResponse.QueryDeviceDetail_Data();
			data.IotId = _ctx.StringValue("QueryDeviceDetail.Data.IotId");
			data.ProductKey = _ctx.StringValue("QueryDeviceDetail.Data.ProductKey");
			data.ProductName = _ctx.StringValue("QueryDeviceDetail.Data.ProductName");
			data.DeviceName = _ctx.StringValue("QueryDeviceDetail.Data.DeviceName");
			data.DeviceSecret = _ctx.StringValue("QueryDeviceDetail.Data.DeviceSecret");
			data.FirmwareVersion = _ctx.StringValue("QueryDeviceDetail.Data.FirmwareVersion");
			data.GmtCreate = _ctx.StringValue("QueryDeviceDetail.Data.GmtCreate");
			data.UtcCreate = _ctx.StringValue("QueryDeviceDetail.Data.UtcCreate");
			data.GmtActive = _ctx.StringValue("QueryDeviceDetail.Data.GmtActive");
			data.UtcActive = _ctx.StringValue("QueryDeviceDetail.Data.UtcActive");
			data.GmtOnline = _ctx.StringValue("QueryDeviceDetail.Data.GmtOnline");
			data.UtcOnline = _ctx.StringValue("QueryDeviceDetail.Data.UtcOnline");
			data.Status = _ctx.StringValue("QueryDeviceDetail.Data.Status");
			data.IpAddress = _ctx.StringValue("QueryDeviceDetail.Data.IpAddress");
			data.NodeType = _ctx.IntegerValue("QueryDeviceDetail.Data.NodeType");
			data.Region = _ctx.StringValue("QueryDeviceDetail.Data.Region");
			data.Owner = _ctx.BooleanValue("QueryDeviceDetail.Data.Owner");
			data.Nickname = _ctx.StringValue("QueryDeviceDetail.Data.Nickname");
			queryDeviceDetailResponse.Data = data;
        
			return queryDeviceDetailResponse;
        }
    }
}
