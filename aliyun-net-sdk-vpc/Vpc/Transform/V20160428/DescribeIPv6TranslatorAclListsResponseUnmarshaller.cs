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
    public class DescribeIPv6TranslatorAclListsResponseUnmarshaller
    {
        public static DescribeIPv6TranslatorAclListsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeIPv6TranslatorAclListsResponse describeIPv6TranslatorAclListsResponse = new DescribeIPv6TranslatorAclListsResponse();

			describeIPv6TranslatorAclListsResponse.HttpResponse = _ctx.HttpResponse;
			describeIPv6TranslatorAclListsResponse.RequestId = _ctx.StringValue("DescribeIPv6TranslatorAclLists.RequestId");
			describeIPv6TranslatorAclListsResponse.TotalCount = _ctx.IntegerValue("DescribeIPv6TranslatorAclLists.TotalCount");
			describeIPv6TranslatorAclListsResponse.PageNumber = _ctx.IntegerValue("DescribeIPv6TranslatorAclLists.PageNumber");
			describeIPv6TranslatorAclListsResponse.PageSize = _ctx.IntegerValue("DescribeIPv6TranslatorAclLists.PageSize");

			List<DescribeIPv6TranslatorAclListsResponse.DescribeIPv6TranslatorAclLists_IPv6TranslatorAcl> describeIPv6TranslatorAclListsResponse_ipv6TranslatorAcls = new List<DescribeIPv6TranslatorAclListsResponse.DescribeIPv6TranslatorAclLists_IPv6TranslatorAcl>();
			for (int i = 0; i < _ctx.Length("DescribeIPv6TranslatorAclLists.Ipv6TranslatorAcls.Length"); i++) {
				DescribeIPv6TranslatorAclListsResponse.DescribeIPv6TranslatorAclLists_IPv6TranslatorAcl iPv6TranslatorAcl = new DescribeIPv6TranslatorAclListsResponse.DescribeIPv6TranslatorAclLists_IPv6TranslatorAcl();
				iPv6TranslatorAcl.AclId = _ctx.StringValue("DescribeIPv6TranslatorAclLists.Ipv6TranslatorAcls["+ i +"].AclId");
				iPv6TranslatorAcl.AclName = _ctx.StringValue("DescribeIPv6TranslatorAclLists.Ipv6TranslatorAcls["+ i +"].AclName");

				describeIPv6TranslatorAclListsResponse_ipv6TranslatorAcls.Add(iPv6TranslatorAcl);
			}
			describeIPv6TranslatorAclListsResponse.Ipv6TranslatorAcls = describeIPv6TranslatorAclListsResponse_ipv6TranslatorAcls;
        
			return describeIPv6TranslatorAclListsResponse;
        }
    }
}
