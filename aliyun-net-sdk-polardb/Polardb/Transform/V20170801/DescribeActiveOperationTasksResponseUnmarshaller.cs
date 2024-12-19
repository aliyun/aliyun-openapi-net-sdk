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
    public class DescribeActiveOperationTasksResponseUnmarshaller
    {
        public static DescribeActiveOperationTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeActiveOperationTasksResponse describeActiveOperationTasksResponse = new DescribeActiveOperationTasksResponse();

			describeActiveOperationTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeActiveOperationTasksResponse.TotalRecordCount = _ctx.IntegerValue("DescribeActiveOperationTasks.TotalRecordCount");
			describeActiveOperationTasksResponse.RequestId = _ctx.StringValue("DescribeActiveOperationTasks.RequestId");
			describeActiveOperationTasksResponse.PageSize = _ctx.IntegerValue("DescribeActiveOperationTasks.PageSize");
			describeActiveOperationTasksResponse.PageNumber = _ctx.IntegerValue("DescribeActiveOperationTasks.PageNumber");

			List<DescribeActiveOperationTasksResponse.DescribeActiveOperationTasks_ItemsItem> describeActiveOperationTasksResponse_items = new List<DescribeActiveOperationTasksResponse.DescribeActiveOperationTasks_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeActiveOperationTasks.Items.Length"); i++) {
				DescribeActiveOperationTasksResponse.DescribeActiveOperationTasks_ItemsItem itemsItem = new DescribeActiveOperationTasksResponse.DescribeActiveOperationTasks_ItemsItem();
				itemsItem.Status = _ctx.IntegerValue("DescribeActiveOperationTasks.Items["+ i +"].Status");
				itemsItem.PrepareInterval = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].PrepareInterval");
				itemsItem.Deadline = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].Deadline");
				itemsItem.DBType = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].DBType");
				itemsItem.TaskType = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].TaskType");
				itemsItem.StartTime = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].StartTime");
				itemsItem.DBVersion = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].DBVersion");
				itemsItem.ModifiedTime = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].ModifiedTime");
				itemsItem.DBClusterId = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].DBClusterId");
				itemsItem.Region = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].Region");
				itemsItem.ResultInfo = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].ResultInfo");
				itemsItem.CreatedTime = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].CreatedTime");
				itemsItem.TaskId = _ctx.IntegerValue("DescribeActiveOperationTasks.Items["+ i +"].TaskId");
				itemsItem.SwitchTime = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].SwitchTime");
				itemsItem.CurrentAVZ = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].CurrentAVZ");
				itemsItem.InsComment = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].InsComment");
				itemsItem.TaskTypeZh = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].TaskTypeZh");
				itemsItem.TaskTypeEn = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].TaskTypeEn");
				itemsItem.ChangeLevel = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].ChangeLevel");
				itemsItem.ChangeLevelZh = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].ChangeLevelZh");
				itemsItem.ChangeLevelEn = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].ChangeLevelEn");
				itemsItem.ImpactZh = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].ImpactZh");
				itemsItem.ImpactEn = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].ImpactEn");
				itemsItem.AllowChange = _ctx.LongValue("DescribeActiveOperationTasks.Items["+ i +"].AllowChange");
				itemsItem.AllowCancel = _ctx.LongValue("DescribeActiveOperationTasks.Items["+ i +"].AllowCancel");
				itemsItem.Impact = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].Impact");
				itemsItem.TaskParams = _ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].TaskParams");

				List<string> itemsItem_dBNodeIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeActiveOperationTasks.Items["+ i +"].DBNodeIds.Length"); j++) {
					itemsItem_dBNodeIds.Add(_ctx.StringValue("DescribeActiveOperationTasks.Items["+ i +"].DBNodeIds["+ j +"]"));
				}
				itemsItem.DBNodeIds = itemsItem_dBNodeIds;

				describeActiveOperationTasksResponse_items.Add(itemsItem);
			}
			describeActiveOperationTasksResponse.Items = describeActiveOperationTasksResponse_items;
        
			return describeActiveOperationTasksResponse;
        }
    }
}
