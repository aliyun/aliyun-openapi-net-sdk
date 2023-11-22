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
    public class DescribeLiveDomainLogExTtlResponseUnmarshaller
    {
        public static DescribeLiveDomainLogExTtlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainLogExTtlResponse describeLiveDomainLogExTtlResponse = new DescribeLiveDomainLogExTtlResponse();

			describeLiveDomainLogExTtlResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainLogExTtlResponse.DomainName = _ctx.StringValue("DescribeLiveDomainLogExTtl.DomainName");
			describeLiveDomainLogExTtlResponse.RequestId = _ctx.StringValue("DescribeLiveDomainLogExTtl.RequestId");

			List<DescribeLiveDomainLogExTtlResponse.DescribeLiveDomainLogExTtl_DomainLogDetail> describeLiveDomainLogExTtlResponse_domainLogDetails = new List<DescribeLiveDomainLogExTtlResponse.DescribeLiveDomainLogExTtl_DomainLogDetail>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainLogExTtl.DomainLogDetails.Length"); i++) {
				DescribeLiveDomainLogExTtlResponse.DescribeLiveDomainLogExTtl_DomainLogDetail domainLogDetail = new DescribeLiveDomainLogExTtlResponse.DescribeLiveDomainLogExTtl_DomainLogDetail();
				domainLogDetail.LogCount = _ctx.LongValue("DescribeLiveDomainLogExTtl.DomainLogDetails["+ i +"].LogCount");

				DescribeLiveDomainLogExTtlResponse.DescribeLiveDomainLogExTtl_DomainLogDetail.DescribeLiveDomainLogExTtl_PageInfos pageInfos = new DescribeLiveDomainLogExTtlResponse.DescribeLiveDomainLogExTtl_DomainLogDetail.DescribeLiveDomainLogExTtl_PageInfos();
				pageInfos.PageIndex = _ctx.LongValue("DescribeLiveDomainLogExTtl.DomainLogDetails["+ i +"].PageInfos.PageIndex");
				pageInfos.PageSize = _ctx.LongValue("DescribeLiveDomainLogExTtl.DomainLogDetails["+ i +"].PageInfos.PageSize");
				pageInfos.Total = _ctx.LongValue("DescribeLiveDomainLogExTtl.DomainLogDetails["+ i +"].PageInfos.Total");
				domainLogDetail.PageInfos = pageInfos;

				List<DescribeLiveDomainLogExTtlResponse.DescribeLiveDomainLogExTtl_DomainLogDetail.DescribeLiveDomainLogExTtl_LogInfoDetail> domainLogDetail_logInfos = new List<DescribeLiveDomainLogExTtlResponse.DescribeLiveDomainLogExTtl_DomainLogDetail.DescribeLiveDomainLogExTtl_LogInfoDetail>();
				for (int j = 0; j < _ctx.Length("DescribeLiveDomainLogExTtl.DomainLogDetails["+ i +"].LogInfos.Length"); j++) {
					DescribeLiveDomainLogExTtlResponse.DescribeLiveDomainLogExTtl_DomainLogDetail.DescribeLiveDomainLogExTtl_LogInfoDetail logInfoDetail = new DescribeLiveDomainLogExTtlResponse.DescribeLiveDomainLogExTtl_DomainLogDetail.DescribeLiveDomainLogExTtl_LogInfoDetail();
					logInfoDetail.EndTime = _ctx.StringValue("DescribeLiveDomainLogExTtl.DomainLogDetails["+ i +"].LogInfos["+ j +"].EndTime");
					logInfoDetail.LogSize = _ctx.LongValue("DescribeLiveDomainLogExTtl.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogSize");
					logInfoDetail.StartTime = _ctx.StringValue("DescribeLiveDomainLogExTtl.DomainLogDetails["+ i +"].LogInfos["+ j +"].StartTime");
					logInfoDetail.LogName = _ctx.StringValue("DescribeLiveDomainLogExTtl.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogName");
					logInfoDetail.LogPath = _ctx.StringValue("DescribeLiveDomainLogExTtl.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogPath");

					domainLogDetail_logInfos.Add(logInfoDetail);
				}
				domainLogDetail.LogInfos = domainLogDetail_logInfos;

				describeLiveDomainLogExTtlResponse_domainLogDetails.Add(domainLogDetail);
			}
			describeLiveDomainLogExTtlResponse.DomainLogDetails = describeLiveDomainLogExTtlResponse_domainLogDetails;
        
			return describeLiveDomainLogExTtlResponse;
        }
    }
}
