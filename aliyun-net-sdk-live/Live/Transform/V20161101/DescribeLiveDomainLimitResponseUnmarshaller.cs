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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveDomainLimitResponseUnmarshaller
    {
        public static DescribeLiveDomainLimitResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainLimitResponse describeLiveDomainLimitResponse = new DescribeLiveDomainLimitResponse();

			describeLiveDomainLimitResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainLimitResponse.RequestId = _ctx.StringValue("DescribeLiveDomainLimit.RequestId");

			List<DescribeLiveDomainLimitResponse.DescribeLiveDomainLimit_LiveDomainLimit> describeLiveDomainLimitResponse_liveDomainLimitList = new List<DescribeLiveDomainLimitResponse.DescribeLiveDomainLimit_LiveDomainLimit>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainLimit.LiveDomainLimitList.Length"); i++) {
				DescribeLiveDomainLimitResponse.DescribeLiveDomainLimit_LiveDomainLimit liveDomainLimit = new DescribeLiveDomainLimitResponse.DescribeLiveDomainLimit_LiveDomainLimit();
				liveDomainLimit.DomainName = _ctx.StringValue("DescribeLiveDomainLimit.LiveDomainLimitList["+ i +"].DomainName");
				liveDomainLimit.LimitNum = _ctx.IntegerValue("DescribeLiveDomainLimit.LiveDomainLimitList["+ i +"].LimitNum");
				liveDomainLimit.LimitTranscodeNum = _ctx.IntegerValue("DescribeLiveDomainLimit.LiveDomainLimitList["+ i +"].LimitTranscodeNum");

				describeLiveDomainLimitResponse_liveDomainLimitList.Add(liveDomainLimit);
			}
			describeLiveDomainLimitResponse.LiveDomainLimitList = describeLiveDomainLimitResponse_liveDomainLimitList;
        
			return describeLiveDomainLimitResponse;
        }
    }
}
