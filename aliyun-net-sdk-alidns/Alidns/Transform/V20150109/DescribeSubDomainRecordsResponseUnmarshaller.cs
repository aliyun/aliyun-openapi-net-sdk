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
    public class DescribeSubDomainRecordsResponseUnmarshaller
    {
        public static DescribeSubDomainRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSubDomainRecordsResponse describeSubDomainRecordsResponse = new DescribeSubDomainRecordsResponse();

			describeSubDomainRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeSubDomainRecordsResponse.RequestId = _ctx.StringValue("DescribeSubDomainRecords.RequestId");
			describeSubDomainRecordsResponse.TotalCount = _ctx.LongValue("DescribeSubDomainRecords.TotalCount");
			describeSubDomainRecordsResponse.PageNumber = _ctx.LongValue("DescribeSubDomainRecords.PageNumber");
			describeSubDomainRecordsResponse.PageSize = _ctx.LongValue("DescribeSubDomainRecords.PageSize");

			List<DescribeSubDomainRecordsResponse.DescribeSubDomainRecords_Record> describeSubDomainRecordsResponse_domainRecords = new List<DescribeSubDomainRecordsResponse.DescribeSubDomainRecords_Record>();
			for (int i = 0; i < _ctx.Length("DescribeSubDomainRecords.DomainRecords.Length"); i++) {
				DescribeSubDomainRecordsResponse.DescribeSubDomainRecords_Record record = new DescribeSubDomainRecordsResponse.DescribeSubDomainRecords_Record();
				record.DomainName = _ctx.StringValue("DescribeSubDomainRecords.DomainRecords["+ i +"].DomainName");
				record.RecordId = _ctx.StringValue("DescribeSubDomainRecords.DomainRecords["+ i +"].RecordId");
				record.RR = _ctx.StringValue("DescribeSubDomainRecords.DomainRecords["+ i +"].RR");
				record.Type = _ctx.StringValue("DescribeSubDomainRecords.DomainRecords["+ i +"].Type");
				record._Value = _ctx.StringValue("DescribeSubDomainRecords.DomainRecords["+ i +"].Value");
				record.TTL = _ctx.LongValue("DescribeSubDomainRecords.DomainRecords["+ i +"].TTL");
				record.Priority = _ctx.LongValue("DescribeSubDomainRecords.DomainRecords["+ i +"].Priority");
				record.Line = _ctx.StringValue("DescribeSubDomainRecords.DomainRecords["+ i +"].Line");
				record.Status = _ctx.StringValue("DescribeSubDomainRecords.DomainRecords["+ i +"].Status");
				record.Locked = _ctx.BooleanValue("DescribeSubDomainRecords.DomainRecords["+ i +"].Locked");
				record.Weight = _ctx.IntegerValue("DescribeSubDomainRecords.DomainRecords["+ i +"].Weight");

				describeSubDomainRecordsResponse_domainRecords.Add(record);
			}
			describeSubDomainRecordsResponse.DomainRecords = describeSubDomainRecordsResponse_domainRecords;
        
			return describeSubDomainRecordsResponse;
        }
    }
}
