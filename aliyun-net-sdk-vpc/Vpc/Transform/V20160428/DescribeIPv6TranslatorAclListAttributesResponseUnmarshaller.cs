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
    public class DescribeIPv6TranslatorAclListAttributesResponseUnmarshaller
    {
        public static DescribeIPv6TranslatorAclListAttributesResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeIPv6TranslatorAclListAttributesResponse describeIPv6TranslatorAclListAttributesResponse = new DescribeIPv6TranslatorAclListAttributesResponse();

            describeIPv6TranslatorAclListAttributesResponse.HttpResponse = context.HttpResponse;
            describeIPv6TranslatorAclListAttributesResponse.RequestId = context.StringValue("DescribeIPv6TranslatorAclListAttributes.RequestId");
            describeIPv6TranslatorAclListAttributesResponse.AclId = context.StringValue("DescribeIPv6TranslatorAclListAttributes.AclId");
            describeIPv6TranslatorAclListAttributesResponse.AclName = context.StringValue("DescribeIPv6TranslatorAclListAttributes.AclName");
            describeIPv6TranslatorAclListAttributesResponse.TotalCount = context.IntegerValue("DescribeIPv6TranslatorAclListAttributes.TotalCount");
            describeIPv6TranslatorAclListAttributesResponse.PageNumber = context.IntegerValue("DescribeIPv6TranslatorAclListAttributes.PageNumber");
            describeIPv6TranslatorAclListAttributesResponse.PageSize = context.IntegerValue("DescribeIPv6TranslatorAclListAttributes.PageSize");

            List<DescribeIPv6TranslatorAclListAttributesResponse.DescribeIPv6TranslatorAclListAttributes_AclEntry> describeIPv6TranslatorAclListAttributesResponse_aclEntries = new List<DescribeIPv6TranslatorAclListAttributesResponse.DescribeIPv6TranslatorAclListAttributes_AclEntry>();
            for (int i = 0; i < context.Length("DescribeIPv6TranslatorAclListAttributes.AclEntries.Length"); i++)
            {
                DescribeIPv6TranslatorAclListAttributesResponse.DescribeIPv6TranslatorAclListAttributes_AclEntry aclEntry = new DescribeIPv6TranslatorAclListAttributesResponse.DescribeIPv6TranslatorAclListAttributes_AclEntry();
                aclEntry.AclEntryId = context.StringValue("DescribeIPv6TranslatorAclListAttributes.AclEntries[" + i + "].AclEntryId");
                aclEntry.AclEntryIp = context.StringValue("DescribeIPv6TranslatorAclListAttributes.AclEntries[" + i + "].AclEntryIp");
                aclEntry.AclEntryComment = context.StringValue("DescribeIPv6TranslatorAclListAttributes.AclEntries[" + i + "].AclEntryComment");

                describeIPv6TranslatorAclListAttributesResponse_aclEntries.Add(aclEntry);
            }
            describeIPv6TranslatorAclListAttributesResponse.AclEntries = describeIPv6TranslatorAclListAttributesResponse_aclEntries;

            return describeIPv6TranslatorAclListAttributesResponse;
        }
    }
}