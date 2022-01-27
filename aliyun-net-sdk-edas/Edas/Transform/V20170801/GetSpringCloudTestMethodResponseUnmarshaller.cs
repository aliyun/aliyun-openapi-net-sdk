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
    public class GetSpringCloudTestMethodResponseUnmarshaller
    {
        public static GetSpringCloudTestMethodResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSpringCloudTestMethodResponse getSpringCloudTestMethodResponse = new GetSpringCloudTestMethodResponse();

			getSpringCloudTestMethodResponse.HttpResponse = _ctx.HttpResponse;
			getSpringCloudTestMethodResponse.Code = _ctx.IntegerValue("GetSpringCloudTestMethod.Code");
			getSpringCloudTestMethodResponse.Message = _ctx.StringValue("GetSpringCloudTestMethod.Message");
			getSpringCloudTestMethodResponse.Success = _ctx.BooleanValue("GetSpringCloudTestMethod.Success");

			GetSpringCloudTestMethodResponse.GetSpringCloudTestMethod_Data data = new GetSpringCloudTestMethodResponse.GetSpringCloudTestMethod_Data();
			data.Path = _ctx.StringValue("GetSpringCloudTestMethod.Data.Path");
			data.HttpHeaders = _ctx.StringValue("GetSpringCloudTestMethod.Data.HttpHeaders");
			data._Params = _ctx.StringValue("GetSpringCloudTestMethod.Data.Params");

			List<string> data_requestMethods = new List<string>();
			for (int i = 0; i < _ctx.Length("GetSpringCloudTestMethod.Data.RequestMethods.Length"); i++) {
				data_requestMethods.Add(_ctx.StringValue("GetSpringCloudTestMethod.Data.RequestMethods["+ i +"]"));
			}
			data.RequestMethods = data_requestMethods;

			List<string> data_urls = new List<string>();
			for (int i = 0; i < _ctx.Length("GetSpringCloudTestMethod.Data.Urls.Length"); i++) {
				data_urls.Add(_ctx.StringValue("GetSpringCloudTestMethod.Data.Urls["+ i +"]"));
			}
			data.Urls = data_urls;
			getSpringCloudTestMethodResponse.Data = data;
        
			return getSpringCloudTestMethodResponse;
        }
    }
}
