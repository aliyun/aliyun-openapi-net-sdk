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
    public class ListClusterOperationResponseUnmarshaller
    {
        public static ListClusterOperationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterOperationResponse listClusterOperationResponse = new ListClusterOperationResponse();

			listClusterOperationResponse.HttpResponse = _ctx.HttpResponse;
			listClusterOperationResponse.RequestId = _ctx.StringValue("ListClusterOperation.RequestId");
			listClusterOperationResponse.TotalCount = _ctx.IntegerValue("ListClusterOperation.TotalCount");
			listClusterOperationResponse.PageNumber = _ctx.IntegerValue("ListClusterOperation.PageNumber");
			listClusterOperationResponse.PageSize = _ctx.IntegerValue("ListClusterOperation.PageSize");

			List<ListClusterOperationResponse.ListClusterOperation_ClusterOperation> listClusterOperationResponse_clusterOperationList = new List<ListClusterOperationResponse.ListClusterOperation_ClusterOperation>();
			for (int i = 0; i < _ctx.Length("ListClusterOperation.ClusterOperationList.Length"); i++) {
				ListClusterOperationResponse.ListClusterOperation_ClusterOperation clusterOperation = new ListClusterOperationResponse.ListClusterOperation_ClusterOperation();
				clusterOperation.OperationId = _ctx.StringValue("ListClusterOperation.ClusterOperationList["+ i +"].OperationId");
				clusterOperation.OperationName = _ctx.StringValue("ListClusterOperation.ClusterOperationList["+ i +"].OperationName");
				clusterOperation.StartTime = _ctx.StringValue("ListClusterOperation.ClusterOperationList["+ i +"].StartTime");
				clusterOperation.Duration = _ctx.StringValue("ListClusterOperation.ClusterOperationList["+ i +"].Duration");
				clusterOperation.Status = _ctx.StringValue("ListClusterOperation.ClusterOperationList["+ i +"].Status");
				clusterOperation.Percentage = _ctx.StringValue("ListClusterOperation.ClusterOperationList["+ i +"].Percentage");
				clusterOperation.Comment = _ctx.StringValue("ListClusterOperation.ClusterOperationList["+ i +"].Comment");

				listClusterOperationResponse_clusterOperationList.Add(clusterOperation);
			}
			listClusterOperationResponse.ClusterOperationList = listClusterOperationResponse_clusterOperationList;
        
			return listClusterOperationResponse;
        }
    }
}
