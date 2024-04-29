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
    public class DescribeStudioLayoutsResponseUnmarshaller
    {
        public static DescribeStudioLayoutsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStudioLayoutsResponse describeStudioLayoutsResponse = new DescribeStudioLayoutsResponse();

			describeStudioLayoutsResponse.HttpResponse = _ctx.HttpResponse;
			describeStudioLayoutsResponse.RequestId = _ctx.StringValue("DescribeStudioLayouts.RequestId");
			describeStudioLayoutsResponse.Total = _ctx.IntegerValue("DescribeStudioLayouts.Total");

			List<DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout> describeStudioLayoutsResponse_studioLayouts = new List<DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout>();
			for (int i = 0; i < _ctx.Length("DescribeStudioLayouts.StudioLayouts.Length"); i++) {
				DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout studioLayout = new DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout();
				studioLayout.LayoutId = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].LayoutId");
				studioLayout.LayoutName = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].LayoutName");
				studioLayout.LayoutType = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].LayoutType");

				DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_BgImageConfig bgImageConfig = new DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_BgImageConfig();
				bgImageConfig.Id = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].BgImageConfig.Id");
				bgImageConfig.ImageUrl = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].BgImageConfig.ImageUrl");
				bgImageConfig.LocationId = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].BgImageConfig.LocationId");
				bgImageConfig.MaterialId = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].BgImageConfig.MaterialId");
				studioLayout.BgImageConfig = bgImageConfig;

				DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_CommonConfig commonConfig = new DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_CommonConfig();
				commonConfig.ChannelId = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].CommonConfig.ChannelId");
				commonConfig.VideoResourceId = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].CommonConfig.VideoResourceId");
				studioLayout.CommonConfig = commonConfig;

				List<DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_LayerOrderConfig> studioLayout_layerOrderConfigList = new List<DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_LayerOrderConfig>();
				for (int j = 0; j < _ctx.Length("DescribeStudioLayouts.StudioLayouts["+ i +"].LayerOrderConfigList.Length"); j++) {
					DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_LayerOrderConfig layerOrderConfig = new DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_LayerOrderConfig();
					layerOrderConfig.Id = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].LayerOrderConfigList["+ j +"].Id");
					layerOrderConfig.Type = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].LayerOrderConfigList["+ j +"].Type");

					studioLayout_layerOrderConfigList.Add(layerOrderConfig);
				}
				studioLayout.LayerOrderConfigList = studioLayout_layerOrderConfigList;

				List<DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_MediaInputConfig> studioLayout_mediaInputConfigList = new List<DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_MediaInputConfig>();
				for (int j = 0; j < _ctx.Length("DescribeStudioLayouts.StudioLayouts["+ i +"].MediaInputConfigList.Length"); j++) {
					DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_MediaInputConfig mediaInputConfig = new DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_MediaInputConfig();
					mediaInputConfig.ChannelId = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].MediaInputConfigList["+ j +"].ChannelId");
					mediaInputConfig.FillMode = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].MediaInputConfigList["+ j +"].FillMode");
					mediaInputConfig.HeightNormalized = _ctx.FloatValue("DescribeStudioLayouts.StudioLayouts["+ i +"].MediaInputConfigList["+ j +"].HeightNormalized");
					mediaInputConfig.Id = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].MediaInputConfigList["+ j +"].Id");
					mediaInputConfig.ImageMaterialId = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].MediaInputConfigList["+ j +"].ImageMaterialId");
					mediaInputConfig.Index = _ctx.IntegerValue("DescribeStudioLayouts.StudioLayouts["+ i +"].MediaInputConfigList["+ j +"].Index");
					mediaInputConfig.PositionRefer = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].MediaInputConfigList["+ j +"].PositionRefer");
					mediaInputConfig.VideoResourceId = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].MediaInputConfigList["+ j +"].VideoResourceId");
					mediaInputConfig.WidthNormalized = _ctx.FloatValue("DescribeStudioLayouts.StudioLayouts["+ i +"].MediaInputConfigList["+ j +"].WidthNormalized");

					List<string> mediaInputConfig_positionNormalized = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeStudioLayouts.StudioLayouts["+ i +"].MediaInputConfigList["+ j +"].PositionNormalized.Length"); k++) {
						mediaInputConfig_positionNormalized.Add(_ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].MediaInputConfigList["+ j +"].PositionNormalized["+ k +"]"));
					}
					mediaInputConfig.PositionNormalized = mediaInputConfig_positionNormalized;

					studioLayout_mediaInputConfigList.Add(mediaInputConfig);
				}
				studioLayout.MediaInputConfigList = studioLayout_mediaInputConfigList;

				List<DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_ScreenInputConfig> studioLayout_screenInputConfigList = new List<DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_ScreenInputConfig>();
				for (int j = 0; j < _ctx.Length("DescribeStudioLayouts.StudioLayouts["+ i +"].ScreenInputConfigList.Length"); j++) {
					DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_ScreenInputConfig screenInputConfig = new DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_ScreenInputConfig();
					screenInputConfig.ChannelId = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].ScreenInputConfigList["+ j +"].ChannelId");
					screenInputConfig.Color = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].ScreenInputConfigList["+ j +"].Color");
					screenInputConfig.HeightNormalized = _ctx.FloatValue("DescribeStudioLayouts.StudioLayouts["+ i +"].ScreenInputConfigList["+ j +"].HeightNormalized");
					screenInputConfig.Id = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].ScreenInputConfigList["+ j +"].Id");
					screenInputConfig.Index = _ctx.IntegerValue("DescribeStudioLayouts.StudioLayouts["+ i +"].ScreenInputConfigList["+ j +"].Index");
					screenInputConfig.OnlyAudio = _ctx.BooleanValue("DescribeStudioLayouts.StudioLayouts["+ i +"].ScreenInputConfigList["+ j +"].OnlyAudio");
					screenInputConfig.PortraitType = _ctx.IntegerValue("DescribeStudioLayouts.StudioLayouts["+ i +"].ScreenInputConfigList["+ j +"].PortraitType");
					screenInputConfig.PositionX = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].ScreenInputConfigList["+ j +"].PositionX");
					screenInputConfig.PositionY = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].ScreenInputConfigList["+ j +"].PositionY");
					screenInputConfig.VideoResourceId = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].ScreenInputConfigList["+ j +"].VideoResourceId");

					DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_ScreenInputConfig.DescribeStudioLayouts_AudioConfig audioConfig = new DescribeStudioLayoutsResponse.DescribeStudioLayouts_StudioLayout.DescribeStudioLayouts_ScreenInputConfig.DescribeStudioLayouts_AudioConfig();
					audioConfig.ValidChannel = _ctx.StringValue("DescribeStudioLayouts.StudioLayouts["+ i +"].ScreenInputConfigList["+ j +"].AudioConfig.ValidChannel");
					audioConfig.VolumeRate = _ctx.FloatValue("DescribeStudioLayouts.StudioLayouts["+ i +"].ScreenInputConfigList["+ j +"].AudioConfig.VolumeRate");
					screenInputConfig.AudioConfig = audioConfig;

					studioLayout_screenInputConfigList.Add(screenInputConfig);
				}
				studioLayout.ScreenInputConfigList = studioLayout_screenInputConfigList;

				describeStudioLayoutsResponse_studioLayouts.Add(studioLayout);
			}
			describeStudioLayoutsResponse.StudioLayouts = describeStudioLayoutsResponse_studioLayouts;
        
			return describeStudioLayoutsResponse;
        }
    }
}
