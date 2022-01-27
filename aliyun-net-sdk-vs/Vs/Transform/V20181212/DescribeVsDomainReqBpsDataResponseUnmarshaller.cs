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
    public class DescribeVsDomainReqBpsDataResponseUnmarshaller
    {
        public static DescribeVsDomainReqBpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVsDomainReqBpsDataResponse describeVsDomainReqBpsDataResponse = new DescribeVsDomainReqBpsDataResponse();

			describeVsDomainReqBpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVsDomainReqBpsDataResponse.RequestId = _ctx.StringValue("DescribeVsDomainReqBpsData.RequestId");
			describeVsDomainReqBpsDataResponse.DomainName = _ctx.StringValue("DescribeVsDomainReqBpsData.DomainName");
			describeVsDomainReqBpsDataResponse.StartTime = _ctx.StringValue("DescribeVsDomainReqBpsData.StartTime");
			describeVsDomainReqBpsDataResponse.EndTime = _ctx.StringValue("DescribeVsDomainReqBpsData.EndTime");
			describeVsDomainReqBpsDataResponse.DataInterval = _ctx.StringValue("DescribeVsDomainReqBpsData.DataInterval");

			List<DescribeVsDomainReqBpsDataResponse.DescribeVsDomainReqBpsData_DataModule> describeVsDomainReqBpsDataResponse_reqBpsDataPerInterval = new List<DescribeVsDomainReqBpsDataResponse.DescribeVsDomainReqBpsData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeVsDomainReqBpsData.ReqBpsDataPerInterval.Length"); i++) {
				DescribeVsDomainReqBpsDataResponse.DescribeVsDomainReqBpsData_DataModule dataModule = new DescribeVsDomainReqBpsDataResponse.DescribeVsDomainReqBpsData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeVsDomainReqBpsData.ReqBpsDataPerInterval["+ i +"].TimeStamp");
				dataModule.ReqBpsValue = _ctx.StringValue("DescribeVsDomainReqBpsData.ReqBpsDataPerInterval["+ i +"].ReqBpsValue");

				describeVsDomainReqBpsDataResponse_reqBpsDataPerInterval.Add(dataModule);
			}
			describeVsDomainReqBpsDataResponse.ReqBpsDataPerInterval = describeVsDomainReqBpsDataResponse_reqBpsDataPerInterval;
        
			return describeVsDomainReqBpsDataResponse;
        }
    }
}
