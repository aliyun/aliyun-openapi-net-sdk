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
using Aliyun.Acs.ComputeNestSupplier.Model.V20210521;

namespace Aliyun.Acs.ComputeNestSupplier.Transform.V20210521
{
    public class GetServiceResponseUnmarshaller
    {
        public static GetServiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetServiceResponse getServiceResponse = new GetServiceResponse();

			getServiceResponse.HttpResponse = _ctx.HttpResponse;
			getServiceResponse.Status = _ctx.StringValue("GetService.Status");
			getServiceResponse.DeployMetadata = _ctx.StringValue("GetService.DeployMetadata");
			getServiceResponse.PublishTime = _ctx.StringValue("GetService.PublishTime");
			getServiceResponse.RequestId = _ctx.StringValue("GetService.RequestId");
			getServiceResponse.Version = _ctx.StringValue("GetService.Version");
			getServiceResponse.DeployType = _ctx.StringValue("GetService.DeployType");
			getServiceResponse.ServiceId = _ctx.StringValue("GetService.ServiceId");
			getServiceResponse.SupplierUrl = _ctx.StringValue("GetService.SupplierUrl");
			getServiceResponse.ServiceDocUrl = _ctx.StringValue("GetService.ServiceDocUrl");
			getServiceResponse.ServiceProductUrl = _ctx.StringValue("GetService.ServiceProductUrl");
			getServiceResponse.ServiceType = _ctx.StringValue("GetService.ServiceType");
			getServiceResponse.SupplierName = _ctx.StringValue("GetService.SupplierName");
			getServiceResponse.CommodityCode = _ctx.StringValue("GetService.CommodityCode");
			getServiceResponse.IsSupportOperated = _ctx.BooleanValue("GetService.IsSupportOperated");
			getServiceResponse.PolicyNames = _ctx.StringValue("GetService.PolicyNames");
			getServiceResponse.Duration = _ctx.LongValue("GetService.Duration");
			getServiceResponse.Progress = _ctx.LongValue("GetService.Progress");
			getServiceResponse.StatusDetail = _ctx.StringValue("GetService.StatusDetail");
			getServiceResponse.CreateTime = _ctx.StringValue("GetService.CreateTime");
			getServiceResponse.UpdateTime = _ctx.StringValue("GetService.UpdateTime");
			getServiceResponse.ShareType = _ctx.StringValue("GetService.ShareType");
			getServiceResponse.AlarmMetadata = _ctx.StringValue("GetService.AlarmMetadata");
			getServiceResponse.UpgradeMetadata = _ctx.StringValue("GetService.UpgradeMetadata");
			getServiceResponse.VersionName = _ctx.StringValue("GetService.VersionName");
			getServiceResponse.PayFromType = _ctx.StringValue("GetService.PayFromType");
			getServiceResponse.PayType = _ctx.StringValue("GetService.PayType");
			getServiceResponse.DefaultLicenseDays = _ctx.LongValue("GetService.DefaultLicenseDays");
			getServiceResponse.TrialDuration = _ctx.LongValue("GetService.TrialDuration");
			getServiceResponse.TrialType = _ctx.StringValue("GetService.TrialType");
			getServiceResponse.TenantType = _ctx.StringValue("GetService.TenantType");
			getServiceResponse.LicenseMetadata = _ctx.StringValue("GetService.LicenseMetadata");
			getServiceResponse.OperationMetadata = _ctx.StringValue("GetService.OperationMetadata");
			getServiceResponse.TestStatus = _ctx.StringValue("GetService.TestStatus");
			getServiceResponse.ApprovalType = _ctx.StringValue("GetService.ApprovalType");
			getServiceResponse.RegistrationId = _ctx.StringValue("GetService.RegistrationId");
			getServiceResponse.ResourceGroupId = _ctx.StringValue("GetService.ResourceGroupId");
			getServiceResponse.Permission = _ctx.StringValue("GetService.Permission");

