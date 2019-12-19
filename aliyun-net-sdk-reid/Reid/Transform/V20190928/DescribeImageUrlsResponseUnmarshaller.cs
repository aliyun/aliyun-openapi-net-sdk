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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class DescribeImageUrlsResponseUnmarshaller
    {
        public static DescribeImageUrlsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeImageUrlsResponse describeImageUrlsResponse = new DescribeImageUrlsResponse();

			describeImageUrlsResponse.HttpResponse = context.HttpResponse;
			describeImageUrlsResponse.ErrorCode = context.StringValue("DescribeImageUrls.ErrorCode");
			describeImageUrlsResponse.ErrorMessage = context.StringValue("DescribeImageUrls.ErrorMessage");
			describeImageUrlsResponse.RequestId = context.StringValue("DescribeImageUrls.RequestId");
			describeImageUrlsResponse.Success = context.BooleanValue("DescribeImageUrls.Success");

			List<DescribeImageUrlsResponse.DescribeImageUrls_ImageUrl> describeImageUrlsResponse_urls = new List<DescribeImageUrlsResponse.DescribeImageUrls_ImageUrl>();
			for (int i = 0; i < context.Length("DescribeImageUrls.Urls.Length"); i++) {
				DescribeImageUrlsResponse.DescribeImageUrls_ImageUrl imageUrl = new DescribeImageUrlsResponse.DescribeImageUrls_ImageUrl();
				imageUrl.ObjectKey = context.StringValue("DescribeImageUrls.Urls["+ i +"].ObjectKey");
				imageUrl.Url = context.StringValue("DescribeImageUrls.Urls["+ i +"].Url");

				describeImageUrlsResponse_urls.Add(imageUrl);
			}
			describeImageUrlsResponse.Urls = describeImageUrlsResponse_urls;
        
			return describeImageUrlsResponse;
        }
    }
}
