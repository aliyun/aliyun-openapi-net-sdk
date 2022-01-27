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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DeleteRenderingDeviceInternetPortsResponseUnmarshaller
    {
        public static DeleteRenderingDeviceInternetPortsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteRenderingDeviceInternetPortsResponse deleteRenderingDeviceInternetPortsResponse = new DeleteRenderingDeviceInternetPortsResponse();

			deleteRenderingDeviceInternetPortsResponse.HttpResponse = _ctx.HttpResponse;
			deleteRenderingDeviceInternetPortsResponse.RequestId = _ctx.StringValue("DeleteRenderingDeviceInternetPorts.RequestId");

			List<string> deleteRenderingDeviceInternetPortsResponse_instanceIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DeleteRenderingDeviceInternetPorts.InstanceIds.Length"); i++) {
				deleteRenderingDeviceInternetPortsResponse_instanceIds.Add(_ctx.StringValue("DeleteRenderingDeviceInternetPorts.InstanceIds["+ i +"]"));
			}
			deleteRenderingDeviceInternetPortsResponse.InstanceIds = deleteRenderingDeviceInternetPortsResponse_instanceIds;
        
			return deleteRenderingDeviceInternetPortsResponse;
        }
    }
}
