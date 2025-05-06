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
    public class DescribeHistoryTasksResponseUnmarshaller
    {
        public static DescribeHistoryTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeHistoryTasksResponse describeHistoryTasksResponse = new DescribeHistoryTasksResponse();

			describeHistoryTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeHistoryTasksResponse.PageNumber = _ctx.IntegerValue("DescribeHistoryTasks.PageNumber");
			describeHistoryTasksResponse.RequestId = _ctx.StringValue("DescribeHistoryTasks.RequestId");
			describeHistoryTasksResponse.PageSize = _ctx.IntegerValue("DescribeHistoryTasks.PageSize");
			describeHistoryTasksResponse.TotalCount = _ctx.StringValue("DescribeHistoryTasks.TotalCount");

			List<DescribeHistoryTasksResponse.DescribeHistoryTasks_ItemsItem> describeHistoryTasksResponse_items = new List<DescribeHistoryTasksResponse.DescribeHistoryTasks_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeHistoryTasks.Items.Length"); i++) {
				DescribeHistoryTasksResponse.DescribeHistoryTasks_ItemsItem itemsItem = new DescribeHistoryTasksResponse.DescribeHistoryTasks_ItemsItem();
				itemsItem.Status = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].Status");
				itemsItem.TaskId = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].TaskId");
				itemsItem.CurrentStepName = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].CurrentStepName");
				itemsItem.StartTime = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].StartTime");
				itemsItem.EndTime = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].EndTime");
				itemsItem.TaskType = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].TaskType");
				itemsItem.RemainTime = _ctx.IntegerValue("DescribeHistoryTasks.Items["+ i +"].RemainTime");
				itemsItem.Progress = _ctx.FloatValue("DescribeHistoryTasks.Items["+ i +"].Progress");
				itemsItem.RegionId = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].RegionId");
				itemsItem.InstanceType = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].InstanceType");
				itemsItem.InstanceId = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].InstanceId");
				itemsItem.InstanceName = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].InstanceName");
				itemsItem.DbType = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].DbType");
				itemsItem.Product = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].Product");
				itemsItem.TaskDetail = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].TaskDetail");
				itemsItem.ReasonCode = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].ReasonCode");
				itemsItem.ActionInfo = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].ActionInfo");
				itemsItem.Uid = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].Uid");
				itemsItem.CallerSource = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].CallerSource");
				itemsItem.CallerUid = _ctx.StringValue("DescribeHistoryTasks.Items["+ i +"].CallerUid");

				describeHistoryTasksResponse_items.Add(itemsItem);
			}
			describeHistoryTasksResponse.Items = describeHistoryTasksResponse_items;
        
			return describeHistoryTasksResponse;
        }
    }
}
