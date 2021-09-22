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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeDnsGtmInstanceResponseUnmarshaller
    {
        public static DescribeDnsGtmInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDnsGtmInstanceResponse describeDnsGtmInstanceResponse = new DescribeDnsGtmInstanceResponse();

			describeDnsGtmInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeDnsGtmInstanceResponse.ExpireTimestamp = _ctx.LongValue("DescribeDnsGtmInstance.ExpireTimestamp");
			describeDnsGtmInstanceResponse.RequestId = _ctx.StringValue("DescribeDnsGtmInstance.RequestId");
			describeDnsGtmInstanceResponse.ResourceGroupId = _ctx.StringValue("DescribeDnsGtmInstance.ResourceGroupId");
			describeDnsGtmInstanceResponse.InstanceId = _ctx.StringValue("DescribeDnsGtmInstance.InstanceId");
			describeDnsGtmInstanceResponse.TaskQuota = _ctx.IntegerValue("DescribeDnsGtmInstance.TaskQuota");
			describeDnsGtmInstanceResponse.CreateTime = _ctx.StringValue("DescribeDnsGtmInstance.CreateTime");
			describeDnsGtmInstanceResponse.SmsQuota = _ctx.IntegerValue("DescribeDnsGtmInstance.SmsQuota");
			describeDnsGtmInstanceResponse.VersionCode = _ctx.StringValue("DescribeDnsGtmInstance.VersionCode");
			describeDnsGtmInstanceResponse.PaymentType = _ctx.StringValue("DescribeDnsGtmInstance.PaymentType");
			describeDnsGtmInstanceResponse.ExpireTime = _ctx.StringValue("DescribeDnsGtmInstance.ExpireTime");
			describeDnsGtmInstanceResponse.CreateTimestamp = _ctx.LongValue("DescribeDnsGtmInstance.CreateTimestamp");

			DescribeDnsGtmInstanceResponse.DescribeDnsGtmInstance_Config config = new DescribeDnsGtmInstanceResponse.DescribeDnsGtmInstance_Config();
			config.Ttl = _ctx.IntegerValue("DescribeDnsGtmInstance.Config.Ttl");
			config.AlertGroup = _ctx.StringValue("DescribeDnsGtmInstance.Config.AlertGroup");
			config.CnameType = _ctx.StringValue("DescribeDnsGtmInstance.Config.CnameType");
			config.StrategyMode = _ctx.StringValue("DescribeDnsGtmInstance.Config.StrategyMode");
			config.InstanceName = _ctx.StringValue("DescribeDnsGtmInstance.Config.InstanceName");
			config.PublicCnameMode = _ctx.StringValue("DescribeDnsGtmInstance.Config.PublicCnameMode");
			config.PublicUserDomainName = _ctx.StringValue("DescribeDnsGtmInstance.Config.PublicUserDomainName");
			config.PubicZoneName = _ctx.StringValue("DescribeDnsGtmInstance.Config.PubicZoneName");
			config.PublicRr = _ctx.StringValue("DescribeDnsGtmInstance.Config.PublicRr");

			List<DescribeDnsGtmInstanceResponse.DescribeDnsGtmInstance_Config.DescribeDnsGtmInstance_AlertConfigItem> config_alertConfig = new List<DescribeDnsGtmInstanceResponse.DescribeDnsGtmInstance_Config.DescribeDnsGtmInstance_AlertConfigItem>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmInstance.Config.AlertConfig.Length"); i++) {
				DescribeDnsGtmInstanceResponse.DescribeDnsGtmInstance_Config.DescribeDnsGtmInstance_AlertConfigItem alertConfigItem = new DescribeDnsGtmInstanceResponse.DescribeDnsGtmInstance_Config.DescribeDnsGtmInstance_AlertConfigItem();
				alertConfigItem.SmsNotice = _ctx.BooleanValue("DescribeDnsGtmInstance.Config.AlertConfig["+ i +"].SmsNotice");
				alertConfigItem.NoticeType = _ctx.StringValue("DescribeDnsGtmInstance.Config.AlertConfig["+ i +"].NoticeType");
				alertConfigItem.EmailNotice = _ctx.BooleanValue("DescribeDnsGtmInstance.Config.AlertConfig["+ i +"].EmailNotice");
				alertConfigItem.DingtalkNotice = _ctx.BooleanValue("DescribeDnsGtmInstance.Config.AlertConfig["+ i +"].DingtalkNotice");

				config_alertConfig.Add(alertConfigItem);
			}
			config.AlertConfig = config_alertConfig;
			describeDnsGtmInstanceResponse.Config = config;

			DescribeDnsGtmInstanceResponse.DescribeDnsGtmInstance_UsedQuota usedQuota = new DescribeDnsGtmInstanceResponse.DescribeDnsGtmInstance_UsedQuota();
			usedQuota.EmailUsedCount = _ctx.IntegerValue("DescribeDnsGtmInstance.UsedQuota.EmailUsedCount");
			usedQuota.TaskUsedCount = _ctx.IntegerValue("DescribeDnsGtmInstance.UsedQuota.TaskUsedCount");
			usedQuota.SmsUsedCount = _ctx.IntegerValue("DescribeDnsGtmInstance.UsedQuota.SmsUsedCount");
			usedQuota.DingtalkUsedCount = _ctx.IntegerValue("DescribeDnsGtmInstance.UsedQuota.DingtalkUsedCount");
			describeDnsGtmInstanceResponse.UsedQuota = usedQuota;
        
			return describeDnsGtmInstanceResponse;
        }
    }
}
