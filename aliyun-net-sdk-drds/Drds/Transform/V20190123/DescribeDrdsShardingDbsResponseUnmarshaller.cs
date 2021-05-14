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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeDrdsShardingDbsResponseUnmarshaller
    {
        public static DescribeDrdsShardingDbsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDrdsShardingDbsResponse describeDrdsShardingDbsResponse = new DescribeDrdsShardingDbsResponse();

			describeDrdsShardingDbsResponse.HttpResponse = _ctx.HttpResponse;
			describeDrdsShardingDbsResponse.RequestId = _ctx.StringValue("DescribeDrdsShardingDbs.RequestId");
			describeDrdsShardingDbsResponse.Success = _ctx.BooleanValue("DescribeDrdsShardingDbs.Success");

			List<DescribeDrdsShardingDbsResponse.DescribeDrdsShardingDbs_ShardingDb> describeDrdsShardingDbsResponse_shardingDbs = new List<DescribeDrdsShardingDbsResponse.DescribeDrdsShardingDbs_ShardingDb>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsShardingDbs.ShardingDbs.Length"); i++) {
				DescribeDrdsShardingDbsResponse.DescribeDrdsShardingDbs_ShardingDb shardingDb = new DescribeDrdsShardingDbsResponse.DescribeDrdsShardingDbs_ShardingDb();
				shardingDb.ShardingDbName = _ctx.StringValue("DescribeDrdsShardingDbs.ShardingDbs["+ i +"].ShardingDbName");
				shardingDb.DbInstanceId = _ctx.StringValue("DescribeDrdsShardingDbs.ShardingDbs["+ i +"].DbInstanceId");
				shardingDb.GroupName = _ctx.StringValue("DescribeDrdsShardingDbs.ShardingDbs["+ i +"].GroupName");
				shardingDb.DbStatus = _ctx.StringValue("DescribeDrdsShardingDbs.ShardingDbs["+ i +"].DbStatus");
				shardingDb.DbType = _ctx.StringValue("DescribeDrdsShardingDbs.ShardingDbs["+ i +"].DbType");
				shardingDb.MinPoolSize = _ctx.IntegerValue("DescribeDrdsShardingDbs.ShardingDbs["+ i +"].MinPoolSize");
				shardingDb.MaxPoolSize = _ctx.IntegerValue("DescribeDrdsShardingDbs.ShardingDbs["+ i +"].MaxPoolSize");
				shardingDb.IdleTimeOut = _ctx.IntegerValue("DescribeDrdsShardingDbs.ShardingDbs["+ i +"].IdleTimeOut");
				shardingDb.BlockingTimeout = _ctx.IntegerValue("DescribeDrdsShardingDbs.ShardingDbs["+ i +"].BlockingTimeout");
				shardingDb.ConnectionProperties = _ctx.StringValue("DescribeDrdsShardingDbs.ShardingDbs["+ i +"].ConnectionProperties");
				shardingDb.PreparedStatementCacheSize = _ctx.IntegerValue("DescribeDrdsShardingDbs.ShardingDbs["+ i +"].PreparedStatementCacheSize");
				shardingDb.UserName = _ctx.StringValue("DescribeDrdsShardingDbs.ShardingDbs["+ i +"].UserName");
				shardingDb.ConnectUrl = _ctx.StringValue("DescribeDrdsShardingDbs.ShardingDbs["+ i +"].ConnectUrl");

				describeDrdsShardingDbsResponse_shardingDbs.Add(shardingDb);
			}
			describeDrdsShardingDbsResponse.ShardingDbs = describeDrdsShardingDbsResponse_shardingDbs;
        
			return describeDrdsShardingDbsResponse;
        }
    }
}
