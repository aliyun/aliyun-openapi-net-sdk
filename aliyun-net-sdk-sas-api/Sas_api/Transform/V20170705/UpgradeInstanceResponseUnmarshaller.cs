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
using Aliyun.Acs.Sas_api.Model.V20170705;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Sas_api.Transform.V20170705
{
    public class UpgradeInstanceResponseUnmarshaller
    {
        public static UpgradeInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			UpgradeInstanceResponse upgradeInstanceResponse = new UpgradeInstanceResponse();

			upgradeInstanceResponse.HttpResponse = context.HttpResponse;
			upgradeInstanceResponse.Code = context.StringValue("UpgradeInstance.Code");
			upgradeInstanceResponse.Message = context.StringValue("UpgradeInstance.Message");
			upgradeInstanceResponse.OrderId = context.StringValue("UpgradeInstance.OrderId");
			upgradeInstanceResponse.InstanceId = context.StringValue("UpgradeInstance.InstanceId");
			upgradeInstanceResponse.RequestId = context.StringValue("UpgradeInstance.RequestId");

			List<string> upgradeInstanceResponse_instanceIds = new List<string>();
			for (int i = 0; i < context.Length("UpgradeInstance.InstanceIds.Length"); i++) {
				upgradeInstanceResponse_instanceIds.Add(context.StringValue("UpgradeInstance.InstanceIds["+ i +"]"));
			}
			upgradeInstanceResponse.InstanceIds = upgradeInstanceResponse_instanceIds;
        
			return upgradeInstanceResponse;
        }
    }
}