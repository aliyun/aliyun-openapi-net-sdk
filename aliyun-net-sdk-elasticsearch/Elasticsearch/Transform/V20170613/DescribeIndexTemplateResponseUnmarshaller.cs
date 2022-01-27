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
    public class DescribeIndexTemplateResponseUnmarshaller
    {
        public static DescribeIndexTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeIndexTemplateResponse describeIndexTemplateResponse = new DescribeIndexTemplateResponse();

			describeIndexTemplateResponse.HttpResponse = _ctx.HttpResponse;
			describeIndexTemplateResponse.RequestId = _ctx.StringValue("DescribeIndexTemplate.RequestId");

			DescribeIndexTemplateResponse.DescribeIndexTemplate_Result result = new DescribeIndexTemplateResponse.DescribeIndexTemplate_Result();
			result.IndexTemplate = _ctx.StringValue("DescribeIndexTemplate.Result.indexTemplate");
			result.DataStream = _ctx.BooleanValue("DescribeIndexTemplate.Result.dataStream");
			result.Priority = _ctx.IntegerValue("DescribeIndexTemplate.Result.priority");
			result.IlmPolicy = _ctx.StringValue("DescribeIndexTemplate.Result.ilmPolicy");

			List<string> result_indexPatterns = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeIndexTemplate.Result.IndexPatterns.Length"); i++) {
				result_indexPatterns.Add(_ctx.StringValue("DescribeIndexTemplate.Result.IndexPatterns["+ i +"]"));
			}
			result.IndexPatterns = result_indexPatterns;

			DescribeIndexTemplateResponse.DescribeIndexTemplate_Result.DescribeIndexTemplate_Template template = new DescribeIndexTemplateResponse.DescribeIndexTemplate_Result.DescribeIndexTemplate_Template();
			template.Settings = _ctx.StringValue("DescribeIndexTemplate.Result.Template.settings");
			template.Mappings = _ctx.StringValue("DescribeIndexTemplate.Result.Template.mappings");
			template.Aliases = _ctx.StringValue("DescribeIndexTemplate.Result.Template.aliases");
			result.Template = template;
			describeIndexTemplateResponse.Result = result;
        
			return describeIndexTemplateResponse;
        }
    }
}
