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
using Aliyun.Acs.hitsdb.Model.V20200615;

namespace Aliyun.Acs.hitsdb.Transform.V20200615
{
    public class GetLindormInstanceResponseUnmarshaller
    {
        public static GetLindormInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetLindormInstanceResponse getLindormInstanceResponse = new GetLindormInstanceResponse();

			getLindormInstanceResponse.HttpResponse = _ctx.HttpResponse;
			getLindormInstanceResponse.VpcId = _ctx.StringValue("GetLindormInstance.VpcId");
			getLindormInstanceResponse.VswitchId = _ctx.StringValue("GetLindormInstance.VswitchId");
			getLindormInstanceResponse.CreateTime = _ctx.StringValue("GetLindormInstance.CreateTime");
			getLindormInstanceResponse.PayType = _ctx.StringValue("GetLindormInstance.PayType");
			getLindormInstanceResponse.NetworkType = _ctx.StringValue("GetLindormInstance.NetworkType");
			getLindormInstanceResponse.ServiceType = _ctx.StringValue("GetLindormInstance.ServiceType");
			getLindormInstanceResponse.EnableKms = _ctx.BooleanValue("GetLindormInstance.EnableKms");
			getLindormInstanceResponse.DiskUsage = _ctx.StringValue("GetLindormInstance.DiskUsage");
			getLindormInstanceResponse.DiskCategory = _ctx.StringValue("GetLindormInstance.DiskCategory");
			getLindormInstanceResponse.RequestId = _ctx.StringValue("GetLindormInstance.RequestId");
			getLindormInstanceResponse.ColdStorage = _ctx.IntegerValue("GetLindormInstance.ColdStorage");
			getLindormInstanceResponse.ExpiredMilliseconds = _ctx.LongValue("GetLindormInstance.ExpiredMilliseconds");
			getLindormInstanceResponse.EngineType = _ctx.IntegerValue("GetLindormInstance.EngineType");
			getLindormInstanceResponse.ExpireTime = _ctx.StringValue("GetLindormInstance.ExpireTime");
			getLindormInstanceResponse.AutoRenew = _ctx.BooleanValue("GetLindormInstance.AutoRenew");
			getLindormInstanceResponse.DeletionProtection = _ctx.StringValue("GetLindormInstance.DeletionProtection");
			getLindormInstanceResponse.InstanceStorage = _ctx.StringValue("GetLindormInstance.InstanceStorage");
			getLindormInstanceResponse.AliUid = _ctx.LongValue("GetLindormInstance.AliUid");
			getLindormInstanceResponse.InstanceId = _ctx.StringValue("GetLindormInstance.InstanceId");
			getLindormInstanceResponse.RegionId = _ctx.StringValue("GetLindormInstance.RegionId");
			getLindormInstanceResponse.EnableFS = _ctx.BooleanValue("GetLindormInstance.EnableFS");
			getLindormInstanceResponse.CreateMilliseconds = _ctx.LongValue("GetLindormInstance.CreateMilliseconds");
			getLindormInstanceResponse.InstanceAlias = _ctx.StringValue("GetLindormInstance.InstanceAlias");
			getLindormInstanceResponse.EnableBDS = _ctx.BooleanValue("GetLindormInstance.EnableBDS");
			getLindormInstanceResponse.EnablePhoenix = _ctx.BooleanValue("GetLindormInstance.EnablePhoenix");
			getLindormInstanceResponse.DiskThreshold = _ctx.StringValue("GetLindormInstance.DiskThreshold");
			getLindormInstanceResponse.ZoneId = _ctx.StringValue("GetLindormInstance.ZoneId");
			getLindormInstanceResponse.InstanceStatus = _ctx.StringValue("GetLindormInstance.InstanceStatus");
			getLindormInstanceResponse.EnableCompute = _ctx.BooleanValue("GetLindormInstance.EnableCompute");
			getLindormInstanceResponse.EnableSSL = _ctx.BooleanValue("GetLindormInstance.EnableSSL");
			getLindormInstanceResponse.EnableCdc = _ctx.BooleanValue("GetLindormInstance.EnableCdc");

			List<GetLindormInstanceResponse.GetLindormInstance_Engine> getLindormInstanceResponse_engineList = new List<GetLindormInstanceResponse.GetLindormInstance_Engine>();
			for (int i = 0; i < _ctx.Length("GetLindormInstance.EngineList.Length"); i++) {
				GetLindormInstanceResponse.GetLindormInstance_Engine engine = new GetLindormInstanceResponse.GetLindormInstance_Engine();
				engine.Version = _ctx.StringValue("GetLindormInstance.EngineList["+ i +"].Version");
				engine.CpuCount = _ctx.StringValue("GetLindormInstance.EngineList["+ i +"].CpuCount");
				engine.CoreCount = _ctx.StringValue("GetLindormInstance.EngineList["+ i +"].CoreCount");
				engine.Engine = _ctx.StringValue("GetLindormInstance.EngineList["+ i +"].Engine");
				engine.MemorySize = _ctx.StringValue("GetLindormInstance.EngineList["+ i +"].MemorySize");
				engine.IsLastVersion = _ctx.BooleanValue("GetLindormInstance.EngineList["+ i +"].IsLastVersion");
				engine.LatestVersion = _ctx.StringValue("GetLindormInstance.EngineList["+ i +"].LatestVersion");

				getLindormInstanceResponse_engineList.Add(engine);
			}
			getLindormInstanceResponse.EngineList = getLindormInstanceResponse_engineList;
        
			return getLindormInstanceResponse;
        }
    }
}
