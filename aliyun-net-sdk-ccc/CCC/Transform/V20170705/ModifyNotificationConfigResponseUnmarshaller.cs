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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ModifyNotificationConfigResponseUnmarshaller
    {
        public static ModifyNotificationConfigResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyNotificationConfigResponse modifyNotificationConfigResponse = new ModifyNotificationConfigResponse();

			modifyNotificationConfigResponse.HttpResponse = context.HttpResponse;
			modifyNotificationConfigResponse.RequestId = context.StringValue("ModifyNotificationConfig.RequestId");
			modifyNotificationConfigResponse.Success = context.BooleanValue("ModifyNotificationConfig.Success");
			modifyNotificationConfigResponse.Code = context.StringValue("ModifyNotificationConfig.Code");
			modifyNotificationConfigResponse.Message = context.StringValue("ModifyNotificationConfig.Message");
			modifyNotificationConfigResponse.HttpStatusCode = context.IntegerValue("ModifyNotificationConfig.HttpStatusCode");
			modifyNotificationConfigResponse.ProducerId = context.StringValue("ModifyNotificationConfig.ProducerId");
			modifyNotificationConfigResponse.AccessPoint = context.StringValue("ModifyNotificationConfig.AccessPoint");
			modifyNotificationConfigResponse.Topic = context.StringValue("ModifyNotificationConfig.Topic");

			List<ModifyNotificationConfigResponse.ModifyNotificationConfig_SubscriptionsItem> modifyNotificationConfigResponse_subscriptions = new List<ModifyNotificationConfigResponse.ModifyNotificationConfig_SubscriptionsItem>();
			for (int i = 0; i < context.Length("ModifyNotificationConfig.Subscriptions.Length"); i++) {
				ModifyNotificationConfigResponse.ModifyNotificationConfig_SubscriptionsItem subscriptionsItem = new ModifyNotificationConfigResponse.ModifyNotificationConfig_SubscriptionsItem();
				subscriptionsItem.Name = context.StringValue("ModifyNotificationConfig.Subscriptions["+ i +"].Name");
				subscriptionsItem.Selected = context.BooleanValue("ModifyNotificationConfig.Subscriptions["+ i +"].Selected");
				subscriptionsItem.DisplayName = context.StringValue("ModifyNotificationConfig.Subscriptions["+ i +"].DisplayName");

				modifyNotificationConfigResponse_subscriptions.Add(subscriptionsItem);
			}
			modifyNotificationConfigResponse.Subscriptions = modifyNotificationConfigResponse_subscriptions;
        
			return modifyNotificationConfigResponse;
        }
    }
}
