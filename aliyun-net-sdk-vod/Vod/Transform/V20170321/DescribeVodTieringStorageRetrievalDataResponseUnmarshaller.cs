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
    public class DescribeVodTieringStorageRetrievalDataResponseUnmarshaller
    {
        public static DescribeVodTieringStorageRetrievalDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVodTieringStorageRetrievalDataResponse describeVodTieringStorageRetrievalDataResponse = new DescribeVodTieringStorageRetrievalDataResponse();

			describeVodTieringStorageRetrievalDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVodTieringStorageRetrievalDataResponse.RequestId = _ctx.StringValue("DescribeVodTieringStorageRetrievalData.RequestId");

			List<DescribeVodTieringStorageRetrievalDataResponse.DescribeVodTieringStorageRetrievalData_RetrievalDataItem> describeVodTieringStorageRetrievalDataResponse_retrievalData = new List<DescribeVodTieringStorageRetrievalDataResponse.DescribeVodTieringStorageRetrievalData_RetrievalDataItem>();
			for (int i = 0; i < _ctx.Length("DescribeVodTieringStorageRetrievalData.RetrievalData.Length"); i++) {
				DescribeVodTieringStorageRetrievalDataResponse.DescribeVodTieringStorageRetrievalData_RetrievalDataItem retrievalDataItem = new DescribeVodTieringStorageRetrievalDataResponse.DescribeVodTieringStorageRetrievalData_RetrievalDataItem();
				retrievalDataItem.TimeStamp = _ctx.StringValue("DescribeVodTieringStorageRetrievalData.RetrievalData["+ i +"].TimeStamp");
				retrievalDataItem.Region = _ctx.StringValue("DescribeVodTieringStorageRetrievalData.RetrievalData["+ i +"].Region");
				retrievalDataItem.StorageClass = _ctx.StringValue("DescribeVodTieringStorageRetrievalData.RetrievalData["+ i +"].StorageClass");
				retrievalDataItem.RetrievalData = _ctx.LongValue("DescribeVodTieringStorageRetrievalData.RetrievalData["+ i +"].RetrievalData");
				retrievalDataItem.CAStdRetrievalData = _ctx.LongValue("DescribeVodTieringStorageRetrievalData.RetrievalData["+ i +"].CAStdRetrievalData");
				retrievalDataItem.CABulkRetrievalData = _ctx.LongValue("DescribeVodTieringStorageRetrievalData.RetrievalData["+ i +"].CABulkRetrievalData");
				retrievalDataItem.CAHighPriorRetrievalData = _ctx.LongValue("DescribeVodTieringStorageRetrievalData.RetrievalData["+ i +"].CAHighPriorRetrievalData");

				describeVodTieringStorageRetrievalDataResponse_retrievalData.Add(retrievalDataItem);
			}
			describeVodTieringStorageRetrievalDataResponse.RetrievalData = describeVodTieringStorageRetrievalDataResponse_retrievalData;
        
			return describeVodTieringStorageRetrievalDataResponse;
        }
    }
}
