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
    public class DescribeSnatTableEntriesResponseUnmarshaller
    {
        public static DescribeSnatTableEntriesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSnatTableEntriesResponse describeSnatTableEntriesResponse = new DescribeSnatTableEntriesResponse();

			describeSnatTableEntriesResponse.HttpResponse = context.HttpResponse;
			describeSnatTableEntriesResponse.RequestId = context.StringValue("DescribeSnatTableEntries.RequestId");
			describeSnatTableEntriesResponse.TotalCount = context.IntegerValue("DescribeSnatTableEntries.TotalCount");
			describeSnatTableEntriesResponse.PageNumber = context.IntegerValue("DescribeSnatTableEntries.PageNumber");
			describeSnatTableEntriesResponse.PageSize = context.IntegerValue("DescribeSnatTableEntries.PageSize");

			List<DescribeSnatTableEntriesResponse.DescribeSnatTableEntries_SnatTableEntry> describeSnatTableEntriesResponse_snatTableEntries = new List<DescribeSnatTableEntriesResponse.DescribeSnatTableEntries_SnatTableEntry>();
			for (int i = 0; i < context.Length("DescribeSnatTableEntries.SnatTableEntries.Length"); i++) {
				DescribeSnatTableEntriesResponse.DescribeSnatTableEntries_SnatTableEntry snatTableEntry = new DescribeSnatTableEntriesResponse.DescribeSnatTableEntries_SnatTableEntry();
				snatTableEntry.SnatTableId = context.StringValue("DescribeSnatTableEntries.SnatTableEntries["+ i +"].SnatTableId");
				snatTableEntry.SnatEntryId = context.StringValue("DescribeSnatTableEntries.SnatTableEntries["+ i +"].SnatEntryId");
				snatTableEntry.SourceVSwitchId = context.StringValue("DescribeSnatTableEntries.SnatTableEntries["+ i +"].SourceVSwitchId");
				snatTableEntry.SourceCIDR = context.StringValue("DescribeSnatTableEntries.SnatTableEntries["+ i +"].SourceCIDR");
				snatTableEntry.SnatIp = context.StringValue("DescribeSnatTableEntries.SnatTableEntries["+ i +"].SnatIp");
				snatTableEntry.Status = context.StringValue("DescribeSnatTableEntries.SnatTableEntries["+ i +"].Status");

				describeSnatTableEntriesResponse_snatTableEntries.Add(snatTableEntry);
			}
			describeSnatTableEntriesResponse.SnatTableEntries = describeSnatTableEntriesResponse_snatTableEntries;
        
			return describeSnatTableEntriesResponse;
        }
    }
}