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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodDomainUsageDataResponseUnmarshaller
    {
        public static DescribeVodDomainUsageDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainUsageDataResponse describeVodDomainUsageDataResponse = new DescribeVodDomainUsageDataResponse();

			describeVodDomainUsageDataResponse.HttpResponse = context.HttpResponse;
			describeVodDomainUsageDataResponse.RequestId = context.StringValue("DescribeVodDomainUsageData.RequestId");
			describeVodDomainUsageDataResponse.DomainName = context.StringValue("DescribeVodDomainUsageData.DomainName");
			describeVodDomainUsageDataResponse.StartTime = context.StringValue("DescribeVodDomainUsageData.StartTime");
			describeVodDomainUsageDataResponse.EndTime = context.StringValue("DescribeVodDomainUsageData.EndTime");
			describeVodDomainUsageDataResponse.Type = context.StringValue("DescribeVodDomainUsageData.Type");
			describeVodDomainUsageDataResponse.Area = context.StringValue("DescribeVodDomainUsageData.Area");
			describeVodDomainUsageDataResponse.DataInterval = context.StringValue("DescribeVodDomainUsageData.DataInterval");

			List<DescribeVodDomainUsageDataResponse.DescribeVodDomainUsageData_DataModule> describeVodDomainUsageDataResponse_usageDataPerInterval = new List<DescribeVodDomainUsageDataResponse.DescribeVodDomainUsageData_DataModule>();
			for (int i = 0; i < context.Length("DescribeVodDomainUsageData.UsageDataPerInterval.Length"); i++) {
				DescribeVodDomainUsageDataResponse.DescribeVodDomainUsageData_DataModule dataModule = new DescribeVodDomainUsageDataResponse.DescribeVodDomainUsageData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeVodDomainUsageData.UsageDataPerInterval["+ i +"].TimeStamp");
				dataModule._Value = context.StringValue("DescribeVodDomainUsageData.UsageDataPerInterval["+ i +"].Value");

				describeVodDomainUsageDataResponse_usageDataPerInterval.Add(dataModule);
			}
			describeVodDomainUsageDataResponse.UsageDataPerInterval = describeVodDomainUsageDataResponse_usageDataPerInterval;
        
			return describeVodDomainUsageDataResponse;
        }
    }
}
