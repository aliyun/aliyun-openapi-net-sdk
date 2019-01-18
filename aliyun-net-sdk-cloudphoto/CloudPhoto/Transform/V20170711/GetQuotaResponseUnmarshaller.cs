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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CloudPhoto.Model.V20170711;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class GetQuotaResponseUnmarshaller
    {
        public static GetQuotaResponse Unmarshall(UnmarshallerContext context)
        {
			GetQuotaResponse getQuotaResponse = new GetQuotaResponse();

			getQuotaResponse.HttpResponse = context.HttpResponse;
			getQuotaResponse.Code = context.StringValue("GetQuota.Code");
			getQuotaResponse.Message = context.StringValue("GetQuota.Message");
			getQuotaResponse.RequestId = context.StringValue("GetQuota.RequestId");
			getQuotaResponse.Action = context.StringValue("GetQuota.Action");

			GetQuotaResponse.GetQuota_Quota quota = new GetQuotaResponse.GetQuota_Quota();
			quota.TotalQuota = context.LongValue("GetQuota.Quota.TotalQuota");
			quota.FacesCount = context.IntegerValue("GetQuota.Quota.FacesCount");
			quota.PhotosCount = context.IntegerValue("GetQuota.Quota.PhotosCount");
			quota.UsedQuota = context.LongValue("GetQuota.Quota.UsedQuota");
			quota.VideosCount = context.IntegerValue("GetQuota.Quota.VideosCount");
			getQuotaResponse.Quota = quota;
        
			return getQuotaResponse;
        }
    }
}