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
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeExtensiveDomainDataResponseUnmarshaller
    {
        public static DescribeExtensiveDomainDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeExtensiveDomainDataResponse describeExtensiveDomainDataResponse = new DescribeExtensiveDomainDataResponse();

			describeExtensiveDomainDataResponse.HttpResponse = context.HttpResponse;
			describeExtensiveDomainDataResponse.RequestId = context.StringValue("DescribeExtensiveDomainData.RequestId");
			describeExtensiveDomainDataResponse.ExtensiveDomain = context.StringValue("DescribeExtensiveDomainData.ExtensiveDomain");
			describeExtensiveDomainDataResponse.DataInterval = context.StringValue("DescribeExtensiveDomainData.DataInterval");
			describeExtensiveDomainDataResponse.StartTime = context.StringValue("DescribeExtensiveDomainData.StartTime");
			describeExtensiveDomainDataResponse.EndTime = context.StringValue("DescribeExtensiveDomainData.EndTime");
			describeExtensiveDomainDataResponse.PageNumber = context.StringValue("DescribeExtensiveDomainData.PageNumber");
			describeExtensiveDomainDataResponse.TotalCount = context.StringValue("DescribeExtensiveDomainData.TotalCount");
			describeExtensiveDomainDataResponse.PageSize = context.StringValue("DescribeExtensiveDomainData.PageSize");

			List<DescribeExtensiveDomainDataResponse.DescribeExtensiveDomainData_UsageData> describeExtensiveDomainDataResponse_dataPerInterval = new List<DescribeExtensiveDomainDataResponse.DescribeExtensiveDomainData_UsageData>();
			for (int i = 0; i < context.Length("DescribeExtensiveDomainData.DataPerInterval.Length"); i++) {
				DescribeExtensiveDomainDataResponse.DescribeExtensiveDomainData_UsageData usageData = new DescribeExtensiveDomainDataResponse.DescribeExtensiveDomainData_UsageData();
				usageData.ExactDomain = context.StringValue("DescribeExtensiveDomainData.DataPerInterval["+ i +"].ExactDomain");
				usageData.TimeStamp = context.StringValue("DescribeExtensiveDomainData.DataPerInterval["+ i +"].TimeStamp");
				usageData.Acc = context.StringValue("DescribeExtensiveDomainData.DataPerInterval["+ i +"].Acc");
				usageData.Flow = context.StringValue("DescribeExtensiveDomainData.DataPerInterval["+ i +"].Flow");

				describeExtensiveDomainDataResponse_dataPerInterval.Add(usageData);
			}
			describeExtensiveDomainDataResponse.DataPerInterval = describeExtensiveDomainDataResponse_dataPerInterval;
        
			return describeExtensiveDomainDataResponse;
        }
    }
}