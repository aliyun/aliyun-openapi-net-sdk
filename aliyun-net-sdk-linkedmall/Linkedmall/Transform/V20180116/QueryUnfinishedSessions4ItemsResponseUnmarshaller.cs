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
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class QueryUnfinishedSessions4ItemsResponseUnmarshaller
    {
        public static QueryUnfinishedSessions4ItemsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryUnfinishedSessions4ItemsResponse queryUnfinishedSessions4ItemsResponse = new QueryUnfinishedSessions4ItemsResponse();

			queryUnfinishedSessions4ItemsResponse.HttpResponse = context.HttpResponse;
			queryUnfinishedSessions4ItemsResponse.Code = context.StringValue("QueryUnfinishedSessions4Items.Code");
			queryUnfinishedSessions4ItemsResponse.Message = context.StringValue("QueryUnfinishedSessions4Items.Message");
			queryUnfinishedSessions4ItemsResponse.RequestId = context.StringValue("QueryUnfinishedSessions4Items.RequestId");

			List<QueryUnfinishedSessions4ItemsResponse.QueryUnfinishedSessions4Items_LmItemActivitySessionModelList> queryUnfinishedSessions4ItemsResponse_lmItemActivitySessionModelListList = new List<QueryUnfinishedSessions4ItemsResponse.QueryUnfinishedSessions4Items_LmItemActivitySessionModelList>();
			for (int i = 0; i < context.Length("QueryUnfinishedSessions4Items.LmItemActivitySessionModelListList.Length"); i++) {
				QueryUnfinishedSessions4ItemsResponse.QueryUnfinishedSessions4Items_LmItemActivitySessionModelList lmItemActivitySessionModelList = new QueryUnfinishedSessions4ItemsResponse.QueryUnfinishedSessions4Items_LmItemActivitySessionModelList();
				lmItemActivitySessionModelList.ItemId = context.LongValue("QueryUnfinishedSessions4Items.LmItemActivitySessionModelListList["+ i +"].ItemId");
				lmItemActivitySessionModelList.LmItemId = context.StringValue("QueryUnfinishedSessions4Items.LmItemActivitySessionModelListList["+ i +"].LmItemId");

				List<QueryUnfinishedSessions4ItemsResponse.QueryUnfinishedSessions4Items_LmItemActivitySessionModelList.QueryUnfinishedSessions4Items_LmActivitySessionModel> lmItemActivitySessionModelList_lmActivitySessionModels = new List<QueryUnfinishedSessions4ItemsResponse.QueryUnfinishedSessions4Items_LmItemActivitySessionModelList.QueryUnfinishedSessions4Items_LmActivitySessionModel>();
				for (int j = 0; j < context.Length("QueryUnfinishedSessions4Items.LmItemActivitySessionModelListList["+ i +"].LmActivitySessionModels.Length"); j++) {
					QueryUnfinishedSessions4ItemsResponse.QueryUnfinishedSessions4Items_LmItemActivitySessionModelList.QueryUnfinishedSessions4Items_LmActivitySessionModel lmActivitySessionModel = new QueryUnfinishedSessions4ItemsResponse.QueryUnfinishedSessions4Items_LmItemActivitySessionModelList.QueryUnfinishedSessions4Items_LmActivitySessionModel();
					lmActivitySessionModel.BizId = context.StringValue("QueryUnfinishedSessions4Items.LmItemActivitySessionModelListList["+ i +"].LmActivitySessionModels["+ j +"].BizId");
					lmActivitySessionModel.Description = context.StringValue("QueryUnfinishedSessions4Items.LmItemActivitySessionModelListList["+ i +"].LmActivitySessionModels["+ j +"].Description");
					lmActivitySessionModel.DisplayDate = context.StringValue("QueryUnfinishedSessions4Items.LmItemActivitySessionModelListList["+ i +"].LmActivitySessionModels["+ j +"].DisplayDate");
					lmActivitySessionModel.EndDate = context.StringValue("QueryUnfinishedSessions4Items.LmItemActivitySessionModelListList["+ i +"].LmActivitySessionModels["+ j +"].EndDate");
					lmActivitySessionModel.ExtInfo = context.StringValue("QueryUnfinishedSessions4Items.LmItemActivitySessionModelListList["+ i +"].LmActivitySessionModels["+ j +"].ExtInfo");
					lmActivitySessionModel.LmActivityId = context.LongValue("QueryUnfinishedSessions4Items.LmItemActivitySessionModelListList["+ i +"].LmActivitySessionModels["+ j +"].LmActivityId");
					lmActivitySessionModel.LmSessionId = context.LongValue("QueryUnfinishedSessions4Items.LmItemActivitySessionModelListList["+ i +"].LmActivitySessionModels["+ j +"].LmSessionId");
					lmActivitySessionModel.Name = context.StringValue("QueryUnfinishedSessions4Items.LmItemActivitySessionModelListList["+ i +"].LmActivitySessionModels["+ j +"].Name");
					lmActivitySessionModel.StartDate = context.StringValue("QueryUnfinishedSessions4Items.LmItemActivitySessionModelListList["+ i +"].LmActivitySessionModels["+ j +"].StartDate");
					lmActivitySessionModel.SubBizCode = context.StringValue("QueryUnfinishedSessions4Items.LmItemActivitySessionModelListList["+ i +"].LmActivitySessionModels["+ j +"].SubBizCode");

					lmItemActivitySessionModelList_lmActivitySessionModels.Add(lmActivitySessionModel);
				}
				lmItemActivitySessionModelList.LmActivitySessionModels = lmItemActivitySessionModelList_lmActivitySessionModels;

				queryUnfinishedSessions4ItemsResponse_lmItemActivitySessionModelListList.Add(lmItemActivitySessionModelList);
			}
			queryUnfinishedSessions4ItemsResponse.LmItemActivitySessionModelListList = queryUnfinishedSessions4ItemsResponse_lmItemActivitySessionModelListList;
        
			return queryUnfinishedSessions4ItemsResponse;
        }
    }
}