			List<GetServiceResponse.GetService_ServiceInfo> getServiceResponse_serviceInfos = new List<GetServiceResponse.GetService_ServiceInfo>();
			for (int i = 0; i < _ctx.Length("GetService.ServiceInfos.Length"); i++) {
				GetServiceResponse.GetService_ServiceInfo serviceInfo = new GetServiceResponse.GetService_ServiceInfo();
				serviceInfo.Locale = _ctx.StringValue("GetService.ServiceInfos["+ i +"].Locale");
				serviceInfo.Image = _ctx.StringValue("GetService.ServiceInfos["+ i +"].Image");
				serviceInfo.Name = _ctx.StringValue("GetService.ServiceInfos["+ i +"].Name");
				serviceInfo.ShortDescription = _ctx.StringValue("GetService.ServiceInfos["+ i +"].ShortDescription");

				getServiceResponse_serviceInfos.Add(serviceInfo);
			}
			getServiceResponse.ServiceInfos = getServiceResponse_serviceInfos;

			List<GetServiceResponse.GetService_CommoditySpecification> getServiceResponse_commoditySpecifications = new List<GetServiceResponse.GetService_CommoditySpecification>();
			for (int i = 0; i < _ctx.Length("GetService.CommoditySpecifications.Length"); i++) {
				GetServiceResponse.GetService_CommoditySpecification commoditySpecification = new GetServiceResponse.GetService_CommoditySpecification();
				commoditySpecification.SpecificationCode = _ctx.StringValue("GetService.CommoditySpecifications["+ i +"].SpecificationCode");
				commoditySpecification.TemplateName = _ctx.StringValue("GetService.CommoditySpecifications["+ i +"].TemplateName");
				commoditySpecification.PredefinedParameterName = _ctx.StringValue("GetService.CommoditySpecifications["+ i +"].PredefinedParameterName");

				getServiceResponse_commoditySpecifications.Add(commoditySpecification);
			}
			getServiceResponse.CommoditySpecifications = getServiceResponse_commoditySpecifications;

			List<GetServiceResponse.GetService_Tag> getServiceResponse_tags = new List<GetServiceResponse.GetService_Tag>();
			for (int i = 0; i < _ctx.Length("GetService.Tags.Length"); i++) {
				GetServiceResponse.GetService_Tag tag = new GetServiceResponse.GetService_Tag();
				tag.Key = _ctx.StringValue("GetService.Tags["+ i +"].Key");
				tag._Value = _ctx.StringValue("GetService.Tags["+ i +"].Value");

				getServiceResponse_tags.Add(tag);
			}
			getServiceResponse.Tags = getServiceResponse_tags;

			List<GetServiceResponse.GetService_CommodityEntitiesItem> getServiceResponse_commodityEntities = new List<GetServiceResponse.GetService_CommodityEntitiesItem>();
			for (int i = 0; i < _ctx.Length("GetService.CommodityEntities.Length"); i++) {
				GetServiceResponse.GetService_CommodityEntitiesItem commodityEntitiesItem = new GetServiceResponse.GetService_CommodityEntitiesItem();
				commodityEntitiesItem.TemplateName = _ctx.StringValue("GetService.CommodityEntities["+ i +"].TemplateName");
				commodityEntitiesItem.PredefinedParameterName = _ctx.StringValue("GetService.CommodityEntities["+ i +"].PredefinedParameterName");

				List<string> commodityEntitiesItem_entityIds = new List<string>();
				for (int j = 0; j < _ctx.Length("GetService.CommodityEntities["+ i +"].EntityIds.Length"); j++) {
					commodityEntitiesItem_entityIds.Add(_ctx.StringValue("GetService.CommodityEntities["+ i +"].EntityIds["+ j +"]"));
				}
				commodityEntitiesItem.EntityIds = commodityEntitiesItem_entityIds;

				getServiceResponse_commodityEntities.Add(commodityEntitiesItem);
			}
			getServiceResponse.CommodityEntities = getServiceResponse_commodityEntities;
        
			return getServiceResponse;
        }
    }
}
