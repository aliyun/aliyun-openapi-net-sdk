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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListAdviceActionResponseUnmarshaller
    {
        public static ListAdviceActionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAdviceActionResponse listAdviceActionResponse = new ListAdviceActionResponse();

			listAdviceActionResponse.HttpResponse = _ctx.HttpResponse;
			listAdviceActionResponse.RequestId = _ctx.StringValue("ListAdviceAction.RequestId");
			listAdviceActionResponse.PageNumber = _ctx.IntegerValue("ListAdviceAction.PageNumber");
			listAdviceActionResponse.PageSize = _ctx.IntegerValue("ListAdviceAction.PageSize");
			listAdviceActionResponse.TotalCount = _ctx.IntegerValue("ListAdviceAction.TotalCount");

			List<ListAdviceActionResponse.ListAdviceAction_Item> listAdviceActionResponse_items = new List<ListAdviceActionResponse.ListAdviceAction_Item>();
			for (int i = 0; i < _ctx.Length("ListAdviceAction.Items.Length"); i++) {
				ListAdviceActionResponse.ListAdviceAction_Item item = new ListAdviceActionResponse.ListAdviceAction_Item();
				item.ConfigName = _ctx.StringValue("ListAdviceAction.Items["+ i +"].ConfigName");
				item.ConfigItemKey = _ctx.StringValue("ListAdviceAction.Items["+ i +"].ConfigItemKey");
				item.Command = _ctx.StringValue("ListAdviceAction.Items["+ i +"].Command");
				item.ClusterId = _ctx.StringValue("ListAdviceAction.Items["+ i +"].ClusterId");
				item.HostgroupName = _ctx.StringValue("ListAdviceAction.Items["+ i +"].HostgroupName");
				item.ServiceName = _ctx.StringValue("ListAdviceAction.Items["+ i +"].ServiceName");
				item.Component = _ctx.StringValue("ListAdviceAction.Items["+ i +"].Component");
				item.ActionType = _ctx.StringValue("ListAdviceAction.Items["+ i +"].ActionType");
				item.GmtCreate = _ctx.LongValue("ListAdviceAction.Items["+ i +"].GmtCreate");
				item.GmtModified = _ctx.LongValue("ListAdviceAction.Items["+ i +"].GmtModified");

				listAdviceActionResponse_items.Add(item);
			}
			listAdviceActionResponse.Items = listAdviceActionResponse_items;
        
			return listAdviceActionResponse;
        }
    }
}
