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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class QueryNotifyResponseUnmarshaller
    {
        public static QueryNotifyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryNotifyResponse queryNotifyResponse = new QueryNotifyResponse();

			queryNotifyResponse.HttpResponse = _ctx.HttpResponse;
			queryNotifyResponse.RequestId = _ctx.StringValue("QueryNotify.RequestId");

			QueryNotifyResponse.QueryNotify_Data data = new QueryNotifyResponse.QueryNotify_Data();
			data.PageSize = _ctx.IntegerValue("QueryNotify.Data.PageSize");
			data.PageNumber = _ctx.IntegerValue("QueryNotify.Data.PageNumber");
			data.TotalRecordCount = _ctx.IntegerValue("QueryNotify.Data.TotalRecordCount");

			List<QueryNotifyResponse.QueryNotify_Data.QueryNotify_NotifyItemListItem> data_notifyItemList = new List<QueryNotifyResponse.QueryNotify_Data.QueryNotify_NotifyItemListItem>();
			for (int i = 0; i < _ctx.Length("QueryNotify.Data.NotifyItemList.Length"); i++) {
				QueryNotifyResponse.QueryNotify_Data.QueryNotify_NotifyItemListItem notifyItemListItem = new QueryNotifyResponse.QueryNotify_Data.QueryNotify_NotifyItemListItem();
				notifyItemListItem.Id = _ctx.LongValue("QueryNotify.Data.NotifyItemList["+ i +"].Id");
				notifyItemListItem.GmtCreated = _ctx.StringValue("QueryNotify.Data.NotifyItemList["+ i +"].GmtCreated");
				notifyItemListItem.GmtModified = _ctx.StringValue("QueryNotify.Data.NotifyItemList["+ i +"].GmtModified");
				notifyItemListItem.AliUid = _ctx.LongValue("QueryNotify.Data.NotifyItemList["+ i +"].AliUid");
				notifyItemListItem.IdempotentId = _ctx.StringValue("QueryNotify.Data.NotifyItemList["+ i +"].IdempotentId");
				notifyItemListItem.IdempotentCount = _ctx.StringValue("QueryNotify.Data.NotifyItemList["+ i +"].IdempotentCount");
				notifyItemListItem.Type = _ctx.StringValue("QueryNotify.Data.NotifyItemList["+ i +"].Type");
				notifyItemListItem.Level = _ctx.StringValue("QueryNotify.Data.NotifyItemList["+ i +"].Level");
				notifyItemListItem.TemplateName = _ctx.StringValue("QueryNotify.Data.NotifyItemList["+ i +"].TemplateName");
				notifyItemListItem.NotifyElement = _ctx.StringValue("QueryNotify.Data.NotifyItemList["+ i +"].NotifyElement");
				notifyItemListItem.ConfirmFlag = _ctx.BooleanValue("QueryNotify.Data.NotifyItemList["+ i +"].ConfirmFlag");
				notifyItemListItem.Confirmor = _ctx.LongValue("QueryNotify.Data.NotifyItemList["+ i +"].Confirmor");

				data_notifyItemList.Add(notifyItemListItem);
			}
			data.NotifyItemList = data_notifyItemList;
			queryNotifyResponse.Data = data;
        
			return queryNotifyResponse;
        }
    }
}
