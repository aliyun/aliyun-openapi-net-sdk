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
using Aliyun.Acs.R_kvstore.Model.V20150101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeSecurityIpsResponseUnmarshaller
    {
        public static DescribeSecurityIpsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSecurityIpsResponse describeSecurityIpsResponse = new DescribeSecurityIpsResponse();

			describeSecurityIpsResponse.HttpResponse = context.HttpResponse;
			describeSecurityIpsResponse.RequestId = context.StringValue("DescribeSecurityIps.RequestId");

			List<DescribeSecurityIpsResponse.DescribeSecurityIps_SecurityIpGroup> describeSecurityIpsResponse_securityIpGroups = new List<DescribeSecurityIpsResponse.DescribeSecurityIps_SecurityIpGroup>();
			for (int i = 0; i < context.Length("DescribeSecurityIps.SecurityIpGroups.Length"); i++) {
				DescribeSecurityIpsResponse.DescribeSecurityIps_SecurityIpGroup securityIpGroup = new DescribeSecurityIpsResponse.DescribeSecurityIps_SecurityIpGroup();
				securityIpGroup.SecurityIpGroupName = context.StringValue("DescribeSecurityIps.SecurityIpGroups["+ i +"].SecurityIpGroupName");
				securityIpGroup.SecurityIpGroupAttribute = context.StringValue("DescribeSecurityIps.SecurityIpGroups["+ i +"].SecurityIpGroupAttribute");
				securityIpGroup.SecurityIpList = context.StringValue("DescribeSecurityIps.SecurityIpGroups["+ i +"].SecurityIpList");

				describeSecurityIpsResponse_securityIpGroups.Add(securityIpGroup);
			}
			describeSecurityIpsResponse.SecurityIpGroups = describeSecurityIpsResponse_securityIpGroups;
        
			return describeSecurityIpsResponse;
        }
    }
}