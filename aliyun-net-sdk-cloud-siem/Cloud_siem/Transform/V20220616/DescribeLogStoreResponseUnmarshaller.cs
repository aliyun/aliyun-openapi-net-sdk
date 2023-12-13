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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeLogStoreResponseUnmarshaller
    {
        public static DescribeLogStoreResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLogStoreResponse describeLogStoreResponse = new DescribeLogStoreResponse();

			describeLogStoreResponse.HttpResponse = _ctx.HttpResponse;
			describeLogStoreResponse.RequestId = _ctx.StringValue("DescribeLogStore.RequestId");

			DescribeLogStoreResponse.DescribeLogStore_Data data = new DescribeLogStoreResponse.DescribeLogStore_Data();
			data.LogStoreName = _ctx.StringValue("DescribeLogStore.Data.LogStoreName");
			data.Ttl = _ctx.IntegerValue("DescribeLogStore.Data.Ttl");
			data.ShardCount = _ctx.IntegerValue("DescribeLogStore.Data.ShardCount");
			data.EnableTracking = _ctx.BooleanValue("DescribeLogStore.Data.EnableTracking");
			data.AutoSplit = _ctx.BooleanValue("DescribeLogStore.Data.AutoSplit");
			data.MaxSplitShard = _ctx.IntegerValue("DescribeLogStore.Data.MaxSplitShard");
			data.AppendMeta = _ctx.BooleanValue("DescribeLogStore.Data.AppendMeta");
			describeLogStoreResponse.Data = data;
        
			return describeLogStoreResponse;
        }
    }
}
