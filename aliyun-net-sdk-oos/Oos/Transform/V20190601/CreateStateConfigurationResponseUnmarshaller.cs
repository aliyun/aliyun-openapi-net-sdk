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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class CreateStateConfigurationResponseUnmarshaller
    {
        public static CreateStateConfigurationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateStateConfigurationResponse createStateConfigurationResponse = new CreateStateConfigurationResponse();

			createStateConfigurationResponse.HttpResponse = _ctx.HttpResponse;
			createStateConfigurationResponse.RequestId = _ctx.StringValue("CreateStateConfiguration.RequestId");

			CreateStateConfigurationResponse.CreateStateConfiguration_StateConfiguration stateConfiguration = new CreateStateConfigurationResponse.CreateStateConfiguration_StateConfiguration();
			stateConfiguration.CreateTime = _ctx.StringValue("CreateStateConfiguration.StateConfiguration.CreateTime");
			stateConfiguration.Description = _ctx.StringValue("CreateStateConfiguration.StateConfiguration.Description");
			stateConfiguration.StateConfigurationId = _ctx.StringValue("CreateStateConfiguration.StateConfiguration.StateConfigurationId");
			stateConfiguration.TemplateId = _ctx.StringValue("CreateStateConfiguration.StateConfiguration.TemplateId");
			stateConfiguration.TemplateName = _ctx.StringValue("CreateStateConfiguration.StateConfiguration.TemplateName");
			stateConfiguration.TemplateVersion = _ctx.StringValue("CreateStateConfiguration.StateConfiguration.TemplateVersion");
			stateConfiguration.Parameters = _ctx.StringValue("CreateStateConfiguration.StateConfiguration.Parameters");
			stateConfiguration.ConfigureMode = _ctx.StringValue("CreateStateConfiguration.StateConfiguration.ConfigureMode");
			stateConfiguration.ScheduleType = _ctx.StringValue("CreateStateConfiguration.StateConfiguration.ScheduleType");
			stateConfiguration.ScheduleExpression = _ctx.StringValue("CreateStateConfiguration.StateConfiguration.ScheduleExpression");
			stateConfiguration.Targets = _ctx.StringValue("CreateStateConfiguration.StateConfiguration.Targets");
			stateConfiguration.Tags = _ctx.StringValue("CreateStateConfiguration.StateConfiguration.Tags");
			createStateConfigurationResponse.StateConfiguration = stateConfiguration;
        
			return createStateConfigurationResponse;
        }
    }
}
