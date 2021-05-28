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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeStorageBundlesResponseUnmarshaller
    {
        public static DescribeStorageBundlesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStorageBundlesResponse describeStorageBundlesResponse = new DescribeStorageBundlesResponse();

			describeStorageBundlesResponse.HttpResponse = _ctx.HttpResponse;
			describeStorageBundlesResponse.RequestId = _ctx.StringValue("DescribeStorageBundles.RequestId");
			describeStorageBundlesResponse.Success = _ctx.BooleanValue("DescribeStorageBundles.Success");
			describeStorageBundlesResponse.Code = _ctx.StringValue("DescribeStorageBundles.Code");
			describeStorageBundlesResponse.Message = _ctx.StringValue("DescribeStorageBundles.Message");
			describeStorageBundlesResponse.TotalCount = _ctx.IntegerValue("DescribeStorageBundles.TotalCount");
			describeStorageBundlesResponse.PageNumber = _ctx.IntegerValue("DescribeStorageBundles.PageNumber");
			describeStorageBundlesResponse.PageSize = _ctx.IntegerValue("DescribeStorageBundles.PageSize");

			List<DescribeStorageBundlesResponse.DescribeStorageBundles_StorageBundle> describeStorageBundlesResponse_storageBundles = new List<DescribeStorageBundlesResponse.DescribeStorageBundles_StorageBundle>();
			for (int i = 0; i < _ctx.Length("DescribeStorageBundles.StorageBundles.Length"); i++) {
				DescribeStorageBundlesResponse.DescribeStorageBundles_StorageBundle storageBundle = new DescribeStorageBundlesResponse.DescribeStorageBundles_StorageBundle();
				storageBundle.StorageBundleId = _ctx.StringValue("DescribeStorageBundles.StorageBundles["+ i +"].StorageBundleId");
				storageBundle.Name = _ctx.StringValue("DescribeStorageBundles.StorageBundles["+ i +"].Name");
				storageBundle.Description = _ctx.StringValue("DescribeStorageBundles.StorageBundles["+ i +"].Description");
				storageBundle.BackendBucketRegionId = _ctx.StringValue("DescribeStorageBundles.StorageBundles["+ i +"].BackendBucketRegionId");
				storageBundle.Location = _ctx.StringValue("DescribeStorageBundles.StorageBundles["+ i +"].Location");
				storageBundle.CreatedTime = _ctx.LongValue("DescribeStorageBundles.StorageBundles["+ i +"].CreatedTime");
				storageBundle.ResourceGroupId = _ctx.StringValue("DescribeStorageBundles.StorageBundles["+ i +"].ResourceGroupId");

				describeStorageBundlesResponse_storageBundles.Add(storageBundle);
			}
			describeStorageBundlesResponse.StorageBundles = describeStorageBundlesResponse_storageBundles;
        
			return describeStorageBundlesResponse;
        }
    }
}
