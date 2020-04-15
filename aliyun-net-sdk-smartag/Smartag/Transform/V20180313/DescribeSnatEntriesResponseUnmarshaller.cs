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
    public class DescribeSnatEntriesResponseUnmarshaller
    {
        public static DescribeSnatEntriesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSnatEntriesResponse describeSnatEntriesResponse = new DescribeSnatEntriesResponse();

			describeSnatEntriesResponse.HttpResponse = context.HttpResponse;
			describeSnatEntriesResponse.RequestId = context.StringValue("DescribeSnatEntries.RequestId");
			describeSnatEntriesResponse.TotalCount = context.IntegerValue("DescribeSnatEntries.TotalCount");
			describeSnatEntriesResponse.PageNumber = context.IntegerValue("DescribeSnatEntries.PageNumber");
			describeSnatEntriesResponse.PageSize = context.IntegerValue("DescribeSnatEntries.PageSize");

			List<DescribeSnatEntriesResponse.DescribeSnatEntries_SnatEntry> describeSnatEntriesResponse_snatEntries = new List<DescribeSnatEntriesResponse.DescribeSnatEntries_SnatEntry>();
			for (int i = 0; i < context.Length("DescribeSnatEntries.SnatEntries.Length"); i++) {
				DescribeSnatEntriesResponse.DescribeSnatEntries_SnatEntry snatEntry = new DescribeSnatEntriesResponse.DescribeSnatEntries_SnatEntry();
				snatEntry.InstanceId = context.StringValue("DescribeSnatEntries.SnatEntries["+ i +"].InstanceId");
				snatEntry.CidrBlock = context.StringValue("DescribeSnatEntries.SnatEntries["+ i +"].CidrBlock");
				snatEntry.SnatIp = context.StringValue("DescribeSnatEntries.SnatEntries["+ i +"].SnatIp");
				snatEntry.CreateTime = context.LongValue("DescribeSnatEntries.SnatEntries["+ i +"].CreateTime");

				describeSnatEntriesResponse_snatEntries.Add(snatEntry);
			}
			describeSnatEntriesResponse.SnatEntries = describeSnatEntriesResponse_snatEntries;
        
			return describeSnatEntriesResponse;
        }
    }
}
