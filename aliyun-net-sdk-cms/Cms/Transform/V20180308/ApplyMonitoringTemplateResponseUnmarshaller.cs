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
    public class ApplyMonitoringTemplateResponseUnmarshaller
    {
        public static ApplyMonitoringTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			ApplyMonitoringTemplateResponse applyMonitoringTemplateResponse = new ApplyMonitoringTemplateResponse();

			applyMonitoringTemplateResponse.HttpResponse = context.HttpResponse;
			applyMonitoringTemplateResponse.RequestId = context.StringValue("ApplyMonitoringTemplate.RequestId");
			applyMonitoringTemplateResponse.Success = context.BooleanValue("ApplyMonitoringTemplate.Success");
			applyMonitoringTemplateResponse.ErrorCode = context.IntegerValue("ApplyMonitoringTemplate.ErrorCode");
			applyMonitoringTemplateResponse.ErrorMessage = context.StringValue("ApplyMonitoringTemplate.ErrorMessage");

			ApplyMonitoringTemplateResponse.ApplyMonitoringTemplate_Resource resource = new ApplyMonitoringTemplateResponse.ApplyMonitoringTemplate_Resource();
			resource.GroupId = context.LongValue("ApplyMonitoringTemplate.Resource.GroupId");

			List<ApplyMonitoringTemplateResponse.ApplyMonitoringTemplate_Resource.ApplyMonitoringTemplate_Result> resource_eventResults = new List<ApplyMonitoringTemplateResponse.ApplyMonitoringTemplate_Resource.ApplyMonitoringTemplate_Result>();
			for (int i = 0; i < context.Length("ApplyMonitoringTemplate.Resource.EventResults.Length"); i++) {
				ApplyMonitoringTemplateResponse.ApplyMonitoringTemplate_Resource.ApplyMonitoringTemplate_Result result = new ApplyMonitoringTemplateResponse.ApplyMonitoringTemplate_Resource.ApplyMonitoringTemplate_Result();
				result.GroupId = context.LongValue("ApplyMonitoringTemplate.Resource.EventResults["+ i +"].GroupId");
				result.Name = context.StringValue("ApplyMonitoringTemplate.Resource.EventResults["+ i +"].Name");
				result.Message = context.StringValue("ApplyMonitoringTemplate.Resource.EventResults["+ i +"].Message");
				result.DisplayName = context.StringValue("ApplyMonitoringTemplate.Resource.EventResults["+ i +"].DisplayName");
				result.Code = context.IntegerValue("ApplyMonitoringTemplate.Resource.EventResults["+ i +"].Code");
				result.Success = context.BooleanValue("ApplyMonitoringTemplate.Resource.EventResults["+ i +"].Success");

				resource_eventResults.Add(result);
			}
			resource.EventResults = resource_eventResults;

			List<ApplyMonitoringTemplateResponse.ApplyMonitoringTemplate_Resource.ApplyMonitoringTemplate_Result> resource_alertResults = new List<ApplyMonitoringTemplateResponse.ApplyMonitoringTemplate_Resource.ApplyMonitoringTemplate_Result>();
			for (int i = 0; i < context.Length("ApplyMonitoringTemplate.Resource.AlertResults.Length"); i++) {
				ApplyMonitoringTemplateResponse.ApplyMonitoringTemplate_Resource.ApplyMonitoringTemplate_Result result = new ApplyMonitoringTemplateResponse.ApplyMonitoringTemplate_Resource.ApplyMonitoringTemplate_Result();
				result.GroupId = context.LongValue("ApplyMonitoringTemplate.Resource.AlertResults["+ i +"].GroupId");
				result.Name = context.StringValue("ApplyMonitoringTemplate.Resource.AlertResults["+ i +"].Name");
				result.Message = context.StringValue("ApplyMonitoringTemplate.Resource.AlertResults["+ i +"].Message");
				result.DisplayName = context.StringValue("ApplyMonitoringTemplate.Resource.AlertResults["+ i +"].DisplayName");
				result.Code = context.IntegerValue("ApplyMonitoringTemplate.Resource.AlertResults["+ i +"].Code");
				result.Success = context.BooleanValue("ApplyMonitoringTemplate.Resource.AlertResults["+ i +"].Success");

				resource_alertResults.Add(result);
			}
			resource.AlertResults = resource_alertResults;
			applyMonitoringTemplateResponse.Resource = resource;
        
			return applyMonitoringTemplateResponse;
        }
    }
}
