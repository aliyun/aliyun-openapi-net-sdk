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
    public class DescribeDomainDnssecInfoResponseUnmarshaller
    {
        public static DescribeDomainDnssecInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainDnssecInfoResponse describeDomainDnssecInfoResponse = new DescribeDomainDnssecInfoResponse();

			describeDomainDnssecInfoResponse.HttpResponse = context.HttpResponse;
			describeDomainDnssecInfoResponse.RequestId = context.StringValue("DescribeDomainDnssecInfo.RequestId");
			describeDomainDnssecInfoResponse.DomainName = context.StringValue("DescribeDomainDnssecInfo.DomainName");
			describeDomainDnssecInfoResponse.Status = context.StringValue("DescribeDomainDnssecInfo.Status");
			describeDomainDnssecInfoResponse.DsRecord = context.StringValue("DescribeDomainDnssecInfo.DsRecord");
			describeDomainDnssecInfoResponse.Digest = context.StringValue("DescribeDomainDnssecInfo.Digest");
			describeDomainDnssecInfoResponse.DigestType = context.StringValue("DescribeDomainDnssecInfo.DigestType");
			describeDomainDnssecInfoResponse.Algorithm = context.StringValue("DescribeDomainDnssecInfo.Algorithm");
			describeDomainDnssecInfoResponse.PublicKey = context.StringValue("DescribeDomainDnssecInfo.PublicKey");
			describeDomainDnssecInfoResponse.KeyTag = context.StringValue("DescribeDomainDnssecInfo.KeyTag");
			describeDomainDnssecInfoResponse.Flags = context.StringValue("DescribeDomainDnssecInfo.Flags");
        
			return describeDomainDnssecInfoResponse;
        }
    }
}
