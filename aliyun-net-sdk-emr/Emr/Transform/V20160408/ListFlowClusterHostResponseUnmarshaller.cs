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
    public class ListFlowClusterHostResponseUnmarshaller
    {
        public static ListFlowClusterHostResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFlowClusterHostResponse listFlowClusterHostResponse = new ListFlowClusterHostResponse();

			listFlowClusterHostResponse.HttpResponse = _ctx.HttpResponse;
			listFlowClusterHostResponse.RequestId = _ctx.StringValue("ListFlowClusterHost.RequestId");

			List<ListFlowClusterHostResponse.ListFlowClusterHost_Host> listFlowClusterHostResponse_hostList = new List<ListFlowClusterHostResponse.ListFlowClusterHost_Host>();
			for (int i = 0; i < _ctx.Length("ListFlowClusterHost.HostList.Length"); i++) {
				ListFlowClusterHostResponse.ListFlowClusterHost_Host host = new ListFlowClusterHostResponse.ListFlowClusterHost_Host();
				host.HostId = _ctx.StringValue("ListFlowClusterHost.HostList["+ i +"].HostId");
				host.HostName = _ctx.StringValue("ListFlowClusterHost.HostList["+ i +"].HostName");
				host.PublicIp = _ctx.StringValue("ListFlowClusterHost.HostList["+ i +"].PublicIp");
				host.PrivateIp = _ctx.StringValue("ListFlowClusterHost.HostList["+ i +"].PrivateIp");
				host.Role = _ctx.StringValue("ListFlowClusterHost.HostList["+ i +"].Role");
				host.InstanceType = _ctx.StringValue("ListFlowClusterHost.HostList["+ i +"].InstanceType");
				host.Cpu = _ctx.IntegerValue("ListFlowClusterHost.HostList["+ i +"].Cpu");
				host.Memory = _ctx.IntegerValue("ListFlowClusterHost.HostList["+ i +"].Memory");
				host.Status = _ctx.StringValue("ListFlowClusterHost.HostList["+ i +"].Status");
				host.Type = _ctx.StringValue("ListFlowClusterHost.HostList["+ i +"].Type");
				host.HostInstanceId = _ctx.StringValue("ListFlowClusterHost.HostList["+ i +"].HostInstanceId");
				host.SerialNumber = _ctx.StringValue("ListFlowClusterHost.HostList["+ i +"].SerialNumber");

				listFlowClusterHostResponse_hostList.Add(host);
			}
			listFlowClusterHostResponse.HostList = listFlowClusterHostResponse_hostList;
        
			return listFlowClusterHostResponse;
        }
    }
}
