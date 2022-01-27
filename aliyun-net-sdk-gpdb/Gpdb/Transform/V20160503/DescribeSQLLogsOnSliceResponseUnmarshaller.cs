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
using Aliyun.Acs.gpdb.Model.V20160503;

namespace Aliyun.Acs.gpdb.Transform.V20160503
{
    public class DescribeSQLLogsOnSliceResponseUnmarshaller
    {
        public static DescribeSQLLogsOnSliceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLLogsOnSliceResponse describeSQLLogsOnSliceResponse = new DescribeSQLLogsOnSliceResponse();

			describeSQLLogsOnSliceResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLLogsOnSliceResponse.RequestId = _ctx.StringValue("DescribeSQLLogsOnSlice.RequestId");
			describeSQLLogsOnSliceResponse.PageRecordCount = _ctx.IntegerValue("DescribeSQLLogsOnSlice.PageRecordCount");
			describeSQLLogsOnSliceResponse.PageNumber = _ctx.IntegerValue("DescribeSQLLogsOnSlice.PageNumber");

			List<DescribeSQLLogsOnSliceResponse.DescribeSQLLogsOnSlice_SQLLogsSliceItem> describeSQLLogsOnSliceResponse_sliceLogItems = new List<DescribeSQLLogsOnSliceResponse.DescribeSQLLogsOnSlice_SQLLogsSliceItem>();
			for (int i = 0; i < _ctx.Length("DescribeSQLLogsOnSlice.SliceLogItems.Length"); i++) {
				DescribeSQLLogsOnSliceResponse.DescribeSQLLogsOnSlice_SQLLogsSliceItem sQLLogsSliceItem = new DescribeSQLLogsOnSliceResponse.DescribeSQLLogsOnSlice_SQLLogsSliceItem();
				sQLLogsSliceItem.ExecuteStatus = _ctx.StringValue("DescribeSQLLogsOnSlice.SliceLogItems["+ i +"].ExecuteStatus");
				sQLLogsSliceItem.ExecuteCost = _ctx.FloatValue("DescribeSQLLogsOnSlice.SliceLogItems["+ i +"].ExecuteCost");
				sQLLogsSliceItem.ReturnRowCounts = _ctx.LongValue("DescribeSQLLogsOnSlice.SliceLogItems["+ i +"].ReturnRowCounts");
				sQLLogsSliceItem.OperationExecuteTime = _ctx.StringValue("DescribeSQLLogsOnSlice.SliceLogItems["+ i +"].OperationExecuteTime");
				sQLLogsSliceItem.SegmentId = _ctx.StringValue("DescribeSQLLogsOnSlice.SliceLogItems["+ i +"].SegmentId");
				sQLLogsSliceItem.PeakMemory = _ctx.FloatValue("DescribeSQLLogsOnSlice.SliceLogItems["+ i +"].PeakMemory");
				sQLLogsSliceItem.OperationExecuteEndTime = _ctx.StringValue("DescribeSQLLogsOnSlice.SliceLogItems["+ i +"].OperationExecuteEndTime");
				sQLLogsSliceItem.SegmentName = _ctx.StringValue("DescribeSQLLogsOnSlice.SliceLogItems["+ i +"].SegmentName");

				describeSQLLogsOnSliceResponse_sliceLogItems.Add(sQLLogsSliceItem);
			}
			describeSQLLogsOnSliceResponse.SliceLogItems = describeSQLLogsOnSliceResponse_sliceLogItems;
        
			return describeSQLLogsOnSliceResponse;
        }
    }
}
