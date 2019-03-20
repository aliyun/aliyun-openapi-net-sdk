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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeDomainRecordsResponseUnmarshaller
    {
        public static DescribeDomainRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainRecordsResponse describeDomainRecordsResponse = new DescribeDomainRecordsResponse();

			describeDomainRecordsResponse.HttpResponse = context.HttpResponse;
			describeDomainRecordsResponse.RequestId = context.StringValue("DescribeDomainRecords.RequestId");
			describeDomainRecordsResponse.TotalCount = context.LongValue("DescribeDomainRecords.TotalCount");
			describeDomainRecordsResponse.PageNumber = context.LongValue("DescribeDomainRecords.PageNumber");
			describeDomainRecordsResponse.PageSize = context.LongValue("DescribeDomainRecords.PageSize");

			List<DescribeDomainRecordsResponse.DescribeDomainRecords_Record> describeDomainRecordsResponse_domainRecords = new List<DescribeDomainRecordsResponse.DescribeDomainRecords_Record>();
			for (int i = 0; i < context.Length("DescribeDomainRecords.DomainRecords.Length"); i++) {
				DescribeDomainRecordsResponse.DescribeDomainRecords_Record record = new DescribeDomainRecordsResponse.DescribeDomainRecords_Record();
				record.DomainName = context.StringValue("DescribeDomainRecords.DomainRecords["+ i +"].DomainName");
				record.RecordId = context.StringValue("DescribeDomainRecords.DomainRecords["+ i +"].RecordId");
				record.RR = context.StringValue("DescribeDomainRecords.DomainRecords["+ i +"].RR");
				record.Type = context.StringValue("DescribeDomainRecords.DomainRecords["+ i +"].Type");
				record._Value = context.StringValue("DescribeDomainRecords.DomainRecords["+ i +"].Value");
				record.TTL = context.LongValue("DescribeDomainRecords.DomainRecords["+ i +"].TTL");
				record.Priority = context.LongValue("DescribeDomainRecords.DomainRecords["+ i +"].Priority");
				record.Line = context.StringValue("DescribeDomainRecords.DomainRecords["+ i +"].Line");
				record.Status = context.StringValue("DescribeDomainRecords.DomainRecords["+ i +"].Status");
				record.Locked = context.BooleanValue("DescribeDomainRecords.DomainRecords["+ i +"].Locked");
				record.Weight = context.IntegerValue("DescribeDomainRecords.DomainRecords["+ i +"].Weight");
				record.Remark = context.StringValue("DescribeDomainRecords.DomainRecords["+ i +"].Remark");

				describeDomainRecordsResponse_domainRecords.Add(record);
			}
			describeDomainRecordsResponse.DomainRecords = describeDomainRecordsResponse_domainRecords;
        
			return describeDomainRecordsResponse;
        }
    }
}
