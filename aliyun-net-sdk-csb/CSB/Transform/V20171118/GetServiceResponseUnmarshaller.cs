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
using Aliyun.Acs.CSB.Model.V20171118;

namespace Aliyun.Acs.CSB.Transform.V20171118
{
    public class GetServiceResponseUnmarshaller
    {
        public static GetServiceResponse Unmarshall(UnmarshallerContext context)
        {
			GetServiceResponse getServiceResponse = new GetServiceResponse();

			getServiceResponse.HttpResponse = context.HttpResponse;
			getServiceResponse.Code = context.IntegerValue("GetService.Code");
			getServiceResponse.Message = context.StringValue("GetService.Message");
			getServiceResponse.RequestId = context.StringValue("GetService.RequestId");

			GetServiceResponse.GetService_Data data = new GetServiceResponse.GetService_Data();

			GetServiceResponse.GetService_Data.GetService_Service service = new GetServiceResponse.GetService_Data.GetService_Service();
			service.AccessParamsJSON = context.StringValue("GetService.Data.Service.AccessParamsJSON");
			service.Active = context.BooleanValue("GetService.Data.Service.Active");
			service.Alias = context.StringValue("GetService.Data.Service.Alias");
			service.AllVisiable = context.BooleanValue("GetService.Data.Service.AllVisiable");
			service.ApproveUserId = context.StringValue("GetService.Data.Service.ApproveUserId");
			service.CasTargets = context.StringValue("GetService.Data.Service.CasTargets");
			service.ConsumeTypesJSON = context.StringValue("GetService.Data.Service.ConsumeTypesJSON");
			service.CreateTime = context.LongValue("GetService.Data.Service.CreateTime");
			service.CsbId = context.LongValue("GetService.Data.Service.CsbId");
			service.ErrDefJSON = context.StringValue("GetService.Data.Service.ErrDefJSON");
			service.Id = context.LongValue("GetService.Data.Service.Id");
			service.InterfaceName = context.StringValue("GetService.Data.Service.InterfaceName");
			service.IpBlackStr = context.StringValue("GetService.Data.Service.IpBlackStr");
			service.IpWhiteStr = context.StringValue("GetService.Data.Service.IpWhiteStr");
			service.ModelVersion = context.StringValue("GetService.Data.Service.ModelVersion");
			service.ModifiedTime = context.LongValue("GetService.Data.Service.ModifiedTime");
			service.OldVersion = context.StringValue("GetService.Data.Service.OldVersion");
			service.OpenRestfulPath = context.StringValue("GetService.Data.Service.OpenRestfulPath");
			service.OttFlag = context.BooleanValue("GetService.Data.Service.OttFlag");
			service.OwnerId = context.StringValue("GetService.Data.Service.OwnerId");
			service.PolicyHandler = context.StringValue("GetService.Data.Service.PolicyHandler");
			service.PrincipalName = context.StringValue("GetService.Data.Service.PrincipalName");
			service.ProjectId = context.LongValue("GetService.Data.Service.ProjectId");
			service.ProjectName = context.StringValue("GetService.Data.Service.ProjectName");
			service.ProvideType = context.StringValue("GetService.Data.Service.ProvideType");
			service.RouteConfJson = context.StringValue("GetService.Data.Service.RouteConfJson");
			service.SSL = context.BooleanValue("GetService.Data.Service.SSL");
			service.Scope = context.StringValue("GetService.Data.Service.Scope");
			service.ServiceName = context.StringValue("GetService.Data.Service.ServiceName");
			service.ServiceOpenRestfulPath = context.StringValue("GetService.Data.Service.ServiceOpenRestfulPath");
			service.ServiceProviderType = context.StringValue("GetService.Data.Service.ServiceProviderType");
			service.ServiceVersion = context.StringValue("GetService.Data.Service.ServiceVersion");
			service.SkipAuth = context.BooleanValue("GetService.Data.Service.SkipAuth");
			service.StatisticName = context.StringValue("GetService.Data.Service.StatisticName");
			service.Status = context.IntegerValue("GetService.Data.Service.Status");
			service.UserId = context.StringValue("GetService.Data.Service.UserId");
			service.ValidConsumeTypes = context.BooleanValue("GetService.Data.Service.ValidConsumeTypes");
			service.ValidProvideType = context.BooleanValue("GetService.Data.Service.ValidProvideType");
			service.Qps = context.IntegerValue("GetService.Data.Service.Qps");

			List<string> service_casServTargets = new List<string>();
			for (int i = 0; i < context.Length("GetService.Data.Service.CasServTargets.Length"); i++) {
				service_casServTargets.Add(context.StringValue("GetService.Data.Service.CasServTargets["+ i +"]"));
			}
			service.CasServTargets = service_casServTargets;

			List<string> service_consumeTypes = new List<string>();
			for (int i = 0; i < context.Length("GetService.Data.Service.ConsumeTypes.Length"); i++) {
				service_consumeTypes.Add(context.StringValue("GetService.Data.Service.ConsumeTypes["+ i +"]"));
			}
			service.ConsumeTypes = service_consumeTypes;

			List<GetServiceResponse.GetService_Data.GetService_Service.GetService_ServiceVersion> service_serviceVersionsList = new List<GetServiceResponse.GetService_Data.GetService_Service.GetService_ServiceVersion>();
			for (int i = 0; i < context.Length("GetService.Data.Service.ServiceVersionsList.Length"); i++) {
				GetServiceResponse.GetService_Data.GetService_Service.GetService_ServiceVersion serviceVersion = new GetServiceResponse.GetService_Data.GetService_Service.GetService_ServiceVersion();
				serviceVersion.Active = context.BooleanValue("GetService.Data.Service.ServiceVersionsList["+ i +"].Active");
				serviceVersion.AllVisiable = context.BooleanValue("GetService.Data.Service.ServiceVersionsList["+ i +"].AllVisiable");
				serviceVersion.Id = context.LongValue("GetService.Data.Service.ServiceVersionsList["+ i +"].Id");
				serviceVersion.OldVersion = context.StringValue("GetService.Data.Service.ServiceVersionsList["+ i +"].OldVersion");
				serviceVersion.OttFlag = context.BooleanValue("GetService.Data.Service.ServiceVersionsList["+ i +"].OttFlag");
				serviceVersion.SSL = context.BooleanValue("GetService.Data.Service.ServiceVersionsList["+ i +"].SSL");
				serviceVersion.Scope = context.StringValue("GetService.Data.Service.ServiceVersionsList["+ i +"].Scope");
				serviceVersion.ServiceVersion = context.StringValue("GetService.Data.Service.ServiceVersionsList["+ i +"].ServiceVersion");
				serviceVersion.SkipAuth = context.BooleanValue("GetService.Data.Service.ServiceVersionsList["+ i +"].SkipAuth");
				serviceVersion.StatisticName = context.StringValue("GetService.Data.Service.ServiceVersionsList["+ i +"].StatisticName");
				serviceVersion.Status = context.IntegerValue("GetService.Data.Service.ServiceVersionsList["+ i +"].Status");
				serviceVersion.ValidConsumeTypes = context.BooleanValue("GetService.Data.Service.ServiceVersionsList["+ i +"].ValidConsumeTypes");
				serviceVersion.ValidProvideType = context.BooleanValue("GetService.Data.Service.ServiceVersionsList["+ i +"].ValidProvideType");

				service_serviceVersionsList.Add(serviceVersion);
			}
			service.ServiceVersionsList = service_serviceVersionsList;

			List<GetServiceResponse.GetService_Data.GetService_Service.GetService_VisiableGroup> service_visiableGroupList = new List<GetServiceResponse.GetService_Data.GetService_Service.GetService_VisiableGroup>();
			for (int i = 0; i < context.Length("GetService.Data.Service.VisiableGroupList.Length"); i++) {
				GetServiceResponse.GetService_Data.GetService_Service.GetService_VisiableGroup visiableGroup = new GetServiceResponse.GetService_Data.GetService_Service.GetService_VisiableGroup();
				visiableGroup.Id = context.LongValue("GetService.Data.Service.VisiableGroupList["+ i +"].Id");
				visiableGroup.GroupId = context.LongValue("GetService.Data.Service.VisiableGroupList["+ i +"].GroupId");
				visiableGroup.UserId = context.StringValue("GetService.Data.Service.VisiableGroupList["+ i +"].UserId");
				visiableGroup.ServiceId = context.LongValue("GetService.Data.Service.VisiableGroupList["+ i +"].ServiceId");
				visiableGroup.CreateTime = context.LongValue("GetService.Data.Service.VisiableGroupList["+ i +"].CreateTime");
				visiableGroup.ModifiedTime = context.LongValue("GetService.Data.Service.VisiableGroupList["+ i +"].ModifiedTime");
				visiableGroup.Status = context.IntegerValue("GetService.Data.Service.VisiableGroupList["+ i +"].Status");

				service_visiableGroupList.Add(visiableGroup);
			}
			service.VisiableGroupList = service_visiableGroupList;
			data.Service = service;
			getServiceResponse.Data = data;
        
			return getServiceResponse;
        }
    }
}
