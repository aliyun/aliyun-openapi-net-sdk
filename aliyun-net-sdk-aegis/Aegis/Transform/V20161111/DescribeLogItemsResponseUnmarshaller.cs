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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeLogItemsResponseUnmarshaller
    {
        public static DescribeLogItemsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLogItemsResponse describeLogItemsResponse = new DescribeLogItemsResponse();

			describeLogItemsResponse.HttpResponse = context.HttpResponse;
			describeLogItemsResponse.RequestId = context.StringValue("DescribeLogItems.RequestId");
			describeLogItemsResponse.TotalCount = context.IntegerValue("DescribeLogItems.TotalCount");
			describeLogItemsResponse.CrackTotalCount = context.IntegerValue("DescribeLogItems.CrackTotalCount");
			describeLogItemsResponse.SetPageSize = context.IntegerValue("DescribeLogItems.SetPageSize");
			describeLogItemsResponse.ProcessOffset = context.IntegerValue("DescribeLogItems.ProcessOffset");
			describeLogItemsResponse.NetworkOffset = context.IntegerValue("DescribeLogItems.NetworkOffset");
			describeLogItemsResponse.PortSnapshotOffset = context.IntegerValue("DescribeLogItems.PortSnapshotOffset");
			describeLogItemsResponse.ProcessSnapshotTotalCount = context.IntegerValue("DescribeLogItems.ProcessSnapshotTotalCount");
			describeLogItemsResponse.CrackOffset = context.IntegerValue("DescribeLogItems.CrackOffset");
			describeLogItemsResponse.NetworkTotalCount = context.IntegerValue("DescribeLogItems.NetworkTotalCount");
			describeLogItemsResponse.PortSnapshotTotalCount = context.IntegerValue("DescribeLogItems.PortSnapshotTotalCount");
			describeLogItemsResponse.ProcessSnapshotOffset = context.IntegerValue("DescribeLogItems.ProcessSnapshotOffset");
			describeLogItemsResponse.ProcessTotalCount = context.IntegerValue("DescribeLogItems.ProcessTotalCount");
			describeLogItemsResponse.LoginTotalCount = context.IntegerValue("DescribeLogItems.LoginTotalCount");
			describeLogItemsResponse.CurrentPage = context.IntegerValue("DescribeLogItems.CurrentPage");
			describeLogItemsResponse.AccountSnapshotOffset = context.IntegerValue("DescribeLogItems.AccountSnapshotOffset");
			describeLogItemsResponse.AccountSnapshotTotalCount = context.IntegerValue("DescribeLogItems.AccountSnapshotTotalCount");

			List<DescribeLogItemsResponse.DescribeLogItems_LogsListItem> describeLogItemsResponse_logsList = new List<DescribeLogItemsResponse.DescribeLogItems_LogsListItem>();
			for (int i = 0; i < context.Length("DescribeLogItems.LogsList.Length"); i++) {
				DescribeLogItemsResponse.DescribeLogItems_LogsListItem logsListItem = new DescribeLogItemsResponse.DescribeLogItems_LogsListItem();
				logsListItem.MLogTime = context.StringValue("DescribeLogItems.LogsList["+ i +"].MLogTime");
				logsListItem.LogSourceId = context.StringValue("DescribeLogItems.LogsList["+ i +"].LogSourceId");
				logsListItem.LogSource = context.StringValue("DescribeLogItems.LogsList["+ i +"].LogSource");

				List<DescribeLogItemsResponse.DescribeLogItems_LogsListItem.DescribeLogItems_MContentsItem> logsListItem_mContents = new List<DescribeLogItemsResponse.DescribeLogItems_LogsListItem.DescribeLogItems_MContentsItem>();
				for (int j = 0; j < context.Length("DescribeLogItems.LogsList["+ i +"].MContents.Length"); j++) {
					DescribeLogItemsResponse.DescribeLogItems_LogsListItem.DescribeLogItems_MContentsItem mContentsItem = new DescribeLogItemsResponse.DescribeLogItems_LogsListItem.DescribeLogItems_MContentsItem();
					mContentsItem.MKey = context.StringValue("DescribeLogItems.LogsList["+ i +"].MContents["+ j +"].MKey");
					mContentsItem.MValue = context.StringValue("DescribeLogItems.LogsList["+ i +"].MContents["+ j +"].MValue");

					logsListItem_mContents.Add(mContentsItem);
				}
				logsListItem.MContents = logsListItem_mContents;

				describeLogItemsResponse_logsList.Add(logsListItem);
			}
			describeLogItemsResponse.LogsList = describeLogItemsResponse_logsList;
        
			return describeLogItemsResponse;
        }
    }
}
