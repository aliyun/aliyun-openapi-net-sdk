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
    public class ListPrefixListsResponseUnmarshaller
    {
        public static ListPrefixListsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPrefixListsResponse listPrefixListsResponse = new ListPrefixListsResponse();

			listPrefixListsResponse.HttpResponse = _ctx.HttpResponse;
			listPrefixListsResponse.RequestId = _ctx.StringValue("ListPrefixLists.RequestId");
			listPrefixListsResponse.NextToken = _ctx.StringValue("ListPrefixLists.NextToken");
			listPrefixListsResponse.TotalCount = _ctx.LongValue("ListPrefixLists.TotalCount");
			listPrefixListsResponse.MaxResults = _ctx.LongValue("ListPrefixLists.MaxResults");

			List<ListPrefixListsResponse.ListPrefixLists_PrefixList> listPrefixListsResponse_prefixLists = new List<ListPrefixListsResponse.ListPrefixLists_PrefixList>();
			for (int i = 0; i < _ctx.Length("ListPrefixLists.PrefixLists.Length"); i++) {
				ListPrefixListsResponse.ListPrefixLists_PrefixList prefixList = new ListPrefixListsResponse.ListPrefixLists_PrefixList();
				prefixList.PrefixListId = _ctx.StringValue("ListPrefixLists.PrefixLists["+ i +"].PrefixListId");
				prefixList.PrefixListName = _ctx.StringValue("ListPrefixLists.PrefixLists["+ i +"].PrefixListName");
				prefixList.PrefixListDescription = _ctx.StringValue("ListPrefixLists.PrefixLists["+ i +"].PrefixListDescription");
				prefixList.IpVersion = _ctx.StringValue("ListPrefixLists.PrefixLists["+ i +"].IpVersion");
				prefixList.CreationTime = _ctx.StringValue("ListPrefixLists.PrefixLists["+ i +"].CreationTime");
				prefixList.ShareType = _ctx.StringValue("ListPrefixLists.PrefixLists["+ i +"].ShareType");
				prefixList.MaxEntries = _ctx.IntegerValue("ListPrefixLists.PrefixLists["+ i +"].MaxEntries");
				prefixList.Status = _ctx.StringValue("ListPrefixLists.PrefixLists["+ i +"].Status");
				prefixList.OwnerId = _ctx.StringValue("ListPrefixLists.PrefixLists["+ i +"].OwnerId");
				prefixList.PrefixListStatus = _ctx.StringValue("ListPrefixLists.PrefixLists["+ i +"].PrefixListStatus");
				prefixList.RegionId = _ctx.StringValue("ListPrefixLists.PrefixLists["+ i +"].RegionId");
				prefixList.ResourceGroupId = _ctx.StringValue("ListPrefixLists.PrefixLists["+ i +"].ResourceGroupId");

				List<string> prefixList_cidrBlocks = new List<string>();
				for (int j = 0; j < _ctx.Length("ListPrefixLists.PrefixLists["+ i +"].CidrBlocks.Length"); j++) {
					prefixList_cidrBlocks.Add(_ctx.StringValue("ListPrefixLists.PrefixLists["+ i +"].CidrBlocks["+ j +"]"));
				}
				prefixList.CidrBlocks = prefixList_cidrBlocks;

				List<ListPrefixListsResponse.ListPrefixLists_PrefixList.ListPrefixLists_Tag> prefixList_tags = new List<ListPrefixListsResponse.ListPrefixLists_PrefixList.ListPrefixLists_Tag>();
				for (int j = 0; j < _ctx.Length("ListPrefixLists.PrefixLists["+ i +"].Tags.Length"); j++) {
					ListPrefixListsResponse.ListPrefixLists_PrefixList.ListPrefixLists_Tag tag = new ListPrefixListsResponse.ListPrefixLists_PrefixList.ListPrefixLists_Tag();
					tag.Key = _ctx.StringValue("ListPrefixLists.PrefixLists["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("ListPrefixLists.PrefixLists["+ i +"].Tags["+ j +"].Value");

					prefixList_tags.Add(tag);
				}
				prefixList.Tags = prefixList_tags;

				listPrefixListsResponse_prefixLists.Add(prefixList);
			}
			listPrefixListsResponse.PrefixLists = listPrefixListsResponse_prefixLists;
        
			return listPrefixListsResponse;
        }
    }
}
