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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListFlowClusterAllHostsResponseUnmarshaller
    {
        public static ListFlowClusterAllHostsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFlowClusterAllHostsResponse listFlowClusterAllHostsResponse = new ListFlowClusterAllHostsResponse();

			listFlowClusterAllHostsResponse.HttpResponse = _ctx.HttpResponse;
			listFlowClusterAllHostsResponse.RequestId = _ctx.StringValue("ListFlowClusterAllHosts.RequestId");

			List<ListFlowClusterAllHostsResponse.ListFlowClusterAllHosts_Host> listFlowClusterAllHostsResponse_hostList = new List<ListFlowClusterAllHostsResponse.ListFlowClusterAllHosts_Host>();
			for (int i = 0; i < _ctx.Length("ListFlowClusterAllHosts.HostList.Length"); i++) {
				ListFlowClusterAllHostsResponse.ListFlowClusterAllHosts_Host host = new ListFlowClusterAllHostsResponse.ListFlowClusterAllHosts_Host();
				host.HostId = _ctx.StringValue("ListFlowClusterAllHosts.HostList["+ i +"].HostId");
				host.HostName = _ctx.StringValue("ListFlowClusterAllHosts.HostList["+ i +"].HostName");
				host.PublicIp = _ctx.StringValue("ListFlowClusterAllHosts.HostList["+ i +"].PublicIp");
				host.PrivateIp = _ctx.StringValue("ListFlowClusterAllHosts.HostList["+ i +"].PrivateIp");
				host.Role = _ctx.StringValue("ListFlowClusterAllHosts.HostList["+ i +"].Role");
				host.InstanceType = _ctx.StringValue("ListFlowClusterAllHosts.HostList["+ i +"].InstanceType");
				host.Cpu = _ctx.IntegerValue("ListFlowClusterAllHosts.HostList["+ i +"].Cpu");
				host.Memory = _ctx.IntegerValue("ListFlowClusterAllHosts.HostList["+ i +"].Memory");
				host.Status = _ctx.StringValue("ListFlowClusterAllHosts.HostList["+ i +"].Status");
				host.Type = _ctx.StringValue("ListFlowClusterAllHosts.HostList["+ i +"].Type");
				host.HostInstanceId = _ctx.StringValue("ListFlowClusterAllHosts.HostList["+ i +"].HostInstanceId");
				host.SerialNumber = _ctx.StringValue("ListFlowClusterAllHosts.HostList["+ i +"].SerialNumber");

				listFlowClusterAllHostsResponse_hostList.Add(host);
			}
			listFlowClusterAllHostsResponse.HostList = listFlowClusterAllHostsResponse_hostList;
        
			return listFlowClusterAllHostsResponse;
        }
    }
}
