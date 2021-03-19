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
using Aliyun.Acs.Ons.Model.V20190214;

namespace Aliyun.Acs.Ons.Transform.V20190214
{
    public class OnsTraceGetResultResponseUnmarshaller
    {
        public static OnsTraceGetResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			OnsTraceGetResultResponse onsTraceGetResultResponse = new OnsTraceGetResultResponse();

			onsTraceGetResultResponse.HttpResponse = _ctx.HttpResponse;
			onsTraceGetResultResponse.RequestId = _ctx.StringValue("OnsTraceGetResult.RequestId");
			onsTraceGetResultResponse.HelpUrl = _ctx.StringValue("OnsTraceGetResult.HelpUrl");

			OnsTraceGetResultResponse.OnsTraceGetResult_TraceData traceData = new OnsTraceGetResultResponse.OnsTraceGetResult_TraceData();
			traceData.QueryId = _ctx.StringValue("OnsTraceGetResult.TraceData.QueryId");
			traceData.UserId = _ctx.StringValue("OnsTraceGetResult.TraceData.UserId");
			traceData.Topic = _ctx.StringValue("OnsTraceGetResult.TraceData.Topic");
			traceData.MsgId = _ctx.StringValue("OnsTraceGetResult.TraceData.MsgId");
			traceData.MsgKey = _ctx.StringValue("OnsTraceGetResult.TraceData.MsgKey");
			traceData.Status = _ctx.StringValue("OnsTraceGetResult.TraceData.Status");
			traceData.CreateTime = _ctx.LongValue("OnsTraceGetResult.TraceData.CreateTime");
			traceData.UpdateTime = _ctx.LongValue("OnsTraceGetResult.TraceData.UpdateTime");
			traceData.InstanceId = _ctx.StringValue("OnsTraceGetResult.TraceData.InstanceId");

			List<OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo> traceData_traceList = new List<OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo>();
			for (int i = 0; i < _ctx.Length("OnsTraceGetResult.TraceData.TraceList.Length"); i++) {
				OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo traceMapDo = new OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo();
				traceMapDo.PubTime = _ctx.LongValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].PubTime");
				traceMapDo.Topic = _ctx.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].Topic");
				traceMapDo.PubGroupName = _ctx.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].PubGroupName");
				traceMapDo.MsgId = _ctx.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].MsgId");
				traceMapDo.Tag = _ctx.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].Tag");
				traceMapDo.MsgKey = _ctx.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].MsgKey");
				traceMapDo.BornHost = _ctx.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].BornHost");
				traceMapDo.CostTime = _ctx.IntegerValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].CostTime");
				traceMapDo.Status = _ctx.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].Status");

				List<OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo.OnsTraceGetResult_SubMapDo> traceMapDo_subList = new List<OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo.OnsTraceGetResult_SubMapDo>();
				for (int j = 0; j < _ctx.Length("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList.Length"); j++) {
					OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo.OnsTraceGetResult_SubMapDo subMapDo = new OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo.OnsTraceGetResult_SubMapDo();
					subMapDo.SubGroupName = _ctx.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].SubGroupName");
					subMapDo.SuccessCount = _ctx.IntegerValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].SuccessCount");
					subMapDo.FailCount = _ctx.IntegerValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].FailCount");

					List<OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo.OnsTraceGetResult_SubMapDo.OnsTraceGetResult_SubClientInfoDo> subMapDo_clientList = new List<OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo.OnsTraceGetResult_SubMapDo.OnsTraceGetResult_SubClientInfoDo>();
					for (int k = 0; k < _ctx.Length("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].ClientList.Length"); k++) {
						OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo.OnsTraceGetResult_SubMapDo.OnsTraceGetResult_SubClientInfoDo subClientInfoDo = new OnsTraceGetResultResponse.OnsTraceGetResult_TraceData.OnsTraceGetResult_TraceMapDo.OnsTraceGetResult_SubMapDo.OnsTraceGetResult_SubClientInfoDo();
						subClientInfoDo.SubGroupName = _ctx.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].ClientList["+ k +"].SubGroupName");
						subClientInfoDo.SubTime = _ctx.LongValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].ClientList["+ k +"].SubTime");
						subClientInfoDo.ClientHost = _ctx.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].ClientList["+ k +"].ClientHost");
						subClientInfoDo.ReconsumeTimes = _ctx.IntegerValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].ClientList["+ k +"].ReconsumeTimes");
						subClientInfoDo.CostTime = _ctx.IntegerValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].ClientList["+ k +"].CostTime");
						subClientInfoDo.Status = _ctx.StringValue("OnsTraceGetResult.TraceData.TraceList["+ i +"].SubList["+ j +"].ClientList["+ k +"].Status");

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
