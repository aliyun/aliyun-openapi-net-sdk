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
using Aliyun.Acs.R_kvstore.Model.V20150101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeMonthlyServiceStatusResponseUnmarshaller
    {
        public static DescribeMonthlyServiceStatusResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMonthlyServiceStatusResponse describeMonthlyServiceStatusResponse = new DescribeMonthlyServiceStatusResponse();

			describeMonthlyServiceStatusResponse.HttpResponse = context.HttpResponse;
			describeMonthlyServiceStatusResponse.RequestId = context.StringValue("DescribeMonthlyServiceStatus.RequestId");
			describeMonthlyServiceStatusResponse.TotalCount = context.LongValue("DescribeMonthlyServiceStatus.TotalCount");

			List<DescribeMonthlyServiceStatusResponse.DescribeMonthlyServiceStatus_InstanceSLAInfo> describeMonthlyServiceStatusResponse_instanceSLAInfos = new List<DescribeMonthlyServiceStatusResponse.DescribeMonthlyServiceStatus_InstanceSLAInfo>();
			for (int i = 0; i < context.Length("DescribeMonthlyServiceStatus.InstanceSLAInfos.Length"); i++) {
				DescribeMonthlyServiceStatusResponse.DescribeMonthlyServiceStatus_InstanceSLAInfo instanceSLAInfo = new DescribeMonthlyServiceStatusResponse.DescribeMonthlyServiceStatus_InstanceSLAInfo();
				instanceSLAInfo.InstanceId = context.StringValue("DescribeMonthlyServiceStatus.InstanceSLAInfos["+ i +"].InstanceId");
				instanceSLAInfo.UptimePct = context.FloatValue("DescribeMonthlyServiceStatus.InstanceSLAInfos["+ i +"].UptimePct");

				describeMonthlyServiceStatusResponse_instanceSLAInfos.Add(instanceSLAInfo);
			}
			describeMonthlyServiceStatusResponse.InstanceSLAInfos = describeMonthlyServiceStatusResponse_instanceSLAInfos;
        
			return describeMonthlyServiceStatusResponse;
        }
    }
}