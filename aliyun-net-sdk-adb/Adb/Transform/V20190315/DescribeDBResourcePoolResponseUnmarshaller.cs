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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeDBResourcePoolResponseUnmarshaller
    {
        public static DescribeDBResourcePoolResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBResourcePoolResponse describeDBResourcePoolResponse = new DescribeDBResourcePoolResponse();

			describeDBResourcePoolResponse.HttpResponse = _ctx.HttpResponse;
			describeDBResourcePoolResponse.RequestId = _ctx.StringValue("DescribeDBResourcePool.RequestId");

			List<DescribeDBResourcePoolResponse.DescribeDBResourcePool_PoolInfo> describeDBResourcePoolResponse_poolsInfo = new List<DescribeDBResourcePoolResponse.DescribeDBResourcePool_PoolInfo>();
			for (int i = 0; i < _ctx.Length("DescribeDBResourcePool.PoolsInfo.Length"); i++) {
				DescribeDBResourcePoolResponse.DescribeDBResourcePool_PoolInfo poolInfo = new DescribeDBResourcePoolResponse.DescribeDBResourcePool_PoolInfo();
				poolInfo.PoolName = _ctx.StringValue("DescribeDBResourcePool.PoolsInfo["+ i +"].PoolName");
				poolInfo.QueryType = _ctx.StringValue("DescribeDBResourcePool.PoolsInfo["+ i +"].QueryType");
				poolInfo.NodeNum = _ctx.IntegerValue("DescribeDBResourcePool.PoolsInfo["+ i +"].NodeNum");
				poolInfo.PoolUsers = _ctx.StringValue("DescribeDBResourcePool.PoolsInfo["+ i +"].PoolUsers");
				poolInfo.CreateTime = _ctx.StringValue("DescribeDBResourcePool.PoolsInfo["+ i +"].CreateTime");
				poolInfo.UpdateTime = _ctx.StringValue("DescribeDBResourcePool.PoolsInfo["+ i +"].UpdateTime");

				describeDBResourcePoolResponse_poolsInfo.Add(poolInfo);
			}
			describeDBResourcePoolResponse.PoolsInfo = describeDBResourcePoolResponse_poolsInfo;
        
			return describeDBResourcePoolResponse;
        }
    }
}
