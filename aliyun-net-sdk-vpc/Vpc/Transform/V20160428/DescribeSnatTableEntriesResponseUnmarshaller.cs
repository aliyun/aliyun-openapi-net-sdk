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
    public class DescribeSnatTableEntriesResponseUnmarshaller
    {
        public static DescribeSnatTableEntriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSnatTableEntriesResponse describeSnatTableEntriesResponse = new DescribeSnatTableEntriesResponse();

			describeSnatTableEntriesResponse.HttpResponse = _ctx.HttpResponse;
			describeSnatTableEntriesResponse.RequestId = _ctx.StringValue("DescribeSnatTableEntries.RequestId");
			describeSnatTableEntriesResponse.TotalCount = _ctx.IntegerValue("DescribeSnatTableEntries.TotalCount");
			describeSnatTableEntriesResponse.PageNumber = _ctx.IntegerValue("DescribeSnatTableEntries.PageNumber");
			describeSnatTableEntriesResponse.PageSize = _ctx.IntegerValue("DescribeSnatTableEntries.PageSize");

			List<DescribeSnatTableEntriesResponse.DescribeSnatTableEntries_SnatTableEntry> describeSnatTableEntriesResponse_snatTableEntries = new List<DescribeSnatTableEntriesResponse.DescribeSnatTableEntries_SnatTableEntry>();
			for (int i = 0; i < _ctx.Length("DescribeSnatTableEntries.SnatTableEntries.Length"); i++) {
				DescribeSnatTableEntriesResponse.DescribeSnatTableEntries_SnatTableEntry snatTableEntry = new DescribeSnatTableEntriesResponse.DescribeSnatTableEntries_SnatTableEntry();
				snatTableEntry.SnatTableId = _ctx.StringValue("DescribeSnatTableEntries.SnatTableEntries["+ i +"].SnatTableId");
				snatTableEntry.SnatEntryId = _ctx.StringValue("DescribeSnatTableEntries.SnatTableEntries["+ i +"].SnatEntryId");
				snatTableEntry.SourceVSwitchId = _ctx.StringValue("DescribeSnatTableEntries.SnatTableEntries["+ i +"].SourceVSwitchId");
				snatTableEntry.SourceCIDR = _ctx.StringValue("DescribeSnatTableEntries.SnatTableEntries["+ i +"].SourceCIDR");
				snatTableEntry.SnatIp = _ctx.StringValue("DescribeSnatTableEntries.SnatTableEntries["+ i +"].SnatIp");
				snatTableEntry.Status = _ctx.StringValue("DescribeSnatTableEntries.SnatTableEntries["+ i +"].Status");
				snatTableEntry.SnatEntryName = _ctx.StringValue("DescribeSnatTableEntries.SnatTableEntries["+ i +"].SnatEntryName");

				describeSnatTableEntriesResponse_snatTableEntries.Add(snatTableEntry);
			}
			describeSnatTableEntriesResponse.SnatTableEntries = describeSnatTableEntriesResponse_snatTableEntries;
        
			return describeSnatTableEntriesResponse;
        }
    }
}
