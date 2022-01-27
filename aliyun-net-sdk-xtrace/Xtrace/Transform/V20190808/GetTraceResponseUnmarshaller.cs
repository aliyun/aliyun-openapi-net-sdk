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
using Aliyun.Acs.xtrace.Model.V20190808;

namespace Aliyun.Acs.xtrace.Transform.V20190808
{
    public class GetTraceResponseUnmarshaller
    {
        public static GetTraceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTraceResponse getTraceResponse = new GetTraceResponse();

			getTraceResponse.HttpResponse = _ctx.HttpResponse;
			getTraceResponse.RequestId = _ctx.StringValue("GetTrace.RequestId");

			List<GetTraceResponse.GetTrace_Span> getTraceResponse_spans = new List<GetTraceResponse.GetTrace_Span>();
			for (int i = 0; i < _ctx.Length("GetTrace.Spans.Length"); i++) {
				GetTraceResponse.GetTrace_Span span = new GetTraceResponse.GetTrace_Span();
				span.TraceID = _ctx.StringValue("GetTrace.Spans["+ i +"].TraceID");
				span.OperationName = _ctx.StringValue("GetTrace.Spans["+ i +"].OperationName");
				span.Duration = _ctx.LongValue("GetTrace.Spans["+ i +"].Duration");
				span.ServiceName = _ctx.StringValue("GetTrace.Spans["+ i +"].ServiceName");
				span.ServiceIp = _ctx.StringValue("GetTrace.Spans["+ i +"].ServiceIp");
				span.Timestamp = _ctx.LongValue("GetTrace.Spans["+ i +"].Timestamp");
				span.RpcId = _ctx.StringValue("GetTrace.Spans["+ i +"].RpcId");
				span.ResultCode = _ctx.StringValue("GetTrace.Spans["+ i +"].ResultCode");
				span.HaveStack = _ctx.BooleanValue("GetTrace.Spans["+ i +"].HaveStack");
				span.SpanId = _ctx.StringValue("GetTrace.Spans["+ i +"].SpanId");
				span.ParentSpanId = _ctx.StringValue("GetTrace.Spans["+ i +"].ParentSpanId");

				List<GetTraceResponse.GetTrace_Span.GetTrace_TagEntry> span_tagEntryList = new List<GetTraceResponse.GetTrace_Span.GetTrace_TagEntry>();
				for (int j = 0; j < _ctx.Length("GetTrace.Spans["+ i +"].TagEntryList.Length"); j++) {
					GetTraceResponse.GetTrace_Span.GetTrace_TagEntry tagEntry = new GetTraceResponse.GetTrace_Span.GetTrace_TagEntry();
					tagEntry.Key = _ctx.StringValue("GetTrace.Spans["+ i +"].TagEntryList["+ j +"].Key");
					tagEntry._Value = _ctx.StringValue("GetTrace.Spans["+ i +"].TagEntryList["+ j +"].Value");

					span_tagEntryList.Add(tagEntry);
				}
				span.TagEntryList = span_tagEntryList;

				List<GetTraceResponse.GetTrace_Span.GetTrace_LogEvent> span_logEventList = new List<GetTraceResponse.GetTrace_Span.GetTrace_LogEvent>();
				for (int j = 0; j < _ctx.Length("GetTrace.Spans["+ i +"].LogEventList.Length"); j++) {
					GetTraceResponse.GetTrace_Span.GetTrace_LogEvent logEvent = new GetTraceResponse.GetTrace_Span.GetTrace_LogEvent();
					logEvent.Timestamp = _ctx.LongValue("GetTrace.Spans["+ i +"].LogEventList["+ j +"].Timestamp");

					List<GetTraceResponse.GetTrace_Span.GetTrace_LogEvent.GetTrace_TagEntry2> logEvent_tagEntryList1 = new List<GetTraceResponse.GetTrace_Span.GetTrace_LogEvent.GetTrace_TagEntry2>();
					for (int k = 0; k < _ctx.Length("GetTrace.Spans["+ i +"].LogEventList["+ j +"].TagEntryList.Length"); k++) {
						GetTraceResponse.GetTrace_Span.GetTrace_LogEvent.GetTrace_TagEntry2 tagEntry2 = new GetTraceResponse.GetTrace_Span.GetTrace_LogEvent.GetTrace_TagEntry2();
						tagEntry2.Key = _ctx.StringValue("GetTrace.Spans["+ i +"].LogEventList["+ j +"].TagEntryList["+ k +"].Key");
						tagEntry2._Value = _ctx.StringValue("GetTrace.Spans["+ i +"].LogEventList["+ j +"].TagEntryList["+ k +"].Value");

						logEvent_tagEntryList1.Add(tagEntry2);
					}
					logEvent.TagEntryList1 = logEvent_tagEntryList1;

					span_logEventList.Add(logEvent);
				}
				span.LogEventList = span_logEventList;

				getTraceResponse_spans.Add(span);
			}
			getTraceResponse.Spans = getTraceResponse_spans;
        
			return getTraceResponse;
        }
    }
}
