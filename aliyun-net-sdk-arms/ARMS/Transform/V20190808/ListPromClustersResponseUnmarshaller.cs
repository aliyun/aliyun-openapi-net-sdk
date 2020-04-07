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
using Aliyun.Acs.ARMS.Model.V20190808;

namespace Aliyun.Acs.ARMS.Transform.V20190808
{
    public class ListPromClustersResponseUnmarshaller
    {
        public static ListPromClustersResponse Unmarshall(UnmarshallerContext context)
        {
			ListPromClustersResponse listPromClustersResponse = new ListPromClustersResponse();

			listPromClustersResponse.HttpResponse = context.HttpResponse;
			listPromClustersResponse.RequestId = context.StringValue("ListPromClusters.RequestId");

			List<ListPromClustersResponse.ListPromClusters_PromCluster> listPromClustersResponse_promClusterList = new List<ListPromClustersResponse.ListPromClusters_PromCluster>();
			for (int i = 0; i < context.Length("ListPromClusters.PromClusterList.Length"); i++) {
				ListPromClustersResponse.ListPromClusters_PromCluster promCluster = new ListPromClustersResponse.ListPromClusters_PromCluster();
				promCluster.Id = context.LongValue("ListPromClusters.PromClusterList["+ i +"].Id");
				promCluster.ClusterId = context.StringValue("ListPromClusters.PromClusterList["+ i +"].ClusterId");
				promCluster.ClusterName = context.StringValue("ListPromClusters.PromClusterList["+ i +"].ClusterName");
				promCluster.AgentStatus = context.StringValue("ListPromClusters.PromClusterList["+ i +"].AgentStatus");
				promCluster.ClusterType = context.StringValue("ListPromClusters.PromClusterList["+ i +"].ClusterType");
				promCluster.ControllerId = context.StringValue("ListPromClusters.PromClusterList["+ i +"].ControllerId");
				promCluster.IsControllerInstalled = context.BooleanValue("ListPromClusters.PromClusterList["+ i +"].IsControllerInstalled");
				promCluster.UserId = context.StringValue("ListPromClusters.PromClusterList["+ i +"].UserId");
				promCluster.RegionId = context.StringValue("ListPromClusters.PromClusterList["+ i +"].RegionId");
				promCluster.PluginsJsonArray = context.StringValue("ListPromClusters.PromClusterList["+ i +"].PluginsJsonArray");
				promCluster.StateJson = context.StringValue("ListPromClusters.PromClusterList["+ i +"].StateJson");
				promCluster.NodeNum = context.IntegerValue("ListPromClusters.PromClusterList["+ i +"].NodeNum");
				promCluster.CreateTime = context.LongValue("ListPromClusters.PromClusterList["+ i +"].CreateTime");
				promCluster.UpdateTime = context.LongValue("ListPromClusters.PromClusterList["+ i +"].UpdateTime");
				promCluster.LastHeartBeatTime = context.LongValue("ListPromClusters.PromClusterList["+ i +"].LastHeartBeatTime");
				promCluster.InstallTime = context.LongValue("ListPromClusters.PromClusterList["+ i +"].InstallTime");
				promCluster.Extra = context.StringValue("ListPromClusters.PromClusterList["+ i +"].Extra");
				promCluster.Options = context.StringValue("ListPromClusters.PromClusterList["+ i +"].Options");

				listPromClustersResponse_promClusterList.Add(promCluster);
			}
			listPromClustersResponse.PromClusterList = listPromClustersResponse_promClusterList;
        
			return listPromClustersResponse;
        }
    }
}
