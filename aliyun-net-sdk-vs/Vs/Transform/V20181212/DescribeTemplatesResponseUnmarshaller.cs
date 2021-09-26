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
    public class DescribeTemplatesResponseUnmarshaller
    {
        public static DescribeTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTemplatesResponse describeTemplatesResponse = new DescribeTemplatesResponse();

			describeTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			describeTemplatesResponse.RequestId = _ctx.StringValue("DescribeTemplates.RequestId");
			describeTemplatesResponse.PageSize = _ctx.LongValue("DescribeTemplates.PageSize");
			describeTemplatesResponse.PageNum = _ctx.LongValue("DescribeTemplates.PageNum");
			describeTemplatesResponse.PageCount = _ctx.LongValue("DescribeTemplates.PageCount");
			describeTemplatesResponse.TotalCount = _ctx.LongValue("DescribeTemplates.TotalCount");

			List<DescribeTemplatesResponse.DescribeTemplates_Template> describeTemplatesResponse_templates = new List<DescribeTemplatesResponse.DescribeTemplates_Template>();
			for (int i = 0; i < _ctx.Length("DescribeTemplates.Templates.Length"); i++) {
				DescribeTemplatesResponse.DescribeTemplates_Template template = new DescribeTemplatesResponse.DescribeTemplates_Template();
				template.Id = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].Id");
				template.Name = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].Name");
				template.Description = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].Description");
				template.Type = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].Type");
				template.Region = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].Region");
				template.OssBucket = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].OssBucket");
				template.OssEndpoint = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].OssEndpoint");
				template.OssFilePrefix = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].OssFilePrefix");
				template.Trigger = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].Trigger");
				template.StartTime = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].StartTime");
				template.EndTime = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].EndTime");
				template.Interval = _ctx.LongValue("DescribeTemplates.Templates["+ i +"].Interval");
				template.Retention = _ctx.LongValue("DescribeTemplates.Templates["+ i +"].Retention");
				template.FileFormat = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].FileFormat");
				template.JpgOverwrite = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].JpgOverwrite");
				template.JpgSequence = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].JpgSequence");
				template.JpgOnDemand = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].JpgOnDemand");
				template.Mp4 = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].Mp4");
				template.Flv = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].Flv");
				template.HlsM3u8 = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].HlsM3u8");
				template.HlsTs = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].HlsTs");
				template.Callback = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].Callback");
				template.CreatedTime = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].CreatedTime");

				List<DescribeTemplatesResponse.DescribeTemplates_Template.DescribeTemplates_TransConfig> template_transConfigs = new List<DescribeTemplatesResponse.DescribeTemplates_Template.DescribeTemplates_TransConfig>();
				for (int j = 0; j < _ctx.Length("DescribeTemplates.Templates["+ i +"].TransConfigs.Length"); j++) {
					DescribeTemplatesResponse.DescribeTemplates_Template.DescribeTemplates_TransConfig transConfig = new DescribeTemplatesResponse.DescribeTemplates_Template.DescribeTemplates_TransConfig();
					transConfig.Id = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].TransConfigs["+ j +"].id");
					transConfig.Name = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].TransConfigs["+ j +"].Name");
					transConfig.VideoCodec = _ctx.StringValue("DescribeTemplates.Templates["+ i +"].TransConfigs["+ j +"].VideoCodec");
					transConfig.VideoBitrate = _ctx.LongValue("DescribeTemplates.Templates["+ i +"].TransConfigs["+ j +"].VideoBitrate");
					transConfig.Fps = _ctx.LongValue("DescribeTemplates.Templates["+ i +"].TransConfigs["+ j +"].Fps");
					transConfig.Gop = _ctx.LongValue("DescribeTemplates.Templates["+ i +"].TransConfigs["+ j +"].Gop");
					transConfig.Height = _ctx.LongValue("DescribeTemplates.Templates["+ i +"].TransConfigs["+ j +"].Height");
					transConfig.Width = _ctx.LongValue("DescribeTemplates.Templates["+ i +"].TransConfigs["+ j +"].Width");

					template_transConfigs.Add(transConfig);
				}
				template.TransConfigs = template_transConfigs;

				describeTemplatesResponse_templates.Add(template);
			}
			describeTemplatesResponse.Templates = describeTemplatesResponse_templates;
        
			return describeTemplatesResponse;
        }
    }
}
