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
    public class PickOutboundNumbersResponseUnmarshaller
    {
        public static PickOutboundNumbersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PickOutboundNumbersResponse pickOutboundNumbersResponse = new PickOutboundNumbersResponse();

			pickOutboundNumbersResponse.HttpResponse = _ctx.HttpResponse;
			pickOutboundNumbersResponse.Code = _ctx.StringValue("PickOutboundNumbers.Code");
			pickOutboundNumbersResponse.HttpStatusCode = _ctx.IntegerValue("PickOutboundNumbers.HttpStatusCode");
			pickOutboundNumbersResponse.Message = _ctx.StringValue("PickOutboundNumbers.Message");
			pickOutboundNumbersResponse.RequestId = _ctx.StringValue("PickOutboundNumbers.RequestId");

			List<PickOutboundNumbersResponse.PickOutboundNumbers_NumberPair> pickOutboundNumbersResponse_data = new List<PickOutboundNumbersResponse.PickOutboundNumbers_NumberPair>();
			for (int i = 0; i < _ctx.Length("PickOutboundNumbers.Data.Length"); i++) {
				PickOutboundNumbersResponse.PickOutboundNumbers_NumberPair numberPair = new PickOutboundNumbersResponse.PickOutboundNumbers_NumberPair();

				PickOutboundNumbersResponse.PickOutboundNumbers_NumberPair.PickOutboundNumbers_Callee callee = new PickOutboundNumbersResponse.PickOutboundNumbers_NumberPair.PickOutboundNumbers_Callee();
				callee.City = _ctx.StringValue("PickOutboundNumbers.Data["+ i +"].Callee.City");
				callee.Number = _ctx.StringValue("PickOutboundNumbers.Data["+ i +"].Callee.Number");
				callee.Province = _ctx.StringValue("PickOutboundNumbers.Data["+ i +"].Callee.Province");
				numberPair.Callee = callee;

				PickOutboundNumbersResponse.PickOutboundNumbers_NumberPair.PickOutboundNumbers_Caller caller = new PickOutboundNumbersResponse.PickOutboundNumbers_NumberPair.PickOutboundNumbers_Caller();
				caller.City = _ctx.StringValue("PickOutboundNumbers.Data["+ i +"].Caller.City");
				caller.Number = _ctx.StringValue("PickOutboundNumbers.Data["+ i +"].Caller.Number");
				caller.Province = _ctx.StringValue("PickOutboundNumbers.Data["+ i +"].Caller.Province");
				numberPair.Caller = caller;

				pickOutboundNumbersResponse_data.Add(numberPair);
			}
			pickOutboundNumbersResponse.Data = pickOutboundNumbersResponse_data;
        
			return pickOutboundNumbersResponse;
        }
    }
}
