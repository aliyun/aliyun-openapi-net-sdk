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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CloudPhoto.Model.V20170711;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class GetPrivateAccessUrlsResponseUnmarshaller
    {
        public static GetPrivateAccessUrlsResponse Unmarshall(UnmarshallerContext context)
        {
			GetPrivateAccessUrlsResponse getPrivateAccessUrlsResponse = new GetPrivateAccessUrlsResponse();

			getPrivateAccessUrlsResponse.HttpResponse = context.HttpResponse;
			getPrivateAccessUrlsResponse.Code = context.StringValue("GetPrivateAccessUrls.Code");
			getPrivateAccessUrlsResponse.Message = context.StringValue("GetPrivateAccessUrls.Message");
			getPrivateAccessUrlsResponse.RequestId = context.StringValue("GetPrivateAccessUrls.RequestId");
			getPrivateAccessUrlsResponse.Action = context.StringValue("GetPrivateAccessUrls.Action");

			List<GetPrivateAccessUrlsResponse.GetPrivateAccessUrls_Result> getPrivateAccessUrlsResponse_results = new List<GetPrivateAccessUrlsResponse.GetPrivateAccessUrls_Result>();
			for (int i = 0; i < context.Length("GetPrivateAccessUrls.Results.Length"); i++) {
				GetPrivateAccessUrlsResponse.GetPrivateAccessUrls_Result result = new GetPrivateAccessUrlsResponse.GetPrivateAccessUrls_Result();
				result.Code = context.StringValue("GetPrivateAccessUrls.Results["+ i +"].Code");
				result.Message = context.StringValue("GetPrivateAccessUrls.Results["+ i +"].Message");
				result.PhotoId = context.LongValue("GetPrivateAccessUrls.Results["+ i +"].PhotoId");
				result.AccessUrl = context.StringValue("GetPrivateAccessUrls.Results["+ i +"].AccessUrl");

				getPrivateAccessUrlsResponse_results.Add(result);
			}
			getPrivateAccessUrlsResponse.Results = getPrivateAccessUrlsResponse_results;
        
			return getPrivateAccessUrlsResponse;
        }
    }
}