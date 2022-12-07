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
using Aliyun.Acs.alikafka.Model.V20190916;

namespace Aliyun.Acs.alikafka.Transform.V20190916
{
    public class GetQuotaTipResponseUnmarshaller
    {
        public static GetQuotaTipResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetQuotaTipResponse getQuotaTipResponse = new GetQuotaTipResponse();

			getQuotaTipResponse.HttpResponse = _ctx.HttpResponse;
			getQuotaTipResponse.Code = _ctx.IntegerValue("GetQuotaTip.Code");
			getQuotaTipResponse.Message = _ctx.StringValue("GetQuotaTip.Message");
			getQuotaTipResponse.RequestId = _ctx.StringValue("GetQuotaTip.RequestId");
			getQuotaTipResponse.Success = _ctx.BooleanValue("GetQuotaTip.Success");

			GetQuotaTipResponse.GetQuotaTip_QuotaData quotaData = new GetQuotaTipResponse.GetQuotaTip_QuotaData();
			quotaData.TopicNumOfBuy = _ctx.IntegerValue("GetQuotaTip.QuotaData.TopicNumOfBuy");
			quotaData.TopicQuota = _ctx.IntegerValue("GetQuotaTip.QuotaData.TopicQuota");
			quotaData.TopicLeft = _ctx.IntegerValue("GetQuotaTip.QuotaData.TopicLeft");
			quotaData.TopicUsed = _ctx.IntegerValue("GetQuotaTip.QuotaData.TopicUsed");
			quotaData.PartitionNumOfBuy = _ctx.IntegerValue("GetQuotaTip.QuotaData.PartitionNumOfBuy");
			quotaData.PartitionQuata = _ctx.IntegerValue("GetQuotaTip.QuotaData.PartitionQuata");
			quotaData.PartitionLeft = _ctx.IntegerValue("GetQuotaTip.QuotaData.PartitionLeft");
			quotaData.PartitionUsed = _ctx.IntegerValue("GetQuotaTip.QuotaData.PartitionUsed");
			quotaData.GroupLeft = _ctx.IntegerValue("GetQuotaTip.QuotaData.GroupLeft");
			quotaData.GroupUsed = _ctx.IntegerValue("GetQuotaTip.QuotaData.GroupUsed");
			quotaData.IsPartitionBuy = _ctx.IntegerValue("GetQuotaTip.QuotaData.IsPartitionBuy");
			getQuotaTipResponse.QuotaData = quotaData;
        
			return getQuotaTipResponse;
        }
    }
}
