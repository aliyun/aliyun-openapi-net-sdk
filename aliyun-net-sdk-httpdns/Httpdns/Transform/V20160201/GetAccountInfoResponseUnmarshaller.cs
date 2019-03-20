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
        public static GetAccountInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetAccountInfoResponse getAccountInfoResponse = new GetAccountInfoResponse();

			getAccountInfoResponse.HttpResponse = context.HttpResponse;
			getAccountInfoResponse.RequestId = context.StringValue("GetAccountInfo.RequestId");

			GetAccountInfoResponse.GetAccountInfo_AccountInfo accountInfo = new GetAccountInfoResponse.GetAccountInfo_AccountInfo();
			accountInfo.AccountId = context.StringValue("GetAccountInfo.AccountInfo.AccountId");
			accountInfo.MonthFreeCount = context.IntegerValue("GetAccountInfo.AccountInfo.MonthFreeCount");
			accountInfo.MonthHttpsResolveCount = context.IntegerValue("GetAccountInfo.AccountInfo.MonthHttpsResolveCount");
			accountInfo.MonthResolveCount = context.IntegerValue("GetAccountInfo.AccountInfo.MonthResolveCount");
			accountInfo.PackageCount = context.IntegerValue("GetAccountInfo.AccountInfo.PackageCount");
			accountInfo.UserStatus = context.IntegerValue("GetAccountInfo.AccountInfo.UserStatus");
			accountInfo.SignSecret = context.StringValue("GetAccountInfo.AccountInfo.SignSecret");
			accountInfo.UnsignedEnabled = context.BooleanValue("GetAccountInfo.AccountInfo.UnsignedEnabled");
			accountInfo.SignedCount = context.LongValue("GetAccountInfo.AccountInfo.SignedCount");
			accountInfo.UnsignedCount = context.LongValue("GetAccountInfo.AccountInfo.UnsignedCount");
			getAccountInfoResponse.AccountInfo = accountInfo;
        
			return getAccountInfoResponse;
        }
    }
}
