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
using Aliyun.Acs.WebsiteBuild.Model.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Transform.V20250429
{
    public class ListAppInstancesResponseUnmarshaller
    {
        public static ListAppInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppInstancesResponse listAppInstancesResponse = new ListAppInstancesResponse();

			listAppInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listAppInstancesResponse.RequestId = _ctx.StringValue("ListAppInstances.RequestId");
			listAppInstancesResponse.DynamicCode = _ctx.StringValue("ListAppInstances.DynamicCode");
			listAppInstancesResponse.DynamicMessage = _ctx.StringValue("ListAppInstances.DynamicMessage");
			listAppInstancesResponse.Synchro = _ctx.BooleanValue("ListAppInstances.Synchro");
			listAppInstancesResponse.AccessDeniedDetail = _ctx.StringValue("ListAppInstances.AccessDeniedDetail");
			listAppInstancesResponse.RootErrorMsg = _ctx.StringValue("ListAppInstances.RootErrorMsg");
			listAppInstancesResponse.RootErrorCode = _ctx.StringValue("ListAppInstances.RootErrorCode");
			listAppInstancesResponse.CurrentPageNum = _ctx.IntegerValue("ListAppInstances.CurrentPageNum");
			listAppInstancesResponse.PageSize = _ctx.IntegerValue("ListAppInstances.PageSize");
			listAppInstancesResponse.TotalPageNum = _ctx.IntegerValue("ListAppInstances.TotalPageNum");
			listAppInstancesResponse.PrePage = _ctx.BooleanValue("ListAppInstances.PrePage");
			listAppInstancesResponse.NextPage = _ctx.BooleanValue("ListAppInstances.NextPage");
			listAppInstancesResponse.ResultLimit = _ctx.BooleanValue("ListAppInstances.ResultLimit");
			listAppInstancesResponse.AllowRetry = _ctx.BooleanValue("ListAppInstances.AllowRetry");
			listAppInstancesResponse.AppName = _ctx.StringValue("ListAppInstances.AppName");
			listAppInstancesResponse.NextToken = _ctx.StringValue("ListAppInstances.NextToken");
			listAppInstancesResponse.MaxResults = _ctx.IntegerValue("ListAppInstances.MaxResults");

			List<string> listAppInstancesResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("ListAppInstances.ErrorArgs.Length"); i++) {
				listAppInstancesResponse_errorArgs.Add(_ctx.StringValue("ListAppInstances.ErrorArgs["+ i +"]"));
			}
			listAppInstancesResponse.ErrorArgs = listAppInstancesResponse_errorArgs;

			List<ListAppInstancesResponse.ListAppInstances_DataItem> listAppInstancesResponse_data = new List<ListAppInstancesResponse.ListAppInstances_DataItem>();
			for (int i = 0; i < _ctx.Length("ListAppInstances.Data.Length"); i++) {
				ListAppInstancesResponse.ListAppInstances_DataItem dataItem = new ListAppInstancesResponse.ListAppInstances_DataItem();
				dataItem.CreateTime = _ctx.StringValue("ListAppInstances.Data["+ i +"].CreateTime");
				dataItem.GmtModified = _ctx.StringValue("ListAppInstances.Data["+ i +"].GmtModified");
				dataItem.BizId = _ctx.StringValue("ListAppInstances.Data["+ i +"].BizId");
				dataItem.Name = _ctx.StringValue("ListAppInstances.Data["+ i +"].Name");
				dataItem.UserId = _ctx.StringValue("ListAppInstances.Data["+ i +"].UserId");
				dataItem.AppType = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppType");
				dataItem.AppSubType = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppSubType");
				dataItem.BuildType = _ctx.StringValue("ListAppInstances.Data["+ i +"].BuildType");
				dataItem.Description = _ctx.StringValue("ListAppInstances.Data["+ i +"].Description");
				dataItem.IconUrl = _ctx.StringValue("ListAppInstances.Data["+ i +"].IconUrl");
				dataItem.ThumbnailUrl = _ctx.StringValue("ListAppInstances.Data["+ i +"].ThumbnailUrl");
				dataItem.Slug = _ctx.StringValue("ListAppInstances.Data["+ i +"].Slug");
				dataItem.Status = _ctx.StringValue("ListAppInstances.Data["+ i +"].Status");
				dataItem.StatusText = _ctx.StringValue("ListAppInstances.Data["+ i +"].StatusText");
				dataItem.DesignSpecId = _ctx.StringValue("ListAppInstances.Data["+ i +"].DesignSpecId");
				dataItem.GmtPublish = _ctx.StringValue("ListAppInstances.Data["+ i +"].GmtPublish");
				dataItem.GmtDelete = _ctx.StringValue("ListAppInstances.Data["+ i +"].GmtDelete");
				dataItem.StartTime = _ctx.StringValue("ListAppInstances.Data["+ i +"].StartTime");
				dataItem.EndTime = _ctx.StringValue("ListAppInstances.Data["+ i +"].EndTime");
				dataItem.Domain = _ctx.StringValue("ListAppInstances.Data["+ i +"].Domain");
				dataItem.SiteHost = _ctx.StringValue("ListAppInstances.Data["+ i +"].SiteHost");
				dataItem.EspBizId = _ctx.StringValue("ListAppInstances.Data["+ i +"].EspBizId");
				dataItem.Deleted = _ctx.IntegerValue("ListAppInstances.Data["+ i +"].Deleted");
				dataItem.DesignSpecBizId = _ctx.StringValue("ListAppInstances.Data["+ i +"].DesignSpecBizId");
				dataItem.SourceType = _ctx.StringValue("ListAppInstances.Data["+ i +"].SourceType");

				ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_Profile profile = new ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_Profile();
				profile.CommodityCode = _ctx.StringValue("ListAppInstances.Data["+ i +"].Profile.CommodityCode");
				profile.PayTime = _ctx.StringValue("ListAppInstances.Data["+ i +"].Profile.PayTime");
				profile.BizId = _ctx.StringValue("ListAppInstances.Data["+ i +"].Profile.BizId");
				profile.TemplateId = _ctx.StringValue("ListAppInstances.Data["+ i +"].Profile.TemplateId");
				profile.TemplateEtag = _ctx.StringValue("ListAppInstances.Data["+ i +"].Profile.TemplateEtag");
				profile.OrderId = _ctx.StringValue("ListAppInstances.Data["+ i +"].Profile.OrderId");
				profile.SeoSite = _ctx.StringValue("ListAppInstances.Data["+ i +"].Profile.SeoSite");
				profile.CustomerService = _ctx.StringValue("ListAppInstances.Data["+ i +"].Profile.CustomerService");
				profile.ApplicationType = _ctx.StringValue("ListAppInstances.Data["+ i +"].Profile.ApplicationType");
				profile.ApplicationTypeText = _ctx.StringValue("ListAppInstances.Data["+ i +"].Profile.ApplicationTypeText");
				profile.DeployArea = _ctx.StringValue("ListAppInstances.Data["+ i +"].Profile.DeployArea");
				profile.SiteVersion = _ctx.StringValue("ListAppInstances.Data["+ i +"].Profile.SiteVersion");
				profile.SiteVersionText = _ctx.StringValue("ListAppInstances.Data["+ i +"].Profile.SiteVersionText");
				profile.OrdTime = _ctx.StringValue("ListAppInstances.Data["+ i +"].Profile.OrdTime");
				profile.Source = _ctx.StringValue("ListAppInstances.Data["+ i +"].Profile.Source");
				profile.InstanceId = _ctx.StringValue("ListAppInstances.Data["+ i +"].Profile.InstanceId");
				dataItem.Profile = profile;

				ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppOperationAddress appOperationAddress = new ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppOperationAddress();

				List<ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppOperationAddress.ListAppInstances_ActionsItem3> appOperationAddress_actions2 = new List<ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppOperationAddress.ListAppInstances_ActionsItem3>();
				for (int j = 0; j < _ctx.Length("ListAppInstances.Data["+ i +"].AppOperationAddress.Actions.Length"); j++) {
					ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppOperationAddress.ListAppInstances_ActionsItem3 actionsItem3 = new ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppOperationAddress.ListAppInstances_ActionsItem3();
					actionsItem3.ActionKey = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppOperationAddress.Actions["+ j +"].ActionKey");
					actionsItem3.ActionText = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppOperationAddress.Actions["+ j +"].ActionText");
					actionsItem3.Href = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppOperationAddress.Actions["+ j +"].Href");
					actionsItem3.Enable = _ctx.BooleanValue("ListAppInstances.Data["+ i +"].AppOperationAddress.Actions["+ j +"].Enable");

					appOperationAddress_actions2.Add(actionsItem3);
				}
				appOperationAddress.Actions2 = appOperationAddress_actions2;
				dataItem.AppOperationAddress = appOperationAddress;

				List<ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AiStaffListItem> dataItem_aiStaffList = new List<ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AiStaffListItem>();
				for (int j = 0; j < _ctx.Length("ListAppInstances.Data["+ i +"].AiStaffList.Length"); j++) {
					ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AiStaffListItem aiStaffListItem = new ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AiStaffListItem();
					aiStaffListItem.StaffId = _ctx.StringValue("ListAppInstances.Data["+ i +"].AiStaffList["+ j +"].StaffId");
					aiStaffListItem.StaffName = _ctx.StringValue("ListAppInstances.Data["+ i +"].AiStaffList["+ j +"].StaffName");
					aiStaffListItem.StaffType = _ctx.StringValue("ListAppInstances.Data["+ i +"].AiStaffList["+ j +"].StaffType");
					aiStaffListItem.Status = _ctx.StringValue("ListAppInstances.Data["+ i +"].AiStaffList["+ j +"].Status");

					dataItem_aiStaffList.Add(aiStaffListItem);
				}
				dataItem.AiStaffList = dataItem_aiStaffList;

				List<ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppServiceListItem> dataItem_appServiceList = new List<ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppServiceListItem>();
				for (int j = 0; j < _ctx.Length("ListAppInstances.Data["+ i +"].AppServiceList.Length"); j++) {
					ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppServiceListItem appServiceListItem = new ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppServiceListItem();
					appServiceListItem.Name = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].Name");
					appServiceListItem.GmtCreate = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].GmtCreate");
					appServiceListItem.GmtModified = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].GmtModified");
					appServiceListItem.BizId = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].BizId");
					appServiceListItem.ServiceType = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].ServiceType");
					appServiceListItem.ServiceTypeText = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].ServiceTypeText");
					appServiceListItem.UserId = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].UserId");
					appServiceListItem.Status = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].Status");
					appServiceListItem.Deleted = _ctx.IntegerValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].Deleted");
					appServiceListItem.StartTime = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].StartTime");
					appServiceListItem.EndTime = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].EndTime");
					appServiceListItem.Slug = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].Slug");
					appServiceListItem.InstanceBizId = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].InstanceBizId");
					appServiceListItem.EspBizId = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].EspBizId");

					ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppServiceListItem.ListAppInstances_Profile1 profile1 = new ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppServiceListItem.ListAppInstances_Profile1();
					profile1.BizId = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].Profile.BizId");
					profile1.DesignType = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].Profile.DesignType");
					profile1.DesignTypeText = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].Profile.DesignTypeText");
					profile1.ServiceSpec = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].Profile.ServiceSpec");
					profile1.ServiceSpecText = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].Profile.ServiceSpecText");
					profile1.OrderId = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].Profile.OrderId");
					profile1.InstanceId = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].Profile.InstanceId");
					appServiceListItem.Profile1 = profile1;

					ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppServiceListItem.ListAppInstances_OperationAddress operationAddress = new ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppServiceListItem.ListAppInstances_OperationAddress();

					List<ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppServiceListItem.ListAppInstances_OperationAddress.ListAppInstances_ActionsItem> operationAddress_actions = new List<ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppServiceListItem.ListAppInstances_OperationAddress.ListAppInstances_ActionsItem>();
					for (int k = 0; k < _ctx.Length("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].OperationAddress.Actions.Length"); k++) {
						ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppServiceListItem.ListAppInstances_OperationAddress.ListAppInstances_ActionsItem actionsItem = new ListAppInstancesResponse.ListAppInstances_DataItem.ListAppInstances_AppServiceListItem.ListAppInstances_OperationAddress.ListAppInstances_ActionsItem();
						actionsItem.ActionKey = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].OperationAddress.Actions["+ k +"].ActionKey");
						actionsItem.ActionText = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].OperationAddress.Actions["+ k +"].ActionText");
						actionsItem.Href = _ctx.StringValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].OperationAddress.Actions["+ k +"].Href");
						actionsItem.Enable = _ctx.BooleanValue("ListAppInstances.Data["+ i +"].AppServiceList["+ j +"].OperationAddress.Actions["+ k +"].Enable");

						operationAddress_actions.Add(actionsItem);
					}
					operationAddress.Actions = operationAddress_actions;
					appServiceListItem.OperationAddress = operationAddress;

					dataItem_appServiceList.Add(appServiceListItem);
				}
				dataItem.AppServiceList = dataItem_appServiceList;

				listAppInstancesResponse_data.Add(dataItem);
			}
			listAppInstancesResponse.Data = listAppInstancesResponse_data;
        
			return listAppInstancesResponse;
        }
    }
}
