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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnDomainLogResponseUnmarshaller
    {
        public static DescribeDcdnDomainLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnDomainLogResponse describeDcdnDomainLogResponse = new DescribeDcdnDomainLogResponse();

			describeDcdnDomainLogResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnDomainLogResponse.RequestId = _ctx.StringValue("DescribeDcdnDomainLog.RequestId");
			describeDcdnDomainLogResponse.DomainName = _ctx.StringValue("DescribeDcdnDomainLog.DomainName");

			List<DescribeDcdnDomainLogResponse.DescribeDcdnDomainLog_DomainLogDetail> describeDcdnDomainLogResponse_domainLogDetails = new List<DescribeDcdnDomainLogResponse.DescribeDcdnDomainLog_DomainLogDetail>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnDomainLog.DomainLogDetails.Length"); i++) {
				DescribeDcdnDomainLogResponse.DescribeDcdnDomainLog_DomainLogDetail domainLogDetail = new DescribeDcdnDomainLogResponse.DescribeDcdnDomainLog_DomainLogDetail();
				domainLogDetail.LogCount = _ctx.LongValue("DescribeDcdnDomainLog.DomainLogDetails["+ i +"].LogCount");

				DescribeDcdnDomainLogResponse.DescribeDcdnDomainLog_DomainLogDetail.DescribeDcdnDomainLog_PageInfos pageInfos = new DescribeDcdnDomainLogResponse.DescribeDcdnDomainLog_DomainLogDetail.DescribeDcdnDomainLog_PageInfos();
				pageInfos.PageIndex = _ctx.LongValue("DescribeDcdnDomainLog.DomainLogDetails["+ i +"].PageInfos.PageIndex");
				pageInfos.PageSize = _ctx.LongValue("DescribeDcdnDomainLog.DomainLogDetails["+ i +"].PageInfos.PageSize");
				pageInfos.Total = _ctx.LongValue("DescribeDcdnDomainLog.DomainLogDetails["+ i +"].PageInfos.Total");
				domainLogDetail.PageInfos = pageInfos;

				List<DescribeDcdnDomainLogResponse.DescribeDcdnDomainLog_DomainLogDetail.DescribeDcdnDomainLog_LogInfoDetail> domainLogDetail_logInfos = new List<DescribeDcdnDomainLogResponse.DescribeDcdnDomainLog_DomainLogDetail.DescribeDcdnDomainLog_LogInfoDetail>();
				for (int j = 0; j < _ctx.Length("DescribeDcdnDomainLog.DomainLogDetails["+ i +"].LogInfos.Length"); j++) {
					DescribeDcdnDomainLogResponse.DescribeDcdnDomainLog_DomainLogDetail.DescribeDcdnDomainLog_LogInfoDetail logInfoDetail = new DescribeDcdnDomainLogResponse.DescribeDcdnDomainLog_DomainLogDetail.DescribeDcdnDomainLog_LogInfoDetail();
					logInfoDetail.LogName = _ctx.StringValue("DescribeDcdnDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogName");
					logInfoDetail.LogPath = _ctx.StringValue("DescribeDcdnDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogPath");
					logInfoDetail.LogSize = _ctx.LongValue("DescribeDcdnDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogSize");
					logInfoDetail.StartTime = _ctx.StringValue("DescribeDcdnDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].StartTime");
					logInfoDetail.EndTime = _ctx.StringValue("DescribeDcdnDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].EndTime");

					domainLogDetail_logInfos.Add(logInfoDetail);
				}
				domainLogDetail.LogInfos = domainLogDetail_logInfos;

				describeDcdnDomainLogResponse_domainLogDetails.Add(domainLogDetail);
			}
			describeDcdnDomainLogResponse.DomainLogDetails = describeDcdnDomainLogResponse_domainLogDetails;
        
			return describeDcdnDomainLogResponse;
        }
    }
}
