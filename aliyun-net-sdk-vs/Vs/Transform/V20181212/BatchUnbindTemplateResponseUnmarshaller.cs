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
    public class BatchUnbindTemplateResponseUnmarshaller
    {
        public static BatchUnbindTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			BatchUnbindTemplateResponse batchUnbindTemplateResponse = new BatchUnbindTemplateResponse();

			batchUnbindTemplateResponse.HttpResponse = context.HttpResponse;
			batchUnbindTemplateResponse.RequestId = context.StringValue("BatchUnbindTemplate.RequestId");

			List<BatchUnbindTemplateResponse.BatchUnbindTemplate_Binding> batchUnbindTemplateResponse_bindings = new List<BatchUnbindTemplateResponse.BatchUnbindTemplate_Binding>();
			for (int i = 0; i < context.Length("BatchUnbindTemplate.Bindings.Length"); i++) {
				BatchUnbindTemplateResponse.BatchUnbindTemplate_Binding binding = new BatchUnbindTemplateResponse.BatchUnbindTemplate_Binding();
				binding.TemplateId = context.StringValue("BatchUnbindTemplate.Bindings["+ i +"].TemplateId");
				binding.InstanceId = context.StringValue("BatchUnbindTemplate.Bindings["+ i +"].InstanceId");
				binding.InstanceType = context.StringValue("BatchUnbindTemplate.Bindings["+ i +"].InstanceType");
				binding.Error = context.StringValue("BatchUnbindTemplate.Bindings["+ i +"].Error");

				batchUnbindTemplateResponse_bindings.Add(binding);
			}
			batchUnbindTemplateResponse.Bindings = batchUnbindTemplateResponse_bindings;
        
			return batchUnbindTemplateResponse;
        }
    }
}
