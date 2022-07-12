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
using Aliyun.Acs.antiddos_public.Model.V20170518;

namespace Aliyun.Acs.antiddos_public.Transform.V20170518
{
    public class DescribeInstanceResponseUnmarshaller
    {
        public static DescribeInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceResponse describeInstanceResponse = new DescribeInstanceResponse();

			describeInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceResponse.Total = _ctx.IntegerValue("DescribeInstance.Total");
			describeInstanceResponse.RequestId = _ctx.StringValue("DescribeInstance.RequestId");

			List<DescribeInstanceResponse.DescribeInstance_Instance> describeInstanceResponse_instanceList = new List<DescribeInstanceResponse.DescribeInstance_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeInstance.InstanceList.Length"); i++) {
				DescribeInstanceResponse.DescribeInstance_Instance instance = new DescribeInstanceResponse.DescribeInstance_Instance();
				instance.InstanceIp = _ctx.StringValue("DescribeInstance.InstanceList["+ i +"].InstanceIp");
				instance.IsBgppack = _ctx.BooleanValue("DescribeInstance.InstanceList["+ i +"].IsBgppack");
				instance.IpVersion = _ctx.StringValue("DescribeInstance.InstanceList["+ i +"].IpVersion");
				instance.ElasticThreshold = _ctx.IntegerValue("DescribeInstance.InstanceList["+ i +"].ElasticThreshold");
				instance.BlackholeThreshold = _ctx.IntegerValue("DescribeInstance.InstanceList["+ i +"].BlackholeThreshold");
				instance.DefenseBpsThreshold = _ctx.IntegerValue("DescribeInstance.InstanceList["+ i +"].DefenseBpsThreshold");
				instance.InstanceName = _ctx.StringValue("DescribeInstance.InstanceList["+ i +"].InstanceName");
				instance.InstanceStatus = _ctx.StringValue("DescribeInstance.InstanceList["+ i +"].InstanceStatus");
				instance.DefensePpsThreshold = _ctx.IntegerValue("DescribeInstance.InstanceList["+ i +"].DefensePpsThreshold");
				instance.InstanceId = _ctx.StringValue("DescribeInstance.InstanceList["+ i +"].InstanceId");
				instance.InstanceType = _ctx.StringValue("DescribeInstance.InstanceList["+ i +"].InstanceType");

				describeInstanceResponse_instanceList.Add(instance);
			}
			describeInstanceResponse.InstanceList = describeInstanceResponse_instanceList;
        
			return describeInstanceResponse;
        }
    }
}
