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
    public class DescribeLiveStreamMonitorListResponseUnmarshaller
    {
        public static DescribeLiveStreamMonitorListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamMonitorListResponse describeLiveStreamMonitorListResponse = new DescribeLiveStreamMonitorListResponse();

			describeLiveStreamMonitorListResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamMonitorListResponse.Total = _ctx.IntegerValue("DescribeLiveStreamMonitorList.Total");
			describeLiveStreamMonitorListResponse.RequestId = _ctx.StringValue("DescribeLiveStreamMonitorList.RequestId");

			List<DescribeLiveStreamMonitorListResponse.DescribeLiveStreamMonitorList_LiveStreamMonitorInfo> describeLiveStreamMonitorListResponse_liveStreamMonitorList = new List<DescribeLiveStreamMonitorListResponse.DescribeLiveStreamMonitorList_LiveStreamMonitorInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamMonitorList.LiveStreamMonitorList.Length"); i++) {
				DescribeLiveStreamMonitorListResponse.DescribeLiveStreamMonitorList_LiveStreamMonitorInfo liveStreamMonitorInfo = new DescribeLiveStreamMonitorListResponse.DescribeLiveStreamMonitorList_LiveStreamMonitorInfo();
				liveStreamMonitorInfo.Status = _ctx.IntegerValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].Status");
				liveStreamMonitorInfo.MonitorConfig = _ctx.StringValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].MonitorConfig");
				liveStreamMonitorInfo.StartTime = _ctx.StringValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].StartTime");
				liveStreamMonitorInfo.MonitorId = _ctx.StringValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].MonitorId");
				liveStreamMonitorInfo.Domain = _ctx.StringValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].Domain");
				liveStreamMonitorInfo.OutputTemplate = _ctx.StringValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].OutputTemplate");
				liveStreamMonitorInfo.Region = _ctx.StringValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].Region");
				liveStreamMonitorInfo.AudioFrom = _ctx.IntegerValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].AudioFrom");
				liveStreamMonitorInfo.MonitorName = _ctx.StringValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].MonitorName");
				liveStreamMonitorInfo.StopTime = _ctx.StringValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].StopTime");

				DescribeLiveStreamMonitorListResponse.DescribeLiveStreamMonitorList_LiveStreamMonitorInfo.DescribeLiveStreamMonitorList_OutputUrls outputUrls = new DescribeLiveStreamMonitorListResponse.DescribeLiveStreamMonitorList_LiveStreamMonitorInfo.DescribeLiveStreamMonitorList_OutputUrls();
				outputUrls.FlvUrl = _ctx.StringValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].OutputUrls.FlvUrl");
				outputUrls.RtmpUrl = _ctx.StringValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].OutputUrls.RtmpUrl");
				liveStreamMonitorInfo.OutputUrls = outputUrls;

				List<DescribeLiveStreamMonitorListResponse.DescribeLiveStreamMonitorList_LiveStreamMonitorInfo.DescribeLiveStreamMonitorList_InputConfig> liveStreamMonitorInfo_inputList = new List<DescribeLiveStreamMonitorListResponse.DescribeLiveStreamMonitorList_LiveStreamMonitorInfo.DescribeLiveStreamMonitorList_InputConfig>();
				for (int j = 0; j < _ctx.Length("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].InputList.Length"); j++) {
					DescribeLiveStreamMonitorListResponse.DescribeLiveStreamMonitorList_LiveStreamMonitorInfo.DescribeLiveStreamMonitorList_InputConfig inputConfig = new DescribeLiveStreamMonitorListResponse.DescribeLiveStreamMonitorList_LiveStreamMonitorInfo.DescribeLiveStreamMonitorList_InputConfig();
					inputConfig.Index = _ctx.IntegerValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].InputList["+ j +"].Index");
					inputConfig.InputUrl = _ctx.StringValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].InputList["+ j +"].InputUrl");
					inputConfig.LayoutId = _ctx.IntegerValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].InputList["+ j +"].LayoutId");
					inputConfig.StreamName = _ctx.StringValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].InputList["+ j +"].StreamName");

					DescribeLiveStreamMonitorListResponse.DescribeLiveStreamMonitorList_LiveStreamMonitorInfo.DescribeLiveStreamMonitorList_InputConfig.DescribeLiveStreamMonitorList_LayoutConfig layoutConfig = new DescribeLiveStreamMonitorListResponse.DescribeLiveStreamMonitorList_LiveStreamMonitorInfo.DescribeLiveStreamMonitorList_InputConfig.DescribeLiveStreamMonitorList_LayoutConfig();
					layoutConfig.FillMode = _ctx.StringValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].InputList["+ j +"].LayoutConfig.FillMode");
					layoutConfig.PositionRefer = _ctx.StringValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].InputList["+ j +"].LayoutConfig.PositionRefer");

					List<string> layoutConfig_positionNormalized = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].InputList["+ j +"].LayoutConfig.PositionNormalized.Length"); k++) {
						layoutConfig_positionNormalized.Add(_ctx.StringValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].InputList["+ j +"].LayoutConfig.PositionNormalized["+ k +"]"));
					}
					layoutConfig.PositionNormalized = layoutConfig_positionNormalized;

					List<string> layoutConfig_sizeNormalized = new List<string>();
					for (int k = 0; k < _ctx.Length("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].InputList["+ j +"].LayoutConfig.SizeNormalized.Length"); k++) {
						layoutConfig_sizeNormalized.Add(_ctx.StringValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].InputList["+ j +"].LayoutConfig.SizeNormalized["+ k +"]"));
					}
					layoutConfig.SizeNormalized = layoutConfig_sizeNormalized;
					inputConfig.LayoutConfig = layoutConfig;

					DescribeLiveStreamMonitorListResponse.DescribeLiveStreamMonitorList_LiveStreamMonitorInfo.DescribeLiveStreamMonitorList_InputConfig.DescribeLiveStreamMonitorList_PlayConfig playConfig = new DescribeLiveStreamMonitorListResponse.DescribeLiveStreamMonitorList_LiveStreamMonitorInfo.DescribeLiveStreamMonitorList_InputConfig.DescribeLiveStreamMonitorList_PlayConfig();
					playConfig.VolumeRate = _ctx.FloatValue("DescribeLiveStreamMonitorList.LiveStreamMonitorList["+ i +"].InputList["+ j +"].PlayConfig.VolumeRate");
					inputConfig.PlayConfig = playConfig;

					liveStreamMonitorInfo_inputList.Add(inputConfig);
				}
				liveStreamMonitorInfo.InputList = liveStreamMonitorInfo_inputList;

				describeLiveStreamMonitorListResponse_liveStreamMonitorList.Add(liveStreamMonitorInfo);
			}
			describeLiveStreamMonitorListResponse.LiveStreamMonitorList = describeLiveStreamMonitorListResponse_liveStreamMonitorList;
        
			return describeLiveStreamMonitorListResponse;
        }
    }
}
