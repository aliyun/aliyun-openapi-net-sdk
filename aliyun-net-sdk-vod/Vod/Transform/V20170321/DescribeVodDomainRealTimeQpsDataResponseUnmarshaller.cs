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
    public class DescribeVodDomainRealTimeQpsDataResponseUnmarshaller
    {
        public static DescribeVodDomainRealTimeQpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodDomainRealTimeQpsDataResponse describeVodDomainRealTimeQpsDataResponse = new DescribeVodDomainRealTimeQpsDataResponse();

			describeVodDomainRealTimeQpsDataResponse.HttpResponse = context.HttpResponse;
			describeVodDomainRealTimeQpsDataResponse.RequestId = context.StringValue("DescribeVodDomainRealTimeQpsData.RequestId");

			List<DescribeVodDomainRealTimeQpsDataResponse.DescribeVodDomainRealTimeQpsData_QpsModel> describeVodDomainRealTimeQpsDataResponse_data = new List<DescribeVodDomainRealTimeQpsDataResponse.DescribeVodDomainRealTimeQpsData_QpsModel>();
			for (int i = 0; i < context.Length("DescribeVodDomainRealTimeQpsData.Data.Length"); i++) {
				DescribeVodDomainRealTimeQpsDataResponse.DescribeVodDomainRealTimeQpsData_QpsModel qpsModel = new DescribeVodDomainRealTimeQpsDataResponse.DescribeVodDomainRealTimeQpsData_QpsModel();
				qpsModel.Qps = context.FloatValue("DescribeVodDomainRealTimeQpsData.Data["+ i +"].Qps");
				qpsModel.TimeStamp = context.StringValue("DescribeVodDomainRealTimeQpsData.Data["+ i +"].TimeStamp");

				describeVodDomainRealTimeQpsDataResponse_data.Add(qpsModel);
			}
			describeVodDomainRealTimeQpsDataResponse.Data = describeVodDomainRealTimeQpsDataResponse_data;
        
			return describeVodDomainRealTimeQpsDataResponse;
        }
    }
}