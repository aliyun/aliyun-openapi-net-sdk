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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class UnbindDeviceResponseUnmarshaller
    {
        public static UnbindDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UnbindDeviceResponse unbindDeviceResponse = new UnbindDeviceResponse();

			unbindDeviceResponse.HttpResponse = _ctx.HttpResponse;
			unbindDeviceResponse.RequestId = _ctx.StringValue("UnbindDevice.RequestId");
			unbindDeviceResponse.Code = _ctx.StringValue("UnbindDevice.Code");
			unbindDeviceResponse.Message = _ctx.StringValue("UnbindDevice.Message");

			List<UnbindDeviceResponse.UnbindDevice_Datas> unbindDeviceResponse_data = new List<UnbindDeviceResponse.UnbindDevice_Datas>();
			for (int i = 0; i < _ctx.Length("UnbindDevice.Data.Length"); i++) {
				UnbindDeviceResponse.UnbindDevice_Datas datas = new UnbindDeviceResponse.UnbindDevice_Datas();
				datas.Success = _ctx.BooleanValue("UnbindDevice.Data["+ i +"].Success");
				datas.Code = _ctx.StringValue("UnbindDevice.Data["+ i +"].Code");
				datas.Message = _ctx.StringValue("UnbindDevice.Data["+ i +"].Message");
				datas.DeviceId = _ctx.StringValue("UnbindDevice.Data["+ i +"].DeviceId");

				unbindDeviceResponse_data.Add(datas);
			}
			unbindDeviceResponse.Data = unbindDeviceResponse_data;
        
			return unbindDeviceResponse;
        }
    }
}
