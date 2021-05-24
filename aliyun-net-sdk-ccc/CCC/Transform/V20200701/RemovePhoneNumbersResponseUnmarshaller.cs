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
    public class RemovePhoneNumbersResponseUnmarshaller
    {
        public static RemovePhoneNumbersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RemovePhoneNumbersResponse removePhoneNumbersResponse = new RemovePhoneNumbersResponse();

			removePhoneNumbersResponse.HttpResponse = _ctx.HttpResponse;
			removePhoneNumbersResponse.Code = _ctx.StringValue("RemovePhoneNumbers.Code");
			removePhoneNumbersResponse.Data = _ctx.StringValue("RemovePhoneNumbers.Data");
			removePhoneNumbersResponse.HttpStatusCode = _ctx.IntegerValue("RemovePhoneNumbers.HttpStatusCode");
			removePhoneNumbersResponse.Message = _ctx.StringValue("RemovePhoneNumbers.Message");
			removePhoneNumbersResponse.RequestId = _ctx.StringValue("RemovePhoneNumbers.RequestId");

			List<string> removePhoneNumbersResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("RemovePhoneNumbers.Params.Length"); i++) {
				removePhoneNumbersResponse_params.Add(_ctx.StringValue("RemovePhoneNumbers.Params["+ i +"]"));
			}
			removePhoneNumbersResponse._Params = removePhoneNumbersResponse_params;

			List<string> removePhoneNumbersResponse_failureList = new List<string>();
			for (int i = 0; i < _ctx.Length("RemovePhoneNumbers.FailureList.Length"); i++) {
				removePhoneNumbersResponse_failureList.Add(_ctx.StringValue("RemovePhoneNumbers.FailureList["+ i +"]"));
			}
			removePhoneNumbersResponse.FailureList = removePhoneNumbersResponse_failureList;
        
			return removePhoneNumbersResponse;
        }
    }
}
