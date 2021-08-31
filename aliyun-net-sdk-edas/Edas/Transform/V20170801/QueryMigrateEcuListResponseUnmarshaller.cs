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
    public class QueryMigrateEcuListResponseUnmarshaller
    {
        public static QueryMigrateEcuListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryMigrateEcuListResponse queryMigrateEcuListResponse = new QueryMigrateEcuListResponse();

			queryMigrateEcuListResponse.HttpResponse = _ctx.HttpResponse;
			queryMigrateEcuListResponse.Code = _ctx.IntegerValue("QueryMigrateEcuList.Code");
			queryMigrateEcuListResponse.Message = _ctx.StringValue("QueryMigrateEcuList.Message");
			queryMigrateEcuListResponse.RequestId = _ctx.StringValue("QueryMigrateEcuList.RequestId");

			List<QueryMigrateEcuListResponse.QueryMigrateEcuList_EcuEntity> queryMigrateEcuListResponse_ecuEntityList = new List<QueryMigrateEcuListResponse.QueryMigrateEcuList_EcuEntity>();
			for (int i = 0; i < _ctx.Length("QueryMigrateEcuList.EcuEntityList.Length"); i++) {
				QueryMigrateEcuListResponse.QueryMigrateEcuList_EcuEntity ecuEntity = new QueryMigrateEcuListResponse.QueryMigrateEcuList_EcuEntity();
				ecuEntity.EcuId = _ctx.StringValue("QueryMigrateEcuList.EcuEntityList["+ i +"].EcuId");
				ecuEntity.Online = _ctx.BooleanValue("QueryMigrateEcuList.EcuEntityList["+ i +"].Online");
				ecuEntity.DockerEnv = _ctx.BooleanValue("QueryMigrateEcuList.EcuEntityList["+ i +"].DockerEnv");
				ecuEntity.CreateTime = _ctx.LongValue("QueryMigrateEcuList.EcuEntityList["+ i +"].CreateTime");
				ecuEntity.UpdateTime = _ctx.LongValue("QueryMigrateEcuList.EcuEntityList["+ i +"].UpdateTime");
				ecuEntity.IpAddr = _ctx.StringValue("QueryMigrateEcuList.EcuEntityList["+ i +"].IpAddr");
				ecuEntity.HeartbeatTime = _ctx.LongValue("QueryMigrateEcuList.EcuEntityList["+ i +"].HeartbeatTime");
				ecuEntity.UserId = _ctx.StringValue("QueryMigrateEcuList.EcuEntityList["+ i +"].UserId");
				ecuEntity.Name = _ctx.StringValue("QueryMigrateEcuList.EcuEntityList["+ i +"].Name");
				ecuEntity.ZoneId = _ctx.StringValue("QueryMigrateEcuList.EcuEntityList["+ i +"].ZoneId");
				ecuEntity.RegionId = _ctx.StringValue("QueryMigrateEcuList.EcuEntityList["+ i +"].RegionId");
				ecuEntity.InstanceId = _ctx.StringValue("QueryMigrateEcuList.EcuEntityList["+ i +"].InstanceId");
				ecuEntity.VpcId = _ctx.StringValue("QueryMigrateEcuList.EcuEntityList["+ i +"].VpcId");
				ecuEntity.AvailableCpu = _ctx.IntegerValue("QueryMigrateEcuList.EcuEntityList["+ i +"].AvailableCpu");
				ecuEntity.AvailableMem = _ctx.IntegerValue("QueryMigrateEcuList.EcuEntityList["+ i +"].AvailableMem");
				ecuEntity.Cpu = _ctx.IntegerValue("QueryMigrateEcuList.EcuEntityList["+ i +"].Cpu");
				ecuEntity.Mem = _ctx.IntegerValue("QueryMigrateEcuList.EcuEntityList["+ i +"].Mem");

				queryMigrateEcuListResponse_ecuEntityList.Add(ecuEntity);
			}
			queryMigrateEcuListResponse.EcuEntityList = queryMigrateEcuListResponse_ecuEntityList;
        
			return queryMigrateEcuListResponse;
        }
    }
}
