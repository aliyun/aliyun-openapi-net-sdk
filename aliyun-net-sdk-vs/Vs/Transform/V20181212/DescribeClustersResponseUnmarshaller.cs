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
    public class DescribeClustersResponseUnmarshaller
    {
        public static DescribeClustersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClustersResponse describeClustersResponse = new DescribeClustersResponse();

			describeClustersResponse.HttpResponse = _ctx.HttpResponse;
			describeClustersResponse.RequestId = _ctx.StringValue("DescribeClusters.RequestId");
			describeClustersResponse.Total = _ctx.LongValue("DescribeClusters.Total");

			List<DescribeClustersResponse.DescribeClusters_Cluster> describeClustersResponse_clusters = new List<DescribeClustersResponse.DescribeClusters_Cluster>();
			for (int i = 0; i < _ctx.Length("DescribeClusters.Clusters.Length"); i++) {
				DescribeClustersResponse.DescribeClusters_Cluster cluster = new DescribeClustersResponse.DescribeClusters_Cluster();
				cluster.ClusterId = _ctx.StringValue("DescribeClusters.Clusters["+ i +"].ClusterId");
				cluster.Name = _ctx.StringValue("DescribeClusters.Clusters["+ i +"].Name");
				cluster.Description = _ctx.StringValue("DescribeClusters.Clusters["+ i +"].Description");
				cluster.MaintainTime = _ctx.StringValue("DescribeClusters.Clusters["+ i +"].MaintainTime");
				cluster.Status = _ctx.StringValue("DescribeClusters.Clusters["+ i +"].Status");

				List<DescribeClustersResponse.DescribeClusters_Cluster.DescribeClusters_InternalPort> cluster_internalPorts = new List<DescribeClustersResponse.DescribeClusters_Cluster.DescribeClusters_InternalPort>();
				for (int j = 0; j < _ctx.Length("DescribeClusters.Clusters["+ i +"].InternalPorts.Length"); j++) {
					DescribeClustersResponse.DescribeClusters_Cluster.DescribeClusters_InternalPort internalPort = new DescribeClustersResponse.DescribeClusters_Cluster.DescribeClusters_InternalPort();
					internalPort.Platform = _ctx.StringValue("DescribeClusters.Clusters["+ i +"].InternalPorts["+ j +"].Platform");
					internalPort.IpProtocol = _ctx.StringValue("DescribeClusters.Clusters["+ i +"].InternalPorts["+ j +"].IpProtocol");

					List<string> internalPort_port = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeClusters.Clusters["+ i +"].InternalPorts["+ j +"].Port.Length"); k++) {
						internalPort_port.Add(_ctx.StringValue("DescribeClusters.Clusters["+ i +"].InternalPorts["+ j +"].Port["+ k +"]"));
					}
					internalPort.Port = internalPort_port;

					cluster_internalPorts.Add(internalPort);
				}
				cluster.InternalPorts = cluster_internalPorts;

				describeClustersResponse_clusters.Add(cluster);
			}
			describeClustersResponse.Clusters = describeClustersResponse_clusters;
        
			return describeClustersResponse;
        }
    }
}
