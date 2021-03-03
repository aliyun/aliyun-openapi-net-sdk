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
    public class DescribeUpgradeMajorVersionTasksResponseUnmarshaller
    {
        public static DescribeUpgradeMajorVersionTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUpgradeMajorVersionTasksResponse describeUpgradeMajorVersionTasksResponse = new DescribeUpgradeMajorVersionTasksResponse();

			describeUpgradeMajorVersionTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeUpgradeMajorVersionTasksResponse.RequestId = _ctx.StringValue("DescribeUpgradeMajorVersionTasks.RequestId");
			describeUpgradeMajorVersionTasksResponse.TotalRecordCount = _ctx.IntegerValue("DescribeUpgradeMajorVersionTasks.TotalRecordCount");
			describeUpgradeMajorVersionTasksResponse.PageNumber = _ctx.IntegerValue("DescribeUpgradeMajorVersionTasks.PageNumber");
			describeUpgradeMajorVersionTasksResponse.PageRecordCount = _ctx.IntegerValue("DescribeUpgradeMajorVersionTasks.PageRecordCount");

			List<DescribeUpgradeMajorVersionTasksResponse.DescribeUpgradeMajorVersionTasks_Tasks> describeUpgradeMajorVersionTasksResponse_items = new List<DescribeUpgradeMajorVersionTasksResponse.DescribeUpgradeMajorVersionTasks_Tasks>();
			for (int i = 0; i < _ctx.Length("DescribeUpgradeMajorVersionTasks.Items.Length"); i++) {
				DescribeUpgradeMajorVersionTasksResponse.DescribeUpgradeMajorVersionTasks_Tasks tasks = new DescribeUpgradeMajorVersionTasksResponse.DescribeUpgradeMajorVersionTasks_Tasks();
				tasks.TaskId = _ctx.IntegerValue("DescribeUpgradeMajorVersionTasks.Items["+ i +"].TaskId");
				tasks.SourceInsName = _ctx.IntegerValue("DescribeUpgradeMajorVersionTasks.Items["+ i +"].SourceInsName");
				tasks.SourceMajorVersion = _ctx.StringValue("DescribeUpgradeMajorVersionTasks.Items["+ i +"].SourceMajorVersion");
				tasks.TargetInsName = _ctx.IntegerValue("DescribeUpgradeMajorVersionTasks.Items["+ i +"].TargetInsName");
				tasks.TargetMajorVersion = _ctx.StringValue("DescribeUpgradeMajorVersionTasks.Items["+ i +"].TargetMajorVersion");
				tasks.UpgradeMode = _ctx.StringValue("DescribeUpgradeMajorVersionTasks.Items["+ i +"].UpgradeMode");
				tasks.CollectStatMode = _ctx.StringValue("DescribeUpgradeMajorVersionTasks.Items["+ i +"].CollectStatMode");
				tasks.StartTime = _ctx.StringValue("DescribeUpgradeMajorVersionTasks.Items["+ i +"].StartTime");
				tasks.EndTime = _ctx.StringValue("DescribeUpgradeMajorVersionTasks.Items["+ i +"].EndTime");
				tasks.SwitchTime = _ctx.StringValue("DescribeUpgradeMajorVersionTasks.Items["+ i +"].SwitchTime");
				tasks.Result = _ctx.StringValue("DescribeUpgradeMajorVersionTasks.Items["+ i +"].Result");
				tasks.Detail = _ctx.StringValue("DescribeUpgradeMajorVersionTasks.Items["+ i +"].Detail");

				describeUpgradeMajorVersionTasksResponse_items.Add(tasks);
			}
			describeUpgradeMajorVersionTasksResponse.Items = describeUpgradeMajorVersionTasksResponse_items;
        
			return describeUpgradeMajorVersionTasksResponse;
        }
    }
}
