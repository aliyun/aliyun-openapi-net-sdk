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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class ListNodeGroupsPacketStatResponseUnmarshaller
    {
        public static ListNodeGroupsPacketStatResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodeGroupsPacketStatResponse listNodeGroupsPacketStatResponse = new ListNodeGroupsPacketStatResponse();

			listNodeGroupsPacketStatResponse.HttpResponse = _ctx.HttpResponse;
			listNodeGroupsPacketStatResponse.RequestId = _ctx.StringValue("ListNodeGroupsPacketStat.RequestId");
			listNodeGroupsPacketStatResponse.Success = _ctx.BooleanValue("ListNodeGroupsPacketStat.Success");

			List<ListNodeGroupsPacketStatResponse.ListNodeGroupsPacketStat_NodeGroupPacketStat> listNodeGroupsPacketStatResponse_data = new List<ListNodeGroupsPacketStatResponse.ListNodeGroupsPacketStat_NodeGroupPacketStat>();
			for (int i = 0; i < _ctx.Length("ListNodeGroupsPacketStat.Data.Length"); i++) {
				ListNodeGroupsPacketStatResponse.ListNodeGroupsPacketStat_NodeGroupPacketStat nodeGroupPacketStat = new ListNodeGroupsPacketStatResponse.ListNodeGroupsPacketStat_NodeGroupPacketStat();
				nodeGroupPacketStat.NodeGroupId = _ctx.StringValue("ListNodeGroupsPacketStat.Data["+ i +"].NodeGroupId");
				nodeGroupPacketStat.UplinkCount = _ctx.IntegerValue("ListNodeGroupsPacketStat.Data["+ i +"].UplinkCount");
				nodeGroupPacketStat.DownlinkCount = _ctx.IntegerValue("ListNodeGroupsPacketStat.Data["+ i +"].DownlinkCount");

				listNodeGroupsPacketStatResponse_data.Add(nodeGroupPacketStat);
			}
			listNodeGroupsPacketStatResponse.Data = listNodeGroupsPacketStatResponse_data;
        
			return listNodeGroupsPacketStatResponse;
        }
    }
}
