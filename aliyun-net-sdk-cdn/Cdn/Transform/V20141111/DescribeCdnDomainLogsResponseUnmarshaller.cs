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
using Aliyun.Acs.Cdn.Model.V20141111;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeCdnDomainLogsResponseUnmarshaller
    {
        public static DescribeCdnDomainLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnDomainLogsResponse describeCdnDomainLogsResponse = new DescribeCdnDomainLogsResponse();

			describeCdnDomainLogsResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnDomainLogsResponse.RequestId = _ctx.StringValue("DescribeCdnDomainLogs.RequestId");
			describeCdnDomainLogsResponse.PageNumber = _ctx.LongValue("DescribeCdnDomainLogs.PageNumber");
			describeCdnDomainLogsResponse.PageSize = _ctx.LongValue("DescribeCdnDomainLogs.PageSize");
			describeCdnDomainLogsResponse.TotalCount = _ctx.LongValue("DescribeCdnDomainLogs.TotalCount");

			DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogModel domainLogModel = new DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogModel();
			domainLogModel.DomainName = _ctx.StringValue("DescribeCdnDomainLogs.DomainLogModel.DomainName");

			List<DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogModel.DescribeCdnDomainLogs_DomainLogDetail> domainLogModel_domainLogDetails = new List<DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogModel.DescribeCdnDomainLogs_DomainLogDetail>();
			for (int i = 0; i < _ctx.Length("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails.Length"); i++) {
				DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogModel.DescribeCdnDomainLogs_DomainLogDetail domainLogDetail = new DescribeCdnDomainLogsResponse.DescribeCdnDomainLogs_DomainLogModel.DescribeCdnDomainLogs_DomainLogDetail();
				domainLogDetail.LogName = _ctx.StringValue("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails["+ i +"].LogName");
				domainLogDetail.LogPath = _ctx.StringValue("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails["+ i +"].LogPath");
				domainLogDetail.LogSize = _ctx.LongValue("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails["+ i +"].LogSize");
				domainLogDetail.StartTime = _ctx.StringValue("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails["+ i +"].StartTime");
				domainLogDetail.EndTime = _ctx.StringValue("DescribeCdnDomainLogs.DomainLogModel.DomainLogDetails["+ i +"].EndTime");

				domainLogModel_domainLogDetails.Add(domainLogDetail);
			}
			domainLogModel.DomainLogDetails = domainLogModel_domainLogDetails;
			describeCdnDomainLogsResponse.DomainLogModel = domainLogModel;
        
			return describeCdnDomainLogsResponse;
        }
    }
}
