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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeDomainStatusCodeCountResponseUnmarshaller
    {
        public static DescribeDomainStatusCodeCountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainStatusCodeCountResponse describeDomainStatusCodeCountResponse = new DescribeDomainStatusCodeCountResponse();

			describeDomainStatusCodeCountResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainStatusCodeCountResponse.RequestId = _ctx.StringValue("DescribeDomainStatusCodeCount.RequestId");
			describeDomainStatusCodeCountResponse.Status2XX = _ctx.LongValue("DescribeDomainStatusCodeCount.Status2XX");
			describeDomainStatusCodeCountResponse.Status501 = _ctx.LongValue("DescribeDomainStatusCodeCount.Status501");
			describeDomainStatusCodeCountResponse.Status502 = _ctx.LongValue("DescribeDomainStatusCodeCount.Status502");
			describeDomainStatusCodeCountResponse.Status503 = _ctx.LongValue("DescribeDomainStatusCodeCount.Status503");
			describeDomainStatusCodeCountResponse.Status504 = _ctx.LongValue("DescribeDomainStatusCodeCount.Status504");
			describeDomainStatusCodeCountResponse.Status200 = _ctx.LongValue("DescribeDomainStatusCodeCount.Status200");
			describeDomainStatusCodeCountResponse.Status405 = _ctx.LongValue("DescribeDomainStatusCodeCount.Status405");
			describeDomainStatusCodeCountResponse.Status5XX = _ctx.LongValue("DescribeDomainStatusCodeCount.Status5XX");
			describeDomainStatusCodeCountResponse.Status4XX = _ctx.LongValue("DescribeDomainStatusCodeCount.Status4XX");
			describeDomainStatusCodeCountResponse.Status403 = _ctx.LongValue("DescribeDomainStatusCodeCount.Status403");
			describeDomainStatusCodeCountResponse.Status404 = _ctx.LongValue("DescribeDomainStatusCodeCount.Status404");
			describeDomainStatusCodeCountResponse.Status3XX = _ctx.LongValue("DescribeDomainStatusCodeCount.Status3XX");
        
			return describeDomainStatusCodeCountResponse;
        }
    }
}
