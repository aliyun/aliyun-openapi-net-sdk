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
using Aliyun.Acs.cusanalytic_sc_online.Model.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524
{
    public class GetImageUrlResponseUnmarshaller
    {
        public static GetImageUrlResponse Unmarshall(UnmarshallerContext context)
        {
			GetImageUrlResponse getImageUrlResponse = new GetImageUrlResponse();

			getImageUrlResponse.HttpResponse = context.HttpResponse;
			getImageUrlResponse.ErrorMsg = context.StringValue("GetImageUrl.ErrorMsg");
			getImageUrlResponse.Success = context.BooleanValue("GetImageUrl.Success");

			List<GetImageUrlResponse.GetImageUrl_ImageUrl> getImageUrlResponse_urls = new List<GetImageUrlResponse.GetImageUrl_ImageUrl>();
			for (int i = 0; i < context.Length("GetImageUrl.Urls.Length"); i++) {
				GetImageUrlResponse.GetImageUrl_ImageUrl imageUrl = new GetImageUrlResponse.GetImageUrl_ImageUrl();
				imageUrl.ObjectKey = context.StringValue("GetImageUrl.Urls["+ i +"].ObjectKey");
				imageUrl.Url = context.StringValue("GetImageUrl.Urls["+ i +"].Url");

				getImageUrlResponse_urls.Add(imageUrl);
			}
			getImageUrlResponse.Urls = getImageUrlResponse_urls;
        
			return getImageUrlResponse;
        }
    }
}
