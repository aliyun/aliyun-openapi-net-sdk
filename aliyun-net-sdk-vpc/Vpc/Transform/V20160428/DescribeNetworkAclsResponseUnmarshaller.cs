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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeNetworkAclsResponseUnmarshaller
    {
        public static DescribeNetworkAclsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNetworkAclsResponse describeNetworkAclsResponse = new DescribeNetworkAclsResponse();

			describeNetworkAclsResponse.HttpResponse = context.HttpResponse;
			describeNetworkAclsResponse.RequestId = context.StringValue("DescribeNetworkAcls.RequestId");
			describeNetworkAclsResponse.TotalCount = context.StringValue("DescribeNetworkAcls.TotalCount");
			describeNetworkAclsResponse.PageNumber = context.StringValue("DescribeNetworkAcls.PageNumber");
			describeNetworkAclsResponse.PageSize = context.StringValue("DescribeNetworkAcls.PageSize");

			List<DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl> describeNetworkAclsResponse_networkAcls = new List<DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl>();
			for (int i = 0; i < context.Length("DescribeNetworkAcls.NetworkAcls.Length"); i++) {
				DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl networkAcl = new DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl();
				networkAcl.NetworkAclId = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].NetworkAclId");
				networkAcl.RegionId = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].RegionId");
				networkAcl.NetworkAclName = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].NetworkAclName");
				networkAcl.Description = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].Description");
				networkAcl.VpcId = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].VpcId");
				networkAcl.CreationTime = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].CreationTime");
				networkAcl.Status = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].Status");

				List<DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_IngressAclEntry> networkAcl_ingressAclEntries = new List<DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_IngressAclEntry>();
				for (int j = 0; j < context.Length("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries.Length"); j++) {
					DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_IngressAclEntry ingressAclEntry = new DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_IngressAclEntry();
					ingressAclEntry.NetworkAclEntryId = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries["+ j +"].NetworkAclEntryId");
					ingressAclEntry.Policy = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries["+ j +"].Policy");
					ingressAclEntry.Protocol = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries["+ j +"].Protocol");
					ingressAclEntry.SourceCidrIp = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries["+ j +"].SourceCidrIp");
					ingressAclEntry.Port = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries["+ j +"].Port");
					ingressAclEntry.EntryType = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries["+ j +"].EntryType");
					ingressAclEntry.NetworkAclEntryName = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries["+ j +"].NetworkAclEntryName");
					ingressAclEntry.Description = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].IngressAclEntries["+ j +"].Description");

					networkAcl_ingressAclEntries.Add(ingressAclEntry);
				}
				networkAcl.IngressAclEntries = networkAcl_ingressAclEntries;

				List<DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_EgressAclEntry> networkAcl_egressAclEntries = new List<DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_EgressAclEntry>();
				for (int j = 0; j < context.Length("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries.Length"); j++) {
					DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_EgressAclEntry egressAclEntry = new DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_EgressAclEntry();
					egressAclEntry.NetworkAclEntryId = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries["+ j +"].NetworkAclEntryId");
					egressAclEntry.Policy = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries["+ j +"].Policy");
					egressAclEntry.Protocol = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries["+ j +"].Protocol");
					egressAclEntry.DestinationCidrIp = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries["+ j +"].DestinationCidrIp");
					egressAclEntry.Port = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries["+ j +"].Port");
					egressAclEntry.EntryType = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries["+ j +"].EntryType");
					egressAclEntry.Description = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries["+ j +"].Description");
					egressAclEntry.NetworkAclEntryName = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].EgressAclEntries["+ j +"].NetworkAclEntryName");

					networkAcl_egressAclEntries.Add(egressAclEntry);
				}
				networkAcl.EgressAclEntries = networkAcl_egressAclEntries;

				List<DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_Resource> networkAcl_resources = new List<DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_Resource>();
				for (int j = 0; j < context.Length("DescribeNetworkAcls.NetworkAcls["+ i +"].Resources.Length"); j++) {
					DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_Resource resource = new DescribeNetworkAclsResponse.DescribeNetworkAcls_NetworkAcl.DescribeNetworkAcls_Resource();
					resource.ResourceId = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].Resources["+ j +"].ResourceId");
					resource.ResourceType = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].Resources["+ j +"].ResourceType");
					resource.Status = context.StringValue("DescribeNetworkAcls.NetworkAcls["+ i +"].Resources["+ j +"].Status");

					networkAcl_resources.Add(resource);
				}
				networkAcl.Resources = networkAcl_resources;

				describeNetworkAclsResponse_networkAcls.Add(networkAcl);
			}
			describeNetworkAclsResponse.NetworkAcls = describeNetworkAclsResponse_networkAcls;
        
			return describeNetworkAclsResponse;
        }
    }
}
