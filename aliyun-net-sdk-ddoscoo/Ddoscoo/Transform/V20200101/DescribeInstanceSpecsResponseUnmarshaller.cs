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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
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
				instanceSpec.InstanceId = _ctx.StringValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].InstanceId");
				instanceSpec.BaseBandwidth = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].BaseBandwidth");
				instanceSpec.ElasticBandwidth = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].ElasticBandwidth");
				instanceSpec.PortLimit = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].PortLimit");
				instanceSpec.SiteLimit = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].SiteLimit");
				instanceSpec.DomainLimit = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].DomainLimit");
				instanceSpec.BandwidthMbps = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].BandwidthMbps");
				instanceSpec.DefenseCount = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].DefenseCount");
				instanceSpec.FunctionVersion = _ctx.StringValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].FunctionVersion");
				instanceSpec.QpsLimit = _ctx.IntegerValue("DescribeInstanceSpecs.InstanceSpecs["+ i +"].QpsLimit");

				describeInstanceSpecsResponse_instanceSpecs.Add(instanceSpec);
			}
			describeInstanceSpecsResponse.InstanceSpecs = describeInstanceSpecsResponse_instanceSpecs;
        
			return describeInstanceSpecsResponse;
        }
    }
}
