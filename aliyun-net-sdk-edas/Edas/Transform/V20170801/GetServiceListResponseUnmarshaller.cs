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
    public class GetServiceListResponseUnmarshaller
    {
        public static GetServiceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetServiceListResponse getServiceListResponse = new GetServiceListResponse();

			getServiceListResponse.HttpResponse = _ctx.HttpResponse;
			getServiceListResponse.Code = _ctx.IntegerValue("GetServiceList.Code");
			getServiceListResponse.Message = _ctx.StringValue("GetServiceList.Message");
			getServiceListResponse.Success = _ctx.BooleanValue("GetServiceList.Success");

			List<GetServiceListResponse.GetServiceList_MseServiceResponse> getServiceListResponse_data = new List<GetServiceListResponse.GetServiceList_MseServiceResponse>();
			for (int i = 0; i < _ctx.Length("GetServiceList.Data.Length"); i++) {
				GetServiceListResponse.GetServiceList_MseServiceResponse mseServiceResponse = new GetServiceListResponse.GetServiceList_MseServiceResponse();
				mseServiceResponse.ServiceName = _ctx.StringValue("GetServiceList.Data["+ i +"].ServiceName");
				mseServiceResponse.EdasAppName = _ctx.StringValue("GetServiceList.Data["+ i +"].EdasAppName");
				mseServiceResponse.DubboApplicationName = _ctx.StringValue("GetServiceList.Data["+ i +"].DubboApplicationName");
				mseServiceResponse.SpringApplicationName = _ctx.StringValue("GetServiceList.Data["+ i +"].SpringApplicationName");
				mseServiceResponse.ServiceType = _ctx.StringValue("GetServiceList.Data["+ i +"].ServiceType");
				mseServiceResponse.RegistryType = _ctx.StringValue("GetServiceList.Data["+ i +"].RegistryType");
				mseServiceResponse.Version = _ctx.StringValue("GetServiceList.Data["+ i +"].Version");
				mseServiceResponse.Group = _ctx.StringValue("GetServiceList.Data["+ i +"].Group");
				mseServiceResponse.Metadata = _ctx.StringValue("GetServiceList.Data["+ i +"].Metadata");

				List<GetServiceListResponse.GetServiceList_MseServiceResponse.GetServiceList_Method> mseServiceResponse_methods = new List<GetServiceListResponse.GetServiceList_MseServiceResponse.GetServiceList_Method>();
				for (int j = 0; j < _ctx.Length("GetServiceList.Data["+ i +"].Methods.Length"); j++) {
					GetServiceListResponse.GetServiceList_MseServiceResponse.GetServiceList_Method method = new GetServiceListResponse.GetServiceList_MseServiceResponse.GetServiceList_Method();
					method.Name = _ctx.StringValue("GetServiceList.Data["+ i +"].Methods["+ j +"].Name");
					method.ReturnType = _ctx.StringValue("GetServiceList.Data["+ i +"].Methods["+ j +"].ReturnType");
					method.MethodController = _ctx.StringValue("GetServiceList.Data["+ i +"].Methods["+ j +"].MethodController");
					method.ParameterNames = _ctx.StringValue("GetServiceList.Data["+ i +"].Methods["+ j +"].ParameterNames");
					method.NameDetail = _ctx.StringValue("GetServiceList.Data["+ i +"].Methods["+ j +"].NameDetail");
					method.ReturnDetails = _ctx.StringValue("GetServiceList.Data["+ i +"].Methods["+ j +"].ReturnDetails");
					method.ParameterTypes = _ctx.StringValue("GetServiceList.Data["+ i +"].Methods["+ j +"].ParameterTypes");
					method.ParameterDetails = _ctx.StringValue("GetServiceList.Data["+ i +"].Methods["+ j +"].ParameterDetails");
					method.RequestMethods = _ctx.StringValue("GetServiceList.Data["+ i +"].Methods["+ j +"].RequestMethods");
					method.ParameterDetails1 = _ctx.StringValue("GetServiceList.Data["+ i +"].Methods["+ j +"].ParameterDetails");
					method.RequestMethods2 = _ctx.StringValue("GetServiceList.Data["+ i +"].Methods["+ j +"].RequestMethods");
					method.Paths = _ctx.StringValue("GetServiceList.Data["+ i +"].Methods["+ j +"].Paths");
					method.ParameterDefinitions = _ctx.StringValue("GetServiceList.Data["+ i +"].Methods["+ j +"].ParameterDefinitions");

					mseServiceResponse_methods.Add(method);
				}
				mseServiceResponse.Methods = mseServiceResponse_methods;

				getServiceListResponse_data.Add(mseServiceResponse);
			}
			getServiceListResponse.Data = getServiceListResponse_data;
        
			return getServiceListResponse;
        }
    }
}
