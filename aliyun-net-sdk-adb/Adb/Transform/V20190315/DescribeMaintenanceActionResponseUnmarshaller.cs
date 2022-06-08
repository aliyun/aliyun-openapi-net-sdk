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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeMaintenanceActionResponseUnmarshaller
    {
        public static DescribeMaintenanceActionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMaintenanceActionResponse describeMaintenanceActionResponse = new DescribeMaintenanceActionResponse();

			describeMaintenanceActionResponse.HttpResponse = _ctx.HttpResponse;
			describeMaintenanceActionResponse.PageNumber = _ctx.IntegerValue("DescribeMaintenanceAction.PageNumber");
			describeMaintenanceActionResponse.RequestId = _ctx.StringValue("DescribeMaintenanceAction.RequestId");
			describeMaintenanceActionResponse.PageSize = _ctx.IntegerValue("DescribeMaintenanceAction.PageSize");
			describeMaintenanceActionResponse.TotalRecordCount = _ctx.IntegerValue("DescribeMaintenanceAction.TotalRecordCount");

			List<DescribeMaintenanceActionResponse.DescribeMaintenanceAction_ItemsItem> describeMaintenanceActionResponse_items = new List<DescribeMaintenanceActionResponse.DescribeMaintenanceAction_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeMaintenanceAction.Items.Length"); i++) {
				DescribeMaintenanceActionResponse.DescribeMaintenanceAction_ItemsItem itemsItem = new DescribeMaintenanceActionResponse.DescribeMaintenanceAction_ItemsItem();
				itemsItem.Status = _ctx.StringValue("DescribeMaintenanceAction.Items["+ i +"].Status");
				itemsItem.Deadline = _ctx.StringValue("DescribeMaintenanceAction.Items["+ i +"].Deadline");
				itemsItem.PrepareInterval = _ctx.StringValue("DescribeMaintenanceAction.Items["+ i +"].PrepareInterval");
				itemsItem.DBType = _ctx.StringValue("DescribeMaintenanceAction.Items["+ i +"].DBType");
				itemsItem.StartTime = _ctx.StringValue("DescribeMaintenanceAction.Items["+ i +"].StartTime");
				itemsItem.TaskType = _ctx.StringValue("DescribeMaintenanceAction.Items["+ i +"].TaskType");
				itemsItem.DBVersion = _ctx.StringValue("DescribeMaintenanceAction.Items["+ i +"].DBVersion");
				itemsItem.DBClusterId = _ctx.StringValue("DescribeMaintenanceAction.Items["+ i +"].DBClusterId");
				itemsItem.ModifiedTime = _ctx.StringValue("DescribeMaintenanceAction.Items["+ i +"].ModifiedTime");
				itemsItem.Region = _ctx.StringValue("DescribeMaintenanceAction.Items["+ i +"].Region");
				itemsItem.ResultInfo = _ctx.StringValue("DescribeMaintenanceAction.Items["+ i +"].ResultInfo");
				itemsItem.CreatedTime = _ctx.StringValue("DescribeMaintenanceAction.Items["+ i +"].CreatedTime");
				itemsItem.Id = _ctx.IntegerValue("DescribeMaintenanceAction.Items["+ i +"].Id");
				itemsItem.SwitchTime = _ctx.StringValue("DescribeMaintenanceAction.Items["+ i +"].SwitchTime");

				describeMaintenanceActionResponse_items.Add(itemsItem);
			}
			describeMaintenanceActionResponse.Items = describeMaintenanceActionResponse_items;
        
			return describeMaintenanceActionResponse;
        }
    }
}
