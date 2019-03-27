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
    public class PickOutboundNumbersResponseUnmarshaller
    {
        public static PickOutboundNumbersResponse Unmarshall(UnmarshallerContext context)
        {
			PickOutboundNumbersResponse pickOutboundNumbersResponse = new PickOutboundNumbersResponse();

			pickOutboundNumbersResponse.HttpResponse = context.HttpResponse;
			pickOutboundNumbersResponse.RequestId = context.StringValue("PickOutboundNumbers.RequestId");
			pickOutboundNumbersResponse.Success = context.BooleanValue("PickOutboundNumbers.Success");
			pickOutboundNumbersResponse.Code = context.StringValue("PickOutboundNumbers.Code");
			pickOutboundNumbersResponse.Message = context.StringValue("PickOutboundNumbers.Message");
			pickOutboundNumbersResponse.HttpStatusCode = context.IntegerValue("PickOutboundNumbers.HttpStatusCode");

			List<PickOutboundNumbersResponse.PickOutboundNumbers_DialNumberPair> pickOutboundNumbersResponse_dialNumberPairs = new List<PickOutboundNumbersResponse.PickOutboundNumbers_DialNumberPair>();
			for (int i = 0; i < context.Length("PickOutboundNumbers.DialNumberPairs.Length"); i++) {
				PickOutboundNumbersResponse.PickOutboundNumbers_DialNumberPair dialNumberPair = new PickOutboundNumbersResponse.PickOutboundNumbers_DialNumberPair();

				PickOutboundNumbersResponse.PickOutboundNumbers_DialNumberPair.PickOutboundNumbers_Callee callee = new PickOutboundNumbersResponse.PickOutboundNumbers_DialNumberPair.PickOutboundNumbers_Callee();
				callee.Number = context.StringValue("PickOutboundNumbers.DialNumberPairs["+ i +"].Callee.Number");
				callee.Province = context.StringValue("PickOutboundNumbers.DialNumberPairs["+ i +"].Callee.Province");
				callee.City = context.StringValue("PickOutboundNumbers.DialNumberPairs["+ i +"].Callee.City");
				dialNumberPair.Callee = callee;

				PickOutboundNumbersResponse.PickOutboundNumbers_DialNumberPair.PickOutboundNumbers_Caller caller = new PickOutboundNumbersResponse.PickOutboundNumbers_DialNumberPair.PickOutboundNumbers_Caller();
				caller.Number = context.StringValue("PickOutboundNumbers.DialNumberPairs["+ i +"].Caller.Number");
				caller.Province = context.StringValue("PickOutboundNumbers.DialNumberPairs["+ i +"].Caller.Province");
				caller.City = context.StringValue("PickOutboundNumbers.DialNumberPairs["+ i +"].Caller.City");
				dialNumberPair.Caller = caller;

				pickOutboundNumbersResponse_dialNumberPairs.Add(dialNumberPair);
			}
			pickOutboundNumbersResponse.DialNumberPairs = pickOutboundNumbersResponse_dialNumberPairs;
        
			return pickOutboundNumbersResponse;
        }
    }
}
