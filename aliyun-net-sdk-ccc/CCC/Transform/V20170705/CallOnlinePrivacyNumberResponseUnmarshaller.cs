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
        public static CallOnlinePrivacyNumberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CallOnlinePrivacyNumberResponse callOnlinePrivacyNumberResponse = new CallOnlinePrivacyNumberResponse();

			callOnlinePrivacyNumberResponse.HttpResponse = _ctx.HttpResponse;
			callOnlinePrivacyNumberResponse.RequestId = _ctx.StringValue("CallOnlinePrivacyNumber.RequestId");
			callOnlinePrivacyNumberResponse.Success = _ctx.BooleanValue("CallOnlinePrivacyNumber.Success");
			callOnlinePrivacyNumberResponse.Code = _ctx.StringValue("CallOnlinePrivacyNumber.Code");
			callOnlinePrivacyNumberResponse.Message = _ctx.StringValue("CallOnlinePrivacyNumber.Message");
			callOnlinePrivacyNumberResponse.HttpStatusCode = _ctx.IntegerValue("CallOnlinePrivacyNumber.HttpStatusCode");

			CallOnlinePrivacyNumberResponse.CallOnlinePrivacyNumber_Data data = new CallOnlinePrivacyNumberResponse.CallOnlinePrivacyNumber_Data();
			data.StatusCode = _ctx.StringValue("CallOnlinePrivacyNumber.Data.StatusCode");
			data.DateCreated = _ctx.StringValue("CallOnlinePrivacyNumber.Data.DateCreated");
			data.Represent = _ctx.StringValue("CallOnlinePrivacyNumber.Data.Represent");
			data.TelX = _ctx.StringValue("CallOnlinePrivacyNumber.Data.TelX");
			data.CallId = _ctx.StringValue("CallOnlinePrivacyNumber.Data.CallId");
			callOnlinePrivacyNumberResponse.Data = data;
        
			return callOnlinePrivacyNumberResponse;
        }
    }
}
