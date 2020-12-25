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
    public class ListFlowClusterAllResponseUnmarshaller
    {
        public static ListFlowClusterAllResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFlowClusterAllResponse listFlowClusterAllResponse = new ListFlowClusterAllResponse();

			listFlowClusterAllResponse.HttpResponse = _ctx.HttpResponse;
			listFlowClusterAllResponse.RequestId = _ctx.StringValue("ListFlowClusterAll.RequestId");
			listFlowClusterAllResponse.TotalCount = _ctx.IntegerValue("ListFlowClusterAll.TotalCount");
			listFlowClusterAllResponse.PageNumber = _ctx.IntegerValue("ListFlowClusterAll.PageNumber");
			listFlowClusterAllResponse.PageSize = _ctx.IntegerValue("ListFlowClusterAll.PageSize");

			List<ListFlowClusterAllResponse.ListFlowClusterAll_ClusterInfo> listFlowClusterAllResponse_clusters = new List<ListFlowClusterAllResponse.ListFlowClusterAll_ClusterInfo>();
			for (int i = 0; i < _ctx.Length("ListFlowClusterAll.Clusters.Length"); i++) {
				ListFlowClusterAllResponse.ListFlowClusterAll_ClusterInfo clusterInfo = new ListFlowClusterAllResponse.ListFlowClusterAll_ClusterInfo();
				clusterInfo.Id = _ctx.StringValue("ListFlowClusterAll.Clusters["+ i +"].Id");
				clusterInfo.Name = _ctx.StringValue("ListFlowClusterAll.Clusters["+ i +"].Name");
				clusterInfo.Type = _ctx.StringValue("ListFlowClusterAll.Clusters["+ i +"].Type");
				clusterInfo.CreateTime = _ctx.LongValue("ListFlowClusterAll.Clusters["+ i +"].CreateTime");
				clusterInfo.RunningTime = _ctx.IntegerValue("ListFlowClusterAll.Clusters["+ i +"].RunningTime");
				clusterInfo.Status = _ctx.StringValue("ListFlowClusterAll.Clusters["+ i +"].Status");
				clusterInfo.ChargeType = _ctx.StringValue("ListFlowClusterAll.Clusters["+ i +"].ChargeType");
				clusterInfo.ExpiredTime = _ctx.LongValue("ListFlowClusterAll.Clusters["+ i +"].ExpiredTime");
				clusterInfo.Period = _ctx.IntegerValue("ListFlowClusterAll.Clusters["+ i +"].Period");
				clusterInfo.HasUncompletedOrder = _ctx.BooleanValue("ListFlowClusterAll.Clusters["+ i +"].HasUncompletedOrder");
				clusterInfo.OrderList = _ctx.StringValue("ListFlowClusterAll.Clusters["+ i +"].OrderList");
				clusterInfo.CreateResource = _ctx.StringValue("ListFlowClusterAll.Clusters["+ i +"].CreateResource");
				clusterInfo.K8sClusterId = _ctx.StringValue("ListFlowClusterAll.Clusters["+ i +"].K8sClusterId");

				ListFlowClusterAllResponse.ListFlowClusterAll_ClusterInfo.ListFlowClusterAll_OrderTaskInfo orderTaskInfo = new ListFlowClusterAllResponse.ListFlowClusterAll_ClusterInfo.ListFlowClusterAll_OrderTaskInfo();
				orderTaskInfo.TargetCount = _ctx.IntegerValue("ListFlowClusterAll.Clusters["+ i +"].OrderTaskInfo.TargetCount");
				orderTaskInfo.CurrentCount = _ctx.IntegerValue("ListFlowClusterAll.Clusters["+ i +"].OrderTaskInfo.CurrentCount");
				orderTaskInfo.OrderIdList = _ctx.StringValue("ListFlowClusterAll.Clusters["+ i +"].OrderTaskInfo.OrderIdList");
				clusterInfo.OrderTaskInfo = orderTaskInfo;

				ListFlowClusterAllResponse.ListFlowClusterAll_ClusterInfo.ListFlowClusterAll_FailReason failReason = new ListFlowClusterAllResponse.ListFlowClusterAll_ClusterInfo.ListFlowClusterAll_FailReason();
				failReason.ErrorCode = _ctx.StringValue("ListFlowClusterAll.Clusters["+ i +"].FailReason.ErrorCode");
				failReason.ErrorMsg = _ctx.StringValue("ListFlowClusterAll.Clusters["+ i +"].FailReason.ErrorMsg");
				failReason.RequestId = _ctx.StringValue("ListFlowClusterAll.Clusters["+ i +"].FailReason.RequestId");
				clusterInfo.FailReason = failReason;

				listFlowClusterAllResponse_clusters.Add(clusterInfo);
			}
			listFlowClusterAllResponse.Clusters = listFlowClusterAllResponse_clusters;
        
			return listFlowClusterAllResponse;
        }
    }
}
