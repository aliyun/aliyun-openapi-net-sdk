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
    public class DescribeInstanceInfoResponseUnmarshaller
    {
        public static DescribeInstanceInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceInfoResponse describeInstanceInfoResponse = new DescribeInstanceInfoResponse();

			describeInstanceInfoResponse.HttpResponse = context.HttpResponse;
			describeInstanceInfoResponse.RequestId = context.StringValue("DescribeInstanceInfo.RequestId");

			DescribeInstanceInfoResponse.DescribeInstanceInfo_InstanceInfo instanceInfo = new DescribeInstanceInfoResponse.DescribeInstanceInfo_InstanceInfo();
			instanceInfo.InDebt = context.IntegerValue("DescribeInstanceInfo.InstanceInfo.InDebt");
			instanceInfo.InstanceId = context.StringValue("DescribeInstanceInfo.InstanceInfo.InstanceId");
			instanceInfo.PayType = context.IntegerValue("DescribeInstanceInfo.InstanceInfo.PayType");
			instanceInfo.EndDate = context.LongValue("DescribeInstanceInfo.InstanceInfo.EndDate");
			instanceInfo.RemainDay = context.IntegerValue("DescribeInstanceInfo.InstanceInfo.RemainDay");
			instanceInfo.Region = context.StringValue("DescribeInstanceInfo.InstanceInfo.Region");
			instanceInfo.Trial = context.IntegerValue("DescribeInstanceInfo.InstanceInfo.Trial");
			instanceInfo.Status = context.IntegerValue("DescribeInstanceInfo.InstanceInfo.Status");
			instanceInfo.SubscriptionType = context.StringValue("DescribeInstanceInfo.InstanceInfo.SubscriptionType");
			describeInstanceInfoResponse.InstanceInfo = instanceInfo;
        
			return describeInstanceInfoResponse;
        }
    }
}
