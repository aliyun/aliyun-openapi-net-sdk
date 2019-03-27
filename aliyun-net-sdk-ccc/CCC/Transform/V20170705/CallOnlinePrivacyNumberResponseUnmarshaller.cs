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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class CallOnlinePrivacyNumberResponseUnmarshaller
    {
        public static CallOnlinePrivacyNumberResponse Unmarshall(UnmarshallerContext context)
        {
			CallOnlinePrivacyNumberResponse callOnlinePrivacyNumberResponse = new CallOnlinePrivacyNumberResponse();

			callOnlinePrivacyNumberResponse.HttpResponse = context.HttpResponse;
			callOnlinePrivacyNumberResponse.RequestId = context.StringValue("CallOnlinePrivacyNumber.RequestId");
			callOnlinePrivacyNumberResponse.Success = context.BooleanValue("CallOnlinePrivacyNumber.Success");
			callOnlinePrivacyNumberResponse.Code = context.StringValue("CallOnlinePrivacyNumber.Code");
			callOnlinePrivacyNumberResponse.Message = context.StringValue("CallOnlinePrivacyNumber.Message");
			callOnlinePrivacyNumberResponse.HttpStatusCode = context.IntegerValue("CallOnlinePrivacyNumber.HttpStatusCode");

			CallOnlinePrivacyNumberResponse.CallOnlinePrivacyNumber_Data data = new CallOnlinePrivacyNumberResponse.CallOnlinePrivacyNumber_Data();
			data.StatusCode = context.StringValue("CallOnlinePrivacyNumber.Data.StatusCode");
			data.DateCreated = context.StringValue("CallOnlinePrivacyNumber.Data.DateCreated");
			data.Represent = context.StringValue("CallOnlinePrivacyNumber.Data.Represent");
			data.TelX = context.StringValue("CallOnlinePrivacyNumber.Data.TelX");
			data.CallId = context.StringValue("CallOnlinePrivacyNumber.Data.CallId");
			callOnlinePrivacyNumberResponse.Data = data;
        
			return callOnlinePrivacyNumberResponse;
        }
    }
}
