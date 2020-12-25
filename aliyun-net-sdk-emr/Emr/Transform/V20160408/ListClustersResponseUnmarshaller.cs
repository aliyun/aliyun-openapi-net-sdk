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
        public static ListClustersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClustersResponse listClustersResponse = new ListClustersResponse();

			listClustersResponse.HttpResponse = _ctx.HttpResponse;
			listClustersResponse.RequestId = _ctx.StringValue("ListClusters.RequestId");
			listClustersResponse.TotalCount = _ctx.IntegerValue("ListClusters.TotalCount");
			listClustersResponse.PageNumber = _ctx.IntegerValue("ListClusters.PageNumber");
			listClustersResponse.PageSize = _ctx.IntegerValue("ListClusters.PageSize");

			List<ListClustersResponse.ListClusters_ClusterInfo> listClustersResponse_clusters = new List<ListClustersResponse.ListClusters_ClusterInfo>();
			for (int i = 0; i < _ctx.Length("ListClusters.Clusters.Length"); i++) {
				ListClustersResponse.ListClusters_ClusterInfo clusterInfo = new ListClustersResponse.ListClusters_ClusterInfo();
				clusterInfo.Id = _ctx.StringValue("ListClusters.Clusters["+ i +"].Id");
				clusterInfo.Name = _ctx.StringValue("ListClusters.Clusters["+ i +"].Name");
				clusterInfo.MachineType = _ctx.StringValue("ListClusters.Clusters["+ i +"].MachineType");
				clusterInfo.Type = _ctx.StringValue("ListClusters.Clusters["+ i +"].Type");
				clusterInfo.CreateTime = _ctx.LongValue("ListClusters.Clusters["+ i +"].CreateTime");
				clusterInfo.RunningTime = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].RunningTime");
				clusterInfo.Status = _ctx.StringValue("ListClusters.Clusters["+ i +"].Status");
				clusterInfo.ChargeType = _ctx.StringValue("ListClusters.Clusters["+ i +"].ChargeType");
				clusterInfo.ExpiredTime = _ctx.LongValue("ListClusters.Clusters["+ i +"].ExpiredTime");
				clusterInfo.Period = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].Period");
				clusterInfo.HasUncompletedOrder = _ctx.BooleanValue("ListClusters.Clusters["+ i +"].HasUncompletedOrder");
				clusterInfo.OrderList = _ctx.StringValue("ListClusters.Clusters["+ i +"].OrderList");
				clusterInfo.CreateResource = _ctx.StringValue("ListClusters.Clusters["+ i +"].CreateResource");
				clusterInfo.DepositType = _ctx.StringValue("ListClusters.Clusters["+ i +"].DepositType");
				clusterInfo.MetaStoreType = _ctx.StringValue("ListClusters.Clusters["+ i +"].MetaStoreType");
				clusterInfo.K8sClusterId = _ctx.StringValue("ListClusters.Clusters["+ i +"].K8sClusterId");
				clusterInfo.OperationId = _ctx.LongValue("ListClusters.Clusters["+ i +"].OperationId");

				ListClustersResponse.ListClusters_ClusterInfo.ListClusters_OrderTaskInfo orderTaskInfo = new ListClustersResponse.ListClusters_ClusterInfo.ListClusters_OrderTaskInfo();
				orderTaskInfo.TargetCount = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].OrderTaskInfo.TargetCount");
				orderTaskInfo.CurrentCount = _ctx.IntegerValue("ListClusters.Clusters["+ i +"].OrderTaskInfo.CurrentCount");
				orderTaskInfo.OrderIdList = _ctx.StringValue("ListClusters.Clusters["+ i +"].OrderTaskInfo.OrderIdList");
				clusterInfo.OrderTaskInfo = orderTaskInfo;

				ListClustersResponse.ListClusters_ClusterInfo.ListClusters_FailReason failReason = new ListClustersResponse.ListClusters_ClusterInfo.ListClusters_FailReason();
				failReason.ErrorCode = _ctx.StringValue("ListClusters.Clusters["+ i +"].FailReason.ErrorCode");
				failReason.ErrorMsg = _ctx.StringValue("ListClusters.Clusters["+ i +"].FailReason.ErrorMsg");
				failReason.RequestId = _ctx.StringValue("ListClusters.Clusters["+ i +"].FailReason.RequestId");
				clusterInfo.FailReason = failReason;

				List<ListClustersResponse.ListClusters_ClusterInfo.ListClusters_Tag> clusterInfo_tags = new List<ListClustersResponse.ListClusters_ClusterInfo.ListClusters_Tag>();
				for (int j = 0; j < _ctx.Length("ListClusters.Clusters["+ i +"].Tags.Length"); j++) {
					ListClustersResponse.ListClusters_ClusterInfo.ListClusters_Tag tag = new ListClustersResponse.ListClusters_ClusterInfo.ListClusters_Tag();
					tag.TagKey = _ctx.StringValue("ListClusters.Clusters["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("ListClusters.Clusters["+ i +"].Tags["+ j +"].TagValue");

					clusterInfo_tags.Add(tag);
				}
				clusterInfo.Tags = clusterInfo_tags;

				listClustersResponse_clusters.Add(clusterInfo);
			}
			listClustersResponse.Clusters = listClustersResponse_clusters;
        
			return listClustersResponse;
        }
    }
}
