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
			initDeviceResponse.Code = _ctx.StringValue("InitDevice.Code");
			initDeviceResponse.Message = _ctx.StringValue("InitDevice.Message");
			initDeviceResponse.RequestId = _ctx.StringValue("InitDevice.RequestId");

			InitDeviceResponse.InitDevice_ResultObject resultObject = new InitDeviceResponse.InitDevice_ResultObject();
			resultObject.OssEndPoint = _ctx.StringValue("InitDevice.ResultObject.OssEndPoint");
			resultObject.RetCodeSub = _ctx.StringValue("InitDevice.ResultObject.RetCodeSub");
			resultObject.Protocol = _ctx.StringValue("InitDevice.ResultObject.Protocol");
			resultObject.CertifyId = _ctx.StringValue("InitDevice.ResultObject.CertifyId");
			resultObject.ExtParams = _ctx.StringValue("InitDevice.ResultObject.ExtParams");
			resultObject.Message = _ctx.StringValue("InitDevice.ResultObject.Message");
			resultObject.FileName = _ctx.StringValue("InitDevice.ResultObject.FileName");
			resultObject.AccessKeyId = _ctx.StringValue("InitDevice.ResultObject.AccessKeyId");
			resultObject.PresignedUrl = _ctx.StringValue("InitDevice.ResultObject.PresignedUrl");
			resultObject.SecurityToken = _ctx.StringValue("InitDevice.ResultObject.SecurityToken");
			resultObject.FileNamePrefix = _ctx.StringValue("InitDevice.ResultObject.FileNamePrefix");
			resultObject.BucketName = _ctx.StringValue("InitDevice.ResultObject.BucketName");
			resultObject.AccessKeySecret = _ctx.StringValue("InitDevice.ResultObject.AccessKeySecret");
			resultObject.RetMessageSub = _ctx.StringValue("InitDevice.ResultObject.RetMessageSub");
			resultObject.RetCode = _ctx.StringValue("InitDevice.ResultObject.RetCode");
			initDeviceResponse.ResultObject = resultObject;
        
			return initDeviceResponse;
        }
    }
}
