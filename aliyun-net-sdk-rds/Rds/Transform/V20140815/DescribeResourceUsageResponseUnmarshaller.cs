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
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeResourceUsageResponseUnmarshaller
    {
        public static DescribeResourceUsageResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeResourceUsageResponse describeResourceUsageResponse = new DescribeResourceUsageResponse();

			describeResourceUsageResponse.HttpResponse = context.HttpResponse;
			describeResourceUsageResponse.RequestId = context.StringValue("DescribeResourceUsage.RequestId");
			describeResourceUsageResponse.DBInstanceId = context.StringValue("DescribeResourceUsage.DBInstanceId");
			describeResourceUsageResponse.Engine = context.StringValue("DescribeResourceUsage.Engine");
			describeResourceUsageResponse.DiskUsed = context.LongValue("DescribeResourceUsage.DiskUsed");
			describeResourceUsageResponse.DataSize = context.LongValue("DescribeResourceUsage.DataSize");
			describeResourceUsageResponse.LogSize = context.LongValue("DescribeResourceUsage.LogSize");
			describeResourceUsageResponse.BackupSize = context.LongValue("DescribeResourceUsage.BackupSize");
			describeResourceUsageResponse.SQLSize = context.LongValue("DescribeResourceUsage.SQLSize");
			describeResourceUsageResponse.ColdBackupSize = context.LongValue("DescribeResourceUsage.ColdBackupSize");
        
			return describeResourceUsageResponse;
        }
    }
}