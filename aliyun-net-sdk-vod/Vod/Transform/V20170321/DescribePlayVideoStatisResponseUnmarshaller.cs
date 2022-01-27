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
    public class DescribePlayVideoStatisResponseUnmarshaller
    {
        public static DescribePlayVideoStatisResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePlayVideoStatisResponse describePlayVideoStatisResponse = new DescribePlayVideoStatisResponse();

			describePlayVideoStatisResponse.HttpResponse = _ctx.HttpResponse;
			describePlayVideoStatisResponse.RequestId = _ctx.StringValue("DescribePlayVideoStatis.RequestId");

			List<DescribePlayVideoStatisResponse.DescribePlayVideoStatis_VideoPlayStatisDetail> describePlayVideoStatisResponse_videoPlayStatisDetails = new List<DescribePlayVideoStatisResponse.DescribePlayVideoStatis_VideoPlayStatisDetail>();
			for (int i = 0; i < _ctx.Length("DescribePlayVideoStatis.VideoPlayStatisDetails.Length"); i++) {
				DescribePlayVideoStatisResponse.DescribePlayVideoStatis_VideoPlayStatisDetail videoPlayStatisDetail = new DescribePlayVideoStatisResponse.DescribePlayVideoStatis_VideoPlayStatisDetail();
				videoPlayStatisDetail.Date = _ctx.StringValue("DescribePlayVideoStatis.VideoPlayStatisDetails["+ i +"].Date");
				videoPlayStatisDetail.PlayDuration = _ctx.StringValue("DescribePlayVideoStatis.VideoPlayStatisDetails["+ i +"].PlayDuration");
				videoPlayStatisDetail.VV = _ctx.StringValue("DescribePlayVideoStatis.VideoPlayStatisDetails["+ i +"].VV");
				videoPlayStatisDetail.UV = _ctx.StringValue("DescribePlayVideoStatis.VideoPlayStatisDetails["+ i +"].UV");
				videoPlayStatisDetail.PlayRange = _ctx.StringValue("DescribePlayVideoStatis.VideoPlayStatisDetails["+ i +"].PlayRange");
				videoPlayStatisDetail.Title = _ctx.StringValue("DescribePlayVideoStatis.VideoPlayStatisDetails["+ i +"].Title");

				describePlayVideoStatisResponse_videoPlayStatisDetails.Add(videoPlayStatisDetail);
			}
			describePlayVideoStatisResponse.VideoPlayStatisDetails = describePlayVideoStatisResponse_videoPlayStatisDetails;
        
			return describePlayVideoStatisResponse;
        }
    }
}
