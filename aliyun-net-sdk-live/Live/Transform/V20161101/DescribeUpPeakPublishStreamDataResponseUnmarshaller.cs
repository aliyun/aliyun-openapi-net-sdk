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
    public class DescribeUpPeakPublishStreamDataResponseUnmarshaller
    {
        public static DescribeUpPeakPublishStreamDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUpPeakPublishStreamDataResponse describeUpPeakPublishStreamDataResponse = new DescribeUpPeakPublishStreamDataResponse();

			describeUpPeakPublishStreamDataResponse.HttpResponse = context.HttpResponse;
			describeUpPeakPublishStreamDataResponse.RequestId = context.StringValue("DescribeUpPeakPublishStreamData.RequestId");

			List<DescribeUpPeakPublishStreamDataResponse.DescribeUpPeakPublishStreamData_DescribeUpPeakPublishStreamData> describeUpPeakPublishStreamDataResponse_describeUpPeakPublishStreamDatas = new List<DescribeUpPeakPublishStreamDataResponse.DescribeUpPeakPublishStreamData_DescribeUpPeakPublishStreamData>();
			for (int i = 0; i < context.Length("DescribeUpPeakPublishStreamData.DescribeUpPeakPublishStreamDatas.Length"); i++) {
				DescribeUpPeakPublishStreamDataResponse.DescribeUpPeakPublishStreamData_DescribeUpPeakPublishStreamData describeUpPeakPublishStreamData = new DescribeUpPeakPublishStreamDataResponse.DescribeUpPeakPublishStreamData_DescribeUpPeakPublishStreamData();
				describeUpPeakPublishStreamData.PublishStreamNum = context.IntegerValue("DescribeUpPeakPublishStreamData.DescribeUpPeakPublishStreamDatas["+ i +"].PublishStreamNum");
				describeUpPeakPublishStreamData.PeakTime = context.StringValue("DescribeUpPeakPublishStreamData.DescribeUpPeakPublishStreamDatas["+ i +"].PeakTime");
				describeUpPeakPublishStreamData.QueryTime = context.StringValue("DescribeUpPeakPublishStreamData.DescribeUpPeakPublishStreamDatas["+ i +"].QueryTime");
				describeUpPeakPublishStreamData.StatName = context.StringValue("DescribeUpPeakPublishStreamData.DescribeUpPeakPublishStreamDatas["+ i +"].StatName");
				describeUpPeakPublishStreamData.BandWidth = context.StringValue("DescribeUpPeakPublishStreamData.DescribeUpPeakPublishStreamDatas["+ i +"].BandWidth");

				describeUpPeakPublishStreamDataResponse_describeUpPeakPublishStreamDatas.Add(describeUpPeakPublishStreamData);
			}
			describeUpPeakPublishStreamDataResponse.DescribeUpPeakPublishStreamDatas = describeUpPeakPublishStreamDataResponse_describeUpPeakPublishStreamDatas;
        
			return describeUpPeakPublishStreamDataResponse;
        }
    }
}
