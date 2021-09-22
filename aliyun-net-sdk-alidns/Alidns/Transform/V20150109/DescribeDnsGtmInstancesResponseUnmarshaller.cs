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
    public class DescribeDnsGtmInstancesResponseUnmarshaller
    {
        public static DescribeDnsGtmInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDnsGtmInstancesResponse describeDnsGtmInstancesResponse = new DescribeDnsGtmInstancesResponse();

			describeDnsGtmInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeDnsGtmInstancesResponse.PageSize = _ctx.IntegerValue("DescribeDnsGtmInstances.PageSize");
			describeDnsGtmInstancesResponse.RequestId = _ctx.StringValue("DescribeDnsGtmInstances.RequestId");
			describeDnsGtmInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeDnsGtmInstances.PageNumber");
			describeDnsGtmInstancesResponse.TotalPages = _ctx.IntegerValue("DescribeDnsGtmInstances.TotalPages");
			describeDnsGtmInstancesResponse.TotalItems = _ctx.IntegerValue("DescribeDnsGtmInstances.TotalItems");

			List<DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance> describeDnsGtmInstancesResponse_gtmInstances = new List<DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmInstances.GtmInstances.Length"); i++) {
				DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance gtmInstance = new DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance();
				gtmInstance.PaymentType = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].PaymentType");
				gtmInstance.ExpireTime = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].ExpireTime");
				gtmInstance.CreateTime = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].CreateTime");
				gtmInstance.SmsQuota = _ctx.IntegerValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].SmsQuota");
				gtmInstance.InstanceId = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].InstanceId");
				gtmInstance.ExpireTimestamp = _ctx.LongValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].ExpireTimestamp");
				gtmInstance.ResourceGroupId = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].ResourceGroupId");
				gtmInstance.VersionCode = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].VersionCode");
				gtmInstance.TaskQuota = _ctx.IntegerValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].TaskQuota");
				gtmInstance.CreateTimestamp = _ctx.LongValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].CreateTimestamp");

				DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance.DescribeDnsGtmInstances_Config config = new DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance.DescribeDnsGtmInstances_Config();
				config.Ttl = _ctx.IntegerValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.Ttl");
				config.AlertGroup = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.AlertGroup");
				config.PublicZoneName = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.PublicZoneName");
				config.CnameType = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.CnameType");
				config.StrategyMode = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.StrategyMode");
				config.InstanceName = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.InstanceName");
				config.PublicCnameMode = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.PublicCnameMode");
				config.PublicUserDomainName = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.PublicUserDomainName");
				config.PublicRr = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.PublicRr");

				List<DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance.DescribeDnsGtmInstances_Config.DescribeDnsGtmInstances_AlertConfigItem> config_alertConfig = new List<DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance.DescribeDnsGtmInstances_Config.DescribeDnsGtmInstances_AlertConfigItem>();
				for (int j = 0; j < _ctx.Length("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.AlertConfig.Length"); j++) {
					DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance.DescribeDnsGtmInstances_Config.DescribeDnsGtmInstances_AlertConfigItem alertConfigItem = new DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance.DescribeDnsGtmInstances_Config.DescribeDnsGtmInstances_AlertConfigItem();
					alertConfigItem.SmsNotice = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.AlertConfig["+ j +"].SmsNotice");
					alertConfigItem.NoticeType = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.AlertConfig["+ j +"].NoticeType");
					alertConfigItem.EmailNotice = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.AlertConfig["+ j +"].EmailNotice");
					alertConfigItem.DingtalkNotice = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.AlertConfig["+ j +"].DingtalkNotice");

					config_alertConfig.Add(alertConfigItem);
				}
				config.AlertConfig = config_alertConfig;
				gtmInstance.Config = config;

				DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance.DescribeDnsGtmInstances_UsedQuota usedQuota = new DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance.DescribeDnsGtmInstances_UsedQuota();
				usedQuota.EmailUsedCount = _ctx.IntegerValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].UsedQuota.EmailUsedCount");
				usedQuota.TaskUsedCount = _ctx.IntegerValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].UsedQuota.TaskUsedCount");
				usedQuota.SmsUsedCount = _ctx.IntegerValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].UsedQuota.SmsUsedCount");
				usedQuota.DingtalkUsedCount = _ctx.IntegerValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].UsedQuota.DingtalkUsedCount");
				gtmInstance.UsedQuota = usedQuota;

				describeDnsGtmInstancesResponse_gtmInstances.Add(gtmInstance);
			}
			describeDnsGtmInstancesResponse.GtmInstances = describeDnsGtmInstancesResponse_gtmInstances;
        
			return describeDnsGtmInstancesResponse;
        }
    }
}
