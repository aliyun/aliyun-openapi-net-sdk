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
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeRecordTasksResponseUnmarshaller
    {
        public static DescribeRecordTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRecordTasksResponse describeRecordTasksResponse = new DescribeRecordTasksResponse();

			describeRecordTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeRecordTasksResponse.RequestId = _ctx.StringValue("DescribeRecordTasks.RequestId");
			describeRecordTasksResponse.TotalNum = _ctx.LongValue("DescribeRecordTasks.TotalNum");
			describeRecordTasksResponse.TotalPage = _ctx.LongValue("DescribeRecordTasks.TotalPage");

			List<DescribeRecordTasksResponse.DescribeRecordTasks_RecordTask> describeRecordTasksResponse_recordTasks = new List<DescribeRecordTasksResponse.DescribeRecordTasks_RecordTask>();
			for (int i = 0; i < _ctx.Length("DescribeRecordTasks.RecordTasks.Length"); i++) {
				DescribeRecordTasksResponse.DescribeRecordTasks_RecordTask recordTask = new DescribeRecordTasksResponse.DescribeRecordTasks_RecordTask();
				recordTask.CreateTime = _ctx.StringValue("DescribeRecordTasks.RecordTasks["+ i +"].CreateTime");
				recordTask.AppId = _ctx.StringValue("DescribeRecordTasks.RecordTasks["+ i +"].AppId");
				recordTask.ChannelId = _ctx.StringValue("DescribeRecordTasks.RecordTasks["+ i +"].ChannelId");
				recordTask.TaskId = _ctx.StringValue("DescribeRecordTasks.RecordTasks["+ i +"].TaskId");
				recordTask.TemplateId = _ctx.StringValue("DescribeRecordTasks.RecordTasks["+ i +"].TemplateId");
				recordTask.Status = _ctx.IntegerValue("DescribeRecordTasks.RecordTasks["+ i +"].Status");

				List<string> recordTask_subSpecUsers = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeRecordTasks.RecordTasks["+ i +"].SubSpecUsers.Length"); j++) {
					recordTask_subSpecUsers.Add(_ctx.StringValue("DescribeRecordTasks.RecordTasks["+ i +"].SubSpecUsers["+ j +"]"));
				}
				recordTask.SubSpecUsers = recordTask_subSpecUsers;

				List<DescribeRecordTasksResponse.DescribeRecordTasks_RecordTask.DescribeRecordTasks_UserPanesItem> recordTask_userPanes = new List<DescribeRecordTasksResponse.DescribeRecordTasks_RecordTask.DescribeRecordTasks_UserPanesItem>();
				for (int j = 0; j < _ctx.Length("DescribeRecordTasks.RecordTasks["+ i +"].UserPanes.Length"); j++) {
					DescribeRecordTasksResponse.DescribeRecordTasks_RecordTask.DescribeRecordTasks_UserPanesItem userPanesItem = new DescribeRecordTasksResponse.DescribeRecordTasks_RecordTask.DescribeRecordTasks_UserPanesItem();
					userPanesItem.PaneId = _ctx.IntegerValue("DescribeRecordTasks.RecordTasks["+ i +"].UserPanes["+ j +"].PaneId");
					userPanesItem.UserId = _ctx.StringValue("DescribeRecordTasks.RecordTasks["+ i +"].UserPanes["+ j +"].UserId");
					userPanesItem.Source = _ctx.StringValue("DescribeRecordTasks.RecordTasks["+ i +"].UserPanes["+ j +"].Source");

					recordTask_userPanes.Add(userPanesItem);
				}
				recordTask.UserPanes = recordTask_userPanes;

				describeRecordTasksResponse_recordTasks.Add(recordTask);
			}
			describeRecordTasksResponse.RecordTasks = describeRecordTasksResponse_recordTasks;
        
			return describeRecordTasksResponse;
        }
    }
}
