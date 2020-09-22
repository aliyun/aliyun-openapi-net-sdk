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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeVsUpPeakPublishStreamDataResponseUnmarshaller
    {
        public static DescribeVsUpPeakPublishStreamDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVsUpPeakPublishStreamDataResponse describeVsUpPeakPublishStreamDataResponse = new DescribeVsUpPeakPublishStreamDataResponse();

			describeVsUpPeakPublishStreamDataResponse.HttpResponse = context.HttpResponse;
			describeVsUpPeakPublishStreamDataResponse.RequestId = context.StringValue("DescribeVsUpPeakPublishStreamData.RequestId");

			List<DescribeVsUpPeakPublishStreamDataResponse.DescribeVsUpPeakPublishStreamData_DescribeVsUpPeakPublishStreamData> describeVsUpPeakPublishStreamDataResponse_describeVsUpPeakPublishStreamDatas = new List<DescribeVsUpPeakPublishStreamDataResponse.DescribeVsUpPeakPublishStreamData_DescribeVsUpPeakPublishStreamData>();
			for (int i = 0; i < context.Length("DescribeVsUpPeakPublishStreamData.DescribeVsUpPeakPublishStreamDatas.Length"); i++) {
				DescribeVsUpPeakPublishStreamDataResponse.DescribeVsUpPeakPublishStreamData_DescribeVsUpPeakPublishStreamData describeVsUpPeakPublishStreamData = new DescribeVsUpPeakPublishStreamDataResponse.DescribeVsUpPeakPublishStreamData_DescribeVsUpPeakPublishStreamData();
				describeVsUpPeakPublishStreamData.PublishStreamNum = context.IntegerValue("DescribeVsUpPeakPublishStreamData.DescribeVsUpPeakPublishStreamDatas["+ i +"].PublishStreamNum");
				describeVsUpPeakPublishStreamData.PeakTime = context.StringValue("DescribeVsUpPeakPublishStreamData.DescribeVsUpPeakPublishStreamDatas["+ i +"].PeakTime");
				describeVsUpPeakPublishStreamData.QueryTime = context.StringValue("DescribeVsUpPeakPublishStreamData.DescribeVsUpPeakPublishStreamDatas["+ i +"].QueryTime");
				describeVsUpPeakPublishStreamData.StatName = context.StringValue("DescribeVsUpPeakPublishStreamData.DescribeVsUpPeakPublishStreamDatas["+ i +"].StatName");
				describeVsUpPeakPublishStreamData.BandWidth = context.StringValue("DescribeVsUpPeakPublishStreamData.DescribeVsUpPeakPublishStreamDatas["+ i +"].BandWidth");

				describeVsUpPeakPublishStreamDataResponse_describeVsUpPeakPublishStreamDatas.Add(describeVsUpPeakPublishStreamData);
			}
			describeVsUpPeakPublishStreamDataResponse.DescribeVsUpPeakPublishStreamDatas = describeVsUpPeakPublishStreamDataResponse_describeVsUpPeakPublishStreamDatas;
        
			return describeVsUpPeakPublishStreamDataResponse;
        }
    }
}
