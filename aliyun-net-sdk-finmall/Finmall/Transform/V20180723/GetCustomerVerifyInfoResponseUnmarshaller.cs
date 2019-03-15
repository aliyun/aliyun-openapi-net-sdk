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
using Aliyun.Acs.finmall.Model.V20180723;

namespace Aliyun.Acs.finmall.Transform.V20180723
{
    public class GetCustomerVerifyInfoResponseUnmarshaller
    {
        public static GetCustomerVerifyInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetCustomerVerifyInfoResponse getCustomerVerifyInfoResponse = new GetCustomerVerifyInfoResponse();

			getCustomerVerifyInfoResponse.HttpResponse = context.HttpResponse;
			getCustomerVerifyInfoResponse.Code = context.StringValue("GetCustomerVerifyInfo.Code");
			getCustomerVerifyInfoResponse.Message = context.StringValue("GetCustomerVerifyInfo.Message");
			getCustomerVerifyInfoResponse.RequestId = context.StringValue("GetCustomerVerifyInfo.RequestId");

			GetCustomerVerifyInfoResponse.GetCustomerVerifyInfo_Data data = new GetCustomerVerifyInfoResponse.GetCustomerVerifyInfo_Data();
			data.LegalPersonName = context.StringValue("GetCustomerVerifyInfo.Data.LegalPersonName");
			data.IdCardNumber = context.StringValue("GetCustomerVerifyInfo.Data.IdCardNumber");
			data.EnterpriseName = context.StringValue("GetCustomerVerifyInfo.Data.EnterpriseName");
			data.BusinessLicense = context.StringValue("GetCustomerVerifyInfo.Data.BusinessLicense");
			data.Address = context.StringValue("GetCustomerVerifyInfo.Data.Address");
			data.PhoneNumber = context.StringValue("GetCustomerVerifyInfo.Data.PhoneNumber");
			data.BankCard = context.StringValue("GetCustomerVerifyInfo.Data.BankCard");
			data.LoanSubject = context.StringValue("GetCustomerVerifyInfo.Data.LoanSubject");
			data.IdCardFrontPage = context.StringValue("GetCustomerVerifyInfo.Data.IdCardFrontPage");
			data.IdCardBackPage = context.StringValue("GetCustomerVerifyInfo.Data.IdCardBackPage");
			data.ValidateTime = context.StringValue("GetCustomerVerifyInfo.Data.ValidateTime");
			data.ValidateState = context.StringValue("GetCustomerVerifyInfo.Data.ValidateState");
			data.Email = context.StringValue("GetCustomerVerifyInfo.Data.Email");
			getCustomerVerifyInfoResponse.Data = data;
        
			return getCustomerVerifyInfoResponse;
        }
    }
}
