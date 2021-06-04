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
    public class DescribePrefixListsResponseUnmarshaller
    {
        public static DescribePrefixListsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePrefixListsResponse describePrefixListsResponse = new DescribePrefixListsResponse();

			describePrefixListsResponse.HttpResponse = _ctx.HttpResponse;
			describePrefixListsResponse.RequestId = _ctx.StringValue("DescribePrefixLists.RequestId");
			describePrefixListsResponse.NextToken = _ctx.StringValue("DescribePrefixLists.NextToken");

			List<DescribePrefixListsResponse.DescribePrefixLists_PrefixList> describePrefixListsResponse_prefixLists = new List<DescribePrefixListsResponse.DescribePrefixLists_PrefixList>();
			for (int i = 0; i < _ctx.Length("DescribePrefixLists.PrefixLists.Length"); i++) {
				DescribePrefixListsResponse.DescribePrefixLists_PrefixList prefixList = new DescribePrefixListsResponse.DescribePrefixLists_PrefixList();
				prefixList.PrefixListId = _ctx.StringValue("DescribePrefixLists.PrefixLists["+ i +"].PrefixListId");
				prefixList.PrefixListName = _ctx.StringValue("DescribePrefixLists.PrefixLists["+ i +"].PrefixListName");
				prefixList.AddressFamily = _ctx.StringValue("DescribePrefixLists.PrefixLists["+ i +"].AddressFamily");
				prefixList.MaxEntries = _ctx.IntegerValue("DescribePrefixLists.PrefixLists["+ i +"].MaxEntries");
				prefixList.Description = _ctx.StringValue("DescribePrefixLists.PrefixLists["+ i +"].Description");
				prefixList.CreationTime = _ctx.StringValue("DescribePrefixLists.PrefixLists["+ i +"].CreationTime");
				prefixList.AssociationCount = _ctx.IntegerValue("DescribePrefixLists.PrefixLists["+ i +"].AssociationCount");

				describePrefixListsResponse_prefixLists.Add(prefixList);
			}
			describePrefixListsResponse.PrefixLists = describePrefixListsResponse_prefixLists;
        
			return describePrefixListsResponse;
        }
    }
}
