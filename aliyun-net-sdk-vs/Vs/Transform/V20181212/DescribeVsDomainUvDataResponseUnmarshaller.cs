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
        public static DescribeVsDomainUvDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVsDomainUvDataResponse describeVsDomainUvDataResponse = new DescribeVsDomainUvDataResponse();

			describeVsDomainUvDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVsDomainUvDataResponse.RequestId = _ctx.StringValue("DescribeVsDomainUvData.RequestId");
			describeVsDomainUvDataResponse.DomainName = _ctx.StringValue("DescribeVsDomainUvData.DomainName");
			describeVsDomainUvDataResponse.StartTime = _ctx.StringValue("DescribeVsDomainUvData.StartTime");
			describeVsDomainUvDataResponse.EndTime = _ctx.StringValue("DescribeVsDomainUvData.EndTime");
			describeVsDomainUvDataResponse.DataInterval = _ctx.StringValue("DescribeVsDomainUvData.DataInterval");

			List<DescribeVsDomainUvDataResponse.DescribeVsDomainUvData_UsageData> describeVsDomainUvDataResponse_uvDataInterval = new List<DescribeVsDomainUvDataResponse.DescribeVsDomainUvData_UsageData>();
			for (int i = 0; i < _ctx.Length("DescribeVsDomainUvData.UvDataInterval.Length"); i++) {
				DescribeVsDomainUvDataResponse.DescribeVsDomainUvData_UsageData usageData = new DescribeVsDomainUvDataResponse.DescribeVsDomainUvData_UsageData();
				usageData._Value = _ctx.StringValue("DescribeVsDomainUvData.UvDataInterval["+ i +"].Value");
				usageData.TimeStamp = _ctx.StringValue("DescribeVsDomainUvData.UvDataInterval["+ i +"].TimeStamp");

				describeVsDomainUvDataResponse_uvDataInterval.Add(usageData);
			}
			describeVsDomainUvDataResponse.UvDataInterval = describeVsDomainUvDataResponse_uvDataInterval;
        
			return describeVsDomainUvDataResponse;
        }
    }
}
