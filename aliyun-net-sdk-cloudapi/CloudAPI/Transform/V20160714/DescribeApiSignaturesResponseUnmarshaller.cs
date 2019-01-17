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
    public class DescribeApiSignaturesResponseUnmarshaller
    {
        public static DescribeApiSignaturesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApiSignaturesResponse describeApiSignaturesResponse = new DescribeApiSignaturesResponse();

			describeApiSignaturesResponse.HttpResponse = context.HttpResponse;
			describeApiSignaturesResponse.RequestId = context.StringValue("DescribeApiSignatures.RequestId");
			describeApiSignaturesResponse.TotalCount = context.IntegerValue("DescribeApiSignatures.TotalCount");
			describeApiSignaturesResponse.PageSize = context.IntegerValue("DescribeApiSignatures.PageSize");
			describeApiSignaturesResponse.PageNumber = context.IntegerValue("DescribeApiSignatures.PageNumber");

			List<DescribeApiSignaturesResponse.DescribeApiSignatures_ApiSignatureItem> describeApiSignaturesResponse_apiSignatures = new List<DescribeApiSignaturesResponse.DescribeApiSignatures_ApiSignatureItem>();
			for (int i = 0; i < context.Length("DescribeApiSignatures.ApiSignatures.Length"); i++) {
				DescribeApiSignaturesResponse.DescribeApiSignatures_ApiSignatureItem apiSignatureItem = new DescribeApiSignaturesResponse.DescribeApiSignatures_ApiSignatureItem();
				apiSignatureItem.ApiId = context.StringValue("DescribeApiSignatures.ApiSignatures["+ i +"].ApiId");
				apiSignatureItem.ApiName = context.StringValue("DescribeApiSignatures.ApiSignatures["+ i +"].ApiName");
				apiSignatureItem.SignatureId = context.StringValue("DescribeApiSignatures.ApiSignatures["+ i +"].SignatureId");
				apiSignatureItem.SignatureName = context.StringValue("DescribeApiSignatures.ApiSignatures["+ i +"].SignatureName");
				apiSignatureItem.BoundTime = context.StringValue("DescribeApiSignatures.ApiSignatures["+ i +"].BoundTime");

				describeApiSignaturesResponse_apiSignatures.Add(apiSignatureItem);
			}
			describeApiSignaturesResponse.ApiSignatures = describeApiSignaturesResponse_apiSignatures;
        
			return describeApiSignaturesResponse;
        }
    }
}