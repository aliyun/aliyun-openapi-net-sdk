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
    public class ListResourceGroupResponseUnmarshaller
    {
        public static ListResourceGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListResourceGroupResponse listResourceGroupResponse = new ListResourceGroupResponse();

			listResourceGroupResponse.HttpResponse = _ctx.HttpResponse;
			listResourceGroupResponse.Code = _ctx.IntegerValue("ListResourceGroup.Code");
			listResourceGroupResponse.Message = _ctx.StringValue("ListResourceGroup.Message");
			listResourceGroupResponse.RequestId = _ctx.StringValue("ListResourceGroup.RequestId");

			List<ListResourceGroupResponse.ListResourceGroup_ResGroupEntity> listResourceGroupResponse_resourceGroupList = new List<ListResourceGroupResponse.ListResourceGroup_ResGroupEntity>();
			for (int i = 0; i < _ctx.Length("ListResourceGroup.ResourceGroupList.Length"); i++) {
				ListResourceGroupResponse.ListResourceGroup_ResGroupEntity resGroupEntity = new ListResourceGroupResponse.ListResourceGroup_ResGroupEntity();
				resGroupEntity.Id = _ctx.LongValue("ListResourceGroup.ResourceGroupList["+ i +"].Id");
				resGroupEntity.Name = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].Name");
				resGroupEntity.Description = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].Description");
				resGroupEntity.AdminUserId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].AdminUserId");
				resGroupEntity.CreateTime = _ctx.LongValue("ListResourceGroup.ResourceGroupList["+ i +"].CreateTime");
				resGroupEntity.UpdateTime = _ctx.LongValue("ListResourceGroup.ResourceGroupList["+ i +"].UpdateTime");
				resGroupEntity.RegionId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].RegionId");

				List<ListResourceGroupResponse.ListResourceGroup_ResGroupEntity.ListResourceGroup_EcsEntity> resGroupEntity_ecsList = new List<ListResourceGroupResponse.ListResourceGroup_ResGroupEntity.ListResourceGroup_EcsEntity>();
				for (int j = 0; j < _ctx.Length("ListResourceGroup.ResourceGroupList["+ i +"].EcsList.Length"); j++) {
					ListResourceGroupResponse.ListResourceGroup_ResGroupEntity.ListResourceGroup_EcsEntity ecsEntity = new ListResourceGroupResponse.ListResourceGroup_ResGroupEntity.ListResourceGroup_EcsEntity();
					ecsEntity.InstanceId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].InstanceId");
					ecsEntity.InstanceName = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].InstanceName");
					ecsEntity.HostName = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].HostName");
					ecsEntity.Description = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].Description");
					ecsEntity.Status = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].Status");
					ecsEntity.PublicIp = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].PublicIp");
					ecsEntity.InnerIp = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].InnerIp");
					ecsEntity.PrivateIp = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].PrivateIp");
					ecsEntity.Eip = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].Eip");
					ecsEntity.SerialNum = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].SerialNum");
					ecsEntity.UserId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].UserId");
					ecsEntity.ZoneId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].ZoneId");
					ecsEntity.RegionId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].RegionId");
					ecsEntity.InstanceId1 = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].InstanceId");
					ecsEntity.Expired = _ctx.BooleanValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].Expired");
					ecsEntity.SgId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].SgId");
					ecsEntity.VpcId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].VpcId");
					ecsEntity.GroupId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].GroupId");
					ecsEntity.Cpu = _ctx.IntegerValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].Cpu");
					ecsEntity.Mem = _ctx.IntegerValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].Mem");

					ListResourceGroupResponse.ListResourceGroup_ResGroupEntity.ListResourceGroup_EcsEntity.ListResourceGroup_EcuEntity ecuEntity = new ListResourceGroupResponse.ListResourceGroup_ResGroupEntity.ListResourceGroup_EcsEntity.ListResourceGroup_EcuEntity();
					ecuEntity.EcuId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].EcuEntity.EcuId");
					ecuEntity.Online = _ctx.BooleanValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].EcuEntity.Online");
					ecuEntity.DockerEnv = _ctx.BooleanValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].EcuEntity.DockerEnv");
					ecuEntity.CreateTime = _ctx.LongValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].EcuEntity.CreateTime");
					ecuEntity.UpdateTime = _ctx.LongValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].EcuEntity.UpdateTime");
					ecuEntity.IpAddr = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].EcuEntity.IpAddr");
					ecuEntity.HeartbeatTime = _ctx.LongValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].EcuEntity.HeartbeatTime");
					ecuEntity.UserId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].EcuEntity.UserId");
					ecuEntity.Name = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].EcuEntity.Name");
					ecuEntity.ZoneId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].EcuEntity.ZoneId");
					ecuEntity.RegionId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].EcuEntity.RegionId");
					ecuEntity.InstanceId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].EcuEntity.InstanceId");
					ecuEntity.VpcId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].EcuEntity.VpcId");
					ecuEntity.AvailableCpu = _ctx.IntegerValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].EcuEntity.AvailableCpu");
					ecuEntity.AvailableMem = _ctx.IntegerValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].EcuEntity.AvailableMem");
					ecuEntity.Cpu = _ctx.IntegerValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].EcuEntity.Cpu");
					ecuEntity.Mem = _ctx.IntegerValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].EcuEntity.Mem");
					ecsEntity.EcuEntity = ecuEntity;

					ListResourceGroupResponse.ListResourceGroup_ResGroupEntity.ListResourceGroup_EcsEntity.ListResourceGroup_VpcEntity vpcEntity = new ListResourceGroupResponse.ListResourceGroup_ResGroupEntity.ListResourceGroup_EcsEntity.ListResourceGroup_VpcEntity();
					vpcEntity.VpcId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].VpcEntity.VpcId");
					vpcEntity.VpcName = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].VpcEntity.VpcName");
					vpcEntity.RegionId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].VpcEntity.RegionId");
					vpcEntity.UserId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].VpcEntity.UserId");
					vpcEntity.Cidrblock = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].VpcEntity.Cidrblock");
					vpcEntity.Status = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].VpcEntity.Status");
					vpcEntity.Description = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].VpcEntity.Description");
					vpcEntity.Expired = _ctx.BooleanValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].VpcEntity.Expired");
					vpcEntity.EcsNum = _ctx.IntegerValue("ListResourceGroup.ResourceGroupList["+ i +"].EcsList["+ j +"].VpcEntity.EcsNum");
					ecsEntity.VpcEntity = vpcEntity;

					resGroupEntity_ecsList.Add(ecsEntity);
				}
				resGroupEntity.EcsList = resGroupEntity_ecsList;

				List<ListResourceGroupResponse.ListResourceGroup_ResGroupEntity.ListResourceGroup_SlbEntity> resGroupEntity_slbList = new List<ListResourceGroupResponse.ListResourceGroup_ResGroupEntity.ListResourceGroup_SlbEntity>();
				for (int j = 0; j < _ctx.Length("ListResourceGroup.ResourceGroupList["+ i +"].SlbList.Length"); j++) {
					ListResourceGroupResponse.ListResourceGroup_ResGroupEntity.ListResourceGroup_SlbEntity slbEntity = new ListResourceGroupResponse.ListResourceGroup_ResGroupEntity.ListResourceGroup_SlbEntity();
					slbEntity.SlbId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].SlbList["+ j +"].SlbId");
					slbEntity.SlbName = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].SlbList["+ j +"].SlbName");
					slbEntity.RegionId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].SlbList["+ j +"].RegionId");
					slbEntity.UserId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].SlbList["+ j +"].UserId");
					slbEntity.Address = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].SlbList["+ j +"].Address");
					slbEntity.SlbStatus = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].SlbList["+ j +"].SlbStatus");
					slbEntity.AddressType = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].SlbList["+ j +"].AddressType");
					slbEntity.VswitchId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].SlbList["+ j +"].VswitchId");
					slbEntity.VpcId = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].SlbList["+ j +"].VpcId");
					slbEntity.NetworkType = _ctx.StringValue("ListResourceGroup.ResourceGroupList["+ i +"].SlbList["+ j +"].NetworkType");
					slbEntity.GroupId = _ctx.IntegerValue("ListResourceGroup.ResourceGroupList["+ i +"].SlbList["+ j +"].GroupId");
					slbEntity.Expired = _ctx.BooleanValue("ListResourceGroup.ResourceGroupList["+ i +"].SlbList["+ j +"].Expired");

					resGroupEntity_slbList.Add(slbEntity);
				}
				resGroupEntity.SlbList = resGroupEntity_slbList;

				listResourceGroupResponse_resourceGroupList.Add(resGroupEntity);
			}
			listResourceGroupResponse.ResourceGroupList = listResourceGroupResponse_resourceGroupList;
        
			return listResourceGroupResponse;
        }
    }
}
