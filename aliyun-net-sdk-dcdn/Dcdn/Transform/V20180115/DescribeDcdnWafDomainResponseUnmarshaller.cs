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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnWafDomainResponseUnmarshaller
    {
        public static DescribeDcdnWafDomainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnWafDomainResponse describeDcdnWafDomainResponse = new DescribeDcdnWafDomainResponse();

			describeDcdnWafDomainResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnWafDomainResponse.RequestId = _ctx.StringValue("DescribeDcdnWafDomain.RequestId");
			describeDcdnWafDomainResponse.TotalCount = _ctx.IntegerValue("DescribeDcdnWafDomain.TotalCount");

			List<DescribeDcdnWafDomainResponse.DescribeDcdnWafDomain_OutPutDomain> describeDcdnWafDomainResponse_outPutDomains = new List<DescribeDcdnWafDomainResponse.DescribeDcdnWafDomain_OutPutDomain>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnWafDomain.OutPutDomains.Length"); i++) {
				DescribeDcdnWafDomainResponse.DescribeDcdnWafDomain_OutPutDomain outPutDomain = new DescribeDcdnWafDomainResponse.DescribeDcdnWafDomain_OutPutDomain();
				outPutDomain.Status = _ctx.IntegerValue("DescribeDcdnWafDomain.OutPutDomains["+ i +"].Status");
				outPutDomain.Domain = _ctx.StringValue("DescribeDcdnWafDomain.OutPutDomains["+ i +"].Domain");
				outPutDomain.WafStatus = _ctx.IntegerValue("DescribeDcdnWafDomain.OutPutDomains["+ i +"].WafStatus");
				outPutDomain.CcStatus = _ctx.IntegerValue("DescribeDcdnWafDomain.OutPutDomains["+ i +"].CcStatus");
				outPutDomain.AclStatus = _ctx.IntegerValue("DescribeDcdnWafDomain.OutPutDomains["+ i +"].AclStatus");

				describeDcdnWafDomainResponse_outPutDomains.Add(outPutDomain);
			}
			describeDcdnWafDomainResponse.OutPutDomains = describeDcdnWafDomainResponse_outPutDomains;
        
			return describeDcdnWafDomainResponse;
        }
    }
}
