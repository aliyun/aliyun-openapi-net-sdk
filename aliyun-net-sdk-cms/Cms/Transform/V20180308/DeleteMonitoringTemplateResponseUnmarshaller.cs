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
    public class DeleteMonitoringTemplateResponseUnmarshaller
    {
        public static DeleteMonitoringTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteMonitoringTemplateResponse deleteMonitoringTemplateResponse = new DeleteMonitoringTemplateResponse();

			deleteMonitoringTemplateResponse.HttpResponse = context.HttpResponse;
			deleteMonitoringTemplateResponse.RequestId = context.StringValue("DeleteMonitoringTemplate.RequestId");
			deleteMonitoringTemplateResponse.Success = context.BooleanValue("DeleteMonitoringTemplate.Success");
			deleteMonitoringTemplateResponse.ErrorCode = context.IntegerValue("DeleteMonitoringTemplate.ErrorCode");
			deleteMonitoringTemplateResponse.ErrorMessage = context.StringValue("DeleteMonitoringTemplate.ErrorMessage");

			DeleteMonitoringTemplateResponse.DeleteMonitoringTemplate_Resource resource = new DeleteMonitoringTemplateResponse.DeleteMonitoringTemplate_Resource();
			resource.Name = context.StringValue("DeleteMonitoringTemplate.Resource.Name");
			resource.Id = context.StringValue("DeleteMonitoringTemplate.Resource.Id");
			resource.RestVersion = context.StringValue("DeleteMonitoringTemplate.Resource.RestVersion");
			resource._Namespace = context.StringValue("DeleteMonitoringTemplate.Resource.Namespace");
			resource.Description = context.StringValue("DeleteMonitoringTemplate.Resource.Description");
			resource.AlertTemplatesJson = context.StringValue("DeleteMonitoringTemplate.Resource.AlertTemplatesJson");
			resource.EventRuleTemplatesJson = context.StringValue("DeleteMonitoringTemplate.Resource.EventRuleTemplatesJson");
			deleteMonitoringTemplateResponse.Resource = resource;
        
			return deleteMonitoringTemplateResponse;
        }
    }
}
