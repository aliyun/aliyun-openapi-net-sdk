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
using Aliyun.Acs.hsm.Model.V20180111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.hsm.Transform.V20180111
{
    public class DescribeInstancesResponseUnmarshaller
    {
        public static DescribeInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstancesResponse describeInstancesResponse = new DescribeInstancesResponse();

			describeInstancesResponse.HttpResponse = context.HttpResponse;
			describeInstancesResponse.RequestId = context.StringValue("DescribeInstances.RequestId");
			describeInstancesResponse.TotalCount = context.IntegerValue("DescribeInstances.TotalCount");

			List<DescribeInstancesResponse.DescribeInstances_Instance> describeInstancesResponse_instances = new List<DescribeInstancesResponse.DescribeInstances_Instance>();
			for (int i = 0; i < context.Length("DescribeInstances.Instances.Length"); i++) {
				DescribeInstancesResponse.DescribeInstances_Instance instance = new DescribeInstancesResponse.DescribeInstances_Instance();
				instance.InstanceId = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceId");
				instance.RegionId = context.StringValue("DescribeInstances.Instances["+ i +"].RegionId");
				instance.ZoneId = context.StringValue("DescribeInstances.Instances["+ i +"].ZoneId");
				instance.HsmStatus = context.IntegerValue("DescribeInstances.Instances["+ i +"].HsmStatus");
				instance.HsmOem = context.StringValue("DescribeInstances.Instances["+ i +"].HsmOem");
				instance.HsmDeviceType = context.StringValue("DescribeInstances.Instances["+ i +"].HsmDeviceType");
				instance.VpcId = context.StringValue("DescribeInstances.Instances["+ i +"].VpcId");
				instance.VswitchId = context.StringValue("DescribeInstances.Instances["+ i +"].VswitchId");
				instance.Ip = context.StringValue("DescribeInstances.Instances["+ i +"].Ip");
				instance.Remark = context.StringValue("DescribeInstances.Instances["+ i +"].Remark");
				instance.ExpiredTime = context.LongValue("DescribeInstances.Instances["+ i +"].ExpiredTime");
				instance.CreateTime = context.LongValue("DescribeInstances.Instances["+ i +"].CreateTime");

				List<string> instance_whiteList = new List<string>();
				for (int j = 0; j < context.Length("DescribeInstances.Instances["+ i +"].WhiteList.Length"); j++) {
					instance_whiteList.Add(context.StringValue("DescribeInstances.Instances["+ i +"].WhiteList["+ j +"]"));
				}
				instance.WhiteList = instance_whiteList;

				describeInstancesResponse_instances.Add(instance);
			}
			describeInstancesResponse.Instances = describeInstancesResponse_instances;
        
			return describeInstancesResponse;
        }
    }
}