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
using System.Collections.Generic;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeSubDomainRecordsResponseUnmarshaller
    {
        public static DescribeSubDomainRecordsResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeSubDomainRecordsResponse describeSubDomainRecordsResponse = new DescribeSubDomainRecordsResponse
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeSubDomainRecords.RequestId"),
                TotalCount = context.LongValue("DescribeSubDomainRecords.TotalCount"),
                PageNumber = context.LongValue("DescribeSubDomainRecords.PageNumber"),
                PageSize = context.LongValue("DescribeSubDomainRecords.PageSize")
            };


            List<DescribeSubDomainRecordsResponse.Record> domainRecords = new List<DescribeSubDomainRecordsResponse.Record>();
			for (int i = 0; i < context.Length("DescribeSubDomainRecords.DomainRecords.Length"); i++) {
			    DescribeSubDomainRecordsResponse.Record record = new DescribeSubDomainRecordsResponse.Record
			    {
			        DomainName = context.StringValue($"DescribeSubDomainRecords.DomainRecords[{i}].DomainName"),
			        RecordId = context.StringValue($"DescribeSubDomainRecords.DomainRecords[{i}].RecordId"),
			        RR = context.StringValue($"DescribeSubDomainRecords.DomainRecords[{i}].RR"),
			        Type = context.StringValue($"DescribeSubDomainRecords.DomainRecords[{i}].Type"),
			        Value = context.StringValue($"DescribeSubDomainRecords.DomainRecords[{i}].Value"),
			        TTL = context.LongValue($"DescribeSubDomainRecords.DomainRecords[{i}].TTL"),
			        Priority = context.LongValue($"DescribeSubDomainRecords.DomainRecords[{i}].Priority"),
			        Line = context.StringValue($"DescribeSubDomainRecords.DomainRecords[{i}].Line"),
			        Status = context.StringValue($"DescribeSubDomainRecords.DomainRecords[{i}].Status"),
			        Locked = context.BooleanValue($"DescribeSubDomainRecords.DomainRecords[{i}].Locked"),
			        Weight = context.IntegerValue($"DescribeSubDomainRecords.DomainRecords[{i}].Weight")
			    };

			    domainRecords.Add(record);
			}
			describeSubDomainRecordsResponse.DomainRecords = domainRecords;
        
			return describeSubDomainRecordsResponse;
        }
    }
}