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
using Aliyun.Acs.CloudPhoto.Model.V20170711;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class GetDownloadUrlsResponseUnmarshaller
    {
        public static GetDownloadUrlsResponse Unmarshall(UnmarshallerContext context)
        {
			GetDownloadUrlsResponse getDownloadUrlsResponse = new GetDownloadUrlsResponse();

			getDownloadUrlsResponse.HttpResponse = context.HttpResponse;
			getDownloadUrlsResponse.Code = context.StringValue("GetDownloadUrls.Code");
			getDownloadUrlsResponse.Message = context.StringValue("GetDownloadUrls.Message");
			getDownloadUrlsResponse.RequestId = context.StringValue("GetDownloadUrls.RequestId");
			getDownloadUrlsResponse.Action = context.StringValue("GetDownloadUrls.Action");

			List<GetDownloadUrlsResponse.GetDownloadUrls_Result> getDownloadUrlsResponse_results = new List<GetDownloadUrlsResponse.GetDownloadUrls_Result>();
			for (int i = 0; i < context.Length("GetDownloadUrls.Results.Length"); i++) {
				GetDownloadUrlsResponse.GetDownloadUrls_Result result = new GetDownloadUrlsResponse.GetDownloadUrls_Result();
				result.Code = context.StringValue("GetDownloadUrls.Results["+ i +"].Code");
				result.Message = context.StringValue("GetDownloadUrls.Results["+ i +"].Message");
				result.PhotoId = context.LongValue("GetDownloadUrls.Results["+ i +"].PhotoId");
				result.PhotoIdStr = context.StringValue("GetDownloadUrls.Results["+ i +"].PhotoIdStr");
				result.DownloadUrl = context.StringValue("GetDownloadUrls.Results["+ i +"].DownloadUrl");

				getDownloadUrlsResponse_results.Add(result);
			}
			getDownloadUrlsResponse.Results = getDownloadUrlsResponse_results;
        
			return getDownloadUrlsResponse;
        }
    }
}
