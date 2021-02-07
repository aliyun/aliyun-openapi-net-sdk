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

			List<CreateStateConfigurationResponse.CreateStateConfiguration_StateConfigurationItem> createStateConfigurationResponse_stateConfiguration = new List<CreateStateConfigurationResponse.CreateStateConfiguration_StateConfigurationItem>();
			for (int i = 0; i < _ctx.Length("CreateStateConfiguration.StateConfiguration.Length"); i++) {
				CreateStateConfigurationResponse.CreateStateConfiguration_StateConfigurationItem stateConfigurationItem = new CreateStateConfigurationResponse.CreateStateConfiguration_StateConfigurationItem();
				stateConfigurationItem.CreateTime = _ctx.StringValue("CreateStateConfiguration.StateConfiguration["+ i +"].CreateTime");
				stateConfigurationItem.Description = _ctx.StringValue("CreateStateConfiguration.StateConfiguration["+ i +"].Description");
				stateConfigurationItem.StateConfigurationId = _ctx.StringValue("CreateStateConfiguration.StateConfiguration["+ i +"].StateConfigurationId");
				stateConfigurationItem.TemplateId = _ctx.StringValue("CreateStateConfiguration.StateConfiguration["+ i +"].TemplateId");
				stateConfigurationItem.TemplateName = _ctx.StringValue("CreateStateConfiguration.StateConfiguration["+ i +"].TemplateName");
				stateConfigurationItem.TemplateVersion = _ctx.StringValue("CreateStateConfiguration.StateConfiguration["+ i +"].TemplateVersion");
				stateConfigurationItem.Parameters = _ctx.StringValue("CreateStateConfiguration.StateConfiguration["+ i +"].Parameters");
				stateConfigurationItem.ConfigureMode = _ctx.StringValue("CreateStateConfiguration.StateConfiguration["+ i +"].ConfigureMode");
				stateConfigurationItem.ScheduleType = _ctx.StringValue("CreateStateConfiguration.StateConfiguration["+ i +"].ScheduleType");
				stateConfigurationItem.ScheduleExpression = _ctx.StringValue("CreateStateConfiguration.StateConfiguration["+ i +"].ScheduleExpression");
				stateConfigurationItem.Targets = _ctx.StringValue("CreateStateConfiguration.StateConfiguration["+ i +"].Targets");
				stateConfigurationItem.Tags = _ctx.StringValue("CreateStateConfiguration.StateConfiguration["+ i +"].Tags");

				createStateConfigurationResponse_stateConfiguration.Add(stateConfigurationItem);
			}
			createStateConfigurationResponse.StateConfiguration = createStateConfigurationResponse_stateConfiguration;
        
			return createStateConfigurationResponse;
        }
    }
}
