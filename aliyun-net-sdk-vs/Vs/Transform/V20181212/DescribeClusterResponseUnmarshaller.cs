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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeClusterResponseUnmarshaller
    {
        public static DescribeClusterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClusterResponse describeClusterResponse = new DescribeClusterResponse();

			describeClusterResponse.HttpResponse = _ctx.HttpResponse;
			describeClusterResponse.RequestId = _ctx.StringValue("DescribeCluster.RequestId");
			describeClusterResponse.ClusterId = _ctx.StringValue("DescribeCluster.ClusterId");
			describeClusterResponse.Name = _ctx.StringValue("DescribeCluster.Name");
			describeClusterResponse.Description = _ctx.StringValue("DescribeCluster.Description");
			describeClusterResponse.MaintainTime = _ctx.StringValue("DescribeCluster.MaintainTime");
			describeClusterResponse.Status = _ctx.StringValue("DescribeCluster.Status");

			List<DescribeClusterResponse.DescribeCluster_InternalPort> describeClusterResponse_internalPorts = new List<DescribeClusterResponse.DescribeCluster_InternalPort>();
			for (int i = 0; i < _ctx.Length("DescribeCluster.InternalPorts.Length"); i++) {
				DescribeClusterResponse.DescribeCluster_InternalPort internalPort = new DescribeClusterResponse.DescribeCluster_InternalPort();
				internalPort.Platform = _ctx.StringValue("DescribeCluster.InternalPorts["+ i +"].Platform");
				internalPort.IpProtocol = _ctx.StringValue("DescribeCluster.InternalPorts["+ i +"].IpProtocol");

				List<string> internalPort_port = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCluster.InternalPorts["+ i +"].Port.Length"); j++) {
					internalPort_port.Add(_ctx.StringValue("DescribeCluster.InternalPorts["+ i +"].Port["+ j +"]"));
				}
				internalPort.Port = internalPort_port;

				describeClusterResponse_internalPorts.Add(internalPort);
			}
			describeClusterResponse.InternalPorts = describeClusterResponse_internalPorts;
        
			return describeClusterResponse;
        }
    }
}
