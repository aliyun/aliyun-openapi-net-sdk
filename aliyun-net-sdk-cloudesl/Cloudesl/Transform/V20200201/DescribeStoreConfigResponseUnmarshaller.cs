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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribeStoreConfigResponseUnmarshaller
    {
        public static DescribeStoreConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStoreConfigResponse describeStoreConfigResponse = new DescribeStoreConfigResponse();

			describeStoreConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeStoreConfigResponse.RequestId = _ctx.StringValue("DescribeStoreConfig.RequestId");
			describeStoreConfigResponse.ErrorMessage = _ctx.StringValue("DescribeStoreConfig.ErrorMessage");
			describeStoreConfigResponse.Success = _ctx.BooleanValue("DescribeStoreConfig.Success");
			describeStoreConfigResponse.ErrorCode = _ctx.StringValue("DescribeStoreConfig.ErrorCode");
			describeStoreConfigResponse.Code = _ctx.StringValue("DescribeStoreConfig.Code");
			describeStoreConfigResponse.Message = _ctx.StringValue("DescribeStoreConfig.Message");
			describeStoreConfigResponse.DynamicMessage = _ctx.StringValue("DescribeStoreConfig.DynamicMessage");
			describeStoreConfigResponse.DynamicCode = _ctx.StringValue("DescribeStoreConfig.DynamicCode");

			DescribeStoreConfigResponse.DescribeStoreConfig_StoreConfigInfo storeConfigInfo = new DescribeStoreConfigResponse.DescribeStoreConfig_StoreConfigInfo();
			storeConfigInfo.StoreId = _ctx.StringValue("DescribeStoreConfig.StoreConfigInfo.StoreId");
			storeConfigInfo.EnableNotification = _ctx.BooleanValue("DescribeStoreConfig.StoreConfigInfo.EnableNotification");
			storeConfigInfo.NotificationWebHook = _ctx.StringValue("DescribeStoreConfig.StoreConfigInfo.NotificationWebHook");
			storeConfigInfo.NotificationSilentTimes = _ctx.StringValue("DescribeStoreConfig.StoreConfigInfo.NotificationSilentTimes");

			List<DescribeStoreConfigResponse.DescribeStoreConfig_StoreConfigInfo.DescribeStoreConfig_SubscribeContent> storeConfigInfo_subscribeContents = new List<DescribeStoreConfigResponse.DescribeStoreConfig_StoreConfigInfo.DescribeStoreConfig_SubscribeContent>();
			for (int i = 0; i < _ctx.Length("DescribeStoreConfig.StoreConfigInfo.SubscribeContents.Length"); i++) {
				DescribeStoreConfigResponse.DescribeStoreConfig_StoreConfigInfo.DescribeStoreConfig_SubscribeContent subscribeContent = new DescribeStoreConfigResponse.DescribeStoreConfig_StoreConfigInfo.DescribeStoreConfig_SubscribeContent();
				subscribeContent.Category = _ctx.StringValue("DescribeStoreConfig.StoreConfigInfo.SubscribeContents["+ i +"].Category");
				subscribeContent.Enable = _ctx.BooleanValue("DescribeStoreConfig.StoreConfigInfo.SubscribeContents["+ i +"].Enable");
				subscribeContent.Threshold = _ctx.StringValue("DescribeStoreConfig.StoreConfigInfo.SubscribeContents["+ i +"].Threshold");
				subscribeContent.AtAll = _ctx.BooleanValue("DescribeStoreConfig.StoreConfigInfo.SubscribeContents["+ i +"].AtAll");
				subscribeContent.AtMobileList = _ctx.StringValue("DescribeStoreConfig.StoreConfigInfo.SubscribeContents["+ i +"].AtMobileList");

				storeConfigInfo_subscribeContents.Add(subscribeContent);
			}
			storeConfigInfo.SubscribeContents = storeConfigInfo_subscribeContents;
			describeStoreConfigResponse.StoreConfigInfo = storeConfigInfo;
        
			return describeStoreConfigResponse;
        }
    }
}
