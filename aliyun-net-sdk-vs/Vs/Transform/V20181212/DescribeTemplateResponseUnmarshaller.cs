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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeTemplateResponseUnmarshaller
    {
        public static DescribeTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTemplateResponse describeTemplateResponse = new DescribeTemplateResponse();

			describeTemplateResponse.HttpResponse = context.HttpResponse;
			describeTemplateResponse.RequestId = context.StringValue("DescribeTemplate.RequestId");
			describeTemplateResponse.Id = context.StringValue("DescribeTemplate.Id");
			describeTemplateResponse.Name = context.StringValue("DescribeTemplate.Name");
			describeTemplateResponse.Description = context.StringValue("DescribeTemplate.Description");
			describeTemplateResponse.Type = context.StringValue("DescribeTemplate.Type");
			describeTemplateResponse.Region = context.StringValue("DescribeTemplate.Region");
			describeTemplateResponse.OssBucket = context.StringValue("DescribeTemplate.OssBucket");
			describeTemplateResponse.OssEndpoint = context.StringValue("DescribeTemplate.OssEndpoint");
			describeTemplateResponse.OssFilePrefix = context.StringValue("DescribeTemplate.OssFilePrefix");
			describeTemplateResponse.Trigger = context.StringValue("DescribeTemplate.Trigger");
			describeTemplateResponse.StartTime = context.StringValue("DescribeTemplate.StartTime");
			describeTemplateResponse.EndTime = context.StringValue("DescribeTemplate.EndTime");
			describeTemplateResponse.Interval = context.LongValue("DescribeTemplate.Interval");
			describeTemplateResponse.Retention = context.LongValue("DescribeTemplate.Retention");
			describeTemplateResponse.FileFormat = context.StringValue("DescribeTemplate.FileFormat");
			describeTemplateResponse.JpgOverwrite = context.StringValue("DescribeTemplate.JpgOverwrite");
			describeTemplateResponse.JpgSequence = context.StringValue("DescribeTemplate.JpgSequence");
			describeTemplateResponse.JpgOnDemand = context.StringValue("DescribeTemplate.JpgOnDemand");
			describeTemplateResponse.Mp4 = context.StringValue("DescribeTemplate.Mp4");
			describeTemplateResponse.Flv = context.StringValue("DescribeTemplate.Flv");
			describeTemplateResponse.HlsM3u8 = context.StringValue("DescribeTemplate.HlsM3u8");
			describeTemplateResponse.HlsTs = context.StringValue("DescribeTemplate.HlsTs");
			describeTemplateResponse.Callback = context.StringValue("DescribeTemplate.Callback");
			describeTemplateResponse.CreatedTime = context.StringValue("DescribeTemplate.CreatedTime");

			List<DescribeTemplateResponse.DescribeTemplate_TransConfig> describeTemplateResponse_transConfigs = new List<DescribeTemplateResponse.DescribeTemplate_TransConfig>();
			for (int i = 0; i < context.Length("DescribeTemplate.TransConfigs.Length"); i++) {
				DescribeTemplateResponse.DescribeTemplate_TransConfig transConfig = new DescribeTemplateResponse.DescribeTemplate_TransConfig();
				transConfig.Id = context.StringValue("DescribeTemplate.TransConfigs["+ i +"].Id");
				transConfig.Name = context.StringValue("DescribeTemplate.TransConfigs["+ i +"].Name");
				transConfig.VideoCodec = context.StringValue("DescribeTemplate.TransConfigs["+ i +"].VideoCodec");
				transConfig.VideoBitrate = context.LongValue("DescribeTemplate.TransConfigs["+ i +"].VideoBitrate");
				transConfig.Fps = context.LongValue("DescribeTemplate.TransConfigs["+ i +"].Fps");
				transConfig.Gop = context.LongValue("DescribeTemplate.TransConfigs["+ i +"].Gop");
				transConfig.Height = context.LongValue("DescribeTemplate.TransConfigs["+ i +"].Height");
				transConfig.Width = context.LongValue("DescribeTemplate.TransConfigs["+ i +"].Width");

				describeTemplateResponse_transConfigs.Add(transConfig);
			}
			describeTemplateResponse.TransConfigs = describeTemplateResponse_transConfigs;
        
			return describeTemplateResponse;
        }
    }
}
