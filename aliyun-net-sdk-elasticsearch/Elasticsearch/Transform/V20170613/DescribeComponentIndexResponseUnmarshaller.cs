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
    public class DescribeComponentIndexResponseUnmarshaller
    {
        public static DescribeComponentIndexResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeComponentIndexResponse describeComponentIndexResponse = new DescribeComponentIndexResponse();

			describeComponentIndexResponse.HttpResponse = _ctx.HttpResponse;
			describeComponentIndexResponse.RequestId = _ctx.StringValue("DescribeComponentIndex.RequestId");

			DescribeComponentIndexResponse.DescribeComponentIndex_Result result = new DescribeComponentIndexResponse.DescribeComponentIndex_Result();
			result._Meta = _ctx.StringValue("DescribeComponentIndex.Result._meta");

			DescribeComponentIndexResponse.DescribeComponentIndex_Result.DescribeComponentIndex_Template template = new DescribeComponentIndexResponse.DescribeComponentIndex_Result.DescribeComponentIndex_Template();
			template.Aliases = _ctx.StringValue("DescribeComponentIndex.Result.Template.aliases");
			template.Mappings = _ctx.StringValue("DescribeComponentIndex.Result.Template.mappings");
			template.Settings = _ctx.StringValue("DescribeComponentIndex.Result.Template.settings");
			result.Template = template;
			describeComponentIndexResponse.Result = result;
        
			return describeComponentIndexResponse;
        }
    }
}
