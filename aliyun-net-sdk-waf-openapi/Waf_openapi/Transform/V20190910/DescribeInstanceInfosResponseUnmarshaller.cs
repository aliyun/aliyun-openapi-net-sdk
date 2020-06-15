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
using Aliyun.Acs.waf_openapi.Model.V20190910;

namespace Aliyun.Acs.waf_openapi.Transform.V20190910
{
    public class DescribeInstanceInfosResponseUnmarshaller
    {
        public static DescribeInstanceInfosResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceInfosResponse describeInstanceInfosResponse = new DescribeInstanceInfosResponse();

			describeInstanceInfosResponse.HttpResponse = context.HttpResponse;
			describeInstanceInfosResponse.RequestId = context.StringValue("DescribeInstanceInfos.RequestId");

			List<DescribeInstanceInfosResponse.DescribeInstanceInfos_InstanceInfo> describeInstanceInfosResponse_instanceInfos = new List<DescribeInstanceInfosResponse.DescribeInstanceInfos_InstanceInfo>();
			for (int i = 0; i < context.Length("DescribeInstanceInfos.InstanceInfos.Length"); i++) {
				DescribeInstanceInfosResponse.DescribeInstanceInfos_InstanceInfo instanceInfo = new DescribeInstanceInfosResponse.DescribeInstanceInfos_InstanceInfo();
				instanceInfo.InDebt = context.IntegerValue("DescribeInstanceInfos.InstanceInfos["+ i +"].InDebt");
				instanceInfo.InstanceId = context.StringValue("DescribeInstanceInfos.InstanceInfos["+ i +"].InstanceId");
				instanceInfo.PayType = context.IntegerValue("DescribeInstanceInfos.InstanceInfos["+ i +"].PayType");
				instanceInfo.EndDate = context.LongValue("DescribeInstanceInfos.InstanceInfos["+ i +"].EndDate");
				instanceInfo.RemainDay = context.IntegerValue("DescribeInstanceInfos.InstanceInfos["+ i +"].RemainDay");
				instanceInfo.Region = context.StringValue("DescribeInstanceInfos.InstanceInfos["+ i +"].Region");
				instanceInfo.Trial = context.IntegerValue("DescribeInstanceInfos.InstanceInfos["+ i +"].Trial");
				instanceInfo.Status = context.IntegerValue("DescribeInstanceInfos.InstanceInfos["+ i +"].Status");
				instanceInfo.SubscriptionType = context.StringValue("DescribeInstanceInfos.InstanceInfos["+ i +"].SubscriptionType");

				describeInstanceInfosResponse_instanceInfos.Add(instanceInfo);
			}
			describeInstanceInfosResponse.InstanceInfos = describeInstanceInfosResponse_instanceInfos;
        
			return describeInstanceInfosResponse;
        }
    }
}
