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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class DescribeDeprecatedTemplateResponseUnmarshaller
    {
        public static DescribeDeprecatedTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDeprecatedTemplateResponse describeDeprecatedTemplateResponse = new DescribeDeprecatedTemplateResponse();

			describeDeprecatedTemplateResponse.HttpResponse = _ctx.HttpResponse;
			describeDeprecatedTemplateResponse.RequestId = _ctx.StringValue("DescribeDeprecatedTemplate.RequestId");

			DescribeDeprecatedTemplateResponse.DescribeDeprecatedTemplate_Result result = new DescribeDeprecatedTemplateResponse.DescribeDeprecatedTemplate_Result();
			result.DataStream = _ctx.BooleanValue("DescribeDeprecatedTemplate.Result.dataStream");
			result.IndexTemplate = _ctx.StringValue("DescribeDeprecatedTemplate.Result.indexTemplate");
			result.Order = _ctx.LongValue("DescribeDeprecatedTemplate.Result.order");
			result.Version = _ctx.StringValue("DescribeDeprecatedTemplate.Result.version");

			List<string> result_indexPatterns = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeDeprecatedTemplate.Result.IndexPatterns.Length"); i++) {
				result_indexPatterns.Add(_ctx.StringValue("DescribeDeprecatedTemplate.Result.IndexPatterns["+ i +"]"));
			}
			result.IndexPatterns = result_indexPatterns;

			DescribeDeprecatedTemplateResponse.DescribeDeprecatedTemplate_Result.DescribeDeprecatedTemplate_Template template = new DescribeDeprecatedTemplateResponse.DescribeDeprecatedTemplate_Result.DescribeDeprecatedTemplate_Template();
			template.Aliases = _ctx.StringValue("DescribeDeprecatedTemplate.Result.Template.aliases");
			template.Mappings = _ctx.StringValue("DescribeDeprecatedTemplate.Result.Template.mappings");
			template.Settings = _ctx.StringValue("DescribeDeprecatedTemplate.Result.Template.settings");
			result.Template = template;
			describeDeprecatedTemplateResponse.Result = result;
        
			return describeDeprecatedTemplateResponse;
        }
    }
}
