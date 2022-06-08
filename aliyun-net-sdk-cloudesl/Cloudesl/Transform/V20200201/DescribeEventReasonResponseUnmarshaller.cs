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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribeEventReasonResponseUnmarshaller
    {
        public static DescribeEventReasonResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEventReasonResponse describeEventReasonResponse = new DescribeEventReasonResponse();

			describeEventReasonResponse.HttpResponse = _ctx.HttpResponse;
			describeEventReasonResponse.RequestId = _ctx.StringValue("DescribeEventReason.RequestId");
			describeEventReasonResponse.Success = _ctx.BooleanValue("DescribeEventReason.Success");
			describeEventReasonResponse.Message = _ctx.StringValue("DescribeEventReason.Message");
			describeEventReasonResponse.ErrorCode = _ctx.StringValue("DescribeEventReason.ErrorCode");
			describeEventReasonResponse.ErrorMessage = _ctx.StringValue("DescribeEventReason.ErrorMessage");
			describeEventReasonResponse.Code = _ctx.StringValue("DescribeEventReason.Code");
			describeEventReasonResponse.DynamicCode = _ctx.StringValue("DescribeEventReason.DynamicCode");
			describeEventReasonResponse.DynamicMessage = _ctx.StringValue("DescribeEventReason.DynamicMessage");

			List<DescribeEventReasonResponse.DescribeEventReason_EventReason> describeEventReasonResponse_eventReasons = new List<DescribeEventReasonResponse.DescribeEventReason_EventReason>();
			for (int i = 0; i < _ctx.Length("DescribeEventReason.EventReasons.Length"); i++) {
				DescribeEventReasonResponse.DescribeEventReason_EventReason eventReason = new DescribeEventReasonResponse.DescribeEventReason_EventReason();
				eventReason.Category = _ctx.StringValue("DescribeEventReason.EventReasons["+ i +"].Category");

				List<string> eventReason_reasons = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeEventReason.EventReasons["+ i +"].Reasons.Length"); j++) {
					eventReason_reasons.Add(_ctx.StringValue("DescribeEventReason.EventReasons["+ i +"].Reasons["+ j +"]"));
				}
				eventReason.Reasons = eventReason_reasons;

				List<string> eventReason_reasonI18ns = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeEventReason.EventReasons["+ i +"].ReasonI18ns.Length"); j++) {
					eventReason_reasonI18ns.Add(_ctx.StringValue("DescribeEventReason.EventReasons["+ i +"].ReasonI18ns["+ j +"]"));
				}
				eventReason.ReasonI18ns = eventReason_reasonI18ns;

				describeEventReasonResponse_eventReasons.Add(eventReason);
			}
			describeEventReasonResponse.EventReasons = describeEventReasonResponse_eventReasons;
        
			return describeEventReasonResponse;
        }
    }
}
