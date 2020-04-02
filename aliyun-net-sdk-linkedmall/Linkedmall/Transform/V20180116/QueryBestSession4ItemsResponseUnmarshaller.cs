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
    public class QueryBestSession4ItemsResponseUnmarshaller
    {
        public static QueryBestSession4ItemsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryBestSession4ItemsResponse queryBestSession4ItemsResponse = new QueryBestSession4ItemsResponse();

			queryBestSession4ItemsResponse.HttpResponse = context.HttpResponse;
			queryBestSession4ItemsResponse.Code = context.StringValue("QueryBestSession4Items.Code");
			queryBestSession4ItemsResponse.Message = context.StringValue("QueryBestSession4Items.Message");
			queryBestSession4ItemsResponse.RequestId = context.StringValue("QueryBestSession4Items.RequestId");

			List<QueryBestSession4ItemsResponse.QueryBestSession4Items_LmItemActivitySessionModel> queryBestSession4ItemsResponse_lmItemActivitySessionModelList = new List<QueryBestSession4ItemsResponse.QueryBestSession4Items_LmItemActivitySessionModel>();
			for (int i = 0; i < context.Length("QueryBestSession4Items.LmItemActivitySessionModelList.Length"); i++) {
				QueryBestSession4ItemsResponse.QueryBestSession4Items_LmItemActivitySessionModel lmItemActivitySessionModel = new QueryBestSession4ItemsResponse.QueryBestSession4Items_LmItemActivitySessionModel();
				lmItemActivitySessionModel.ItemId = context.LongValue("QueryBestSession4Items.LmItemActivitySessionModelList["+ i +"].ItemId");
				lmItemActivitySessionModel.LmItemId = context.StringValue("QueryBestSession4Items.LmItemActivitySessionModelList["+ i +"].LmItemId");

				QueryBestSession4ItemsResponse.QueryBestSession4Items_LmItemActivitySessionModel.QueryBestSession4Items_LmActivitySessionModel lmActivitySessionModel = new QueryBestSession4ItemsResponse.QueryBestSession4Items_LmItemActivitySessionModel.QueryBestSession4Items_LmActivitySessionModel();
				lmActivitySessionModel.BizId = context.StringValue("QueryBestSession4Items.LmItemActivitySessionModelList["+ i +"].LmActivitySessionModel.BizId");
				lmActivitySessionModel.Description = context.StringValue("QueryBestSession4Items.LmItemActivitySessionModelList["+ i +"].LmActivitySessionModel.Description");
				lmActivitySessionModel.DisplayDate = context.StringValue("QueryBestSession4Items.LmItemActivitySessionModelList["+ i +"].LmActivitySessionModel.DisplayDate");
				lmActivitySessionModel.EndDate = context.StringValue("QueryBestSession4Items.LmItemActivitySessionModelList["+ i +"].LmActivitySessionModel.EndDate");
				lmActivitySessionModel.ExtInfo = context.StringValue("QueryBestSession4Items.LmItemActivitySessionModelList["+ i +"].LmActivitySessionModel.ExtInfo");
				lmActivitySessionModel.LmActivityId = context.LongValue("QueryBestSession4Items.LmItemActivitySessionModelList["+ i +"].LmActivitySessionModel.LmActivityId");
				lmActivitySessionModel.LmSessionId = context.LongValue("QueryBestSession4Items.LmItemActivitySessionModelList["+ i +"].LmActivitySessionModel.LmSessionId");
				lmActivitySessionModel.Name = context.StringValue("QueryBestSession4Items.LmItemActivitySessionModelList["+ i +"].LmActivitySessionModel.Name");
				lmActivitySessionModel.StartDate = context.StringValue("QueryBestSession4Items.LmItemActivitySessionModelList["+ i +"].LmActivitySessionModel.StartDate");
				lmActivitySessionModel.SubBizCode = context.StringValue("QueryBestSession4Items.LmItemActivitySessionModelList["+ i +"].LmActivitySessionModel.SubBizCode");
				lmItemActivitySessionModel.LmActivitySessionModel = lmActivitySessionModel;

				queryBestSession4ItemsResponse_lmItemActivitySessionModelList.Add(lmItemActivitySessionModel);
			}
			queryBestSession4ItemsResponse.LmItemActivitySessionModelList = queryBestSession4ItemsResponse_lmItemActivitySessionModelList;
        
			return queryBestSession4ItemsResponse;
        }
    }
}
