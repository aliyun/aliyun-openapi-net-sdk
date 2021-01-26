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
			describeScheduleTasksResponse.Message = _ctx.StringValue("DescribeScheduleTasks.Message");
			describeScheduleTasksResponse.Code = _ctx.StringValue("DescribeScheduleTasks.Code");
			describeScheduleTasksResponse.Success = _ctx.BooleanValue("DescribeScheduleTasks.Success");

			DescribeScheduleTasksResponse.DescribeScheduleTasks_Data data = new DescribeScheduleTasksResponse.DescribeScheduleTasks_Data();
			data.TotalRecordCount = _ctx.IntegerValue("DescribeScheduleTasks.Data.TotalRecordCount");
			data.PageSize = _ctx.IntegerValue("DescribeScheduleTasks.Data.PageSize");
			data.PageNumber = _ctx.IntegerValue("DescribeScheduleTasks.Data.PageNumber");

			List<DescribeScheduleTasksResponse.DescribeScheduleTasks_Data.DescribeScheduleTasks_TimerInfosItem> data_timerInfos = new List<DescribeScheduleTasksResponse.DescribeScheduleTasks_Data.DescribeScheduleTasks_TimerInfosItem>();
			for (int i = 0; i < _ctx.Length("DescribeScheduleTasks.Data.TimerInfos.Length"); i++) {
				DescribeScheduleTasksResponse.DescribeScheduleTasks_Data.DescribeScheduleTasks_TimerInfosItem timerInfosItem = new DescribeScheduleTasksResponse.DescribeScheduleTasks_Data.DescribeScheduleTasks_TimerInfosItem();
				timerInfosItem.Status = _ctx.StringValue("DescribeScheduleTasks.Data.TimerInfos["+ i +"].Status");
				timerInfosItem.GmtCreate = _ctx.LongValue("DescribeScheduleTasks.Data.TimerInfos["+ i +"].GmtCreate");
				timerInfosItem.Action = _ctx.StringValue("DescribeScheduleTasks.Data.TimerInfos["+ i +"].Action");
				timerInfosItem.TaskId = _ctx.StringValue("DescribeScheduleTasks.Data.TimerInfos["+ i +"].TaskId");
				timerInfosItem.PlannedTime = _ctx.StringValue("DescribeScheduleTasks.Data.TimerInfos["+ i +"].PlannedTime");
				timerInfosItem.PlannedStartTime = _ctx.StringValue("DescribeScheduleTasks.Data.TimerInfos["+ i +"].PlannedStartTime");
				timerInfosItem.DBClusterId = _ctx.StringValue("DescribeScheduleTasks.Data.TimerInfos["+ i +"].DBClusterId");
				timerInfosItem.GmtModified = _ctx.LongValue("DescribeScheduleTasks.Data.TimerInfos["+ i +"].GmtModified");
				timerInfosItem.Region = _ctx.StringValue("DescribeScheduleTasks.Data.TimerInfos["+ i +"].Region");
				timerInfosItem.OrderId = _ctx.StringValue("DescribeScheduleTasks.Data.TimerInfos["+ i +"].OrderId");
				timerInfosItem.PlannedEndTime = _ctx.StringValue("DescribeScheduleTasks.Data.TimerInfos["+ i +"].PlannedEndTime");
				timerInfosItem.AliUid = _ctx.IntegerValue("DescribeScheduleTasks.Data.TimerInfos["+ i +"].AliUid");

				data_timerInfos.Add(timerInfosItem);
			}
			data.TimerInfos = data_timerInfos;
			describeScheduleTasksResponse.Data = data;
        
			return describeScheduleTasksResponse;
        }
    }
}
