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
    public class ListClusterFromGrafanaResponseUnmarshaller
    {
        public static ListClusterFromGrafanaResponse Unmarshall(UnmarshallerContext context)
        {
			ListClusterFromGrafanaResponse listClusterFromGrafanaResponse = new ListClusterFromGrafanaResponse();

			listClusterFromGrafanaResponse.HttpResponse = context.HttpResponse;
			listClusterFromGrafanaResponse.RequestId = context.StringValue("ListClusterFromGrafana.RequestId");

			List<ListClusterFromGrafanaResponse.ListClusterFromGrafana_PromCluster> listClusterFromGrafanaResponse_promClusterList = new List<ListClusterFromGrafanaResponse.ListClusterFromGrafana_PromCluster>();
			for (int i = 0; i < context.Length("ListClusterFromGrafana.PromClusterList.Length"); i++) {
				ListClusterFromGrafanaResponse.ListClusterFromGrafana_PromCluster promCluster = new ListClusterFromGrafanaResponse.ListClusterFromGrafana_PromCluster();
				promCluster.Id = context.LongValue("ListClusterFromGrafana.PromClusterList["+ i +"].Id");
				promCluster.ClusterId = context.StringValue("ListClusterFromGrafana.PromClusterList["+ i +"].ClusterId");
				promCluster.ClusterName = context.StringValue("ListClusterFromGrafana.PromClusterList["+ i +"].ClusterName");
				promCluster.AgentStatus = context.StringValue("ListClusterFromGrafana.PromClusterList["+ i +"].AgentStatus");
				promCluster.ClusterType = context.StringValue("ListClusterFromGrafana.PromClusterList["+ i +"].ClusterType");
				promCluster.ControllerId = context.StringValue("ListClusterFromGrafana.PromClusterList["+ i +"].ControllerId");
				promCluster.IsControllerInstalled = context.BooleanValue("ListClusterFromGrafana.PromClusterList["+ i +"].IsControllerInstalled");
				promCluster.UserId = context.StringValue("ListClusterFromGrafana.PromClusterList["+ i +"].UserId");
				promCluster.RegionId = context.StringValue("ListClusterFromGrafana.PromClusterList["+ i +"].RegionId");
				promCluster.PluginsJsonArray = context.StringValue("ListClusterFromGrafana.PromClusterList["+ i +"].PluginsJsonArray");
				promCluster.StateJson = context.StringValue("ListClusterFromGrafana.PromClusterList["+ i +"].StateJson");
				promCluster.NodeNum = context.IntegerValue("ListClusterFromGrafana.PromClusterList["+ i +"].NodeNum");
				promCluster.CreateTime = context.LongValue("ListClusterFromGrafana.PromClusterList["+ i +"].CreateTime");
				promCluster.UpdateTime = context.LongValue("ListClusterFromGrafana.PromClusterList["+ i +"].UpdateTime");
				promCluster.LastHeartBeatTime = context.LongValue("ListClusterFromGrafana.PromClusterList["+ i +"].LastHeartBeatTime");
				promCluster.InstallTime = context.LongValue("ListClusterFromGrafana.PromClusterList["+ i +"].InstallTime");
				promCluster.Extra = context.StringValue("ListClusterFromGrafana.PromClusterList["+ i +"].Extra");
				promCluster.Options = context.StringValue("ListClusterFromGrafana.PromClusterList["+ i +"].Options");

				listClusterFromGrafanaResponse_promClusterList.Add(promCluster);
			}
			listClusterFromGrafanaResponse.PromClusterList = listClusterFromGrafanaResponse_promClusterList;
        
			return listClusterFromGrafanaResponse;
        }
    }
}
