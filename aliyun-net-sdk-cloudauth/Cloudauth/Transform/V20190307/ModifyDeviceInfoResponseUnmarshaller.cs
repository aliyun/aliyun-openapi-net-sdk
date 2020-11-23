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
using Aliyun.Acs.Cloudauth.Model.V20190307;

namespace Aliyun.Acs.Cloudauth.Transform.V20190307
{
    public class ModifyDeviceInfoResponseUnmarshaller
    {
        public static ModifyDeviceInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyDeviceInfoResponse modifyDeviceInfoResponse = new ModifyDeviceInfoResponse();

			modifyDeviceInfoResponse.HttpResponse = _ctx.HttpResponse;
			modifyDeviceInfoResponse.RequestId = _ctx.StringValue("ModifyDeviceInfo.RequestId");
			modifyDeviceInfoResponse.DeviceId = _ctx.StringValue("ModifyDeviceInfo.DeviceId");
			modifyDeviceInfoResponse.UserDeviceId = _ctx.StringValue("ModifyDeviceInfo.UserDeviceId");
			modifyDeviceInfoResponse.BizType = _ctx.StringValue("ModifyDeviceInfo.BizType");
			modifyDeviceInfoResponse.BeginDay = _ctx.StringValue("ModifyDeviceInfo.BeginDay");
			modifyDeviceInfoResponse.ExpiredDay = _ctx.StringValue("ModifyDeviceInfo.ExpiredDay");
        
			return modifyDeviceInfoResponse;
        }
    }
}
