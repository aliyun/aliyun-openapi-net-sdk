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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListConnectedClustersResponseUnmarshaller
    {
        public static ListConnectedClustersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListConnectedClustersResponse listConnectedClustersResponse = new ListConnectedClustersResponse();

			listConnectedClustersResponse.HttpResponse = _ctx.HttpResponse;
			listConnectedClustersResponse.RequestId = _ctx.StringValue("ListConnectedClusters.RequestId");

			List<ListConnectedClustersResponse.ListConnectedClusters_ResultItem> listConnectedClustersResponse_result = new List<ListConnectedClustersResponse.ListConnectedClusters_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListConnectedClusters.Result.Length"); i++) {
				ListConnectedClustersResponse.ListConnectedClusters_ResultItem resultItem = new ListConnectedClustersResponse.ListConnectedClusters_ResultItem();
				resultItem.Instances = _ctx.StringValue("ListConnectedClusters.Result["+ i +"].instances");
				resultItem.NetworkType = _ctx.StringValue("ListConnectedClusters.Result["+ i +"].networkType");

				listConnectedClustersResponse_result.Add(resultItem);
			}
			listConnectedClustersResponse.Result = listConnectedClustersResponse_result;
        
			return listConnectedClustersResponse;
        }
    }
}
