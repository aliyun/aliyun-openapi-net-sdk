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
using Aliyun.Acs.Slb.Model.V20140515;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeAccessControlListsResponseUnmarshaller
    {
        public static DescribeAccessControlListsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccessControlListsResponse describeAccessControlListsResponse = new DescribeAccessControlListsResponse();

			describeAccessControlListsResponse.HttpResponse = _ctx.HttpResponse;
			describeAccessControlListsResponse.RequestId = _ctx.StringValue("DescribeAccessControlLists.RequestId");
			describeAccessControlListsResponse.TotalCount = _ctx.IntegerValue("DescribeAccessControlLists.TotalCount");
			describeAccessControlListsResponse.PageSize = _ctx.IntegerValue("DescribeAccessControlLists.PageSize");
			describeAccessControlListsResponse.Count = _ctx.IntegerValue("DescribeAccessControlLists.Count");
			describeAccessControlListsResponse.PageNumber = _ctx.IntegerValue("DescribeAccessControlLists.PageNumber");

			List<DescribeAccessControlListsResponse.DescribeAccessControlLists_Acl> describeAccessControlListsResponse_acls = new List<DescribeAccessControlListsResponse.DescribeAccessControlLists_Acl>();
			for (int i = 0; i < _ctx.Length("DescribeAccessControlLists.Acls.Length"); i++) {
				DescribeAccessControlListsResponse.DescribeAccessControlLists_Acl acl = new DescribeAccessControlListsResponse.DescribeAccessControlLists_Acl();
				acl.AclId = _ctx.StringValue("DescribeAccessControlLists.Acls["+ i +"].AclId");
				acl.AclName = _ctx.StringValue("DescribeAccessControlLists.Acls["+ i +"].AclName");
				acl.AddressIPVersion = _ctx.StringValue("DescribeAccessControlLists.Acls["+ i +"].AddressIPVersion");
				acl.ResourceGroupId = _ctx.StringValue("DescribeAccessControlLists.Acls["+ i +"].ResourceGroupId");

				List<DescribeAccessControlListsResponse.DescribeAccessControlLists_Acl.DescribeAccessControlLists_Tag> acl_tags = new List<DescribeAccessControlListsResponse.DescribeAccessControlLists_Acl.DescribeAccessControlLists_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeAccessControlLists.Acls["+ i +"].Tags.Length"); j++) {
					DescribeAccessControlListsResponse.DescribeAccessControlLists_Acl.DescribeAccessControlLists_Tag tag = new DescribeAccessControlListsResponse.DescribeAccessControlLists_Acl.DescribeAccessControlLists_Tag();
					tag.TagKey = _ctx.StringValue("DescribeAccessControlLists.Acls["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("DescribeAccessControlLists.Acls["+ i +"].Tags["+ j +"].TagValue");

					acl_tags.Add(tag);
				}
				acl.Tags = acl_tags;

				describeAccessControlListsResponse_acls.Add(acl);
			}
			describeAccessControlListsResponse.Acls = describeAccessControlListsResponse_acls;
        
			return describeAccessControlListsResponse;
        }
    }
}
