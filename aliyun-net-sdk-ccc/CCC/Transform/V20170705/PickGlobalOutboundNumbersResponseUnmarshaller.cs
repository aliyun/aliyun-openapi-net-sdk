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
    public class PickGlobalOutboundNumbersResponseUnmarshaller
    {
        public static PickGlobalOutboundNumbersResponse Unmarshall(UnmarshallerContext context)
        {
			PickGlobalOutboundNumbersResponse pickGlobalOutboundNumbersResponse = new PickGlobalOutboundNumbersResponse();

			pickGlobalOutboundNumbersResponse.HttpResponse = context.HttpResponse;
			pickGlobalOutboundNumbersResponse.RequestId = context.StringValue("PickGlobalOutboundNumbers.RequestId");
			pickGlobalOutboundNumbersResponse.Success = context.BooleanValue("PickGlobalOutboundNumbers.Success");
			pickGlobalOutboundNumbersResponse.Code = context.StringValue("PickGlobalOutboundNumbers.Code");
			pickGlobalOutboundNumbersResponse.Message = context.StringValue("PickGlobalOutboundNumbers.Message");
			pickGlobalOutboundNumbersResponse.HttpStatusCode = context.IntegerValue("PickGlobalOutboundNumbers.HttpStatusCode");

			List<PickGlobalOutboundNumbersResponse.PickGlobalOutboundNumbers_DialNumberPair> pickGlobalOutboundNumbersResponse_dialNumberPairs = new List<PickGlobalOutboundNumbersResponse.PickGlobalOutboundNumbers_DialNumberPair>();
			for (int i = 0; i < context.Length("PickGlobalOutboundNumbers.DialNumberPairs.Length"); i++) {
				PickGlobalOutboundNumbersResponse.PickGlobalOutboundNumbers_DialNumberPair dialNumberPair = new PickGlobalOutboundNumbersResponse.PickGlobalOutboundNumbers_DialNumberPair();

				PickGlobalOutboundNumbersResponse.PickGlobalOutboundNumbers_DialNumberPair.PickGlobalOutboundNumbers_Callee callee = new PickGlobalOutboundNumbersResponse.PickGlobalOutboundNumbers_DialNumberPair.PickGlobalOutboundNumbers_Callee();
				callee.Number = context.StringValue("PickGlobalOutboundNumbers.DialNumberPairs["+ i +"].Callee.Number");
				callee.Province = context.StringValue("PickGlobalOutboundNumbers.DialNumberPairs["+ i +"].Callee.Province");
				callee.City = context.StringValue("PickGlobalOutboundNumbers.DialNumberPairs["+ i +"].Callee.City");
				dialNumberPair.Callee = callee;

				PickGlobalOutboundNumbersResponse.PickGlobalOutboundNumbers_DialNumberPair.PickGlobalOutboundNumbers_Caller caller = new PickGlobalOutboundNumbersResponse.PickGlobalOutboundNumbers_DialNumberPair.PickGlobalOutboundNumbers_Caller();
				caller.Number = context.StringValue("PickGlobalOutboundNumbers.DialNumberPairs["+ i +"].Caller.Number");
				caller.Province = context.StringValue("PickGlobalOutboundNumbers.DialNumberPairs["+ i +"].Caller.Province");
				caller.City = context.StringValue("PickGlobalOutboundNumbers.DialNumberPairs["+ i +"].Caller.City");
				dialNumberPair.Caller = caller;

				pickGlobalOutboundNumbersResponse_dialNumberPairs.Add(dialNumberPair);
			}
			pickGlobalOutboundNumbersResponse.DialNumberPairs = pickGlobalOutboundNumbersResponse_dialNumberPairs;
        
			return pickGlobalOutboundNumbersResponse;
        }
    }
}
