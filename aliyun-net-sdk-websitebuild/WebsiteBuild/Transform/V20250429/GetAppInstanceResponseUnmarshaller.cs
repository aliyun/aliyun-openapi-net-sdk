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
    public class GetAppInstanceResponseUnmarshaller
    {
        public static GetAppInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAppInstanceResponse getAppInstanceResponse = new GetAppInstanceResponse();

			getAppInstanceResponse.HttpResponse = _ctx.HttpResponse;
			getAppInstanceResponse.RequestId = _ctx.StringValue("GetAppInstance.RequestId");
			getAppInstanceResponse.DynamicCode = _ctx.StringValue("GetAppInstance.DynamicCode");
			getAppInstanceResponse.DynamicMessage = _ctx.StringValue("GetAppInstance.DynamicMessage");
			getAppInstanceResponse.Synchro = _ctx.BooleanValue("GetAppInstance.Synchro");
			getAppInstanceResponse.AccessDeniedDetail = _ctx.StringValue("GetAppInstance.AccessDeniedDetail");
			getAppInstanceResponse.RootErrorMsg = _ctx.StringValue("GetAppInstance.RootErrorMsg");
			getAppInstanceResponse.RootErrorCode = _ctx.StringValue("GetAppInstance.RootErrorCode");
			getAppInstanceResponse.AllowRetry = _ctx.BooleanValue("GetAppInstance.AllowRetry");
			getAppInstanceResponse.AppName = _ctx.StringValue("GetAppInstance.AppName");

			List<string> getAppInstanceResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("GetAppInstance.ErrorArgs.Length"); i++) {
				getAppInstanceResponse_errorArgs.Add(_ctx.StringValue("GetAppInstance.ErrorArgs["+ i +"]"));
			}
			getAppInstanceResponse.ErrorArgs = getAppInstanceResponse_errorArgs;

			GetAppInstanceResponse.GetAppInstance_Module module = new GetAppInstanceResponse.GetAppInstance_Module();
			module.CreateTime = _ctx.StringValue("GetAppInstance.Module.CreateTime");
			module.GmtModified = _ctx.StringValue("GetAppInstance.Module.GmtModified");
			module.BizId = _ctx.StringValue("GetAppInstance.Module.BizId");
			module.Name = _ctx.StringValue("GetAppInstance.Module.Name");
			module.UserId = _ctx.StringValue("GetAppInstance.Module.UserId");
			module.AppType = _ctx.StringValue("GetAppInstance.Module.AppType");
			module.AppSubType = _ctx.StringValue("GetAppInstance.Module.AppSubType");
			module.BuildType = _ctx.StringValue("GetAppInstance.Module.BuildType");
			module.Description = _ctx.StringValue("GetAppInstance.Module.Description");
			module.IconUrl = _ctx.StringValue("GetAppInstance.Module.IconUrl");
			module.ThumbnailUrl = _ctx.StringValue("GetAppInstance.Module.ThumbnailUrl");
			module.Slug = _ctx.StringValue("GetAppInstance.Module.Slug");
			module.Status = _ctx.StringValue("GetAppInstance.Module.Status");
			module.StatusText = _ctx.StringValue("GetAppInstance.Module.StatusText");
			module.DesignSpecId = _ctx.StringValue("GetAppInstance.Module.DesignSpecId");
			module.GmtPublish = _ctx.StringValue("GetAppInstance.Module.GmtPublish");
			module.GmtDelete = _ctx.StringValue("GetAppInstance.Module.GmtDelete");
			module.StartTime = _ctx.StringValue("GetAppInstance.Module.StartTime");
			module.EndTime = _ctx.StringValue("GetAppInstance.Module.EndTime");
			module.Domain = _ctx.StringValue("GetAppInstance.Module.Domain");
			module.SiteHost = _ctx.StringValue("GetAppInstance.Module.SiteHost");
			module.EspBizId = _ctx.StringValue("GetAppInstance.Module.EspBizId");
			module.Deleted = _ctx.IntegerValue("GetAppInstance.Module.Deleted");
			module.DesignSpecBizId = _ctx.StringValue("GetAppInstance.Module.DesignSpecBizId");
			module.SourceType = _ctx.StringValue("GetAppInstance.Module.SourceType");

			GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_Profile profile = new GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_Profile();
			profile.CommodityCode = _ctx.StringValue("GetAppInstance.Module.Profile.CommodityCode");
			profile.PayTime = _ctx.StringValue("GetAppInstance.Module.Profile.PayTime");
			profile.BizId = _ctx.StringValue("GetAppInstance.Module.Profile.BizId");
			profile.TemplateId = _ctx.StringValue("GetAppInstance.Module.Profile.TemplateId");
			profile.TemplateEtag = _ctx.StringValue("GetAppInstance.Module.Profile.TemplateEtag");
			profile.OrderId = _ctx.StringValue("GetAppInstance.Module.Profile.OrderId");
			profile.SeoSite = _ctx.StringValue("GetAppInstance.Module.Profile.SeoSite");
			profile.CustomerService = _ctx.StringValue("GetAppInstance.Module.Profile.CustomerService");
			profile.ApplicationType = _ctx.StringValue("GetAppInstance.Module.Profile.ApplicationType");
			profile.ApplicationTypeText = _ctx.StringValue("GetAppInstance.Module.Profile.ApplicationTypeText");
			profile.DeployArea = _ctx.StringValue("GetAppInstance.Module.Profile.DeployArea");
			profile.SiteVersion = _ctx.StringValue("GetAppInstance.Module.Profile.SiteVersion");
			profile.SiteVersionText = _ctx.StringValue("GetAppInstance.Module.Profile.SiteVersionText");
			profile.OrdTime = _ctx.StringValue("GetAppInstance.Module.Profile.OrdTime");
			profile.Source = _ctx.StringValue("GetAppInstance.Module.Profile.Source");
			profile.InstanceId = _ctx.StringValue("GetAppInstance.Module.Profile.InstanceId");
			module.Profile = profile;

			GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppOperationAddress appOperationAddress = new GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppOperationAddress();

			List<GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppOperationAddress.GetAppInstance_ActionsItem3> appOperationAddress_actions2 = new List<GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppOperationAddress.GetAppInstance_ActionsItem3>();
			for (int i = 0; i < _ctx.Length("GetAppInstance.Module.AppOperationAddress.Actions.Length"); i++) {
				GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppOperationAddress.GetAppInstance_ActionsItem3 actionsItem3 = new GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppOperationAddress.GetAppInstance_ActionsItem3();
				actionsItem3.ActionKey = _ctx.StringValue("GetAppInstance.Module.AppOperationAddress.Actions["+ i +"].ActionKey");
				actionsItem3.ActionText = _ctx.StringValue("GetAppInstance.Module.AppOperationAddress.Actions["+ i +"].ActionText");
				actionsItem3.Href = _ctx.StringValue("GetAppInstance.Module.AppOperationAddress.Actions["+ i +"].Href");
				actionsItem3.Enable = _ctx.BooleanValue("GetAppInstance.Module.AppOperationAddress.Actions["+ i +"].Enable");

				appOperationAddress_actions2.Add(actionsItem3);
			}
			appOperationAddress.Actions2 = appOperationAddress_actions2;
			module.AppOperationAddress = appOperationAddress;

			List<GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AiStaffListItem> module_aiStaffList = new List<GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AiStaffListItem>();
			for (int i = 0; i < _ctx.Length("GetAppInstance.Module.AiStaffList.Length"); i++) {
				GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AiStaffListItem aiStaffListItem = new GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AiStaffListItem();
				aiStaffListItem.StaffId = _ctx.StringValue("GetAppInstance.Module.AiStaffList["+ i +"].StaffId");
				aiStaffListItem.StaffName = _ctx.StringValue("GetAppInstance.Module.AiStaffList["+ i +"].StaffName");
				aiStaffListItem.StaffType = _ctx.StringValue("GetAppInstance.Module.AiStaffList["+ i +"].StaffType");
				aiStaffListItem.Status = _ctx.StringValue("GetAppInstance.Module.AiStaffList["+ i +"].Status");

				module_aiStaffList.Add(aiStaffListItem);
			}
			module.AiStaffList = module_aiStaffList;

			List<GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppServiceListItem> module_appServiceList = new List<GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppServiceListItem>();
			for (int i = 0; i < _ctx.Length("GetAppInstance.Module.AppServiceList.Length"); i++) {
				GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppServiceListItem appServiceListItem = new GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppServiceListItem();
				appServiceListItem.Name = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].Name");
				appServiceListItem.GmtCreate = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].GmtCreate");
				appServiceListItem.GmtModified = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].GmtModified");
				appServiceListItem.BizId = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].BizId");
				appServiceListItem.ServiceType = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].ServiceType");
				appServiceListItem.ServiceTypeText = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].ServiceTypeText");
				appServiceListItem.UserId = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].UserId");
				appServiceListItem.Status = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].Status");
				appServiceListItem.Deleted = _ctx.IntegerValue("GetAppInstance.Module.AppServiceList["+ i +"].Deleted");
				appServiceListItem.StartTime = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].StartTime");
				appServiceListItem.EndTime = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].EndTime");
				appServiceListItem.Slug = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].Slug");
				appServiceListItem.InstanceBizId = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].InstanceBizId");
				appServiceListItem.EspBizId = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].EspBizId");

				GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppServiceListItem.GetAppInstance_Profile1 profile1 = new GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppServiceListItem.GetAppInstance_Profile1();
				profile1.BizId = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].Profile.BizId");
				profile1.DesignType = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].Profile.DesignType");
				profile1.DesignTypeText = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].Profile.DesignTypeText");
				profile1.ServiceSpec = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].Profile.ServiceSpec");
				profile1.ServiceSpecText = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].Profile.ServiceSpecText");
				profile1.OrderId = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].Profile.OrderId");
				profile1.InstanceId = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].Profile.InstanceId");
				appServiceListItem.Profile1 = profile1;

				GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppServiceListItem.GetAppInstance_OperationAddress operationAddress = new GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppServiceListItem.GetAppInstance_OperationAddress();

				List<GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppServiceListItem.GetAppInstance_OperationAddress.GetAppInstance_ActionsItem> operationAddress_actions = new List<GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppServiceListItem.GetAppInstance_OperationAddress.GetAppInstance_ActionsItem>();
				for (int j = 0; j < _ctx.Length("GetAppInstance.Module.AppServiceList["+ i +"].OperationAddress.Actions.Length"); j++) {
					GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppServiceListItem.GetAppInstance_OperationAddress.GetAppInstance_ActionsItem actionsItem = new GetAppInstanceResponse.GetAppInstance_Module.GetAppInstance_AppServiceListItem.GetAppInstance_OperationAddress.GetAppInstance_ActionsItem();
					actionsItem.ActionKey = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].OperationAddress.Actions["+ j +"].ActionKey");
					actionsItem.ActionText = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].OperationAddress.Actions["+ j +"].ActionText");
					actionsItem.Href = _ctx.StringValue("GetAppInstance.Module.AppServiceList["+ i +"].OperationAddress.Actions["+ j +"].Href");
					actionsItem.Enable = _ctx.BooleanValue("GetAppInstance.Module.AppServiceList["+ i +"].OperationAddress.Actions["+ j +"].Enable");

					operationAddress_actions.Add(actionsItem);
				}
				operationAddress.Actions = operationAddress_actions;
				appServiceListItem.OperationAddress = operationAddress;

				module_appServiceList.Add(appServiceListItem);
			}
			module.AppServiceList = module_appServiceList;
			getAppInstanceResponse.Module = module;
        
			return getAppInstanceResponse;
        }
    }
}
