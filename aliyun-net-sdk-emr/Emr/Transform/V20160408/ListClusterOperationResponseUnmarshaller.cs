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
        public static ListClusterOperationResponse Unmarshall(UnmarshallerContext context)
        {
			ListClusterOperationResponse listClusterOperationResponse = new ListClusterOperationResponse();

			listClusterOperationResponse.HttpResponse = context.HttpResponse;
			listClusterOperationResponse.RequestId = context.StringValue("ListClusterOperation.RequestId");
			listClusterOperationResponse.TotalCount = context.IntegerValue("ListClusterOperation.TotalCount");
			listClusterOperationResponse.PageNumber = context.IntegerValue("ListClusterOperation.PageNumber");
			listClusterOperationResponse.PageSize = context.IntegerValue("ListClusterOperation.PageSize");

			List<ListClusterOperationResponse.ListClusterOperation_ClusterOperation> listClusterOperationResponse_clusterOperationList = new List<ListClusterOperationResponse.ListClusterOperation_ClusterOperation>();
			for (int i = 0; i < context.Length("ListClusterOperation.ClusterOperationList.Length"); i++) {
				ListClusterOperationResponse.ListClusterOperation_ClusterOperation clusterOperation = new ListClusterOperationResponse.ListClusterOperation_ClusterOperation();
				clusterOperation.OperationId = context.StringValue("ListClusterOperation.ClusterOperationList["+ i +"].OperationId");
				clusterOperation.OperationName = context.StringValue("ListClusterOperation.ClusterOperationList["+ i +"].OperationName");
				clusterOperation.StartTime = context.StringValue("ListClusterOperation.ClusterOperationList["+ i +"].StartTime");
				clusterOperation.Duration = context.StringValue("ListClusterOperation.ClusterOperationList["+ i +"].Duration");
				clusterOperation.Status = context.StringValue("ListClusterOperation.ClusterOperationList["+ i +"].Status");
				clusterOperation.Percentage = context.StringValue("ListClusterOperation.ClusterOperationList["+ i +"].Percentage");
				clusterOperation.Comment = context.StringValue("ListClusterOperation.ClusterOperationList["+ i +"].Comment");

				listClusterOperationResponse_clusterOperationList.Add(clusterOperation);
			}
			listClusterOperationResponse.ClusterOperationList = listClusterOperationResponse_clusterOperationList;
        
			return listClusterOperationResponse;
        }
    }
}
