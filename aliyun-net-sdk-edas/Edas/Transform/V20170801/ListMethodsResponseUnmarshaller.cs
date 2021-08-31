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
    public class ListMethodsResponseUnmarshaller
    {
        public static ListMethodsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMethodsResponse listMethodsResponse = new ListMethodsResponse();

			listMethodsResponse.HttpResponse = _ctx.HttpResponse;
			listMethodsResponse.Code = _ctx.IntegerValue("ListMethods.Code");
			listMethodsResponse.Message = _ctx.StringValue("ListMethods.Message");
			listMethodsResponse.RequestId = _ctx.StringValue("ListMethods.RequestId");

			List<ListMethodsResponse.ListMethods_ServiceMethod> listMethodsResponse_serviceMethodList = new List<ListMethodsResponse.ListMethods_ServiceMethod>();
			for (int i = 0; i < _ctx.Length("ListMethods.ServiceMethodList.Length"); i++) {
				ListMethodsResponse.ListMethods_ServiceMethod serviceMethod = new ListMethodsResponse.ListMethods_ServiceMethod();
				serviceMethod.AppName = _ctx.StringValue("ListMethods.ServiceMethodList["+ i +"].AppName");
				serviceMethod.ServiceName = _ctx.StringValue("ListMethods.ServiceMethodList["+ i +"].ServiceName");
				serviceMethod.MethodName = _ctx.StringValue("ListMethods.ServiceMethodList["+ i +"].MethodName");
				serviceMethod.Output = _ctx.StringValue("ListMethods.ServiceMethodList["+ i +"].Output");

				List<string> serviceMethod_inputParams = new List<string>();
				for (int j = 0; j < _ctx.Length("ListMethods.ServiceMethodList["+ i +"].InputParams.Length"); j++) {
					serviceMethod_inputParams.Add(_ctx.StringValue("ListMethods.ServiceMethodList["+ i +"].InputParams["+ j +"]"));
				}
				serviceMethod.InputParams = serviceMethod_inputParams;

				List<string> serviceMethod_paramTypes = new List<string>();
				for (int j = 0; j < _ctx.Length("ListMethods.ServiceMethodList["+ i +"].ParamTypes.Length"); j++) {
					serviceMethod_paramTypes.Add(_ctx.StringValue("ListMethods.ServiceMethodList["+ i +"].ParamTypes["+ j +"]"));
				}
				serviceMethod.ParamTypes = serviceMethod_paramTypes;

				listMethodsResponse_serviceMethodList.Add(serviceMethod);
			}
			listMethodsResponse.ServiceMethodList = listMethodsResponse_serviceMethodList;
        
			return listMethodsResponse;
        }
    }
}
