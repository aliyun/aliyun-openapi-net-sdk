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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeParameterTemplatesResponseUnmarshaller
    {
        public static DescribeParameterTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeParameterTemplatesResponse describeParameterTemplatesResponse = new DescribeParameterTemplatesResponse();

			describeParameterTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			describeParameterTemplatesResponse.RequestId = _ctx.StringValue("DescribeParameterTemplates.RequestId");

			DescribeParameterTemplatesResponse.DescribeParameterTemplates_Data data = new DescribeParameterTemplatesResponse.DescribeParameterTemplates_Data();
			data.EngineVersion = _ctx.StringValue("DescribeParameterTemplates.Data.EngineVersion");
			data.Engine = _ctx.StringValue("DescribeParameterTemplates.Data.Engine");
			data.ParameterCount = _ctx.IntegerValue("DescribeParameterTemplates.Data.ParameterCount");

			List<DescribeParameterTemplatesResponse.DescribeParameterTemplates_Data.DescribeParameterTemplates_TemplateRecord> data_parameters = new List<DescribeParameterTemplatesResponse.DescribeParameterTemplates_Data.DescribeParameterTemplates_TemplateRecord>();
			for (int i = 0; i < _ctx.Length("DescribeParameterTemplates.Data.Parameters.Length"); i++) {
				DescribeParameterTemplatesResponse.DescribeParameterTemplates_Data.DescribeParameterTemplates_TemplateRecord templateRecord = new DescribeParameterTemplatesResponse.DescribeParameterTemplates_Data.DescribeParameterTemplates_TemplateRecord();
				templateRecord.ParameterName = _ctx.StringValue("DescribeParameterTemplates.Data.Parameters["+ i +"].ParameterName");
				templateRecord.ParameterValue = _ctx.StringValue("DescribeParameterTemplates.Data.Parameters["+ i +"].ParameterValue");
				templateRecord.ParameterDescription = _ctx.StringValue("DescribeParameterTemplates.Data.Parameters["+ i +"].ParameterDescription");
				templateRecord.CheckingCode = _ctx.StringValue("DescribeParameterTemplates.Data.Parameters["+ i +"].CheckingCode");
				templateRecord.Revisable = _ctx.IntegerValue("DescribeParameterTemplates.Data.Parameters["+ i +"].Revisable");
				templateRecord._Dynamic = _ctx.IntegerValue("DescribeParameterTemplates.Data.Parameters["+ i +"].Dynamic");

				data_parameters.Add(templateRecord);
			}
			data.Parameters = data_parameters;
			describeParameterTemplatesResponse.Data = data;
        
			return describeParameterTemplatesResponse;
        }
    }
}
