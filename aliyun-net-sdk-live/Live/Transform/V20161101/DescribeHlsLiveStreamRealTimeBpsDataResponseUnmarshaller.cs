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
    public class DescribeHlsLiveStreamRealTimeBpsDataResponseUnmarshaller
    {
        public static DescribeHlsLiveStreamRealTimeBpsDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeHlsLiveStreamRealTimeBpsDataResponse describeHlsLiveStreamRealTimeBpsDataResponse = new DescribeHlsLiveStreamRealTimeBpsDataResponse();

			describeHlsLiveStreamRealTimeBpsDataResponse.HttpResponse = _ctx.HttpResponse;
			describeHlsLiveStreamRealTimeBpsDataResponse.Time = _ctx.StringValue("DescribeHlsLiveStreamRealTimeBpsData.Time");
			describeHlsLiveStreamRealTimeBpsDataResponse.RequestId = _ctx.StringValue("DescribeHlsLiveStreamRealTimeBpsData.RequestId");

			List<DescribeHlsLiveStreamRealTimeBpsDataResponse.DescribeHlsLiveStreamRealTimeBpsData_UsageDataPerDomain> describeHlsLiveStreamRealTimeBpsDataResponse_usageData = new List<DescribeHlsLiveStreamRealTimeBpsDataResponse.DescribeHlsLiveStreamRealTimeBpsData_UsageDataPerDomain>();
			for (int i = 0; i < _ctx.Length("DescribeHlsLiveStreamRealTimeBpsData.UsageData.Length"); i++) {
				DescribeHlsLiveStreamRealTimeBpsDataResponse.DescribeHlsLiveStreamRealTimeBpsData_UsageDataPerDomain usageDataPerDomain = new DescribeHlsLiveStreamRealTimeBpsDataResponse.DescribeHlsLiveStreamRealTimeBpsData_UsageDataPerDomain();
				usageDataPerDomain.DomainName = _ctx.StringValue("DescribeHlsLiveStreamRealTimeBpsData.UsageData["+ i +"].DomainName");

				List<DescribeHlsLiveStreamRealTimeBpsDataResponse.DescribeHlsLiveStreamRealTimeBpsData_UsageDataPerDomain.DescribeHlsLiveStreamRealTimeBpsData_StreamInfo> usageDataPerDomain_streamInfos = new List<DescribeHlsLiveStreamRealTimeBpsDataResponse.DescribeHlsLiveStreamRealTimeBpsData_UsageDataPerDomain.DescribeHlsLiveStreamRealTimeBpsData_StreamInfo>();
				for (int j = 0; j < _ctx.Length("DescribeHlsLiveStreamRealTimeBpsData.UsageData["+ i +"].StreamInfos.Length"); j++) {
					DescribeHlsLiveStreamRealTimeBpsDataResponse.DescribeHlsLiveStreamRealTimeBpsData_UsageDataPerDomain.DescribeHlsLiveStreamRealTimeBpsData_StreamInfo streamInfo = new DescribeHlsLiveStreamRealTimeBpsDataResponse.DescribeHlsLiveStreamRealTimeBpsData_UsageDataPerDomain.DescribeHlsLiveStreamRealTimeBpsData_StreamInfo();
					streamInfo.StreamName = _ctx.StringValue("DescribeHlsLiveStreamRealTimeBpsData.UsageData["+ i +"].StreamInfos["+ j +"].StreamName");

					List<DescribeHlsLiveStreamRealTimeBpsDataResponse.DescribeHlsLiveStreamRealTimeBpsData_UsageDataPerDomain.DescribeHlsLiveStreamRealTimeBpsData_StreamInfo.DescribeHlsLiveStreamRealTimeBpsData_Info> streamInfo_infos = new List<DescribeHlsLiveStreamRealTimeBpsDataResponse.DescribeHlsLiveStreamRealTimeBpsData_UsageDataPerDomain.DescribeHlsLiveStreamRealTimeBpsData_StreamInfo.DescribeHlsLiveStreamRealTimeBpsData_Info>();
					for (int k = 0; k < _ctx.Length("DescribeHlsLiveStreamRealTimeBpsData.UsageData["+ i +"].StreamInfos["+ j +"].Infos.Length"); k++) {
						DescribeHlsLiveStreamRealTimeBpsDataResponse.DescribeHlsLiveStreamRealTimeBpsData_UsageDataPerDomain.DescribeHlsLiveStreamRealTimeBpsData_StreamInfo.DescribeHlsLiveStreamRealTimeBpsData_Info info = new DescribeHlsLiveStreamRealTimeBpsDataResponse.DescribeHlsLiveStreamRealTimeBpsData_UsageDataPerDomain.DescribeHlsLiveStreamRealTimeBpsData_StreamInfo.DescribeHlsLiveStreamRealTimeBpsData_Info();
						info.DownFlow = _ctx.FloatValue("DescribeHlsLiveStreamRealTimeBpsData.UsageData["+ i +"].StreamInfos["+ j +"].Infos["+ k +"].DownFlow");
						info.Rate = _ctx.StringValue("DescribeHlsLiveStreamRealTimeBpsData.UsageData["+ i +"].StreamInfos["+ j +"].Infos["+ k +"].Rate");
						info.Online = _ctx.FloatValue("DescribeHlsLiveStreamRealTimeBpsData.UsageData["+ i +"].StreamInfos["+ j +"].Infos["+ k +"].Online");

						streamInfo_infos.Add(info);
					}
					streamInfo.Infos = streamInfo_infos;

					usageDataPerDomain_streamInfos.Add(streamInfo);
				}
				usageDataPerDomain.StreamInfos = usageDataPerDomain_streamInfos;

				describeHlsLiveStreamRealTimeBpsDataResponse_usageData.Add(usageDataPerDomain);
			}
			describeHlsLiveStreamRealTimeBpsDataResponse.UsageData = describeHlsLiveStreamRealTimeBpsDataResponse_usageData;
        
			return describeHlsLiveStreamRealTimeBpsDataResponse;
        }
    }
}
