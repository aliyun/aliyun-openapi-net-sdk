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
			describeDnsGtmInstancesResponse.RequestId = _ctx.StringValue("DescribeDnsGtmInstances.RequestId");
			describeDnsGtmInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeDnsGtmInstances.PageNumber");
			describeDnsGtmInstancesResponse.PageSize = _ctx.IntegerValue("DescribeDnsGtmInstances.PageSize");
			describeDnsGtmInstancesResponse.TotalItems = _ctx.IntegerValue("DescribeDnsGtmInstances.TotalItems");
			describeDnsGtmInstancesResponse.TotalPages = _ctx.IntegerValue("DescribeDnsGtmInstances.TotalPages");

			List<DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance> describeDnsGtmInstancesResponse_gtmInstances = new List<DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmInstances.GtmInstances.Length"); i++) {
				DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance gtmInstance = new DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance();
				gtmInstance.InstanceId = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].InstanceId");
				gtmInstance.VersionCode = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].VersionCode");
				gtmInstance.SmsQuota = _ctx.IntegerValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].SmsQuota");
				gtmInstance.CreateTime = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].CreateTime");
				gtmInstance.CreateTimestamp = _ctx.LongValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].CreateTimestamp");
				gtmInstance.ExpireTime = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].ExpireTime");
				gtmInstance.ExpireTimestamp = _ctx.LongValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].ExpireTimestamp");
				gtmInstance.TaskQuota = _ctx.IntegerValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].TaskQuota");
				gtmInstance.ResourceGroupId = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].ResourceGroupId");
				gtmInstance.PaymentType = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].PaymentType");

				DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance.DescribeDnsGtmInstances_Config config = new DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance.DescribeDnsGtmInstances_Config();
				config.InstanceName = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.InstanceName");
				config.CnameType = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.CnameType");
				config.PublicUserDomainName = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.PublicUserDomainName");
				config.PublicCnameMode = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.PublicCnameMode");
				config.PublicZoneName = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.PublicZoneName");
				config.Ttl = _ctx.IntegerValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.Ttl");
				config.AlertGroup = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.AlertGroup");
				config.StrategyMode = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.StrategyMode");

				List<DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance.DescribeDnsGtmInstances_Config.DescribeDnsGtmInstances_AlertConfigItem> config_alertConfig = new List<DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance.DescribeDnsGtmInstances_Config.DescribeDnsGtmInstances_AlertConfigItem>();
				for (int j = 0; j < _ctx.Length("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.AlertConfig.Length"); j++) {
					DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance.DescribeDnsGtmInstances_Config.DescribeDnsGtmInstances_AlertConfigItem alertConfigItem = new DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance.DescribeDnsGtmInstances_Config.DescribeDnsGtmInstances_AlertConfigItem();
					alertConfigItem.NoticeType = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.AlertConfig["+ j +"].NoticeType");
					alertConfigItem.SmsNotice = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.AlertConfig["+ j +"].SmsNotice");
					alertConfigItem.EmailNotice = _ctx.StringValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].Config.AlertConfig["+ j +"].EmailNotice");

					config_alertConfig.Add(alertConfigItem);
				}
				config.AlertConfig = config_alertConfig;
				gtmInstance.Config = config;

				DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance.DescribeDnsGtmInstances_UsedQuota usedQuota = new DescribeDnsGtmInstancesResponse.DescribeDnsGtmInstances_GtmInstance.DescribeDnsGtmInstances_UsedQuota();
				usedQuota.TaskUsedCount = _ctx.IntegerValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].UsedQuota.TaskUsedCount");
				usedQuota.SmsUsedCount = _ctx.IntegerValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].UsedQuota.SmsUsedCount");
				usedQuota.EmailUsedCount = _ctx.IntegerValue("DescribeDnsGtmInstances.GtmInstances["+ i +"].UsedQuota.EmailUsedCount");
				gtmInstance.UsedQuota = usedQuota;

				describeDnsGtmInstancesResponse_gtmInstances.Add(gtmInstance);
			}
			describeDnsGtmInstancesResponse.GtmInstances = describeDnsGtmInstancesResponse_gtmInstances;
        
			return describeDnsGtmInstancesResponse;
        }
    }
}
