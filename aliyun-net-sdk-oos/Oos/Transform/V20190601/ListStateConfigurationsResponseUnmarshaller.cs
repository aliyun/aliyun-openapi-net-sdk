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
    public class ListStateConfigurationsResponseUnmarshaller
    {
        public static ListStateConfigurationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListStateConfigurationsResponse listStateConfigurationsResponse = new ListStateConfigurationsResponse();

			listStateConfigurationsResponse.HttpResponse = _ctx.HttpResponse;
			listStateConfigurationsResponse.RequestId = _ctx.StringValue("ListStateConfigurations.RequestId");

			List<ListStateConfigurationsResponse.ListStateConfigurations_StateConfiguration> listStateConfigurationsResponse_stateConfigurations = new List<ListStateConfigurationsResponse.ListStateConfigurations_StateConfiguration>();
			for (int i = 0; i < _ctx.Length("ListStateConfigurations.StateConfigurations.Length"); i++) {
				ListStateConfigurationsResponse.ListStateConfigurations_StateConfiguration stateConfiguration = new ListStateConfigurationsResponse.ListStateConfigurations_StateConfiguration();
				stateConfiguration.CreateTime = _ctx.StringValue("ListStateConfigurations.StateConfigurations["+ i +"].CreateTime");
				stateConfiguration.Description = _ctx.StringValue("ListStateConfigurations.StateConfigurations["+ i +"].Description");
				stateConfiguration.StateConfigurationId = _ctx.StringValue("ListStateConfigurations.StateConfigurations["+ i +"].StateConfigurationId");
				stateConfiguration.TemplateId = _ctx.StringValue("ListStateConfigurations.StateConfigurations["+ i +"].TemplateId");
				stateConfiguration.TemplateName = _ctx.StringValue("ListStateConfigurations.StateConfigurations["+ i +"].TemplateName");
				stateConfiguration.TemplateVersion = _ctx.StringValue("ListStateConfigurations.StateConfigurations["+ i +"].TemplateVersion");
				stateConfiguration.Parameters = _ctx.StringValue("ListStateConfigurations.StateConfigurations["+ i +"].Parameters");
				stateConfiguration.ConfigureMode = _ctx.StringValue("ListStateConfigurations.StateConfigurations["+ i +"].ConfigureMode");
				stateConfiguration.ScheduleType = _ctx.StringValue("ListStateConfigurations.StateConfigurations["+ i +"].ScheduleType");
				stateConfiguration.ScheduleExpression = _ctx.StringValue("ListStateConfigurations.StateConfigurations["+ i +"].ScheduleExpression");
				stateConfiguration.Targets = _ctx.StringValue("ListStateConfigurations.StateConfigurations["+ i +"].Targets");
				stateConfiguration.UpdateTime = _ctx.StringValue("ListStateConfigurations.StateConfigurations["+ i +"].UpdateTime");
				stateConfiguration.Tags = _ctx.StringValue("ListStateConfigurations.StateConfigurations["+ i +"].Tags");

				listStateConfigurationsResponse_stateConfigurations.Add(stateConfiguration);
			}
			listStateConfigurationsResponse.StateConfigurations = listStateConfigurationsResponse_stateConfigurations;
        
			return listStateConfigurationsResponse;
        }
    }
}
