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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeCdnDomainLogsResponseUnmarshaller
    {
        public static DescribeCdnDomainLogsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCdnDomainLogsResponse describeCdnDomainLogsResponse = new DescribeCdnDomainLogsResponse();

			describeCdnDomainLogsResponse.HttpResponse = context.HttpResponse;
			describeCdnDomainLogsResponse.RequestId = context.StringValue("DescribeCdnDomainLogs.RequestId");
			describeCdnDomainLogsResponse.PageNo = context.LongValue("DescribeCdnDomainLogs.PageNo");
			describeCdnDomainLogsResponse.PageSize = context.LongValue("DescribeCdnDomainLogs.PageSize");
			describeCdnDomainLogsResponse.Total = context.LongValue("DescribeCdnDomainLogs.Total");

			DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogModel domainLogModel = new DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogModel();
			domainLogModel.DomainName = context.StringValue("DescribeCdnDomainLogs.DomainLogModel.DomainName");

			List<DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogModel.DescribeCdnDomainLogs_DomainLogDetail> domainLogModel_domainLogDetails = new List<DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogModel.DescribeCdnDomainLogs_DomainLogDetail>();
			for (int i = 0; i < context.Length("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails.Length"); i++) {
				DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogModel.DescribeCdnDomainLogs_DomainLogDetail domainLogDetail = new DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogModel.DescribeCdnDomainLogs_DomainLogDetail();
				domainLogDetail.LogPath = context.StringValue("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails["+ i +"].LogPath");
				domainLogDetail.StartTime = context.StringValue("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails["+ i +"].StartTime");
				domainLogDetail.EndTime = context.StringValue("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails["+ i +"].EndTime");
				domainLogDetail.LogSize = context.LongValue("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails["+ i +"].LogSize");
				domainLogDetail.LogName = context.StringValue("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails["+ i +"].LogName");

				domainLogModel_domainLogDetails.Add(domainLogDetail);
			}
			domainLogModel.DomainLogDetails = domainLogModel_domainLogDetails;
			describeCdnDomainLogsResponse.DomainLogModel = domainLogModel;
        
			return describeCdnDomainLogsResponse;
        }
    }
}