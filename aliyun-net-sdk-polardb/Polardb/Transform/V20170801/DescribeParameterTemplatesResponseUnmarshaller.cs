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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeParameterTemplatesResponseUnmarshaller
    {
        public static DescribeParameterTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParameterTemplatesResponse describeParameterTemplatesResponse = new DescribeParameterTemplatesResponse();

			describeParameterTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			describeParameterTemplatesResponse.ParameterCount = _ctx.StringValue("DescribeParameterTemplates.ParameterCount");
			describeParameterTemplatesResponse.DBVersion = _ctx.StringValue("DescribeParameterTemplates.DBVersion");
			describeParameterTemplatesResponse.RequestId = _ctx.StringValue("DescribeParameterTemplates.RequestId");
			describeParameterTemplatesResponse.DBType = _ctx.StringValue("DescribeParameterTemplates.DBType");
			describeParameterTemplatesResponse.Engine = _ctx.StringValue("DescribeParameterTemplates.Engine");

			List<DescribeParameterTemplatesResponse.DescribeParameterTemplates_TemplateRecord> describeParameterTemplatesResponse_parameters = new List<DescribeParameterTemplatesResponse.DescribeParameterTemplates_TemplateRecord>();
			for (int i = 0; i < _ctx.Length("DescribeParameterTemplates.Parameters.Length"); i++) {
				DescribeParameterTemplatesResponse.DescribeParameterTemplates_TemplateRecord templateRecord = new DescribeParameterTemplatesResponse.DescribeParameterTemplates_TemplateRecord();
				templateRecord.ForceModify = _ctx.StringValue("DescribeParameterTemplates.Parameters["+ i +"].ForceModify");
				templateRecord.CheckingCode = _ctx.StringValue("DescribeParameterTemplates.Parameters["+ i +"].CheckingCode");
				templateRecord.ParameterValue = _ctx.StringValue("DescribeParameterTemplates.Parameters["+ i +"].ParameterValue");
				templateRecord.ForceRestart = _ctx.StringValue("DescribeParameterTemplates.Parameters["+ i +"].ForceRestart");
				templateRecord.ParameterName = _ctx.StringValue("DescribeParameterTemplates.Parameters["+ i +"].ParameterName");
				templateRecord.ParameterDescription = _ctx.StringValue("DescribeParameterTemplates.Parameters["+ i +"].ParameterDescription");

				describeParameterTemplatesResponse_parameters.Add(templateRecord);
			}
			describeParameterTemplatesResponse.Parameters = describeParameterTemplatesResponse_parameters;
        
			return describeParameterTemplatesResponse;
        }
    }
}
