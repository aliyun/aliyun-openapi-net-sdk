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
        public static DescribeVodStorageDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodStorageDataResponse describeVodStorageDataResponse = new DescribeVodStorageDataResponse();

			describeVodStorageDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVodStorageDataResponse.DataInterval = _ctx.StringValue("DescribeVodStorageData.DataInterval");
			describeVodStorageDataResponse.RequestId = _ctx.StringValue("DescribeVodStorageData.RequestId");

			List<DescribeVodStorageDataResponse.DescribeVodStorageData_StorageDataItem> describeVodStorageDataResponse_storageData = new List<DescribeVodStorageDataResponse.DescribeVodStorageData_StorageDataItem>();
			for (int i = 0; i < _ctx.Length("DescribeVodStorageData.StorageData.Length"); i++) {
				DescribeVodStorageDataResponse.DescribeVodStorageData_StorageDataItem storageDataItem = new DescribeVodStorageDataResponse.DescribeVodStorageData_StorageDataItem();
				storageDataItem.TimeStamp = _ctx.StringValue("DescribeVodStorageData.StorageData["+ i +"].TimeStamp");
				storageDataItem.StorageUtilization = _ctx.StringValue("DescribeVodStorageData.StorageData["+ i +"].StorageUtilization");
				storageDataItem.NetworkOut = _ctx.StringValue("DescribeVodStorageData.StorageData["+ i +"].NetworkOut");

				describeVodStorageDataResponse_storageData.Add(storageDataItem);
			}
			describeVodStorageDataResponse.StorageData = describeVodStorageDataResponse_storageData;
        
			return describeVodStorageDataResponse;
        }
    }
}
