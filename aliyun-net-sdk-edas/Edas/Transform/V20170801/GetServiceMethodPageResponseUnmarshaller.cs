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
    public class GetServiceMethodPageResponseUnmarshaller
    {
        public static GetServiceMethodPageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetServiceMethodPageResponse getServiceMethodPageResponse = new GetServiceMethodPageResponse();

			getServiceMethodPageResponse.HttpResponse = _ctx.HttpResponse;
			getServiceMethodPageResponse.Code = _ctx.StringValue("GetServiceMethodPage.Code");
			getServiceMethodPageResponse.Message = _ctx.StringValue("GetServiceMethodPage.Message");
			getServiceMethodPageResponse.Success = _ctx.BooleanValue("GetServiceMethodPage.Success");
			getServiceMethodPageResponse.RequestId = _ctx.StringValue("GetServiceMethodPage.RequestId");
			getServiceMethodPageResponse.HttpCode = _ctx.StringValue("GetServiceMethodPage.HttpCode");

			GetServiceMethodPageResponse.GetServiceMethodPage_Data data = new GetServiceMethodPageResponse.GetServiceMethodPage_Data();
			data.PageNumber = _ctx.IntegerValue("GetServiceMethodPage.Data.PageNumber");
			data.TotalSize = _ctx.IntegerValue("GetServiceMethodPage.Data.TotalSize");
			data.PageSize = _ctx.IntegerValue("GetServiceMethodPage.Data.PageSize");

			List<GetServiceMethodPageResponse.GetServiceMethodPage_Data.GetServiceMethodPage_Method> data_result = new List<GetServiceMethodPageResponse.GetServiceMethodPage_Data.GetServiceMethodPage_Method>();
			for (int i = 0; i < _ctx.Length("GetServiceMethodPage.Data.Result.Length"); i++) {
				GetServiceMethodPageResponse.GetServiceMethodPage_Data.GetServiceMethodPage_Method method = new GetServiceMethodPageResponse.GetServiceMethodPage_Data.GetServiceMethodPage_Method();
				method.Name = _ctx.StringValue("GetServiceMethodPage.Data.Result["+ i +"].Name");
				method.ReturnType = _ctx.StringValue("GetServiceMethodPage.Data.Result["+ i +"].ReturnType");
				method.MethodController = _ctx.StringValue("GetServiceMethodPage.Data.Result["+ i +"].MethodController");
				method.NameDetail = _ctx.StringValue("GetServiceMethodPage.Data.Result["+ i +"].NameDetail");
				method.ReturnDetails = _ctx.StringValue("GetServiceMethodPage.Data.Result["+ i +"].ReturnDetails");
				method.ParameterTypes = _ctx.StringValue("GetServiceMethodPage.Data.Result["+ i +"].ParameterTypes");
				method.ParameterNames = _ctx.StringValue("GetServiceMethodPage.Data.Result["+ i +"].ParameterNames");
				method.ParameterDetails = _ctx.StringValue("GetServiceMethodPage.Data.Result["+ i +"].ParameterDetails");
				method.RequestMethods = _ctx.StringValue("GetServiceMethodPage.Data.Result["+ i +"].RequestMethods");
				method.Paths = _ctx.StringValue("GetServiceMethodPage.Data.Result["+ i +"].Paths");
				method.ParameterDefinitions = _ctx.StringValue("GetServiceMethodPage.Data.Result["+ i +"].ParameterDefinitions");

				GetServiceMethodPageResponse.GetServiceMethodPage_Data.GetServiceMethodPage_Method.GetServiceMethodPage_ReturnDefinition returnDefinition = new GetServiceMethodPageResponse.GetServiceMethodPage_Data.GetServiceMethodPage_Method.GetServiceMethodPage_ReturnDefinition();
				returnDefinition.Id = _ctx.StringValue("GetServiceMethodPage.Data.Result["+ i +"].ReturnDefinition.Id");
				returnDefinition.Type = _ctx.StringValue("GetServiceMethodPage.Data.Result["+ i +"].ReturnDefinition.Type");
				method.ReturnDefinition = returnDefinition;

				data_result.Add(method);
			}
			data.Result = data_result;
			getServiceMethodPageResponse.Data = data;
        
			return getServiceMethodPageResponse;
        }
    }
}
