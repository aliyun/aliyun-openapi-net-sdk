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
    public class BatchBindTemplatesResponseUnmarshaller
    {
        public static BatchBindTemplatesResponse Unmarshall(UnmarshallerContext context)
        {
			BatchBindTemplatesResponse batchBindTemplatesResponse = new BatchBindTemplatesResponse();

			batchBindTemplatesResponse.HttpResponse = context.HttpResponse;
			batchBindTemplatesResponse.RequestId = context.StringValue("BatchBindTemplates.RequestId");

			List<BatchBindTemplatesResponse.BatchBindTemplates_Result> batchBindTemplatesResponse_results = new List<BatchBindTemplatesResponse.BatchBindTemplates_Result>();
			for (int i = 0; i < context.Length("BatchBindTemplates.Results.Length"); i++) {
				BatchBindTemplatesResponse.BatchBindTemplates_Result result = new BatchBindTemplatesResponse.BatchBindTemplates_Result();
				result.TemplateId = context.StringValue("BatchBindTemplates.Results["+ i +"].TemplateId");
				result.InstanceId = context.StringValue("BatchBindTemplates.Results["+ i +"].InstanceId");
				result.InstanceType = context.StringValue("BatchBindTemplates.Results["+ i +"].InstanceType");
				result.Error = context.StringValue("BatchBindTemplates.Results["+ i +"].Error");

				batchBindTemplatesResponse_results.Add(result);
			}
			batchBindTemplatesResponse.Results = batchBindTemplatesResponse_results;
        
			return batchBindTemplatesResponse;
        }
    }
}
