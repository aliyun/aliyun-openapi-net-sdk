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
        public static GenerateDeviceNameListURLResponse Unmarshall(UnmarshallerContext context)
        {
			GenerateDeviceNameListURLResponse generateDeviceNameListURLResponse = new GenerateDeviceNameListURLResponse();

			generateDeviceNameListURLResponse.HttpResponse = context.HttpResponse;
			generateDeviceNameListURLResponse.RequestId = context.StringValue("GenerateDeviceNameListURL.RequestId");
			generateDeviceNameListURLResponse.Success = context.BooleanValue("GenerateDeviceNameListURL.Success");
			generateDeviceNameListURLResponse.Code = context.StringValue("GenerateDeviceNameListURL.Code");
			generateDeviceNameListURLResponse.ErrorMessage = context.StringValue("GenerateDeviceNameListURL.ErrorMessage");

			GenerateDeviceNameListURLResponse.GenerateDeviceNameListURL_Data data = new GenerateDeviceNameListURLResponse.GenerateDeviceNameListURL_Data();
			data.Key = context.StringValue("GenerateDeviceNameListURL.Data.Key");
			data.Host = context.StringValue("GenerateDeviceNameListURL.Data.Host");
			data.Policy = context.StringValue("GenerateDeviceNameListURL.Data.Policy");
			data.AccessKeyId = context.StringValue("GenerateDeviceNameListURL.Data.AccessKeyId");
			data.Signature = context.StringValue("GenerateDeviceNameListURL.Data.Signature");
			data.FileUrl = context.StringValue("GenerateDeviceNameListURL.Data.FileUrl");
			data.UtcCreate = context.StringValue("GenerateDeviceNameListURL.Data.UtcCreate");
			data.ObjectStorage = context.StringValue("GenerateDeviceNameListURL.Data.ObjectStorage");
			generateDeviceNameListURLResponse.Data = data;
        
			return generateDeviceNameListURLResponse;
        }
    }
}
