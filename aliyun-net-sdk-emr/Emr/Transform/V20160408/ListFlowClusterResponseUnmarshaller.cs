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
        public static ListFlowClusterResponse Unmarshall(UnmarshallerContext context)
        {
			ListFlowClusterResponse listFlowClusterResponse = new ListFlowClusterResponse();

			listFlowClusterResponse.HttpResponse = context.HttpResponse;
			listFlowClusterResponse.RequestId = context.StringValue("ListFlowCluster.RequestId");
			listFlowClusterResponse.TotalCount = context.IntegerValue("ListFlowCluster.TotalCount");
			listFlowClusterResponse.PageNumber = context.IntegerValue("ListFlowCluster.PageNumber");
			listFlowClusterResponse.PageSize = context.IntegerValue("ListFlowCluster.PageSize");

			List<ListFlowClusterResponse.ListFlowCluster_ClusterInfo> listFlowClusterResponse_clusters = new List<ListFlowClusterResponse.ListFlowCluster_ClusterInfo>();
			for (int i = 0; i < context.Length("ListFlowCluster.Clusters.Length"); i++) {
				ListFlowClusterResponse.ListFlowCluster_ClusterInfo clusterInfo = new ListFlowClusterResponse.ListFlowCluster_ClusterInfo();
				clusterInfo.Id = context.StringValue("ListFlowCluster.Clusters["+ i +"].Id");
				clusterInfo.Name = context.StringValue("ListFlowCluster.Clusters["+ i +"].Name");
				clusterInfo.Type = context.StringValue("ListFlowCluster.Clusters["+ i +"].Type");
				clusterInfo.CreateTime = context.LongValue("ListFlowCluster.Clusters["+ i +"].CreateTime");
				clusterInfo.RunningTime = context.IntegerValue("ListFlowCluster.Clusters["+ i +"].RunningTime");
				clusterInfo.Status = context.StringValue("ListFlowCluster.Clusters["+ i +"].Status");
				clusterInfo.ChargeType = context.StringValue("ListFlowCluster.Clusters["+ i +"].ChargeType");
				clusterInfo.ExpiredTime = context.LongValue("ListFlowCluster.Clusters["+ i +"].ExpiredTime");
				clusterInfo.Period = context.IntegerValue("ListFlowCluster.Clusters["+ i +"].Period");
				clusterInfo.HasUncompletedOrder = context.BooleanValue("ListFlowCluster.Clusters["+ i +"].HasUncompletedOrder");
				clusterInfo.OrderList = context.StringValue("ListFlowCluster.Clusters["+ i +"].OrderList");
				clusterInfo.CreateResource = context.StringValue("ListFlowCluster.Clusters["+ i +"].CreateResource");

				ListFlowClusterResponse.ListFlowCluster_ClusterInfo.ListFlowCluster_OrderTaskInfo orderTaskInfo = new ListFlowClusterResponse.ListFlowCluster_ClusterInfo.ListFlowCluster_OrderTaskInfo();
				orderTaskInfo.TargetCount = context.IntegerValue("ListFlowCluster.Clusters["+ i +"].OrderTaskInfo.TargetCount");
				orderTaskInfo.CurrentCount = context.IntegerValue("ListFlowCluster.Clusters["+ i +"].OrderTaskInfo.CurrentCount");
				orderTaskInfo.OrderIdList = context.StringValue("ListFlowCluster.Clusters["+ i +"].OrderTaskInfo.OrderIdList");
				clusterInfo.OrderTaskInfo = orderTaskInfo;

				ListFlowClusterResponse.ListFlowCluster_ClusterInfo.ListFlowCluster_FailReason failReason = new ListFlowClusterResponse.ListFlowCluster_ClusterInfo.ListFlowCluster_FailReason();
				failReason.ErrorCode = context.StringValue("ListFlowCluster.Clusters["+ i +"].FailReason.ErrorCode");
				failReason.ErrorMsg = context.StringValue("ListFlowCluster.Clusters["+ i +"].FailReason.ErrorMsg");
				failReason.RequestId = context.StringValue("ListFlowCluster.Clusters["+ i +"].FailReason.RequestId");
				clusterInfo.FailReason = failReason;

				listFlowClusterResponse_clusters.Add(clusterInfo);
			}
			listFlowClusterResponse.Clusters = listFlowClusterResponse_clusters;
        
			return listFlowClusterResponse;
        }
    }
}
