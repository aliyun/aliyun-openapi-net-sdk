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
using Aliyun.Acs.avatar.Model.V20220130;

namespace Aliyun.Acs.avatar.Transform.V20220130
{
    public class QueryAvatarListResponseUnmarshaller
    {
        public static QueryAvatarListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryAvatarListResponse queryAvatarListResponse = new QueryAvatarListResponse();

			queryAvatarListResponse.HttpResponse = _ctx.HttpResponse;
			queryAvatarListResponse.RequestId = _ctx.StringValue("QueryAvatarList.RequestId");
			queryAvatarListResponse.Code = _ctx.StringValue("QueryAvatarList.Code");
			queryAvatarListResponse.Message = _ctx.StringValue("QueryAvatarList.Message");
			queryAvatarListResponse.Success = _ctx.BooleanValue("QueryAvatarList.Success");

			QueryAvatarListResponse.QueryAvatarList_Data data = new QueryAvatarListResponse.QueryAvatarList_Data();
			data.TotalCount = _ctx.IntegerValue("QueryAvatarList.Data.TotalCount");
			data.PageNo = _ctx.IntegerValue("QueryAvatarList.Data.PageNo");
			data.PageSize = _ctx.IntegerValue("QueryAvatarList.Data.PageSize");
			data.TotalPage = _ctx.IntegerValue("QueryAvatarList.Data.TotalPage");

			List<QueryAvatarListResponse.QueryAvatarList_Data.QueryAvatarList_ListItem> data_list = new List<QueryAvatarListResponse.QueryAvatarList_Data.QueryAvatarList_ListItem>();
			for (int i = 0; i < _ctx.Length("QueryAvatarList.Data.List.Length"); i++) {
				QueryAvatarListResponse.QueryAvatarList_Data.QueryAvatarList_ListItem listItem = new QueryAvatarListResponse.QueryAvatarList_Data.QueryAvatarList_ListItem();
				listItem.Code = _ctx.StringValue("QueryAvatarList.Data.List["+ i +"].Code");
				listItem.Name = _ctx.StringValue("QueryAvatarList.Data.List["+ i +"].Name");
				listItem.Image = _ctx.StringValue("QueryAvatarList.Data.List["+ i +"].Image");
				listItem.Portrait = _ctx.StringValue("QueryAvatarList.Data.List["+ i +"].Portrait");
				listItem.Description = _ctx.StringValue("QueryAvatarList.Data.List["+ i +"].Description");
				listItem.AvatarType = _ctx.StringValue("QueryAvatarList.Data.List["+ i +"].AvatarType");
				listItem.ModelType = _ctx.StringValue("QueryAvatarList.Data.List["+ i +"].ModelType");
				listItem.MakeStatus = _ctx.StringValue("QueryAvatarList.Data.List["+ i +"].MakeStatus");
				listItem.MakeFailReason = _ctx.StringValue("QueryAvatarList.Data.List["+ i +"].MakeFailReason");
				listItem.MakeStage = _ctx.StringValue("QueryAvatarList.Data.List["+ i +"].MakeStage");
				listItem.Preview = _ctx.StringValue("QueryAvatarList.Data.List["+ i +"].Preview");

				QueryAvatarListResponse.QueryAvatarList_Data.QueryAvatarList_ListItem.QueryAvatarList_SupportedResolutions supportedResolutions = new QueryAvatarListResponse.QueryAvatarList_Data.QueryAvatarList_ListItem.QueryAvatarList_SupportedResolutions();

				List<QueryAvatarListResponse.QueryAvatarList_Data.QueryAvatarList_ListItem.QueryAvatarList_SupportedResolutions.QueryAvatarList_OfflineItem> supportedResolutions_offline = new List<QueryAvatarListResponse.QueryAvatarList_Data.QueryAvatarList_ListItem.QueryAvatarList_SupportedResolutions.QueryAvatarList_OfflineItem>();
				for (int j = 0; j < _ctx.Length("QueryAvatarList.Data.List["+ i +"].SupportedResolutions.Offline.Length"); j++) {
					QueryAvatarListResponse.QueryAvatarList_Data.QueryAvatarList_ListItem.QueryAvatarList_SupportedResolutions.QueryAvatarList_OfflineItem offlineItem = new QueryAvatarListResponse.QueryAvatarList_Data.QueryAvatarList_ListItem.QueryAvatarList_SupportedResolutions.QueryAvatarList_OfflineItem();
					offlineItem.Width = _ctx.IntegerValue("QueryAvatarList.Data.List["+ i +"].SupportedResolutions.Offline["+ j +"].Width");
					offlineItem.Height = _ctx.IntegerValue("QueryAvatarList.Data.List["+ i +"].SupportedResolutions.Offline["+ j +"].Height");
					offlineItem.Desc = _ctx.StringValue("QueryAvatarList.Data.List["+ i +"].SupportedResolutions.Offline["+ j +"].Desc");

					supportedResolutions_offline.Add(offlineItem);
				}
				supportedResolutions.Offline = supportedResolutions_offline;

				List<QueryAvatarListResponse.QueryAvatarList_Data.QueryAvatarList_ListItem.QueryAvatarList_SupportedResolutions.QueryAvatarList_OnlineItem> supportedResolutions_online = new List<QueryAvatarListResponse.QueryAvatarList_Data.QueryAvatarList_ListItem.QueryAvatarList_SupportedResolutions.QueryAvatarList_OnlineItem>();
				for (int j = 0; j < _ctx.Length("QueryAvatarList.Data.List["+ i +"].SupportedResolutions.Online.Length"); j++) {
					QueryAvatarListResponse.QueryAvatarList_Data.QueryAvatarList_ListItem.QueryAvatarList_SupportedResolutions.QueryAvatarList_OnlineItem onlineItem = new QueryAvatarListResponse.QueryAvatarList_Data.QueryAvatarList_ListItem.QueryAvatarList_SupportedResolutions.QueryAvatarList_OnlineItem();
					onlineItem.Width = _ctx.IntegerValue("QueryAvatarList.Data.List["+ i +"].SupportedResolutions.Online["+ j +"].Width");
					onlineItem.Height = _ctx.IntegerValue("QueryAvatarList.Data.List["+ i +"].SupportedResolutions.Online["+ j +"].Height");
					onlineItem.Desc = _ctx.StringValue("QueryAvatarList.Data.List["+ i +"].SupportedResolutions.Online["+ j +"].Desc");

					supportedResolutions_online.Add(onlineItem);
				}
				supportedResolutions.Online = supportedResolutions_online;
				listItem.SupportedResolutions = supportedResolutions;

				data_list.Add(listItem);
			}
			data.List = data_list;
			queryAvatarListResponse.Data = data;
        
			return queryAvatarListResponse;
        }
    }
}
