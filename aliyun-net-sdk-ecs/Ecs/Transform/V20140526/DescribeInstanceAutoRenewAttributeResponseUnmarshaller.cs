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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeInstanceAutoRenewAttributeResponseUnmarshaller
    {
        public static DescribeInstanceAutoRenewAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceAutoRenewAttributeResponse describeInstanceAutoRenewAttributeResponse = new DescribeInstanceAutoRenewAttributeResponse();

			describeInstanceAutoRenewAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceAutoRenewAttributeResponse.RequestId = _ctx.StringValue("DescribeInstanceAutoRenewAttribute.RequestId");
			describeInstanceAutoRenewAttributeResponse.PageNumber = _ctx.IntegerValue("DescribeInstanceAutoRenewAttribute.PageNumber");
			describeInstanceAutoRenewAttributeResponse.PageSize = _ctx.IntegerValue("DescribeInstanceAutoRenewAttribute.PageSize");
			describeInstanceAutoRenewAttributeResponse.TotalCount = _ctx.IntegerValue("DescribeInstanceAutoRenewAttribute.TotalCount");

			List<DescribeInstanceAutoRenewAttributeResponse.DescribeInstanceAutoRenewAttribute_InstanceRenewAttribute> describeInstanceAutoRenewAttributeResponse_instanceRenewAttributes = new List<DescribeInstanceAutoRenewAttributeResponse.DescribeInstanceAutoRenewAttribute_InstanceRenewAttribute>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceAutoRenewAttribute.InstanceRenewAttributes.Length"); i++) {
				DescribeInstanceAutoRenewAttributeResponse.DescribeInstanceAutoRenewAttribute_InstanceRenewAttribute instanceRenewAttribute = new DescribeInstanceAutoRenewAttributeResponse.DescribeInstanceAutoRenewAttribute_InstanceRenewAttribute();
				instanceRenewAttribute.InstanceId = _ctx.StringValue("DescribeInstanceAutoRenewAttribute.InstanceRenewAttributes["+ i +"].InstanceId");
				instanceRenewAttribute.AutoRenewEnabled = _ctx.BooleanValue("DescribeInstanceAutoRenewAttribute.InstanceRenewAttributes["+ i +"].AutoRenewEnabled");
				instanceRenewAttribute.Duration = _ctx.IntegerValue("DescribeInstanceAutoRenewAttribute.InstanceRenewAttributes["+ i +"].Duration");
				instanceRenewAttribute.PeriodUnit = _ctx.StringValue("DescribeInstanceAutoRenewAttribute.InstanceRenewAttributes["+ i +"].PeriodUnit");
				instanceRenewAttribute.RenewalStatus = _ctx.StringValue("DescribeInstanceAutoRenewAttribute.InstanceRenewAttributes["+ i +"].RenewalStatus");

				describeInstanceAutoRenewAttributeResponse_instanceRenewAttributes.Add(instanceRenewAttribute);
			}
			describeInstanceAutoRenewAttributeResponse.InstanceRenewAttributes = describeInstanceAutoRenewAttributeResponse_instanceRenewAttributes;
        
			return describeInstanceAutoRenewAttributeResponse;
        }
    }
}
