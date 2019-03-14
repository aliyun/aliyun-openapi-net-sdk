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

			List<ListClustersResponse.ListClusters_ClusterInfo> listClustersResponse_clusters = new List<ListClustersResponse.ListClusters_ClusterInfo>();
			for (int i = 0; i < context.Length("ListClusters.Clusters.Length"); i++) {
				ListClustersResponse.ListClusters_ClusterInfo clusterInfo = new ListClustersResponse.ListClusters_ClusterInfo();
				clusterInfo.Id = context.StringValue("ListClusters.Clusters["+ i +"].Id");
				clusterInfo.Name = context.StringValue("ListClusters.Clusters["+ i +"].Name");
				clusterInfo.Type = context.StringValue("ListClusters.Clusters["+ i +"].Type");
				clusterInfo.CreateTime = context.LongValue("ListClusters.Clusters["+ i +"].CreateTime");
				clusterInfo.RunningTime = context.IntegerValue("ListClusters.Clusters["+ i +"].RunningTime");
				clusterInfo.Status = context.StringValue("ListClusters.Clusters["+ i +"].Status");
				clusterInfo.ChargeType = context.StringValue("ListClusters.Clusters["+ i +"].ChargeType");
				clusterInfo.ExpiredTime = context.LongValue("ListClusters.Clusters["+ i +"].ExpiredTime");
				clusterInfo.Period = context.IntegerValue("ListClusters.Clusters["+ i +"].Period");
				clusterInfo.HasUncompletedOrder = context.BooleanValue("ListClusters.Clusters["+ i +"].HasUncompletedOrder");
				clusterInfo.OrderList = context.StringValue("ListClusters.Clusters["+ i +"].OrderList");
				clusterInfo.CreateResource = context.StringValue("ListClusters.Clusters["+ i +"].CreateResource");
				clusterInfo.DepositType = context.StringValue("ListClusters.Clusters["+ i +"].DepositType");

				ListClustersResponse.ListClusters_ClusterInfo.ListClusters_OrderTaskInfo orderTaskInfo = new ListClustersResponse.ListClusters_ClusterInfo.ListClusters_OrderTaskInfo();
				orderTaskInfo.TargetCount = context.IntegerValue("ListClusters.Clusters["+ i +"].OrderTaskInfo.TargetCount");
				orderTaskInfo.CurrentCount = context.IntegerValue("ListClusters.Clusters["+ i +"].OrderTaskInfo.CurrentCount");
				orderTaskInfo.OrderIdList = context.StringValue("ListClusters.Clusters["+ i +"].OrderTaskInfo.OrderIdList");
				clusterInfo.OrderTaskInfo = orderTaskInfo;

				ListClustersResponse.ListClusters_ClusterInfo.ListClusters_FailReason failReason = new ListClustersResponse.ListClusters_ClusterInfo.ListClusters_FailReason();
				failReason.ErrorCode = context.StringValue("ListClusters.Clusters["+ i +"].FailReason.ErrorCode");
				failReason.ErrorMsg = context.StringValue("ListClusters.Clusters["+ i +"].FailReason.ErrorMsg");
				failReason.RequestId = context.StringValue("ListClusters.Clusters["+ i +"].FailReason.RequestId");
				clusterInfo.FailReason = failReason;

				listClustersResponse_clusters.Add(clusterInfo);
			}
			listClustersResponse.Clusters = listClustersResponse_clusters;
        
			return listClustersResponse;
        }
    }
}
