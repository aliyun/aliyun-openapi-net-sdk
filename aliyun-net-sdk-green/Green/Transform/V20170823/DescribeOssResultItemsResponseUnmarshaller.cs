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
    public class DescribeOssResultItemsResponseUnmarshaller
    {
        public static DescribeOssResultItemsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOssResultItemsResponse describeOssResultItemsResponse = new DescribeOssResultItemsResponse();

			describeOssResultItemsResponse.HttpResponse = context.HttpResponse;
			describeOssResultItemsResponse.RequestId = context.StringValue("DescribeOssResultItems.RequestId");
			describeOssResultItemsResponse.PageSize = context.IntegerValue("DescribeOssResultItems.PageSize");
			describeOssResultItemsResponse.CurrentPage = context.IntegerValue("DescribeOssResultItems.CurrentPage");
			describeOssResultItemsResponse.TotalCount = context.IntegerValue("DescribeOssResultItems.TotalCount");
			describeOssResultItemsResponse.QueryId = context.StringValue("DescribeOssResultItems.QueryId");

			List<DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult> describeOssResultItemsResponse_scanResultList = new List<DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult>();
			for (int i = 0; i < context.Length("DescribeOssResultItems.ScanResultList.Length"); i++) {
				DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult scanResult = new DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult();
				scanResult.TaskId = context.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].TaskId");
				scanResult.DataId = context.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].DataId");
				scanResult.NewUrl = context.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].NewUrl");
				scanResult.Thumbnail = context.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].Thumbnail");
				scanResult.RequestTime = context.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].RequestTime");
				scanResult.ScanFinishedTime = context.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].ScanFinishedTime");
				scanResult.CreateTime = context.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].CreateTime");
				scanResult.Suggestion = context.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].Suggestion");
				scanResult.Id = context.LongValue("DescribeOssResultItems.ScanResultList["+ i +"].Id");
				scanResult.Bucket = context.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].Bucket");
				scanResult._Object = context.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].Object");
				scanResult.Score = context.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].Score");
				scanResult.HandleStatus = context.IntegerValue("DescribeOssResultItems.ScanResultList["+ i +"].HandleStatus");
				scanResult.ResourceStatus = context.IntegerValue("DescribeOssResultItems.ScanResultList["+ i +"].ResourceStatus");

				List<DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult.DescribeOssResultItems_FrameResult> scanResult_frameResults = new List<DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult.DescribeOssResultItems_FrameResult>();
				for (int j = 0; j < context.Length("DescribeOssResultItems.ScanResultList["+ i +"].FrameResults.Length"); j++) {
					DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult.DescribeOssResultItems_FrameResult frameResult = new DescribeOssResultItemsResponse.DescribeOssResultItems_ScanResult.DescribeOssResultItems_FrameResult();
					frameResult.Thumbnail = context.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].FrameResults["+ j +"].Thumbnail");
					frameResult.Offset = context.IntegerValue("DescribeOssResultItems.ScanResultList["+ i +"].FrameResults["+ j +"].Offset");
					frameResult.Url = context.StringValue("DescribeOssResultItems.ScanResultList["+ i +"].FrameResults["+ j +"].Url");

					scanResult_frameResults.Add(frameResult);
				}
				scanResult.FrameResults = scanResult_frameResults;

				describeOssResultItemsResponse_scanResultList.Add(scanResult);
			}
			describeOssResultItemsResponse.ScanResultList = describeOssResultItemsResponse_scanResultList;
        
			return describeOssResultItemsResponse;
        }
    }
}
