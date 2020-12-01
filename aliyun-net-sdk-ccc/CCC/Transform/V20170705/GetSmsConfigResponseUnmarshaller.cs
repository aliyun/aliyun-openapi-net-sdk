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
        public static GetSmsConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSmsConfigResponse getSmsConfigResponse = new GetSmsConfigResponse();

			getSmsConfigResponse.HttpResponse = _ctx.HttpResponse;
			getSmsConfigResponse.RequestId = _ctx.StringValue("GetSmsConfig.RequestId");
			getSmsConfigResponse.Success = _ctx.BooleanValue("GetSmsConfig.Success");
			getSmsConfigResponse.Code = _ctx.StringValue("GetSmsConfig.Code");
			getSmsConfigResponse.Message = _ctx.StringValue("GetSmsConfig.Message");
			getSmsConfigResponse.HttpStatusCode = _ctx.IntegerValue("GetSmsConfig.HttpStatusCode");

			List<GetSmsConfigResponse.GetSmsConfig_SmsConfig> getSmsConfigResponse_smsConfigs = new List<GetSmsConfigResponse.GetSmsConfig_SmsConfig>();
			for (int i = 0; i < _ctx.Length("GetSmsConfig.SmsConfigs.Length"); i++) {
				GetSmsConfigResponse.GetSmsConfig_SmsConfig smsConfig = new GetSmsConfigResponse.GetSmsConfig_SmsConfig();
				smsConfig.Id = _ctx.LongValue("GetSmsConfig.SmsConfigs["+ i +"].Id");
				smsConfig.Instance = _ctx.StringValue("GetSmsConfig.SmsConfigs["+ i +"].Instance");
				smsConfig.SignName = _ctx.StringValue("GetSmsConfig.SmsConfigs["+ i +"].SignName");
				smsConfig.TemplateCode = _ctx.StringValue("GetSmsConfig.SmsConfigs["+ i +"].TemplateCode");
				smsConfig.Scenario = _ctx.IntegerValue("GetSmsConfig.SmsConfigs["+ i +"].Scenario");
				smsConfig.Name = _ctx.StringValue("GetSmsConfig.SmsConfigs["+ i +"].Name");
				smsConfig.Description = _ctx.StringValue("GetSmsConfig.SmsConfigs["+ i +"].Description");
				smsConfig.Extra = _ctx.StringValue("GetSmsConfig.SmsConfigs["+ i +"].Extra");
				smsConfig.GmtCreate = _ctx.StringValue("GetSmsConfig.SmsConfigs["+ i +"].GmtCreate");
				smsConfig.GmtModified = _ctx.StringValue("GetSmsConfig.SmsConfigs["+ i +"].GmtModified");

				getSmsConfigResponse_smsConfigs.Add(smsConfig);
			}
			getSmsConfigResponse.SmsConfigs = getSmsConfigResponse_smsConfigs;
        
			return getSmsConfigResponse;
        }
    }
}
