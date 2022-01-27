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
    public class ListOTAUnfinishedTaskByDeviceResponseUnmarshaller
    {
        public static ListOTAUnfinishedTaskByDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOTAUnfinishedTaskByDeviceResponse listOTAUnfinishedTaskByDeviceResponse = new ListOTAUnfinishedTaskByDeviceResponse();

			listOTAUnfinishedTaskByDeviceResponse.HttpResponse = _ctx.HttpResponse;
			listOTAUnfinishedTaskByDeviceResponse.RequestId = _ctx.StringValue("ListOTAUnfinishedTaskByDevice.RequestId");
			listOTAUnfinishedTaskByDeviceResponse.Success = _ctx.BooleanValue("ListOTAUnfinishedTaskByDevice.Success");
			listOTAUnfinishedTaskByDeviceResponse.Code = _ctx.StringValue("ListOTAUnfinishedTaskByDevice.Code");
			listOTAUnfinishedTaskByDeviceResponse.ErrorMessage = _ctx.StringValue("ListOTAUnfinishedTaskByDevice.ErrorMessage");

			List<ListOTAUnfinishedTaskByDeviceResponse.ListOTAUnfinishedTaskByDevice_SimpleOTATaskInfo> listOTAUnfinishedTaskByDeviceResponse_data = new List<ListOTAUnfinishedTaskByDeviceResponse.ListOTAUnfinishedTaskByDevice_SimpleOTATaskInfo>();
			for (int i = 0; i < _ctx.Length("ListOTAUnfinishedTaskByDevice.Data.Length"); i++) {
				ListOTAUnfinishedTaskByDeviceResponse.ListOTAUnfinishedTaskByDevice_SimpleOTATaskInfo simpleOTATaskInfo = new ListOTAUnfinishedTaskByDeviceResponse.ListOTAUnfinishedTaskByDevice_SimpleOTATaskInfo();
				simpleOTATaskInfo.TaskId = _ctx.StringValue("ListOTAUnfinishedTaskByDevice.Data["+ i +"].TaskId");
				simpleOTATaskInfo.UtcModified = _ctx.StringValue("ListOTAUnfinishedTaskByDevice.Data["+ i +"].UtcModified");
				simpleOTATaskInfo.ProductKey = _ctx.StringValue("ListOTAUnfinishedTaskByDevice.Data["+ i +"].ProductKey");
				simpleOTATaskInfo.TaskStatus = _ctx.StringValue("ListOTAUnfinishedTaskByDevice.Data["+ i +"].TaskStatus");
				simpleOTATaskInfo.JobId = _ctx.StringValue("ListOTAUnfinishedTaskByDevice.Data["+ i +"].JobId");
				simpleOTATaskInfo.ProductName = _ctx.StringValue("ListOTAUnfinishedTaskByDevice.Data["+ i +"].ProductName");
				simpleOTATaskInfo.DeviceName = _ctx.StringValue("ListOTAUnfinishedTaskByDevice.Data["+ i +"].DeviceName");
				simpleOTATaskInfo.SrcVersion = _ctx.StringValue("ListOTAUnfinishedTaskByDevice.Data["+ i +"].SrcVersion");
				simpleOTATaskInfo.DestVersion = _ctx.StringValue("ListOTAUnfinishedTaskByDevice.Data["+ i +"].DestVersion");
				simpleOTATaskInfo.IotId = _ctx.StringValue("ListOTAUnfinishedTaskByDevice.Data["+ i +"].IotId");
				simpleOTATaskInfo.UtcCreate = _ctx.StringValue("ListOTAUnfinishedTaskByDevice.Data["+ i +"].UtcCreate");
				simpleOTATaskInfo.ModuleName = _ctx.StringValue("ListOTAUnfinishedTaskByDevice.Data["+ i +"].ModuleName");
				simpleOTATaskInfo.FirmwareId = _ctx.StringValue("ListOTAUnfinishedTaskByDevice.Data["+ i +"].FirmwareId");

				listOTAUnfinishedTaskByDeviceResponse_data.Add(simpleOTATaskInfo);
			}
			listOTAUnfinishedTaskByDeviceResponse.Data = listOTAUnfinishedTaskByDeviceResponse_data;
        
			return listOTAUnfinishedTaskByDeviceResponse;
        }
    }
}
