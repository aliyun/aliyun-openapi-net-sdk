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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class ListTrafficMirrorSessionsResponseUnmarshaller
    {
        public static ListTrafficMirrorSessionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTrafficMirrorSessionsResponse listTrafficMirrorSessionsResponse = new ListTrafficMirrorSessionsResponse();

			listTrafficMirrorSessionsResponse.HttpResponse = _ctx.HttpResponse;
			listTrafficMirrorSessionsResponse.RequestId = _ctx.StringValue("ListTrafficMirrorSessions.RequestId");
			listTrafficMirrorSessionsResponse.NextToken = _ctx.StringValue("ListTrafficMirrorSessions.NextToken");
			listTrafficMirrorSessionsResponse.TotalCount = _ctx.StringValue("ListTrafficMirrorSessions.TotalCount");

			List<ListTrafficMirrorSessionsResponse.ListTrafficMirrorSessions_TrafficMirrorSession> listTrafficMirrorSessionsResponse_trafficMirrorSessions = new List<ListTrafficMirrorSessionsResponse.ListTrafficMirrorSessions_TrafficMirrorSession>();
			for (int i = 0; i < _ctx.Length("ListTrafficMirrorSessions.TrafficMirrorSessions.Length"); i++) {
				ListTrafficMirrorSessionsResponse.ListTrafficMirrorSessions_TrafficMirrorSession trafficMirrorSession = new ListTrafficMirrorSessionsResponse.ListTrafficMirrorSessions_TrafficMirrorSession();
				trafficMirrorSession.TrafficMirrorSessionName = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorSessionName");
				trafficMirrorSession.TrafficMirrorSessionDescription = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorSessionDescription");
				trafficMirrorSession.TrafficMirrorSessionId = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorSessionId");
				trafficMirrorSession.TrafficMirrorSessionStatus = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorSessionStatus");
				trafficMirrorSession.TrafficMirrorTargetId = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorTargetId");
				trafficMirrorSession.TrafficMirrorTargetType = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorTargetType");
				trafficMirrorSession.TrafficMirrorFilterId = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorFilterId");
				trafficMirrorSession.VirtualNetworkId = _ctx.IntegerValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].VirtualNetworkId");
				trafficMirrorSession.Priority = _ctx.IntegerValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].Priority");
				trafficMirrorSession.Enabled = _ctx.BooleanValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].Enabled");
				trafficMirrorSession.PacketLength = _ctx.IntegerValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].PacketLength");
				trafficMirrorSession.TrafficMirrorSessionBusinessStatus = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorSessionBusinessStatus");

				List<string> trafficMirrorSession_trafficMirrorSourceIds = new List<string>();
				for (int j = 0; j < _ctx.Length("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorSourceIds.Length"); j++) {
					trafficMirrorSession_trafficMirrorSourceIds.Add(_ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorSourceIds["+ j +"]"));
				}
				trafficMirrorSession.TrafficMirrorSourceIds = trafficMirrorSession_trafficMirrorSourceIds;

				listTrafficMirrorSessionsResponse_trafficMirrorSessions.Add(trafficMirrorSession);
			}
			listTrafficMirrorSessionsResponse.TrafficMirrorSessions = listTrafficMirrorSessionsResponse_trafficMirrorSessions;
        
			return listTrafficMirrorSessionsResponse;
        }
    }
}
