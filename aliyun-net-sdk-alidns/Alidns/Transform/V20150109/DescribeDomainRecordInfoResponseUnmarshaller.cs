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
    public class DescribeDomainRecordInfoResponseUnmarshaller
    {
        public static DescribeDomainRecordInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainRecordInfoResponse describeDomainRecordInfoResponse = new DescribeDomainRecordInfoResponse();

			describeDomainRecordInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainRecordInfoResponse.RequestId = _ctx.StringValue("DescribeDomainRecordInfo.RequestId");
			describeDomainRecordInfoResponse.DomainId = _ctx.StringValue("DescribeDomainRecordInfo.DomainId");
			describeDomainRecordInfoResponse.DomainName = _ctx.StringValue("DescribeDomainRecordInfo.DomainName");
			describeDomainRecordInfoResponse.PunyCode = _ctx.StringValue("DescribeDomainRecordInfo.PunyCode");
			describeDomainRecordInfoResponse.GroupId = _ctx.StringValue("DescribeDomainRecordInfo.GroupId");
			describeDomainRecordInfoResponse.GroupName = _ctx.StringValue("DescribeDomainRecordInfo.GroupName");
			describeDomainRecordInfoResponse.RecordId = _ctx.StringValue("DescribeDomainRecordInfo.RecordId");
			describeDomainRecordInfoResponse.RR = _ctx.StringValue("DescribeDomainRecordInfo.RR");
			describeDomainRecordInfoResponse.Type = _ctx.StringValue("DescribeDomainRecordInfo.Type");
			describeDomainRecordInfoResponse._Value = _ctx.StringValue("DescribeDomainRecordInfo.Value");
			describeDomainRecordInfoResponse.TTL = _ctx.LongValue("DescribeDomainRecordInfo.TTL");
			describeDomainRecordInfoResponse.Priority = _ctx.LongValue("DescribeDomainRecordInfo.Priority");
			describeDomainRecordInfoResponse.Line = _ctx.StringValue("DescribeDomainRecordInfo.Line");
			describeDomainRecordInfoResponse.Status = _ctx.StringValue("DescribeDomainRecordInfo.Status");
			describeDomainRecordInfoResponse.Locked = _ctx.BooleanValue("DescribeDomainRecordInfo.Locked");
        
			return describeDomainRecordInfoResponse;
        }
    }
}
