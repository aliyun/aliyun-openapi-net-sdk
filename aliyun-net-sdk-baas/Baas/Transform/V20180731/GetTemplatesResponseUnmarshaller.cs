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
    public class GetTemplatesResponseUnmarshaller
    {
        public static GetTemplatesResponse Unmarshall(UnmarshallerContext context)
        {
			GetTemplatesResponse getTemplatesResponse = new GetTemplatesResponse();

			getTemplatesResponse.HttpResponse = context.HttpResponse;
			getTemplatesResponse.RequestId = context.StringValue("GetTemplates.RequestId");

			GetTemplatesResponse.GetTemplates_Result result = new GetTemplatesResponse.GetTemplates_Result();

			List<GetTemplatesResponse.GetTemplates_Result.GetTemplates_SchemaListItem> result_schemaList = new List<GetTemplatesResponse.GetTemplates_Result.GetTemplates_SchemaListItem>();
			for (int i = 0; i < context.Length("GetTemplates.Result.SchemaList.Length"); i++) {
				GetTemplatesResponse.GetTemplates_Result.GetTemplates_SchemaListItem schemaListItem = new GetTemplatesResponse.GetTemplates_Result.GetTemplates_SchemaListItem();
				schemaListItem.Id = context.LongValue("GetTemplates.Result.SchemaList["+ i +"].Id");
				schemaListItem.Name = context.StringValue("GetTemplates.Result.SchemaList["+ i +"].Name");
				schemaListItem.Description = context.StringValue("GetTemplates.Result.SchemaList["+ i +"].Description");
				schemaListItem.Version = context.LongValue("GetTemplates.Result.SchemaList["+ i +"].Version");
				schemaListItem.CreateTime = context.LongValue("GetTemplates.Result.SchemaList["+ i +"].CreateTime");
				schemaListItem.UpdateTime = context.LongValue("GetTemplates.Result.SchemaList["+ i +"].UpdateTime");
				schemaListItem.IsTemplate = context.IntegerValue("GetTemplates.Result.SchemaList["+ i +"].IsTemplate");

				result_schemaList.Add(schemaListItem);
			}
			result.SchemaList = result_schemaList;
			getTemplatesResponse.Result = result;
        
			return getTemplatesResponse;
        }
    }
}