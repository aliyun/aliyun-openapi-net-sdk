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
    public class ListItemActivitiesResponseUnmarshaller
    {
        public static ListItemActivitiesResponse Unmarshall(UnmarshallerContext context)
        {
			ListItemActivitiesResponse listItemActivitiesResponse = new ListItemActivitiesResponse();

			listItemActivitiesResponse.HttpResponse = context.HttpResponse;
			listItemActivitiesResponse.Code = context.StringValue("ListItemActivities.Code");
			listItemActivitiesResponse.Message = context.StringValue("ListItemActivities.Message");
			listItemActivitiesResponse.RequestId = context.StringValue("ListItemActivities.RequestId");

			List<ListItemActivitiesResponse.ListItemActivities_LmItemActivityModel> listItemActivitiesResponse_lmItemActivityModelList = new List<ListItemActivitiesResponse.ListItemActivities_LmItemActivityModel>();
			for (int i = 0; i < context.Length("ListItemActivities.LmItemActivityModelList.Length"); i++) {
				ListItemActivitiesResponse.ListItemActivities_LmItemActivityModel lmItemActivityModel = new ListItemActivitiesResponse.ListItemActivities_LmItemActivityModel();
				lmItemActivityModel.ItemId = context.LongValue("ListItemActivities.LmItemActivityModelList["+ i +"].ItemId");
				lmItemActivityModel.LmItemId = context.StringValue("ListItemActivities.LmItemActivityModelList["+ i +"].LmItemId");

				ListItemActivitiesResponse.ListItemActivities_LmItemActivityModel.ListItemActivities_LmActivityPopModel lmActivityPopModel = new ListItemActivitiesResponse.ListItemActivities_LmItemActivityModel.ListItemActivities_LmActivityPopModel();
				lmActivityPopModel.Id = context.LongValue("ListItemActivities.LmItemActivityModelList["+ i +"].LmActivityPopModel.Id");
				lmActivityPopModel.BizId = context.StringValue("ListItemActivities.LmItemActivityModelList["+ i +"].LmActivityPopModel.BizId");
				lmActivityPopModel.SubBizCode = context.StringValue("ListItemActivities.LmItemActivityModelList["+ i +"].LmActivityPopModel.SubBizCode");
				lmActivityPopModel.Title = context.StringValue("ListItemActivities.LmItemActivityModelList["+ i +"].LmActivityPopModel.Title");
				lmActivityPopModel.DisplayDate = context.StringValue("ListItemActivities.LmItemActivityModelList["+ i +"].LmActivityPopModel.DisplayDate");
				lmActivityPopModel.StartDate = context.StringValue("ListItemActivities.LmItemActivityModelList["+ i +"].LmActivityPopModel.StartDate");
				lmActivityPopModel.EndDate = context.StringValue("ListItemActivities.LmItemActivityModelList["+ i +"].LmActivityPopModel.EndDate");
				lmActivityPopModel.ExtInfo = context.StringValue("ListItemActivities.LmItemActivityModelList["+ i +"].LmActivityPopModel.ExtInfo");
				lmItemActivityModel.LmActivityPopModel = lmActivityPopModel;

				listItemActivitiesResponse_lmItemActivityModelList.Add(lmItemActivityModel);
			}
			listItemActivitiesResponse.LmItemActivityModelList = listItemActivitiesResponse_lmItemActivityModelList;
        
			return listItemActivitiesResponse;
        }
    }
}
