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
    public class DescribeDomainViewTopUrlResponseUnmarshaller
    {
        public static DescribeDomainViewTopUrlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainViewTopUrlResponse describeDomainViewTopUrlResponse = new DescribeDomainViewTopUrlResponse();

			describeDomainViewTopUrlResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainViewTopUrlResponse.RequestId = _ctx.StringValue("DescribeDomainViewTopUrl.RequestId");

			List<DescribeDomainViewTopUrlResponse.DescribeDomainViewTopUrl_Url> describeDomainViewTopUrlResponse_urlList = new List<DescribeDomainViewTopUrlResponse.DescribeDomainViewTopUrl_Url>();
			for (int i = 0; i < _ctx.Length("DescribeDomainViewTopUrl.UrlList.Length"); i++) {
				DescribeDomainViewTopUrlResponse.DescribeDomainViewTopUrl_Url url = new DescribeDomainViewTopUrlResponse.DescribeDomainViewTopUrl_Url();
				url.Count = _ctx.LongValue("DescribeDomainViewTopUrl.UrlList["+ i +"].Count");
				url.Domain = _ctx.StringValue("DescribeDomainViewTopUrl.UrlList["+ i +"].Domain");
				url.Url = _ctx.StringValue("DescribeDomainViewTopUrl.UrlList["+ i +"].Url");

				describeDomainViewTopUrlResponse_urlList.Add(url);
			}
			describeDomainViewTopUrlResponse.UrlList = describeDomainViewTopUrlResponse_urlList;
        
			return describeDomainViewTopUrlResponse;
        }
    }
}
