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
    public class GenerateDeviceNameListURLResponseUnmarshaller
    {
        public static GenerateDeviceNameListURLResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GenerateDeviceNameListURLResponse generateDeviceNameListURLResponse = new GenerateDeviceNameListURLResponse();

			generateDeviceNameListURLResponse.HttpResponse = _ctx.HttpResponse;
			generateDeviceNameListURLResponse.RequestId = _ctx.StringValue("GenerateDeviceNameListURL.RequestId");
			generateDeviceNameListURLResponse.Success = _ctx.BooleanValue("GenerateDeviceNameListURL.Success");
			generateDeviceNameListURLResponse.Code = _ctx.StringValue("GenerateDeviceNameListURL.Code");
			generateDeviceNameListURLResponse.ErrorMessage = _ctx.StringValue("GenerateDeviceNameListURL.ErrorMessage");

			GenerateDeviceNameListURLResponse.GenerateDeviceNameListURL_Data data = new GenerateDeviceNameListURLResponse.GenerateDeviceNameListURL_Data();
			data.Key = _ctx.StringValue("GenerateDeviceNameListURL.Data.Key");
			data.Host = _ctx.StringValue("GenerateDeviceNameListURL.Data.Host");
			data.Policy = _ctx.StringValue("GenerateDeviceNameListURL.Data.Policy");
			data.AccessKeyId = _ctx.StringValue("GenerateDeviceNameListURL.Data.AccessKeyId");
			data.Signature = _ctx.StringValue("GenerateDeviceNameListURL.Data.Signature");
			data.FileUrl = _ctx.StringValue("GenerateDeviceNameListURL.Data.FileUrl");
			data.UtcCreate = _ctx.StringValue("GenerateDeviceNameListURL.Data.UtcCreate");
			data.ObjectStorage = _ctx.StringValue("GenerateDeviceNameListURL.Data.ObjectStorage");
			generateDeviceNameListURLResponse.Data = data;
        
			return generateDeviceNameListURLResponse;
        }
    }
}
