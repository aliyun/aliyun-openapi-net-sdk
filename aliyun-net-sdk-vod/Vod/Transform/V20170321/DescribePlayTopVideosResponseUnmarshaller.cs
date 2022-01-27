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
    public class DescribePlayTopVideosResponseUnmarshaller
    {
        public static DescribePlayTopVideosResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePlayTopVideosResponse describePlayTopVideosResponse = new DescribePlayTopVideosResponse();

			describePlayTopVideosResponse.HttpResponse = _ctx.HttpResponse;
			describePlayTopVideosResponse.RequestId = _ctx.StringValue("DescribePlayTopVideos.RequestId");
			describePlayTopVideosResponse.PageNo = _ctx.LongValue("DescribePlayTopVideos.PageNo");
			describePlayTopVideosResponse.PageSize = _ctx.LongValue("DescribePlayTopVideos.PageSize");
			describePlayTopVideosResponse.TotalNum = _ctx.LongValue("DescribePlayTopVideos.TotalNum");

			List<DescribePlayTopVideosResponse.DescribePlayTopVideos_TopPlayVideoStatis> describePlayTopVideosResponse_topPlayVideos = new List<DescribePlayTopVideosResponse.DescribePlayTopVideos_TopPlayVideoStatis>();
			for (int i = 0; i < _ctx.Length("DescribePlayTopVideos.TopPlayVideos.Length"); i++) {
				DescribePlayTopVideosResponse.DescribePlayTopVideos_TopPlayVideoStatis topPlayVideoStatis = new DescribePlayTopVideosResponse.DescribePlayTopVideos_TopPlayVideoStatis();
				topPlayVideoStatis.PlayDuration = _ctx.StringValue("DescribePlayTopVideos.TopPlayVideos["+ i +"].PlayDuration");
				topPlayVideoStatis.VV = _ctx.StringValue("DescribePlayTopVideos.TopPlayVideos["+ i +"].VV");
				topPlayVideoStatis.UV = _ctx.StringValue("DescribePlayTopVideos.TopPlayVideos["+ i +"].UV");
				topPlayVideoStatis.VideoId = _ctx.StringValue("DescribePlayTopVideos.TopPlayVideos["+ i +"].VideoId");
				topPlayVideoStatis.Title = _ctx.StringValue("DescribePlayTopVideos.TopPlayVideos["+ i +"].Title");

				describePlayTopVideosResponse_topPlayVideos.Add(topPlayVideoStatis);
			}
			describePlayTopVideosResponse.TopPlayVideos = describePlayTopVideosResponse_topPlayVideos;
        
			return describePlayTopVideosResponse;
        }
    }
}
