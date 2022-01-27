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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeResourceUsageResponseUnmarshaller
    {
        public static DescribeResourceUsageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeResourceUsageResponse describeResourceUsageResponse = new DescribeResourceUsageResponse();

			describeResourceUsageResponse.HttpResponse = _ctx.HttpResponse;
			describeResourceUsageResponse.RequestId = _ctx.StringValue("DescribeResourceUsage.RequestId");
			describeResourceUsageResponse.DBInstanceId = _ctx.StringValue("DescribeResourceUsage.DBInstanceId");
			describeResourceUsageResponse.Engine = _ctx.StringValue("DescribeResourceUsage.Engine");
			describeResourceUsageResponse.DiskUsed = _ctx.LongValue("DescribeResourceUsage.DiskUsed");
			describeResourceUsageResponse.DataSize = _ctx.LongValue("DescribeResourceUsage.DataSize");
			describeResourceUsageResponse.LogSize = _ctx.LongValue("DescribeResourceUsage.LogSize");
			describeResourceUsageResponse.BackupSize = _ctx.LongValue("DescribeResourceUsage.BackupSize");
			describeResourceUsageResponse.BackupOssDataSize = _ctx.LongValue("DescribeResourceUsage.BackupOssDataSize");
			describeResourceUsageResponse.BackupOssLogSize = _ctx.LongValue("DescribeResourceUsage.BackupOssLogSize");
			describeResourceUsageResponse.SQLSize = _ctx.LongValue("DescribeResourceUsage.SQLSize");
			describeResourceUsageResponse.ColdBackupSize = _ctx.LongValue("DescribeResourceUsage.ColdBackupSize");
			describeResourceUsageResponse.BackupDataSize = _ctx.LongValue("DescribeResourceUsage.BackupDataSize");
			describeResourceUsageResponse.BackupLogSize = _ctx.LongValue("DescribeResourceUsage.BackupLogSize");
			describeResourceUsageResponse.PaidBackupSize = _ctx.LongValue("DescribeResourceUsage.PaidBackupSize");
			describeResourceUsageResponse.ArchiveBackupSize = _ctx.LongValue("DescribeResourceUsage.ArchiveBackupSize");
        
			return describeResourceUsageResponse;
        }
    }
}
