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
using Aliyun.Acs.Cms.Model.V20180308;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class ApplyTemplateResponseUnmarshaller
    {
        public static ApplyTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			ApplyTemplateResponse applyTemplateResponse = new ApplyTemplateResponse();

			applyTemplateResponse.HttpResponse = context.HttpResponse;
			applyTemplateResponse.RequestId = context.StringValue("ApplyTemplate.RequestId");
			applyTemplateResponse.Success = context.BooleanValue("ApplyTemplate.Success");
			applyTemplateResponse.ErrorCode = context.IntegerValue("ApplyTemplate.ErrorCode");
			applyTemplateResponse.ErrorMessage = context.StringValue("ApplyTemplate.ErrorMessage");

			ApplyTemplateResponse.ApplyTemplate_Resource resource = new ApplyTemplateResponse.ApplyTemplate_Resource();

			List<ApplyTemplateResponse.ApplyTemplate_Resource.ApplyTemplate_AlertResult> resource_createAlertResults = new List<ApplyTemplateResponse.ApplyTemplate_Resource.ApplyTemplate_AlertResult>();
			for (int i = 0; i < context.Length("ApplyTemplate.Resource.CreateAlertResults.Length"); i++) {
				ApplyTemplateResponse.ApplyTemplate_Resource.ApplyTemplate_AlertResult alertResult = new ApplyTemplateResponse.ApplyTemplate_Resource.ApplyTemplate_AlertResult();
				alertResult.Name = context.StringValue("ApplyTemplate.Resource.CreateAlertResults["+ i +"].Name");
				alertResult.DisplayName = context.StringValue("ApplyTemplate.Resource.CreateAlertResults["+ i +"].DisplayName");
				alertResult.MetricNamespace = context.StringValue("ApplyTemplate.Resource.CreateAlertResults["+ i +"].MetricNamespace");
				alertResult.MetricName = context.StringValue("ApplyTemplate.Resource.CreateAlertResults["+ i +"].MetricName");
				alertResult.Message = context.StringValue("ApplyTemplate.Resource.CreateAlertResults["+ i +"].Message");
				alertResult.Success = context.StringValue("ApplyTemplate.Resource.CreateAlertResults["+ i +"].Success");

				resource_createAlertResults.Add(alertResult);
			}
			resource.CreateAlertResults = resource_createAlertResults;
			applyTemplateResponse.Resource = resource;
        
			return applyTemplateResponse;
        }
    }
}
