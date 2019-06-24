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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodStorageDataResponseUnmarshaller
    {
        public static DescribeVodStorageDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodStorageDataResponse describeVodStorageDataResponse = new DescribeVodStorageDataResponse();

			describeVodStorageDataResponse.HttpResponse = context.HttpResponse;
			describeVodStorageDataResponse.RequestId = context.StringValue("DescribeVodStorageData.RequestId");
			describeVodStorageDataResponse.DataInterval = context.StringValue("DescribeVodStorageData.DataInterval");

			List<DescribeVodStorageDataResponse.DescribeVodStorageData_StorageDataItem> describeVodStorageDataResponse_storageData = new List<DescribeVodStorageDataResponse.DescribeVodStorageData_StorageDataItem>();
			for (int i = 0; i < context.Length("DescribeVodStorageData.StorageData.Length"); i++) {
				DescribeVodStorageDataResponse.DescribeVodStorageData_StorageDataItem storageDataItem = new DescribeVodStorageDataResponse.DescribeVodStorageData_StorageDataItem();
				storageDataItem.TimeStamp = context.StringValue("DescribeVodStorageData.StorageData["+ i +"].TimeStamp");
				storageDataItem.StorageUtilization = context.StringValue("DescribeVodStorageData.StorageData["+ i +"].StorageUtilization");
				storageDataItem.NetworkOut = context.StringValue("DescribeVodStorageData.StorageData["+ i +"].NetworkOut");

				describeVodStorageDataResponse_storageData.Add(storageDataItem);
			}
			describeVodStorageDataResponse.StorageData = describeVodStorageDataResponse_storageData;
        
			return describeVodStorageDataResponse;
        }
    }
}
