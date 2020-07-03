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
    public class UpdateUserBucketConfigResponseUnmarshaller
    {
        public static UpdateUserBucketConfigResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateUserBucketConfigResponse updateUserBucketConfigResponse = new UpdateUserBucketConfigResponse();

			updateUserBucketConfigResponse.HttpResponse = context.HttpResponse;
			updateUserBucketConfigResponse.RequestId = context.StringValue("UpdateUserBucketConfig.RequestId");
			updateUserBucketConfigResponse.Code = context.StringValue("UpdateUserBucketConfig.Code");
			updateUserBucketConfigResponse.Message = context.StringValue("UpdateUserBucketConfig.Message");

			List<UpdateUserBucketConfigResponse.UpdateUserBucketConfig_DataItem> updateUserBucketConfigResponse_data = new List<UpdateUserBucketConfigResponse.UpdateUserBucketConfig_DataItem>();
			for (int i = 0; i < context.Length("UpdateUserBucketConfig.Data.Length"); i++) {
				UpdateUserBucketConfigResponse.UpdateUserBucketConfig_DataItem dataItem = new UpdateUserBucketConfigResponse.UpdateUserBucketConfig_DataItem();
				dataItem.Region = context.StringValue("UpdateUserBucketConfig.Data["+ i +"].Region");
				dataItem.RegionName = context.StringValue("UpdateUserBucketConfig.Data["+ i +"].RegionName");
				dataItem.Bucket = context.StringValue("UpdateUserBucketConfig.Data["+ i +"].Bucket");

				updateUserBucketConfigResponse_data.Add(dataItem);
			}
			updateUserBucketConfigResponse.Data = updateUserBucketConfigResponse_data;
        
			return updateUserBucketConfigResponse;
        }
    }
}
