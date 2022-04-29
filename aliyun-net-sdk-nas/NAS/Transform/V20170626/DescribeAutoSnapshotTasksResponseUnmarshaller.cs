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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeAutoSnapshotTasksResponseUnmarshaller
    {
        public static DescribeAutoSnapshotTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAutoSnapshotTasksResponse describeAutoSnapshotTasksResponse = new DescribeAutoSnapshotTasksResponse();

			describeAutoSnapshotTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeAutoSnapshotTasksResponse.TotalCount = _ctx.IntegerValue("DescribeAutoSnapshotTasks.TotalCount");
			describeAutoSnapshotTasksResponse.RequestId = _ctx.StringValue("DescribeAutoSnapshotTasks.RequestId");
			describeAutoSnapshotTasksResponse.PageSize = _ctx.IntegerValue("DescribeAutoSnapshotTasks.PageSize");
			describeAutoSnapshotTasksResponse.PageNumber = _ctx.IntegerValue("DescribeAutoSnapshotTasks.PageNumber");

			List<DescribeAutoSnapshotTasksResponse.DescribeAutoSnapshotTasks_AutoSnapshotTask> describeAutoSnapshotTasksResponse_autoSnapshotTasks = new List<DescribeAutoSnapshotTasksResponse.DescribeAutoSnapshotTasks_AutoSnapshotTask>();
			for (int i = 0; i < _ctx.Length("DescribeAutoSnapshotTasks.AutoSnapshotTasks.Length"); i++) {
				DescribeAutoSnapshotTasksResponse.DescribeAutoSnapshotTasks_AutoSnapshotTask autoSnapshotTask = new DescribeAutoSnapshotTasksResponse.DescribeAutoSnapshotTasks_AutoSnapshotTask();
				autoSnapshotTask.SourceFileSystemId = _ctx.StringValue("DescribeAutoSnapshotTasks.AutoSnapshotTasks["+ i +"].SourceFileSystemId");
				autoSnapshotTask.AutoSnapshotPolicyId = _ctx.StringValue("DescribeAutoSnapshotTasks.AutoSnapshotTasks["+ i +"].AutoSnapshotPolicyId");

				describeAutoSnapshotTasksResponse_autoSnapshotTasks.Add(autoSnapshotTask);
			}
			describeAutoSnapshotTasksResponse.AutoSnapshotTasks = describeAutoSnapshotTasksResponse_autoSnapshotTasks;
        
			return describeAutoSnapshotTasksResponse;
        }
    }
}
