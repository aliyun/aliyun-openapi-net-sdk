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
    public class ListServicesResponseUnmarshaller
    {
        public static ListServicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListServicesResponse listServicesResponse = new ListServicesResponse();

			listServicesResponse.HttpResponse = _ctx.HttpResponse;
			listServicesResponse.NextToken = _ctx.StringValue("ListServices.NextToken");
			listServicesResponse.RequestId = _ctx.StringValue("ListServices.RequestId");
			listServicesResponse.TotalCount = _ctx.StringValue("ListServices.TotalCount");
			listServicesResponse.MaxResults = _ctx.IntegerValue("ListServices.MaxResults");

			List<ListServicesResponse.ListServices_Service> listServicesResponse_services = new List<ListServicesResponse.ListServices_Service>();
			for (int i = 0; i < _ctx.Length("ListServices.Services.Length"); i++) {
				ListServicesResponse.ListServices_Service service = new ListServicesResponse.ListServices_Service();
				service.Status = _ctx.StringValue("ListServices.Services["+ i +"].Status");
				service.DefaultVersion = _ctx.BooleanValue("ListServices.Services["+ i +"].DefaultVersion");
				service.PublishTime = _ctx.StringValue("ListServices.Services["+ i +"].PublishTime");
				service.Version = _ctx.StringValue("ListServices.Services["+ i +"].Version");
				service.DeployType = _ctx.StringValue("ListServices.Services["+ i +"].DeployType");
				service.ServiceId = _ctx.StringValue("ListServices.Services["+ i +"].ServiceId");
				service.SupplierUrl = _ctx.StringValue("ListServices.Services["+ i +"].SupplierUrl");
				service.ServiceType = _ctx.StringValue("ListServices.Services["+ i +"].ServiceType");
				service.SupplierName = _ctx.StringValue("ListServices.Services["+ i +"].SupplierName");
				service.CommodityCode = _ctx.StringValue("ListServices.Services["+ i +"].CommodityCode");
				service.CreateTime = _ctx.StringValue("ListServices.Services["+ i +"].CreateTime");
				service.UpdateTime = _ctx.StringValue("ListServices.Services["+ i +"].UpdateTime");
				service.ShareType = _ctx.StringValue("ListServices.Services["+ i +"].ShareType");
				service.ApprovalType = _ctx.StringValue("ListServices.Services["+ i +"].ApprovalType");
				service.VersionName = _ctx.StringValue("ListServices.Services["+ i +"].VersionName");
				service.ArtifactId = _ctx.StringValue("ListServices.Services["+ i +"].ArtifactId");
				service.ArtifactVersion = _ctx.StringValue("ListServices.Services["+ i +"].ArtifactVersion");
				service.SourceImage = _ctx.StringValue("ListServices.Services["+ i +"].SourceImage");
				service.RelationType = _ctx.StringValue("ListServices.Services["+ i +"].RelationType");
				service.TrialType = _ctx.StringValue("ListServices.Services["+ i +"].TrialType");
				service.TenantType = _ctx.StringValue("ListServices.Services["+ i +"].TenantType");
				service.ResourceGroupId = _ctx.StringValue("ListServices.Services["+ i +"].ResourceGroupId");

				List<ListServicesResponse.ListServices_Service.ListServices_ServiceInfo> service_serviceInfos = new List<ListServicesResponse.ListServices_Service.ListServices_ServiceInfo>();
				for (int j = 0; j < _ctx.Length("ListServices.Services["+ i +"].ServiceInfos.Length"); j++) {
					ListServicesResponse.ListServices_Service.ListServices_ServiceInfo serviceInfo = new ListServicesResponse.ListServices_Service.ListServices_ServiceInfo();
					serviceInfo.Locale = _ctx.StringValue("ListServices.Services["+ i +"].ServiceInfos["+ j +"].Locale");
					serviceInfo.Image = _ctx.StringValue("ListServices.Services["+ i +"].ServiceInfos["+ j +"].Image");
					serviceInfo.Name = _ctx.StringValue("ListServices.Services["+ i +"].ServiceInfos["+ j +"].Name");
					serviceInfo.ShortDescription = _ctx.StringValue("ListServices.Services["+ i +"].ServiceInfos["+ j +"].ShortDescription");

					service_serviceInfos.Add(serviceInfo);
				}
				service.ServiceInfos = service_serviceInfos;

				List<ListServicesResponse.ListServices_Service.ListServices_Tag> service_tags = new List<ListServicesResponse.ListServices_Service.ListServices_Tag>();
				for (int j = 0; j < _ctx.Length("ListServices.Services["+ i +"].Tags.Length"); j++) {
					ListServicesResponse.ListServices_Service.ListServices_Tag tag = new ListServicesResponse.ListServices_Service.ListServices_Tag();
					tag.Key = _ctx.StringValue("ListServices.Services["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("ListServices.Services["+ i +"].Tags["+ j +"].Value");

					service_tags.Add(tag);
				}
				service.Tags = service_tags;

				listServicesResponse_services.Add(service);
			}
			listServicesResponse.Services = listServicesResponse_services;
        
			return listServicesResponse;
        }
    }
}
