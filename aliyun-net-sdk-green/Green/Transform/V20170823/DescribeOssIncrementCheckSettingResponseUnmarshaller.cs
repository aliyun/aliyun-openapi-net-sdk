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
			describeOssIncrementCheckSettingResponse.RequestId = _ctx.StringValue("DescribeOssIncrementCheckSetting.RequestId");
			describeOssIncrementCheckSettingResponse.ImageEnableLimit = _ctx.BooleanValue("DescribeOssIncrementCheckSetting.ImageEnableLimit");
			describeOssIncrementCheckSettingResponse.ImageScanLimit = _ctx.LongValue("DescribeOssIncrementCheckSetting.ImageScanLimit");
			describeOssIncrementCheckSettingResponse.VideoFrameInterval = _ctx.IntegerValue("DescribeOssIncrementCheckSetting.VideoFrameInterval");
			describeOssIncrementCheckSettingResponse.VideoMaxFrames = _ctx.IntegerValue("DescribeOssIncrementCheckSetting.VideoMaxFrames");
			describeOssIncrementCheckSettingResponse.VideoMaxSize = _ctx.IntegerValue("DescribeOssIncrementCheckSetting.VideoMaxSize");
			describeOssIncrementCheckSettingResponse.AutoFreezeType = _ctx.StringValue("DescribeOssIncrementCheckSetting.AutoFreezeType");
			describeOssIncrementCheckSettingResponse.CallbackId = _ctx.StringValue("DescribeOssIncrementCheckSetting.CallbackId");
			describeOssIncrementCheckSettingResponse.CallbackName = _ctx.StringValue("DescribeOssIncrementCheckSetting.CallbackName");

			List<string> describeOssIncrementCheckSettingResponse_imageSceneList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.ImageSceneList.Length"); i++) {
				describeOssIncrementCheckSettingResponse_imageSceneList.Add(_ctx.StringValue("DescribeOssIncrementCheckSetting.ImageSceneList["+ i +"]"));
			}
			describeOssIncrementCheckSettingResponse.ImageSceneList = describeOssIncrementCheckSettingResponse_imageSceneList;

			List<string> describeOssIncrementCheckSettingResponse_videoSceneList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.VideoSceneList.Length"); i++) {
				describeOssIncrementCheckSettingResponse_videoSceneList.Add(_ctx.StringValue("DescribeOssIncrementCheckSetting.VideoSceneList["+ i +"]"));
			}
			describeOssIncrementCheckSettingResponse.VideoSceneList = describeOssIncrementCheckSettingResponse_videoSceneList;

			List<string> describeOssIncrementCheckSettingResponse_videoAutoFreezeSceneList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.VideoAutoFreezeSceneList.Length"); i++) {
				describeOssIncrementCheckSettingResponse_videoAutoFreezeSceneList.Add(_ctx.StringValue("DescribeOssIncrementCheckSetting.VideoAutoFreezeSceneList["+ i +"]"));
			}
			describeOssIncrementCheckSettingResponse.VideoAutoFreezeSceneList = describeOssIncrementCheckSettingResponse_videoAutoFreezeSceneList;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_ImageAutoFreeze imageAutoFreeze = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_ImageAutoFreeze();
			imageAutoFreeze.Enabled = _ctx.BooleanValue("DescribeOssIncrementCheckSetting.ImageAutoFreeze.Enabled");
			imageAutoFreeze.Porn = _ctx.StringValue("DescribeOssIncrementCheckSetting.ImageAutoFreeze.Porn");
			imageAutoFreeze.Terrorism = _ctx.StringValue("DescribeOssIncrementCheckSetting.ImageAutoFreeze.Terrorism");
			imageAutoFreeze.Ad = _ctx.StringValue("DescribeOssIncrementCheckSetting.ImageAutoFreeze.Ad");
			imageAutoFreeze.Live = _ctx.StringValue("DescribeOssIncrementCheckSetting.ImageAutoFreeze.Live");
			describeOssIncrementCheckSettingResponse.ImageAutoFreeze = imageAutoFreeze;

			List<DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BucketConfig> describeOssIncrementCheckSettingResponse_bucketConfigList = new List<DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BucketConfig>();
			for (int i = 0; i < _ctx.Length("DescribeOssIncrementCheckSetting.BucketConfigList.Length"); i++) {
				DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BucketConfig bucketConfig = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BucketConfig();
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
