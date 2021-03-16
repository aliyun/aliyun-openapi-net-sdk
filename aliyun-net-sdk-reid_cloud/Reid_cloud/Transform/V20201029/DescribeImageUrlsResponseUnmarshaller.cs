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
using Aliyun.Acs.reid_cloud.Model.V20201029;

namespace Aliyun.Acs.reid_cloud.Transform.V20201029
{
    public class DescribeImageUrlsResponseUnmarshaller
    {
        public static DescribeImageUrlsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeImageUrlsResponse describeImageUrlsResponse = new DescribeImageUrlsResponse();

			describeImageUrlsResponse.HttpResponse = _ctx.HttpResponse;
			describeImageUrlsResponse.ErrorCode = _ctx.StringValue("DescribeImageUrls.ErrorCode");
			describeImageUrlsResponse.ErrorMessage = _ctx.StringValue("DescribeImageUrls.ErrorMessage");
			describeImageUrlsResponse.Message = _ctx.StringValue("DescribeImageUrls.Message");
			describeImageUrlsResponse.Code = _ctx.StringValue("DescribeImageUrls.Code");
			describeImageUrlsResponse.DynamicCode = _ctx.StringValue("DescribeImageUrls.DynamicCode");
			describeImageUrlsResponse.RequestId = _ctx.StringValue("DescribeImageUrls.RequestId");
			describeImageUrlsResponse.Success = _ctx.BooleanValue("DescribeImageUrls.Success");
			describeImageUrlsResponse.DynamicMessage = _ctx.StringValue("DescribeImageUrls.DynamicMessage");

			List<DescribeImageUrlsResponse.DescribeImageUrls_ImageUrl> describeImageUrlsResponse_urls = new List<DescribeImageUrlsResponse.DescribeImageUrls_ImageUrl>();
			for (int i = 0; i < _ctx.Length("DescribeImageUrls.Urls.Length"); i++) {
				DescribeImageUrlsResponse.DescribeImageUrls_ImageUrl imageUrl = new DescribeImageUrlsResponse.DescribeImageUrls_ImageUrl();
				imageUrl.ObjectKey = _ctx.StringValue("DescribeImageUrls.Urls["+ i +"].ObjectKey");
				imageUrl.Url = _ctx.StringValue("DescribeImageUrls.Urls["+ i +"].Url");

				describeImageUrlsResponse_urls.Add(imageUrl);
			}
			describeImageUrlsResponse.Urls = describeImageUrlsResponse_urls;
        
			return describeImageUrlsResponse;
        }
    }
}
