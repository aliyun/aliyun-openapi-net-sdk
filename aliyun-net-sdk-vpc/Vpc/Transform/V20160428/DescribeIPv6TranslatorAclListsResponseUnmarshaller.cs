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
using Aliyun.Acs.Vpc.Model.V20160428;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeIPv6TranslatorAclListsResponseUnmarshaller
    {
        public static DescribeIPv6TranslatorAclListsResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeIPv6TranslatorAclListsResponse describeIPv6TranslatorAclListsResponse = new DescribeIPv6TranslatorAclListsResponse();

            describeIPv6TranslatorAclListsResponse.HttpResponse = context.HttpResponse;
            describeIPv6TranslatorAclListsResponse.RequestId = context.StringValue("DescribeIPv6TranslatorAclLists.RequestId");
            describeIPv6TranslatorAclListsResponse.TotalCount = context.IntegerValue("DescribeIPv6TranslatorAclLists.TotalCount");
            describeIPv6TranslatorAclListsResponse.PageNumber = context.IntegerValue("DescribeIPv6TranslatorAclLists.PageNumber");
            describeIPv6TranslatorAclListsResponse.PageSize = context.IntegerValue("DescribeIPv6TranslatorAclLists.PageSize");

            List<DescribeIPv6TranslatorAclListsResponse.DescribeIPv6TranslatorAclLists_IPv6TranslatorAcl> describeIPv6TranslatorAclListsResponse_ipv6TranslatorAcls = new List<DescribeIPv6TranslatorAclListsResponse.DescribeIPv6TranslatorAclLists_IPv6TranslatorAcl>();
            for (int i = 0; i < context.Length("DescribeIPv6TranslatorAclLists.Ipv6TranslatorAcls.Length"); i++)
            {
                DescribeIPv6TranslatorAclListsResponse.DescribeIPv6TranslatorAclLists_IPv6TranslatorAcl iPv6TranslatorAcl = new DescribeIPv6TranslatorAclListsResponse.DescribeIPv6TranslatorAclLists_IPv6TranslatorAcl();
                iPv6TranslatorAcl.AclId = context.StringValue("DescribeIPv6TranslatorAclLists.Ipv6TranslatorAcls[" + i + "].AclId");
                iPv6TranslatorAcl.AclName = context.StringValue("DescribeIPv6TranslatorAclLists.Ipv6TranslatorAcls[" + i + "].AclName");

                describeIPv6TranslatorAclListsResponse_ipv6TranslatorAcls.Add(iPv6TranslatorAcl);
            }
            describeIPv6TranslatorAclListsResponse.Ipv6TranslatorAcls = describeIPv6TranslatorAclListsResponse_ipv6TranslatorAcls;

            return describeIPv6TranslatorAclListsResponse;
        }
    }
}