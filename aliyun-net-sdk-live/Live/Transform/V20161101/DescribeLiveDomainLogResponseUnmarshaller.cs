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
    public class DescribeLiveDomainLogResponseUnmarshaller
    {
        public static DescribeLiveDomainLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainLogResponse describeLiveDomainLogResponse = new DescribeLiveDomainLogResponse();

			describeLiveDomainLogResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainLogResponse.DomainName = _ctx.StringValue("DescribeLiveDomainLog.DomainName");
			describeLiveDomainLogResponse.RequestId = _ctx.StringValue("DescribeLiveDomainLog.RequestId");

			List<DescribeLiveDomainLogResponse.DescribeLiveDomainLog_DomainLogDetail> describeLiveDomainLogResponse_domainLogDetails = new List<DescribeLiveDomainLogResponse.DescribeLiveDomainLog_DomainLogDetail>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainLog.DomainLogDetails.Length"); i++) {
				DescribeLiveDomainLogResponse.DescribeLiveDomainLog_DomainLogDetail domainLogDetail = new DescribeLiveDomainLogResponse.DescribeLiveDomainLog_DomainLogDetail();
				domainLogDetail.LogCount = _ctx.LongValue("DescribeLiveDomainLog.DomainLogDetails["+ i +"].LogCount");

				DescribeLiveDomainLogResponse.DescribeLiveDomainLog_DomainLogDetail.DescribeLiveDomainLog_PageInfos pageInfos = new DescribeLiveDomainLogResponse.DescribeLiveDomainLog_DomainLogDetail.DescribeLiveDomainLog_PageInfos();
				pageInfos.PageIndex = _ctx.LongValue("DescribeLiveDomainLog.DomainLogDetails["+ i +"].PageInfos.PageIndex");
				pageInfos.PageSize = _ctx.LongValue("DescribeLiveDomainLog.DomainLogDetails["+ i +"].PageInfos.PageSize");
				pageInfos.Total = _ctx.LongValue("DescribeLiveDomainLog.DomainLogDetails["+ i +"].PageInfos.Total");
				domainLogDetail.PageInfos = pageInfos;

				List<DescribeLiveDomainLogResponse.DescribeLiveDomainLog_DomainLogDetail.DescribeLiveDomainLog_LogInfoDetail> domainLogDetail_logInfos = new List<DescribeLiveDomainLogResponse.DescribeLiveDomainLog_DomainLogDetail.DescribeLiveDomainLog_LogInfoDetail>();
				for (int j = 0; j < _ctx.Length("DescribeLiveDomainLog.DomainLogDetails["+ i +"].LogInfos.Length"); j++) {
					DescribeLiveDomainLogResponse.DescribeLiveDomainLog_DomainLogDetail.DescribeLiveDomainLog_LogInfoDetail logInfoDetail = new DescribeLiveDomainLogResponse.DescribeLiveDomainLog_DomainLogDetail.DescribeLiveDomainLog_LogInfoDetail();
					logInfoDetail.EndTime = _ctx.StringValue("DescribeLiveDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].EndTime");
					logInfoDetail.LogSize = _ctx.LongValue("DescribeLiveDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogSize");
					logInfoDetail.StartTime = _ctx.StringValue("DescribeLiveDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].StartTime");
					logInfoDetail.LogName = _ctx.StringValue("DescribeLiveDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogName");
					logInfoDetail.LogPath = _ctx.StringValue("DescribeLiveDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogPath");

					domainLogDetail_logInfos.Add(logInfoDetail);
				}
				domainLogDetail.LogInfos = domainLogDetail_logInfos;

				describeLiveDomainLogResponse_domainLogDetails.Add(domainLogDetail);
			}
			describeLiveDomainLogResponse.DomainLogDetails = describeLiveDomainLogResponse_domainLogDetails;
        
			return describeLiveDomainLogResponse;
        }
    }
}
