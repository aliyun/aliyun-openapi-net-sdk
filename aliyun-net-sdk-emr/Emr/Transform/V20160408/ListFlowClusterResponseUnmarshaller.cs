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
    public class ListFlowClusterResponseUnmarshaller
    {
        public static ListFlowClusterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFlowClusterResponse listFlowClusterResponse = new ListFlowClusterResponse();

			listFlowClusterResponse.HttpResponse = _ctx.HttpResponse;
			listFlowClusterResponse.RequestId = _ctx.StringValue("ListFlowCluster.RequestId");
			listFlowClusterResponse.TotalCount = _ctx.IntegerValue("ListFlowCluster.TotalCount");
			listFlowClusterResponse.PageNumber = _ctx.IntegerValue("ListFlowCluster.PageNumber");
			listFlowClusterResponse.PageSize = _ctx.IntegerValue("ListFlowCluster.PageSize");

			List<ListFlowClusterResponse.ListFlowCluster_ClusterInfo> listFlowClusterResponse_clusters = new List<ListFlowClusterResponse.ListFlowCluster_ClusterInfo>();
			for (int i = 0; i < _ctx.Length("ListFlowCluster.Clusters.Length"); i++) {
				ListFlowClusterResponse.ListFlowCluster_ClusterInfo clusterInfo = new ListFlowClusterResponse.ListFlowCluster_ClusterInfo();
				clusterInfo.Id = _ctx.StringValue("ListFlowCluster.Clusters["+ i +"].Id");
				clusterInfo.Name = _ctx.StringValue("ListFlowCluster.Clusters["+ i +"].Name");
				clusterInfo.Type = _ctx.StringValue("ListFlowCluster.Clusters["+ i +"].Type");
				clusterInfo.CreateTime = _ctx.LongValue("ListFlowCluster.Clusters["+ i +"].CreateTime");
				clusterInfo.RunningTime = _ctx.IntegerValue("ListFlowCluster.Clusters["+ i +"].RunningTime");
				clusterInfo.Status = _ctx.StringValue("ListFlowCluster.Clusters["+ i +"].Status");
				clusterInfo.ChargeType = _ctx.StringValue("ListFlowCluster.Clusters["+ i +"].ChargeType");
				clusterInfo.ExpiredTime = _ctx.LongValue("ListFlowCluster.Clusters["+ i +"].ExpiredTime");
				clusterInfo.Period = _ctx.IntegerValue("ListFlowCluster.Clusters["+ i +"].Period");
				clusterInfo.HasUncompletedOrder = _ctx.BooleanValue("ListFlowCluster.Clusters["+ i +"].HasUncompletedOrder");
				clusterInfo.OrderList = _ctx.StringValue("ListFlowCluster.Clusters["+ i +"].OrderList");
				clusterInfo.CreateResource = _ctx.StringValue("ListFlowCluster.Clusters["+ i +"].CreateResource");
				clusterInfo.K8sClusterId = _ctx.StringValue("ListFlowCluster.Clusters["+ i +"].K8sClusterId");

				ListFlowClusterResponse.ListFlowCluster_ClusterInfo.ListFlowCluster_OrderTaskInfo orderTaskInfo = new ListFlowClusterResponse.ListFlowCluster_ClusterInfo.ListFlowCluster_OrderTaskInfo();
				orderTaskInfo.TargetCount = _ctx.IntegerValue("ListFlowCluster.Clusters["+ i +"].OrderTaskInfo.TargetCount");
				orderTaskInfo.CurrentCount = _ctx.IntegerValue("ListFlowCluster.Clusters["+ i +"].OrderTaskInfo.CurrentCount");
				orderTaskInfo.OrderIdList = _ctx.StringValue("ListFlowCluster.Clusters["+ i +"].OrderTaskInfo.OrderIdList");
				clusterInfo.OrderTaskInfo = orderTaskInfo;

				ListFlowClusterResponse.ListFlowCluster_ClusterInfo.ListFlowCluster_FailReason failReason = new ListFlowClusterResponse.ListFlowCluster_ClusterInfo.ListFlowCluster_FailReason();
				failReason.ErrorCode = _ctx.StringValue("ListFlowCluster.Clusters["+ i +"].FailReason.ErrorCode");
				failReason.ErrorMsg = _ctx.StringValue("ListFlowCluster.Clusters["+ i +"].FailReason.ErrorMsg");
				failReason.RequestId = _ctx.StringValue("ListFlowCluster.Clusters["+ i +"].FailReason.RequestId");
				clusterInfo.FailReason = failReason;

				listFlowClusterResponse_clusters.Add(clusterInfo);
			}
			listFlowClusterResponse.Clusters = listFlowClusterResponse_clusters;
        
			return listFlowClusterResponse;
        }
    }
}
