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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeParameterTemplatesResponseUnmarshaller
    {
        public static DescribeParameterTemplatesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeParameterTemplatesResponse describeParameterTemplatesResponse = new DescribeParameterTemplatesResponse();

			describeParameterTemplatesResponse.HttpResponse = context.HttpResponse;
			describeParameterTemplatesResponse.Engine = context.StringValue("DescribeParameterTemplates.Engine");
			describeParameterTemplatesResponse.EngineVersion = context.StringValue("DescribeParameterTemplates.EngineVersion");
			describeParameterTemplatesResponse.ParameterCount = context.StringValue("DescribeParameterTemplates.ParameterCount");
			describeParameterTemplatesResponse.RequestId = context.StringValue("DescribeParameterTemplates.RequestId");

			List<DescribeParameterTemplatesResponse.DescribeParameterTemplates_TemplateRecord> describeParameterTemplatesResponse_parameters = new List<DescribeParameterTemplatesResponse.DescribeParameterTemplates_TemplateRecord>();
			for (int i = 0; i < context.Length("DescribeParameterTemplates.Parameters.Length"); i++) {
				DescribeParameterTemplatesResponse.DescribeParameterTemplates_TemplateRecord templateRecord = new DescribeParameterTemplatesResponse.DescribeParameterTemplates_TemplateRecord();
				templateRecord.CheckingCode = context.StringValue("DescribeParameterTemplates.Parameters["+ i +"].CheckingCode");
				templateRecord.ForceModify = context.BooleanValue("DescribeParameterTemplates.Parameters["+ i +"].ForceModify");
				templateRecord.ForceRestart = context.BooleanValue("DescribeParameterTemplates.Parameters["+ i +"].ForceRestart");
				templateRecord.ParameterDescription = context.StringValue("DescribeParameterTemplates.Parameters["+ i +"].ParameterDescription");
				templateRecord.ParameterName = context.StringValue("DescribeParameterTemplates.Parameters["+ i +"].ParameterName");
				templateRecord.ParameterValue = context.StringValue("DescribeParameterTemplates.Parameters["+ i +"].ParameterValue");

				describeParameterTemplatesResponse_parameters.Add(templateRecord);
			}
			describeParameterTemplatesResponse.Parameters = describeParameterTemplatesResponse_parameters;
        
			return describeParameterTemplatesResponse;
        }
    }
}
