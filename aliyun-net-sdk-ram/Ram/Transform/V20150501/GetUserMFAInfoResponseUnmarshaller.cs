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
using Aliyun.Acs.Ram.Model.V20150501;

namespace Aliyun.Acs.Ram.Transform.V20150501
{
    public class GetUserMFAInfoResponseUnmarshaller
    {
        public static GetUserMFAInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetUserMFAInfoResponse getUserMFAInfoResponse = new GetUserMFAInfoResponse();

			getUserMFAInfoResponse.HttpResponse = _ctx.HttpResponse;
			getUserMFAInfoResponse.RequestId = _ctx.StringValue("GetUserMFAInfo.RequestId");

			GetUserMFAInfoResponse.GetUserMFAInfo_MFADevice mFADevice = new GetUserMFAInfoResponse.GetUserMFAInfo_MFADevice();
			mFADevice.SerialNumber = _ctx.StringValue("GetUserMFAInfo.MFADevice.SerialNumber");
			mFADevice.Type = _ctx.StringValue("GetUserMFAInfo.MFADevice.Type");
			getUserMFAInfoResponse.MFADevice = mFADevice;
        
			return getUserMFAInfoResponse;
        }
    }
}
