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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DescribeAppServiceDetailResponseUnmarshaller
    {
        public static DescribeAppServiceDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAppServiceDetailResponse describeAppServiceDetailResponse = new DescribeAppServiceDetailResponse();

			describeAppServiceDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeAppServiceDetailResponse.RequestId = _ctx.StringValue("DescribeAppServiceDetail.RequestId");
			describeAppServiceDetailResponse.Message = _ctx.StringValue("DescribeAppServiceDetail.Message");
			describeAppServiceDetailResponse.TraceId = _ctx.StringValue("DescribeAppServiceDetail.TraceId");
			describeAppServiceDetailResponse.ErrorCode = _ctx.StringValue("DescribeAppServiceDetail.ErrorCode");
			describeAppServiceDetailResponse.Code = _ctx.StringValue("DescribeAppServiceDetail.Code");
			describeAppServiceDetailResponse.Success = _ctx.BooleanValue("DescribeAppServiceDetail.Success");

			DescribeAppServiceDetailResponse.DescribeAppServiceDetail_Data data = new DescribeAppServiceDetailResponse.DescribeAppServiceDetail_Data();
			data.Group = _ctx.StringValue("DescribeAppServiceDetail.Data.Group");
			data.ServiceName = _ctx.StringValue("DescribeAppServiceDetail.Data.ServiceName");
			data.Version = _ctx.StringValue("DescribeAppServiceDetail.Data.Version");
			data.ServiceType = _ctx.StringValue("DescribeAppServiceDetail.Data.ServiceType");
			data.EdasAppName = _ctx.StringValue("DescribeAppServiceDetail.Data.EdasAppName");
			data.Metadata = _ctx.StringValue("DescribeAppServiceDetail.Data.Metadata");
			data.SpringApplicationName = _ctx.StringValue("DescribeAppServiceDetail.Data.SpringApplicationName");
			data.DubboApplicationName = _ctx.StringValue("DescribeAppServiceDetail.Data.DubboApplicationName");

			List<DescribeAppServiceDetailResponse.DescribeAppServiceDetail_Data.DescribeAppServiceDetail_Method> data_methods = new List<DescribeAppServiceDetailResponse.DescribeAppServiceDetail_Data.DescribeAppServiceDetail_Method>();
			for (int i = 0; i < _ctx.Length("DescribeAppServiceDetail.Data.Methods.Length"); i++) {
				DescribeAppServiceDetailResponse.DescribeAppServiceDetail_Data.DescribeAppServiceDetail_Method method = new DescribeAppServiceDetailResponse.DescribeAppServiceDetail_Data.DescribeAppServiceDetail_Method();
				method.MethodController = _ctx.StringValue("DescribeAppServiceDetail.Data.Methods["+ i +"].MethodController");
				method.ReturnType = _ctx.StringValue("DescribeAppServiceDetail.Data.Methods["+ i +"].ReturnType");
				method.ReturnDetails = _ctx.StringValue("DescribeAppServiceDetail.Data.Methods["+ i +"].ReturnDetails");
				method.Name = _ctx.StringValue("DescribeAppServiceDetail.Data.Methods["+ i +"].Name");
				method.NameDetail = _ctx.StringValue("DescribeAppServiceDetail.Data.Methods["+ i +"].NameDetail");

				List<string> method_parameterDetails = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeAppServiceDetail.Data.Methods["+ i +"].ParameterDetails.Length"); j++) {
					method_parameterDetails.Add(_ctx.StringValue("DescribeAppServiceDetail.Data.Methods["+ i +"].ParameterDetails["+ j +"]"));
				}
				method.ParameterDetails = method_parameterDetails;

				List<string> method_requestMethods = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeAppServiceDetail.Data.Methods["+ i +"].RequestMethods.Length"); j++) {
					method_requestMethods.Add(_ctx.StringValue("DescribeAppServiceDetail.Data.Methods["+ i +"].RequestMethods["+ j +"]"));
				}
				method.RequestMethods = method_requestMethods;

				List<string> method_parameterTypes = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeAppServiceDetail.Data.Methods["+ i +"].ParameterTypes.Length"); j++) {
					method_parameterTypes.Add(_ctx.StringValue("DescribeAppServiceDetail.Data.Methods["+ i +"].ParameterTypes["+ j +"]"));
				}
				method.ParameterTypes = method_parameterTypes;

				List<string> method_paths = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeAppServiceDetail.Data.Methods["+ i +"].Paths.Length"); j++) {
					method_paths.Add(_ctx.StringValue("DescribeAppServiceDetail.Data.Methods["+ i +"].Paths["+ j +"]"));
				}
				method.Paths = method_paths;

				List<DescribeAppServiceDetailResponse.DescribeAppServiceDetail_Data.DescribeAppServiceDetail_Method.DescribeAppServiceDetail_ParameterDefinition> method_parameterDefinitions = new List<DescribeAppServiceDetailResponse.DescribeAppServiceDetail_Data.DescribeAppServiceDetail_Method.DescribeAppServiceDetail_ParameterDefinition>();
				for (int j = 0; j < _ctx.Length("DescribeAppServiceDetail.Data.Methods["+ i +"].ParameterDefinitions.Length"); j++) {
					DescribeAppServiceDetailResponse.DescribeAppServiceDetail_Data.DescribeAppServiceDetail_Method.DescribeAppServiceDetail_ParameterDefinition parameterDefinition = new DescribeAppServiceDetailResponse.DescribeAppServiceDetail_Data.DescribeAppServiceDetail_Method.DescribeAppServiceDetail_ParameterDefinition();
					parameterDefinition.Type = _ctx.StringValue("DescribeAppServiceDetail.Data.Methods["+ i +"].ParameterDefinitions["+ j +"].Type");
					parameterDefinition.Description = _ctx.StringValue("DescribeAppServiceDetail.Data.Methods["+ i +"].ParameterDefinitions["+ j +"].Description");
					parameterDefinition.Name = _ctx.StringValue("DescribeAppServiceDetail.Data.Methods["+ i +"].ParameterDefinitions["+ j +"].Name");

					method_parameterDefinitions.Add(parameterDefinition);
				}
				method.ParameterDefinitions = method_parameterDefinitions;

				data_methods.Add(method);
			}
			data.Methods = data_methods;
			describeAppServiceDetailResponse.Data = data;
        
			return describeAppServiceDetailResponse;
        }
    }
}
