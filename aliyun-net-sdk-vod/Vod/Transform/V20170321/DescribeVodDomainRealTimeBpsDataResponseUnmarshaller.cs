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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodDomainRealTimeBpsDataResponseUnmarshaller
    {
        public static DescribeVodDomainRealTimeBpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainRealTimeBpsDataResponse describeVodDomainRealTimeBpsDataResponse = new DescribeVodDomainRealTimeBpsDataResponse();

			describeVodDomainRealTimeBpsDataResponse.HttpResponse = context.HttpResponse;
			describeVodDomainRealTimeBpsDataResponse.RequestId = context.StringValue("DescribeVodDomainRealTimeBpsData.RequestId");

			List<DescribeVodDomainRealTimeBpsDataResponse.DescribeVodDomainRealTimeBpsData_BpsModel> describeVodDomainRealTimeBpsDataResponse_data = new List<DescribeVodDomainRealTimeBpsDataResponse.DescribeVodDomainRealTimeBpsData_BpsModel>();
			for (int i = 0; i < context.Length("DescribeVodDomainRealTimeBpsData.Data.Length"); i++) {
				DescribeVodDomainRealTimeBpsDataResponse.DescribeVodDomainRealTimeBpsData_BpsModel bpsModel = new DescribeVodDomainRealTimeBpsDataResponse.DescribeVodDomainRealTimeBpsData_BpsModel();
				bpsModel.Bps = context.FloatValue("DescribeVodDomainRealTimeBpsData.Data["+ i +"].Bps");
				bpsModel.TimeStamp = context.StringValue("DescribeVodDomainRealTimeBpsData.Data["+ i +"].TimeStamp");

				describeVodDomainRealTimeBpsDataResponse_data.Add(bpsModel);
			}
			describeVodDomainRealTimeBpsDataResponse.Data = describeVodDomainRealTimeBpsDataResponse_data;
        
			return describeVodDomainRealTimeBpsDataResponse;
        }
    }
}