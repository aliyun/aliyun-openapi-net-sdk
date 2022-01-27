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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeGroupedMaliciousFilesResponseUnmarshaller
    {
        public static DescribeGroupedMaliciousFilesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGroupedMaliciousFilesResponse describeGroupedMaliciousFilesResponse = new DescribeGroupedMaliciousFilesResponse();

			describeGroupedMaliciousFilesResponse.HttpResponse = _ctx.HttpResponse;
			describeGroupedMaliciousFilesResponse.RequestId = _ctx.StringValue("DescribeGroupedMaliciousFiles.RequestId");

			DescribeGroupedMaliciousFilesResponse.DescribeGroupedMaliciousFiles_PageInfo pageInfo = new DescribeGroupedMaliciousFilesResponse.DescribeGroupedMaliciousFiles_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribeGroupedMaliciousFiles.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeGroupedMaliciousFiles.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeGroupedMaliciousFiles.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeGroupedMaliciousFiles.PageInfo.CurrentPage");
			describeGroupedMaliciousFilesResponse.PageInfo = pageInfo;

			List<DescribeGroupedMaliciousFilesResponse.DescribeGroupedMaliciousFiles_GroupedMaliciousFile> describeGroupedMaliciousFilesResponse_groupedMaliciousFileResponse = new List<DescribeGroupedMaliciousFilesResponse.DescribeGroupedMaliciousFiles_GroupedMaliciousFile>();
			for (int i = 0; i < _ctx.Length("DescribeGroupedMaliciousFiles.GroupedMaliciousFileResponse.Length"); i++) {
				DescribeGroupedMaliciousFilesResponse.DescribeGroupedMaliciousFiles_GroupedMaliciousFile groupedMaliciousFile = new DescribeGroupedMaliciousFilesResponse.DescribeGroupedMaliciousFiles_GroupedMaliciousFile();
				groupedMaliciousFile.MaliciousName = _ctx.StringValue("DescribeGroupedMaliciousFiles.GroupedMaliciousFileResponse["+ i +"].MaliciousName");
				groupedMaliciousFile.MaliciousMd5 = _ctx.StringValue("DescribeGroupedMaliciousFiles.GroupedMaliciousFileResponse["+ i +"].MaliciousMd5");
				groupedMaliciousFile.FirstScanTimestamp = _ctx.LongValue("DescribeGroupedMaliciousFiles.GroupedMaliciousFileResponse["+ i +"].FirstScanTimestamp");
				groupedMaliciousFile.LatestScanTimestamp = _ctx.LongValue("DescribeGroupedMaliciousFiles.GroupedMaliciousFileResponse["+ i +"].LatestScanTimestamp");
				groupedMaliciousFile.Status = _ctx.IntegerValue("DescribeGroupedMaliciousFiles.GroupedMaliciousFileResponse["+ i +"].Status");
				groupedMaliciousFile.Level = _ctx.StringValue("DescribeGroupedMaliciousFiles.GroupedMaliciousFileResponse["+ i +"].Level");
				groupedMaliciousFile.ImageCount = _ctx.LongValue("DescribeGroupedMaliciousFiles.GroupedMaliciousFileResponse["+ i +"].ImageCount");

				describeGroupedMaliciousFilesResponse_groupedMaliciousFileResponse.Add(groupedMaliciousFile);
			}
			describeGroupedMaliciousFilesResponse.GroupedMaliciousFileResponse = describeGroupedMaliciousFilesResponse_groupedMaliciousFileResponse;
        
			return describeGroupedMaliciousFilesResponse;
        }
    }
}
