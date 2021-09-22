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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribePdnsUserInfoResponseUnmarshaller
    {
        public static DescribePdnsUserInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePdnsUserInfoResponse describePdnsUserInfoResponse = new DescribePdnsUserInfoResponse();

			describePdnsUserInfoResponse.HttpResponse = _ctx.HttpResponse;
			describePdnsUserInfoResponse.RequestId = _ctx.StringValue("DescribePdnsUserInfo.RequestId");

			DescribePdnsUserInfoResponse.DescribePdnsUserInfo_UserInfo userInfo = new DescribePdnsUserInfoResponse.DescribePdnsUserInfo_UserInfo();
			userInfo.AvailableService = _ctx.StringValue("DescribePdnsUserInfo.UserInfo.AvailableService");
			userInfo.ServiceType = _ctx.StringValue("DescribePdnsUserInfo.UserInfo.ServiceType");
			userInfo.State = _ctx.StringValue("DescribePdnsUserInfo.UserInfo.State");
			userInfo.StoppedService = _ctx.StringValue("DescribePdnsUserInfo.UserInfo.StoppedService");
			userInfo.PdnsId = _ctx.LongValue("DescribePdnsUserInfo.UserInfo.PdnsId");
			describePdnsUserInfoResponse.UserInfo = userInfo;
        
			return describePdnsUserInfoResponse;
        }
    }
}
