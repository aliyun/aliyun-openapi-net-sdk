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

			GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf routeConf = new GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf();
			routeConf.ServiceRouteStrategy = context.StringValue("GetService.Data.Service.RouteConf.ServiceRouteStrategy");

			GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConf importConf = new GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConf();
			importConf.AccessEndpointJSON = context.StringValue("GetService.Data.Service.RouteConf.ImportConf.AccessEndpointJSON");
			importConf.ProvideType = context.StringValue("GetService.Data.Service.RouteConf.ImportConf.ProvideType");

			List<GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConf.GetService_InputParameter> importConf_inputParameterMap = new List<GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConf.GetService_InputParameter>();
			for (int i = 0; i < context.Length("GetService.Data.Service.RouteConf.ImportConf.InputParameterMap.Length"); i++) {
				GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConf.GetService_InputParameter inputParameter = new GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConf.GetService_InputParameter();
				inputParameter.CatType = context.IntegerValue("GetService.Data.Service.RouteConf.ImportConf.InputParameterMap["+ i +"].CatType");
				inputParameter.Depth = context.IntegerValue("GetService.Data.Service.RouteConf.ImportConf.InputParameterMap["+ i +"].Depth");
				inputParameter.ExtType = context.IntegerValue("GetService.Data.Service.RouteConf.ImportConf.InputParameterMap["+ i +"].ExtType");
				inputParameter.MapStyle = context.IntegerValue("GetService.Data.Service.RouteConf.ImportConf.InputParameterMap["+ i +"].MapStyle");
				inputParameter.Optional = context.BooleanValue("GetService.Data.Service.RouteConf.ImportConf.InputParameterMap["+ i +"].Optional");
				inputParameter.OriginalName = context.StringValue("GetService.Data.Service.RouteConf.ImportConf.InputParameterMap["+ i +"].OriginalName");
				inputParameter.ParamType = context.StringValue("GetService.Data.Service.RouteConf.ImportConf.InputParameterMap["+ i +"].ParamType");
				inputParameter.PassMethod = context.StringValue("GetService.Data.Service.RouteConf.ImportConf.InputParameterMap["+ i +"].PassMethod");
				inputParameter.TargetName = context.StringValue("GetService.Data.Service.RouteConf.ImportConf.InputParameterMap["+ i +"].TargetName");

				importConf_inputParameterMap.Add(inputParameter);
			}
			importConf.InputParameterMap = importConf_inputParameterMap;

			List<GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConf.GetService_OutputParameter> importConf_outputParameterMap = new List<GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConf.GetService_OutputParameter>();
			for (int i = 0; i < context.Length("GetService.Data.Service.RouteConf.ImportConf.OutputParameterMap.Length"); i++) {
				GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConf.GetService_OutputParameter outputParameter = new GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConf.GetService_OutputParameter();
				outputParameter.CatType = context.IntegerValue("GetService.Data.Service.RouteConf.ImportConf.OutputParameterMap["+ i +"].CatType");
				outputParameter.Depth = context.IntegerValue("GetService.Data.Service.RouteConf.ImportConf.OutputParameterMap["+ i +"].Depth");
				outputParameter.ExtType = context.IntegerValue("GetService.Data.Service.RouteConf.ImportConf.OutputParameterMap["+ i +"].ExtType");
				outputParameter.MapStyle = context.IntegerValue("GetService.Data.Service.RouteConf.ImportConf.OutputParameterMap["+ i +"].MapStyle");
				outputParameter.Optional = context.BooleanValue("GetService.Data.Service.RouteConf.ImportConf.OutputParameterMap["+ i +"].Optional");
				outputParameter.OriginalName = context.StringValue("GetService.Data.Service.RouteConf.ImportConf.OutputParameterMap["+ i +"].OriginalName");
				outputParameter.ParamType = context.StringValue("GetService.Data.Service.RouteConf.ImportConf.OutputParameterMap["+ i +"].ParamType");
				outputParameter.PassMethod = context.StringValue("GetService.Data.Service.RouteConf.ImportConf.OutputParameterMap["+ i +"].PassMethod");
				outputParameter.TargetName = context.StringValue("GetService.Data.Service.RouteConf.ImportConf.OutputParameterMap["+ i +"].TargetName");

				importConf_outputParameterMap.Add(outputParameter);
			}
			importConf.OutputParameterMap = importConf_outputParameterMap;
			routeConf.ImportConf = importConf;

			GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConfs importConfs = new GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConfs();
			importConfs.AccessEndpointJSON = context.StringValue("GetService.Data.Service.RouteConf.ImportConfs.AccessEndpointJSON");
			importConfs.ProvideType = context.StringValue("GetService.Data.Service.RouteConf.ImportConfs.ProvideType");

			List<GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConfs.GetService_InputParameter3> importConfs_inputParameterMap1 = new List<GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConfs.GetService_InputParameter3>();
			for (int i = 0; i < context.Length("GetService.Data.Service.RouteConf.ImportConfs.InputParameterMap.Length"); i++) {
				GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConfs.GetService_InputParameter3 inputParameter3 = new GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConfs.GetService_InputParameter3();
				inputParameter3.CatType = context.IntegerValue("GetService.Data.Service.RouteConf.ImportConfs.InputParameterMap["+ i +"].CatType");
				inputParameter3.Depth = context.IntegerValue("GetService.Data.Service.RouteConf.ImportConfs.InputParameterMap["+ i +"].Depth");
				inputParameter3.ExtType = context.IntegerValue("GetService.Data.Service.RouteConf.ImportConfs.InputParameterMap["+ i +"].ExtType");
				inputParameter3.MapStyle = context.IntegerValue("GetService.Data.Service.RouteConf.ImportConfs.InputParameterMap["+ i +"].MapStyle");
				inputParameter3.Optional = context.BooleanValue("GetService.Data.Service.RouteConf.ImportConfs.InputParameterMap["+ i +"].Optional");
				inputParameter3.OriginalName = context.StringValue("GetService.Data.Service.RouteConf.ImportConfs.InputParameterMap["+ i +"].OriginalName");
				inputParameter3.ParamType = context.StringValue("GetService.Data.Service.RouteConf.ImportConfs.InputParameterMap["+ i +"].ParamType");
				inputParameter3.PassMethod = context.StringValue("GetService.Data.Service.RouteConf.ImportConfs.InputParameterMap["+ i +"].PassMethod");
				inputParameter3.TargetName = context.StringValue("GetService.Data.Service.RouteConf.ImportConfs.InputParameterMap["+ i +"].TargetName");

				importConfs_inputParameterMap1.Add(inputParameter3);
			}
			importConfs.InputParameterMap1 = importConfs_inputParameterMap1;

			List<GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConfs.GetService_OutputParameter4> importConfs_outputParameterMap2 = new List<GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConfs.GetService_OutputParameter4>();
			for (int i = 0; i < context.Length("GetService.Data.Service.RouteConf.ImportConfs.OutputParameterMap.Length"); i++) {
				GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConfs.GetService_OutputParameter4 outputParameter4 = new GetServiceResponse.GetService_Data.GetService_Service.GetService_RouteConf.GetService_ImportConfs.GetService_OutputParameter4();
				outputParameter4.CatType = context.IntegerValue("GetService.Data.Service.RouteConf.ImportConfs.OutputParameterMap["+ i +"].CatType");
				outputParameter4.Depth = context.IntegerValue("GetService.Data.Service.RouteConf.ImportConfs.OutputParameterMap["+ i +"].Depth");
				outputParameter4.ExtType = context.IntegerValue("GetService.Data.Service.RouteConf.ImportConfs.OutputParameterMap["+ i +"].ExtType");
				outputParameter4.MapStyle = context.IntegerValue("GetService.Data.Service.RouteConf.ImportConfs.OutputParameterMap["+ i +"].MapStyle");
				outputParameter4.Optional = context.BooleanValue("GetService.Data.Service.RouteConf.ImportConfs.OutputParameterMap["+ i +"].Optional");
				outputParameter4.OriginalName = context.StringValue("GetService.Data.Service.RouteConf.ImportConfs.OutputParameterMap["+ i +"].OriginalName");
				outputParameter4.ParamType = context.StringValue("GetService.Data.Service.RouteConf.ImportConfs.OutputParameterMap["+ i +"].ParamType");
				outputParameter4.PassMethod = context.StringValue("GetService.Data.Service.RouteConf.ImportConfs.OutputParameterMap["+ i +"].PassMethod");
				outputParameter4.TargetName = context.StringValue("GetService.Data.Service.RouteConf.ImportConfs.OutputParameterMap["+ i +"].TargetName");

				importConfs_outputParameterMap2.Add(outputParameter4);
			}
			importConfs.OutputParameterMap2 = importConfs_outputParameterMap2;
			routeConf.ImportConfs = importConfs;
			service.RouteConf = routeConf;

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
