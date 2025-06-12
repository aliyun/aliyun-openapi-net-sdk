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
using Aliyun.Acs.clickhouse.Model.V20191111;

namespace Aliyun.Acs.clickhouse.Transform.V20191111
{
    public class DescribeTransferHistoryResponseUnmarshaller
    {
        public static DescribeTransferHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTransferHistoryResponse describeTransferHistoryResponse = new DescribeTransferHistoryResponse();

			describeTransferHistoryResponse.HttpResponse = _ctx.HttpResponse;
			describeTransferHistoryResponse.RequestId = _ctx.StringValue("DescribeTransferHistory.RequestId");

			List<DescribeTransferHistoryResponse.DescribeTransferHistory_HistoryDetail> describeTransferHistoryResponse_historyDetails = new List<DescribeTransferHistoryResponse.DescribeTransferHistory_HistoryDetail>();
			for (int i = 0; i < _ctx.Length("DescribeTransferHistory.HistoryDetails.Length"); i++) {
				DescribeTransferHistoryResponse.DescribeTransferHistory_HistoryDetail historyDetail = new DescribeTransferHistoryResponse.DescribeTransferHistory_HistoryDetail();
				historyDetail.SourceDBCluster = _ctx.StringValue("DescribeTransferHistory.HistoryDetails["+ i +"].SourceDBCluster");
				historyDetail.SourceControlVersion = _ctx.StringValue("DescribeTransferHistory.HistoryDetails["+ i +"].SourceControlVersion");
				historyDetail.TargetDBCluster = _ctx.StringValue("DescribeTransferHistory.HistoryDetails["+ i +"].TargetDBCluster");
				historyDetail.TargetControlVersion = _ctx.StringValue("DescribeTransferHistory.HistoryDetails["+ i +"].TargetControlVersion");
				historyDetail.Status = _ctx.StringValue("DescribeTransferHistory.HistoryDetails["+ i +"].Status");
				historyDetail.Progress = _ctx.StringValue("DescribeTransferHistory.HistoryDetails["+ i +"].Progress");
				historyDetail.DisableWriteWindows = _ctx.StringValue("DescribeTransferHistory.HistoryDetails["+ i +"].DisableWriteWindows");
				historyDetail.UnsyncedBytes = _ctx.LongValue("DescribeTransferHistory.HistoryDetails["+ i +"].UnsyncedBytes");
				historyDetail.UnsyncedParts = _ctx.LongValue("DescribeTransferHistory.HistoryDetails["+ i +"].UnsyncedParts");
				historyDetail.PartsPerMinute = _ctx.DoubleValue("DescribeTransferHistory.HistoryDetails["+ i +"].PartsPerMinute");
				historyDetail.BytesPerMinute = _ctx.LongValue("DescribeTransferHistory.HistoryDetails["+ i +"].BytesPerMinute");
				historyDetail.SubJob = _ctx.StringValue("DescribeTransferHistory.HistoryDetails["+ i +"].SubJob");
				historyDetail.SubJobStatus = _ctx.StringValue("DescribeTransferHistory.HistoryDetails["+ i +"].SubJobStatus");

				describeTransferHistoryResponse_historyDetails.Add(historyDetail);
			}
			describeTransferHistoryResponse.HistoryDetails = describeTransferHistoryResponse_historyDetails;
        
			return describeTransferHistoryResponse;
        }
    }
}
