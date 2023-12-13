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
    public class DescribeLiveDomainEdgeLogResponseUnmarshaller
    {
        public static DescribeLiveDomainEdgeLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainEdgeLogResponse describeLiveDomainEdgeLogResponse = new DescribeLiveDomainEdgeLogResponse();

			describeLiveDomainEdgeLogResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainEdgeLogResponse.DomainName = _ctx.StringValue("DescribeLiveDomainEdgeLog.DomainName");
			describeLiveDomainEdgeLogResponse.RequestId = _ctx.StringValue("DescribeLiveDomainEdgeLog.RequestId");

			List<DescribeLiveDomainEdgeLogResponse.DescribeLiveDomainEdgeLog_DomainLogDetail> describeLiveDomainEdgeLogResponse_domainLogDetails = new List<DescribeLiveDomainEdgeLogResponse.DescribeLiveDomainEdgeLog_DomainLogDetail>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainEdgeLog.DomainLogDetails.Length"); i++) {
				DescribeLiveDomainEdgeLogResponse.DescribeLiveDomainEdgeLog_DomainLogDetail domainLogDetail = new DescribeLiveDomainEdgeLogResponse.DescribeLiveDomainEdgeLog_DomainLogDetail();
				domainLogDetail.LogCount = _ctx.LongValue("DescribeLiveDomainEdgeLog.DomainLogDetails["+ i +"].LogCount");

				DescribeLiveDomainEdgeLogResponse.DescribeLiveDomainEdgeLog_DomainLogDetail.DescribeLiveDomainEdgeLog_PageInfos pageInfos = new DescribeLiveDomainEdgeLogResponse.DescribeLiveDomainEdgeLog_DomainLogDetail.DescribeLiveDomainEdgeLog_PageInfos();
				pageInfos.PageIndex = _ctx.LongValue("DescribeLiveDomainEdgeLog.DomainLogDetails["+ i +"].PageInfos.PageIndex");
				pageInfos.PageSize = _ctx.LongValue("DescribeLiveDomainEdgeLog.DomainLogDetails["+ i +"].PageInfos.PageSize");
				pageInfos.Total = _ctx.LongValue("DescribeLiveDomainEdgeLog.DomainLogDetails["+ i +"].PageInfos.Total");
				domainLogDetail.PageInfos = pageInfos;

				List<DescribeLiveDomainEdgeLogResponse.DescribeLiveDomainEdgeLog_DomainLogDetail.DescribeLiveDomainEdgeLog_LogInfoDetail> domainLogDetail_logInfos = new List<DescribeLiveDomainEdgeLogResponse.DescribeLiveDomainEdgeLog_DomainLogDetail.DescribeLiveDomainEdgeLog_LogInfoDetail>();
				for (int j = 0; j < _ctx.Length("DescribeLiveDomainEdgeLog.DomainLogDetails["+ i +"].LogInfos.Length"); j++) {
					DescribeLiveDomainEdgeLogResponse.DescribeLiveDomainEdgeLog_DomainLogDetail.DescribeLiveDomainEdgeLog_LogInfoDetail logInfoDetail = new DescribeLiveDomainEdgeLogResponse.DescribeLiveDomainEdgeLog_DomainLogDetail.DescribeLiveDomainEdgeLog_LogInfoDetail();
					logInfoDetail.EndTime = _ctx.StringValue("DescribeLiveDomainEdgeLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].EndTime");
					logInfoDetail.LogSize = _ctx.LongValue("DescribeLiveDomainEdgeLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogSize");
					logInfoDetail.StartTime = _ctx.StringValue("DescribeLiveDomainEdgeLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].StartTime");
					logInfoDetail.LogName = _ctx.StringValue("DescribeLiveDomainEdgeLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogName");
					logInfoDetail.LogPath = _ctx.StringValue("DescribeLiveDomainEdgeLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogPath");

					domainLogDetail_logInfos.Add(logInfoDetail);
				}
				domainLogDetail.LogInfos = domainLogDetail_logInfos;

				describeLiveDomainEdgeLogResponse_domainLogDetails.Add(domainLogDetail);
			}
			describeLiveDomainEdgeLogResponse.DomainLogDetails = describeLiveDomainEdgeLogResponse_domainLogDetails;
        
			return describeLiveDomainEdgeLogResponse;
        }
    }
}
