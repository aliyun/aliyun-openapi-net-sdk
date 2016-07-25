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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Iot.Model.V20160530;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Transform.V20160530
{
    public class ListDevicePermitsResponseUnmarshaller
    {
        public static ListDevicePermitsResponse Unmarshall(UnmarshallerContext context)
        {
			ListDevicePermitsResponse listDevicePermitsResponse = new ListDevicePermitsResponse();

			listDevicePermitsResponse.HttpResponse = context.HttpResponse;
			listDevicePermitsResponse.RequestId = context.StringValue("ListDevicePermits.RequestId");
			listDevicePermitsResponse.Success = context.BooleanValue("ListDevicePermits.Success");
			listDevicePermitsResponse.ErrorMessage = context.StringValue("ListDevicePermits.ErrorMessage");

			List<ListDevicePermitsResponse.DevicePermission> devicePermissions = new List<ListDevicePermitsResponse.DevicePermission>();
			for (int i = 0; i < context.Length("ListDevicePermits.DevicePermissions.Length"); i++) {
				ListDevicePermitsResponse.DevicePermission devicePermission = new ListDevicePermitsResponse.DevicePermission();
				devicePermission.Id = context.LongValue("ListDevicePermits.DevicePermissions["+ i +"].Id");
				devicePermission.GrantType = context.StringValue("ListDevicePermits.DevicePermissions["+ i +"].GrantType");
				devicePermission.TopicFullName = context.StringValue("ListDevicePermits.DevicePermissions["+ i +"].TopicFullName");
				devicePermission.TopicUserId = context.LongValue("ListDevicePermits.DevicePermissions["+ i +"].TopicUserId");

				devicePermissions.Add(devicePermission);
			}
			listDevicePermitsResponse.DevicePermissions = devicePermissions;
        
			return listDevicePermitsResponse;
        }
    }
}