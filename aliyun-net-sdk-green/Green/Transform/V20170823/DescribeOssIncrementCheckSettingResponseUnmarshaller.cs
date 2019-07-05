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
        public static DescribeOssIncrementCheckSettingResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOssIncrementCheckSettingResponse describeOssIncrementCheckSettingResponse = new DescribeOssIncrementCheckSettingResponse();

			describeOssIncrementCheckSettingResponse.HttpResponse = context.HttpResponse;
			describeOssIncrementCheckSettingResponse.RequestId = context.StringValue("DescribeOssIncrementCheckSetting.RequestId");
			describeOssIncrementCheckSettingResponse.ImageEnableLimit = context.BooleanValue("DescribeOssIncrementCheckSetting.ImageEnableLimit");
			describeOssIncrementCheckSettingResponse.ImageScanLimit = context.LongValue("DescribeOssIncrementCheckSetting.ImageScanLimit");
			describeOssIncrementCheckSettingResponse.VideoFrameInterval = context.IntegerValue("DescribeOssIncrementCheckSetting.VideoFrameInterval");
			describeOssIncrementCheckSettingResponse.VideoMaxFrames = context.IntegerValue("DescribeOssIncrementCheckSetting.VideoMaxFrames");
			describeOssIncrementCheckSettingResponse.VideoMaxSize = context.IntegerValue("DescribeOssIncrementCheckSetting.VideoMaxSize");
			describeOssIncrementCheckSettingResponse.AutoFreezeType = context.StringValue("DescribeOssIncrementCheckSetting.AutoFreezeType");

			List<string> describeOssIncrementCheckSettingResponse_imageSceneList = new List<string>();
			for (int i = 0; i < context.Length("DescribeOssIncrementCheckSetting.ImageSceneList.Length"); i++) {
				describeOssIncrementCheckSettingResponse_imageSceneList.Add(context.StringValue("DescribeOssIncrementCheckSetting.ImageSceneList["+ i +"]"));
			}
			describeOssIncrementCheckSettingResponse.ImageSceneList = describeOssIncrementCheckSettingResponse_imageSceneList;

			List<string> describeOssIncrementCheckSettingResponse_videoSceneList = new List<string>();
			for (int i = 0; i < context.Length("DescribeOssIncrementCheckSetting.VideoSceneList.Length"); i++) {
				describeOssIncrementCheckSettingResponse_videoSceneList.Add(context.StringValue("DescribeOssIncrementCheckSetting.VideoSceneList["+ i +"]"));
			}
			describeOssIncrementCheckSettingResponse.VideoSceneList = describeOssIncrementCheckSettingResponse_videoSceneList;

			List<string> describeOssIncrementCheckSettingResponse_videoAutoFreezeSceneList = new List<string>();
			for (int i = 0; i < context.Length("DescribeOssIncrementCheckSetting.VideoAutoFreezeSceneList.Length"); i++) {
				describeOssIncrementCheckSettingResponse_videoAutoFreezeSceneList.Add(context.StringValue("DescribeOssIncrementCheckSetting.VideoAutoFreezeSceneList["+ i +"]"));
			}
			describeOssIncrementCheckSettingResponse.VideoAutoFreezeSceneList = describeOssIncrementCheckSettingResponse_videoAutoFreezeSceneList;

			DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_ImageAutoFreeze imageAutoFreeze = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_ImageAutoFreeze();
			imageAutoFreeze.Enabled = context.BooleanValue("DescribeOssIncrementCheckSetting.ImageAutoFreeze.Enabled");
			imageAutoFreeze.Porn = context.StringValue("DescribeOssIncrementCheckSetting.ImageAutoFreeze.Porn");
			imageAutoFreeze.Terrorism = context.StringValue("DescribeOssIncrementCheckSetting.ImageAutoFreeze.Terrorism");
			describeOssIncrementCheckSettingResponse.ImageAutoFreeze = imageAutoFreeze;

			List<DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BucketConfig> describeOssIncrementCheckSettingResponse_bucketConfigList = new List<DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BucketConfig>();
			for (int i = 0; i < context.Length("DescribeOssIncrementCheckSetting.BucketConfigList.Length"); i++) {
				DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BucketConfig bucketConfig = new DescribeOssIncrementCheckSettingResponse.DescribeOssIncrementCheckSetting_BucketConfig();
				bucketConfig.Selected = context.BooleanValue("DescribeOssIncrementCheckSetting.BucketConfigList["+ i +"].Selected");
				bucketConfig.Bucket = context.StringValue("DescribeOssIncrementCheckSetting.BucketConfigList["+ i +"].Bucket");

				List<string> bucketConfig_prefixes = new List<string>();
				for (int j = 0; j < context.Length("DescribeOssIncrementCheckSetting.BucketConfigList["+ i +"].Prefixes.Length"); j++) {
					bucketConfig_prefixes.Add(context.StringValue("DescribeOssIncrementCheckSetting.BucketConfigList["+ i +"].Prefixes["+ j +"]"));
				}
				bucketConfig.Prefixes = bucketConfig_prefixes;

				describeOssIncrementCheckSettingResponse_bucketConfigList.Add(bucketConfig);
			}
			describeOssIncrementCheckSettingResponse.BucketConfigList = describeOssIncrementCheckSettingResponse_bucketConfigList;
        
			return describeOssIncrementCheckSettingResponse;
        }
    }
}
