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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeCdnDomainLogsResponseUnmarshaller
    {
        public static DescribeCdnDomainLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnDomainLogsResponse describeCdnDomainLogsResponse = new DescribeCdnDomainLogsResponse();

			describeCdnDomainLogsResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnDomainLogsResponse.RequestId = _ctx.StringValue("DescribeCdnDomainLogs.RequestId");

			List<DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogDetail> describeCdnDomainLogsResponse_domainLogDetails = new List<DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogDetail>();
			for (int i = 0; i < _ctx.Length("DescribeCdnDomainLogs.DomainLogDetails.Length"); i++) {
				DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogDetail domainLogDetail = new DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogDetail();
				domainLogDetail.DomainName = _ctx.StringValue("DescribeCdnDomainLogs.DomainLogDetails["+ i +"].DomainName");
				domainLogDetail.LogCount = _ctx.LongValue("DescribeCdnDomainLogs.DomainLogDetails["+ i +"].LogCount");

				List<DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogDetail.DescribeCdnDomainLogs_PageInfoDetail> domainLogDetail_pageInfos = new List<DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogDetail.DescribeCdnDomainLogs_PageInfoDetail>();
				for (int j = 0; j < _ctx.Length("DescribeCdnDomainLogs.DomainLogDetails["+ i +"].PageInfos.Length"); j++) {
					DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogDetail.DescribeCdnDomainLogs_PageInfoDetail pageInfoDetail = new DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogDetail.DescribeCdnDomainLogs_PageInfoDetail();
					pageInfoDetail.PageIndex = _ctx.LongValue("DescribeCdnDomainLogs.DomainLogDetails["+ i +"].PageInfos["+ j +"].PageIndex");
					pageInfoDetail.PageSize = _ctx.LongValue("DescribeCdnDomainLogs.DomainLogDetails["+ i +"].PageInfos["+ j +"].PageSize");
					pageInfoDetail.Total = _ctx.LongValue("DescribeCdnDomainLogs.DomainLogDetails["+ i +"].PageInfos["+ j +"].Total");

					domainLogDetail_pageInfos.Add(pageInfoDetail);
				}
				domainLogDetail.PageInfos = domainLogDetail_pageInfos;

				List<DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogDetail.DescribeCdnDomainLogs_LogInfoDetail> domainLogDetail_logInfos = new List<DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogDetail.DescribeCdnDomainLogs_LogInfoDetail>();
				for (int j = 0; j < _ctx.Length("DescribeCdnDomainLogs.DomainLogDetails["+ i +"].LogInfos.Length"); j++) {
					DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogDetail.DescribeCdnDomainLogs_LogInfoDetail logInfoDetail = new DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogDetail.DescribeCdnDomainLogs_LogInfoDetail();
					logInfoDetail.LogName = _ctx.StringValue("DescribeCdnDomainLogs.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogName");
					logInfoDetail.LogPath = _ctx.StringValue("DescribeCdnDomainLogs.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogPath");
					logInfoDetail.LogSize = _ctx.LongValue("DescribeCdnDomainLogs.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogSize");
					logInfoDetail.StartTime = _ctx.StringValue("DescribeCdnDomainLogs.DomainLogDetails["+ i +"].LogInfos["+ j +"].StartTime");
					logInfoDetail.EndTime = _ctx.StringValue("DescribeCdnDomainLogs.DomainLogDetails["+ i +"].LogInfos["+ j +"].EndTime");

					domainLogDetail_logInfos.Add(logInfoDetail);
				}
				domainLogDetail.LogInfos = domainLogDetail_logInfos;

				describeCdnDomainLogsResponse_domainLogDetails.Add(domainLogDetail);
			}
			describeCdnDomainLogsResponse.DomainLogDetails = describeCdnDomainLogsResponse_domainLogDetails;
        
			return describeCdnDomainLogsResponse;
        }
    }
}
