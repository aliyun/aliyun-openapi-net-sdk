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
    public class DescribeVsDomainReqTrafficDataResponseUnmarshaller
    {
        public static DescribeVsDomainReqTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVsDomainReqTrafficDataResponse describeVsDomainReqTrafficDataResponse = new DescribeVsDomainReqTrafficDataResponse();

			describeVsDomainReqTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeVsDomainReqTrafficDataResponse.RequestId = context.StringValue("DescribeVsDomainReqTrafficData.RequestId");
			describeVsDomainReqTrafficDataResponse.DomainName = context.StringValue("DescribeVsDomainReqTrafficData.DomainName");
			describeVsDomainReqTrafficDataResponse.StartTime = context.StringValue("DescribeVsDomainReqTrafficData.StartTime");
			describeVsDomainReqTrafficDataResponse.EndTime = context.StringValue("DescribeVsDomainReqTrafficData.EndTime");
			describeVsDomainReqTrafficDataResponse.DataInterval = context.StringValue("DescribeVsDomainReqTrafficData.DataInterval");

			List<DescribeVsDomainReqTrafficDataResponse.DescribeVsDomainReqTrafficData_DataModule> describeVsDomainReqTrafficDataResponse_reqTrafficDataPerInterval = new List<DescribeVsDomainReqTrafficDataResponse.DescribeVsDomainReqTrafficData_DataModule>();
			for (int i = 0; i < context.Length("DescribeVsDomainReqTrafficData.ReqTrafficDataPerInterval.Length"); i++) {
				DescribeVsDomainReqTrafficDataResponse.DescribeVsDomainReqTrafficData_DataModule dataModule = new DescribeVsDomainReqTrafficDataResponse.DescribeVsDomainReqTrafficData_DataModule();
				dataModule.TimeStamp = context.StringValue("DescribeVsDomainReqTrafficData.ReqTrafficDataPerInterval["+ i +"].TimeStamp");
				dataModule.ReqTrafficValue = context.StringValue("DescribeVsDomainReqTrafficData.ReqTrafficDataPerInterval["+ i +"].ReqTrafficValue");

				describeVsDomainReqTrafficDataResponse_reqTrafficDataPerInterval.Add(dataModule);
			}
			describeVsDomainReqTrafficDataResponse.ReqTrafficDataPerInterval = describeVsDomainReqTrafficDataResponse_reqTrafficDataPerInterval;
        
			return describeVsDomainReqTrafficDataResponse;
        }
    }
}
