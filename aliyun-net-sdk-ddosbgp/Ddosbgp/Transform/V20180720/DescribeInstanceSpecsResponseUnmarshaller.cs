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
using Aliyun.Acs.ddosbgp.Model.V20180720;

namespace Aliyun.Acs.ddosbgp.Transform.V20180720
{
    public class DescribeInstanceSpecsResponseUnmarshaller
    {
        public static DescribeInstanceSpecsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceSpecsResponse describeInstanceSpecsResponse = new DescribeInstanceSpecsResponse();

			describeInstanceSpecsResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceSpecsResponse.RequestId = _ctx.StringValue("DescribeInstanceSpecs.RequestId");

			List<DescribeInstanceSpecsResponse.DescribeInstanceSpecs_InstanceSpec> describeInstanceSpecsResponse_instanceSpecs = new List<DescribeInstanceSpecsResponse.DescribeInstanceSpecs_InstanceSpec>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceSpecs.InstanceSpecs.Length"); i++) {
				DescribeInstanceSpecsResponse.DescribeInstanceSpecs_InstanceSpec instanceSpec = new DescribeInstanceSpecsResponse.DescribeInstanceSpecs_InstanceSpec();
				instanceSpec.IsFullDefenseMode = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].IsFullDefenseMode");
				instanceSpec.Region = _ctx.StringValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].Region");
				instanceSpec.AvailableDefenseTimes = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].AvailableDefenseTimes");
				instanceSpec.TotalDefenseTimes = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].TotalDefenseTimes");
				instanceSpec.AvailableDeleteBlackholeCount = _ctx.StringValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].AvailableDeleteBlackholeCount");
				instanceSpec.InstanceId = _ctx.StringValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].InstanceId");

				DescribeInstanceSpecsResponse.DescribeInstanceSpecs_InstanceSpec.DescribeInstanceSpecs_PackConfig packConfig = new DescribeInstanceSpecsResponse.DescribeInstanceSpecs_InstanceSpec.DescribeInstanceSpecs_PackConfig();
				packConfig.PackBasicThre = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].PackConfig.PackBasicThre");
				packConfig.BindIpCount = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].PackConfig.BindIpCount");
				packConfig.PackAdvThre = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].PackConfig.PackAdvThre");
				packConfig.NormalBandwidth = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].PackConfig.NormalBandwidth");
				packConfig.IpBasicThre = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].PackConfig.IpBasicThre");
				packConfig.IpAdvanceThre = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].PackConfig.IpAdvanceThre");
				packConfig.IpSpec = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].PackConfig.IpSpec");
				packConfig.Bandwidth = _ctx.LongValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].PackConfig.Bandwidth");
				instanceSpec.PackConfig = packConfig;

				describeInstanceSpecsResponse_instanceSpecs.Add(instanceSpec);
			}
			describeInstanceSpecsResponse.InstanceSpecs = describeInstanceSpecsResponse_instanceSpecs;
        
			return describeInstanceSpecsResponse;
        }
    }
}
