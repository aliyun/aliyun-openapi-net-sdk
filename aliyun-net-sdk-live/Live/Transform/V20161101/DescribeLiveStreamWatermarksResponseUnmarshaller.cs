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
    public class DescribeLiveStreamWatermarksResponseUnmarshaller
    {
        public static DescribeLiveStreamWatermarksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamWatermarksResponse describeLiveStreamWatermarksResponse = new DescribeLiveStreamWatermarksResponse();

			describeLiveStreamWatermarksResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamWatermarksResponse.Total = _ctx.IntegerValue("DescribeLiveStreamWatermarks.Total");
			describeLiveStreamWatermarksResponse.RequestId = _ctx.StringValue("DescribeLiveStreamWatermarks.RequestId");

			List<DescribeLiveStreamWatermarksResponse.DescribeLiveStreamWatermarks_Watermark> describeLiveStreamWatermarksResponse_watermarkList = new List<DescribeLiveStreamWatermarksResponse.DescribeLiveStreamWatermarks_Watermark>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamWatermarks.WatermarkList.Length"); i++) {
				DescribeLiveStreamWatermarksResponse.DescribeLiveStreamWatermarks_Watermark watermark = new DescribeLiveStreamWatermarksResponse.DescribeLiveStreamWatermarks_Watermark();
				watermark.Type = _ctx.IntegerValue("DescribeLiveStreamWatermarks.WatermarkList["+ i +"].Type");
				watermark.XOffset = _ctx.FloatValue("DescribeLiveStreamWatermarks.WatermarkList["+ i +"].XOffset");
				watermark.RefWidth = _ctx.IntegerValue("DescribeLiveStreamWatermarks.WatermarkList["+ i +"].RefWidth");
				watermark.YOffset = _ctx.FloatValue("DescribeLiveStreamWatermarks.WatermarkList["+ i +"].YOffset");
				watermark.Height = _ctx.IntegerValue("DescribeLiveStreamWatermarks.WatermarkList["+ i +"].Height");
				watermark.RefHeight = _ctx.IntegerValue("DescribeLiveStreamWatermarks.WatermarkList["+ i +"].RefHeight");
				watermark.PictureUrl = _ctx.StringValue("DescribeLiveStreamWatermarks.WatermarkList["+ i +"].PictureUrl");
				watermark.Transparency = _ctx.IntegerValue("DescribeLiveStreamWatermarks.WatermarkList["+ i +"].Transparency");
				watermark.Description = _ctx.StringValue("DescribeLiveStreamWatermarks.WatermarkList["+ i +"].Description");
				watermark.OffsetCorner = _ctx.StringValue("DescribeLiveStreamWatermarks.WatermarkList["+ i +"].OffsetCorner");
				watermark.RuleCount = _ctx.IntegerValue("DescribeLiveStreamWatermarks.WatermarkList["+ i +"].RuleCount");
				watermark.Name = _ctx.StringValue("DescribeLiveStreamWatermarks.WatermarkList["+ i +"].Name");
				watermark.TemplateId = _ctx.StringValue("DescribeLiveStreamWatermarks.WatermarkList["+ i +"].TemplateId");

				describeLiveStreamWatermarksResponse_watermarkList.Add(watermark);
			}
			describeLiveStreamWatermarksResponse.WatermarkList = describeLiveStreamWatermarksResponse_watermarkList;
        
			return describeLiveStreamWatermarksResponse;
        }
    }
}
