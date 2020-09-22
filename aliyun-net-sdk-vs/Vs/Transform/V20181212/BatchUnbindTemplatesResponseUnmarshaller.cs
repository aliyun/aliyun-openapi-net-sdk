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
    public class BatchUnbindTemplatesResponseUnmarshaller
    {
        public static BatchUnbindTemplatesResponse Unmarshall(UnmarshallerContext context)
        {
			BatchUnbindTemplatesResponse batchUnbindTemplatesResponse = new BatchUnbindTemplatesResponse();

			batchUnbindTemplatesResponse.HttpResponse = context.HttpResponse;
			batchUnbindTemplatesResponse.RequestId = context.StringValue("BatchUnbindTemplates.RequestId");

			List<BatchUnbindTemplatesResponse.BatchUnbindTemplates_Result> batchUnbindTemplatesResponse_results = new List<BatchUnbindTemplatesResponse.BatchUnbindTemplates_Result>();
			for (int i = 0; i < context.Length("BatchUnbindTemplates.Results.Length"); i++) {
				BatchUnbindTemplatesResponse.BatchUnbindTemplates_Result result = new BatchUnbindTemplatesResponse.BatchUnbindTemplates_Result();
				result.TemplateId = context.StringValue("BatchUnbindTemplates.Results["+ i +"].TemplateId");
				result.TemplateType = context.StringValue("BatchUnbindTemplates.Results["+ i +"].TemplateType");
				result.InstanceId = context.StringValue("BatchUnbindTemplates.Results["+ i +"].InstanceId");
				result.InstanceType = context.StringValue("BatchUnbindTemplates.Results["+ i +"].InstanceType");
				result.Error = context.StringValue("BatchUnbindTemplates.Results["+ i +"].Error");

				batchUnbindTemplatesResponse_results.Add(result);
			}
			batchUnbindTemplatesResponse.Results = batchUnbindTemplatesResponse_results;
        
			return batchUnbindTemplatesResponse;
        }
    }
}
