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
using Aliyun.Acs.Ess.Model.V20140828;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ess.Transform.V20140828
{
    public class DescribeScalingConfigurationsResponseUnmarshaller
    {
        public static DescribeScalingConfigurationsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScalingConfigurationsResponse describeScalingConfigurationsResponse = new DescribeScalingConfigurationsResponse();

			describeScalingConfigurationsResponse.HttpResponse = context.HttpResponse;
			describeScalingConfigurationsResponse.TotalCount = context.IntegerValue("DescribeScalingConfigurations.TotalCount");
			describeScalingConfigurationsResponse.PageNumber = context.IntegerValue("DescribeScalingConfigurations.PageNumber");
			describeScalingConfigurationsResponse.PageSize = context.IntegerValue("DescribeScalingConfigurations.PageSize");
			describeScalingConfigurationsResponse.RequestId = context.StringValue("DescribeScalingConfigurations.RequestId");

			List<DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration> describeScalingConfigurationsResponse_scalingConfigurations = new List<DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration>();
			for (int i = 0; i < context.Length("DescribeScalingConfigurations.ScalingConfigurations.Length"); i++) {
				DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration scalingConfiguration = new DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration();
				scalingConfiguration.ScalingConfigurationId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].ScalingConfigurationId");
				scalingConfiguration.ScalingConfigurationName = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].ScalingConfigurationName");
				scalingConfiguration.ScalingGroupId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].ScalingGroupId");
				scalingConfiguration.ImageId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].ImageId");
				scalingConfiguration.InstanceType = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].InstanceType");
				scalingConfiguration.InstanceGeneration = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].InstanceGeneration");
				scalingConfiguration.SecurityGroupId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].SecurityGroupId");
				scalingConfiguration.IoOptimized = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].IoOptimized");
				scalingConfiguration.InternetChargeType = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].InternetChargeType");
				scalingConfiguration.InternetMaxBandwidthIn = context.IntegerValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].InternetMaxBandwidthIn");
				scalingConfiguration.InternetMaxBandwidthOut = context.IntegerValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].InternetMaxBandwidthOut");
				scalingConfiguration.SystemDiskCategory = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].SystemDiskCategory");
				scalingConfiguration.SystemDiskSize = context.IntegerValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].SystemDiskSize");
				scalingConfiguration.LifecycleState = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].LifecycleState");
				scalingConfiguration.CreationTime = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].CreationTime");
				scalingConfiguration.LoadBalancerWeight = context.IntegerValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].LoadBalancerWeight");

				List<DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_DataDisk> scalingConfiguration_dataDisks = new List<DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_DataDisk>();
				for (int j = 0; j < context.Length("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DataDisks.Length"); j++) {
					DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_DataDisk dataDisk = new DescribeScalingConfigurationsResponse.DescribeScalingConfigurations_ScalingConfiguration.DescribeScalingConfigurations_DataDisk();
					dataDisk.Size = context.IntegerValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DataDisks["+ j +"].Size");
					dataDisk.Category = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DataDisks["+ j +"].Category");
					dataDisk.SnapshotId = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DataDisks["+ j +"].SnapshotId");
					dataDisk.Device = context.StringValue("DescribeScalingConfigurations.ScalingConfigurations["+ i +"].DataDisks["+ j +"].Device");

					scalingConfiguration_dataDisks.Add(dataDisk);
				}
				scalingConfiguration.DataDisks = scalingConfiguration_dataDisks;

				describeScalingConfigurationsResponse_scalingConfigurations.Add(scalingConfiguration);
			}
			describeScalingConfigurationsResponse.ScalingConfigurations = describeScalingConfigurationsResponse_scalingConfigurations;
        
			return describeScalingConfigurationsResponse;
        }
    }
}