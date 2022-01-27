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
    public class GetSlrConfigurationResponseUnmarshaller
    {
        public static GetSlrConfigurationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSlrConfigurationResponse getSlrConfigurationResponse = new GetSlrConfigurationResponse();

			getSlrConfigurationResponse.HttpResponse = _ctx.HttpResponse;
			getSlrConfigurationResponse.Code = _ctx.StringValue("GetSlrConfiguration.Code");
			getSlrConfigurationResponse.Message = _ctx.StringValue("GetSlrConfiguration.Message");
			getSlrConfigurationResponse.RequestId = _ctx.StringValue("GetSlrConfiguration.RequestId");

			GetSlrConfigurationResponse.GetSlrConfiguration_Data data = new GetSlrConfigurationResponse.GetSlrConfiguration_Data();
			data.MqSubscribe = _ctx.BooleanValue("GetSlrConfiguration.Data.MqSubscribe");
			data.MqEndpoint = _ctx.StringValue("GetSlrConfiguration.Data.MqEndpoint");
			data.MqInstanceId = _ctx.StringValue("GetSlrConfiguration.Data.MqInstanceId");
			data.MqTopic = _ctx.StringValue("GetSlrConfiguration.Data.MqTopic");
			data.MqGroupId = _ctx.StringValue("GetSlrConfiguration.Data.MqGroupId");

			List<string> data_mqEventList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetSlrConfiguration.Data.MqEventList.Length"); i++) {
				data_mqEventList.Add(_ctx.StringValue("GetSlrConfiguration.Data.MqEventList["+ i +"]"));
			}
			data.MqEventList = data_mqEventList;
			getSlrConfigurationResponse.Data = data;
        
			return getSlrConfigurationResponse;
        }
    }
}
