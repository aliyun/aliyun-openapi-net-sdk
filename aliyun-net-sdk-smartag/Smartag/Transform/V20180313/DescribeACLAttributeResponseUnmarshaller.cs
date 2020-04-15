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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeACLAttributeResponseUnmarshaller
    {
        public static DescribeACLAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeACLAttributeResponse describeACLAttributeResponse = new DescribeACLAttributeResponse();

			describeACLAttributeResponse.HttpResponse = context.HttpResponse;
			describeACLAttributeResponse.RequestId = context.StringValue("DescribeACLAttribute.RequestId");
			describeACLAttributeResponse.TotalCount = context.IntegerValue("DescribeACLAttribute.TotalCount");
			describeACLAttributeResponse.PageNumber = context.IntegerValue("DescribeACLAttribute.PageNumber");
			describeACLAttributeResponse.PageSize = context.IntegerValue("DescribeACLAttribute.PageSize");

			List<DescribeACLAttributeResponse.DescribeACLAttribute_Acr> describeACLAttributeResponse_acrs = new List<DescribeACLAttributeResponse.DescribeACLAttribute_Acr>();
			for (int i = 0; i < context.Length("DescribeACLAttribute.Acrs.Length"); i++) {
				DescribeACLAttributeResponse.DescribeACLAttribute_Acr acr = new DescribeACLAttributeResponse.DescribeACLAttribute_Acr();
				acr.AcrId = context.StringValue("DescribeACLAttribute.Acrs["+ i +"].AcrId");
				acr.Description = context.StringValue("DescribeACLAttribute.Acrs["+ i +"].Description");
				acr.Direction = context.StringValue("DescribeACLAttribute.Acrs["+ i +"].Direction");
				acr.SourceCidr = context.StringValue("DescribeACLAttribute.Acrs["+ i +"].SourceCidr");
				acr.DestCidr = context.StringValue("DescribeACLAttribute.Acrs["+ i +"].DestCidr");
				acr.IpProtocol = context.StringValue("DescribeACLAttribute.Acrs["+ i +"].IpProtocol");
				acr.SourcePortRange = context.StringValue("DescribeACLAttribute.Acrs["+ i +"].SourcePortRange");
				acr.DestPortRange = context.StringValue("DescribeACLAttribute.Acrs["+ i +"].DestPortRange");
				acr.Policy = context.StringValue("DescribeACLAttribute.Acrs["+ i +"].Policy");
				acr.Priority = context.IntegerValue("DescribeACLAttribute.Acrs["+ i +"].Priority");
				acr.GmtCreate = context.LongValue("DescribeACLAttribute.Acrs["+ i +"].GmtCreate");
				acr.AclId = context.StringValue("DescribeACLAttribute.Acrs["+ i +"].AclId");
				acr.Type = context.StringValue("DescribeACLAttribute.Acrs["+ i +"].Type");
				acr.Name = context.StringValue("DescribeACLAttribute.Acrs["+ i +"].Name");

				describeACLAttributeResponse_acrs.Add(acr);
			}
			describeACLAttributeResponse.Acrs = describeACLAttributeResponse_acrs;
        
			return describeACLAttributeResponse;
        }
    }
}
