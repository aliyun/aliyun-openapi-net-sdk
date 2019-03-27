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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class GetConfigResponseUnmarshaller
    {
        public static GetConfigResponse Unmarshall(UnmarshallerContext context)
        {
			GetConfigResponse getConfigResponse = new GetConfigResponse();

			getConfigResponse.HttpResponse = context.HttpResponse;
			getConfigResponse.RequestId = context.StringValue("GetConfig.RequestId");
			getConfigResponse.Success = context.BooleanValue("GetConfig.Success");
			getConfigResponse.Code = context.StringValue("GetConfig.Code");
			getConfigResponse.Message = context.StringValue("GetConfig.Message");
			getConfigResponse.HttpStatusCode = context.IntegerValue("GetConfig.HttpStatusCode");

			GetConfigResponse.GetConfig_ConfigItem configItem = new GetConfigResponse.GetConfig_ConfigItem();
			configItem.Name = context.StringValue("GetConfig.ConfigItem.Name");
			configItem._Value = context.StringValue("GetConfig.ConfigItem.Value");
			getConfigResponse.ConfigItem = configItem;
        
			return getConfigResponse;
        }
    }
}
