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
using Aliyun.Acs.ivpd.Model.V20190625;

namespace Aliyun.Acs.ivpd.Transform.V20190625
{
    public class GetUserBucketConfigResponseUnmarshaller
    {
        public static GetUserBucketConfigResponse Unmarshall(UnmarshallerContext context)
        {
			GetUserBucketConfigResponse getUserBucketConfigResponse = new GetUserBucketConfigResponse();

			getUserBucketConfigResponse.HttpResponse = context.HttpResponse;
			getUserBucketConfigResponse.RequestId = context.StringValue("GetUserBucketConfig.RequestId");
			getUserBucketConfigResponse.Code = context.StringValue("GetUserBucketConfig.Code");
			getUserBucketConfigResponse.Message = context.StringValue("GetUserBucketConfig.Message");

			List<GetUserBucketConfigResponse.GetUserBucketConfig_DataItem> getUserBucketConfigResponse_data = new List<GetUserBucketConfigResponse.GetUserBucketConfig_DataItem>();
			for (int i = 0; i < context.Length("GetUserBucketConfig.Data.Length"); i++) {
				GetUserBucketConfigResponse.GetUserBucketConfig_DataItem dataItem = new GetUserBucketConfigResponse.GetUserBucketConfig_DataItem();
				dataItem.Region = context.StringValue("GetUserBucketConfig.Data["+ i +"].Region");
				dataItem.RegionName = context.StringValue("GetUserBucketConfig.Data["+ i +"].RegionName");
				dataItem.Bucket = context.StringValue("GetUserBucketConfig.Data["+ i +"].Bucket");

				getUserBucketConfigResponse_data.Add(dataItem);
			}
			getUserBucketConfigResponse.Data = getUserBucketConfigResponse_data;
        
			return getUserBucketConfigResponse;
        }
    }
}
