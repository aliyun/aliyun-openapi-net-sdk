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
    public class DescribeTemplatesResponseUnmarshaller
    {
        public static DescribeTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTemplatesResponse describeTemplatesResponse = new DescribeTemplatesResponse();

			describeTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			describeTemplatesResponse.RequestId = _ctx.StringValue("DescribeTemplates.RequestId");

			List<DescribeTemplatesResponse.DescribeTemplates_ResultItem> describeTemplatesResponse_result = new List<DescribeTemplatesResponse.DescribeTemplates_ResultItem>();
			for (int i = 0; i < _ctx.Length("DescribeTemplates.Result.Length"); i++) {
				DescribeTemplatesResponse.DescribeTemplates_ResultItem resultItem = new DescribeTemplatesResponse.DescribeTemplates_ResultItem();
				resultItem.Content = _ctx.StringValue("DescribeTemplates.Result["+ i +"].content");
				resultItem.TemplateName = _ctx.StringValue("DescribeTemplates.Result["+ i +"].templateName");

				describeTemplatesResponse_result.Add(resultItem);
			}
			describeTemplatesResponse.Result = describeTemplatesResponse_result;
        
			return describeTemplatesResponse;
        }
    }
}
