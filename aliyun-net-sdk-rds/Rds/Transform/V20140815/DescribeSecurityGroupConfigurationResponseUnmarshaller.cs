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
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSecurityGroupConfigurationResponseUnmarshaller
    {
        public static DescribeSecurityGroupConfigurationResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeSecurityGroupConfigurationResponse describeSecurityGroupConfigurationResponse = new DescribeSecurityGroupConfigurationResponse();

            describeSecurityGroupConfigurationResponse.HttpResponse = context.HttpResponse;
            describeSecurityGroupConfigurationResponse.RequestId = context.StringValue("DescribeSecurityGroupConfiguration.RequestId");
            describeSecurityGroupConfigurationResponse.DBInstanceName = context.StringValue("DescribeSecurityGroupConfiguration.DBInstanceName");

            List<DescribeSecurityGroupConfigurationResponse.DescribeSecurityGroupConfiguration_EcsSecurityGroupRelation> describeSecurityGroupConfigurationResponse_items = new List<DescribeSecurityGroupConfigurationResponse.DescribeSecurityGroupConfiguration_EcsSecurityGroupRelation>();
            for (int i = 0; i < context.Length("DescribeSecurityGroupConfiguration.Items.Length"); i++)
            {
                DescribeSecurityGroupConfigurationResponse.DescribeSecurityGroupConfiguration_EcsSecurityGroupRelation ecsSecurityGroupRelation = new DescribeSecurityGroupConfigurationResponse.DescribeSecurityGroupConfiguration_EcsSecurityGroupRelation();
                ecsSecurityGroupRelation.RegionId = context.StringValue("DescribeSecurityGroupConfiguration.Items[" + i + "].RegionId");
                ecsSecurityGroupRelation.SecurityGroupId = context.StringValue("DescribeSecurityGroupConfiguration.Items[" + i + "].SecurityGroupId");
                ecsSecurityGroupRelation.NetworkType = context.StringValue("DescribeSecurityGroupConfiguration.Items[" + i + "].NetworkType");

                describeSecurityGroupConfigurationResponse_items.Add(ecsSecurityGroupRelation);
            }
            describeSecurityGroupConfigurationResponse.Items = describeSecurityGroupConfigurationResponse_items;

            return describeSecurityGroupConfigurationResponse;
        }
    }
}