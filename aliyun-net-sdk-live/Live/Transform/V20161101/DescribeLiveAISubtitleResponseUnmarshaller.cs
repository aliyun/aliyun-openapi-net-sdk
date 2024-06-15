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
    public class DescribeLiveAISubtitleResponseUnmarshaller
    {
        public static DescribeLiveAISubtitleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveAISubtitleResponse describeLiveAISubtitleResponse = new DescribeLiveAISubtitleResponse();

			describeLiveAISubtitleResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveAISubtitleResponse.RequestId = _ctx.StringValue("DescribeLiveAISubtitle.RequestId");

			List<DescribeLiveAISubtitleResponse.DescribeLiveAISubtitle_SubtitleConfig> describeLiveAISubtitleResponse_subtitleConfigs = new List<DescribeLiveAISubtitleResponse.DescribeLiveAISubtitle_SubtitleConfig>();
			for (int i = 0; i < _ctx.Length("DescribeLiveAISubtitle.SubtitleConfigs.Length"); i++) {
				DescribeLiveAISubtitleResponse.DescribeLiveAISubtitle_SubtitleConfig subtitleConfig = new DescribeLiveAISubtitleResponse.DescribeLiveAISubtitle_SubtitleConfig();
				subtitleConfig.DstLanguage = _ctx.StringValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].DstLanguage");
				subtitleConfig.SrcLanguage = _ctx.StringValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].SrcLanguage");
				subtitleConfig.FontColor = _ctx.StringValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].FontColor");
				subtitleConfig.FontName = _ctx.StringValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].FontName");
				subtitleConfig.ShowSourceLan = _ctx.IntegerValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].ShowSourceLan");
				subtitleConfig.MaxLines = _ctx.IntegerValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].MaxLines");
				subtitleConfig.WordPerline = _ctx.IntegerValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].WordPerline");
				subtitleConfig.BgColor = _ctx.StringValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].BgColor");
				subtitleConfig.BgWidthNormalized = _ctx.FloatValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].BgWidthNormalized");
				subtitleConfig.BorderWidthNormalized = _ctx.FloatValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].BorderWidthNormalized");
				subtitleConfig.Width = _ctx.StringValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].Width");
				subtitleConfig.Height = _ctx.StringValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].Height");
				subtitleConfig.SubtitleName = _ctx.StringValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].SubtitleName");
				subtitleConfig.SubtitleId = _ctx.StringValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].SubtitleId");
				subtitleConfig.FontSizeNormalized = _ctx.StringValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].FontSizeNormalized");
				subtitleConfig.Description = _ctx.StringValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].Description");

				List<string> subtitleConfig_positionNormalized = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].PositionNormalized.Length"); j++) {
					subtitleConfig_positionNormalized.Add(_ctx.StringValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].PositionNormalized["+ j +"]"));
				}
				subtitleConfig.PositionNormalized = subtitleConfig_positionNormalized;

				List<string> subtitleConfig_rulesRefer = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].RulesRefer.Length"); j++) {
					subtitleConfig_rulesRefer.Add(_ctx.StringValue("DescribeLiveAISubtitle.SubtitleConfigs["+ i +"].RulesRefer["+ j +"]"));
				}
				subtitleConfig.RulesRefer = subtitleConfig_rulesRefer;

				describeLiveAISubtitleResponse_subtitleConfigs.Add(subtitleConfig);
			}
			describeLiveAISubtitleResponse.SubtitleConfigs = describeLiveAISubtitleResponse_subtitleConfigs;
        
			return describeLiveAISubtitleResponse;
        }
    }
}
