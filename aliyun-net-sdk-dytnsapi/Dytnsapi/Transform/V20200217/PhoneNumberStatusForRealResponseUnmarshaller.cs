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
    public class PhoneNumberStatusForRealResponseUnmarshaller
    {
        public static PhoneNumberStatusForRealResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PhoneNumberStatusForRealResponse phoneNumberStatusForRealResponse = new PhoneNumberStatusForRealResponse();

			phoneNumberStatusForRealResponse.HttpResponse = _ctx.HttpResponse;
			phoneNumberStatusForRealResponse.Code = _ctx.StringValue("PhoneNumberStatusForReal.Code");
			phoneNumberStatusForRealResponse.Message = _ctx.StringValue("PhoneNumberStatusForReal.Message");
			phoneNumberStatusForRealResponse.RequestId = _ctx.StringValue("PhoneNumberStatusForReal.RequestId");

			PhoneNumberStatusForRealResponse.PhoneNumberStatusForReal_Data data = new PhoneNumberStatusForRealResponse.PhoneNumberStatusForReal_Data();
			data.Status = _ctx.StringValue("PhoneNumberStatusForReal.Data.Status");
			data.Carrier = _ctx.StringValue("PhoneNumberStatusForReal.Data.Carrier");
			phoneNumberStatusForRealResponse.Data = data;
        
			return phoneNumberStatusForRealResponse;
        }
    }
}
