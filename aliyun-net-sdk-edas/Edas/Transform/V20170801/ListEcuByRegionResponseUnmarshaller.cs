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
    public class ListEcuByRegionResponseUnmarshaller
    {
        public static ListEcuByRegionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEcuByRegionResponse listEcuByRegionResponse = new ListEcuByRegionResponse();

			listEcuByRegionResponse.HttpResponse = _ctx.HttpResponse;
			listEcuByRegionResponse.Code = _ctx.IntegerValue("ListEcuByRegion.Code");
			listEcuByRegionResponse.Message = _ctx.StringValue("ListEcuByRegion.Message");
			listEcuByRegionResponse.RequestId = _ctx.StringValue("ListEcuByRegion.RequestId");

			List<ListEcuByRegionResponse.ListEcuByRegion_EcuEntity> listEcuByRegionResponse_ecuEntityList = new List<ListEcuByRegionResponse.ListEcuByRegion_EcuEntity>();
			for (int i = 0; i < _ctx.Length("ListEcuByRegion.EcuEntityList.Length"); i++) {
				ListEcuByRegionResponse.ListEcuByRegion_EcuEntity ecuEntity = new ListEcuByRegionResponse.ListEcuByRegion_EcuEntity();
				ecuEntity.EcuId = _ctx.StringValue("ListEcuByRegion.EcuEntityList["+ i +"].EcuId");
				ecuEntity.Online = _ctx.BooleanValue("ListEcuByRegion.EcuEntityList["+ i +"].Online");
				ecuEntity.DockerEnv = _ctx.BooleanValue("ListEcuByRegion.EcuEntityList["+ i +"].DockerEnv");
				ecuEntity.CreateTime = _ctx.LongValue("ListEcuByRegion.EcuEntityList["+ i +"].CreateTime");
				ecuEntity.UpdateTime = _ctx.LongValue("ListEcuByRegion.EcuEntityList["+ i +"].UpdateTime");
				ecuEntity.IpAddr = _ctx.StringValue("ListEcuByRegion.EcuEntityList["+ i +"].IpAddr");
				ecuEntity.HeartbeatTime = _ctx.LongValue("ListEcuByRegion.EcuEntityList["+ i +"].HeartbeatTime");
				ecuEntity.UserId = _ctx.StringValue("ListEcuByRegion.EcuEntityList["+ i +"].UserId");
				ecuEntity.Name = _ctx.StringValue("ListEcuByRegion.EcuEntityList["+ i +"].Name");
				ecuEntity.ZoneId = _ctx.StringValue("ListEcuByRegion.EcuEntityList["+ i +"].ZoneId");
				ecuEntity.RegionId = _ctx.StringValue("ListEcuByRegion.EcuEntityList["+ i +"].RegionId");
				ecuEntity.InstanceId = _ctx.StringValue("ListEcuByRegion.EcuEntityList["+ i +"].InstanceId");
				ecuEntity.VpcId = _ctx.StringValue("ListEcuByRegion.EcuEntityList["+ i +"].VpcId");
				ecuEntity.AvailableCpu = _ctx.IntegerValue("ListEcuByRegion.EcuEntityList["+ i +"].AvailableCpu");
				ecuEntity.AvailableMem = _ctx.IntegerValue("ListEcuByRegion.EcuEntityList["+ i +"].AvailableMem");
				ecuEntity.Cpu = _ctx.IntegerValue("ListEcuByRegion.EcuEntityList["+ i +"].Cpu");
				ecuEntity.Mem = _ctx.IntegerValue("ListEcuByRegion.EcuEntityList["+ i +"].Mem");

				listEcuByRegionResponse_ecuEntityList.Add(ecuEntity);
			}
			listEcuByRegionResponse.EcuEntityList = listEcuByRegionResponse_ecuEntityList;
        
			return listEcuByRegionResponse;
        }
    }
}
