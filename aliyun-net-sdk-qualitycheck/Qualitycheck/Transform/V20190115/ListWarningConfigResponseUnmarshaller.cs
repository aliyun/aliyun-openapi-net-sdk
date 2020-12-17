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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class ListWarningConfigResponseUnmarshaller
    {
        public static ListWarningConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListWarningConfigResponse listWarningConfigResponse = new ListWarningConfigResponse();

			listWarningConfigResponse.HttpResponse = _ctx.HttpResponse;
			listWarningConfigResponse.RequestId = _ctx.StringValue("ListWarningConfig.RequestId");
			listWarningConfigResponse.Success = _ctx.BooleanValue("ListWarningConfig.Success");
			listWarningConfigResponse.Code = _ctx.StringValue("ListWarningConfig.Code");
			listWarningConfigResponse.Message = _ctx.StringValue("ListWarningConfig.Message");

			List<ListWarningConfigResponse.ListWarningConfig_WarningConfigInfo> listWarningConfigResponse_data = new List<ListWarningConfigResponse.ListWarningConfig_WarningConfigInfo>();
			for (int i = 0; i < _ctx.Length("ListWarningConfig.Data.Length"); i++) {
				ListWarningConfigResponse.ListWarningConfig_WarningConfigInfo warningConfigInfo = new ListWarningConfigResponse.ListWarningConfig_WarningConfigInfo();
				warningConfigInfo.ConfigId = _ctx.LongValue("ListWarningConfig.Data["+ i +"].ConfigId");
				warningConfigInfo.ConfigName = _ctx.StringValue("ListWarningConfig.Data["+ i +"].ConfigName");
				warningConfigInfo.Status = _ctx.IntegerValue("ListWarningConfig.Data["+ i +"].Status");
				warningConfigInfo.CreateTime = _ctx.StringValue("ListWarningConfig.Data["+ i +"].CreateTime");
				warningConfigInfo.UpdateTime = _ctx.StringValue("ListWarningConfig.Data["+ i +"].UpdateTime");

				List<string> warningConfigInfo_ridList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListWarningConfig.Data["+ i +"].RidList.Length"); j++) {
					warningConfigInfo_ridList.Add(_ctx.StringValue("ListWarningConfig.Data["+ i +"].RidList["+ j +"]"));
				}
				warningConfigInfo.RidList = warningConfigInfo_ridList;

				List<ListWarningConfigResponse.ListWarningConfig_WarningConfigInfo.ListWarningConfig_WarningRule> warningConfigInfo_ruleList = new List<ListWarningConfigResponse.ListWarningConfig_WarningConfigInfo.ListWarningConfig_WarningRule>();
				for (int j = 0; j < _ctx.Length("ListWarningConfig.Data["+ i +"].RuleList.Length"); j++) {
					ListWarningConfigResponse.ListWarningConfig_WarningConfigInfo.ListWarningConfig_WarningRule warningRule = new ListWarningConfigResponse.ListWarningConfig_WarningConfigInfo.ListWarningConfig_WarningRule();
					warningRule.Rid = _ctx.LongValue("ListWarningConfig.Data["+ i +"].RuleList["+ j +"].Rid");
					warningRule.RuleName = _ctx.StringValue("ListWarningConfig.Data["+ i +"].RuleList["+ j +"].RuleName");

					warningConfigInfo_ruleList.Add(warningRule);
				}
				warningConfigInfo.RuleList = warningConfigInfo_ruleList;

				List<ListWarningConfigResponse.ListWarningConfig_WarningConfigInfo.ListWarningConfig_Channel> warningConfigInfo_channels = new List<ListWarningConfigResponse.ListWarningConfig_WarningConfigInfo.ListWarningConfig_Channel>();
				for (int j = 0; j < _ctx.Length("ListWarningConfig.Data["+ i +"].Channels.Length"); j++) {
					ListWarningConfigResponse.ListWarningConfig_WarningConfigInfo.ListWarningConfig_Channel channel = new ListWarningConfigResponse.ListWarningConfig_WarningConfigInfo.ListWarningConfig_Channel();
					channel.Type = _ctx.IntegerValue("ListWarningConfig.Data["+ i +"].Channels["+ j +"].Type");
					channel.Url = _ctx.StringValue("ListWarningConfig.Data["+ i +"].Channels["+ j +"].Url");

					warningConfigInfo_channels.Add(channel);
				}
				warningConfigInfo.Channels = warningConfigInfo_channels;

				listWarningConfigResponse_data.Add(warningConfigInfo);
			}
			listWarningConfigResponse.Data = listWarningConfigResponse_data;
        
			return listWarningConfigResponse;
        }
    }
}
