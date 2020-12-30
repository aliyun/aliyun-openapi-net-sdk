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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeActiveOperationTaskResponseUnmarshaller
    {
        public static DescribeActiveOperationTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeActiveOperationTaskResponse describeActiveOperationTaskResponse = new DescribeActiveOperationTaskResponse();

			describeActiveOperationTaskResponse.HttpResponse = _ctx.HttpResponse;
			describeActiveOperationTaskResponse.RequestId = _ctx.StringValue("DescribeActiveOperationTask.RequestId");
			describeActiveOperationTaskResponse.TotalRecordCount = _ctx.IntegerValue("DescribeActiveOperationTask.TotalRecordCount");
			describeActiveOperationTaskResponse.PageSize = _ctx.IntegerValue("DescribeActiveOperationTask.PageSize");
			describeActiveOperationTaskResponse.PageNumber = _ctx.IntegerValue("DescribeActiveOperationTask.PageNumber");

			List<DescribeActiveOperationTaskResponse.DescribeActiveOperationTask_ItemsItem> describeActiveOperationTaskResponse_items = new List<DescribeActiveOperationTaskResponse.DescribeActiveOperationTask_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeActiveOperationTask.Items.Length"); i++) {
				DescribeActiveOperationTaskResponse.DescribeActiveOperationTask_ItemsItem itemsItem = new DescribeActiveOperationTaskResponse.DescribeActiveOperationTask_ItemsItem();
				itemsItem.Id = _ctx.IntegerValue("DescribeActiveOperationTask.Items["+ i +"].Id");
				itemsItem.InsName = _ctx.StringValue("DescribeActiveOperationTask.Items["+ i +"].InsName");
				itemsItem.DbType = _ctx.StringValue("DescribeActiveOperationTask.Items["+ i +"].DbType");
				itemsItem.StartTime = _ctx.StringValue("DescribeActiveOperationTask.Items["+ i +"].StartTime");
				itemsItem.SwitchTime = _ctx.StringValue("DescribeActiveOperationTask.Items["+ i +"].SwitchTime");
				itemsItem.Deadline = _ctx.StringValue("DescribeActiveOperationTask.Items["+ i +"].Deadline");
				itemsItem.Status = _ctx.IntegerValue("DescribeActiveOperationTask.Items["+ i +"].Status");
				itemsItem.CreatedTime = _ctx.StringValue("DescribeActiveOperationTask.Items["+ i +"].CreatedTime");
				itemsItem.ModifiedTime = _ctx.StringValue("DescribeActiveOperationTask.Items["+ i +"].ModifiedTime");
				itemsItem.ResultInfo = _ctx.StringValue("DescribeActiveOperationTask.Items["+ i +"].ResultInfo");
				itemsItem.PrepareInterval = _ctx.StringValue("DescribeActiveOperationTask.Items["+ i +"].PrepareInterval");
				itemsItem.TaskParams = _ctx.StringValue("DescribeActiveOperationTask.Items["+ i +"].TaskParams");
				itemsItem.TaskType = _ctx.StringValue("DescribeActiveOperationTask.Items["+ i +"].TaskType");
				itemsItem.Region = _ctx.StringValue("DescribeActiveOperationTask.Items["+ i +"].Region");

				describeActiveOperationTaskResponse_items.Add(itemsItem);
			}
			describeActiveOperationTaskResponse.Items = describeActiveOperationTaskResponse_items;
        
			return describeActiveOperationTaskResponse;
        }
    }
}
