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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListEcsNotInClusterResponseUnmarshaller
    {
        public static ListEcsNotInClusterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEcsNotInClusterResponse listEcsNotInClusterResponse = new ListEcsNotInClusterResponse();

			listEcsNotInClusterResponse.HttpResponse = _ctx.HttpResponse;
			listEcsNotInClusterResponse.Code = _ctx.IntegerValue("ListEcsNotInCluster.Code");
			listEcsNotInClusterResponse.Message = _ctx.StringValue("ListEcsNotInCluster.Message");
			listEcsNotInClusterResponse.RequestId = _ctx.StringValue("ListEcsNotInCluster.RequestId");

			List<ListEcsNotInClusterResponse.ListEcsNotInCluster_EcsEntity> listEcsNotInClusterResponse_ecsEntityList = new List<ListEcsNotInClusterResponse.ListEcsNotInCluster_EcsEntity>();
			for (int i = 0; i < _ctx.Length("ListEcsNotInCluster.EcsEntityList.Length"); i++) {
				ListEcsNotInClusterResponse.ListEcsNotInCluster_EcsEntity ecsEntity = new ListEcsNotInClusterResponse.ListEcsNotInCluster_EcsEntity();
				ecsEntity.InstanceId = _ctx.StringValue("ListEcsNotInCluster.EcsEntityList["+ i +"].InstanceId");
				ecsEntity.InstanceName = _ctx.StringValue("ListEcsNotInCluster.EcsEntityList["+ i +"].InstanceName");
				ecsEntity.VpcId = _ctx.StringValue("ListEcsNotInCluster.EcsEntityList["+ i +"].VpcId");
				ecsEntity.VpcName = _ctx.StringValue("ListEcsNotInCluster.EcsEntityList["+ i +"].VpcName");
				ecsEntity.Expired = _ctx.BooleanValue("ListEcsNotInCluster.EcsEntityList["+ i +"].Expired");
				ecsEntity.Status = _ctx.StringValue("ListEcsNotInCluster.EcsEntityList["+ i +"].Status");
				ecsEntity.RegionId = _ctx.StringValue("ListEcsNotInCluster.EcsEntityList["+ i +"].RegionId");
				ecsEntity.Cpu = _ctx.IntegerValue("ListEcsNotInCluster.EcsEntityList["+ i +"].Cpu");
				ecsEntity.Mem = _ctx.IntegerValue("ListEcsNotInCluster.EcsEntityList["+ i +"].Mem");
				ecsEntity.PublicIp = _ctx.StringValue("ListEcsNotInCluster.EcsEntityList["+ i +"].PublicIp");
				ecsEntity.InnerIp = _ctx.StringValue("ListEcsNotInCluster.EcsEntityList["+ i +"].InnerIp");
				ecsEntity.PrivateIp = _ctx.StringValue("ListEcsNotInCluster.EcsEntityList["+ i +"].PrivateIp");
				ecsEntity.Eip = _ctx.StringValue("ListEcsNotInCluster.EcsEntityList["+ i +"].Eip");

				listEcsNotInClusterResponse_ecsEntityList.Add(ecsEntity);
			}
			listEcsNotInClusterResponse.EcsEntityList = listEcsNotInClusterResponse_ecsEntityList;
        
			return listEcsNotInClusterResponse;
        }
    }
}
