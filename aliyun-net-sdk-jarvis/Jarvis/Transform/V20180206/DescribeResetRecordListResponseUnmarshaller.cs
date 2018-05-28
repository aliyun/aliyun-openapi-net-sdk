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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.jarvis.Model.V20180206;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.jarvis.Transform.V20180206
{
    public class DescribeResetRecordListResponseUnmarshaller
    {
        public static DescribeResetRecordListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeResetRecordListResponse describeResetRecordListResponse = new DescribeResetRecordListResponse();

			describeResetRecordListResponse.HttpResponse = context.HttpResponse;
			describeResetRecordListResponse.RequestId = context.StringValue("DescribeResetRecordList.RequestId");
			describeResetRecordListResponse.Module = context.StringValue("DescribeResetRecordList.Module");

			DescribeResetRecordListResponse.DescribeResetRecordList_PageInfo pageInfo = new DescribeResetRecordListResponse.DescribeResetRecordList_PageInfo();
			pageInfo.Total = context.IntegerValue("DescribeResetRecordList.PageInfo.Total");
			pageInfo.PageSize = context.IntegerValue("DescribeResetRecordList.PageInfo.PageSize");
			pageInfo.CurrentPage = context.IntegerValue("DescribeResetRecordList.PageInfo.CurrentPage");
			describeResetRecordListResponse.PageInfo = pageInfo;

			List<DescribeResetRecordListResponse.DescribeResetRecordList_Data> describeResetRecordListResponse_dataList = new List<DescribeResetRecordListResponse.DescribeResetRecordList_Data>();
			for (int i = 0; i < context.Length("DescribeResetRecordList.DataList.Length"); i++) {
				DescribeResetRecordListResponse.DescribeResetRecordList_Data data = new DescribeResetRecordListResponse.DescribeResetRecordList_Data();
				data.PunishType = context.StringValue("DescribeResetRecordList.DataList["+ i +"].PunishType");
				data.DstIP = context.StringValue("DescribeResetRecordList.DataList["+ i +"].DstIP");
				data.PunishResult = context.StringValue("DescribeResetRecordList.DataList["+ i +"].PunishResult");
				data.DstPort = context.IntegerValue("DescribeResetRecordList.DataList["+ i +"].DstPort");
				data.SrcIP = context.StringValue("DescribeResetRecordList.DataList["+ i +"].SrcIP");
				data.PunishCount = context.IntegerValue("DescribeResetRecordList.DataList["+ i +"].PunishCount");

				describeResetRecordListResponse_dataList.Add(data);
			}
			describeResetRecordListResponse.DataList = describeResetRecordListResponse_dataList;
        
			return describeResetRecordListResponse;
        }
    }
}