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
    public class DescribeLivePushProxyLogResponseUnmarshaller
    {
        public static DescribeLivePushProxyLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLivePushProxyLogResponse describeLivePushProxyLogResponse = new DescribeLivePushProxyLogResponse();

			describeLivePushProxyLogResponse.HttpResponse = _ctx.HttpResponse;
			describeLivePushProxyLogResponse.DomainName = _ctx.StringValue("DescribeLivePushProxyLog.DomainName");
			describeLivePushProxyLogResponse.RequestId = _ctx.StringValue("DescribeLivePushProxyLog.RequestId");

			List<DescribeLivePushProxyLogResponse.DescribeLivePushProxyLog_DomainLogDetail> describeLivePushProxyLogResponse_domainLogDetails = new List<DescribeLivePushProxyLogResponse.DescribeLivePushProxyLog_DomainLogDetail>();
			for (int i = 0; i < _ctx.Length("DescribeLivePushProxyLog.DomainLogDetails.Length"); i++) {
				DescribeLivePushProxyLogResponse.DescribeLivePushProxyLog_DomainLogDetail domainLogDetail = new DescribeLivePushProxyLogResponse.DescribeLivePushProxyLog_DomainLogDetail();
				domainLogDetail.LogCount = _ctx.LongValue("DescribeLivePushProxyLog.DomainLogDetails["+ i +"].LogCount");

				DescribeLivePushProxyLogResponse.DescribeLivePushProxyLog_DomainLogDetail.DescribeLivePushProxyLog_PageInfos pageInfos = new DescribeLivePushProxyLogResponse.DescribeLivePushProxyLog_DomainLogDetail.DescribeLivePushProxyLog_PageInfos();
				pageInfos.PageIndex = _ctx.LongValue("DescribeLivePushProxyLog.DomainLogDetails["+ i +"].PageInfos.PageIndex");
				pageInfos.PageSize = _ctx.LongValue("DescribeLivePushProxyLog.DomainLogDetails["+ i +"].PageInfos.PageSize");
				pageInfos.Total = _ctx.LongValue("DescribeLivePushProxyLog.DomainLogDetails["+ i +"].PageInfos.Total");
				domainLogDetail.PageInfos = pageInfos;

				List<DescribeLivePushProxyLogResponse.DescribeLivePushProxyLog_DomainLogDetail.DescribeLivePushProxyLog_LogInfoDetail> domainLogDetail_logInfos = new List<DescribeLivePushProxyLogResponse.DescribeLivePushProxyLog_DomainLogDetail.DescribeLivePushProxyLog_LogInfoDetail>();
				for (int j = 0; j < _ctx.Length("DescribeLivePushProxyLog.DomainLogDetails["+ i +"].LogInfos.Length"); j++) {
					DescribeLivePushProxyLogResponse.DescribeLivePushProxyLog_DomainLogDetail.DescribeLivePushProxyLog_LogInfoDetail logInfoDetail = new DescribeLivePushProxyLogResponse.DescribeLivePushProxyLog_DomainLogDetail.DescribeLivePushProxyLog_LogInfoDetail();
					logInfoDetail.EndTime = _ctx.StringValue("DescribeLivePushProxyLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].EndTime");
					logInfoDetail.LogSize = _ctx.LongValue("DescribeLivePushProxyLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogSize");
					logInfoDetail.StartTime = _ctx.StringValue("DescribeLivePushProxyLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].StartTime");
					logInfoDetail.LogName = _ctx.StringValue("DescribeLivePushProxyLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogName");
					logInfoDetail.LogPath = _ctx.StringValue("DescribeLivePushProxyLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogPath");

					domainLogDetail_logInfos.Add(logInfoDetail);
				}
				domainLogDetail.LogInfos = domainLogDetail_logInfos;

				describeLivePushProxyLogResponse_domainLogDetails.Add(domainLogDetail);
			}
			describeLivePushProxyLogResponse.DomainLogDetails = describeLivePushProxyLogResponse_domainLogDetails;
        
			return describeLivePushProxyLogResponse;
        }
    }
}
