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
    public class InitDeviceResponseUnmarshaller
    {
        public static InitDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			InitDeviceResponse initDeviceResponse = new InitDeviceResponse();

			initDeviceResponse.HttpResponse = _ctx.HttpResponse;
			initDeviceResponse.RequestId = _ctx.StringValue("InitDevice.RequestId");
			initDeviceResponse.Message = _ctx.StringValue("InitDevice.Message");
			initDeviceResponse.Code = _ctx.StringValue("InitDevice.Code");

			InitDeviceResponse.InitDevice_ResultObject resultObject = new InitDeviceResponse.InitDevice_ResultObject();
			resultObject.CertifyId = _ctx.StringValue("InitDevice.ResultObject.CertifyId");
			resultObject.Protocol = _ctx.StringValue("InitDevice.ResultObject.Protocol");
			resultObject.ExtParams = _ctx.StringValue("InitDevice.ResultObject.ExtParams");
			resultObject.RetCode = _ctx.StringValue("InitDevice.ResultObject.RetCode");
			resultObject.RetCodeSub = _ctx.StringValue("InitDevice.ResultObject.RetCodeSub");
			resultObject.RetMessageSub = _ctx.StringValue("InitDevice.ResultObject.RetMessageSub");
			resultObject.Message = _ctx.StringValue("InitDevice.ResultObject.Message");
			resultObject.OssEndPoint = _ctx.StringValue("InitDevice.ResultObject.OssEndPoint");
			resultObject.AccessKeyId = _ctx.StringValue("InitDevice.ResultObject.AccessKeyId");
			resultObject.AccessKeySecret = _ctx.StringValue("InitDevice.ResultObject.AccessKeySecret");
			resultObject.SecurityToken = _ctx.StringValue("InitDevice.ResultObject.SecurityToken");
			resultObject.BucketName = _ctx.StringValue("InitDevice.ResultObject.BucketName");
			resultObject.FileNamePrefix = _ctx.StringValue("InitDevice.ResultObject.FileNamePrefix");
			resultObject.FileName = _ctx.StringValue("InitDevice.ResultObject.FileName");
			resultObject.PresignedUrl = _ctx.StringValue("InitDevice.ResultObject.PresignedUrl");
			initDeviceResponse.ResultObject = resultObject;
        
			return initDeviceResponse;
        }
    }
}
