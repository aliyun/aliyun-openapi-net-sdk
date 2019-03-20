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
    public class GetMonitoringTemplateResponseUnmarshaller
    {
        public static GetMonitoringTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			GetMonitoringTemplateResponse getMonitoringTemplateResponse = new GetMonitoringTemplateResponse();

			getMonitoringTemplateResponse.HttpResponse = context.HttpResponse;
			getMonitoringTemplateResponse.RequestId = context.StringValue("GetMonitoringTemplate.RequestId");
			getMonitoringTemplateResponse.Success = context.BooleanValue("GetMonitoringTemplate.Success");
			getMonitoringTemplateResponse.ErrorCode = context.IntegerValue("GetMonitoringTemplate.ErrorCode");
			getMonitoringTemplateResponse.ErrorMessage = context.StringValue("GetMonitoringTemplate.ErrorMessage");

			GetMonitoringTemplateResponse.GetMonitoringTemplate_Resource resource = new GetMonitoringTemplateResponse.GetMonitoringTemplate_Resource();
			resource.Name = context.StringValue("GetMonitoringTemplate.Resource.Name");
			resource.Id = context.StringValue("GetMonitoringTemplate.Resource.Id");
			resource.RestVersion = context.StringValue("GetMonitoringTemplate.Resource.RestVersion");
			resource._Namespace = context.StringValue("GetMonitoringTemplate.Resource.Namespace");
			resource.Description = context.StringValue("GetMonitoringTemplate.Resource.Description");
			resource.AlertTemplatesJson = context.StringValue("GetMonitoringTemplate.Resource.AlertTemplatesJson");
			resource.EventRuleTemplatesJson = context.StringValue("GetMonitoringTemplate.Resource.EventRuleTemplatesJson");
			getMonitoringTemplateResponse.Resource = resource;
        
			return getMonitoringTemplateResponse;
        }
    }
}
