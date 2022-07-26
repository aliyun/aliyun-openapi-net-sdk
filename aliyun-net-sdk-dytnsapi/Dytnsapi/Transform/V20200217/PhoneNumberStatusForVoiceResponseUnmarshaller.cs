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
    public class PhoneNumberStatusForVoiceResponseUnmarshaller
    {
        public static PhoneNumberStatusForVoiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PhoneNumberStatusForVoiceResponse phoneNumberStatusForVoiceResponse = new PhoneNumberStatusForVoiceResponse();

			phoneNumberStatusForVoiceResponse.HttpResponse = _ctx.HttpResponse;
			phoneNumberStatusForVoiceResponse.Code = _ctx.StringValue("PhoneNumberStatusForVoice.Code");
			phoneNumberStatusForVoiceResponse.Message = _ctx.StringValue("PhoneNumberStatusForVoice.Message");
			phoneNumberStatusForVoiceResponse.RequestId = _ctx.StringValue("PhoneNumberStatusForVoice.RequestId");

			PhoneNumberStatusForVoiceResponse.PhoneNumberStatusForVoice_Data data = new PhoneNumberStatusForVoiceResponse.PhoneNumberStatusForVoice_Data();
			data.Status = _ctx.StringValue("PhoneNumberStatusForVoice.Data.Status");
			data.Carrier = _ctx.StringValue("PhoneNumberStatusForVoice.Data.Carrier");
			phoneNumberStatusForVoiceResponse.Data = data;
        
			return phoneNumberStatusForVoiceResponse;
        }
    }
}
