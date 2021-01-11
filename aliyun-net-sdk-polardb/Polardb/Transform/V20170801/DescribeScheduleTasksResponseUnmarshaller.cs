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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeScheduleTasksResponseUnmarshaller
    {
        public static DescribeScheduleTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScheduleTasksResponse describeScheduleTasksResponse = new DescribeScheduleTasksResponse();

			describeScheduleTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeScheduleTasksResponse.Code = _ctx.StringValue("DescribeScheduleTasks.Code");
			describeScheduleTasksResponse.HttpStatusCode = _ctx.IntegerValue("DescribeScheduleTasks.HttpStatusCode");
			describeScheduleTasksResponse.Message = _ctx.StringValue("DescribeScheduleTasks.Message");
			describeScheduleTasksResponse.RequestId = _ctx.StringValue("DescribeScheduleTasks.RequestId");
			describeScheduleTasksResponse.Success = _ctx.BooleanValue("DescribeScheduleTasks.Success");

			List<DescribeScheduleTasksResponse.DescribeScheduleTasks_Items> describeScheduleTasksResponse_data = new List<DescribeScheduleTasksResponse.DescribeScheduleTasks_Items>();
			for (int i = 0; i < _ctx.Length("DescribeScheduleTasks.Data.Length"); i++) {
				DescribeScheduleTasksResponse.DescribeScheduleTasks_Items items = new DescribeScheduleTasksResponse.DescribeScheduleTasks_Items();
				items.Action = _ctx.StringValue("DescribeScheduleTasks.Data["+ i +"].Action");
				items.Args = _ctx.StringValue("DescribeScheduleTasks.Data["+ i +"].Args");
				items.GmtCreate = _ctx.LongValue("DescribeScheduleTasks.Data["+ i +"].GmtCreate");
				items.GmtModified = _ctx.LongValue("DescribeScheduleTasks.Data["+ i +"].GmtModified");
				items.DBClusterId = _ctx.StringValue("DescribeScheduleTasks.Data["+ i +"].DBClusterId");
				items.MaxRetryTime = _ctx.IntegerValue("DescribeScheduleTasks.Data["+ i +"].MaxRetryTime");
				items.Mutex = _ctx.StringValue("DescribeScheduleTasks.Data["+ i +"].Mutex");
				items.OrderId = _ctx.StringValue("DescribeScheduleTasks.Data["+ i +"].OrderId");
				items.PlannedEndTime = _ctx.LongValue("DescribeScheduleTasks.Data["+ i +"].PlannedEndTime");
				items.PlannedStartTime = _ctx.LongValue("DescribeScheduleTasks.Data["+ i +"].PlannedStartTime");
				items.PlannedTime = _ctx.LongValue("DescribeScheduleTasks.Data["+ i +"].PlannedTime");
				items.ProductCode = _ctx.StringValue("DescribeScheduleTasks.Data["+ i +"].ProductCode");
				items.Region = _ctx.StringValue("DescribeScheduleTasks.Data["+ i +"].Region");
				items.Response = _ctx.StringValue("DescribeScheduleTasks.Data["+ i +"].Response");
				items.RetryTime = _ctx.IntegerValue("DescribeScheduleTasks.Data["+ i +"].RetryTime");
				items.Status = _ctx.StringValue("DescribeScheduleTasks.Data["+ i +"].Status");
				items.TaskId = _ctx.StringValue("DescribeScheduleTasks.Data["+ i +"].TaskId");
				items.Type = _ctx.IntegerValue("DescribeScheduleTasks.Data["+ i +"].Type");

				describeScheduleTasksResponse_data.Add(items);
			}
			describeScheduleTasksResponse.Data = describeScheduleTasksResponse_data;
        
			return describeScheduleTasksResponse;
        }
    }
}
