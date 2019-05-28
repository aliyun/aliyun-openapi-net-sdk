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
using Aliyun.Acs.ARMS.Model.V20181219;

namespace Aliyun.Acs.ARMS.Transform.V20181219
{
    public class GetTraceResponseUnmarshaller
    {
        public static GetTraceResponse Unmarshall(UnmarshallerContext context)
        {
			GetTraceResponse getTraceResponse = new GetTraceResponse();

			getTraceResponse.HttpResponse = context.HttpResponse;
			getTraceResponse.RequestId = context.StringValue("GetTrace.RequestId");

			List<GetTraceResponse.GetTrace_CallChainInfo> getTraceResponse_data = new List<GetTraceResponse.GetTrace_CallChainInfo>();
			for (int i = 0; i < context.Length("GetTrace.Data.Length"); i++) {
				GetTraceResponse.GetTrace_CallChainInfo callChainInfo = new GetTraceResponse.GetTrace_CallChainInfo();
				callChainInfo.TraceID = context.StringValue("GetTrace.Data["+ i +"].TraceID");
				callChainInfo.OperationName = context.StringValue("GetTrace.Data["+ i +"].OperationName");
				callChainInfo.Duration = context.IntegerValue("GetTrace.Data["+ i +"].Duration");
				callChainInfo.ServiceName = context.StringValue("GetTrace.Data["+ i +"].ServiceName");
				callChainInfo.ServiceIp = context.StringValue("GetTrace.Data["+ i +"].ServiceIp");
				callChainInfo.Timestamp = context.LongValue("GetTrace.Data["+ i +"].Timestamp");
				callChainInfo.RpcId = context.StringValue("GetTrace.Data["+ i +"].RpcId");
				callChainInfo.ResultCode = context.StringValue("GetTrace.Data["+ i +"].ResultCode");
				callChainInfo.HaveStack = context.BooleanValue("GetTrace.Data["+ i +"].HaveStack");

				List<GetTraceResponse.GetTrace_CallChainInfo.GetTrace_TagEntry> callChainInfo_tagEntryList = new List<GetTraceResponse.GetTrace_CallChainInfo.GetTrace_TagEntry>();
				for (int j = 0; j < context.Length("GetTrace.Data["+ i +"].TagEntryList.Length"); j++) {
					GetTraceResponse.GetTrace_CallChainInfo.GetTrace_TagEntry tagEntry = new GetTraceResponse.GetTrace_CallChainInfo.GetTrace_TagEntry();
					tagEntry.Key = context.StringValue("GetTrace.Data["+ i +"].TagEntryList["+ j +"].Key");
					tagEntry._Value = context.StringValue("GetTrace.Data["+ i +"].TagEntryList["+ j +"].Value");

					callChainInfo_tagEntryList.Add(tagEntry);
				}
				callChainInfo.TagEntryList = callChainInfo_tagEntryList;

				List<GetTraceResponse.GetTrace_CallChainInfo.GetTrace_LogEvent> callChainInfo_logEventList = new List<GetTraceResponse.GetTrace_CallChainInfo.GetTrace_LogEvent>();
				for (int j = 0; j < context.Length("GetTrace.Data["+ i +"].LogEventList.Length"); j++) {
					GetTraceResponse.GetTrace_CallChainInfo.GetTrace_LogEvent logEvent = new GetTraceResponse.GetTrace_CallChainInfo.GetTrace_LogEvent();
					logEvent.Timestamp = context.LongValue("GetTrace.Data["+ i +"].LogEventList["+ j +"].Timestamp");

					List<GetTraceResponse.GetTrace_CallChainInfo.GetTrace_LogEvent.GetTrace_TagEntry2> logEvent_tagEntryList1 = new List<GetTraceResponse.GetTrace_CallChainInfo.GetTrace_LogEvent.GetTrace_TagEntry2>();
					for (int k = 0; k < context.Length("GetTrace.Data["+ i +"].LogEventList["+ j +"].TagEntryList.Length"); k++) {
						GetTraceResponse.GetTrace_CallChainInfo.GetTrace_LogEvent.GetTrace_TagEntry2 tagEntry2 = new GetTraceResponse.GetTrace_CallChainInfo.GetTrace_LogEvent.GetTrace_TagEntry2();
						tagEntry2.Key = context.StringValue("GetTrace.Data["+ i +"].LogEventList["+ j +"].TagEntryList["+ k +"].Key");
						tagEntry2._Value = context.StringValue("GetTrace.Data["+ i +"].LogEventList["+ j +"].TagEntryList["+ k +"].Value");

						logEvent_tagEntryList1.Add(tagEntry2);
					}
					logEvent.TagEntryList1 = logEvent_tagEntryList1;

					callChainInfo_logEventList.Add(logEvent);
				}
				callChainInfo.LogEventList = callChainInfo_logEventList;

				getTraceResponse_data.Add(callChainInfo);
			}
			getTraceResponse.Data = getTraceResponse_data;
        
			return getTraceResponse;
        }
    }
}
