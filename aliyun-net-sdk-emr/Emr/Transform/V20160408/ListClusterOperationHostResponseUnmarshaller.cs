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
    public class ListClusterOperationHostResponseUnmarshaller
    {
        public static ListClusterOperationHostResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClusterOperationHostResponse listClusterOperationHostResponse = new ListClusterOperationHostResponse();

			listClusterOperationHostResponse.HttpResponse = _ctx.HttpResponse;
			listClusterOperationHostResponse.RequestId = _ctx.StringValue("ListClusterOperationHost.RequestId");
			listClusterOperationHostResponse.TotalCount = _ctx.IntegerValue("ListClusterOperationHost.TotalCount");
			listClusterOperationHostResponse.PageNumber = _ctx.IntegerValue("ListClusterOperationHost.PageNumber");
			listClusterOperationHostResponse.PageSize = _ctx.IntegerValue("ListClusterOperationHost.PageSize");

			List<ListClusterOperationHostResponse.ListClusterOperationHost_ClusterOperationHost> listClusterOperationHostResponse_clusterOperationHostList = new List<ListClusterOperationHostResponse.ListClusterOperationHost_ClusterOperationHost>();
			for (int i = 0; i < _ctx.Length("ListClusterOperationHost.ClusterOperationHostList.Length"); i++) {
				ListClusterOperationHostResponse.ListClusterOperationHost_ClusterOperationHost clusterOperationHost = new ListClusterOperationHostResponse.ListClusterOperationHost_ClusterOperationHost();
				clusterOperationHost.HostId = _ctx.StringValue("ListClusterOperationHost.ClusterOperationHostList["+ i +"].HostId");
				clusterOperationHost.HostName = _ctx.StringValue("ListClusterOperationHost.ClusterOperationHostList["+ i +"].HostName");
				clusterOperationHost.Status = _ctx.StringValue("ListClusterOperationHost.ClusterOperationHostList["+ i +"].Status");
				clusterOperationHost.Percentage = _ctx.StringValue("ListClusterOperationHost.ClusterOperationHostList["+ i +"].Percentage");

				listClusterOperationHostResponse_clusterOperationHostList.Add(clusterOperationHost);
			}
			listClusterOperationHostResponse.ClusterOperationHostList = listClusterOperationHostResponse_clusterOperationHostList;
        
			return listClusterOperationHostResponse;
        }
    }
}
