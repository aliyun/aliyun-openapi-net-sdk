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
        public static DescribeStoreConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStoreConfigResponse describeStoreConfigResponse = new DescribeStoreConfigResponse();

			describeStoreConfigResponse.HttpResponse = context.HttpResponse;
			describeStoreConfigResponse.ErrorMessage = context.StringValue("DescribeStoreConfig.ErrorMessage");
			describeStoreConfigResponse.ErrorCode = context.StringValue("DescribeStoreConfig.ErrorCode");
			describeStoreConfigResponse.Message = context.StringValue("DescribeStoreConfig.Message");
			describeStoreConfigResponse.DynamicCode = context.StringValue("DescribeStoreConfig.DynamicCode");
			describeStoreConfigResponse.Code = context.StringValue("DescribeStoreConfig.Code");
			describeStoreConfigResponse.DynamicMessage = context.StringValue("DescribeStoreConfig.DynamicMessage");
			describeStoreConfigResponse.RequestId = context.StringValue("DescribeStoreConfig.RequestId");
			describeStoreConfigResponse.Success = context.BooleanValue("DescribeStoreConfig.Success");

			DescribeStoreConfigResponse.DescribeStoreConfig_StoreConfigInfo storeConfigInfo = new DescribeStoreConfigResponse.DescribeStoreConfig_StoreConfigInfo();
			storeConfigInfo.EnableNotification = context.BooleanValue("DescribeStoreConfig.StoreConfigInfo.EnableNotification");
			storeConfigInfo.NotificationWebHook = context.StringValue("DescribeStoreConfig.StoreConfigInfo.NotificationWebHook");
			storeConfigInfo.NotificationSilentTimes = context.StringValue("DescribeStoreConfig.StoreConfigInfo.NotificationSilentTimes");
			storeConfigInfo.StoreId = context.StringValue("DescribeStoreConfig.StoreConfigInfo.StoreId");
			describeStoreConfigResponse.StoreConfigInfo = storeConfigInfo;
        
			return describeStoreConfigResponse;
        }
    }
}
