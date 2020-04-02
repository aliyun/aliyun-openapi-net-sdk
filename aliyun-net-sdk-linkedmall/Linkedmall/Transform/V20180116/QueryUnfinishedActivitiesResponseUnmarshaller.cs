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
    public class QueryUnfinishedActivitiesResponseUnmarshaller
    {
        public static QueryUnfinishedActivitiesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryUnfinishedActivitiesResponse queryUnfinishedActivitiesResponse = new QueryUnfinishedActivitiesResponse();

			queryUnfinishedActivitiesResponse.HttpResponse = context.HttpResponse;
			queryUnfinishedActivitiesResponse.Code = context.StringValue("QueryUnfinishedActivities.Code");
			queryUnfinishedActivitiesResponse.Message = context.StringValue("QueryUnfinishedActivities.Message");
			queryUnfinishedActivitiesResponse.RequestId = context.StringValue("QueryUnfinishedActivities.RequestId");
			queryUnfinishedActivitiesResponse.PageSize = context.LongValue("QueryUnfinishedActivities.PageSize");
			queryUnfinishedActivitiesResponse.PageNumber = context.LongValue("QueryUnfinishedActivities.PageNumber");
			queryUnfinishedActivitiesResponse.TotalCount = context.LongValue("QueryUnfinishedActivities.TotalCount");

			List<QueryUnfinishedActivitiesResponse.QueryUnfinishedActivities_LmActivityModelV2Ext> queryUnfinishedActivitiesResponse_lmActivityModelExtList = new List<QueryUnfinishedActivitiesResponse.QueryUnfinishedActivities_LmActivityModelV2Ext>();
			for (int i = 0; i < context.Length("QueryUnfinishedActivities.LmActivityModelExtList.Length"); i++) {
				QueryUnfinishedActivitiesResponse.QueryUnfinishedActivities_LmActivityModelV2Ext lmActivityModelV2Ext = new QueryUnfinishedActivitiesResponse.QueryUnfinishedActivities_LmActivityModelV2Ext();
				lmActivityModelV2Ext.StartDate = context.StringValue("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].StartDate");
				lmActivityModelV2Ext.Name = context.StringValue("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].Name");
				lmActivityModelV2Ext.LmActivityId = context.LongValue("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].LmActivityId");
				lmActivityModelV2Ext.EndDate = context.StringValue("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].EndDate");
				lmActivityModelV2Ext.Description = context.StringValue("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].Description");
				lmActivityModelV2Ext.BizId = context.StringValue("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].BizId");
				lmActivityModelV2Ext.ActivityPicUrl = context.StringValue("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].ActivityPicUrl");

				List<QueryUnfinishedActivitiesResponse.QueryUnfinishedActivities_LmActivityModelV2Ext.QueryUnfinishedActivities_LmActivitySessionModel> lmActivityModelV2Ext_lmActivitySessionModels = new List<QueryUnfinishedActivitiesResponse.QueryUnfinishedActivities_LmActivityModelV2Ext.QueryUnfinishedActivities_LmActivitySessionModel>();
				for (int j = 0; j < context.Length("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].LmActivitySessionModels.Length"); j++) {
					QueryUnfinishedActivitiesResponse.QueryUnfinishedActivities_LmActivityModelV2Ext.QueryUnfinishedActivities_LmActivitySessionModel lmActivitySessionModel = new QueryUnfinishedActivitiesResponse.QueryUnfinishedActivities_LmActivityModelV2Ext.QueryUnfinishedActivities_LmActivitySessionModel();
					lmActivitySessionModel.LmActivityId = context.LongValue("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].LmActivitySessionModels["+ j +"].LmActivityId");
					lmActivitySessionModel.LmSessionId = context.LongValue("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].LmActivitySessionModels["+ j +"].LmSessionId");
					lmActivitySessionModel.Name = context.StringValue("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].LmActivitySessionModels["+ j +"].Name");
					lmActivitySessionModel.Description = context.StringValue("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].LmActivitySessionModels["+ j +"].Description");
					lmActivitySessionModel.BizId = context.StringValue("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].LmActivitySessionModels["+ j +"].BizId");
					lmActivitySessionModel.SubBizCode = context.StringValue("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].LmActivitySessionModels["+ j +"].SubBizCode");
					lmActivitySessionModel.DisplayDate = context.StringValue("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].LmActivitySessionModels["+ j +"].DisplayDate");
					lmActivitySessionModel.StartDate = context.StringValue("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].LmActivitySessionModels["+ j +"].StartDate");
					lmActivitySessionModel.EndDate = context.StringValue("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].LmActivitySessionModels["+ j +"].EndDate");
					lmActivitySessionModel.ExtInfo = context.StringValue("QueryUnfinishedActivities.LmActivityModelExtList["+ i +"].LmActivitySessionModels["+ j +"].ExtInfo");

					lmActivityModelV2Ext_lmActivitySessionModels.Add(lmActivitySessionModel);
				}
				lmActivityModelV2Ext.LmActivitySessionModels = lmActivityModelV2Ext_lmActivitySessionModels;

				queryUnfinishedActivitiesResponse_lmActivityModelExtList.Add(lmActivityModelV2Ext);
			}
			queryUnfinishedActivitiesResponse.LmActivityModelExtList = queryUnfinishedActivitiesResponse_lmActivityModelExtList;
        
			return queryUnfinishedActivitiesResponse;
        }
    }
}
