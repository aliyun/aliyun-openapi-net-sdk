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
        public static DescribeDomainRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainRecordsResponse describeDomainRecordsResponse = new DescribeDomainRecordsResponse();

			describeDomainRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainRecordsResponse.RequestId = _ctx.StringValue("DescribeDomainRecords.RequestId");
			describeDomainRecordsResponse.TotalCount = _ctx.LongValue("DescribeDomainRecords.TotalCount");
			describeDomainRecordsResponse.PageNumber = _ctx.LongValue("DescribeDomainRecords.PageNumber");
			describeDomainRecordsResponse.PageSize = _ctx.LongValue("DescribeDomainRecords.PageSize");

			List<DescribeDomainRecordsResponse.DescribeDomainRecords_Record> describeDomainRecordsResponse_domainRecords = new List<DescribeDomainRecordsResponse.DescribeDomainRecords_Record>();
			for (int i = 0; i < _ctx.Length("DescribeDomainRecords.DomainRecords.Length"); i++) {
				DescribeDomainRecordsResponse.DescribeDomainRecords_Record record = new DescribeDomainRecordsResponse.DescribeDomainRecords_Record();
				record.DomainName = _ctx.StringValue("DescribeDomainRecords.DomainRecords["+ i +"].DomainName");
				record.RecordId = _ctx.StringValue("DescribeDomainRecords.DomainRecords["+ i +"].RecordId");
				record.RR = _ctx.StringValue("DescribeDomainRecords.DomainRecords["+ i +"].RR");
				record.Type = _ctx.StringValue("DescribeDomainRecords.DomainRecords["+ i +"].Type");
				record._Value = _ctx.StringValue("DescribeDomainRecords.DomainRecords["+ i +"].Value");
				record.TTL = _ctx.LongValue("DescribeDomainRecords.DomainRecords["+ i +"].TTL");
				record.Priority = _ctx.LongValue("DescribeDomainRecords.DomainRecords["+ i +"].Priority");
				record.Line = _ctx.StringValue("DescribeDomainRecords.DomainRecords["+ i +"].Line");
				record.Status = _ctx.StringValue("DescribeDomainRecords.DomainRecords["+ i +"].Status");
				record.Locked = _ctx.BooleanValue("DescribeDomainRecords.DomainRecords["+ i +"].Locked");
				record.Weight = _ctx.IntegerValue("DescribeDomainRecords.DomainRecords["+ i +"].Weight");
				record.Remark = _ctx.StringValue("DescribeDomainRecords.DomainRecords["+ i +"].Remark");

				describeDomainRecordsResponse_domainRecords.Add(record);
			}
			describeDomainRecordsResponse.DomainRecords = describeDomainRecordsResponse_domainRecords;
        
			return describeDomainRecordsResponse;
        }
    }
}
