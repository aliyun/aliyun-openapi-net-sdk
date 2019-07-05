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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeOssStockStatusResponseUnmarshaller
    {
        public static DescribeOssStockStatusResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOssStockStatusResponse describeOssStockStatusResponse = new DescribeOssStockStatusResponse();

			describeOssStockStatusResponse.HttpResponse = context.HttpResponse;
			describeOssStockStatusResponse.RequestId = context.StringValue("DescribeOssStockStatus.RequestId");
			describeOssStockStatusResponse.StockStatus = context.IntegerValue("DescribeOssStockStatus.StockStatus");
			describeOssStockStatusResponse.FinishedTime = context.StringValue("DescribeOssStockStatus.FinishedTime");
			describeOssStockStatusResponse.ImageTotalCount = context.IntegerValue("DescribeOssStockStatus.ImageTotalCount");
			describeOssStockStatusResponse.ImagePornCount = context.IntegerValue("DescribeOssStockStatus.ImagePornCount");
			describeOssStockStatusResponse.ImageTerrorismCount = context.IntegerValue("DescribeOssStockStatus.ImageTerrorismCount");
			describeOssStockStatusResponse.VideoTotalCount = context.IntegerValue("DescribeOssStockStatus.VideoTotalCount");
			describeOssStockStatusResponse.VideoPornCount = context.IntegerValue("DescribeOssStockStatus.VideoPornCount");
			describeOssStockStatusResponse.VideoTerrorismCount = context.IntegerValue("DescribeOssStockStatus.VideoTerrorismCount");

			List<string> describeOssStockStatusResponse_sceneList = new List<string>();
			for (int i = 0; i < context.Length("DescribeOssStockStatus.SceneList.Length"); i++) {
				describeOssStockStatusResponse_sceneList.Add(context.StringValue("DescribeOssStockStatus.SceneList["+ i +"]"));
			}
			describeOssStockStatusResponse.SceneList = describeOssStockStatusResponse_sceneList;

			List<string> describeOssStockStatusResponse_resouceTypeList = new List<string>();
			for (int i = 0; i < context.Length("DescribeOssStockStatus.ResouceTypeList.Length"); i++) {
				describeOssStockStatusResponse_resouceTypeList.Add(context.StringValue("DescribeOssStockStatus.ResouceTypeList["+ i +"]"));
			}
			describeOssStockStatusResponse.ResouceTypeList = describeOssStockStatusResponse_resouceTypeList;

			List<DescribeOssStockStatusResponse.DescribeOssStockStatus_Bucket> describeOssStockStatusResponse_bucketList = new List<DescribeOssStockStatusResponse.DescribeOssStockStatus_Bucket>();
			for (int i = 0; i < context.Length("DescribeOssStockStatus.BucketList.Length"); i++) {
				DescribeOssStockStatusResponse.DescribeOssStockStatus_Bucket bucket = new DescribeOssStockStatusResponse.DescribeOssStockStatus_Bucket();
				bucket.Selected = context.BooleanValue("DescribeOssStockStatus.BucketList["+ i +"].Selected");
				bucket.Bucket = context.StringValue("DescribeOssStockStatus.BucketList["+ i +"].Bucket");

				List<string> bucket_prefixes = new List<string>();
				for (int j = 0; j < context.Length("DescribeOssStockStatus.BucketList["+ i +"].Prefixes.Length"); j++) {
					bucket_prefixes.Add(context.StringValue("DescribeOssStockStatus.BucketList["+ i +"].Prefixes["+ j +"]"));
				}
				bucket.Prefixes = bucket_prefixes;

				describeOssStockStatusResponse_bucketList.Add(bucket);
			}
			describeOssStockStatusResponse.BucketList = describeOssStockStatusResponse_bucketList;
        
			return describeOssStockStatusResponse;
        }
    }
}
