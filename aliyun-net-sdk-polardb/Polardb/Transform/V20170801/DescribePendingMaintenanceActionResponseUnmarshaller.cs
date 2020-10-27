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
    public class DescribePendingMaintenanceActionResponseUnmarshaller
    {
        public static DescribePendingMaintenanceActionResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePendingMaintenanceActionResponse describePendingMaintenanceActionResponse = new DescribePendingMaintenanceActionResponse();

			describePendingMaintenanceActionResponse.HttpResponse = context.HttpResponse;
			describePendingMaintenanceActionResponse.RequestId = context.StringValue("DescribePendingMaintenanceAction.RequestId");
			describePendingMaintenanceActionResponse.TotalRecordCount = context.IntegerValue("DescribePendingMaintenanceAction.TotalRecordCount");
			describePendingMaintenanceActionResponse.PageSize = context.IntegerValue("DescribePendingMaintenanceAction.PageSize");
			describePendingMaintenanceActionResponse.PageNumber = context.IntegerValue("DescribePendingMaintenanceAction.PageNumber");

			List<DescribePendingMaintenanceActionResponse.DescribePendingMaintenanceAction_ItemsItem> describePendingMaintenanceActionResponse_items = new List<DescribePendingMaintenanceActionResponse.DescribePendingMaintenanceAction_ItemsItem>();
			for (int i = 0; i < context.Length("DescribePendingMaintenanceAction.Items.Length"); i++) {
				DescribePendingMaintenanceActionResponse.DescribePendingMaintenanceAction_ItemsItem itemsItem = new DescribePendingMaintenanceActionResponse.DescribePendingMaintenanceAction_ItemsItem();
				itemsItem.Id = context.IntegerValue("DescribePendingMaintenanceAction.Items["+ i +"].Id");
				itemsItem.DBClusterId = context.StringValue("DescribePendingMaintenanceAction.Items["+ i +"].DBClusterId");
				itemsItem.DBType = context.StringValue("DescribePendingMaintenanceAction.Items["+ i +"].DBType");
				itemsItem.StartTime = context.StringValue("DescribePendingMaintenanceAction.Items["+ i +"].StartTime");
				itemsItem.SwitchTime = context.StringValue("DescribePendingMaintenanceAction.Items["+ i +"].SwitchTime");
				itemsItem.Deadline = context.StringValue("DescribePendingMaintenanceAction.Items["+ i +"].Deadline");
				itemsItem.Status = context.IntegerValue("DescribePendingMaintenanceAction.Items["+ i +"].Status");
				itemsItem.CreatedTime = context.StringValue("DescribePendingMaintenanceAction.Items["+ i +"].CreatedTime");
				itemsItem.ModifiedTime = context.StringValue("DescribePendingMaintenanceAction.Items["+ i +"].ModifiedTime");
				itemsItem.ResultInfo = context.StringValue("DescribePendingMaintenanceAction.Items["+ i +"].ResultInfo");
				itemsItem.PrepareInterval = context.StringValue("DescribePendingMaintenanceAction.Items["+ i +"].PrepareInterval");
				itemsItem.TaskType = context.StringValue("DescribePendingMaintenanceAction.Items["+ i +"].TaskType");
				itemsItem.DBVersion = context.StringValue("DescribePendingMaintenanceAction.Items["+ i +"].DBVersion");
				itemsItem.Region = context.StringValue("DescribePendingMaintenanceAction.Items["+ i +"].Region");

				describePendingMaintenanceActionResponse_items.Add(itemsItem);
			}
			describePendingMaintenanceActionResponse.Items = describePendingMaintenanceActionResponse_items;
        
			return describePendingMaintenanceActionResponse;
        }
    }
}
