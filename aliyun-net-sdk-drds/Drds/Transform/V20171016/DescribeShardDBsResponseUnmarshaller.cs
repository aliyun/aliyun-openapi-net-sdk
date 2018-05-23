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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Drds.Model.V20171016;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Drds.Transform.V20171016
{
    public class DescribeShardDBsResponseUnmarshaller
    {
        public static DescribeShardDBsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeShardDBsResponse describeShardDBsResponse = new DescribeShardDBsResponse();

			describeShardDBsResponse.HttpResponse = context.HttpResponse;
			describeShardDBsResponse.RequestId = context.StringValue("DescribeShardDBs.RequestId");
			describeShardDBsResponse.Success = context.BooleanValue("DescribeShardDBs.Success");

			List<DescribeShardDBsResponse.DescribeShardDBs_DbIntancePair> describeShardDBsResponse_data = new List<DescribeShardDBsResponse.DescribeShardDBs_DbIntancePair>();
			for (int i = 0; i < context.Length("DescribeShardDBs.Data.Length"); i++) {
				DescribeShardDBsResponse.DescribeShardDBs_DbIntancePair dbIntancePair = new DescribeShardDBsResponse.DescribeShardDBs_DbIntancePair();
				dbIntancePair.SubDbName = context.StringValue("DescribeShardDBs.Data["+ i +"].SubDbName");
				dbIntancePair.InstanceName = context.StringValue("DescribeShardDBs.Data["+ i +"].InstanceName");

				describeShardDBsResponse_data.Add(dbIntancePair);
			}
			describeShardDBsResponse.Data = describeShardDBsResponse_data;
        
			return describeShardDBsResponse;
        }
    }
}