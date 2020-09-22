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
        public static DescribeTemplatesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTemplatesResponse describeTemplatesResponse = new DescribeTemplatesResponse();

			describeTemplatesResponse.HttpResponse = context.HttpResponse;
			describeTemplatesResponse.RequestId = context.StringValue("DescribeTemplates.RequestId");
			describeTemplatesResponse.PageSize = context.LongValue("DescribeTemplates.PageSize");
			describeTemplatesResponse.PageNum = context.LongValue("DescribeTemplates.PageNum");
			describeTemplatesResponse.PageCount = context.LongValue("DescribeTemplates.PageCount");
			describeTemplatesResponse.TotalCount = context.LongValue("DescribeTemplates.TotalCount");

			List<DescribeTemplatesResponse.DescribeTemplates_Template> describeTemplatesResponse_templates = new List<DescribeTemplatesResponse.DescribeTemplates_Template>();
			for (int i = 0; i < context.Length("DescribeTemplates.Templates.Length"); i++) {
				DescribeTemplatesResponse.DescribeTemplates_Template template = new DescribeTemplatesResponse.DescribeTemplates_Template();
				template.Id = context.StringValue("DescribeTemplates.Templates["+ i +"].Id");
				template.Name = context.StringValue("DescribeTemplates.Templates["+ i +"].Name");
				template.Description = context.StringValue("DescribeTemplates.Templates["+ i +"].Description");
				template.Type = context.StringValue("DescribeTemplates.Templates["+ i +"].Type");
				template.Region = context.StringValue("DescribeTemplates.Templates["+ i +"].Region");
				template.OssBucket = context.StringValue("DescribeTemplates.Templates["+ i +"].OssBucket");
				template.OssEndpoint = context.StringValue("DescribeTemplates.Templates["+ i +"].OssEndpoint");
				template.OssFilePrefix = context.StringValue("DescribeTemplates.Templates["+ i +"].OssFilePrefix");
				template.Trigger = context.StringValue("DescribeTemplates.Templates["+ i +"].Trigger");
				template.StartTime = context.StringValue("DescribeTemplates.Templates["+ i +"].StartTime");
				template.EndTime = context.StringValue("DescribeTemplates.Templates["+ i +"].EndTime");
				template.Interval = context.LongValue("DescribeTemplates.Templates["+ i +"].Interval");
				template.Retention = context.LongValue("DescribeTemplates.Templates["+ i +"].Retention");
				template.FileFormat = context.StringValue("DescribeTemplates.Templates["+ i +"].FileFormat");
				template.JpgOverwrite = context.StringValue("DescribeTemplates.Templates["+ i +"].JpgOverwrite");
				template.JpgSequence = context.StringValue("DescribeTemplates.Templates["+ i +"].JpgSequence");
				template.JpgOnDemand = context.StringValue("DescribeTemplates.Templates["+ i +"].JpgOnDemand");
				template.Mp4 = context.StringValue("DescribeTemplates.Templates["+ i +"].Mp4");
				template.Flv = context.StringValue("DescribeTemplates.Templates["+ i +"].Flv");
				template.HlsM3u8 = context.StringValue("DescribeTemplates.Templates["+ i +"].HlsM3u8");
				template.HlsTs = context.StringValue("DescribeTemplates.Templates["+ i +"].HlsTs");
				template.Callback = context.StringValue("DescribeTemplates.Templates["+ i +"].Callback");
				template.CreatedTime = context.StringValue("DescribeTemplates.Templates["+ i +"].CreatedTime");

				List<DescribeTemplatesResponse.DescribeTemplates_Template.DescribeTemplates_TransConfig> template_transConfigs = new List<DescribeTemplatesResponse.DescribeTemplates_Template.DescribeTemplates_TransConfig>();
				for (int j = 0; j < context.Length("DescribeTemplates.Templates["+ i +"].TransConfigs.Length"); j++) {
					DescribeTemplatesResponse.DescribeTemplates_Template.DescribeTemplates_TransConfig transConfig = new DescribeTemplatesResponse.DescribeTemplates_Template.DescribeTemplates_TransConfig();
					transConfig.Id = context.StringValue("DescribeTemplates.Templates["+ i +"].TransConfigs["+ j +"].id");
					transConfig.Name = context.StringValue("DescribeTemplates.Templates["+ i +"].TransConfigs["+ j +"].Name");
					transConfig.VideoCodec = context.StringValue("DescribeTemplates.Templates["+ i +"].TransConfigs["+ j +"].VideoCodec");
					transConfig.VideoBitrate = context.LongValue("DescribeTemplates.Templates["+ i +"].TransConfigs["+ j +"].VideoBitrate");
					transConfig.Fps = context.LongValue("DescribeTemplates.Templates["+ i +"].TransConfigs["+ j +"].Fps");
					transConfig.Gop = context.LongValue("DescribeTemplates.Templates["+ i +"].TransConfigs["+ j +"].Gop");
					transConfig.Height = context.LongValue("DescribeTemplates.Templates["+ i +"].TransConfigs["+ j +"].Height");
					transConfig.Width = context.LongValue("DescribeTemplates.Templates["+ i +"].TransConfigs["+ j +"].Width");

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
