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
using Aliyun.Acs.waf_openapi.Model.V20180117;

namespace Aliyun.Acs.waf_openapi.Transform.V20180117
{
    public class DescribeDomainNamesResponseUnmarshaller
    {
        public static DescribeDomainNamesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainNamesResponse describeDomainNamesResponse = new DescribeDomainNamesResponse();

			describeDomainNamesResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainNamesResponse.RequestId = _ctx.StringValue("DescribeDomainNames.RequestId");

			List<string> describeDomainNamesResponse_result = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDomainNames.Result.Length"); i++) {
				describeDomainNamesResponse_result.Add(_ctx.StringValue("DescribeDomainNames.Result["+ i +"]"));
			}
			describeDomainNamesResponse.Result = describeDomainNamesResponse_result;
        
			return describeDomainNamesResponse;
        }
    }
}
