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
        public static InitDeviceResponse Unmarshall(UnmarshallerContext context)
        {
			InitDeviceResponse initDeviceResponse = new InitDeviceResponse();

			initDeviceResponse.HttpResponse = context.HttpResponse;
			initDeviceResponse.RequestId = context.StringValue("InitDevice.RequestId");
			initDeviceResponse.Message = context.StringValue("InitDevice.Message");
			initDeviceResponse.Code = context.StringValue("InitDevice.Code");

			InitDeviceResponse.InitDevice_ResultObject resultObject = new InitDeviceResponse.InitDevice_ResultObject();
			resultObject.CertifyId = context.StringValue("InitDevice.ResultObject.CertifyId");
			resultObject.Protocol = context.StringValue("InitDevice.ResultObject.Protocol");
			resultObject.ExtParams = context.StringValue("InitDevice.ResultObject.ExtParams");
			resultObject.RetCode = context.StringValue("InitDevice.ResultObject.RetCode");
			resultObject.RetCodeSub = context.StringValue("InitDevice.ResultObject.RetCodeSub");
			resultObject.RetMessageSub = context.StringValue("InitDevice.ResultObject.RetMessageSub");
			resultObject.Message = context.StringValue("InitDevice.ResultObject.Message");
			resultObject.OssEndPoint = context.StringValue("InitDevice.ResultObject.OssEndPoint");
			resultObject.AccessKeyId = context.StringValue("InitDevice.ResultObject.AccessKeyId");
			resultObject.AccessKeySecret = context.StringValue("InitDevice.ResultObject.AccessKeySecret");
			resultObject.SecurityToken = context.StringValue("InitDevice.ResultObject.SecurityToken");
			resultObject.BucketName = context.StringValue("InitDevice.ResultObject.BucketName");
			resultObject.FileNamePrefix = context.StringValue("InitDevice.ResultObject.FileNamePrefix");
			resultObject.FileName = context.StringValue("InitDevice.ResultObject.FileName");
			resultObject.PresignedUrl = context.StringValue("InitDevice.ResultObject.PresignedUrl");
			initDeviceResponse.ResultObject = resultObject;
        
			return initDeviceResponse;
        }
    }
}
