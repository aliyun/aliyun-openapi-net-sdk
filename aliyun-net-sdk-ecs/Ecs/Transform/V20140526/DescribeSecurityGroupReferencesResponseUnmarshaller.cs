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
    public class DescribeSecurityGroupReferencesResponseUnmarshaller
    {
        public static DescribeSecurityGroupReferencesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSecurityGroupReferencesResponse describeSecurityGroupReferencesResponse = new DescribeSecurityGroupReferencesResponse();

			describeSecurityGroupReferencesResponse.HttpResponse = context.HttpResponse;
			describeSecurityGroupReferencesResponse.RequestId = context.StringValue("DescribeSecurityGroupReferences.RequestId");

			List<DescribeSecurityGroupReferencesResponse.DescribeSecurityGroupReferences_SecurityGroupReference> describeSecurityGroupReferencesResponse_securityGroupReferences = new List<DescribeSecurityGroupReferencesResponse.DescribeSecurityGroupReferences_SecurityGroupReference>();
			for (int i = 0; i < context.Length("DescribeSecurityGroupReferences.SecurityGroupReferences.Length"); i++) {
				DescribeSecurityGroupReferencesResponse.DescribeSecurityGroupReferences_SecurityGroupReference securityGroupReference = new DescribeSecurityGroupReferencesResponse.DescribeSecurityGroupReferences_SecurityGroupReference();
				securityGroupReference.SecurityGroupId = context.StringValue("DescribeSecurityGroupReferences.SecurityGroupReferences["+ i +"].SecurityGroupId");

				List<DescribeSecurityGroupReferencesResponse.DescribeSecurityGroupReferences_SecurityGroupReference.DescribeSecurityGroupReferences_ReferencingSecurityGroup> securityGroupReference_referencingSecurityGroups = new List<DescribeSecurityGroupReferencesResponse.DescribeSecurityGroupReferences_SecurityGroupReference.DescribeSecurityGroupReferences_ReferencingSecurityGroup>();
				for (int j = 0; j < context.Length("DescribeSecurityGroupReferences.SecurityGroupReferences["+ i +"].ReferencingSecurityGroups.Length"); j++) {
					DescribeSecurityGroupReferencesResponse.DescribeSecurityGroupReferences_SecurityGroupReference.DescribeSecurityGroupReferences_ReferencingSecurityGroup referencingSecurityGroup = new DescribeSecurityGroupReferencesResponse.DescribeSecurityGroupReferences_SecurityGroupReference.DescribeSecurityGroupReferences_ReferencingSecurityGroup();
					referencingSecurityGroup.AliUid = context.StringValue("DescribeSecurityGroupReferences.SecurityGroupReferences["+ i +"].ReferencingSecurityGroups["+ j +"].AliUid");
					referencingSecurityGroup.SecurityGroupId = context.StringValue("DescribeSecurityGroupReferences.SecurityGroupReferences["+ i +"].ReferencingSecurityGroups["+ j +"].SecurityGroupId");

					securityGroupReference_referencingSecurityGroups.Add(referencingSecurityGroup);
				}
				securityGroupReference.ReferencingSecurityGroups = securityGroupReference_referencingSecurityGroups;

				describeSecurityGroupReferencesResponse_securityGroupReferences.Add(securityGroupReference);
			}
			describeSecurityGroupReferencesResponse.SecurityGroupReferences = describeSecurityGroupReferencesResponse_securityGroupReferences;
        
			return describeSecurityGroupReferencesResponse;
        }
    }
}
