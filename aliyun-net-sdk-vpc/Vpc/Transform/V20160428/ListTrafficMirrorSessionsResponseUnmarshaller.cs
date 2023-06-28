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
			listTrafficMirrorSessionsResponse.NextToken = _ctx.StringValue("ListTrafficMirrorSessions.NextToken");
			listTrafficMirrorSessionsResponse.RequestId = _ctx.StringValue("ListTrafficMirrorSessions.RequestId");
			listTrafficMirrorSessionsResponse.TotalCount = _ctx.StringValue("ListTrafficMirrorSessions.TotalCount");

			List<ListTrafficMirrorSessionsResponse.ListTrafficMirrorSessions_TrafficMirrorSession> listTrafficMirrorSessionsResponse_trafficMirrorSessions = new List<ListTrafficMirrorSessionsResponse.ListTrafficMirrorSessions_TrafficMirrorSession>();
			for (int i = 0; i < _ctx.Length("ListTrafficMirrorSessions.TrafficMirrorSessions.Length"); i++) {
				ListTrafficMirrorSessionsResponse.ListTrafficMirrorSessions_TrafficMirrorSession trafficMirrorSession = new ListTrafficMirrorSessionsResponse.ListTrafficMirrorSessions_TrafficMirrorSession();
				trafficMirrorSession.TrafficMirrorTargetId = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorTargetId");
				trafficMirrorSession.TrafficMirrorSessionId = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorSessionId");
				trafficMirrorSession.Priority = _ctx.IntegerValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].Priority");
				trafficMirrorSession.TrafficMirrorTargetType = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorTargetType");
				trafficMirrorSession.PacketLength = _ctx.IntegerValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].PacketLength");
				trafficMirrorSession.TrafficMirrorSessionDescription = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorSessionDescription");
				trafficMirrorSession.TrafficMirrorSessionStatus = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorSessionStatus");
				trafficMirrorSession.Enabled = _ctx.BooleanValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].Enabled");
				trafficMirrorSession.TrafficMirrorSessionBusinessStatus = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorSessionBusinessStatus");
				trafficMirrorSession.VirtualNetworkId = _ctx.IntegerValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].VirtualNetworkId");
				trafficMirrorSession.TrafficMirrorFilterId = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorFilterId");
				trafficMirrorSession.TrafficMirrorSessionName = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorSessionName");
				trafficMirrorSession.ResourceGroupId = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].ResourceGroupId");

				List<string> trafficMirrorSession_trafficMirrorSourceIds = new List<string>();
				for (int j = 0; j < _ctx.Length("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorSourceIds.Length"); j++) {
					trafficMirrorSession_trafficMirrorSourceIds.Add(_ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].TrafficMirrorSourceIds["+ j +"]"));
				}
				trafficMirrorSession.TrafficMirrorSourceIds = trafficMirrorSession_trafficMirrorSourceIds;

				List<ListTrafficMirrorSessionsResponse.ListTrafficMirrorSessions_TrafficMirrorSession.ListTrafficMirrorSessions_Tag> trafficMirrorSession_tags = new List<ListTrafficMirrorSessionsResponse.ListTrafficMirrorSessions_TrafficMirrorSession.ListTrafficMirrorSessions_Tag>();
				for (int j = 0; j < _ctx.Length("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].Tags.Length"); j++) {
					ListTrafficMirrorSessionsResponse.ListTrafficMirrorSessions_TrafficMirrorSession.ListTrafficMirrorSessions_Tag tag = new ListTrafficMirrorSessionsResponse.ListTrafficMirrorSessions_TrafficMirrorSession.ListTrafficMirrorSessions_Tag();
					tag.Key = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("ListTrafficMirrorSessions.TrafficMirrorSessions["+ i +"].Tags["+ j +"].Value");

					trafficMirrorSession_tags.Add(tag);
				}
				trafficMirrorSession.Tags = trafficMirrorSession_tags;

				listTrafficMirrorSessionsResponse_trafficMirrorSessions.Add(trafficMirrorSession);
			}
			listTrafficMirrorSessionsResponse.TrafficMirrorSessions = listTrafficMirrorSessionsResponse_trafficMirrorSessions;
        
			return listTrafficMirrorSessionsResponse;
        }
    }
}
