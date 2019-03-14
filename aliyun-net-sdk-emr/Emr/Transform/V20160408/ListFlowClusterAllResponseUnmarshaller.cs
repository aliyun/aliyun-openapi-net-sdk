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
        public static ListFlowClusterAllResponse Unmarshall(UnmarshallerContext context)
        {
			ListFlowClusterAllResponse listFlowClusterAllResponse = new ListFlowClusterAllResponse();

			listFlowClusterAllResponse.HttpResponse = context.HttpResponse;
			listFlowClusterAllResponse.RequestId = context.StringValue("ListFlowClusterAll.RequestId");
			listFlowClusterAllResponse.TotalCount = context.IntegerValue("ListFlowClusterAll.TotalCount");
			listFlowClusterAllResponse.PageNumber = context.IntegerValue("ListFlowClusterAll.PageNumber");
			listFlowClusterAllResponse.PageSize = context.IntegerValue("ListFlowClusterAll.PageSize");

			List<ListFlowClusterAllResponse.ListFlowClusterAll_ClusterInfo> listFlowClusterAllResponse_clusters = new List<ListFlowClusterAllResponse.ListFlowClusterAll_ClusterInfo>();
			for (int i = 0; i < context.Length("ListFlowClusterAll.Clusters.Length"); i++) {
				ListFlowClusterAllResponse.ListFlowClusterAll_ClusterInfo clusterInfo = new ListFlowClusterAllResponse.ListFlowClusterAll_ClusterInfo();
				clusterInfo.Id = context.StringValue("ListFlowClusterAll.Clusters["+ i +"].Id");
				clusterInfo.Name = context.StringValue("ListFlowClusterAll.Clusters["+ i +"].Name");
				clusterInfo.Type = context.StringValue("ListFlowClusterAll.Clusters["+ i +"].Type");
				clusterInfo.CreateTime = context.LongValue("ListFlowClusterAll.Clusters["+ i +"].CreateTime");
				clusterInfo.RunningTime = context.IntegerValue("ListFlowClusterAll.Clusters["+ i +"].RunningTime");
				clusterInfo.Status = context.StringValue("ListFlowClusterAll.Clusters["+ i +"].Status");
				clusterInfo.ChargeType = context.StringValue("ListFlowClusterAll.Clusters["+ i +"].ChargeType");
				clusterInfo.ExpiredTime = context.LongValue("ListFlowClusterAll.Clusters["+ i +"].ExpiredTime");
				clusterInfo.Period = context.IntegerValue("ListFlowClusterAll.Clusters["+ i +"].Period");
				clusterInfo.HasUncompletedOrder = context.BooleanValue("ListFlowClusterAll.Clusters["+ i +"].HasUncompletedOrder");
				clusterInfo.OrderList = context.StringValue("ListFlowClusterAll.Clusters["+ i +"].OrderList");
				clusterInfo.CreateResource = context.StringValue("ListFlowClusterAll.Clusters["+ i +"].CreateResource");

				ListFlowClusterAllResponse.ListFlowClusterAll_ClusterInfo.ListFlowClusterAll_OrderTaskInfo orderTaskInfo = new ListFlowClusterAllResponse.ListFlowClusterAll_ClusterInfo.ListFlowClusterAll_OrderTaskInfo();
				orderTaskInfo.TargetCount = context.IntegerValue("ListFlowClusterAll.Clusters["+ i +"].OrderTaskInfo.TargetCount");
				orderTaskInfo.CurrentCount = context.IntegerValue("ListFlowClusterAll.Clusters["+ i +"].OrderTaskInfo.CurrentCount");
				orderTaskInfo.OrderIdList = context.StringValue("ListFlowClusterAll.Clusters["+ i +"].OrderTaskInfo.OrderIdList");
				clusterInfo.OrderTaskInfo = orderTaskInfo;

				ListFlowClusterAllResponse.ListFlowClusterAll_ClusterInfo.ListFlowClusterAll_FailReason failReason = new ListFlowClusterAllResponse.ListFlowClusterAll_ClusterInfo.ListFlowClusterAll_FailReason();
				failReason.ErrorCode = context.StringValue("ListFlowClusterAll.Clusters["+ i +"].FailReason.ErrorCode");
				failReason.ErrorMsg = context.StringValue("ListFlowClusterAll.Clusters["+ i +"].FailReason.ErrorMsg");
				failReason.RequestId = context.StringValue("ListFlowClusterAll.Clusters["+ i +"].FailReason.RequestId");
				clusterInfo.FailReason = failReason;

				listFlowClusterAllResponse_clusters.Add(clusterInfo);
			}
			listFlowClusterAllResponse.Clusters = listFlowClusterAllResponse_clusters;
        
			return listFlowClusterAllResponse;
        }
    }
}
