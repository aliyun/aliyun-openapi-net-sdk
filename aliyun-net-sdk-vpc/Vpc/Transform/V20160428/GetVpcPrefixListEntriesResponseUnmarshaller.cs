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
    public class GetVpcPrefixListEntriesResponseUnmarshaller
    {
        public static GetVpcPrefixListEntriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVpcPrefixListEntriesResponse getVpcPrefixListEntriesResponse = new GetVpcPrefixListEntriesResponse();

			getVpcPrefixListEntriesResponse.HttpResponse = _ctx.HttpResponse;
			getVpcPrefixListEntriesResponse.RequestId = _ctx.StringValue("GetVpcPrefixListEntries.RequestId");
			getVpcPrefixListEntriesResponse.NextToken = _ctx.StringValue("GetVpcPrefixListEntries.NextToken");
			getVpcPrefixListEntriesResponse.TotalCount = _ctx.LongValue("GetVpcPrefixListEntries.TotalCount");
			getVpcPrefixListEntriesResponse.Count = _ctx.LongValue("GetVpcPrefixListEntries.Count");

			List<GetVpcPrefixListEntriesResponse.GetVpcPrefixListEntries_PrefixListCidrs> getVpcPrefixListEntriesResponse_prefixListEntry = new List<GetVpcPrefixListEntriesResponse.GetVpcPrefixListEntries_PrefixListCidrs>();
			for (int i = 0; i < _ctx.Length("GetVpcPrefixListEntries.PrefixListEntry.Length"); i++) {
				GetVpcPrefixListEntriesResponse.GetVpcPrefixListEntries_PrefixListCidrs prefixListCidrs = new GetVpcPrefixListEntriesResponse.GetVpcPrefixListEntries_PrefixListCidrs();
				prefixListCidrs.PrefixListId = _ctx.StringValue("GetVpcPrefixListEntries.PrefixListEntry["+ i +"].PrefixListId");
				prefixListCidrs.Cidr = _ctx.StringValue("GetVpcPrefixListEntries.PrefixListEntry["+ i +"].Cidr");
				prefixListCidrs.Description = _ctx.StringValue("GetVpcPrefixListEntries.PrefixListEntry["+ i +"].Description");
				prefixListCidrs.RegionId = _ctx.StringValue("GetVpcPrefixListEntries.PrefixListEntry["+ i +"].RegionId");

				getVpcPrefixListEntriesResponse_prefixListEntry.Add(prefixListCidrs);
			}
			getVpcPrefixListEntriesResponse.PrefixListEntry = getVpcPrefixListEntriesResponse_prefixListEntry;
        
			return getVpcPrefixListEntriesResponse;
        }
    }
}
