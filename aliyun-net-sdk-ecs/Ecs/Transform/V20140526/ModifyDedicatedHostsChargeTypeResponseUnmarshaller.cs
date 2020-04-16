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
    public class ModifyDedicatedHostsChargeTypeResponseUnmarshaller
    {
        public static ModifyDedicatedHostsChargeTypeResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyDedicatedHostsChargeTypeResponse modifyDedicatedHostsChargeTypeResponse = new ModifyDedicatedHostsChargeTypeResponse();

			modifyDedicatedHostsChargeTypeResponse.HttpResponse = context.HttpResponse;
			modifyDedicatedHostsChargeTypeResponse.RequestId = context.StringValue("ModifyDedicatedHostsChargeType.RequestId");
			modifyDedicatedHostsChargeTypeResponse.OrderId = context.StringValue("ModifyDedicatedHostsChargeType.OrderId");

			List<ModifyDedicatedHostsChargeTypeResponse.ModifyDedicatedHostsChargeType_FeeOfInstance> modifyDedicatedHostsChargeTypeResponse_feeOfInstances = new List<ModifyDedicatedHostsChargeTypeResponse.ModifyDedicatedHostsChargeType_FeeOfInstance>();
			for (int i = 0; i < context.Length("ModifyDedicatedHostsChargeType.FeeOfInstances.Length"); i++) {
				ModifyDedicatedHostsChargeTypeResponse.ModifyDedicatedHostsChargeType_FeeOfInstance feeOfInstance = new ModifyDedicatedHostsChargeTypeResponse.ModifyDedicatedHostsChargeType_FeeOfInstance();
				feeOfInstance.InstanceId = context.StringValue("ModifyDedicatedHostsChargeType.FeeOfInstances["+ i +"].InstanceId");
				feeOfInstance.Fee = context.StringValue("ModifyDedicatedHostsChargeType.FeeOfInstances["+ i +"].Fee");
				feeOfInstance.Currency = context.StringValue("ModifyDedicatedHostsChargeType.FeeOfInstances["+ i +"].Currency");

				modifyDedicatedHostsChargeTypeResponse_feeOfInstances.Add(feeOfInstance);
			}
			modifyDedicatedHostsChargeTypeResponse.FeeOfInstances = modifyDedicatedHostsChargeTypeResponse_feeOfInstances;
        
			return modifyDedicatedHostsChargeTypeResponse;
        }
    }
}
