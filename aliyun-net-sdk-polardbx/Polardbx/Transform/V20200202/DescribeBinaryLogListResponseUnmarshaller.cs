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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeBinaryLogListResponseUnmarshaller
    {
        public static DescribeBinaryLogListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBinaryLogListResponse describeBinaryLogListResponse = new DescribeBinaryLogListResponse();

			describeBinaryLogListResponse.HttpResponse = _ctx.HttpResponse;
			describeBinaryLogListResponse.RequestId = _ctx.StringValue("DescribeBinaryLogList.RequestId");
			describeBinaryLogListResponse.PageNumber = _ctx.IntegerValue("DescribeBinaryLogList.PageNumber");
			describeBinaryLogListResponse.PageSize = _ctx.IntegerValue("DescribeBinaryLogList.PageSize");
			describeBinaryLogListResponse.TotalNumber = _ctx.IntegerValue("DescribeBinaryLogList.TotalNumber");

			List<DescribeBinaryLogListResponse.DescribeBinaryLogList_LogListItem> describeBinaryLogListResponse_logList = new List<DescribeBinaryLogListResponse.DescribeBinaryLogList_LogListItem>();
			for (int i = 0; i < _ctx.Length("DescribeBinaryLogList.LogList.Length"); i++) {
				DescribeBinaryLogListResponse.DescribeBinaryLogList_LogListItem logListItem = new DescribeBinaryLogListResponse.DescribeBinaryLogList_LogListItem();
				logListItem.EndTime = _ctx.StringValue("DescribeBinaryLogList.LogList["+ i +"].EndTime");
				logListItem.ModifiedTime = _ctx.StringValue("DescribeBinaryLogList.LogList["+ i +"].ModifiedTime");
				logListItem.UploadHost = _ctx.StringValue("DescribeBinaryLogList.LogList["+ i +"].UploadHost");
				logListItem.UploadStatus = _ctx.IntegerValue("DescribeBinaryLogList.LogList["+ i +"].UploadStatus");
				logListItem.DownloadLink = _ctx.StringValue("DescribeBinaryLogList.LogList["+ i +"].DownloadLink");
				logListItem.BeginTime = _ctx.StringValue("DescribeBinaryLogList.LogList["+ i +"].BeginTime");
				logListItem.LogSize = _ctx.LongValue("DescribeBinaryLogList.LogList["+ i +"].LogSize");
				logListItem.FileName = _ctx.StringValue("DescribeBinaryLogList.LogList["+ i +"].FileName");
				logListItem.CreatedTime = _ctx.StringValue("DescribeBinaryLogList.LogList["+ i +"].CreatedTime");
				logListItem.PurgeStatus = _ctx.IntegerValue("DescribeBinaryLogList.LogList["+ i +"].PurgeStatus");
				logListItem.Id = _ctx.LongValue("DescribeBinaryLogList.LogList["+ i +"].Id");

				describeBinaryLogListResponse_logList.Add(logListItem);
			}
			describeBinaryLogListResponse.LogList = describeBinaryLogListResponse_logList;
        
			return describeBinaryLogListResponse;
        }
    }
}
