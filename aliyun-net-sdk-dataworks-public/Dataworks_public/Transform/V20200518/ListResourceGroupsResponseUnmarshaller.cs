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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListResourceGroupsResponseUnmarshaller
    {
        public static ListResourceGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			ListResourceGroupsResponse listResourceGroupsResponse = new ListResourceGroupsResponse();

			listResourceGroupsResponse.HttpResponse = context.HttpResponse;
			listResourceGroupsResponse.HttpStatusCode = context.IntegerValue("ListResourceGroups.HttpStatusCode");
			listResourceGroupsResponse.Success = context.BooleanValue("ListResourceGroups.Success");
			listResourceGroupsResponse.RequestId = context.StringValue("ListResourceGroups.RequestId");

			List<ListResourceGroupsResponse.ListResourceGroups_DataItem> listResourceGroupsResponse_data = new List<ListResourceGroupsResponse.ListResourceGroups_DataItem>();
			for (int i = 0; i < context.Length("ListResourceGroups.Data.Length"); i++) {
				ListResourceGroupsResponse.ListResourceGroups_DataItem dataItem = new ListResourceGroupsResponse.ListResourceGroups_DataItem();
				dataItem.Identifier = context.StringValue("ListResourceGroups.Data["+ i +"].Identifier");
				dataItem.Cluster = context.StringValue("ListResourceGroups.Data["+ i +"].Cluster");
				dataItem.BizExtKey = context.StringValue("ListResourceGroups.Data["+ i +"].BizExtKey");
				dataItem.EnableKp = context.BooleanValue("ListResourceGroups.Data["+ i +"].EnableKp");
				dataItem.UpdateTime = context.StringValue("ListResourceGroups.Data["+ i +"].UpdateTime");
				dataItem.ResourceGroupType = context.StringValue("ListResourceGroups.Data["+ i +"].ResourceGroupType");
				dataItem.Mode = context.StringValue("ListResourceGroups.Data["+ i +"].Mode");
				dataItem.Sequence = context.IntegerValue("ListResourceGroups.Data["+ i +"].Sequence");
				dataItem.IsDefault = context.BooleanValue("ListResourceGroups.Data["+ i +"].IsDefault");
				dataItem.CreateTime = context.StringValue("ListResourceGroups.Data["+ i +"].CreateTime");
				dataItem.Name = context.StringValue("ListResourceGroups.Data["+ i +"].Name");
				dataItem.TenantId = context.LongValue("ListResourceGroups.Data["+ i +"].TenantId");
				dataItem.Id = context.LongValue("ListResourceGroups.Data["+ i +"].Id");
				dataItem.Status = context.IntegerValue("ListResourceGroups.Data["+ i +"].Status");
				dataItem.Specs = context.StringValue("ListResourceGroups.Data["+ i +"].Specs");

				listResourceGroupsResponse_data.Add(dataItem);
			}
			listResourceGroupsResponse.Data = listResourceGroupsResponse_data;
        
			return listResourceGroupsResponse;
        }
    }
}
