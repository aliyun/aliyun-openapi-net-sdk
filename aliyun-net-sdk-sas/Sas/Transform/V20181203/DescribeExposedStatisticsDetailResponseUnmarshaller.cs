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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeExposedStatisticsDetailResponseUnmarshaller
    {
        public static DescribeExposedStatisticsDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeExposedStatisticsDetailResponse describeExposedStatisticsDetailResponse = new DescribeExposedStatisticsDetailResponse();

			describeExposedStatisticsDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeExposedStatisticsDetailResponse.RequestId = _ctx.StringValue("DescribeExposedStatisticsDetail.RequestId");

			DescribeExposedStatisticsDetailResponse.DescribeExposedStatisticsDetail_PageInfo pageInfo = new DescribeExposedStatisticsDetailResponse.DescribeExposedStatisticsDetail_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribeExposedStatisticsDetail.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeExposedStatisticsDetail.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeExposedStatisticsDetail.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeExposedStatisticsDetail.PageInfo.CurrentPage");
			describeExposedStatisticsDetailResponse.PageInfo = pageInfo;

			List<DescribeExposedStatisticsDetailResponse.DescribeExposedStatisticsDetail_StatisticsDetail> describeExposedStatisticsDetailResponse_statisticsDetails = new List<DescribeExposedStatisticsDetailResponse.DescribeExposedStatisticsDetail_StatisticsDetail>();
			for (int i = 0; i < _ctx.Length("DescribeExposedStatisticsDetail.StatisticsDetails.Length"); i++) {
				DescribeExposedStatisticsDetailResponse.DescribeExposedStatisticsDetail_StatisticsDetail statisticsDetail = new DescribeExposedStatisticsDetailResponse.DescribeExposedStatisticsDetail_StatisticsDetail();
				statisticsDetail.ExposureComponent = _ctx.StringValue("DescribeExposedStatisticsDetail.StatisticsDetails["+ i +"].ExposureComponent");
				statisticsDetail.ExposureType = _ctx.StringValue("DescribeExposedStatisticsDetail.StatisticsDetails["+ i +"].ExposureType");
				statisticsDetail.ExposureTypeId = _ctx.StringValue("DescribeExposedStatisticsDetail.StatisticsDetails["+ i +"].ExposureTypeId");
				statisticsDetail.ExposurePort = _ctx.StringValue("DescribeExposedStatisticsDetail.StatisticsDetails["+ i +"].ExposurePort");
				statisticsDetail.ExposureIp = _ctx.StringValue("DescribeExposedStatisticsDetail.StatisticsDetails["+ i +"].ExposureIp");
				statisticsDetail.ExposureTypeInstanceName = _ctx.StringValue("DescribeExposedStatisticsDetail.StatisticsDetails["+ i +"].ExposureTypeInstanceName");
				statisticsDetail.ExposedCount = _ctx.IntegerValue("DescribeExposedStatisticsDetail.StatisticsDetails["+ i +"].ExposedCount");
				statisticsDetail.RegionId = _ctx.StringValue("DescribeExposedStatisticsDetail.StatisticsDetails["+ i +"].RegionId");

				describeExposedStatisticsDetailResponse_statisticsDetails.Add(statisticsDetail);
			}
			describeExposedStatisticsDetailResponse.StatisticsDetails = describeExposedStatisticsDetailResponse_statisticsDetails;
        
			return describeExposedStatisticsDetailResponse;
        }
    }
}
