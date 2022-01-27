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
    public class DescribeUpBpsPeakDataResponseUnmarshaller
    {
        public static DescribeUpBpsPeakDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUpBpsPeakDataResponse describeUpBpsPeakDataResponse = new DescribeUpBpsPeakDataResponse();

			describeUpBpsPeakDataResponse.HttpResponse = _ctx.HttpResponse;
			describeUpBpsPeakDataResponse.RequestId = _ctx.StringValue("DescribeUpBpsPeakData.RequestId");

			List<DescribeUpBpsPeakDataResponse.DescribeUpBpsPeakData_DescribeUpPeakTraffic> describeUpBpsPeakDataResponse_describeUpPeakTraffics = new List<DescribeUpBpsPeakDataResponse.DescribeUpBpsPeakData_DescribeUpPeakTraffic>();
			for (int i = 0; i < _ctx.Length("DescribeUpBpsPeakData.DescribeUpPeakTraffics.Length"); i++) {
				DescribeUpBpsPeakDataResponse.DescribeUpBpsPeakData_DescribeUpPeakTraffic describeUpPeakTraffic = new DescribeUpBpsPeakDataResponse.DescribeUpBpsPeakData_DescribeUpPeakTraffic();
				describeUpPeakTraffic.PeakTime = _ctx.StringValue("DescribeUpBpsPeakData.DescribeUpPeakTraffics["+ i +"].PeakTime");
				describeUpPeakTraffic.QueryTime = _ctx.StringValue("DescribeUpBpsPeakData.DescribeUpPeakTraffics["+ i +"].QueryTime");
				describeUpPeakTraffic.StatName = _ctx.StringValue("DescribeUpBpsPeakData.DescribeUpPeakTraffics["+ i +"].StatName");
				describeUpPeakTraffic.BandWidth = _ctx.StringValue("DescribeUpBpsPeakData.DescribeUpPeakTraffics["+ i +"].BandWidth");

				describeUpBpsPeakDataResponse_describeUpPeakTraffics.Add(describeUpPeakTraffic);
			}
			describeUpBpsPeakDataResponse.DescribeUpPeakTraffics = describeUpBpsPeakDataResponse_describeUpPeakTraffics;
        
			return describeUpBpsPeakDataResponse;
        }
    }
}
