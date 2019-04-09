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
using Aliyun.Acs.Cloudauth.Model.V20180916;

namespace Aliyun.Acs.Cloudauth.Transform.V20180916
{
    public class ModifyDeviceInfoResponseUnmarshaller
    {
        public static ModifyDeviceInfoResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyDeviceInfoResponse modifyDeviceInfoResponse = new ModifyDeviceInfoResponse();

			modifyDeviceInfoResponse.HttpResponse = context.HttpResponse;
			modifyDeviceInfoResponse.RequestId = context.StringValue("ModifyDeviceInfo.RequestId");
			modifyDeviceInfoResponse.DeviceId = context.StringValue("ModifyDeviceInfo.DeviceId");
			modifyDeviceInfoResponse.UserDeviceId = context.StringValue("ModifyDeviceInfo.UserDeviceId");
			modifyDeviceInfoResponse.BizType = context.StringValue("ModifyDeviceInfo.BizType");
			modifyDeviceInfoResponse.BeginDay = context.StringValue("ModifyDeviceInfo.BeginDay");
			modifyDeviceInfoResponse.ExpiredDay = context.StringValue("ModifyDeviceInfo.ExpiredDay");
        
			return modifyDeviceInfoResponse;
        }
    }
}
