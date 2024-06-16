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
    public class DescribeVodMediaPlayDataResponseUnmarshaller
    {
        public static DescribeVodMediaPlayDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodMediaPlayDataResponse describeVodMediaPlayDataResponse = new DescribeVodMediaPlayDataResponse();

			describeVodMediaPlayDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVodMediaPlayDataResponse.RequestId = _ctx.StringValue("DescribeVodMediaPlayData.RequestId");
			describeVodMediaPlayDataResponse.TotalCount = _ctx.LongValue("DescribeVodMediaPlayData.TotalCount");
			describeVodMediaPlayDataResponse.PageNo = _ctx.LongValue("DescribeVodMediaPlayData.PageNo");
			describeVodMediaPlayDataResponse.PageSize = _ctx.LongValue("DescribeVodMediaPlayData.PageSize");

			List<DescribeVodMediaPlayDataResponse.DescribeVodMediaPlayData_Data> describeVodMediaPlayDataResponse_qoeInfoList = new List<DescribeVodMediaPlayDataResponse.DescribeVodMediaPlayData_Data>();
			for (int i = 0; i < _ctx.Length("DescribeVodMediaPlayData.QoeInfoList.Length"); i++) {
				DescribeVodMediaPlayDataResponse.DescribeVodMediaPlayData_Data data = new DescribeVodMediaPlayDataResponse.DescribeVodMediaPlayData_Data();
				data.VideoTitle = _ctx.StringValue("DescribeVodMediaPlayData.QoeInfoList["+ i +"].VideoTitle");
				data.VideoDuration = _ctx.FloatValue("DescribeVodMediaPlayData.QoeInfoList["+ i +"].VideoDuration");
				data.MediaId = _ctx.StringValue("DescribeVodMediaPlayData.QoeInfoList["+ i +"].MediaId");
				data.DAU = _ctx.FloatValue("DescribeVodMediaPlayData.QoeInfoList["+ i +"].DAU");
				data.PlaySuccessVv = _ctx.FloatValue("DescribeVodMediaPlayData.QoeInfoList["+ i +"].PlaySuccessVv");
				data.PlayDurationPerUv = _ctx.FloatValue("DescribeVodMediaPlayData.QoeInfoList["+ i +"].PlayDurationPerUv");
				data.PlayDuration = _ctx.FloatValue("DescribeVodMediaPlayData.QoeInfoList["+ i +"].PlayDuration");
				data.PlayPerVv = _ctx.FloatValue("DescribeVodMediaPlayData.QoeInfoList["+ i +"].PlayPerVv");

				describeVodMediaPlayDataResponse_qoeInfoList.Add(data);
			}
			describeVodMediaPlayDataResponse.QoeInfoList = describeVodMediaPlayDataResponse_qoeInfoList;
        
			return describeVodMediaPlayDataResponse;
        }
    }
}
