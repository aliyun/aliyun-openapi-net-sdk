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
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeApisBySignatureResponseUnmarshaller
    {
        public static DescribeApisBySignatureResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApisBySignatureResponse describeApisBySignatureResponse = new DescribeApisBySignatureResponse();

			describeApisBySignatureResponse.HttpResponse = context.HttpResponse;
			describeApisBySignatureResponse.RequestId = context.StringValue("DescribeApisBySignature.RequestId");
			describeApisBySignatureResponse.TotalCount = context.IntegerValue("DescribeApisBySignature.TotalCount");
			describeApisBySignatureResponse.PageSize = context.IntegerValue("DescribeApisBySignature.PageSize");
			describeApisBySignatureResponse.PageNumber = context.IntegerValue("DescribeApisBySignature.PageNumber");

			List<DescribeApisBySignatureResponse.ApiInfo> apiInfos = new List<DescribeApisBySignatureResponse.ApiInfo>();
			for (int i = 0; i < context.Length("DescribeApisBySignature.ApiInfos.Length"); i++) {
				DescribeApisBySignatureResponse.ApiInfo apiInfo = new DescribeApisBySignatureResponse.ApiInfo();
				apiInfo.RegionId = context.StringValue("DescribeApisBySignature.ApiInfos["+ i +"].RegionId");
				apiInfo.GroupId = context.StringValue("DescribeApisBySignature.ApiInfos["+ i +"].GroupId");
				apiInfo.GroupName = context.StringValue("DescribeApisBySignature.ApiInfos["+ i +"].GroupName");
				apiInfo.StageName = context.StringValue("DescribeApisBySignature.ApiInfos["+ i +"].StageName");
				apiInfo.ApiId = context.StringValue("DescribeApisBySignature.ApiInfos["+ i +"].ApiId");
				apiInfo.ApiName = context.StringValue("DescribeApisBySignature.ApiInfos["+ i +"].ApiName");
				apiInfo.Description = context.StringValue("DescribeApisBySignature.ApiInfos["+ i +"].Description");
				apiInfo.Visibility = context.StringValue("DescribeApisBySignature.ApiInfos["+ i +"].Visibility");
				apiInfo.BoundTime = context.StringValue("DescribeApisBySignature.ApiInfos["+ i +"].BoundTime");

				apiInfos.Add(apiInfo);
			}
			describeApisBySignatureResponse.ApiInfos = apiInfos;
        
			return describeApisBySignatureResponse;
        }
    }
}