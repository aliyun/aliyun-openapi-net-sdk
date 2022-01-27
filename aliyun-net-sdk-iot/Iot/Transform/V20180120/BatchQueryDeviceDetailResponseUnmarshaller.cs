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
    public class BatchQueryDeviceDetailResponseUnmarshaller
    {
        public static BatchQueryDeviceDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchQueryDeviceDetailResponse batchQueryDeviceDetailResponse = new BatchQueryDeviceDetailResponse();

			batchQueryDeviceDetailResponse.HttpResponse = _ctx.HttpResponse;
			batchQueryDeviceDetailResponse.RequestId = _ctx.StringValue("BatchQueryDeviceDetail.RequestId");
			batchQueryDeviceDetailResponse.Success = _ctx.BooleanValue("BatchQueryDeviceDetail.Success");
			batchQueryDeviceDetailResponse.Code = _ctx.StringValue("BatchQueryDeviceDetail.Code");
			batchQueryDeviceDetailResponse.ErrorMessage = _ctx.StringValue("BatchQueryDeviceDetail.ErrorMessage");

			List<BatchQueryDeviceDetailResponse.BatchQueryDeviceDetail_DataItem> batchQueryDeviceDetailResponse_data = new List<BatchQueryDeviceDetailResponse.BatchQueryDeviceDetail_DataItem>();
			for (int i = 0; i < _ctx.Length("BatchQueryDeviceDetail.Data.Length"); i++) {
				BatchQueryDeviceDetailResponse.BatchQueryDeviceDetail_DataItem dataItem = new BatchQueryDeviceDetailResponse.BatchQueryDeviceDetail_DataItem();
				dataItem.ProductKey = _ctx.StringValue("BatchQueryDeviceDetail.Data["+ i +"].ProductKey");
				dataItem.ProductName = _ctx.StringValue("BatchQueryDeviceDetail.Data["+ i +"].ProductName");
				dataItem.DeviceName = _ctx.StringValue("BatchQueryDeviceDetail.Data["+ i +"].DeviceName");
				dataItem.Nickname = _ctx.StringValue("BatchQueryDeviceDetail.Data["+ i +"].Nickname");
				dataItem.DeviceSecret = _ctx.StringValue("BatchQueryDeviceDetail.Data["+ i +"].DeviceSecret");
				dataItem.IotId = _ctx.StringValue("BatchQueryDeviceDetail.Data["+ i +"].IotId");
				dataItem.UtcCreate = _ctx.StringValue("BatchQueryDeviceDetail.Data["+ i +"].UtcCreate");
				dataItem.GmtCreate = _ctx.StringValue("BatchQueryDeviceDetail.Data["+ i +"].GmtCreate");
				dataItem.UtcActive = _ctx.StringValue("BatchQueryDeviceDetail.Data["+ i +"].UtcActive");
				dataItem.GmtActive = _ctx.StringValue("BatchQueryDeviceDetail.Data["+ i +"].GmtActive");
				dataItem.Status = _ctx.StringValue("BatchQueryDeviceDetail.Data["+ i +"].Status");
				dataItem.FirmwareVersion = _ctx.StringValue("BatchQueryDeviceDetail.Data["+ i +"].FirmwareVersion");
				dataItem.NodeType = _ctx.IntegerValue("BatchQueryDeviceDetail.Data["+ i +"].NodeType");
				dataItem.Region = _ctx.StringValue("BatchQueryDeviceDetail.Data["+ i +"].Region");

				batchQueryDeviceDetailResponse_data.Add(dataItem);
			}
			batchQueryDeviceDetailResponse.Data = batchQueryDeviceDetailResponse_data;
        
			return batchQueryDeviceDetailResponse;
        }
    }
}
