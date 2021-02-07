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
    public class UpdateStateConfigurationResponseUnmarshaller
    {
        public static UpdateStateConfigurationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateStateConfigurationResponse updateStateConfigurationResponse = new UpdateStateConfigurationResponse();

			updateStateConfigurationResponse.HttpResponse = _ctx.HttpResponse;
			updateStateConfigurationResponse.RequestId = _ctx.StringValue("UpdateStateConfiguration.RequestId");

			List<UpdateStateConfigurationResponse.UpdateStateConfiguration_StateConfigurationItem> updateStateConfigurationResponse_stateConfiguration = new List<UpdateStateConfigurationResponse.UpdateStateConfiguration_StateConfigurationItem>();
			for (int i = 0; i < _ctx.Length("UpdateStateConfiguration.StateConfiguration.Length"); i++) {
				UpdateStateConfigurationResponse.UpdateStateConfiguration_StateConfigurationItem stateConfigurationItem = new UpdateStateConfigurationResponse.UpdateStateConfiguration_StateConfigurationItem();
				stateConfigurationItem.CreateTime = _ctx.StringValue("UpdateStateConfiguration.StateConfiguration["+ i +"].CreateTime");
				stateConfigurationItem.Description = _ctx.StringValue("UpdateStateConfiguration.StateConfiguration["+ i +"].Description");
				stateConfigurationItem.StateConfigurationId = _ctx.StringValue("UpdateStateConfiguration.StateConfiguration["+ i +"].StateConfigurationId");
				stateConfigurationItem.TemplateId = _ctx.StringValue("UpdateStateConfiguration.StateConfiguration["+ i +"].TemplateId");
				stateConfigurationItem.TemplateName = _ctx.StringValue("UpdateStateConfiguration.StateConfiguration["+ i +"].TemplateName");
				stateConfigurationItem.TemplateVersion = _ctx.StringValue("UpdateStateConfiguration.StateConfiguration["+ i +"].TemplateVersion");
				stateConfigurationItem.Parameters = _ctx.StringValue("UpdateStateConfiguration.StateConfiguration["+ i +"].Parameters");
				stateConfigurationItem.ConfigureMode = _ctx.StringValue("UpdateStateConfiguration.StateConfiguration["+ i +"].ConfigureMode");
				stateConfigurationItem.ScheduleType = _ctx.StringValue("UpdateStateConfiguration.StateConfiguration["+ i +"].ScheduleType");
				stateConfigurationItem.ScheduleExpression = _ctx.StringValue("UpdateStateConfiguration.StateConfiguration["+ i +"].ScheduleExpression");
				stateConfigurationItem.Targets = _ctx.StringValue("UpdateStateConfiguration.StateConfiguration["+ i +"].Targets");
				stateConfigurationItem.UpdateTime = _ctx.StringValue("UpdateStateConfiguration.StateConfiguration["+ i +"].UpdateTime");
				stateConfigurationItem.Tags = _ctx.StringValue("UpdateStateConfiguration.StateConfiguration["+ i +"].Tags");

				updateStateConfigurationResponse_stateConfiguration.Add(stateConfigurationItem);
			}
			updateStateConfigurationResponse.StateConfiguration = updateStateConfigurationResponse_stateConfiguration;
        
			return updateStateConfigurationResponse;
        }
    }
}
