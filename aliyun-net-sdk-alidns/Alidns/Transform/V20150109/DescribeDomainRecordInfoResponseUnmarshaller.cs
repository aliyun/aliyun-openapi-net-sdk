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
    public class DescribeDomainRecordInfoResponseUnmarshaller
    {
        public static DescribeDomainRecordInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainRecordInfoResponse describeDomainRecordInfoResponse = new DescribeDomainRecordInfoResponse();

			describeDomainRecordInfoResponse.HttpResponse = context.HttpResponse;
			describeDomainRecordInfoResponse.RequestId = context.StringValue("DescribeDomainRecordInfo.RequestId");
			describeDomainRecordInfoResponse.DomainId = context.StringValue("DescribeDomainRecordInfo.DomainId");
			describeDomainRecordInfoResponse.DomainName = context.StringValue("DescribeDomainRecordInfo.DomainName");
			describeDomainRecordInfoResponse.PunyCode = context.StringValue("DescribeDomainRecordInfo.PunyCode");
			describeDomainRecordInfoResponse.GroupId = context.StringValue("DescribeDomainRecordInfo.GroupId");
			describeDomainRecordInfoResponse.GroupName = context.StringValue("DescribeDomainRecordInfo.GroupName");
			describeDomainRecordInfoResponse.RecordId = context.StringValue("DescribeDomainRecordInfo.RecordId");
			describeDomainRecordInfoResponse.RR = context.StringValue("DescribeDomainRecordInfo.RR");
			describeDomainRecordInfoResponse.Type = context.StringValue("DescribeDomainRecordInfo.Type");
			describeDomainRecordInfoResponse.Value = context.StringValue("DescribeDomainRecordInfo.Value");
			describeDomainRecordInfoResponse.TTL = context.LongValue("DescribeDomainRecordInfo.TTL");
			describeDomainRecordInfoResponse.Priority = context.LongValue("DescribeDomainRecordInfo.Priority");
			describeDomainRecordInfoResponse.Line = context.StringValue("DescribeDomainRecordInfo.Line");
			describeDomainRecordInfoResponse.Status = context.StringValue("DescribeDomainRecordInfo.Status");
			describeDomainRecordInfoResponse.Locked = context.BooleanValue("DescribeDomainRecordInfo.Locked");
        
			return describeDomainRecordInfoResponse;
        }
    }
}