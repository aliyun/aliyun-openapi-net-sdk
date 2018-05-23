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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.EHPC.Model.V20180412;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListClustersResponseUnmarshaller
    {
        public static ListClustersResponse Unmarshall(UnmarshallerContext context)
        {
			ListClustersResponse listClustersResponse = new ListClustersResponse();

			listClustersResponse.HttpResponse = context.HttpResponse;
			listClustersResponse.RequestId = context.StringValue("ListClusters.RequestId");
			listClustersResponse.TotalCount = context.IntegerValue("ListClusters.TotalCount");
			listClustersResponse.PageNumber = context.IntegerValue("ListClusters.PageNumber");
			listClustersResponse.PageSize = context.IntegerValue("ListClusters.PageSize");

			List<ListClustersResponse.ListClusters_ClusterInfoSimple> listClustersResponse_clusters = new List<ListClustersResponse.ListClusters_ClusterInfoSimple>();
			for (int i = 0; i < context.Length("ListClusters.Clusters.Length"); i++) {
				ListClustersResponse.ListClusters_ClusterInfoSimple clusterInfoSimple = new ListClustersResponse.ListClusters_ClusterInfoSimple();
				clusterInfoSimple.Id = context.StringValue("ListClusters.Clusters["+ i +"].Id");
				clusterInfoSimple.RegionId = context.StringValue("ListClusters.Clusters["+ i +"].RegionId");
				clusterInfoSimple.ZoneId = context.StringValue("ListClusters.Clusters["+ i +"].ZoneId");
				clusterInfoSimple.Name = context.StringValue("ListClusters.Clusters["+ i +"].Name");
				clusterInfoSimple.Description = context.StringValue("ListClusters.Clusters["+ i +"].Description");
				clusterInfoSimple.Status = context.StringValue("ListClusters.Clusters["+ i +"].Status");
				clusterInfoSimple.OsTag = context.StringValue("ListClusters.Clusters["+ i +"].OsTag");
				clusterInfoSimple.AccountType = context.StringValue("ListClusters.Clusters["+ i +"].AccountType");
				clusterInfoSimple.SchedulerType = context.StringValue("ListClusters.Clusters["+ i +"].SchedulerType");
				clusterInfoSimple.DeployMode = context.StringValue("ListClusters.Clusters["+ i +"].DeployMode");
				clusterInfoSimple.Count = context.IntegerValue("ListClusters.Clusters["+ i +"].Count");
				clusterInfoSimple.InstanceType = context.StringValue("ListClusters.Clusters["+ i +"].InstanceType");
				clusterInfoSimple.LoginNodes = context.StringValue("ListClusters.Clusters["+ i +"].LoginNodes");
				clusterInfoSimple.CreateTime = context.StringValue("ListClusters.Clusters["+ i +"].CreateTime");
				clusterInfoSimple.ImageOwnerAlias = context.StringValue("ListClusters.Clusters["+ i +"].ImageOwnerAlias");
				clusterInfoSimple.ImageId = context.StringValue("ListClusters.Clusters["+ i +"].ImageId");

				ListClustersResponse.ListClusters_ClusterInfoSimple.ListClusters_Managers managers = new ListClustersResponse.ListClusters_ClusterInfoSimple.ListClusters_Managers();
				managers.Total = context.IntegerValue("ListClusters.Clusters["+ i +"].Managers.Total");
				managers.NormalCount = context.IntegerValue("ListClusters.Clusters["+ i +"].Managers.NormalCount");
				managers.OperatingCount = context.IntegerValue("ListClusters.Clusters["+ i +"].Managers.OperatingCount");
				managers.StoppedCount = context.IntegerValue("ListClusters.Clusters["+ i +"].Managers.StoppedCount");
				managers.ExceptionCount = context.IntegerValue("ListClusters.Clusters["+ i +"].Managers.ExceptionCount");
				clusterInfoSimple.Managers = managers;

				ListClustersResponse.ListClusters_ClusterInfoSimple.ListClusters_Computes computes = new ListClustersResponse.ListClusters_ClusterInfoSimple.ListClusters_Computes();
				computes.Total = context.IntegerValue("ListClusters.Clusters["+ i +"].Computes.Total");
				computes.NormalCount = context.IntegerValue("ListClusters.Clusters["+ i +"].Computes.NormalCount");
				computes.OperatingCount = context.IntegerValue("ListClusters.Clusters["+ i +"].Computes.OperatingCount");
				computes.StoppedCount = context.IntegerValue("ListClusters.Clusters["+ i +"].Computes.StoppedCount");
				computes.ExceptionCount = context.IntegerValue("ListClusters.Clusters["+ i +"].Computes.ExceptionCount");
				clusterInfoSimple.Computes = computes;

				ListClustersResponse.ListClusters_ClusterInfoSimple.ListClusters_TotalResources totalResources = new ListClustersResponse.ListClusters_ClusterInfoSimple.ListClusters_TotalResources();
				totalResources.Cpu = context.IntegerValue("ListClusters.Clusters["+ i +"].TotalResources.Cpu");
				totalResources.Memory = context.IntegerValue("ListClusters.Clusters["+ i +"].TotalResources.Memory");
				totalResources.Gpu = context.IntegerValue("ListClusters.Clusters["+ i +"].TotalResources.Gpu");
				clusterInfoSimple.TotalResources = totalResources;

				ListClustersResponse.ListClusters_ClusterInfoSimple.ListClusters_UsedResources usedResources = new ListClustersResponse.ListClusters_ClusterInfoSimple.ListClusters_UsedResources();
				usedResources.Cpu = context.IntegerValue("ListClusters.Clusters["+ i +"].UsedResources.Cpu");
				usedResources.Memory = context.IntegerValue("ListClusters.Clusters["+ i +"].UsedResources.Memory");
				usedResources.Gpu = context.IntegerValue("ListClusters.Clusters["+ i +"].UsedResources.Gpu");
				clusterInfoSimple.UsedResources = usedResources;

				listClustersResponse_clusters.Add(clusterInfoSimple);
			}
			listClustersResponse.Clusters = listClustersResponse_clusters;
        
			return listClustersResponse;
        }
    }
}