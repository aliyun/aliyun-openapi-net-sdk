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
    public class ListDistributedDeviceResponseUnmarshaller
    {
        public static ListDistributedDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDistributedDeviceResponse listDistributedDeviceResponse = new ListDistributedDeviceResponse();

			listDistributedDeviceResponse.HttpResponse = _ctx.HttpResponse;
			listDistributedDeviceResponse.RequestId = _ctx.StringValue("ListDistributedDevice.RequestId");
			listDistributedDeviceResponse.Success = _ctx.BooleanValue("ListDistributedDevice.Success");
			listDistributedDeviceResponse.Code = _ctx.StringValue("ListDistributedDevice.Code");
			listDistributedDeviceResponse.ErrorMessage = _ctx.StringValue("ListDistributedDevice.ErrorMessage");

			ListDistributedDeviceResponse.ListDistributedDevice_Data data = new ListDistributedDeviceResponse.ListDistributedDevice_Data();
			data.Total = _ctx.IntegerValue("ListDistributedDevice.Data.Total");

			List<ListDistributedDeviceResponse.ListDistributedDevice_Data.ListDistributedDevice_Items> data_info = new List<ListDistributedDeviceResponse.ListDistributedDevice_Data.ListDistributedDevice_Items>();
			for (int i = 0; i < _ctx.Length("ListDistributedDevice.Data.Info.Length"); i++) {
				ListDistributedDeviceResponse.ListDistributedDevice_Data.ListDistributedDevice_Items items = new ListDistributedDeviceResponse.ListDistributedDevice_Data.ListDistributedDevice_Items();
				items.SourceUid = _ctx.StringValue("ListDistributedDevice.Data.Info["+ i +"].SourceUid");
				items.TargetUid = _ctx.StringValue("ListDistributedDevice.Data.Info["+ i +"].TargetUid");
				items.ProductKey = _ctx.StringValue("ListDistributedDevice.Data.Info["+ i +"].ProductKey");
				items.DeviceName = _ctx.StringValue("ListDistributedDevice.Data.Info["+ i +"].DeviceName");
				items.SourceInstanceId = _ctx.StringValue("ListDistributedDevice.Data.Info["+ i +"].SourceInstanceId");
				items.TargetInstanceId = _ctx.StringValue("ListDistributedDevice.Data.Info["+ i +"].TargetInstanceId");
				items.GmtCreate = _ctx.LongValue("ListDistributedDevice.Data.Info["+ i +"].GmtCreate");
				items.TargetAliyunId = _ctx.StringValue("ListDistributedDevice.Data.Info["+ i +"].TargetAliyunId");
				items.SourceRegion = _ctx.StringValue("ListDistributedDevice.Data.Info["+ i +"].SourceRegion");
				items.TargetRegion = _ctx.StringValue("ListDistributedDevice.Data.Info["+ i +"].TargetRegion");
				items.SourceInstanceName = _ctx.StringValue("ListDistributedDevice.Data.Info["+ i +"].SourceInstanceName");
				items.TargetInstanceName = _ctx.StringValue("ListDistributedDevice.Data.Info["+ i +"].TargetInstanceName");
				items.GmtModified = _ctx.LongValue("ListDistributedDevice.Data.Info["+ i +"].GmtModified");

				data_info.Add(items);
			}
			data.Info = data_info;
			listDistributedDeviceResponse.Data = data;
        
			return listDistributedDeviceResponse;
        }
    }
}
