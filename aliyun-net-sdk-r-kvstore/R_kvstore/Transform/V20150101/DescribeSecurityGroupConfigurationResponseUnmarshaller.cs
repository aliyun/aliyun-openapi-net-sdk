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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeSecurityGroupConfigurationResponseUnmarshaller
    {
        public static DescribeSecurityGroupConfigurationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSecurityGroupConfigurationResponse describeSecurityGroupConfigurationResponse = new DescribeSecurityGroupConfigurationResponse();

			describeSecurityGroupConfigurationResponse.HttpResponse = _ctx.HttpResponse;
			describeSecurityGroupConfigurationResponse.RequestId = _ctx.StringValue("DescribeSecurityGroupConfiguration.RequestId");

			List<DescribeSecurityGroupConfigurationResponse.DescribeSecurityGroupConfiguration_EcsSecurityGroupRelation> describeSecurityGroupConfigurationResponse_items = new List<DescribeSecurityGroupConfigurationResponse.DescribeSecurityGroupConfiguration_EcsSecurityGroupRelation>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityGroupConfiguration.Items.Length"); i++) {
				DescribeSecurityGroupConfigurationResponse.DescribeSecurityGroupConfiguration_EcsSecurityGroupRelation ecsSecurityGroupRelation = new DescribeSecurityGroupConfigurationResponse.DescribeSecurityGroupConfiguration_EcsSecurityGroupRelation();
				ecsSecurityGroupRelation.RegionId = _ctx.StringValue("DescribeSecurityGroupConfiguration.Items["+ i +"].RegionId");
				ecsSecurityGroupRelation.SecurityGroupId = _ctx.StringValue("DescribeSecurityGroupConfiguration.Items["+ i +"].SecurityGroupId");
				ecsSecurityGroupRelation.NetType = _ctx.StringValue("DescribeSecurityGroupConfiguration.Items["+ i +"].NetType");

				describeSecurityGroupConfigurationResponse_items.Add(ecsSecurityGroupRelation);
			}
			describeSecurityGroupConfigurationResponse.Items = describeSecurityGroupConfigurationResponse_items;
        
			return describeSecurityGroupConfigurationResponse;
        }
    }
}
