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
using Aliyun.Acs.Httpdns.Model.V20160201;

namespace Aliyun.Acs.Httpdns.Transform.V20160201
{
    public class GetAccountInfoResponseUnmarshaller
    {
        public static GetAccountInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAccountInfoResponse getAccountInfoResponse = new GetAccountInfoResponse();

			getAccountInfoResponse.HttpResponse = _ctx.HttpResponse;
			getAccountInfoResponse.RequestId = _ctx.StringValue("GetAccountInfo.RequestId");

			GetAccountInfoResponse.GetAccountInfo_AccountInfo accountInfo = new GetAccountInfoResponse.GetAccountInfo_AccountInfo();
			accountInfo.AccountId = _ctx.StringValue("GetAccountInfo.AccountInfo.AccountId");
			accountInfo.MonthFreeCount = _ctx.IntegerValue("GetAccountInfo.AccountInfo.MonthFreeCount");
			accountInfo.MonthHttpsResolveCount = _ctx.IntegerValue("GetAccountInfo.AccountInfo.MonthHttpsResolveCount");
			accountInfo.MonthResolveCount = _ctx.IntegerValue("GetAccountInfo.AccountInfo.MonthResolveCount");
			accountInfo.PackageCount = _ctx.IntegerValue("GetAccountInfo.AccountInfo.PackageCount");
			accountInfo.UserStatus = _ctx.IntegerValue("GetAccountInfo.AccountInfo.UserStatus");
			accountInfo.SignSecret = _ctx.StringValue("GetAccountInfo.AccountInfo.SignSecret");
			accountInfo.UnsignedEnabled = _ctx.BooleanValue("GetAccountInfo.AccountInfo.UnsignedEnabled");
			accountInfo.SignedCount = _ctx.LongValue("GetAccountInfo.AccountInfo.SignedCount");
			accountInfo.UnsignedCount = _ctx.LongValue("GetAccountInfo.AccountInfo.UnsignedCount");
			getAccountInfoResponse.AccountInfo = accountInfo;
        
			return getAccountInfoResponse;
        }
    }
}
