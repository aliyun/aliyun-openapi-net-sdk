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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class ListOutboundCallNumbersResponseUnmarshaller
    {
        public static ListOutboundCallNumbersResponse Unmarshall(UnmarshallerContext context)
        {
			ListOutboundCallNumbersResponse listOutboundCallNumbersResponse = new ListOutboundCallNumbersResponse();

			listOutboundCallNumbersResponse.HttpResponse = context.HttpResponse;
			listOutboundCallNumbersResponse.RequestId = context.StringValue("ListOutboundCallNumbers.RequestId");
			listOutboundCallNumbersResponse.Success = context.BooleanValue("ListOutboundCallNumbers.Success");
			listOutboundCallNumbersResponse.Code = context.StringValue("ListOutboundCallNumbers.Code");
			listOutboundCallNumbersResponse.Message = context.StringValue("ListOutboundCallNumbers.Message");
			listOutboundCallNumbersResponse.HttpStatusCode = context.IntegerValue("ListOutboundCallNumbers.HttpStatusCode");

			ListOutboundCallNumbersResponse.ListOutboundCallNumbers_OutboundCallNumbers outboundCallNumbers = new ListOutboundCallNumbersResponse.ListOutboundCallNumbers_OutboundCallNumbers();
			outboundCallNumbers.TotalCount = context.IntegerValue("ListOutboundCallNumbers.OutboundCallNumbers.TotalCount");
			outboundCallNumbers.PageNumber = context.IntegerValue("ListOutboundCallNumbers.OutboundCallNumbers.PageNumber");
			outboundCallNumbers.PageSize = context.IntegerValue("ListOutboundCallNumbers.OutboundCallNumbers.PageSize");

			List<ListOutboundCallNumbersResponse.ListOutboundCallNumbers_OutboundCallNumbers.ListOutboundCallNumbers_OutboundCallNumber> outboundCallNumbers_list = new List<ListOutboundCallNumbersResponse.ListOutboundCallNumbers_OutboundCallNumbers.ListOutboundCallNumbers_OutboundCallNumber>();
			for (int i = 0; i < context.Length("ListOutboundCallNumbers.OutboundCallNumbers.List.Length"); i++) {
				ListOutboundCallNumbersResponse.ListOutboundCallNumbers_OutboundCallNumbers.ListOutboundCallNumbers_OutboundCallNumber outboundCallNumber = new ListOutboundCallNumbersResponse.ListOutboundCallNumbers_OutboundCallNumbers.ListOutboundCallNumbers_OutboundCallNumber();
				outboundCallNumber.OutboundCallNumberId = context.StringValue("ListOutboundCallNumbers.OutboundCallNumbers.List["+ i +"].OutboundCallNumberId");
				outboundCallNumber.Number = context.StringValue("ListOutboundCallNumbers.OutboundCallNumbers.List["+ i +"].Number");
				outboundCallNumber.RateLimitPeriod = context.StringValue("ListOutboundCallNumbers.OutboundCallNumbers.List["+ i +"].RateLimitPeriod");
				outboundCallNumber.RateLimitCount = context.StringValue("ListOutboundCallNumbers.OutboundCallNumbers.List["+ i +"].RateLimitCount");

				outboundCallNumbers_list.Add(outboundCallNumber);
			}
			outboundCallNumbers.List = outboundCallNumbers_list;
			listOutboundCallNumbersResponse.OutboundCallNumbers = outboundCallNumbers;
        
			return listOutboundCallNumbersResponse;
        }
    }
}
