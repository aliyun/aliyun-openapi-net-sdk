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
    public class BindDeviceResponseUnmarshaller
    {
        public static BindDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BindDeviceResponse bindDeviceResponse = new BindDeviceResponse();

			bindDeviceResponse.HttpResponse = _ctx.HttpResponse;
			bindDeviceResponse.RequestId = _ctx.StringValue("BindDevice.RequestId");
			bindDeviceResponse.Code = _ctx.StringValue("BindDevice.Code");
			bindDeviceResponse.Message = _ctx.StringValue("BindDevice.Message");

			List<BindDeviceResponse.BindDevice_Datas> bindDeviceResponse_data = new List<BindDeviceResponse.BindDevice_Datas>();
			for (int i = 0; i < _ctx.Length("BindDevice.Data.Length"); i++) {
				BindDeviceResponse.BindDevice_Datas datas = new BindDeviceResponse.BindDevice_Datas();
				datas.Success = _ctx.BooleanValue("BindDevice.Data["+ i +"].Success");
				datas.Code = _ctx.StringValue("BindDevice.Data["+ i +"].Code");
				datas.Message = _ctx.StringValue("BindDevice.Data["+ i +"].Message");
				datas.DeviceId = _ctx.StringValue("BindDevice.Data["+ i +"].DeviceId");

				bindDeviceResponse_data.Add(datas);
			}
			bindDeviceResponse.Data = bindDeviceResponse_data;
        
			return bindDeviceResponse;
        }
    }
}
