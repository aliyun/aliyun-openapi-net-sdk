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
    public class DescribePrefixListAttributesResponseUnmarshaller
    {
        public static DescribePrefixListAttributesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePrefixListAttributesResponse describePrefixListAttributesResponse = new DescribePrefixListAttributesResponse();

			describePrefixListAttributesResponse.HttpResponse = _ctx.HttpResponse;
			describePrefixListAttributesResponse.RequestId = _ctx.StringValue("DescribePrefixListAttributes.RequestId");
			describePrefixListAttributesResponse.PrefixListId = _ctx.StringValue("DescribePrefixListAttributes.PrefixListId");
			describePrefixListAttributesResponse.PrefixListName = _ctx.StringValue("DescribePrefixListAttributes.PrefixListName");
			describePrefixListAttributesResponse.AddressFamily = _ctx.StringValue("DescribePrefixListAttributes.AddressFamily");
			describePrefixListAttributesResponse.MaxEntries = _ctx.IntegerValue("DescribePrefixListAttributes.MaxEntries");
			describePrefixListAttributesResponse.Description = _ctx.StringValue("DescribePrefixListAttributes.Description");
			describePrefixListAttributesResponse.CreationTime = _ctx.StringValue("DescribePrefixListAttributes.CreationTime");

			List<DescribePrefixListAttributesResponse.DescribePrefixListAttributes_Entry> describePrefixListAttributesResponse_entries = new List<DescribePrefixListAttributesResponse.DescribePrefixListAttributes_Entry>();
			for (int i = 0; i < _ctx.Length("DescribePrefixListAttributes.Entries.Length"); i++) {
				DescribePrefixListAttributesResponse.DescribePrefixListAttributes_Entry entry = new DescribePrefixListAttributesResponse.DescribePrefixListAttributes_Entry();
				entry.Cidr = _ctx.StringValue("DescribePrefixListAttributes.Entries["+ i +"].Cidr");
				entry.Description = _ctx.StringValue("DescribePrefixListAttributes.Entries["+ i +"].Description");

				describePrefixListAttributesResponse_entries.Add(entry);
			}
			describePrefixListAttributesResponse.Entries = describePrefixListAttributesResponse_entries;
        
			return describePrefixListAttributesResponse;
        }
    }
}
