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
using Aliyun.Acs.gpdb.Model.V20160503;

namespace Aliyun.Acs.gpdb.Transform.V20160503
{
    public class DescribeResourceUsageResponseUnmarshaller
    {
        public static DescribeResourceUsageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeResourceUsageResponse describeResourceUsageResponse = new DescribeResourceUsageResponse();

			describeResourceUsageResponse.HttpResponse = _ctx.HttpResponse;
			describeResourceUsageResponse.LogSize = _ctx.LongValue("DescribeResourceUsage.LogSize");
			describeResourceUsageResponse.RequestId = _ctx.StringValue("DescribeResourceUsage.RequestId");
			describeResourceUsageResponse.DBInstanceId = _ctx.StringValue("DescribeResourceUsage.DBInstanceId");
			describeResourceUsageResponse.DataSize = _ctx.LongValue("DescribeResourceUsage.DataSize");
			describeResourceUsageResponse.BackupSize = _ctx.LongValue("DescribeResourceUsage.BackupSize");
			describeResourceUsageResponse.DiskUsed = _ctx.LongValue("DescribeResourceUsage.DiskUsed");
			describeResourceUsageResponse.Engine = _ctx.StringValue("DescribeResourceUsage.Engine");
        
			return describeResourceUsageResponse;
        }
    }
}
