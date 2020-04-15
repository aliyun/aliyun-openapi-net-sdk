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
using Aliyun.Acs.Netana.Model.V20181018;

namespace Aliyun.Acs.Netana.Transform.V20181018
{
    public class DescribeNetworkQuotaRequestResultResponseUnmarshaller
    {
        public static DescribeNetworkQuotaRequestResultResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNetworkQuotaRequestResultResponse describeNetworkQuotaRequestResultResponse = new DescribeNetworkQuotaRequestResultResponse();

			describeNetworkQuotaRequestResultResponse.HttpResponse = context.HttpResponse;
			describeNetworkQuotaRequestResultResponse.RequestId = context.StringValue("DescribeNetworkQuotaRequestResult.RequestId");
			describeNetworkQuotaRequestResultResponse.TotalCount = context.IntegerValue("DescribeNetworkQuotaRequestResult.TotalCount");
			describeNetworkQuotaRequestResultResponse.PageNumber = context.IntegerValue("DescribeNetworkQuotaRequestResult.PageNumber");
			describeNetworkQuotaRequestResultResponse.PageSize = context.IntegerValue("DescribeNetworkQuotaRequestResult.PageSize");

			List<DescribeNetworkQuotaRequestResultResponse.DescribeNetworkQuotaRequestResult_QuotaRequest> describeNetworkQuotaRequestResultResponse_quotaRequests = new List<DescribeNetworkQuotaRequestResultResponse.DescribeNetworkQuotaRequestResult_QuotaRequest>();
			for (int i = 0; i < context.Length("DescribeNetworkQuotaRequestResult.QuotaRequests.Length"); i++) {
				DescribeNetworkQuotaRequestResultResponse.DescribeNetworkQuotaRequestResult_QuotaRequest quotaRequest = new DescribeNetworkQuotaRequestResultResponse.DescribeNetworkQuotaRequestResult_QuotaRequest();
				quotaRequest.RegionId = context.StringValue("DescribeNetworkQuotaRequestResult.QuotaRequests["+ i +"].RegionId");
				quotaRequest.Product = context.StringValue("DescribeNetworkQuotaRequestResult.QuotaRequests["+ i +"].Product");
				quotaRequest.RequestId = context.StringValue("DescribeNetworkQuotaRequestResult.QuotaRequests["+ i +"].RequestId");
				quotaRequest.ResourceType = context.StringValue("DescribeNetworkQuotaRequestResult.QuotaRequests["+ i +"].ResourceType");
				quotaRequest.QuotaPublicityName = context.StringValue("DescribeNetworkQuotaRequestResult.QuotaRequests["+ i +"].QuotaPublicityName");
				quotaRequest.RequestReason = context.StringValue("DescribeNetworkQuotaRequestResult.QuotaRequests["+ i +"].RequestReason");
				quotaRequest.MobilePhone = context.StringValue("DescribeNetworkQuotaRequestResult.QuotaRequests["+ i +"].MobilePhone");
				quotaRequest.Email = context.StringValue("DescribeNetworkQuotaRequestResult.QuotaRequests["+ i +"].Email");
				quotaRequest.RequestResult = context.StringValue("DescribeNetworkQuotaRequestResult.QuotaRequests["+ i +"].RequestResult");
				quotaRequest.RequestQuantity = context.StringValue("DescribeNetworkQuotaRequestResult.QuotaRequests["+ i +"].RequestQuantity");
				quotaRequest.ResultReason = context.StringValue("DescribeNetworkQuotaRequestResult.QuotaRequests["+ i +"].ResultReason");
				quotaRequest.CreateTime = context.StringValue("DescribeNetworkQuotaRequestResult.QuotaRequests["+ i +"].CreateTime");
				quotaRequest.ResultQuantity = context.StringValue("DescribeNetworkQuotaRequestResult.QuotaRequests["+ i +"].ResultQuantity");

				describeNetworkQuotaRequestResultResponse_quotaRequests.Add(quotaRequest);
			}
			describeNetworkQuotaRequestResultResponse.QuotaRequests = describeNetworkQuotaRequestResultResponse_quotaRequests;
        
			return describeNetworkQuotaRequestResultResponse;
        }
    }
}
