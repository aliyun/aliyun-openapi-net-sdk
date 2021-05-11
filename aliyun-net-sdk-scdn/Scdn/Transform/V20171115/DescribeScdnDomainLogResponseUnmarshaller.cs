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
using Aliyun.Acs.scdn.Model.V20171115;

namespace Aliyun.Acs.scdn.Transform.V20171115
{
    public class DescribeScdnDomainLogResponseUnmarshaller
    {
        public static DescribeScdnDomainLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScdnDomainLogResponse describeScdnDomainLogResponse = new DescribeScdnDomainLogResponse();

			describeScdnDomainLogResponse.HttpResponse = _ctx.HttpResponse;
			describeScdnDomainLogResponse.RequestId = _ctx.StringValue("DescribeScdnDomainLog.RequestId");
			describeScdnDomainLogResponse.DomainName = _ctx.StringValue("DescribeScdnDomainLog.DomainName");

			List<DescribeScdnDomainLogResponse.DescribeScdnDomainLog_DomainLogDetail> describeScdnDomainLogResponse_domainLogDetails = new List<DescribeScdnDomainLogResponse.DescribeScdnDomainLog_DomainLogDetail>();
			for (int i = 0; i < _ctx.Length("DescribeScdnDomainLog.DomainLogDetails.Length"); i++) {
				DescribeScdnDomainLogResponse.DescribeScdnDomainLog_DomainLogDetail domainLogDetail = new DescribeScdnDomainLogResponse.DescribeScdnDomainLog_DomainLogDetail();
				domainLogDetail.LogCount = _ctx.LongValue("DescribeScdnDomainLog.DomainLogDetails["+ i +"].LogCount");

				DescribeScdnDomainLogResponse.DescribeScdnDomainLog_DomainLogDetail.DescribeScdnDomainLog_PageInfos pageInfos = new DescribeScdnDomainLogResponse.DescribeScdnDomainLog_DomainLogDetail.DescribeScdnDomainLog_PageInfos();
				pageInfos.PageNumber = _ctx.LongValue("DescribeScdnDomainLog.DomainLogDetails["+ i +"].PageInfos.PageNumber");
				pageInfos.PageSize = _ctx.LongValue("DescribeScdnDomainLog.DomainLogDetails["+ i +"].PageInfos.PageSize");
				pageInfos.Total = _ctx.LongValue("DescribeScdnDomainLog.DomainLogDetails["+ i +"].PageInfos.Total");
				domainLogDetail.PageInfos = pageInfos;

				List<DescribeScdnDomainLogResponse.DescribeScdnDomainLog_DomainLogDetail.DescribeScdnDomainLog_LogInfoDetail> domainLogDetail_logInfos = new List<DescribeScdnDomainLogResponse.DescribeScdnDomainLog_DomainLogDetail.DescribeScdnDomainLog_LogInfoDetail>();
				for (int j = 0; j < _ctx.Length("DescribeScdnDomainLog.DomainLogDetails["+ i +"].LogInfos.Length"); j++) {
					DescribeScdnDomainLogResponse.DescribeScdnDomainLog_DomainLogDetail.DescribeScdnDomainLog_LogInfoDetail logInfoDetail = new DescribeScdnDomainLogResponse.DescribeScdnDomainLog_DomainLogDetail.DescribeScdnDomainLog_LogInfoDetail();
					logInfoDetail.LogName = _ctx.StringValue("DescribeScdnDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogName");
					logInfoDetail.LogPath = _ctx.StringValue("DescribeScdnDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogPath");
					logInfoDetail.LogSize = _ctx.LongValue("DescribeScdnDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogSize");
					logInfoDetail.StartTime = _ctx.StringValue("DescribeScdnDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].StartTime");
					logInfoDetail.EndTime = _ctx.StringValue("DescribeScdnDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].EndTime");

					domainLogDetail_logInfos.Add(logInfoDetail);
				}
				domainLogDetail.LogInfos = domainLogDetail_logInfos;

				describeScdnDomainLogResponse_domainLogDetails.Add(domainLogDetail);
			}
			describeScdnDomainLogResponse.DomainLogDetails = describeScdnDomainLogResponse_domainLogDetails;
        
			return describeScdnDomainLogResponse;
        }
    }
}
