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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ons.Model.V20190214;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ons.Transform.V20190214
{
    public class OnsTraceGetResultResponseUnmarshaller
    {
        public static OnsTraceGetResultResponse Unmarshall(UnmarshallerContext context)
        {
			OnsTraceGetResultResponse onsTraceGetResultResponse = new OnsTraceGetResultResponse();

			onsTraceGetResultResponse.HttpResponse = context.HttpResponse;
			onsTraceGetResultResponse.RequestId = context.StringValue("OnsTraceGetResult.RequestId");
			onsTraceGetResultResponse.HelpUrl = context.StringValue("OnsTraceGetResult.HelpUrl");

			OnsTraceGetResultResponse.OnsTraceGetResult_TraceData traceData = new OnsTraceGetResultResponse.OnsTraceGetResult_TraceData();
			traceData.QueryId = context.StringValue("OnsTraceGetResult.TraceData.QueryId");
			traceData.UserId = context.StringValue("OnsTraceGetResult.TraceData.UserId");
			traceData.Topic = context.StringValue("OnsTraceGetResult.TraceData.Topic");
			traceData.MsgId = context.StringValue("OnsTraceGetResult.TraceData.MsgId");
			traceData.MsgKey = context.StringValue("OnsTraceGetResult.TraceData.MsgKey");
			traceData.Status = context.StringValue("OnsTraceGetResult.TraceData.Status");
			traceData.CreateTime = context.LongValue("OnsTraceGetResult.TraceData.CreateTime");
			traceData.UpdateTime = context.LongValue("OnsTraceGetResult.TraceData.UpdateTime");
			traceData.InstanceId = context.StringValue("OnsTraceGetResult.TraceData.InstanceId");

			List<OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo> traceData_traceList = new List<OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo>();
			for (int i = 0; i < context.Length("OnsTraceGetResult.TraceData.TraceList.Length"); i++) {
				OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo traceMapDo = new OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo();
				traceMapDo.PubTime = context.LongValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].PubTime");
				traceMapDo.Topic = context.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].Topic");
				traceMapDo.PubGroupName = context.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].PubGroupName");
				traceMapDo.MsgId = context.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].MsgId");
				traceMapDo.Tag = context.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].Tag");
				traceMapDo.MsgKey = context.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].MsgKey");
				traceMapDo.BornHost = context.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].BornHost");
				traceMapDo.CostTime = context.IntegerValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].CostTime");
				traceMapDo.Status = context.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].Status");

				List<OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo.OnsTraceGetResult_SubMapDo> traceMapDo_subList = new List<OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo.OnsTraceGetResult_SubMapDo>();
				for (int j = 0; j < context.Length("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList.Length"); j++) {
					OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo.OnsTraceGetResult_SubMapDo subMapDo = new OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo.OnsTraceGetResult_SubMapDo();
					subMapDo.SubGroupName = context.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].SubGroupName");
					subMapDo.SuccessCount = context.IntegerValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].SuccessCount");
					subMapDo.FailCount = context.IntegerValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].FailCount");

					List<OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo.OnsTraceGetResult_SubMapDo.OnsTraceGetResult_SubClientInfoDo> subMapDo_clientList = new List<OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo.OnsTraceGetResult_SubMapDo.OnsTraceGetResult_SubClientInfoDo>();
					for (int k = 0; k < context.Length("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].ClientList.Length"); k++) {
						OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo.OnsTraceGetResult_SubMapDo.OnsTraceGetResult_SubClientInfoDo subClientInfoDo = new OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo.OnsTraceGetResult_SubMapDo.OnsTraceGetResult_SubClientInfoDo();
						subClientInfoDo.SubGroupName = context.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].ClientList["+ k +"].SubGroupName");
						subClientInfoDo.SubTime = context.LongValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].ClientList["+ k +"].SubTime");
						subClientInfoDo.ClientHost = context.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].ClientList["+ k +"].ClientHost");
						subClientInfoDo.ReconsumeTimes = context.IntegerValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].ClientList["+ k +"].ReconsumeTimes");
						subClientInfoDo.CostTime = context.IntegerValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].ClientList["+ k +"].CostTime");
						subClientInfoDo.Status = context.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].ClientList["+ k +"].Status");

						subMapDo_clientList.Add(subClientInfoDo);
					}
					subMapDo.ClientList = subMapDo_clientList;

					traceMapDo_subList.Add(subMapDo);
				}
				traceMapDo.SubList = traceMapDo_subList;

				traceData_traceList.Add(traceMapDo);
			}
			traceData.TraceList = traceData_traceList;
			onsTraceGetResultResponse.TraceData = traceData;
        
			return onsTraceGetResultResponse;
        }
    }
}