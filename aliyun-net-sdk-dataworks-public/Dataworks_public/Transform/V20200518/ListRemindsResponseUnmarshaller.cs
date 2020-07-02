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
    public class ListRemindsResponseUnmarshaller
    {
        public static ListRemindsResponse Unmarshall(UnmarshallerContext context)
        {
			ListRemindsResponse listRemindsResponse = new ListRemindsResponse();

			listRemindsResponse.HttpResponse = context.HttpResponse;
			listRemindsResponse.Success = context.BooleanValue("ListReminds.Success");
			listRemindsResponse.ErrorCode = context.StringValue("ListReminds.ErrorCode");
			listRemindsResponse.ErrorMessage = context.StringValue("ListReminds.ErrorMessage");
			listRemindsResponse.HttpStatusCode = context.IntegerValue("ListReminds.HttpStatusCode");
			listRemindsResponse.RequestId = context.StringValue("ListReminds.RequestId");

			ListRemindsResponse.ListReminds_Data data = new ListRemindsResponse.ListReminds_Data();
			data.PageNumber = context.IntegerValue("ListReminds.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListReminds.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListReminds.Data.TotalCount");

			List<ListRemindsResponse.ListReminds_Data.ListReminds_RemindsItem> data_reminds = new List<ListRemindsResponse.ListReminds_Data.ListReminds_RemindsItem>();
			for (int i = 0; i < context.Length("ListReminds.Data.Reminds.Length"); i++) {
				ListRemindsResponse.ListReminds_Data.ListReminds_RemindsItem remindsItem = new ListRemindsResponse.ListReminds_Data.ListReminds_RemindsItem();
				remindsItem.RemindId = context.LongValue("ListReminds.Data.Reminds["+ i +"].RemindId");
				remindsItem.RemindName = context.StringValue("ListReminds.Data.Reminds["+ i +"].RemindName");
				remindsItem.DndStart = context.StringValue("ListReminds.Data.Reminds["+ i +"].DndStart");
				remindsItem.DndEnd = context.StringValue("ListReminds.Data.Reminds["+ i +"].DndEnd");
				remindsItem.RemindUnit = context.StringValue("ListReminds.Data.Reminds["+ i +"].RemindUnit");
				remindsItem.RemindType = context.StringValue("ListReminds.Data.Reminds["+ i +"].RemindType");
				remindsItem.AlertUnit = context.StringValue("ListReminds.Data.Reminds["+ i +"].AlertUnit");
				remindsItem.Useflag = context.BooleanValue("ListReminds.Data.Reminds["+ i +"].Useflag");
				remindsItem.Founder = context.StringValue("ListReminds.Data.Reminds["+ i +"].Founder");

				List<string> remindsItem_nodeIds = new List<string>();
				for (int j = 0; j < context.Length("ListReminds.Data.Reminds["+ i +"].NodeIds.Length"); j++) {
					remindsItem_nodeIds.Add(context.StringValue("ListReminds.Data.Reminds["+ i +"].NodeIds["+ j +"]"));
				}
				remindsItem.NodeIds = remindsItem_nodeIds;

				List<string> remindsItem_baselineIds = new List<string>();
				for (int j = 0; j < context.Length("ListReminds.Data.Reminds["+ i +"].BaselineIds.Length"); j++) {
					remindsItem_baselineIds.Add(context.StringValue("ListReminds.Data.Reminds["+ i +"].BaselineIds["+ j +"]"));
				}
				remindsItem.BaselineIds = remindsItem_baselineIds;

				List<string> remindsItem_projectIds = new List<string>();
				for (int j = 0; j < context.Length("ListReminds.Data.Reminds["+ i +"].ProjectIds.Length"); j++) {
					remindsItem_projectIds.Add(context.StringValue("ListReminds.Data.Reminds["+ i +"].ProjectIds["+ j +"]"));
				}
				remindsItem.ProjectIds = remindsItem_projectIds;

				List<string> remindsItem_bizProcessIds = new List<string>();
				for (int j = 0; j < context.Length("ListReminds.Data.Reminds["+ i +"].BizProcessIds.Length"); j++) {
					remindsItem_bizProcessIds.Add(context.StringValue("ListReminds.Data.Reminds["+ i +"].BizProcessIds["+ j +"]"));
				}
				remindsItem.BizProcessIds = remindsItem_bizProcessIds;

				List<string> remindsItem_alertMethods = new List<string>();
				for (int j = 0; j < context.Length("ListReminds.Data.Reminds["+ i +"].AlertMethods.Length"); j++) {
					remindsItem_alertMethods.Add(context.StringValue("ListReminds.Data.Reminds["+ i +"].AlertMethods["+ j +"]"));
				}
				remindsItem.AlertMethods = remindsItem_alertMethods;

				List<string> remindsItem_alertTargets = new List<string>();
				for (int j = 0; j < context.Length("ListReminds.Data.Reminds["+ i +"].AlertTargets.Length"); j++) {
					remindsItem_alertTargets.Add(context.StringValue("ListReminds.Data.Reminds["+ i +"].AlertTargets["+ j +"]"));
				}
				remindsItem.AlertTargets = remindsItem_alertTargets;

				data_reminds.Add(remindsItem);
			}
			data.Reminds = data_reminds;
			listRemindsResponse.Data = data;
        
			return listRemindsResponse;
        }
    }
}
