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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeVsStorageUsageDataResponseUnmarshaller
    {
        public static DescribeVsStorageUsageDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVsStorageUsageDataResponse describeVsStorageUsageDataResponse = new DescribeVsStorageUsageDataResponse();

			describeVsStorageUsageDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVsStorageUsageDataResponse.RequestId = _ctx.StringValue("DescribeVsStorageUsageData.RequestId");

			List<DescribeVsStorageUsageDataResponse.DescribeVsStorageUsageData_StorageUsageDataModule> describeVsStorageUsageDataResponse_storageUsage = new List<DescribeVsStorageUsageDataResponse.DescribeVsStorageUsageData_StorageUsageDataModule>();
			for (int i = 0; i < _ctx.Length("DescribeVsStorageUsageData.StorageUsage.Length"); i++) {
				DescribeVsStorageUsageDataResponse.DescribeVsStorageUsageData_StorageUsageDataModule storageUsageDataModule = new DescribeVsStorageUsageDataResponse.DescribeVsStorageUsageData_StorageUsageDataModule();
				storageUsageDataModule.TimeStamp = _ctx.StringValue("DescribeVsStorageUsageData.StorageUsage["+ i +"].TimeStamp");
				storageUsageDataModule.Bucket = _ctx.StringValue("DescribeVsStorageUsageData.StorageUsage["+ i +"].Bucket");
				storageUsageDataModule.StorageDataValue = _ctx.IntegerValue("DescribeVsStorageUsageData.StorageUsage["+ i +"].StorageDataValue");

				describeVsStorageUsageDataResponse_storageUsage.Add(storageUsageDataModule);
			}
			describeVsStorageUsageDataResponse.StorageUsage = describeVsStorageUsageDataResponse_storageUsage;
        
			return describeVsStorageUsageDataResponse;
        }
    }
}
