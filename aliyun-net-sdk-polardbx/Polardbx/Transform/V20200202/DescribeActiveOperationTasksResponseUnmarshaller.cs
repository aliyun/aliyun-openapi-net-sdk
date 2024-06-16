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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeActiveOperationTasksResponseUnmarshaller
    {
        public static DescribeActiveOperationTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeActiveOperationTasksResponse describeActiveOperationTasksResponse = new DescribeActiveOperationTasksResponse();

			describeActiveOperationTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeActiveOperationTasksResponse.PageSize = _ctx.LongValue("DescribeActiveOperationTasks.PageSize");
			describeActiveOperationTasksResponse.RequestId = _ctx.StringValue("DescribeActiveOperationTasks.RequestId");
			describeActiveOperationTasksResponse.PageNumber = _ctx.LongValue("DescribeActiveOperationTasks.PageNumber");
			describeActiveOperationTasksResponse.TotalRecordCount = _ctx.LongValue("DescribeActiveOperationTasks.TotalRecordCount");

			List<DescribeActiveOperationTasksResponse.DescribeActiveOperationTasks_ItemsItem> describeActiveOperationTasksResponse_items = new List<DescribeActiveOperationTasksResponse.DescribeActiveOperationTasks_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeActiveOperationTasks.Items.Length"); i++) {
				DescribeActiveOperationTasksResponse.DescribeActiveOperationTasks_ItemsItem itemsItem = new DescribeActiveOperationTasksResponse.DescribeActiveOperationTasks_ItemsItem();
				itemsItem.AllowCancel = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].AllowCancel");
				itemsItem.AllowChange = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].AllowChange");
				itemsItem.ChangeLevel = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].ChangeLevel");
				itemsItem.ChangeLevelEn = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].ChangeLevelEn");
				itemsItem.ChangeLevelZh = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].ChangeLevelZh");
				itemsItem.CreatedTime = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].CreatedTime");
				itemsItem.CurrentAVZ = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].CurrentAVZ");
				itemsItem.DbType = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].DbType");
				itemsItem.DbVersion = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].DbVersion");
				itemsItem.Deadline = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].Deadline");
				itemsItem.Id = _ctx.LongValue("DescribeActiveOperationTasks.Items["+ i +"].Id");
				itemsItem.Impact = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].Impact");
				itemsItem.ImpactEn = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].ImpactEn");
				itemsItem.ImpactZh = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].ImpactZh");
				itemsItem.InsComment = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].InsComment");
				itemsItem.InsName = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].InsName");
				itemsItem.ModifiedTime = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].ModifiedTime");
				itemsItem.PrepareInterval = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].PrepareInterval");
				itemsItem.Region = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].Region");
				itemsItem.ResultInfo = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].ResultInfo");
				itemsItem.StartTime = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].StartTime");
				itemsItem.Status = _ctx.LongValue("DescribeActiveOperationTasks.Items["+ i +"].Status");
				itemsItem.SwitchTime = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].SwitchTime");
				itemsItem.TaskType = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].TaskType");
				itemsItem.TaskTypeEn = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].TaskTypeEn");
				itemsItem.TaskTypeZh = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].TaskTypeZh");

				List<string> itemsItem_subInsNames = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeActiveOperationTasks.Items["+ i +"].SubInsNames.Length"); j++) {
					itemsItem_subInsNames.Add(_ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].SubInsNames["+ j +"]"));
				}
				itemsItem.SubInsNames = itemsItem_subInsNames;

				describeActiveOperationTasksResponse_items.Add(itemsItem);
			}
			describeActiveOperationTasksResponse.Items = describeActiveOperationTasksResponse_items;
        
			return describeActiveOperationTasksResponse;
        }
    }
}
