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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class GetCustomerAccountInfoResponseUnmarshaller
    {
        public static GetCustomerAccountInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCustomerAccountInfoResponse getCustomerAccountInfoResponse = new GetCustomerAccountInfoResponse();

			getCustomerAccountInfoResponse.HttpResponse = _ctx.HttpResponse;
			getCustomerAccountInfoResponse.RequestId = _ctx.StringValue("GetCustomerAccountInfo.RequestId");
			getCustomerAccountInfoResponse.Success = _ctx.BooleanValue("GetCustomerAccountInfo.Success");
			getCustomerAccountInfoResponse.Code = _ctx.StringValue("GetCustomerAccountInfo.Code");
			getCustomerAccountInfoResponse.Message = _ctx.StringValue("GetCustomerAccountInfo.Message");

			GetCustomerAccountInfoResponse.GetCustomerAccountInfo_Data data = new GetCustomerAccountInfoResponse.GetCustomerAccountInfo_Data();
			data.LoginEmail = _ctx.StringValue("GetCustomerAccountInfo.Data.LoginEmail");
			data.AccountType = _ctx.StringValue("GetCustomerAccountInfo.Data.AccountType");
			data.Mpk = _ctx.LongValue("GetCustomerAccountInfo.Data.Mpk");
			data.HostingStatus = _ctx.StringValue("GetCustomerAccountInfo.Data.HostingStatus");
			data.CreditLimitStatus = _ctx.StringValue("GetCustomerAccountInfo.Data.CreditLimitStatus");
			data.IsCertified = _ctx.BooleanValue("GetCustomerAccountInfo.Data.IsCertified");
			getCustomerAccountInfoResponse.Data = data;
        
			return getCustomerAccountInfoResponse;
        }
    }
}
