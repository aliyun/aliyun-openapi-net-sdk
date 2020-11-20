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
using Aliyun.Acs.Ess.Model.V20140828;

namespace Aliyun.Acs.Ess.Transform.V20140828
{
    public class DescribeNotificationConfigurationsResponseUnmarshaller
    {
        public static DescribeNotificationConfigurationsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNotificationConfigurationsResponse describeNotificationConfigurationsResponse = new DescribeNotificationConfigurationsResponse();

			describeNotificationConfigurationsResponse.HttpResponse = context.HttpResponse;
			describeNotificationConfigurationsResponse.RequestId = context.StringValue("DescribeNotificationConfigurations.RequestId");

			List<DescribeNotificationConfigurationsResponse.DescribeNotificationConfigurations_NotificationConfigurationModel> describeNotificationConfigurationsResponse_notificationConfigurationModels = new List<DescribeNotificationConfigurationsResponse.DescribeNotificationConfigurations_NotificationConfigurationModel>();
			for (int i = 0; i < context.Length("DescribeNotificationConfigurations.NotificationConfigurationModels.Length"); i++) {
				DescribeNotificationConfigurationsResponse.DescribeNotificationConfigurations_NotificationConfigurationModel notificationConfigurationModel = new DescribeNotificationConfigurationsResponse.DescribeNotificationConfigurations_NotificationConfigurationModel();
				notificationConfigurationModel.ScalingGroupId = context.StringValue("DescribeNotificationConfigurations.NotificationConfigurationModels["+ i +"].ScalingGroupId");
				notificationConfigurationModel.NotificationArn = context.StringValue("DescribeNotificationConfigurations.NotificationConfigurationModels["+ i +"].NotificationArn");

				List<string> notificationConfigurationModel_notificationTypes = new List<string>();
				for (int j = 0; j < context.Length("DescribeNotificationConfigurations.NotificationConfigurationModels["+ i +"].NotificationTypes.Length"); j++) {
					notificationConfigurationModel_notificationTypes.Add(context.StringValue("DescribeNotificationConfigurations.NotificationConfigurationModels["+ i +"].NotificationTypes["+ j +"]"));
				}
				notificationConfigurationModel.NotificationTypes = notificationConfigurationModel_notificationTypes;

				describeNotificationConfigurationsResponse_notificationConfigurationModels.Add(notificationConfigurationModel);
			}
			describeNotificationConfigurationsResponse.NotificationConfigurationModels = describeNotificationConfigurationsResponse_notificationConfigurationModels;
        
			return describeNotificationConfigurationsResponse;
        }
    }
}
