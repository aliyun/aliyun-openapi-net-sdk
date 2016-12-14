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
    public class DescribeSignaturesResponseUnmarshaller
    {
        public static DescribeSignaturesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSignaturesResponse describeSignaturesResponse = new DescribeSignaturesResponse();

			describeSignaturesResponse.HttpResponse = context.HttpResponse;
			describeSignaturesResponse.RequestId = context.StringValue("DescribeSignatures.RequestId");
			describeSignaturesResponse.TotalCount = context.IntegerValue("DescribeSignatures.TotalCount");
			describeSignaturesResponse.PageSize = context.IntegerValue("DescribeSignatures.PageSize");
			describeSignaturesResponse.PageNumber = context.IntegerValue("DescribeSignatures.PageNumber");

			List<DescribeSignaturesResponse.SignatureInfo> signatureInfos = new List<DescribeSignaturesResponse.SignatureInfo>();
			for (int i = 0; i < context.Length("DescribeSignatures.SignatureInfos.Length"); i++) {
				DescribeSignaturesResponse.SignatureInfo signatureInfo = new DescribeSignaturesResponse.SignatureInfo();
				signatureInfo.RegionId = context.StringValue("DescribeSignatures.SignatureInfos["+ i +"].RegionId");
				signatureInfo.SignatureId = context.StringValue("DescribeSignatures.SignatureInfos["+ i +"].SignatureId");
				signatureInfo.SignatureName = context.StringValue("DescribeSignatures.SignatureInfos["+ i +"].SignatureName");
				signatureInfo.SignatureKey = context.StringValue("DescribeSignatures.SignatureInfos["+ i +"].SignatureKey");
				signatureInfo.SignatureSecret = context.StringValue("DescribeSignatures.SignatureInfos["+ i +"].SignatureSecret");
				signatureInfo.CreatedTime = context.StringValue("DescribeSignatures.SignatureInfos["+ i +"].CreatedTime");
				signatureInfo.ModifiedTime = context.StringValue("DescribeSignatures.SignatureInfos["+ i +"].ModifiedTime");

				signatureInfos.Add(signatureInfo);
			}
			describeSignaturesResponse.SignatureInfos = signatureInfos;
        
			return describeSignaturesResponse;
        }
    }
}