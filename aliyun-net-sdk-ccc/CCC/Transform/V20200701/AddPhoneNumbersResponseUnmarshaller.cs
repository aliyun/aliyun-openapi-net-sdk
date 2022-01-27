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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class AddPhoneNumbersResponseUnmarshaller
    {
        public static AddPhoneNumbersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddPhoneNumbersResponse addPhoneNumbersResponse = new AddPhoneNumbersResponse();

			addPhoneNumbersResponse.HttpResponse = _ctx.HttpResponse;
			addPhoneNumbersResponse.Code = _ctx.StringValue("AddPhoneNumbers.Code");
			addPhoneNumbersResponse.HttpStatusCode = _ctx.IntegerValue("AddPhoneNumbers.HttpStatusCode");
			addPhoneNumbersResponse.Message = _ctx.StringValue("AddPhoneNumbers.Message");
			addPhoneNumbersResponse.RequestId = _ctx.StringValue("AddPhoneNumbers.RequestId");

			List<string> addPhoneNumbersResponse_data = new List<string>();
			for (int i = 0; i < _ctx.Length("AddPhoneNumbers.Data.Length"); i++) {
				addPhoneNumbersResponse_data.Add(_ctx.StringValue("AddPhoneNumbers.Data["+ i +"]"));
			}
			addPhoneNumbersResponse.Data = addPhoneNumbersResponse_data;
        
			return addPhoneNumbersResponse;
        }
    }
}
