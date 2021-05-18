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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListClustersResponseUnmarshaller
    {
        public static ListClustersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClustersResponse listClustersResponse = new ListClustersResponse();

			listClustersResponse.HttpResponse = _ctx.HttpResponse;
			listClustersResponse.RequestId = _ctx.StringValue("ListClusters.RequestId");
			listClustersResponse.TotalCount = _ctx.IntegerValue("ListClusters.TotalCount");
			listClustersResponse.PageNumber = _ctx.IntegerValue("ListClusters.PageNumber");
			listClustersResponse.PageSize = _ctx.IntegerValue("ListClusters.PageSize");

			List<ListClustersResponse.ListClusters_ClusterInfoSimple> listClustersResponse_clusters = new List<ListClustersResponse.ListClusters_ClusterInfoSimple>();
			for (int i = 0; i < _ctx.Length("ListClusters.Clusters.Length"); i++) {
				ListClustersResponse.ListClusters_ClusterInfoSimple clusterInfoSimple = new ListClustersResponse.ListClusters_ClusterInfoSimple();
				clusterInfoSimple.Id = _ctx.StringValue("ListClusters.Clusters["+ i +"].Id");
				clusterInfoSimple.RegionId = _ctx.StringValue("ListClusters.Clusters["+ i +"].RegionId");
				clusterInfoSimple.ZoneId = _ctx.StringValue("ListClusters.Clusters["+ i +"].ZoneId");
				clusterInfoSimple.VSwitchId = _ctx.StringValue("ListClusters.Clusters["+ i +"].VSwitchId");
				clusterInfoSimple.VpcId = _ctx.StringValue("ListClusters.Clusters["+ i +"].VpcId");
				clusterInfoSimple.Name = _ctx.StringValue("ListClusters.Clusters["+ i +"].Name");
				clusterInfoSimple.Description = _ctx.StringValue("ListClusters.Clusters["+ i +"].Description");
				clusterInfoSimple.Status = _ctx.StringValue("ListClusters.Clusters["+ i +"].Status");
				clusterInfoSimple.OsTag = _ctx.StringValue("ListClusters.Clusters["+ i +"].OsTag");
				clusterInfoSimple.AccountType = _ctx.StringValue("ListClusters.Clusters["+ i +"].AccountType");
				clusterInfoSimple.SchedulerType = _ctx.StringValue("ListClusters.Clusters["+ i +"].SchedulerType");
				clusterInfoSimple.DeployMode = _ctx.StringValue("ListClusters.Clusters["+ i +"].DeployMode");
				clusterInfoSimple.Count = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].Count");
				clusterInfoSimple.InstanceType = _ctx.StringValue("ListClusters.Clusters["+ i +"].InstanceType");
				clusterInfoSimple.LoginNodes = _ctx.StringValue("ListClusters.Clusters["+ i +"].LoginNodes");
				clusterInfoSimple.CreateTime = _ctx.StringValue("ListClusters.Clusters["+ i +"].CreateTime");
				clusterInfoSimple.ImageOwnerAlias = _ctx.StringValue("ListClusters.Clusters["+ i +"].ImageOwnerAlias");
				clusterInfoSimple.ImageId = _ctx.StringValue("ListClusters.Clusters["+ i +"].ImageId");
				clusterInfoSimple.Location = _ctx.StringValue("ListClusters.Clusters["+ i +"].Location");
				clusterInfoSimple.EhpcVersion = _ctx.StringValue("ListClusters.Clusters["+ i +"].EhpcVersion");
				clusterInfoSimple.NodePrefix = _ctx.StringValue("ListClusters.Clusters["+ i +"].NodePrefix");
				clusterInfoSimple.NodeSuffix = _ctx.StringValue("ListClusters.Clusters["+ i +"].NodeSuffix");
				clusterInfoSimple.BaseOsTag = _ctx.StringValue("ListClusters.Clusters["+ i +"].BaseOsTag");
				clusterInfoSimple.InstanceChargeType = _ctx.StringValue("ListClusters.Clusters["+ i +"].InstanceChargeType");
				clusterInfoSimple.ComputeSpotStrategy = _ctx.StringValue("ListClusters.Clusters["+ i +"].ComputeSpotStrategy");
				clusterInfoSimple.ComputeSpotPriceLimit = _ctx.FloatValue("ListClusters.Clusters["+ i +"].ComputeSpotPriceLimit");
				clusterInfoSimple.ClientVersion = _ctx.StringValue("ListClusters.Clusters["+ i +"].ClientVersion");
				clusterInfoSimple.IsComputeEss = _ctx.BooleanValue("ListClusters.Clusters["+ i +"].IsComputeEss");

				ListClustersResponse.ListClusters_ClusterInfoSimple.ListClusters_Managers managers = new ListClustersResponse.ListClusters_ClusterInfoSimple.ListClusters_Managers();
				managers.Total = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].Managers.Total");
				managers.NormalCount = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].Managers.NormalCount");
				managers.OperatingCount = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].Managers.OperatingCount");
				managers.StoppedCount = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].Managers.StoppedCount");
				managers.ExceptionCount = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].Managers.ExceptionCount");
				clusterInfoSimple.Managers = managers;

				ListClustersResponse.ListClusters_ClusterInfoSimple.ListClusters_Computes computes = new ListClustersResponse.ListClusters_ClusterInfoSimple.ListClusters_Computes();
				computes.Total = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].Computes.Total");
				computes.NormalCount = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].Computes.NormalCount");
				computes.OperatingCount = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].Computes.OperatingCount");
				computes.StoppedCount = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].Computes.StoppedCount");
				computes.ExceptionCount = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].Computes.ExceptionCount");
				clusterInfoSimple.Computes = computes;

				ListClustersResponse.ListClusters_ClusterInfoSimple.ListClusters_TotalResources totalResources = new ListClustersResponse.ListClusters_ClusterInfoSimple.ListClusters_TotalResources();
				totalResources.Cpu = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].TotalResources.Cpu");
				totalResources.Memory = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].TotalResources.Memory");
				totalResources.Gpu = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].TotalResources.Gpu");
				clusterInfoSimple.TotalResources = totalResources;

				ListClustersResponse.ListClusters_ClusterInfoSimple.ListClusters_UsedResources usedResources = new ListClustersResponse.ListClusters_ClusterInfoSimple.ListClusters_UsedResources();
				usedResources.Cpu = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].UsedResources.Cpu");
				usedResources.Memory = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].UsedResources.Memory");
				usedResources.Gpu = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].UsedResources.Gpu");
				clusterInfoSimple.UsedResources = usedResources;

				listClustersResponse_clusters.Add(clusterInfoSimple);
			}
			listClustersResponse.Clusters = listClustersResponse_clusters;
        
			return listClustersResponse;
        }
    }
}
