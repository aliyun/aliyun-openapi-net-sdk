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
using Aliyun.Acs.Ess.Model.V20140828;

namespace Aliyun.Acs.Ess.Transform.V20140828
{
    public class DescribeScheduledTasksResponseUnmarshaller
    {
        public static DescribeScheduledTasksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScheduledTasksResponse describeScheduledTasksResponse = new DescribeScheduledTasksResponse();

			describeScheduledTasksResponse.HttpResponse = context.HttpResponse;
			describeScheduledTasksResponse.TotalCount = context.IntegerValue("DescribeScheduledTasks.TotalCount");
			describeScheduledTasksResponse.PageNumber = context.IntegerValue("DescribeScheduledTasks.PageNumber");
			describeScheduledTasksResponse.PageSize = context.IntegerValue("DescribeScheduledTasks.PageSize");
			describeScheduledTasksResponse.RequestId = context.StringValue("DescribeScheduledTasks.RequestId");

			List<DescribeScheduledTasksResponse.DescribeScheduledTasks_ScheduledTask> describeScheduledTasksResponse_scheduledTasks = new List<DescribeScheduledTasksResponse.DescribeScheduledTasks_ScheduledTask>();
			for (int i = 0; i < context.Length("DescribeScheduledTasks.ScheduledTasks.Length"); i++) {
				DescribeScheduledTasksResponse.DescribeScheduledTasks_ScheduledTask scheduledTask = new DescribeScheduledTasksResponse.DescribeScheduledTasks_ScheduledTask();
				scheduledTask.ScheduledTaskId = context.StringValue("DescribeScheduledTasks.ScheduledTasks["+ i +"].ScheduledTaskId");
				scheduledTask.ScheduledTaskName = context.StringValue("DescribeScheduledTasks.ScheduledTasks["+ i +"].ScheduledTaskName");
				scheduledTask.Description = context.StringValue("DescribeScheduledTasks.ScheduledTasks["+ i +"].Description");
				scheduledTask.ScheduledAction = context.StringValue("DescribeScheduledTasks.ScheduledTasks["+ i +"].ScheduledAction");
				scheduledTask.RecurrenceEndTime = context.StringValue("DescribeScheduledTasks.ScheduledTasks["+ i +"].RecurrenceEndTime");
				scheduledTask.LaunchTime = context.StringValue("DescribeScheduledTasks.ScheduledTasks["+ i +"].LaunchTime");
				scheduledTask.RecurrenceType = context.StringValue("DescribeScheduledTasks.ScheduledTasks["+ i +"].RecurrenceType");
				scheduledTask.RecurrenceValue = context.StringValue("DescribeScheduledTasks.ScheduledTasks["+ i +"].RecurrenceValue");
				scheduledTask.LaunchExpirationTime = context.IntegerValue("DescribeScheduledTasks.ScheduledTasks["+ i +"].LaunchExpirationTime");
				scheduledTask.TaskEnabled = context.BooleanValue("DescribeScheduledTasks.ScheduledTasks["+ i +"].TaskEnabled");
				scheduledTask.MaxValue = context.IntegerValue("DescribeScheduledTasks.ScheduledTasks["+ i +"].MaxValue");
				scheduledTask.MinValue = context.IntegerValue("DescribeScheduledTasks.ScheduledTasks["+ i +"].MinValue");
				scheduledTask.DesiredCapacity = context.IntegerValue("DescribeScheduledTasks.ScheduledTasks["+ i +"].DesiredCapacity");
				scheduledTask.ScalingGroupId = context.StringValue("DescribeScheduledTasks.ScheduledTasks["+ i +"].ScalingGroupId");

				describeScheduledTasksResponse_scheduledTasks.Add(scheduledTask);
			}
			describeScheduledTasksResponse.ScheduledTasks = describeScheduledTasksResponse_scheduledTasks;
        
			return describeScheduledTasksResponse;
        }
    }
}
