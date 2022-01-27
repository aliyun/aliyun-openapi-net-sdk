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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodDomainLogResponseUnmarshaller
    {
        public static DescribeVodDomainLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodDomainLogResponse describeVodDomainLogResponse = new DescribeVodDomainLogResponse();

			describeVodDomainLogResponse.HttpResponse = _ctx.HttpResponse;
			describeVodDomainLogResponse.RequestId = _ctx.StringValue("DescribeVodDomainLog.RequestId");

			List<DescribeVodDomainLogResponse.DescribeVodDomainLog_DomainLogDetail> describeVodDomainLogResponse_domainLogDetails = new List<DescribeVodDomainLogResponse.DescribeVodDomainLog_DomainLogDetail>();
			for (int i = 0; i < _ctx.Length("DescribeVodDomainLog.DomainLogDetails.Length"); i++) {
				DescribeVodDomainLogResponse.DescribeVodDomainLog_DomainLogDetail domainLogDetail = new DescribeVodDomainLogResponse.DescribeVodDomainLog_DomainLogDetail();
				domainLogDetail.DomainName = _ctx.StringValue("DescribeVodDomainLog.DomainLogDetails["+ i +"].DomainName");
				domainLogDetail.LogCount = _ctx.LongValue("DescribeVodDomainLog.DomainLogDetails["+ i +"].LogCount");

				DescribeVodDomainLogResponse.DescribeVodDomainLog_DomainLogDetail.DescribeVodDomainLog_PageInfos pageInfos = new DescribeVodDomainLogResponse.DescribeVodDomainLog_DomainLogDetail.DescribeVodDomainLog_PageInfos();
				pageInfos.PageNumber = _ctx.LongValue("DescribeVodDomainLog.DomainLogDetails["+ i +"].PageInfos.PageNumber");
				pageInfos.PageSize = _ctx.LongValue("DescribeVodDomainLog.DomainLogDetails["+ i +"].PageInfos.PageSize");
				pageInfos.Total = _ctx.LongValue("DescribeVodDomainLog.DomainLogDetails["+ i +"].PageInfos.Total");
				domainLogDetail.PageInfos = pageInfos;

				List<DescribeVodDomainLogResponse.DescribeVodDomainLog_DomainLogDetail.DescribeVodDomainLog_LogInfoDetail> domainLogDetail_logInfos = new List<DescribeVodDomainLogResponse.DescribeVodDomainLog_DomainLogDetail.DescribeVodDomainLog_LogInfoDetail>();
				for (int j = 0; j < _ctx.Length("DescribeVodDomainLog.DomainLogDetails["+ i +"].LogInfos.Length"); j++) {
					DescribeVodDomainLogResponse.DescribeVodDomainLog_DomainLogDetail.DescribeVodDomainLog_LogInfoDetail logInfoDetail = new DescribeVodDomainLogResponse.DescribeVodDomainLog_DomainLogDetail.DescribeVodDomainLog_LogInfoDetail();
					logInfoDetail.LogName = _ctx.StringValue("DescribeVodDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogName");
					logInfoDetail.LogPath = _ctx.StringValue("DescribeVodDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogPath");
					logInfoDetail.LogSize = _ctx.LongValue("DescribeVodDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].LogSize");
					logInfoDetail.StartTime = _ctx.StringValue("DescribeVodDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].StartTime");
					logInfoDetail.EndTime = _ctx.StringValue("DescribeVodDomainLog.DomainLogDetails["+ i +"].LogInfos["+ j +"].EndTime");

					domainLogDetail_logInfos.Add(logInfoDetail);
				}
				domainLogDetail.LogInfos = domainLogDetail_logInfos;

				describeVodDomainLogResponse_domainLogDetails.Add(domainLogDetail);
			}
			describeVodDomainLogResponse.DomainLogDetails = describeVodDomainLogResponse_domainLogDetails;
        
			return describeVodDomainLogResponse;
        }
    }
}
