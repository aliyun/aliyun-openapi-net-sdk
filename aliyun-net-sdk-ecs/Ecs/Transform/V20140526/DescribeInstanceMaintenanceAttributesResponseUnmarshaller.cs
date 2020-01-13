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
    public class DescribeInstanceMaintenanceAttributesResponseUnmarshaller
    {
        public static DescribeInstanceMaintenanceAttributesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceMaintenanceAttributesResponse describeInstanceMaintenanceAttributesResponse = new DescribeInstanceMaintenanceAttributesResponse();

			describeInstanceMaintenanceAttributesResponse.HttpResponse = context.HttpResponse;
			describeInstanceMaintenanceAttributesResponse.RequestId = context.StringValue("DescribeInstanceMaintenanceAttributes.RequestId");
			describeInstanceMaintenanceAttributesResponse.TotalCount = context.IntegerValue("DescribeInstanceMaintenanceAttributes.TotalCount");
			describeInstanceMaintenanceAttributesResponse.PageNumber = context.IntegerValue("DescribeInstanceMaintenanceAttributes.PageNumber");
			describeInstanceMaintenanceAttributesResponse.PageSize = context.IntegerValue("DescribeInstanceMaintenanceAttributes.PageSize");

			List<DescribeInstanceMaintenanceAttributesResponse.DescribeInstanceMaintenanceAttributes_MaintenanceAttribute> describeInstanceMaintenanceAttributesResponse_maintenanceAttributes = new List<DescribeInstanceMaintenanceAttributesResponse.DescribeInstanceMaintenanceAttributes_MaintenanceAttribute>();
			for (int i = 0; i < context.Length("DescribeInstanceMaintenanceAttributes.MaintenanceAttributes.Length"); i++) {
				DescribeInstanceMaintenanceAttributesResponse.DescribeInstanceMaintenanceAttributes_MaintenanceAttribute maintenanceAttribute = new DescribeInstanceMaintenanceAttributesResponse.DescribeInstanceMaintenanceAttributes_MaintenanceAttribute();
				maintenanceAttribute.InstanceId = context.StringValue("DescribeInstanceMaintenanceAttributes.MaintenanceAttributes["+ i +"].InstanceId");

				DescribeInstanceMaintenanceAttributesResponse.DescribeInstanceMaintenanceAttributes_MaintenanceAttribute.DescribeInstanceMaintenanceAttributes_ActionOnMaintenance actionOnMaintenance = new DescribeInstanceMaintenanceAttributesResponse.DescribeInstanceMaintenanceAttributes_MaintenanceAttribute.DescribeInstanceMaintenanceAttributes_ActionOnMaintenance();
				actionOnMaintenance._Value = context.StringValue("DescribeInstanceMaintenanceAttributes.MaintenanceAttributes["+ i +"].ActionOnMaintenance.Value");
				actionOnMaintenance.DefaultValue = context.StringValue("DescribeInstanceMaintenanceAttributes.MaintenanceAttributes["+ i +"].ActionOnMaintenance.DefaultValue");

				List<string> actionOnMaintenance_supportedValues = new List<string>();
				for (int j = 0; j < context.Length("DescribeInstanceMaintenanceAttributes.MaintenanceAttributes["+ i +"].ActionOnMaintenance.SupportedValues.Length"); j++) {
					actionOnMaintenance_supportedValues.Add(context.StringValue("DescribeInstanceMaintenanceAttributes.MaintenanceAttributes["+ i +"].ActionOnMaintenance.SupportedValues["+ j +"]"));
				}
				actionOnMaintenance.SupportedValues = actionOnMaintenance_supportedValues;
				maintenanceAttribute.ActionOnMaintenance = actionOnMaintenance;

				List<DescribeInstanceMaintenanceAttributesResponse.DescribeInstanceMaintenanceAttributes_MaintenanceAttribute.DescribeInstanceMaintenanceAttributes_MaintenanceWindow> maintenanceAttribute_maintenanceWindows = new List<DescribeInstanceMaintenanceAttributesResponse.DescribeInstanceMaintenanceAttributes_MaintenanceAttribute.DescribeInstanceMaintenanceAttributes_MaintenanceWindow>();
				for (int j = 0; j < context.Length("DescribeInstanceMaintenanceAttributes.MaintenanceAttributes["+ i +"].MaintenanceWindows.Length"); j++) {
					DescribeInstanceMaintenanceAttributesResponse.DescribeInstanceMaintenanceAttributes_MaintenanceAttribute.DescribeInstanceMaintenanceAttributes_MaintenanceWindow maintenanceWindow = new DescribeInstanceMaintenanceAttributesResponse.DescribeInstanceMaintenanceAttributes_MaintenanceAttribute.DescribeInstanceMaintenanceAttributes_MaintenanceWindow();
					maintenanceWindow.StartTime = context.StringValue("DescribeInstanceMaintenanceAttributes.MaintenanceAttributes["+ i +"].MaintenanceWindows["+ j +"].StartTime");
					maintenanceWindow.EndTime = context.StringValue("DescribeInstanceMaintenanceAttributes.MaintenanceAttributes["+ i +"].MaintenanceWindows["+ j +"].EndTime");

					maintenanceAttribute_maintenanceWindows.Add(maintenanceWindow);
				}
				maintenanceAttribute.MaintenanceWindows = maintenanceAttribute_maintenanceWindows;

				describeInstanceMaintenanceAttributesResponse_maintenanceAttributes.Add(maintenanceAttribute);
			}
			describeInstanceMaintenanceAttributesResponse.MaintenanceAttributes = describeInstanceMaintenanceAttributesResponse_maintenanceAttributes;
        
			return describeInstanceMaintenanceAttributesResponse;
        }
    }
}
