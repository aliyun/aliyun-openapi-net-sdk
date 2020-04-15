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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeHealthCheckAttributeResponseUnmarshaller
    {
        public static DescribeHealthCheckAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeHealthCheckAttributeResponse describeHealthCheckAttributeResponse = new DescribeHealthCheckAttributeResponse();

			describeHealthCheckAttributeResponse.HttpResponse = context.HttpResponse;
			describeHealthCheckAttributeResponse.RequestId = context.StringValue("DescribeHealthCheckAttribute.RequestId");
			describeHealthCheckAttributeResponse.CreateTime = context.LongValue("DescribeHealthCheckAttribute.CreateTime");
			describeHealthCheckAttributeResponse.HcInstanceId = context.StringValue("DescribeHealthCheckAttribute.HcInstanceId");
			describeHealthCheckAttributeResponse.SmartAGId = context.StringValue("DescribeHealthCheckAttribute.SmartAGId");
			describeHealthCheckAttributeResponse.Name = context.StringValue("DescribeHealthCheckAttribute.Name");
			describeHealthCheckAttributeResponse.Description = context.StringValue("DescribeHealthCheckAttribute.Description");
			describeHealthCheckAttributeResponse.Type = context.StringValue("DescribeHealthCheckAttribute.Type");
			describeHealthCheckAttributeResponse.DstIpAddr = context.StringValue("DescribeHealthCheckAttribute.DstIpAddr");
			describeHealthCheckAttributeResponse.DstPort = context.IntegerValue("DescribeHealthCheckAttribute.DstPort");
			describeHealthCheckAttributeResponse.SrcIpAddr = context.StringValue("DescribeHealthCheckAttribute.SrcIpAddr");
			describeHealthCheckAttributeResponse.SrcPort = context.IntegerValue("DescribeHealthCheckAttribute.SrcPort");
			describeHealthCheckAttributeResponse.ProbeInterval = context.IntegerValue("DescribeHealthCheckAttribute.ProbeInterval");
			describeHealthCheckAttributeResponse.ProbeCount = context.IntegerValue("DescribeHealthCheckAttribute.ProbeCount");
			describeHealthCheckAttributeResponse.ProbeTimeout = context.IntegerValue("DescribeHealthCheckAttribute.ProbeTimeout");
			describeHealthCheckAttributeResponse.RttThreshold = context.IntegerValue("DescribeHealthCheckAttribute.RttThreshold");
			describeHealthCheckAttributeResponse.RttFailThreshold = context.IntegerValue("DescribeHealthCheckAttribute.RttFailThreshold");
			describeHealthCheckAttributeResponse.FailCountThreshold = context.IntegerValue("DescribeHealthCheckAttribute.FailCountThreshold");
        
			return describeHealthCheckAttributeResponse;
        }
    }
}
