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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Sas_api.Model.V20170705;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Sas_api.Transform.V20170705
{
    public class GetAccountProfileResponseUnmarshaller
    {
        public static GetAccountProfileResponse Unmarshall(UnmarshallerContext context)
        {
			GetAccountProfileResponse getAccountProfileResponse = new GetAccountProfileResponse();

			getAccountProfileResponse.HttpResponse = context.HttpResponse;
			getAccountProfileResponse.Code = context.IntegerValue("GetAccountProfile.Code");
			getAccountProfileResponse.Message = context.StringValue("GetAccountProfile.Message");
			getAccountProfileResponse.Success = context.BooleanValue("GetAccountProfile.Success");
			getAccountProfileResponse.RequestId = context.StringValue("GetAccountProfile.RequestId");

			GetAccountProfileResponse.GetAccountProfile_Data data = new GetAccountProfileResponse.GetAccountProfile_Data();
			data.Ip = context.StringValue("GetAccountProfile.Data.Ip");
			data.Phone = context.StringValue("GetAccountProfile.Data.Phone");
			data.IpInfo = context.StringValue("GetAccountProfile.Data.IpInfo");
			data.PhoneInfo = context.StringValue("GetAccountProfile.Data.PhoneInfo");
			getAccountProfileResponse.Data = data;
        
			return getAccountProfileResponse;
        }
    }
}