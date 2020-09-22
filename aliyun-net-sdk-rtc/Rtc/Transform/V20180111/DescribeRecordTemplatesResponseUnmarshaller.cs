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
        public static DescribeRecordTemplatesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRecordTemplatesResponse describeRecordTemplatesResponse = new DescribeRecordTemplatesResponse();

			describeRecordTemplatesResponse.HttpResponse = context.HttpResponse;
			describeRecordTemplatesResponse.RequestId = context.StringValue("DescribeRecordTemplates.RequestId");
			describeRecordTemplatesResponse.TotalNum = context.LongValue("DescribeRecordTemplates.TotalNum");
			describeRecordTemplatesResponse.TotalPage = context.LongValue("DescribeRecordTemplates.TotalPage");

			List<DescribeRecordTemplatesResponse.DescribeRecordTemplates_Template> describeRecordTemplatesResponse_templates = new List<DescribeRecordTemplatesResponse.DescribeRecordTemplates_Template>();
			for (int i = 0; i < context.Length("DescribeRecordTemplates.Templates.Length"); i++) {
				DescribeRecordTemplatesResponse.DescribeRecordTemplates_Template template = new DescribeRecordTemplatesResponse.DescribeRecordTemplates_Template();
				template.CreateTime = context.StringValue("DescribeRecordTemplates.Templates["+ i +"].CreateTime");
				template.TemplateId = context.StringValue("DescribeRecordTemplates.Templates["+ i +"].TemplateId");
				template.Name = context.StringValue("DescribeRecordTemplates.Templates["+ i +"].Name");
				template.MediaEncode = context.IntegerValue("DescribeRecordTemplates.Templates["+ i +"].MediaEncode");
				template.BackgroundColor = context.IntegerValue("DescribeRecordTemplates.Templates["+ i +"].BackgroundColor");
				template.FileSplitInterval = context.IntegerValue("DescribeRecordTemplates.Templates["+ i +"].FileSplitInterval");
				template.TaskProfile = context.StringValue("DescribeRecordTemplates.Templates["+ i +"].TaskProfile");
				template.OssBucket = context.StringValue("DescribeRecordTemplates.Templates["+ i +"].OssBucket");
				template.OssFilePrefix = context.StringValue("DescribeRecordTemplates.Templates["+ i +"].OssFilePrefix");
				template.MnsQueue = context.StringValue("DescribeRecordTemplates.Templates["+ i +"].MnsQueue");

				List<string> template_layoutIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeRecordTemplates.Templates["+ i +"].LayoutIds.Length"); j++) {
					template_layoutIds.Add(context.StringValue("DescribeRecordTemplates.Templates["+ i +"].LayoutIds["+ j +"]"));
				}
				template.LayoutIds = template_layoutIds;

				List<string> template_formats = new List<string>();
				for (int j = 0; j < context.Length("DescribeRecordTemplates.Templates["+ i +"].Formats.Length"); j++) {
					template_formats.Add(context.StringValue("DescribeRecordTemplates.Templates["+ i +"].Formats["+ j +"]"));
				}
				template.Formats = template_formats;

				describeRecordTemplatesResponse_templates.Add(template);
			}
			describeRecordTemplatesResponse.Templates = describeRecordTemplatesResponse_templates;
        
			return describeRecordTemplatesResponse;
        }
    }
}
