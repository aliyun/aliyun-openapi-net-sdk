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
    public class QueryAvatarResponseUnmarshaller
    {
        public static QueryAvatarResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryAvatarResponse queryAvatarResponse = new QueryAvatarResponse();

			queryAvatarResponse.HttpResponse = _ctx.HttpResponse;
			queryAvatarResponse.RequestId = _ctx.StringValue("QueryAvatar.RequestId");
			queryAvatarResponse.Code = _ctx.StringValue("QueryAvatar.Code");
			queryAvatarResponse.Message = _ctx.StringValue("QueryAvatar.Message");
			queryAvatarResponse.Success = _ctx.BooleanValue("QueryAvatar.Success");

			QueryAvatarResponse.QueryAvatar_Data data = new QueryAvatarResponse.QueryAvatar_Data();
			data.Name = _ctx.StringValue("QueryAvatar.Data.Name");
			data.Description = _ctx.StringValue("QueryAvatar.Data.Description");
			data.Portrait = _ctx.StringValue("QueryAvatar.Data.Portrait");
			data.Image = _ctx.StringValue("QueryAvatar.Data.Image");
			data.AllLocateImages = _ctx.StringValue("QueryAvatar.Data.AllLocateImages");
			data.ModelType = _ctx.StringValue("QueryAvatar.Data.ModelType");
			data.AvatarType = _ctx.StringValue("QueryAvatar.Data.AvatarType");
			data.MakeStatus = _ctx.StringValue("QueryAvatar.Data.MakeStatus");
			data.MakeFailReason = _ctx.StringValue("QueryAvatar.Data.MakeFailReason");
			data.MakeStage = _ctx.StringValue("QueryAvatar.Data.MakeStage");

			QueryAvatarResponse.QueryAvatar_Data.QueryAvatar_SupportedResolutions supportedResolutions = new QueryAvatarResponse.QueryAvatar_Data.QueryAvatar_SupportedResolutions();

			List<QueryAvatarResponse.QueryAvatar_Data.QueryAvatar_SupportedResolutions.QueryAvatar_OfflineItem> supportedResolutions_offline = new List<QueryAvatarResponse.QueryAvatar_Data.QueryAvatar_SupportedResolutions.QueryAvatar_OfflineItem>();
			for (int i = 0; i < _ctx.Length("QueryAvatar.Data.SupportedResolutions.Offline.Length"); i++) {
				QueryAvatarResponse.QueryAvatar_Data.QueryAvatar_SupportedResolutions.QueryAvatar_OfflineItem offlineItem = new QueryAvatarResponse.QueryAvatar_Data.QueryAvatar_SupportedResolutions.QueryAvatar_OfflineItem();
				offlineItem.Width = _ctx.IntegerValue("QueryAvatar.Data.SupportedResolutions.Offline["+ i +"].Width");
				offlineItem.Height = _ctx.IntegerValue("QueryAvatar.Data.SupportedResolutions.Offline["+ i +"].Height");
				offlineItem.Desc = _ctx.StringValue("QueryAvatar.Data.SupportedResolutions.Offline["+ i +"].Desc");

				supportedResolutions_offline.Add(offlineItem);
			}
			supportedResolutions.Offline = supportedResolutions_offline;

			List<QueryAvatarResponse.QueryAvatar_Data.QueryAvatar_SupportedResolutions.QueryAvatar_OnlineItem> supportedResolutions_online = new List<QueryAvatarResponse.QueryAvatar_Data.QueryAvatar_SupportedResolutions.QueryAvatar_OnlineItem>();
			for (int i = 0; i < _ctx.Length("QueryAvatar.Data.SupportedResolutions.Online.Length"); i++) {
				QueryAvatarResponse.QueryAvatar_Data.QueryAvatar_SupportedResolutions.QueryAvatar_OnlineItem onlineItem = new QueryAvatarResponse.QueryAvatar_Data.QueryAvatar_SupportedResolutions.QueryAvatar_OnlineItem();
				onlineItem.Width = _ctx.IntegerValue("QueryAvatar.Data.SupportedResolutions.Online["+ i +"].Width");
				onlineItem.Height = _ctx.IntegerValue("QueryAvatar.Data.SupportedResolutions.Online["+ i +"].Height");
				onlineItem.Desc = _ctx.StringValue("QueryAvatar.Data.SupportedResolutions.Online["+ i +"].Desc");

				supportedResolutions_online.Add(onlineItem);
			}
			supportedResolutions.Online = supportedResolutions_online;
			data.SupportedResolutions = supportedResolutions;
			queryAvatarResponse.Data = data;
        
			return queryAvatarResponse;
        }
    }
}
