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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class GetAuditItemListResponseUnmarshaller
    {
        public static GetAuditItemListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAuditItemListResponse getAuditItemListResponse = new GetAuditItemListResponse();

			getAuditItemListResponse.HttpResponse = _ctx.HttpResponse;
			getAuditItemListResponse.RequestId = _ctx.StringValue("GetAuditItemList.RequestId");
			getAuditItemListResponse.CurrentPage = _ctx.LongValue("GetAuditItemList.CurrentPage");
			getAuditItemListResponse.PageSize = _ctx.LongValue("GetAuditItemList.PageSize");
			getAuditItemListResponse.TotalCount = _ctx.LongValue("GetAuditItemList.TotalCount");

			List<GetAuditItemListResponse.GetAuditItemList_ItemsItem> getAuditItemListResponse_items = new List<GetAuditItemListResponse.GetAuditItemList_ItemsItem>();
			for (int i = 0; i < _ctx.Length("GetAuditItemList.Items.Length"); i++) {
				GetAuditItemListResponse.GetAuditItemList_ItemsItem itemsItem = new GetAuditItemListResponse.GetAuditItemList_ItemsItem();
				itemsItem.Id = _ctx.LongValue("GetAuditItemList.Items["+ i +"].Id");
				itemsItem.Create = _ctx.StringValue("GetAuditItemList.Items["+ i +"].Create");
				itemsItem.Uid = _ctx.StringValue("GetAuditItemList.Items["+ i +"].Uid");
				itemsItem.SubUid = _ctx.StringValue("GetAuditItemList.Items["+ i +"].SubUid");
				itemsItem.BizType = _ctx.StringValue("GetAuditItemList.Items["+ i +"].BizType");
				itemsItem.RcpTs = _ctx.StringValue("GetAuditItemList.Items["+ i +"].RcpTs");
				itemsItem.RcpResult = _ctx.StringValue("GetAuditItemList.Items["+ i +"].RcpResult");
				itemsItem.RcpRiskType = _ctx.StringValue("GetAuditItemList.Items["+ i +"].RcpRiskType");
				itemsItem.CustomTs = _ctx.StringValue("GetAuditItemList.Items["+ i +"].CustomTs");
				itemsItem.CustomResult = _ctx.StringValue("GetAuditItemList.Items["+ i +"].CustomResult");
				itemsItem.CustomRiskType = _ctx.StringValue("GetAuditItemList.Items["+ i +"].CustomRiskType");
				itemsItem._Operator = _ctx.StringValue("GetAuditItemList.Items["+ i +"].Operator");
				itemsItem.TaskId = _ctx.StringValue("GetAuditItemList.Items["+ i +"].TaskId");
				itemsItem.DataId = _ctx.StringValue("GetAuditItemList.Items["+ i +"].DataId");
				itemsItem.Type = _ctx.StringValue("GetAuditItemList.Items["+ i +"].Type");
				itemsItem.Content = _ctx.StringValue("GetAuditItemList.Items["+ i +"].Content");
				itemsItem.Url = _ctx.StringValue("GetAuditItemList.Items["+ i +"].Url");
				itemsItem.Thumbnail = _ctx.StringValue("GetAuditItemList.Items["+ i +"].Thumbnail");

				getAuditItemListResponse_items.Add(itemsItem);
			}
			getAuditItemListResponse.Items = getAuditItemListResponse_items;
        
			return getAuditItemListResponse;
        }
    }
}
