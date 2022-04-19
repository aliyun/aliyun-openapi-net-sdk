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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class QueryGroupedSecurityEventMarkMissListResponseUnmarshaller
    {
        public static QueryGroupedSecurityEventMarkMissListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryGroupedSecurityEventMarkMissListResponse queryGroupedSecurityEventMarkMissListResponse = new QueryGroupedSecurityEventMarkMissListResponse();

			queryGroupedSecurityEventMarkMissListResponse.HttpResponse = _ctx.HttpResponse;
			queryGroupedSecurityEventMarkMissListResponse.Success = _ctx.BooleanValue("QueryGroupedSecurityEventMarkMissList.Success");
			queryGroupedSecurityEventMarkMissListResponse.Code = _ctx.StringValue("QueryGroupedSecurityEventMarkMissList.Code");
			queryGroupedSecurityEventMarkMissListResponse.Message = _ctx.StringValue("QueryGroupedSecurityEventMarkMissList.Message");
			queryGroupedSecurityEventMarkMissListResponse.RequestId = _ctx.StringValue("QueryGroupedSecurityEventMarkMissList.RequestId");
			queryGroupedSecurityEventMarkMissListResponse.HttpStatusCode = _ctx.IntegerValue("QueryGroupedSecurityEventMarkMissList.HttpStatusCode");
			queryGroupedSecurityEventMarkMissListResponse.TimeCost = _ctx.LongValue("QueryGroupedSecurityEventMarkMissList.TimeCost");

			QueryGroupedSecurityEventMarkMissListResponse.QueryGroupedSecurityEventMarkMissList_PageInfo pageInfo = new QueryGroupedSecurityEventMarkMissListResponse.QueryGroupedSecurityEventMarkMissList_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("QueryGroupedSecurityEventMarkMissList.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("QueryGroupedSecurityEventMarkMissList.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("QueryGroupedSecurityEventMarkMissList.PageInfo.TotalCount");
			pageInfo.Count = _ctx.IntegerValue("QueryGroupedSecurityEventMarkMissList.PageInfo.Count");
			queryGroupedSecurityEventMarkMissListResponse.PageInfo = pageInfo;

			List<QueryGroupedSecurityEventMarkMissListResponse.QueryGroupedSecurityEventMarkMissList_ListItem> queryGroupedSecurityEventMarkMissListResponse_list = new List<QueryGroupedSecurityEventMarkMissListResponse.QueryGroupedSecurityEventMarkMissList_ListItem>();
			for (int i = 0; i < _ctx.Length("QueryGroupedSecurityEventMarkMissList.List.Length"); i++) {
				QueryGroupedSecurityEventMarkMissListResponse.QueryGroupedSecurityEventMarkMissList_ListItem listItem = new QueryGroupedSecurityEventMarkMissListResponse.QueryGroupedSecurityEventMarkMissList_ListItem();
				listItem.GmtCreate = _ctx.LongValue("QueryGroupedSecurityEventMarkMissList.List["+ i +"].GmtCreate");
				listItem.GmtModified = _ctx.LongValue("QueryGroupedSecurityEventMarkMissList.List["+ i +"].GmtModified");
				listItem.AliUid = _ctx.LongValue("QueryGroupedSecurityEventMarkMissList.List["+ i +"].AliUid");
				listItem.EventType = _ctx.StringValue("QueryGroupedSecurityEventMarkMissList.List["+ i +"].EventType");
				listItem.EventTypeOriginal = _ctx.StringValue("QueryGroupedSecurityEventMarkMissList.List["+ i +"].EventTypeOriginal");
				listItem.EventName = _ctx.StringValue("QueryGroupedSecurityEventMarkMissList.List["+ i +"].EventName");
				listItem.EventNameOriginal = _ctx.StringValue("QueryGroupedSecurityEventMarkMissList.List["+ i +"].EventNameOriginal");
				listItem.Uuids = _ctx.StringValue("QueryGroupedSecurityEventMarkMissList.List["+ i +"].Uuids");
				listItem.Field = _ctx.StringValue("QueryGroupedSecurityEventMarkMissList.List["+ i +"].Field");
				listItem.FiledAliasName = _ctx.StringValue("QueryGroupedSecurityEventMarkMissList.List["+ i +"].FiledAliasName");
				listItem.FieldValue = _ctx.StringValue("QueryGroupedSecurityEventMarkMissList.List["+ i +"].FieldValue");
				listItem.Operate = _ctx.StringValue("QueryGroupedSecurityEventMarkMissList.List["+ i +"].Operate");

				queryGroupedSecurityEventMarkMissListResponse_list.Add(listItem);
			}
			queryGroupedSecurityEventMarkMissListResponse.List = queryGroupedSecurityEventMarkMissListResponse_list;
        
			return queryGroupedSecurityEventMarkMissListResponse;
        }
    }
}
