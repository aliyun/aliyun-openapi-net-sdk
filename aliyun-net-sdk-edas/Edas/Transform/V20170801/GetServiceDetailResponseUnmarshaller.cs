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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class GetServiceDetailResponseUnmarshaller
    {
        public static GetServiceDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetServiceDetailResponse getServiceDetailResponse = new GetServiceDetailResponse();

			getServiceDetailResponse.HttpResponse = _ctx.HttpResponse;
			getServiceDetailResponse.Code = _ctx.IntegerValue("GetServiceDetail.Code");
			getServiceDetailResponse.Message = _ctx.StringValue("GetServiceDetail.Message");
			getServiceDetailResponse.Success = _ctx.BooleanValue("GetServiceDetail.Success");

			GetServiceDetailResponse.GetServiceDetail_Data data = new GetServiceDetailResponse.GetServiceDetail_Data();
			data.ServiceName = _ctx.StringValue("GetServiceDetail.Data.ServiceName");
			data.EdasAppName = _ctx.StringValue("GetServiceDetail.Data.EdasAppName");
			data.DubboApplicationName = _ctx.StringValue("GetServiceDetail.Data.DubboApplicationName");
			data.SpringApplicationName = _ctx.StringValue("GetServiceDetail.Data.SpringApplicationName");
			data.ServiceType = _ctx.StringValue("GetServiceDetail.Data.ServiceType");
			data.RegistryType = _ctx.StringValue("GetServiceDetail.Data.RegistryType");
			data.Version = _ctx.StringValue("GetServiceDetail.Data.Version");
			data.Group = _ctx.StringValue("GetServiceDetail.Data.Group");
			data.Metadata = _ctx.StringValue("GetServiceDetail.Data.Metadata");

			List<GetServiceDetailResponse.GetServiceDetail_Data.GetServiceDetail_Method> data_methods = new List<GetServiceDetailResponse.GetServiceDetail_Data.GetServiceDetail_Method>();
			for (int i = 0; i < _ctx.Length("GetServiceDetail.Data.Methods.Length"); i++) {
				GetServiceDetailResponse.GetServiceDetail_Data.GetServiceDetail_Method method = new GetServiceDetailResponse.GetServiceDetail_Data.GetServiceDetail_Method();
				method.Name = _ctx.StringValue("GetServiceDetail.Data.Methods["+ i +"].Name");
				method.ReturnType = _ctx.StringValue("GetServiceDetail.Data.Methods["+ i +"].ReturnType");
				method.MethodController = _ctx.StringValue("GetServiceDetail.Data.Methods["+ i +"].MethodController");
				method.ParameterNames = _ctx.StringValue("GetServiceDetail.Data.Methods["+ i +"].ParameterNames");
				method.NameDetail = _ctx.StringValue("GetServiceDetail.Data.Methods["+ i +"].NameDetail");
				method.ReturnDetails = _ctx.StringValue("GetServiceDetail.Data.Methods["+ i +"].ReturnDetails");
				method.ParameterTypes = _ctx.StringValue("GetServiceDetail.Data.Methods["+ i +"].ParameterTypes");
				method.ParameterDetails = _ctx.StringValue("GetServiceDetail.Data.Methods["+ i +"].ParameterDetails");
				method.RequestMethods = _ctx.StringValue("GetServiceDetail.Data.Methods["+ i +"].RequestMethods");
				method.Paths = _ctx.StringValue("GetServiceDetail.Data.Methods["+ i +"].Paths");
				method.ParameterDefinitions = _ctx.StringValue("GetServiceDetail.Data.Methods["+ i +"].ParameterDefinitions");

				GetServiceDetailResponse.GetServiceDetail_Data.GetServiceDetail_Method.GetServiceDetail_ReturnDefinition returnDefinition = new GetServiceDetailResponse.GetServiceDetail_Data.GetServiceDetail_Method.GetServiceDetail_ReturnDefinition();
				returnDefinition.Id = _ctx.StringValue("GetServiceDetail.Data.Methods["+ i +"].ReturnDefinition.Id");
				returnDefinition.Type = _ctx.StringValue("GetServiceDetail.Data.Methods["+ i +"].ReturnDefinition.Type");
				method.ReturnDefinition = returnDefinition;

				data_methods.Add(method);
			}
			data.Methods = data_methods;
			getServiceDetailResponse.Data = data;
        
			return getServiceDetailResponse;
        }
    }
}
