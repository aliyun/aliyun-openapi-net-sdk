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
    public class GetFramedPhotoUrlsResponseUnmarshaller
    {
        public static GetFramedPhotoUrlsResponse Unmarshall(UnmarshallerContext context)
        {
			GetFramedPhotoUrlsResponse getFramedPhotoUrlsResponse = new GetFramedPhotoUrlsResponse();

			getFramedPhotoUrlsResponse.HttpResponse = context.HttpResponse;
			getFramedPhotoUrlsResponse.Code = context.StringValue("GetFramedPhotoUrls.Code");
			getFramedPhotoUrlsResponse.Message = context.StringValue("GetFramedPhotoUrls.Message");
			getFramedPhotoUrlsResponse.RequestId = context.StringValue("GetFramedPhotoUrls.RequestId");
			getFramedPhotoUrlsResponse.Action = context.StringValue("GetFramedPhotoUrls.Action");

			List<GetFramedPhotoUrlsResponse.GetFramedPhotoUrls_Result> getFramedPhotoUrlsResponse_results = new List<GetFramedPhotoUrlsResponse.GetFramedPhotoUrls_Result>();
			for (int i = 0; i < context.Length("GetFramedPhotoUrls.Results.Length"); i++) {
				GetFramedPhotoUrlsResponse.GetFramedPhotoUrls_Result result = new GetFramedPhotoUrlsResponse.GetFramedPhotoUrls_Result();
				result.Code = context.StringValue("GetFramedPhotoUrls.Results["+ i +"].Code");
				result.Message = context.StringValue("GetFramedPhotoUrls.Results["+ i +"].Message");
				result.PhotoId = context.LongValue("GetFramedPhotoUrls.Results["+ i +"].PhotoId");
				result.FramedPhotoUrl = context.StringValue("GetFramedPhotoUrls.Results["+ i +"].FramedPhotoUrl");

				getFramedPhotoUrlsResponse_results.Add(result);
			}
			getFramedPhotoUrlsResponse.Results = getFramedPhotoUrlsResponse_results;
        
			return getFramedPhotoUrlsResponse;
        }
    }
}