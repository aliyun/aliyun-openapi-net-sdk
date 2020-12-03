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
        public static ListRemindsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRemindsResponse listRemindsResponse = new ListRemindsResponse();

			listRemindsResponse.HttpResponse = _ctx.HttpResponse;
			listRemindsResponse.Success = _ctx.BooleanValue("ListReminds.Success");
			listRemindsResponse.ErrorCode = _ctx.StringValue("ListReminds.ErrorCode");
			listRemindsResponse.ErrorMessage = _ctx.StringValue("ListReminds.ErrorMessage");
			listRemindsResponse.HttpStatusCode = _ctx.IntegerValue("ListReminds.HttpStatusCode");
			listRemindsResponse.RequestId = _ctx.StringValue("ListReminds.RequestId");

			ListRemindsResponse.ListReminds_Data data = new ListRemindsResponse.ListReminds_Data();
			data.PageNumber = _ctx.IntegerValue("ListReminds.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListReminds.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListReminds.Data.TotalCount");

			List<ListRemindsResponse.ListReminds_Data.ListReminds_RemindsItem> data_reminds = new List<ListRemindsResponse.ListReminds_Data.ListReminds_RemindsItem>();
			for (int i = 0; i < _ctx.Length("ListReminds.Data.Reminds.Length"); i++) {
				ListRemindsResponse.ListReminds_Data.ListReminds_RemindsItem remindsItem = new ListRemindsResponse.ListReminds_Data.ListReminds_RemindsItem();
				remindsItem.RemindId = _ctx.LongValue("ListReminds.Data.Reminds["+ i +"].RemindId");
				remindsItem.RemindName = _ctx.StringValue("ListReminds.Data.Reminds["+ i +"].RemindName");
				remindsItem.DndStart = _ctx.StringValue("ListReminds.Data.Reminds["+ i +"].DndStart");
				remindsItem.DndEnd = _ctx.StringValue("ListReminds.Data.Reminds["+ i +"].DndEnd");
				remindsItem.RemindUnit = _ctx.StringValue("ListReminds.Data.Reminds["+ i +"].RemindUnit");
				remindsItem.RemindType = _ctx.StringValue("ListReminds.Data.Reminds["+ i +"].RemindType");
				remindsItem.AlertUnit = _ctx.StringValue("ListReminds.Data.Reminds["+ i +"].AlertUnit");
				remindsItem.Useflag = _ctx.BooleanValue("ListReminds.Data.Reminds["+ i +"].Useflag");
				remindsItem.Founder = _ctx.StringValue("ListReminds.Data.Reminds["+ i +"].Founder");

				List<string> remindsItem_nodeIds = new List<string>();
				for (int j = 0; j < _ctx.Length("ListReminds.Data.Reminds["+ i +"].NodeIds.Length"); j++) {
					remindsItem_nodeIds.Add(_ctx.StringValue("ListReminds.Data.Reminds["+ i +"].NodeIds["+ j +"]"));
				}
				remindsItem.NodeIds = remindsItem_nodeIds;

				List<string> remindsItem_baselineIds = new List<string>();
				for (int j = 0; j < _ctx.Length("ListReminds.Data.Reminds["+ i +"].BaselineIds.Length"); j++) {
					remindsItem_baselineIds.Add(_ctx.StringValue("ListReminds.Data.Reminds["+ i +"].BaselineIds["+ j +"]"));
				}
				remindsItem.BaselineIds = remindsItem_baselineIds;

				List<string> remindsItem_projectIds = new List<string>();
				for (int j = 0; j < _ctx.Length("ListReminds.Data.Reminds["+ i +"].ProjectIds.Length"); j++) {
					remindsItem_projectIds.Add(_ctx.StringValue("ListReminds.Data.Reminds["+ i +"].ProjectIds["+ j +"]"));
				}
				remindsItem.ProjectIds = remindsItem_projectIds;

				List<string> remindsItem_bizProcessIds = new List<string>();
				for (int j = 0; j < _ctx.Length("ListReminds.Data.Reminds["+ i +"].BizProcessIds.Length"); j++) {
					remindsItem_bizProcessIds.Add(_ctx.StringValue("ListReminds.Data.Reminds["+ i +"].BizProcessIds["+ j +"]"));
				}
				remindsItem.BizProcessIds = remindsItem_bizProcessIds;

				List<string> remindsItem_alertMethods = new List<string>();
				for (int j = 0; j < _ctx.Length("ListReminds.Data.Reminds["+ i +"].AlertMethods.Length"); j++) {
					remindsItem_alertMethods.Add(_ctx.StringValue("ListReminds.Data.Reminds["+ i +"].AlertMethods["+ j +"]"));
				}
				remindsItem.AlertMethods = remindsItem_alertMethods;

				List<string> remindsItem_alertTargets = new List<string>();
				for (int j = 0; j < _ctx.Length("ListReminds.Data.Reminds["+ i +"].AlertTargets.Length"); j++) {
					remindsItem_alertTargets.Add(_ctx.StringValue("ListReminds.Data.Reminds["+ i +"].AlertTargets["+ j +"]"));
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
