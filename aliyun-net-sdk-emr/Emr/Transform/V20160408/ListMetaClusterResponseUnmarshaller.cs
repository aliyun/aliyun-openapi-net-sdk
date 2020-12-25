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
    public class ListMetaClusterResponseUnmarshaller
    {
        public static ListMetaClusterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMetaClusterResponse listMetaClusterResponse = new ListMetaClusterResponse();

			listMetaClusterResponse.HttpResponse = _ctx.HttpResponse;
			listMetaClusterResponse.RequestId = _ctx.StringValue("ListMetaCluster.RequestId");
			listMetaClusterResponse.PageNumber = _ctx.IntegerValue("ListMetaCluster.PageNumber");
			listMetaClusterResponse.PageSize = _ctx.IntegerValue("ListMetaCluster.PageSize");
			listMetaClusterResponse.TotalCount = _ctx.IntegerValue("ListMetaCluster.TotalCount");

			List<ListMetaClusterResponse.ListMetaCluster_Item> listMetaClusterResponse_items = new List<ListMetaClusterResponse.ListMetaCluster_Item>();
			for (int i = 0; i < _ctx.Length("ListMetaCluster.Items.Length"); i++) {
				ListMetaClusterResponse.ListMetaCluster_Item item = new ListMetaClusterResponse.ListMetaCluster_Item();
				item.Id = _ctx.StringValue("ListMetaCluster.Items["+ i +"].Id");
				item.Name = _ctx.StringValue("ListMetaCluster.Items["+ i +"].Name");

				ListMetaClusterResponse.ListMetaCluster_Item.ListMetaCluster_SoftwareInfo softwareInfo = new ListMetaClusterResponse.ListMetaCluster_Item.ListMetaCluster_SoftwareInfo();
				softwareInfo.EmrVer = _ctx.StringValue("ListMetaCluster.Items["+ i +"].SoftwareInfo.EmrVer");
				softwareInfo.ClusterType = _ctx.StringValue("ListMetaCluster.Items["+ i +"].SoftwareInfo.ClusterType");
				item.SoftwareInfo = softwareInfo;

				listMetaClusterResponse_items.Add(item);
			}
			listMetaClusterResponse.Items = listMetaClusterResponse_items;
        
			return listMetaClusterResponse;
        }
    }
}
