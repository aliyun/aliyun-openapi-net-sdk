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
    public class ListApplicationEcuResponseUnmarshaller
    {
        public static ListApplicationEcuResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListApplicationEcuResponse listApplicationEcuResponse = new ListApplicationEcuResponse();

			listApplicationEcuResponse.HttpResponse = _ctx.HttpResponse;
			listApplicationEcuResponse.Code = _ctx.IntegerValue("ListApplicationEcu.Code");
			listApplicationEcuResponse.Message = _ctx.StringValue("ListApplicationEcu.Message");
			listApplicationEcuResponse.RequestId = _ctx.StringValue("ListApplicationEcu.RequestId");

			List<ListApplicationEcuResponse.ListApplicationEcu_EcuEntity> listApplicationEcuResponse_ecuInfoList = new List<ListApplicationEcuResponse.ListApplicationEcu_EcuEntity>();
			for (int i = 0; i < _ctx.Length("ListApplicationEcu.EcuInfoList.Length"); i++) {
				ListApplicationEcuResponse.ListApplicationEcu_EcuEntity ecuEntity = new ListApplicationEcuResponse.ListApplicationEcu_EcuEntity();
				ecuEntity.EcuId = _ctx.StringValue("ListApplicationEcu.EcuInfoList["+ i +"].EcuId");
				ecuEntity.Online = _ctx.BooleanValue("ListApplicationEcu.EcuInfoList["+ i +"].Online");
				ecuEntity.DockerEnv = _ctx.BooleanValue("ListApplicationEcu.EcuInfoList["+ i +"].DockerEnv");
				ecuEntity.CreateTime = _ctx.LongValue("ListApplicationEcu.EcuInfoList["+ i +"].CreateTime");
				ecuEntity.UpdateTime = _ctx.LongValue("ListApplicationEcu.EcuInfoList["+ i +"].UpdateTime");
				ecuEntity.IpAddr = _ctx.StringValue("ListApplicationEcu.EcuInfoList["+ i +"].IpAddr");
				ecuEntity.HeartbeatTime = _ctx.LongValue("ListApplicationEcu.EcuInfoList["+ i +"].HeartbeatTime");
				ecuEntity.UserId = _ctx.StringValue("ListApplicationEcu.EcuInfoList["+ i +"].UserId");
				ecuEntity.Name = _ctx.StringValue("ListApplicationEcu.EcuInfoList["+ i +"].Name");
				ecuEntity.ZoneId = _ctx.StringValue("ListApplicationEcu.EcuInfoList["+ i +"].ZoneId");
				ecuEntity.RegionId = _ctx.StringValue("ListApplicationEcu.EcuInfoList["+ i +"].RegionId");
				ecuEntity.InstanceId = _ctx.StringValue("ListApplicationEcu.EcuInfoList["+ i +"].InstanceId");
				ecuEntity.VpcId = _ctx.StringValue("ListApplicationEcu.EcuInfoList["+ i +"].VpcId");
				ecuEntity.AvailableCpu = _ctx.IntegerValue("ListApplicationEcu.EcuInfoList["+ i +"].AvailableCpu");
				ecuEntity.AvailableMem = _ctx.IntegerValue("ListApplicationEcu.EcuInfoList["+ i +"].AvailableMem");
				ecuEntity.Cpu = _ctx.IntegerValue("ListApplicationEcu.EcuInfoList["+ i +"].Cpu");
				ecuEntity.Mem = _ctx.IntegerValue("ListApplicationEcu.EcuInfoList["+ i +"].Mem");
				ecuEntity.AppId = _ctx.StringValue("ListApplicationEcu.EcuInfoList["+ i +"].AppId");

				listApplicationEcuResponse_ecuInfoList.Add(ecuEntity);
			}
			listApplicationEcuResponse.EcuInfoList = listApplicationEcuResponse_ecuInfoList;
        
			return listApplicationEcuResponse;
        }
    }
}
