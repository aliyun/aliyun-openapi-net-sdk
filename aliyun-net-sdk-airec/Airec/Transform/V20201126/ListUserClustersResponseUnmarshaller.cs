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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class ListUserClustersResponseUnmarshaller
    {
        public static ListUserClustersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserClustersResponse listUserClustersResponse = new ListUserClustersResponse();

			listUserClustersResponse.HttpResponse = _ctx.HttpResponse;
			listUserClustersResponse.RequestId = _ctx.StringValue("ListUserClusters.requestId");

			ListUserClustersResponse.ListUserClusters_Headers headers = new ListUserClustersResponse.ListUserClusters_Headers();
			headers.XTotalCount = _ctx.IntegerValue("ListUserClusters.Headers.X-Total-Count");
			listUserClustersResponse.Headers = headers;

			List<ListUserClustersResponse.ListUserClusters_UserCluster> listUserClustersResponse_result = new List<ListUserClustersResponse.ListUserClusters_UserCluster>();
			for (int i = 0; i < _ctx.Length("ListUserClusters.Result.Length"); i++) {
				ListUserClustersResponse.ListUserClusters_UserCluster userCluster = new ListUserClustersResponse.ListUserClusters_UserCluster();
				userCluster.Name = _ctx.StringValue("ListUserClusters.Result["+ i +"].name");
				userCluster.Status = _ctx.StringValue("ListUserClusters.Result["+ i +"].status");
				userCluster.GmtCreate = _ctx.StringValue("ListUserClusters.Result["+ i +"].gmtCreate");
				userCluster.GmtModified = _ctx.StringValue("ListUserClusters.Result["+ i +"].gmtModified");

				ListUserClustersResponse.ListUserClusters_UserCluster.ListUserClusters_Meta meta = new ListUserClustersResponse.ListUserClusters_UserCluster.ListUserClusters_Meta();
				meta.MetaType = _ctx.StringValue("ListUserClusters.Result["+ i +"].Meta.metaType");
				meta.Description = _ctx.StringValue("ListUserClusters.Result["+ i +"].Meta.description");
				userCluster.Meta = meta;

				listUserClustersResponse_result.Add(userCluster);
			}
			listUserClustersResponse.Result = listUserClustersResponse_result;
        
			return listUserClustersResponse;
        }
    }
}
