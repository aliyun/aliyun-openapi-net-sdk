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
    public class DescribeVodDomainMax95BpsDataResponseUnmarshaller
    {
        public static DescribeVodDomainMax95BpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodDomainMax95BpsDataResponse describeVodDomainMax95BpsDataResponse = new DescribeVodDomainMax95BpsDataResponse();

			describeVodDomainMax95BpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVodDomainMax95BpsDataResponse.RequestId = _ctx.StringValue("DescribeVodDomainMax95BpsData.RequestId");
			describeVodDomainMax95BpsDataResponse.DomainName = _ctx.StringValue("DescribeVodDomainMax95BpsData.DomainName");
			describeVodDomainMax95BpsDataResponse.EndTime = _ctx.StringValue("DescribeVodDomainMax95BpsData.EndTime");
			describeVodDomainMax95BpsDataResponse.StartTime = _ctx.StringValue("DescribeVodDomainMax95BpsData.StartTime");
			describeVodDomainMax95BpsDataResponse.DomesticMax95Bps = _ctx.StringValue("DescribeVodDomainMax95BpsData.DomesticMax95Bps");
			describeVodDomainMax95BpsDataResponse.OverseasMax95Bps = _ctx.StringValue("DescribeVodDomainMax95BpsData.OverseasMax95Bps");
			describeVodDomainMax95BpsDataResponse.Max95Bps = _ctx.StringValue("DescribeVodDomainMax95BpsData.Max95Bps");

			List<DescribeVodDomainMax95BpsDataResponse.DescribeVodDomainMax95BpsData_Max95Detail> describeVodDomainMax95BpsDataResponse_detailData = new List<DescribeVodDomainMax95BpsDataResponse.DescribeVodDomainMax95BpsData_Max95Detail>();
			for (int i = 0; i < _ctx.Length("DescribeVodDomainMax95BpsData.DetailData.Length"); i++) {
				DescribeVodDomainMax95BpsDataResponse.DescribeVodDomainMax95BpsData_Max95Detail max95Detail = new DescribeVodDomainMax95BpsDataResponse.DescribeVodDomainMax95BpsData_Max95Detail();
				max95Detail.TimeStamp = _ctx.StringValue("DescribeVodDomainMax95BpsData.DetailData["+ i +"].TimeStamp");
				max95Detail.Area = _ctx.StringValue("DescribeVodDomainMax95BpsData.DetailData["+ i +"].Area");
				max95Detail.Max95BpsPeakTime = _ctx.StringValue("DescribeVodDomainMax95BpsData.DetailData["+ i +"].Max95BpsPeakTime");
				max95Detail.Max95Bps = _ctx.FloatValue("DescribeVodDomainMax95BpsData.DetailData["+ i +"].Max95Bps");

				describeVodDomainMax95BpsDataResponse_detailData.Add(max95Detail);
			}
			describeVodDomainMax95BpsDataResponse.DetailData = describeVodDomainMax95BpsDataResponse_detailData;
        
			return describeVodDomainMax95BpsDataResponse;
        }
    }
}
