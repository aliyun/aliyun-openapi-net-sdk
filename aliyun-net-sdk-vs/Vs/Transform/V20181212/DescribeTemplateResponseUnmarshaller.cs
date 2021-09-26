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
        public static DescribeTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTemplateResponse describeTemplateResponse = new DescribeTemplateResponse();

			describeTemplateResponse.HttpResponse = _ctx.HttpResponse;
			describeTemplateResponse.RequestId = _ctx.StringValue("DescribeTemplate.RequestId");
			describeTemplateResponse.Id = _ctx.StringValue("DescribeTemplate.Id");
			describeTemplateResponse.Name = _ctx.StringValue("DescribeTemplate.Name");
			describeTemplateResponse.Description = _ctx.StringValue("DescribeTemplate.Description");
			describeTemplateResponse.Type = _ctx.StringValue("DescribeTemplate.Type");
			describeTemplateResponse.Region = _ctx.StringValue("DescribeTemplate.Region");
			describeTemplateResponse.OssBucket = _ctx.StringValue("DescribeTemplate.OssBucket");
			describeTemplateResponse.OssEndpoint = _ctx.StringValue("DescribeTemplate.OssEndpoint");
			describeTemplateResponse.OssFilePrefix = _ctx.StringValue("DescribeTemplate.OssFilePrefix");
			describeTemplateResponse.Trigger = _ctx.StringValue("DescribeTemplate.Trigger");
			describeTemplateResponse.StartTime = _ctx.StringValue("DescribeTemplate.StartTime");
			describeTemplateResponse.EndTime = _ctx.StringValue("DescribeTemplate.EndTime");
			describeTemplateResponse.Interval = _ctx.LongValue("DescribeTemplate.Interval");
			describeTemplateResponse.Retention = _ctx.LongValue("DescribeTemplate.Retention");
			describeTemplateResponse.FileFormat = _ctx.StringValue("DescribeTemplate.FileFormat");
			describeTemplateResponse.JpgOverwrite = _ctx.StringValue("DescribeTemplate.JpgOverwrite");
			describeTemplateResponse.JpgSequence = _ctx.StringValue("DescribeTemplate.JpgSequence");
			describeTemplateResponse.JpgOnDemand = _ctx.StringValue("DescribeTemplate.JpgOnDemand");
			describeTemplateResponse.Mp4 = _ctx.StringValue("DescribeTemplate.Mp4");
			describeTemplateResponse.Flv = _ctx.StringValue("DescribeTemplate.Flv");
			describeTemplateResponse.HlsM3u8 = _ctx.StringValue("DescribeTemplate.HlsM3u8");
			describeTemplateResponse.HlsTs = _ctx.StringValue("DescribeTemplate.HlsTs");
			describeTemplateResponse.Callback = _ctx.StringValue("DescribeTemplate.Callback");
			describeTemplateResponse.CreatedTime = _ctx.StringValue("DescribeTemplate.CreatedTime");

			List<DescribeTemplateResponse.DescribeTemplate_TransConfig> describeTemplateResponse_transConfigs = new List<DescribeTemplateResponse.DescribeTemplate_TransConfig>();
			for (int i = 0; i < _ctx.Length("DescribeTemplate.TransConfigs.Length"); i++) {
				DescribeTemplateResponse.DescribeTemplate_TransConfig transConfig = new DescribeTemplateResponse.DescribeTemplate_TransConfig();
				transConfig.Id = _ctx.StringValue("DescribeTemplate.TransConfigs["+ i +"].Id");
				transConfig.Name = _ctx.StringValue("DescribeTemplate.TransConfigs["+ i +"].Name");
				transConfig.VideoCodec = _ctx.StringValue("DescribeTemplate.TransConfigs["+ i +"].VideoCodec");
				transConfig.VideoBitrate = _ctx.LongValue("DescribeTemplate.TransConfigs["+ i +"].VideoBitrate");
				transConfig.Fps = _ctx.LongValue("DescribeTemplate.TransConfigs["+ i +"].Fps");
				transConfig.Gop = _ctx.LongValue("DescribeTemplate.TransConfigs["+ i +"].Gop");
				transConfig.Height = _ctx.LongValue("DescribeTemplate.TransConfigs["+ i +"].Height");
				transConfig.Width = _ctx.LongValue("DescribeTemplate.TransConfigs["+ i +"].Width");

				describeTemplateResponse_transConfigs.Add(transConfig);
			}
			describeTemplateResponse.TransConfigs = describeTemplateResponse_transConfigs;
        
			return describeTemplateResponse;
        }
    }
}
