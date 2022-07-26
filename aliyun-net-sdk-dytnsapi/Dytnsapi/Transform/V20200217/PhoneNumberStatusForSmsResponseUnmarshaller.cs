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
using Aliyun.Acs.Dytnsapi.Model.V20200217;

namespace Aliyun.Acs.Dytnsapi.Transform.V20200217
{
    public class PhoneNumberStatusForSmsResponseUnmarshaller
    {
        public static PhoneNumberStatusForSmsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PhoneNumberStatusForSmsResponse phoneNumberStatusForSmsResponse = new PhoneNumberStatusForSmsResponse();

			phoneNumberStatusForSmsResponse.HttpResponse = _ctx.HttpResponse;
			phoneNumberStatusForSmsResponse.Code = _ctx.StringValue("PhoneNumberStatusForSms.Code");
			phoneNumberStatusForSmsResponse.Message = _ctx.StringValue("PhoneNumberStatusForSms.Message");
			phoneNumberStatusForSmsResponse.RequestId = _ctx.StringValue("PhoneNumberStatusForSms.RequestId");

			PhoneNumberStatusForSmsResponse.PhoneNumberStatusForSms_Data data = new PhoneNumberStatusForSmsResponse.PhoneNumberStatusForSms_Data();
			data.Status = _ctx.StringValue("PhoneNumberStatusForSms.Data.Status");
			data.Carrier = _ctx.StringValue("PhoneNumberStatusForSms.Data.Carrier");
			phoneNumberStatusForSmsResponse.Data = data;
        
			return phoneNumberStatusForSmsResponse;
        }
    }
}
