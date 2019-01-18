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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class DescribeTemplatesResponseUnmarshaller
    {
        public static DescribeTemplatesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTemplatesResponse describeTemplatesResponse = new DescribeTemplatesResponse();

			describeTemplatesResponse.HttpResponse = context.HttpResponse;
			describeTemplatesResponse.RequestId = context.StringValue("DescribeTemplates.RequestId");

			DescribeTemplatesResponse.DescribeTemplates_Result result = new DescribeTemplatesResponse.DescribeTemplates_Result();

			List<DescribeTemplatesResponse.DescribeTemplates_Result.DescribeTemplates_SchemaListItem> result_schemaList = new List<DescribeTemplatesResponse.DescribeTemplates_Result.DescribeTemplates_SchemaListItem>();
			for (int i = 0; i < context.Length("DescribeTemplates.Result.SchemaList.Length"); i++) {
				DescribeTemplatesResponse.DescribeTemplates_Result.DescribeTemplates_SchemaListItem schemaListItem = new DescribeTemplatesResponse.DescribeTemplates_Result.DescribeTemplates_SchemaListItem();
				schemaListItem.Id = context.LongValue("DescribeTemplates.Result.SchemaList["+ i +"].Id");
				schemaListItem.Name = context.StringValue("DescribeTemplates.Result.SchemaList["+ i +"].Name");
				schemaListItem.Description = context.StringValue("DescribeTemplates.Result.SchemaList["+ i +"].Description");
				schemaListItem.Version = context.LongValue("DescribeTemplates.Result.SchemaList["+ i +"].Version");
				schemaListItem.CreateTime = context.LongValue("DescribeTemplates.Result.SchemaList["+ i +"].CreateTime");
				schemaListItem.UpdateTime = context.LongValue("DescribeTemplates.Result.SchemaList["+ i +"].UpdateTime");
				schemaListItem.IsTemplate = context.IntegerValue("DescribeTemplates.Result.SchemaList["+ i +"].IsTemplate");

				result_schemaList.Add(schemaListItem);
			}
			result.SchemaList = result_schemaList;
			describeTemplatesResponse.Result = result;
        
			return describeTemplatesResponse;
        }
    }
}