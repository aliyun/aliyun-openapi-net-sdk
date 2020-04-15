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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeDnatEntriesResponseUnmarshaller
    {
        public static DescribeDnatEntriesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDnatEntriesResponse describeDnatEntriesResponse = new DescribeDnatEntriesResponse();

			describeDnatEntriesResponse.HttpResponse = context.HttpResponse;
			describeDnatEntriesResponse.RequestId = context.StringValue("DescribeDnatEntries.RequestId");
			describeDnatEntriesResponse.TotalCount = context.IntegerValue("DescribeDnatEntries.TotalCount");
			describeDnatEntriesResponse.PageNumber = context.IntegerValue("DescribeDnatEntries.PageNumber");
			describeDnatEntriesResponse.PageSize = context.IntegerValue("DescribeDnatEntries.PageSize");

			List<DescribeDnatEntriesResponse.DescribeDnatEntries_DnatEntry> describeDnatEntriesResponse_dnatEntries = new List<DescribeDnatEntriesResponse.DescribeDnatEntries_DnatEntry>();
			for (int i = 0; i < context.Length("DescribeDnatEntries.DnatEntries.Length"); i++) {
				DescribeDnatEntriesResponse.DescribeDnatEntries_DnatEntry dnatEntry = new DescribeDnatEntriesResponse.DescribeDnatEntries_DnatEntry();
				dnatEntry.DnatEntryId = context.StringValue("DescribeDnatEntries.DnatEntries["+ i +"].DnatEntryId");
				dnatEntry.Type = context.StringValue("DescribeDnatEntries.DnatEntries["+ i +"].Type");
				dnatEntry.SagId = context.StringValue("DescribeDnatEntries.DnatEntries["+ i +"].SagId");
				dnatEntry.ExternalIp = context.StringValue("DescribeDnatEntries.DnatEntries["+ i +"].ExternalIp");
				dnatEntry.ExternalPort = context.StringValue("DescribeDnatEntries.DnatEntries["+ i +"].ExternalPort");
				dnatEntry.InternalIp = context.StringValue("DescribeDnatEntries.DnatEntries["+ i +"].InternalIp");
				dnatEntry.IpProtocol = context.StringValue("DescribeDnatEntries.DnatEntries["+ i +"].IpProtocol");
				dnatEntry.InternalPort = context.StringValue("DescribeDnatEntries.DnatEntries["+ i +"].InternalPort");

				describeDnatEntriesResponse_dnatEntries.Add(dnatEntry);
			}
			describeDnatEntriesResponse.DnatEntries = describeDnatEntriesResponse_dnatEntries;
        
			return describeDnatEntriesResponse;
        }
    }
}
