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
    public class DescribeCloudMigrationResultResponseUnmarshaller
    {
        public static DescribeCloudMigrationResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCloudMigrationResultResponse describeCloudMigrationResultResponse = new DescribeCloudMigrationResultResponse();

			describeCloudMigrationResultResponse.HttpResponse = _ctx.HttpResponse;
			describeCloudMigrationResultResponse.TotalSize = _ctx.IntegerValue("DescribeCloudMigrationResult.TotalSize");
			describeCloudMigrationResultResponse.RequestId = _ctx.StringValue("DescribeCloudMigrationResult.RequestId");
			describeCloudMigrationResultResponse.PageNumber = _ctx.LongValue("DescribeCloudMigrationResult.PageNumber");
			describeCloudMigrationResultResponse.PageSize = _ctx.LongValue("DescribeCloudMigrationResult.PageSize");

			List<DescribeCloudMigrationResultResponse.DescribeCloudMigrationResult_Tasks> describeCloudMigrationResultResponse_items = new List<DescribeCloudMigrationResultResponse.DescribeCloudMigrationResult_Tasks>();
			for (int i = 0; i < _ctx.Length("DescribeCloudMigrationResult.Items.Length"); i++) {
				DescribeCloudMigrationResultResponse.DescribeCloudMigrationResult_Tasks tasks = new DescribeCloudMigrationResultResponse.DescribeCloudMigrationResult_Tasks();
				tasks.GmtCreated = _ctx.StringValue("DescribeCloudMigrationResult.Items["+ i +"].GmtCreated");
				tasks.GmtModified = _ctx.StringValue("DescribeCloudMigrationResult.Items["+ i +"].GmtModified");
				tasks.TaskId = _ctx.LongValue("DescribeCloudMigrationResult.Items["+ i +"].TaskId");
				tasks.TaskName = _ctx.StringValue("DescribeCloudMigrationResult.Items["+ i +"].TaskName");
				tasks.Status = _ctx.StringValue("DescribeCloudMigrationResult.Items["+ i +"].Status");
				tasks.MigrateStage = _ctx.StringValue("DescribeCloudMigrationResult.Items["+ i +"].MigrateStage");
				tasks.SourceCategory = _ctx.StringValue("DescribeCloudMigrationResult.Items["+ i +"].SourceCategory");
				tasks.SourceIpAddress = _ctx.StringValue("DescribeCloudMigrationResult.Items["+ i +"].SourceIpAddress");
				tasks.SourcePort = _ctx.LongValue("DescribeCloudMigrationResult.Items["+ i +"].SourcePort");
				tasks.SourceAccount = _ctx.StringValue("DescribeCloudMigrationResult.Items["+ i +"].SourceAccount");
				tasks.SourcePassword = _ctx.StringValue("DescribeCloudMigrationResult.Items["+ i +"].SourcePassword");
				tasks.TargetEip = _ctx.StringValue("DescribeCloudMigrationResult.Items["+ i +"].TargetEip");
				tasks.TargetInstanceName = _ctx.StringValue("DescribeCloudMigrationResult.Items["+ i +"].TargetInstanceName");
				tasks.ReplicationState = _ctx.StringValue("DescribeCloudMigrationResult.Items["+ i +"].ReplicationState");
				tasks.ReplicationInfo = _ctx.StringValue("DescribeCloudMigrationResult.Items["+ i +"].ReplicationInfo");
				tasks.Detail = _ctx.StringValue("DescribeCloudMigrationResult.Items["+ i +"].Detail");
				tasks.SwitchTime = _ctx.StringValue("DescribeCloudMigrationResult.Items["+ i +"].SwitchTime");

				describeCloudMigrationResultResponse_items.Add(tasks);
			}
			describeCloudMigrationResultResponse.Items = describeCloudMigrationResultResponse_items;
        
			return describeCloudMigrationResultResponse;
        }
    }
}
