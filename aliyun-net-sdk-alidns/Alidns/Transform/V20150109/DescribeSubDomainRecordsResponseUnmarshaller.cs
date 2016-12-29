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
using Aliyun.Acs.Alidns.Model.V20150109;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeSubDomainRecordsResponseUnmarshaller
    {
        public static DescribeSubDomainRecordsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSubDomainRecordsResponse describeSubDomainRecordsResponse = new DescribeSubDomainRecordsResponse();

			describeSubDomainRecordsResponse.HttpResponse = context.HttpResponse;
			describeSubDomainRecordsResponse.RequestId = context.StringValue("DescribeSubDomainRecords.RequestId");
			describeSubDomainRecordsResponse.TotalCount = context.LongValue("DescribeSubDomainRecords.TotalCount");
			describeSubDomainRecordsResponse.PageNumber = context.LongValue("DescribeSubDomainRecords.PageNumber");
			describeSubDomainRecordsResponse.PageSize = context.LongValue("DescribeSubDomainRecords.PageSize");

			List<DescribeSubDomainRecordsResponse.Record> domainRecords = new List<DescribeSubDomainRecordsResponse.Record>();
			for (int i = 0; i < context.Length("DescribeSubDomainRecords.DomainRecords.Length"); i++) {
				DescribeSubDomainRecordsResponse.Record record = new DescribeSubDomainRecordsResponse.Record();
				record.DomainName = context.StringValue("DescribeSubDomainRecords.DomainRecords["+ i +"].DomainName");
				record.RecordId = context.StringValue("DescribeSubDomainRecords.DomainRecords["+ i +"].RecordId");
				record.RR = context.StringValue("DescribeSubDomainRecords.DomainRecords["+ i +"].RR");
				record.Type = context.StringValue("DescribeSubDomainRecords.DomainRecords["+ i +"].Type");
				record.Value = context.StringValue("DescribeSubDomainRecords.DomainRecords["+ i +"].Value");
				record.TTL = context.LongValue("DescribeSubDomainRecords.DomainRecords["+ i +"].TTL");
				record.Priority = context.LongValue("DescribeSubDomainRecords.DomainRecords["+ i +"].Priority");
				record.Line = context.StringValue("DescribeSubDomainRecords.DomainRecords["+ i +"].Line");
				record.Status = context.StringValue("DescribeSubDomainRecords.DomainRecords["+ i +"].Status");
				record.Locked = context.BooleanValue("DescribeSubDomainRecords.DomainRecords["+ i +"].Locked");
				record.Weight = context.IntegerValue("DescribeSubDomainRecords.DomainRecords["+ i +"].Weight");

				domainRecords.Add(record);
			}
			describeSubDomainRecordsResponse.DomainRecords = domainRecords;
        
			return describeSubDomainRecordsResponse;
        }
    }
}