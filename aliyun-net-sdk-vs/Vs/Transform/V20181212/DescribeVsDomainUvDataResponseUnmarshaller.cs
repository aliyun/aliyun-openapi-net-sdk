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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeVsDomainUvDataResponseUnmarshaller
    {
        public static DescribeVsDomainUvDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVsDomainUvDataResponse describeVsDomainUvDataResponse = new DescribeVsDomainUvDataResponse();

			describeVsDomainUvDataResponse.HttpResponse = context.HttpResponse;
			describeVsDomainUvDataResponse.RequestId = context.StringValue("DescribeVsDomainUvData.RequestId");
			describeVsDomainUvDataResponse.DomainName = context.StringValue("DescribeVsDomainUvData.DomainName");
			describeVsDomainUvDataResponse.StartTime = context.StringValue("DescribeVsDomainUvData.StartTime");

			List<DescribeVsDomainUvDataResponse.DescribeVsDomainUvData_UsageData> describeVsDomainUvDataResponse_uvDataInterval = new List<DescribeVsDomainUvDataResponse.DescribeVsDomainUvData_UsageData>();
			for (int i = 0; i < context.Length("DescribeVsDomainUvData.UvDataInterval.Length"); i++) {
				DescribeVsDomainUvDataResponse.DescribeVsDomainUvData_UsageData usageData = new DescribeVsDomainUvDataResponse.DescribeVsDomainUvData_UsageData();
				usageData._Value = context.StringValue("DescribeVsDomainUvData.UvDataInterval["+ i +"].Value");
				usageData.TimeStamp = context.StringValue("DescribeVsDomainUvData.UvDataInterval["+ i +"].TimeStamp");

				describeVsDomainUvDataResponse_uvDataInterval.Add(usageData);
			}
			describeVsDomainUvDataResponse.UvDataInterval = describeVsDomainUvDataResponse_uvDataInterval;
        
			return describeVsDomainUvDataResponse;
        }
    }
}
