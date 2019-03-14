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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeSecurityGroupAttributeResponseUnmarshaller
    {
        public static DescribeSecurityGroupAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSecurityGroupAttributeResponse describeSecurityGroupAttributeResponse = new DescribeSecurityGroupAttributeResponse();

			describeSecurityGroupAttributeResponse.HttpResponse = context.HttpResponse;
			describeSecurityGroupAttributeResponse.RequestId = context.StringValue("DescribeSecurityGroupAttribute.RequestId");

			List<DescribeSecurityGroupAttributeResponse.DescribeSecurityGroupAttribute_SecurityGroup> describeSecurityGroupAttributeResponse_availableGroupList = new List<DescribeSecurityGroupAttributeResponse.DescribeSecurityGroupAttribute_SecurityGroup>();
			for (int i = 0; i < context.Length("DescribeSecurityGroupAttribute.AvailableGroupList.Length"); i++) {
				DescribeSecurityGroupAttributeResponse.DescribeSecurityGroupAttribute_SecurityGroup securityGroup = new DescribeSecurityGroupAttributeResponse.DescribeSecurityGroupAttribute_SecurityGroup();
				securityGroup.SecurityGroupId = context.StringValue("DescribeSecurityGroupAttribute.AvailableGroupList["+ i +"].SecurityGroupId");
				securityGroup.Description = context.StringValue("DescribeSecurityGroupAttribute.AvailableGroupList["+ i +"].Description");
				securityGroup.SecurityGroupName = context.StringValue("DescribeSecurityGroupAttribute.AvailableGroupList["+ i +"].SecurityGroupName");
				securityGroup.VpcId = context.StringValue("DescribeSecurityGroupAttribute.AvailableGroupList["+ i +"].VpcId");
				securityGroup.CreationTime = context.StringValue("DescribeSecurityGroupAttribute.AvailableGroupList["+ i +"].CreationTime");
				securityGroup.AvailableInstanceAmount = context.IntegerValue("DescribeSecurityGroupAttribute.AvailableGroupList["+ i +"].AvailableInstanceAmount");
				securityGroup.EcsCount = context.IntegerValue("DescribeSecurityGroupAttribute.AvailableGroupList["+ i +"].EcsCount");

				describeSecurityGroupAttributeResponse_availableGroupList.Add(securityGroup);
			}
			describeSecurityGroupAttributeResponse.AvailableGroupList = describeSecurityGroupAttributeResponse_availableGroupList;

			List<DescribeSecurityGroupAttributeResponse.DescribeSecurityGroupAttribute_SecurityGroupAttribute> describeSecurityGroupAttributeResponse_securityGroupAttributeList = new List<DescribeSecurityGroupAttributeResponse.DescribeSecurityGroupAttribute_SecurityGroupAttribute>();
			for (int i = 0; i < context.Length("DescribeSecurityGroupAttribute.SecurityGroupAttributeList.Length"); i++) {
				DescribeSecurityGroupAttributeResponse.DescribeSecurityGroupAttribute_SecurityGroupAttribute securityGroupAttribute = new DescribeSecurityGroupAttributeResponse.DescribeSecurityGroupAttribute_SecurityGroupAttribute();
				securityGroupAttribute.BizType = context.StringValue("DescribeSecurityGroupAttribute.SecurityGroupAttributeList["+ i +"].BizType");
				securityGroupAttribute.BizContent = context.StringValue("DescribeSecurityGroupAttribute.SecurityGroupAttributeList["+ i +"].BizContent");

				describeSecurityGroupAttributeResponse_securityGroupAttributeList.Add(securityGroupAttribute);
			}
			describeSecurityGroupAttributeResponse.SecurityGroupAttributeList = describeSecurityGroupAttributeResponse_securityGroupAttributeList;
        
			return describeSecurityGroupAttributeResponse;
        }
    }
}
