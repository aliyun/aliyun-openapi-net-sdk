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
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeRecordTemplatesResponseUnmarshaller
    {
        public static DescribeRecordTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRecordTemplatesResponse describeRecordTemplatesResponse = new DescribeRecordTemplatesResponse();

			describeRecordTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			describeRecordTemplatesResponse.RequestId = _ctx.StringValue("DescribeRecordTemplates.RequestId");
			describeRecordTemplatesResponse.TotalNum = _ctx.LongValue("DescribeRecordTemplates.TotalNum");
			describeRecordTemplatesResponse.TotalPage = _ctx.LongValue("DescribeRecordTemplates.TotalPage");

			List<DescribeRecordTemplatesResponse.DescribeRecordTemplates_Template> describeRecordTemplatesResponse_templates = new List<DescribeRecordTemplatesResponse.DescribeRecordTemplates_Template>();
			for (int i = 0; i < _ctx.Length("DescribeRecordTemplates.Templates.Length"); i++) {
				DescribeRecordTemplatesResponse.DescribeRecordTemplates_Template template = new DescribeRecordTemplatesResponse.DescribeRecordTemplates_Template();
				template.CreateTime = _ctx.StringValue("DescribeRecordTemplates.Templates["+ i +"].CreateTime");
				template.TemplateId = _ctx.StringValue("DescribeRecordTemplates.Templates["+ i +"].TemplateId");
				template.Name = _ctx.StringValue("DescribeRecordTemplates.Templates["+ i +"].Name");
				template.MediaEncode = _ctx.IntegerValue("DescribeRecordTemplates.Templates["+ i +"].MediaEncode");
				template.BackgroundColor = _ctx.IntegerValue("DescribeRecordTemplates.Templates["+ i +"].BackgroundColor");
				template.FileSplitInterval = _ctx.IntegerValue("DescribeRecordTemplates.Templates["+ i +"].FileSplitInterval");
				template.TaskProfile = _ctx.StringValue("DescribeRecordTemplates.Templates["+ i +"].TaskProfile");
				template.OssBucket = _ctx.StringValue("DescribeRecordTemplates.Templates["+ i +"].OssBucket");
				template.OssFilePrefix = _ctx.StringValue("DescribeRecordTemplates.Templates["+ i +"].OssFilePrefix");
				template.MnsQueue = _ctx.StringValue("DescribeRecordTemplates.Templates["+ i +"].MnsQueue");

				List<string> template_layoutIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeRecordTemplates.Templates["+ i +"].LayoutIds.Length"); j++) {
					template_layoutIds.Add(_ctx.StringValue("DescribeRecordTemplates.Templates["+ i +"].LayoutIds["+ j +"]"));
				}
				template.LayoutIds = template_layoutIds;

				List<string> template_formats = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeRecordTemplates.Templates["+ i +"].Formats.Length"); j++) {
					template_formats.Add(_ctx.StringValue("DescribeRecordTemplates.Templates["+ i +"].Formats["+ j +"]"));
				}
				template.Formats = template_formats;

				describeRecordTemplatesResponse_templates.Add(template);
			}
			describeRecordTemplatesResponse.Templates = describeRecordTemplatesResponse_templates;
        
			return describeRecordTemplatesResponse;
        }
    }
}
