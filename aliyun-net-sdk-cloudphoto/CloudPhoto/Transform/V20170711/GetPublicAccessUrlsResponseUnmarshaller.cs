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
    public class GetPublicAccessUrlsResponseUnmarshaller
    {
        public static GetPublicAccessUrlsResponse Unmarshall(UnmarshallerContext context)
        {
			GetPublicAccessUrlsResponse getPublicAccessUrlsResponse = new GetPublicAccessUrlsResponse();

			getPublicAccessUrlsResponse.HttpResponse = context.HttpResponse;
			getPublicAccessUrlsResponse.Code = context.StringValue("GetPublicAccessUrls.Code");
			getPublicAccessUrlsResponse.Message = context.StringValue("GetPublicAccessUrls.Message");
			getPublicAccessUrlsResponse.RequestId = context.StringValue("GetPublicAccessUrls.RequestId");
			getPublicAccessUrlsResponse.Action = context.StringValue("GetPublicAccessUrls.Action");

			List<GetPublicAccessUrlsResponse.GetPublicAccessUrls_Result> getPublicAccessUrlsResponse_results = new List<GetPublicAccessUrlsResponse.GetPublicAccessUrls_Result>();
			for (int i = 0; i < context.Length("GetPublicAccessUrls.Results.Length"); i++) {
				GetPublicAccessUrlsResponse.GetPublicAccessUrls_Result result = new GetPublicAccessUrlsResponse.GetPublicAccessUrls_Result();
				result.Code = context.StringValue("GetPublicAccessUrls.Results["+ i +"].Code");
				result.Message = context.StringValue("GetPublicAccessUrls.Results["+ i +"].Message");
				result.PhotoId = context.LongValue("GetPublicAccessUrls.Results["+ i +"].PhotoId");
				result.AccessUrl = context.StringValue("GetPublicAccessUrls.Results["+ i +"].AccessUrl");

				getPublicAccessUrlsResponse_results.Add(result);
			}
			getPublicAccessUrlsResponse.Results = getPublicAccessUrlsResponse_results;
        
			return getPublicAccessUrlsResponse;
        }
    }
}