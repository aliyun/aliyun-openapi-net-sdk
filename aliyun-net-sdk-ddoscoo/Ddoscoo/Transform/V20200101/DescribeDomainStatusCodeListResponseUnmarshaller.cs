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
    public class DescribeDomainStatusCodeListResponseUnmarshaller
    {
        public static DescribeDomainStatusCodeListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainStatusCodeListResponse describeDomainStatusCodeListResponse = new DescribeDomainStatusCodeListResponse();

			describeDomainStatusCodeListResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainStatusCodeListResponse.RequestId = _ctx.StringValue("DescribeDomainStatusCodeList.RequestId");

			List<DescribeDomainStatusCodeListResponse.DescribeDomainStatusCodeList_StatusCode> describeDomainStatusCodeListResponse_statusCodeList = new List<DescribeDomainStatusCodeListResponse.DescribeDomainStatusCodeList_StatusCode>();
			for (int i = 0; i < _ctx.Length("DescribeDomainStatusCodeList.StatusCodeList.Length"); i++) {
				DescribeDomainStatusCodeListResponse.DescribeDomainStatusCodeList_StatusCode statusCode = new DescribeDomainStatusCodeListResponse.DescribeDomainStatusCodeList_StatusCode();
				statusCode.Index = _ctx.IntegerValue("DescribeDomainStatusCodeList.StatusCodeList["+ i +"].Index");
				statusCode.Time = _ctx.LongValue("DescribeDomainStatusCodeList.StatusCodeList["+ i +"].Time");
				statusCode.Status2XX = _ctx.LongValue("DescribeDomainStatusCodeList.StatusCodeList["+ i +"].Status2XX");
				statusCode.Status501 = _ctx.LongValue("DescribeDomainStatusCodeList.StatusCodeList["+ i +"].Status501");
				statusCode.Status502 = _ctx.LongValue("DescribeDomainStatusCodeList.StatusCodeList["+ i +"].Status502");
				statusCode.Status503 = _ctx.LongValue("DescribeDomainStatusCodeList.StatusCodeList["+ i +"].Status503");
				statusCode.Status504 = _ctx.LongValue("DescribeDomainStatusCodeList.StatusCodeList["+ i +"].Status504");
				statusCode.Status200 = _ctx.LongValue("DescribeDomainStatusCodeList.StatusCodeList["+ i +"].Status200");
				statusCode.Status405 = _ctx.LongValue("DescribeDomainStatusCodeList.StatusCodeList["+ i +"].Status405");
				statusCode.Status5XX = _ctx.LongValue("DescribeDomainStatusCodeList.StatusCodeList["+ i +"].Status5XX");
				statusCode.Status4XX = _ctx.LongValue("DescribeDomainStatusCodeList.StatusCodeList["+ i +"].Status4XX");
				statusCode.Status403 = _ctx.LongValue("DescribeDomainStatusCodeList.StatusCodeList["+ i +"].Status403");
				statusCode.Status404 = _ctx.LongValue("DescribeDomainStatusCodeList.StatusCodeList["+ i +"].Status404");
				statusCode.Status3XX = _ctx.LongValue("DescribeDomainStatusCodeList.StatusCodeList["+ i +"].Status3XX");

				describeDomainStatusCodeListResponse_statusCodeList.Add(statusCode);
			}
			describeDomainStatusCodeListResponse.StatusCodeList = describeDomainStatusCodeListResponse_statusCodeList;
        
			return describeDomainStatusCodeListResponse;
        }
    }
}
