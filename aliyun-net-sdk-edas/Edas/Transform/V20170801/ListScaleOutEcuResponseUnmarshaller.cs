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
    public class ListScaleOutEcuResponseUnmarshaller
    {
        public static ListScaleOutEcuResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListScaleOutEcuResponse listScaleOutEcuResponse = new ListScaleOutEcuResponse();

			listScaleOutEcuResponse.HttpResponse = _ctx.HttpResponse;
			listScaleOutEcuResponse.Code = _ctx.IntegerValue("ListScaleOutEcu.Code");
			listScaleOutEcuResponse.Message = _ctx.StringValue("ListScaleOutEcu.Message");
			listScaleOutEcuResponse.RequestId = _ctx.StringValue("ListScaleOutEcu.RequestId");

			List<ListScaleOutEcuResponse.ListScaleOutEcu_EcuInfo> listScaleOutEcuResponse_ecuInfoList = new List<ListScaleOutEcuResponse.ListScaleOutEcu_EcuInfo>();
			for (int i = 0; i < _ctx.Length("ListScaleOutEcu.EcuInfoList.Length"); i++) {
				ListScaleOutEcuResponse.ListScaleOutEcu_EcuInfo ecuInfo = new ListScaleOutEcuResponse.ListScaleOutEcu_EcuInfo();
				ecuInfo.EcuId = _ctx.StringValue("ListScaleOutEcu.EcuInfoList["+ i +"].EcuId");
				ecuInfo.Online = _ctx.BooleanValue("ListScaleOutEcu.EcuInfoList["+ i +"].Online");
				ecuInfo.DockerEnv = _ctx.BooleanValue("ListScaleOutEcu.EcuInfoList["+ i +"].DockerEnv");
				ecuInfo.CreateTime = _ctx.LongValue("ListScaleOutEcu.EcuInfoList["+ i +"].CreateTime");
				ecuInfo.UpdateTime = _ctx.LongValue("ListScaleOutEcu.EcuInfoList["+ i +"].UpdateTime");
				ecuInfo.IpAddr = _ctx.StringValue("ListScaleOutEcu.EcuInfoList["+ i +"].IpAddr");
				ecuInfo.HeartbeatTime = _ctx.LongValue("ListScaleOutEcu.EcuInfoList["+ i +"].HeartbeatTime");
				ecuInfo.UserId = _ctx.StringValue("ListScaleOutEcu.EcuInfoList["+ i +"].UserId");
				ecuInfo.Name = _ctx.StringValue("ListScaleOutEcu.EcuInfoList["+ i +"].Name");
				ecuInfo.ZoneId = _ctx.StringValue("ListScaleOutEcu.EcuInfoList["+ i +"].ZoneId");
				ecuInfo.RegionId = _ctx.StringValue("ListScaleOutEcu.EcuInfoList["+ i +"].RegionId");
				ecuInfo.InstanceId = _ctx.StringValue("ListScaleOutEcu.EcuInfoList["+ i +"].InstanceId");
				ecuInfo.VpcId = _ctx.StringValue("ListScaleOutEcu.EcuInfoList["+ i +"].VpcId");
				ecuInfo.AvailableCpu = _ctx.IntegerValue("ListScaleOutEcu.EcuInfoList["+ i +"].AvailableCpu");
				ecuInfo.AvailableMem = _ctx.IntegerValue("ListScaleOutEcu.EcuInfoList["+ i +"].AvailableMem");

				listScaleOutEcuResponse_ecuInfoList.Add(ecuInfo);
			}
			listScaleOutEcuResponse.EcuInfoList = listScaleOutEcuResponse_ecuInfoList;
        
			return listScaleOutEcuResponse;
        }
    }
}
