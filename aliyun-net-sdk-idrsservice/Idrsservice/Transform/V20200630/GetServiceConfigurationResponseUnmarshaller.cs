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
using Aliyun.Acs.idrsservice.Model.V20200630;

namespace Aliyun.Acs.idrsservice.Transform.V20200630
{
    public class GetServiceConfigurationResponseUnmarshaller
    {
        public static GetServiceConfigurationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetServiceConfigurationResponse getServiceConfigurationResponse = new GetServiceConfigurationResponse();

			getServiceConfigurationResponse.HttpResponse = _ctx.HttpResponse;
			getServiceConfigurationResponse.Code = _ctx.StringValue("GetServiceConfiguration.Code");
			getServiceConfigurationResponse.Message = _ctx.StringValue("GetServiceConfiguration.Message");
			getServiceConfigurationResponse.RequestId = _ctx.StringValue("GetServiceConfiguration.RequestId");

			GetServiceConfigurationResponse.GetServiceConfiguration_Data data = new GetServiceConfigurationResponse.GetServiceConfiguration_Data();
			data.ClientQueueSize = _ctx.IntegerValue("GetServiceConfiguration.Data.ClientQueueSize");
			data.LiveRecordAll = _ctx.BooleanValue("GetServiceConfiguration.Data.LiveRecordAll");
			data.LiveRecordEveryOne = _ctx.BooleanValue("GetServiceConfiguration.Data.LiveRecordEveryOne");
			data.LiveRecordLayout = _ctx.IntegerValue("GetServiceConfiguration.Data.LiveRecordLayout");
			data.LiveRecordTaskProfile = _ctx.StringValue("GetServiceConfiguration.Data.LiveRecordTaskProfile");
			data.TaskItemQueueSize = _ctx.IntegerValue("GetServiceConfiguration.Data.TaskItemQueueSize");
			data.LiveRecordMaxClient = _ctx.IntegerValue("GetServiceConfiguration.Data.LiveRecordMaxClient");
			data.LiveRecordVideoResolution = _ctx.IntegerValue("GetServiceConfiguration.Data.LiveRecordVideoResolution");
			getServiceConfigurationResponse.Data = data;
        
			return getServiceConfigurationResponse;
        }
    }
}
