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
    public class DescribeInstanceAttributeResponseUnmarshaller
    {
        public static DescribeInstanceAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceAttributeResponse describeInstanceAttributeResponse = new DescribeInstanceAttributeResponse();

			describeInstanceAttributeResponse.HttpResponse = context.HttpResponse;
			describeInstanceAttributeResponse.RequestId = context.StringValue("DescribeInstanceAttribute.RequestId");

			List<DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DBInstanceAttribute> describeInstanceAttributeResponse_instances = new List<DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DBInstanceAttribute>();
			for (int i = 0; i < context.Length("DescribeInstanceAttribute.Instances.Length"); i++) {
				DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DBInstanceAttribute dBInstanceAttribute = new DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DBInstanceAttribute();
				dBInstanceAttribute.InstanceId = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].InstanceId");
				dBInstanceAttribute.InstanceName = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].InstanceName");
				dBInstanceAttribute.ConnectionDomain = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].ConnectionDomain");
				dBInstanceAttribute.Port = context.LongValue("DescribeInstanceAttribute.Instances["+ i +"].Port");
				dBInstanceAttribute.InstanceStatus = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].InstanceStatus");
				dBInstanceAttribute.RegionId = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].RegionId");
				dBInstanceAttribute.Capacity = context.LongValue("DescribeInstanceAttribute.Instances["+ i +"].Capacity");
				dBInstanceAttribute.InstanceClass = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].InstanceClass");
				dBInstanceAttribute.QPS = context.LongValue("DescribeInstanceAttribute.Instances["+ i +"].QPS");
				dBInstanceAttribute.Bandwidth = context.LongValue("DescribeInstanceAttribute.Instances["+ i +"].Bandwidth");
				dBInstanceAttribute.Connections = context.LongValue("DescribeInstanceAttribute.Instances["+ i +"].Connections");
				dBInstanceAttribute.ZoneId = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].ZoneId");
				dBInstanceAttribute.Config = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].Config");
				dBInstanceAttribute.ChargeType = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].ChargeType");
				dBInstanceAttribute.NodeType = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].NodeType");
				dBInstanceAttribute.NetworkType = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].NetworkType");
				dBInstanceAttribute.VpcId = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].VpcId");
				dBInstanceAttribute.VSwitchId = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].VSwitchId");
				dBInstanceAttribute.PrivateIp = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].PrivateIp");
				dBInstanceAttribute.CreateTime = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].CreateTime");
				dBInstanceAttribute.EndTime = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].EndTime");
				dBInstanceAttribute.HasRenewChangeOrder = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].HasRenewChangeOrder");
				dBInstanceAttribute.IsRds = context.BooleanValue("DescribeInstanceAttribute.Instances["+ i +"].IsRds");
				dBInstanceAttribute.Engine = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].Engine");
				dBInstanceAttribute.EngineVersion = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].EngineVersion");
				dBInstanceAttribute.MaintainStartTime = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].MaintainStartTime");
				dBInstanceAttribute.MaintainEndTime = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].MaintainEndTime");
				dBInstanceAttribute.AvailabilityValue = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].AvailabilityValue");
				dBInstanceAttribute.SecurityIPList = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].SecurityIPList");
				dBInstanceAttribute.InstanceType = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].InstanceType");
				dBInstanceAttribute.ArchitectureType = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].ArchitectureType");
				dBInstanceAttribute.NodeType1 = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].NodeType");
				dBInstanceAttribute.PackageType = context.StringValue("DescribeInstanceAttribute.Instances["+ i +"].PackageType");

				describeInstanceAttributeResponse_instances.Add(dBInstanceAttribute);
			}
			describeInstanceAttributeResponse.Instances = describeInstanceAttributeResponse_instances;
        
			return describeInstanceAttributeResponse;
        }
    }
}