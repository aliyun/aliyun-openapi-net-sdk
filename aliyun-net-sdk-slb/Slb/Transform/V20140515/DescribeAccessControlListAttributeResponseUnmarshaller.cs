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
using Aliyun.Acs.Slb.Model.V20140515;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeAccessControlListAttributeResponseUnmarshaller
    {
        public static DescribeAccessControlListAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAccessControlListAttributeResponse describeAccessControlListAttributeResponse = new DescribeAccessControlListAttributeResponse();

			describeAccessControlListAttributeResponse.HttpResponse = context.HttpResponse;
			describeAccessControlListAttributeResponse.RequestId = context.StringValue("DescribeAccessControlListAttribute.RequestId");
			describeAccessControlListAttributeResponse.AclId = context.StringValue("DescribeAccessControlListAttribute.AclId");
			describeAccessControlListAttributeResponse.AclName = context.StringValue("DescribeAccessControlListAttribute.AclName");

			List<DescribeAccessControlListAttributeResponse.DescribeAccessControlListAttribute_AclEntry> describeAccessControlListAttributeResponse_aclEntrys = new List<DescribeAccessControlListAttributeResponse.DescribeAccessControlListAttribute_AclEntry>();
			for (int i = 0; i < context.Length("DescribeAccessControlListAttribute.AclEntrys.Length"); i++) {
				DescribeAccessControlListAttributeResponse.DescribeAccessControlListAttribute_AclEntry aclEntry = new DescribeAccessControlListAttributeResponse.DescribeAccessControlListAttribute_AclEntry();
				aclEntry.AclEntryIP = context.StringValue("DescribeAccessControlListAttribute.AclEntrys["+ i +"].AclEntryIP");
				aclEntry.AclEntryComment = context.IntegerValue("DescribeAccessControlListAttribute.AclEntrys["+ i +"].AclEntryComment");

				describeAccessControlListAttributeResponse_aclEntrys.Add(aclEntry);
			}
			describeAccessControlListAttributeResponse.AclEntrys = describeAccessControlListAttributeResponse_aclEntrys;

			List<DescribeAccessControlListAttributeResponse.DescribeAccessControlListAttribute_RelatedListener> describeAccessControlListAttributeResponse_relatedListeners = new List<DescribeAccessControlListAttributeResponse.DescribeAccessControlListAttribute_RelatedListener>();
			for (int i = 0; i < context.Length("DescribeAccessControlListAttribute.RelatedListeners.Length"); i++) {
				DescribeAccessControlListAttributeResponse.DescribeAccessControlListAttribute_RelatedListener relatedListener = new DescribeAccessControlListAttributeResponse.DescribeAccessControlListAttribute_RelatedListener();
				relatedListener.LoadBalancerId = context.StringValue("DescribeAccessControlListAttribute.RelatedListeners["+ i +"].LoadBalancerId");
				relatedListener.ListenerPort = context.IntegerValue("DescribeAccessControlListAttribute.RelatedListeners["+ i +"].ListenerPort");
				relatedListener.AclType = context.StringValue("DescribeAccessControlListAttribute.RelatedListeners["+ i +"].AclType");
				relatedListener.Protocol = context.StringValue("DescribeAccessControlListAttribute.RelatedListeners["+ i +"].Protocol");

				describeAccessControlListAttributeResponse_relatedListeners.Add(relatedListener);
			}
			describeAccessControlListAttributeResponse.RelatedListeners = describeAccessControlListAttributeResponse_relatedListeners;
        
			return describeAccessControlListAttributeResponse;
        }
    }
}