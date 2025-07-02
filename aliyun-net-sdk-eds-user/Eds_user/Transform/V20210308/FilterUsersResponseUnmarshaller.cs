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
using Aliyun.Acs.eds_user.Model.V20210308;

namespace Aliyun.Acs.eds_user.Transform.V20210308
{
    public class FilterUsersResponseUnmarshaller
    {
        public static FilterUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			FilterUsersResponse filterUsersResponse = new FilterUsersResponse();

			filterUsersResponse.HttpResponse = _ctx.HttpResponse;
			filterUsersResponse.RequestId = _ctx.StringValue("FilterUsers.RequestId");
			filterUsersResponse.NextToken = _ctx.StringValue("FilterUsers.NextToken");

			List<FilterUsersResponse.FilterUsers_Data> filterUsersResponse_users = new List<FilterUsersResponse.FilterUsers_Data>();
			for (int i = 0; i < _ctx.Length("FilterUsers.Users.Length"); i++) {
				FilterUsersResponse.FilterUsers_Data data = new FilterUsersResponse.FilterUsers_Data();
				data.Id = _ctx.LongValue("FilterUsers.Users["+ i +"].Id");
				data.EndUserId = _ctx.StringValue("FilterUsers.Users["+ i +"].EndUserId");
				data.Email = _ctx.StringValue("FilterUsers.Users["+ i +"].Email");
				data.Phone = _ctx.StringValue("FilterUsers.Users["+ i +"].Phone");
				data.Status = _ctx.LongValue("FilterUsers.Users["+ i +"].Status");
				data.DesktopCount = _ctx.LongValue("FilterUsers.Users["+ i +"].DesktopCount");
				data.DesktopGroupCount = _ctx.LongValue("FilterUsers.Users["+ i +"].DesktopGroupCount");
				data.OwnerType = _ctx.StringValue("FilterUsers.Users["+ i +"].OwnerType");
				data.Remark = _ctx.StringValue("FilterUsers.Users["+ i +"].Remark");
				data.IsTenantManager = _ctx.BooleanValue("FilterUsers.Users["+ i +"].IsTenantManager");
				data.EnableAdminAccess = _ctx.BooleanValue("FilterUsers.Users["+ i +"].EnableAdminAccess");
				data.RealNickName = _ctx.StringValue("FilterUsers.Users["+ i +"].RealNickName");
				data.AutoLockTime = _ctx.StringValue("FilterUsers.Users["+ i +"].AutoLockTime");
				data.PasswordExpireDays = _ctx.IntegerValue("FilterUsers.Users["+ i +"].PasswordExpireDays");
				data.PasswordExpireRestDays = _ctx.IntegerValue("FilterUsers.Users["+ i +"].PasswordExpireRestDays");

				FilterUsersResponse.FilterUsers_Data.FilterUsers_ExternalInfo externalInfo = new FilterUsersResponse.FilterUsers_Data.FilterUsers_ExternalInfo();
				externalInfo.ExternalName = _ctx.StringValue("FilterUsers.Users["+ i +"].ExternalInfo.ExternalName");
				externalInfo.JobNumber = _ctx.StringValue("FilterUsers.Users["+ i +"].ExternalInfo.JobNumber");
				data.ExternalInfo = externalInfo;

				List<FilterUsersResponse.FilterUsers_Data.FilterUsers_UserSetPropertiesModelsItem> data_userSetPropertiesModels = new List<FilterUsersResponse.FilterUsers_Data.FilterUsers_UserSetPropertiesModelsItem>();
				for (int j = 0; j < _ctx.Length("FilterUsers.Users["+ i +"].UserSetPropertiesModels.Length"); j++) {
					FilterUsersResponse.FilterUsers_Data.FilterUsers_UserSetPropertiesModelsItem userSetPropertiesModelsItem = new FilterUsersResponse.FilterUsers_Data.FilterUsers_UserSetPropertiesModelsItem();
					userSetPropertiesModelsItem.UserId = _ctx.LongValue("FilterUsers.Users["+ i +"].UserSetPropertiesModels["+ j +"].UserId");
					userSetPropertiesModelsItem.UserName = _ctx.StringValue("FilterUsers.Users["+ i +"].UserSetPropertiesModels["+ j +"].UserName");
					userSetPropertiesModelsItem.PropertyId = _ctx.LongValue("FilterUsers.Users["+ i +"].UserSetPropertiesModels["+ j +"].PropertyId");
					userSetPropertiesModelsItem.PropertyKey = _ctx.StringValue("FilterUsers.Users["+ i +"].UserSetPropertiesModels["+ j +"].PropertyKey");
					userSetPropertiesModelsItem.PropertyType = _ctx.IntegerValue("FilterUsers.Users["+ i +"].UserSetPropertiesModels["+ j +"].PropertyType");

					List<FilterUsersResponse.FilterUsers_Data.FilterUsers_UserSetPropertiesModelsItem.FilterUsers_PropertyValuesItem> userSetPropertiesModelsItem_propertyValues = new List<FilterUsersResponse.FilterUsers_Data.FilterUsers_UserSetPropertiesModelsItem.FilterUsers_PropertyValuesItem>();
					for (int k = 0; k < _ctx.Length("FilterUsers.Users["+ i +"].UserSetPropertiesModels["+ j +"].PropertyValues.Length"); k++) {
						FilterUsersResponse.FilterUsers_Data.FilterUsers_UserSetPropertiesModelsItem.FilterUsers_PropertyValuesItem propertyValuesItem = new FilterUsersResponse.FilterUsers_Data.FilterUsers_UserSetPropertiesModelsItem.FilterUsers_PropertyValuesItem();
						propertyValuesItem.PropertyValueId = _ctx.LongValue("FilterUsers.Users["+ i +"].UserSetPropertiesModels["+ j +"].PropertyValues["+ k +"].PropertyValueId");
						propertyValuesItem.PropertyValue = _ctx.StringValue("FilterUsers.Users["+ i +"].UserSetPropertiesModels["+ j +"].PropertyValues["+ k +"].PropertyValue");

						userSetPropertiesModelsItem_propertyValues.Add(propertyValuesItem);
					}
					userSetPropertiesModelsItem.PropertyValues = userSetPropertiesModelsItem_propertyValues;

					data_userSetPropertiesModels.Add(userSetPropertiesModelsItem);
				}
				data.UserSetPropertiesModels = data_userSetPropertiesModels;

				List<FilterUsersResponse.FilterUsers_Data.FilterUsers_OrgListItem> data_orgList = new List<FilterUsersResponse.FilterUsers_Data.FilterUsers_OrgListItem>();
				for (int j = 0; j < _ctx.Length("FilterUsers.Users["+ i +"].OrgList.Length"); j++) {
					FilterUsersResponse.FilterUsers_Data.FilterUsers_OrgListItem orgListItem = new FilterUsersResponse.FilterUsers_Data.FilterUsers_OrgListItem();
					orgListItem.OrgId = _ctx.StringValue("FilterUsers.Users["+ i +"].OrgList["+ j +"].OrgId");
					orgListItem.OrgName = _ctx.StringValue("FilterUsers.Users["+ i +"].OrgList["+ j +"].OrgName");
					orgListItem.OrgNamePath = _ctx.StringValue("FilterUsers.Users["+ i +"].OrgList["+ j +"].OrgNamePath");

					data_orgList.Add(orgListItem);
				}
				data.OrgList = data_orgList;

				List<FilterUsersResponse.FilterUsers_Data.FilterUsers_IdpInfo> data_supportLoginIdps = new List<FilterUsersResponse.FilterUsers_Data.FilterUsers_IdpInfo>();
				for (int j = 0; j < _ctx.Length("FilterUsers.Users["+ i +"].SupportLoginIdps.Length"); j++) {
					FilterUsersResponse.FilterUsers_Data.FilterUsers_IdpInfo idpInfo = new FilterUsersResponse.FilterUsers_Data.FilterUsers_IdpInfo();
					idpInfo.IdpId = _ctx.StringValue("FilterUsers.Users["+ i +"].SupportLoginIdps["+ j +"].IdpId");
					idpInfo.IdpName = _ctx.StringValue("FilterUsers.Users["+ i +"].SupportLoginIdps["+ j +"].IdpName");

					data_supportLoginIdps.Add(idpInfo);
				}
				data.SupportLoginIdps = data_supportLoginIdps;

				filterUsersResponse_users.Add(data);
			}
			filterUsersResponse.Users = filterUsersResponse_users;
        
			return filterUsersResponse;
        }
    }
}
