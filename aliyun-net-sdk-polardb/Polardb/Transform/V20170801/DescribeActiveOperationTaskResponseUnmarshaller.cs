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
    public class DescribeActiveOperationTaskResponseUnmarshaller
    {
        public static DescribeActiveOperationTaskResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeActiveOperationTaskResponse describeActiveOperationTaskResponse = new DescribeActiveOperationTaskResponse();

			describeActiveOperationTaskResponse.HttpResponse = context.HttpResponse;
			describeActiveOperationTaskResponse.RequestId = context.StringValue("DescribeActiveOperationTask.RequestId");
			describeActiveOperationTaskResponse.TotalRecordCount = context.IntegerValue("DescribeActiveOperationTask.TotalRecordCount");
			describeActiveOperationTaskResponse.PageSize = context.IntegerValue("DescribeActiveOperationTask.PageSize");
			describeActiveOperationTaskResponse.PageNumber = context.IntegerValue("DescribeActiveOperationTask.PageNumber");

			List<DescribeActiveOperationTaskResponse.DescribeActiveOperationTask_ItemsItem> describeActiveOperationTaskResponse_items = new List<DescribeActiveOperationTaskResponse.DescribeActiveOperationTask_ItemsItem>();
			for (int i = 0; i < context.Length("DescribeActiveOperationTask.Items.Length"); i++) {
				DescribeActiveOperationTaskResponse.DescribeActiveOperationTask_ItemsItem itemsItem = new DescribeActiveOperationTaskResponse.DescribeActiveOperationTask_ItemsItem();
				itemsItem.Id = context.IntegerValue("DescribeActiveOperationTask.Items["+ i +"].Id");
				itemsItem.InsName = context.StringValue("DescribeActiveOperationTask.Items["+ i +"].InsName");
				itemsItem.DbType = context.StringValue("DescribeActiveOperationTask.Items["+ i +"].DbType");
				itemsItem.StartTime = context.StringValue("DescribeActiveOperationTask.Items["+ i +"].StartTime");
				itemsItem.SwitchTime = context.StringValue("DescribeActiveOperationTask.Items["+ i +"].SwitchTime");
				itemsItem.Deadline = context.StringValue("DescribeActiveOperationTask.Items["+ i +"].Deadline");
				itemsItem.Status = context.IntegerValue("DescribeActiveOperationTask.Items["+ i +"].Status");
				itemsItem.CreatedTime = context.StringValue("DescribeActiveOperationTask.Items["+ i +"].CreatedTime");
				itemsItem.ModifiedTime = context.StringValue("DescribeActiveOperationTask.Items["+ i +"].ModifiedTime");
				itemsItem.ResultInfo = context.StringValue("DescribeActiveOperationTask.Items["+ i +"].ResultInfo");
				itemsItem.PrepareInterval = context.StringValue("DescribeActiveOperationTask.Items["+ i +"].PrepareInterval");
				itemsItem.TaskParams = context.StringValue("DescribeActiveOperationTask.Items["+ i +"].TaskParams");
				itemsItem.TaskType = context.StringValue("DescribeActiveOperationTask.Items["+ i +"].TaskType");
				itemsItem.DbVersion = context.StringValue("DescribeActiveOperationTask.Items["+ i +"].DbVersion");
				itemsItem.Region = context.StringValue("DescribeActiveOperationTask.Items["+ i +"].Region");

				describeActiveOperationTaskResponse_items.Add(itemsItem);
			}
			describeActiveOperationTaskResponse.Items = describeActiveOperationTaskResponse_items;
        
			return describeActiveOperationTaskResponse;
        }
    }
}
