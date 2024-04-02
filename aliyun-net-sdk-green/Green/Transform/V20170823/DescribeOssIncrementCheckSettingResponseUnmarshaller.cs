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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeOssIncrementCheckSettingResponseUnmarshaller
    {
        public static DescribeOssIncrementCheckSettingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOssIncrementCheckSettingResponse describeOssIncrementCheckSettingResponse = new DescribeOssIncrementCheckSettingResponse();

			describeOssIncrementCheckSettingResponse.HttpResponse = _ctx.HttpResponse;
			describeOssIncrementCheckSettingResponse.CallbackName = _ctx.StringValue("DescribeOssIncrementCheckSetting.CallbackName");
			describeOssIncrementCheckSettingResponse.ImageScanLimit = _ctx.LongValue("DescribeOssIncrementCheckSetting.ImageScanLimit");
			describeOssIncrementCheckSettingResponse.VideoScanLimit = _ctx.LongValue("DescribeOssIncrementCheckSetting.VideoScanLimit");
			describeOssIncrementCheckSettingResponse.AudioAutoFreezeOpened = _ctx.BooleanValue("DescribeOssIncrementCheckSetting.AudioAutoFreezeOpened");
			describeOssIncrementCheckSettingResponse.VideoMaxSize = _ctx.IntegerValue("DescribeOssIncrementCheckSetting.VideoMaxSize");
			describeOssIncrementCheckSettingResponse.ImageEnableLimit = _ctx.BooleanValue("DescribeOssIncrementCheckSetting.ImageEnableLimit");
			describeOssIncrementCheckSettingResponse.BizType = _ctx.StringValue("DescribeOssIncrementCheckSetting.BizType");
			describeOssIncrementCheckSettingResponse.EndTime = _ctx.StringValue("DescribeOssIncrementCheckSetting.EndTime");
			describeOssIncrementCheckSettingResponse.ImageAutoFreezeOpened = _ctx.BooleanValue("DescribeOssIncrementCheckSetting.ImageAutoFreezeOpened");
			describeOssIncrementCheckSettingResponse.VideoMaxFrames = _ctx.IntegerValue("DescribeOssIncrementCheckSetting.VideoMaxFrames");
			describeOssIncrementCheckSettingResponse.StartTime = _ctx.StringValue("DescribeOssIncrementCheckSetting.StartTime");
			describeOssIncrementCheckSettingResponse.CallbackId = _ctx.StringValue("DescribeOssIncrementCheckSetting.CallbackId");
			describeOssIncrementCheckSettingResponse.ScanImageNoFileType = _ctx.BooleanValue("DescribeOssIncrementCheckSetting.ScanImageNoFileType");
			describeOssIncrementCheckSettingResponse.AutoFreezeType = _ctx.StringValue("DescribeOssIncrementCheckSetting.AutoFreezeType");
			describeOssIncrementCheckSettingResponse.RequestId = _ctx.StringValue("DescribeOssIncrementCheckSetting.RequestId");
			describeOssIncrementCheckSettingResponse.VideoAutoFreezeOpened = _ctx.BooleanValue("DescribeOssIncrementCheckSetting.VideoAutoFreezeOpened");
			describeOssIncrementCheckSettingResponse.VideoFrameInterval = _ctx.IntegerValue("DescribeOssIncrementCheckSetting.VideoFrameInterval");
			describeOssIncrementCheckSettingResponse.AudioScanLimit = _ctx.LongValue("DescribeOssIncrementCheckSetting.AudioScanLimit");
			describeOssIncrementCheckSettingResponse.AudioMaxSize = _ctx.IntegerValue("DescribeOssIncrementCheckSetting.AudioMaxSize");

			List<string> describeOssIncrementCheckSettingResponse_audioSceneList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.AudioSceneList.Length"); i++) {
				describeOssIncrementCheckSettingResponse_audioSceneList.Add(_ctx.StringValue("DescribeOssIncrementCheckSetting.AudioSceneList["+ i +"]"));
			}
			describeOssIncrementCheckSettingResponse.AudioSceneList = describeOssIncrementCheckSettingResponse_audioSceneList;

			List<string> describeOssIncrementCheckSettingResponse_videoAutoFreezeSceneList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.VideoAutoFreezeSceneList.Length"); i++) {
				describeOssIncrementCheckSettingResponse_videoAutoFreezeSceneList.Add(_ctx.StringValue("DescribeOssIncrementCheckSetting.VideoAutoFreezeSceneList["+ i +"]"));
			}
			describeOssIncrementCheckSettingResponse.VideoAutoFreezeSceneList = describeOssIncrementCheckSettingResponse_videoAutoFreezeSceneList;

			List<string> describeOssIncrementCheckSettingResponse_videoSceneList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.VideoSceneList.Length"); i++) {
				describeOssIncrementCheckSettingResponse_videoSceneList.Add(_ctx.StringValue("DescribeOssIncrementCheckSetting.VideoSceneList["+ i +"]"));
			}
			describeOssIncrementCheckSettingResponse.VideoSceneList = describeOssIncrementCheckSettingResponse_videoSceneList;

			List<string> describeOssIncrementCheckSettingResponse_imageSceneList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.ImageSceneList.Length"); i++) {
				describeOssIncrementCheckSettingResponse_imageSceneList.Add(_ctx.StringValue("DescribeOssIncrementCheckSetting.ImageSceneList["+ i +"]"));
			}
			describeOssIncrementCheckSettingResponse.ImageSceneList = describeOssIncrementCheckSettingResponse_imageSceneList;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_ImageAutoFreeze imageAutoFreeze = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_ImageAutoFreeze();
			imageAutoFreeze.Live = _ctx.StringValue("DescribeOssIncrementCheckSetting.ImageAutoFreeze.Live");
			imageAutoFreeze.Porn = _ctx.StringValue("DescribeOssIncrementCheckSetting.ImageAutoFreeze.Porn");
			imageAutoFreeze.Ad = _ctx.StringValue("DescribeOssIncrementCheckSetting.ImageAutoFreeze.Ad");
			imageAutoFreeze.Terrorism = _ctx.StringValue("DescribeOssIncrementCheckSetting.ImageAutoFreeze.Terrorism");
			imageAutoFreeze.Enabled = _ctx.BooleanValue("DescribeOssIncrementCheckSetting.ImageAutoFreeze.Enabled");
			describeOssIncrementCheckSettingResponse.ImageAutoFreeze = imageAutoFreeze;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_AudioAntispamFreezeConfig audioAntispamFreezeConfig = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_AudioAntispamFreezeConfig();
			audioAntispamFreezeConfig.Type = _ctx.StringValue("DescribeOssIncrementCheckSetting.AudioAntispamFreezeConfig.Type");
			audioAntispamFreezeConfig._Value = _ctx.StringValue("DescribeOssIncrementCheckSetting.AudioAntispamFreezeConfig.Value");
			describeOssIncrementCheckSettingResponse.AudioAntispamFreezeConfig = audioAntispamFreezeConfig;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate bizTypeTemplate = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate();
			bizTypeTemplate.Name = _ctx.StringValue("DescribeOssIncrementCheckSetting.BizTypeTemplate.Name");
			bizTypeTemplate.Description = _ctx.StringValue("DescribeOssIncrementCheckSetting.BizTypeTemplate.Description");
			bizTypeTemplate.BizType = _ctx.StringValue("DescribeOssIncrementCheckSetting.BizTypeTemplate.BizType");
			bizTypeTemplate.IncludeChannel = _ctx.IntegerValue("DescribeOssIncrementCheckSetting.BizTypeTemplate.IncludeChannel");

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_ImageConfig imageConfig = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_ImageConfig();

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_ImageConfig.DescribeOssIncrementCheckSetting_Terrorism terrorism = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_ImageConfig.DescribeOssIncrementCheckSetting_Terrorism();

			List<string> terrorism_categories = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.BizTypeTemplate.ImageConfig.Terrorism.Categories.Length"); i++) {
				terrorism_categories.Add(_ctx.StringValue("DescribeOssIncrementCheckSetting.BizTypeTemplate.ImageConfig.Terrorism.Categories["+ i +"]"));
			}
			terrorism.Categories = terrorism_categories;
			imageConfig.Terrorism = terrorism;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_ImageConfig.DescribeOssIncrementCheckSetting_Porn porn = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_ImageConfig.DescribeOssIncrementCheckSetting_Porn();

			List<string> porn_categories1 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.BizTypeTemplate.ImageConfig.Porn.Categories.Length"); i++) {
				porn_categories1.Add(_ctx.StringValue("DescribeOssIncrementCheckSetting.BizTypeTemplate.ImageConfig.Porn.Categories["+ i +"]"));
			}
			porn.Categories1 = porn_categories1;
			imageConfig.Porn = porn;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_ImageConfig.DescribeOssIncrementCheckSetting_Ad ad = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_ImageConfig.DescribeOssIncrementCheckSetting_Ad();

			List<string> ad_categories2 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.BizTypeTemplate.ImageConfig.Ad.Categories.Length"); i++) {
				ad_categories2.Add(_ctx.StringValue("DescribeOssIncrementCheckSetting.BizTypeTemplate.ImageConfig.Ad.Categories["+ i +"]"));
			}
			ad.Categories2 = ad_categories2;
			imageConfig.Ad = ad;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_ImageConfig.DescribeOssIncrementCheckSetting_Live live = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_ImageConfig.DescribeOssIncrementCheckSetting_Live();

			List<string> live_categories3 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.BizTypeTemplate.ImageConfig.Live.Categories.Length"); i++) {
				live_categories3.Add(_ctx.StringValue("DescribeOssIncrementCheckSetting.BizTypeTemplate.ImageConfig.Live.Categories["+ i +"]"));
			}
			live.Categories3 = live_categories3;
			imageConfig.Live = live;
			bizTypeTemplate.ImageConfig = imageConfig;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_VideoConfig videoConfig = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_VideoConfig();

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_VideoConfig.DescribeOssIncrementCheckSetting_Terrorism4 terrorism4 = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_VideoConfig.DescribeOssIncrementCheckSetting_Terrorism4();

			List<string> terrorism4_categories8 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.BizTypeTemplate.VideoConfig.Terrorism.Categories.Length"); i++) {
				terrorism4_categories8.Add(_ctx.StringValue("DescribeOssIncrementCheckSetting.BizTypeTemplate.VideoConfig.Terrorism.Categories["+ i +"]"));
			}
			terrorism4.Categories8 = terrorism4_categories8;
			videoConfig.Terrorism4 = terrorism4;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_VideoConfig.DescribeOssIncrementCheckSetting_Porn5 porn5 = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_VideoConfig.DescribeOssIncrementCheckSetting_Porn5();

			List<string> porn5_categories9 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.BizTypeTemplate.VideoConfig.Porn.Categories.Length"); i++) {
				porn5_categories9.Add(_ctx.StringValue("DescribeOssIncrementCheckSetting.BizTypeTemplate.VideoConfig.Porn.Categories["+ i +"]"));
			}
			porn5.Categories9 = porn5_categories9;
			videoConfig.Porn5 = porn5;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_VideoConfig.DescribeOssIncrementCheckSetting_Ad6 ad6 = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_VideoConfig.DescribeOssIncrementCheckSetting_Ad6();

			List<string> ad6_categories10 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.BizTypeTemplate.VideoConfig.Ad.Categories.Length"); i++) {
				ad6_categories10.Add(_ctx.StringValue("DescribeOssIncrementCheckSetting.BizTypeTemplate.VideoConfig.Ad.Categories["+ i +"]"));
			}
			ad6.Categories10 = ad6_categories10;
			videoConfig.Ad6 = ad6;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_VideoConfig.DescribeOssIncrementCheckSetting_Live7 live7 = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_VideoConfig.DescribeOssIncrementCheckSetting_Live7();

			List<string> live7_categories11 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.BizTypeTemplate.VideoConfig.Live.Categories.Length"); i++) {
				live7_categories11.Add(_ctx.StringValue("DescribeOssIncrementCheckSetting.BizTypeTemplate.VideoConfig.Live.Categories["+ i +"]"));
			}
			live7.Categories11 = live7_categories11;
			videoConfig.Live7 = live7;
			bizTypeTemplate.VideoConfig = videoConfig;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_VoiceConfig voiceConfig = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_VoiceConfig();

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_VoiceConfig.DescribeOssIncrementCheckSetting_Antispam antispam = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BizTypeTemplate.DescribeOssIncrementCheckSetting_VoiceConfig.DescribeOssIncrementCheckSetting_Antispam();

			List<string> antispam_categories12 = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.BizTypeTemplate.VoiceConfig.Antispam.Categories.Length"); i++) {
				antispam_categories12.Add(_ctx.StringValue("DescribeOssIncrementCheckSetting.BizTypeTemplate.VoiceConfig.Antispam.Categories["+ i +"]"));
			}
			antispam.Categories12 = antispam_categories12;
			voiceConfig.Antispam = antispam;
			bizTypeTemplate.VoiceConfig = voiceConfig;
			describeOssIncrementCheckSettingResponse.BizTypeTemplate = bizTypeTemplate;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_ImagePornFreezeConfig imagePornFreezeConfig = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_ImagePornFreezeConfig();
			imagePornFreezeConfig.Type = _ctx.StringValue("DescribeOssIncrementCheckSetting.ImagePornFreezeConfig.Type");
			imagePornFreezeConfig._Value = _ctx.StringValue("DescribeOssIncrementCheckSetting.ImagePornFreezeConfig.Value");
			describeOssIncrementCheckSettingResponse.ImagePornFreezeConfig = imagePornFreezeConfig;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_ImageTerrorismFreezeConfig imageTerrorismFreezeConfig = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_ImageTerrorismFreezeConfig();
			imageTerrorismFreezeConfig.Type = _ctx.StringValue("DescribeOssIncrementCheckSetting.ImageTerrorismFreezeConfig.Type");
			imageTerrorismFreezeConfig._Value = _ctx.StringValue("DescribeOssIncrementCheckSetting.ImageTerrorismFreezeConfig.Value");
			describeOssIncrementCheckSettingResponse.ImageTerrorismFreezeConfig = imageTerrorismFreezeConfig;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_ImageAdFreezeConfig imageAdFreezeConfig = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_ImageAdFreezeConfig();
			imageAdFreezeConfig.Type = _ctx.StringValue("DescribeOssIncrementCheckSetting.ImageAdFreezeConfig.Type");
			imageAdFreezeConfig._Value = _ctx.StringValue("DescribeOssIncrementCheckSetting.ImageAdFreezeConfig.Value");
			describeOssIncrementCheckSettingResponse.ImageAdFreezeConfig = imageAdFreezeConfig;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_ImageLiveFreezeConfig imageLiveFreezeConfig = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_ImageLiveFreezeConfig();
			imageLiveFreezeConfig.Type = _ctx.StringValue("DescribeOssIncrementCheckSetting.ImageLiveFreezeConfig.Type");
			imageLiveFreezeConfig._Value = _ctx.StringValue("DescribeOssIncrementCheckSetting.ImageLiveFreezeConfig.Value");
			describeOssIncrementCheckSettingResponse.ImageLiveFreezeConfig = imageLiveFreezeConfig;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_VideoPornFreezeConfig videoPornFreezeConfig = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_VideoPornFreezeConfig();
			videoPornFreezeConfig.Type = _ctx.StringValue("DescribeOssIncrementCheckSetting.VideoPornFreezeConfig.Type");
			videoPornFreezeConfig._Value = _ctx.StringValue("DescribeOssIncrementCheckSetting.VideoPornFreezeConfig.Value");
			describeOssIncrementCheckSettingResponse.VideoPornFreezeConfig = videoPornFreezeConfig;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_VideoTerrorismFreezeConfig videoTerrorismFreezeConfig = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_VideoTerrorismFreezeConfig();
			videoTerrorismFreezeConfig.Type = _ctx.StringValue("DescribeOssIncrementCheckSetting.VideoTerrorismFreezeConfig.Type");
			videoTerrorismFreezeConfig._Value = _ctx.StringValue("DescribeOssIncrementCheckSetting.VideoTerrorismFreezeConfig.Value");
			describeOssIncrementCheckSettingResponse.VideoTerrorismFreezeConfig = videoTerrorismFreezeConfig;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_VideoAdFreezeConfig videoAdFreezeConfig = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_VideoAdFreezeConfig();
			videoAdFreezeConfig.Type = _ctx.StringValue("DescribeOssIncrementCheckSetting.VideoAdFreezeConfig.Type");
			videoAdFreezeConfig._Value = _ctx.StringValue("DescribeOssIncrementCheckSetting.VideoAdFreezeConfig.Value");
			describeOssIncrementCheckSettingResponse.VideoAdFreezeConfig = videoAdFreezeConfig;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_VideoLiveFreezeConfig videoLiveFreezeConfig = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_VideoLiveFreezeConfig();
			videoLiveFreezeConfig.Type = _ctx.StringValue("DescribeOssIncrementCheckSetting.VideoLiveFreezeConfig.Type");
			videoLiveFreezeConfig._Value = _ctx.StringValue("DescribeOssIncrementCheckSetting.VideoLiveFreezeConfig.Value");
			describeOssIncrementCheckSettingResponse.VideoLiveFreezeConfig = videoLiveFreezeConfig;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_VideoVoiceAntispamFreezeConfig videoVoiceAntispamFreezeConfig = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_VideoVoiceAntispamFreezeConfig();
			videoVoiceAntispamFreezeConfig.Type = _ctx.StringValue("DescribeOssIncrementCheckSetting.VideoVoiceAntispamFreezeConfig.Type");
			videoVoiceAntispamFreezeConfig._Value = _ctx.StringValue("DescribeOssIncrementCheckSetting.VideoVoiceAntispamFreezeConfig.Value");
			describeOssIncrementCheckSettingResponse.VideoVoiceAntispamFreezeConfig = videoVoiceAntispamFreezeConfig;

			List<DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BucketConfig> describeOssIncrementCheckSettingResponse_bucketConfigList = new List<DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BucketConfig>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.BucketConfigList.Length"); i++) {
				DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BucketConfig bucketConfig = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BucketConfig();
				bucketConfig.Type = _ctx.StringValue("DescribeOssIncrementCheckSetting.BucketConfigList["+ i +"].Type");
				bucketConfig.Selected = _ctx.BooleanValue("DescribeOssIncrementCheckSetting.BucketConfigList["+ i +"].Selected");
				bucketConfig.Bucket = _ctx.StringValue("DescribeOssIncrementCheckSetting.BucketConfigList["+ i +"].Bucket");

				List<string> bucketConfig_prefixes = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeOssIncrementCheckSetting.BucketConfigList["+ i +"].Prefixes.Length"); j++) {
					bucketConfig_prefixes.Add(_ctx.StringValue("DescribeOssIncrementCheckSetting.BucketConfigList["+ i +"].Prefixes["+ j +"]"));
				}
				bucketConfig.Prefixes = bucketConfig_prefixes;

				describeOssIncrementCheckSettingResponse_bucketConfigList.Add(bucketConfig);
			}
			describeOssIncrementCheckSettingResponse.BucketConfigList = describeOssIncrementCheckSettingResponse_bucketConfigList;
        
			return describeOssIncrementCheckSettingResponse;
        }
    }
}
