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
    public class DescribeCloudMigrationPrecheckResultResponseUnmarshaller
    {
        public static DescribeCloudMigrationPrecheckResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCloudMigrationPrecheckResultResponse describeCloudMigrationPrecheckResultResponse = new DescribeCloudMigrationPrecheckResultResponse();

			describeCloudMigrationPrecheckResultResponse.HttpResponse = _ctx.HttpResponse;
			describeCloudMigrationPrecheckResultResponse.TotalSize = _ctx.IntegerValue("DescribeCloudMigrationPrecheckResult.TotalSize");
			describeCloudMigrationPrecheckResultResponse.RequestId = _ctx.StringValue("DescribeCloudMigrationPrecheckResult.RequestId");
			describeCloudMigrationPrecheckResultResponse.PageNumber = _ctx.LongValue("DescribeCloudMigrationPrecheckResult.PageNumber");
			describeCloudMigrationPrecheckResultResponse.PageSize = _ctx.LongValue("DescribeCloudMigrationPrecheckResult.PageSize");

			List<DescribeCloudMigrationPrecheckResultResponse.DescribeCloudMigrationPrecheckResult_MigrateCloudTaskList> describeCloudMigrationPrecheckResultResponse_items = new List<DescribeCloudMigrationPrecheckResultResponse.DescribeCloudMigrationPrecheckResult_MigrateCloudTaskList>();
			for (int i = 0; i < _ctx.Length("DescribeCloudMigrationPrecheckResult.Items.Length"); i++) {
				DescribeCloudMigrationPrecheckResultResponse.DescribeCloudMigrationPrecheckResult_MigrateCloudTaskList migrateCloudTaskList = new DescribeCloudMigrationPrecheckResultResponse.DescribeCloudMigrationPrecheckResult_MigrateCloudTaskList();
				migrateCloudTaskList.GmtCreated = _ctx.StringValue("DescribeCloudMigrationPrecheckResult.Items["+ i +"].GmtCreated");
				migrateCloudTaskList.GmtModified = _ctx.StringValue("DescribeCloudMigrationPrecheckResult.Items["+ i +"].GmtModified");
				migrateCloudTaskList.TaskId = _ctx.LongValue("DescribeCloudMigrationPrecheckResult.Items["+ i +"].TaskId");
				migrateCloudTaskList.TaskName = _ctx.StringValue("DescribeCloudMigrationPrecheckResult.Items["+ i +"].TaskName");
				migrateCloudTaskList.Status = _ctx.StringValue("DescribeCloudMigrationPrecheckResult.Items["+ i +"].Status");
				migrateCloudTaskList.SourceCategory = _ctx.StringValue("DescribeCloudMigrationPrecheckResult.Items["+ i +"].SourceCategory");
				migrateCloudTaskList.SourceIpAddress = _ctx.StringValue("DescribeCloudMigrationPrecheckResult.Items["+ i +"].SourceIpAddress");
				migrateCloudTaskList.SourcePort = _ctx.LongValue("DescribeCloudMigrationPrecheckResult.Items["+ i +"].SourcePort");
				migrateCloudTaskList.SourceAccount = _ctx.StringValue("DescribeCloudMigrationPrecheckResult.Items["+ i +"].SourceAccount");
				migrateCloudTaskList.SourcePassword = _ctx.StringValue("DescribeCloudMigrationPrecheckResult.Items["+ i +"].SourcePassword");
				migrateCloudTaskList.TargetEip = _ctx.StringValue("DescribeCloudMigrationPrecheckResult.Items["+ i +"].TargetEip");
				migrateCloudTaskList.TargetInstanceName = _ctx.StringValue("DescribeCloudMigrationPrecheckResult.Items["+ i +"].TargetInstanceName");
				migrateCloudTaskList.Detail = _ctx.StringValue("DescribeCloudMigrationPrecheckResult.Items["+ i +"].Detail");

				describeCloudMigrationPrecheckResultResponse_items.Add(migrateCloudTaskList);
			}
			describeCloudMigrationPrecheckResultResponse.Items = describeCloudMigrationPrecheckResultResponse_items;
        
			return describeCloudMigrationPrecheckResultResponse;
        }
    }
}
