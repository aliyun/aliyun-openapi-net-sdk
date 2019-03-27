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
    public class GetSmsConfigResponseUnmarshaller
    {
        public static GetSmsConfigResponse Unmarshall(UnmarshallerContext context)
        {
			GetSmsConfigResponse getSmsConfigResponse = new GetSmsConfigResponse();

			getSmsConfigResponse.HttpResponse = context.HttpResponse;
			getSmsConfigResponse.RequestId = context.StringValue("GetSmsConfig.RequestId");
			getSmsConfigResponse.Success = context.BooleanValue("GetSmsConfig.Success");
			getSmsConfigResponse.Code = context.StringValue("GetSmsConfig.Code");
			getSmsConfigResponse.Message = context.StringValue("GetSmsConfig.Message");
			getSmsConfigResponse.HttpStatusCode = context.IntegerValue("GetSmsConfig.HttpStatusCode");

			List<GetSmsConfigResponse.GetSmsConfig_SmsConfig> getSmsConfigResponse_smsConfigs = new List<GetSmsConfigResponse.GetSmsConfig_SmsConfig>();
			for (int i = 0; i < context.Length("GetSmsConfig.SmsConfigs.Length"); i++) {
				GetSmsConfigResponse.GetSmsConfig_SmsConfig smsConfig = new GetSmsConfigResponse.GetSmsConfig_SmsConfig();
				smsConfig.Id = context.LongValue("GetSmsConfig.SmsConfigs["+ i +"].Id");
				smsConfig.Instance = context.StringValue("GetSmsConfig.SmsConfigs["+ i +"].Instance");
				smsConfig.SignName = context.StringValue("GetSmsConfig.SmsConfigs["+ i +"].SignName");
				smsConfig.TemplateCode = context.StringValue("GetSmsConfig.SmsConfigs["+ i +"].TemplateCode");
				smsConfig.Scenario = context.IntegerValue("GetSmsConfig.SmsConfigs["+ i +"].Scenario");
				smsConfig.Name = context.StringValue("GetSmsConfig.SmsConfigs["+ i +"].Name");
				smsConfig.Description = context.StringValue("GetSmsConfig.SmsConfigs["+ i +"].Description");
				smsConfig.Extra = context.StringValue("GetSmsConfig.SmsConfigs["+ i +"].Extra");
				smsConfig.GmtCreate = context.StringValue("GetSmsConfig.SmsConfigs["+ i +"].GmtCreate");
				smsConfig.GmtModified = context.StringValue("GetSmsConfig.SmsConfigs["+ i +"].GmtModified");

				getSmsConfigResponse_smsConfigs.Add(smsConfig);
			}
			getSmsConfigResponse.SmsConfigs = getSmsConfigResponse_smsConfigs;
        
			return getSmsConfigResponse;
        }
    }
}
