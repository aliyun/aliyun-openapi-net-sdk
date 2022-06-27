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
    public class DescribeCasterLayoutsResponseUnmarshaller
    {
        public static DescribeCasterLayoutsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCasterLayoutsResponse describeCasterLayoutsResponse = new DescribeCasterLayoutsResponse();

			describeCasterLayoutsResponse.HttpResponse = _ctx.HttpResponse;
			describeCasterLayoutsResponse.RequestId = _ctx.StringValue("DescribeCasterLayouts.RequestId");
			describeCasterLayoutsResponse.Total = _ctx.IntegerValue("DescribeCasterLayouts.Total");

			List<DescribeCasterLayoutsResponse.DescribeCasterLayouts_Layout> describeCasterLayoutsResponse_layouts = new List<DescribeCasterLayoutsResponse.DescribeCasterLayouts_Layout>();
			for (int i = 0; i < _ctx.Length("DescribeCasterLayouts.Layouts.Length"); i++) {
				DescribeCasterLayoutsResponse.DescribeCasterLayouts_Layout layout = new DescribeCasterLayoutsResponse.DescribeCasterLayouts_Layout();
				layout.LayoutId = _ctx.StringValue("DescribeCasterLayouts.Layouts["+ i +"].LayoutId");

				List<string> layout_blendList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCasterLayouts.Layouts["+ i +"].BlendList.Length"); j++) {
					layout_blendList.Add(_ctx.StringValue("DescribeCasterLayouts.Layouts["+ i +"].BlendList["+ j +"]"));
				}
				layout.BlendList = layout_blendList;

				List<string> layout_mixList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCasterLayouts.Layouts["+ i +"].MixList.Length"); j++) {
					layout_mixList.Add(_ctx.StringValue("DescribeCasterLayouts.Layouts["+ i +"].MixList["+ j +"]"));
				}
				layout.MixList = layout_mixList;

				List<DescribeCasterLayoutsResponse.DescribeCasterLayouts_Layout.DescribeCasterLayouts_VideoLayer> layout_videoLayers = new List<DescribeCasterLayoutsResponse.DescribeCasterLayouts_Layout.DescribeCasterLayouts_VideoLayer>();
				for (int j = 0; j < _ctx.Length("DescribeCasterLayouts.Layouts["+ i +"].VideoLayers.Length"); j++) {
					DescribeCasterLayoutsResponse.DescribeCasterLayouts_Layout.DescribeCasterLayouts_VideoLayer videoLayer = new DescribeCasterLayoutsResponse.DescribeCasterLayouts_Layout.DescribeCasterLayouts_VideoLayer();
					videoLayer.FillMode = _ctx.StringValue("DescribeCasterLayouts.Layouts["+ i +"].VideoLayers["+ j +"].FillMode");
					videoLayer.HeightNormalized = _ctx.FloatValue("DescribeCasterLayouts.Layouts["+ i +"].VideoLayers["+ j +"].HeightNormalized");
					videoLayer.WidthNormalized = _ctx.FloatValue("DescribeCasterLayouts.Layouts["+ i +"].VideoLayers["+ j +"].WidthNormalized");
					videoLayer.PositionRefer = _ctx.StringValue("DescribeCasterLayouts.Layouts["+ i +"].VideoLayers["+ j +"].PositionRefer");
					videoLayer.FixedDelayDuration = _ctx.IntegerValue("DescribeCasterLayouts.Layouts["+ i +"].VideoLayers["+ j +"].FixedDelayDuration");

					List<string> videoLayer_positionNormalizeds = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeCasterLayouts.Layouts["+ i +"].VideoLayers["+ j +"].PositionNormalizeds.Length"); k++) {
						videoLayer_positionNormalizeds.Add(_ctx.StringValue("DescribeCasterLayouts.Layouts["+ i +"].VideoLayers["+ j +"].PositionNormalizeds["+ k +"]"));
					}
					videoLayer.PositionNormalizeds = videoLayer_positionNormalizeds;

					layout_videoLayers.Add(videoLayer);
				}
				layout.VideoLayers = layout_videoLayers;

				List<DescribeCasterLayoutsResponse.DescribeCasterLayouts_Layout.DescribeCasterLayouts_AudioLayer> layout_audioLayers = new List<DescribeCasterLayoutsResponse.DescribeCasterLayouts_Layout.DescribeCasterLayouts_AudioLayer>();
				for (int j = 0; j < _ctx.Length("DescribeCasterLayouts.Layouts["+ i +"].AudioLayers.Length"); j++) {
					DescribeCasterLayoutsResponse.DescribeCasterLayouts_Layout.DescribeCasterLayouts_AudioLayer audioLayer = new DescribeCasterLayoutsResponse.DescribeCasterLayouts_Layout.DescribeCasterLayouts_AudioLayer();
					audioLayer.VolumeRate = _ctx.FloatValue("DescribeCasterLayouts.Layouts["+ i +"].AudioLayers["+ j +"].VolumeRate");
					audioLayer.ValidChannel = _ctx.StringValue("DescribeCasterLayouts.Layouts["+ i +"].AudioLayers["+ j +"].ValidChannel");
					audioLayer.FixedDelayDuration = _ctx.IntegerValue("DescribeCasterLayouts.Layouts["+ i +"].AudioLayers["+ j +"].FixedDelayDuration");

					layout_audioLayers.Add(audioLayer);
				}
				layout.AudioLayers = layout_audioLayers;

				describeCasterLayoutsResponse_layouts.Add(layout);
			}
			describeCasterLayoutsResponse.Layouts = describeCasterLayoutsResponse_layouts;
        
			return describeCasterLayoutsResponse;
        }
    }
}
