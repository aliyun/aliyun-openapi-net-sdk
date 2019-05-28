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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class ModifySecurityGroupConfigurationResponseUnmarshaller
    {
        public static ModifySecurityGroupConfigurationResponse Unmarshall(UnmarshallerContext context)
        {
			ModifySecurityGroupConfigurationResponse modifySecurityGroupConfigurationResponse = new ModifySecurityGroupConfigurationResponse();

			modifySecurityGroupConfigurationResponse.HttpResponse = context.HttpResponse;
			modifySecurityGroupConfigurationResponse.RequestId = context.StringValue("ModifySecurityGroupConfiguration.RequestId");
			modifySecurityGroupConfigurationResponse.DBInstanceName = context.StringValue("ModifySecurityGroupConfiguration.DBInstanceName");

			List<ModifySecurityGroupConfigurationResponse.ModifySecurityGroupConfiguration_EcsSecurityGroupRelation> modifySecurityGroupConfigurationResponse_items = new List<ModifySecurityGroupConfigurationResponse.ModifySecurityGroupConfiguration_EcsSecurityGroupRelation>();
			for (int i = 0; i < context.Length("ModifySecurityGroupConfiguration.Items.Length"); i++) {
				ModifySecurityGroupConfigurationResponse.ModifySecurityGroupConfiguration_EcsSecurityGroupRelation ecsSecurityGroupRelation = new ModifySecurityGroupConfigurationResponse.ModifySecurityGroupConfiguration_EcsSecurityGroupRelation();
				ecsSecurityGroupRelation.RegionId = context.StringValue("ModifySecurityGroupConfiguration.Items["+ i +"].RegionId");
				ecsSecurityGroupRelation.SecurityGroupId = context.StringValue("ModifySecurityGroupConfiguration.Items["+ i +"].SecurityGroupId");
				ecsSecurityGroupRelation.NetworkType = context.StringValue("ModifySecurityGroupConfiguration.Items["+ i +"].NetworkType");

				modifySecurityGroupConfigurationResponse_items.Add(ecsSecurityGroupRelation);
			}
			modifySecurityGroupConfigurationResponse.Items = modifySecurityGroupConfigurationResponse_items;
        
			return modifySecurityGroupConfigurationResponse;
        }
    }
}
