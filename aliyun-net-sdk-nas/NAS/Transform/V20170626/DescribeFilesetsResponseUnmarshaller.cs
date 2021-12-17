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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeFilesetsResponseUnmarshaller
    {
        public static DescribeFilesetsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFilesetsResponse describeFilesetsResponse = new DescribeFilesetsResponse();

			describeFilesetsResponse.HttpResponse = _ctx.HttpResponse;
			describeFilesetsResponse.RequestId = _ctx.StringValue("DescribeFilesets.RequestId");
			describeFilesetsResponse.NextToken = _ctx.StringValue("DescribeFilesets.NextToken");
			describeFilesetsResponse.FileSystemId = _ctx.StringValue("DescribeFilesets.FileSystemId");

			List<DescribeFilesetsResponse.DescribeFilesets_Entrie> describeFilesetsResponse_entries = new List<DescribeFilesetsResponse.DescribeFilesets_Entrie>();
			for (int i = 0; i < _ctx.Length("DescribeFilesets.Entries.Length"); i++) {
				DescribeFilesetsResponse.DescribeFilesets_Entrie entrie = new DescribeFilesetsResponse.DescribeFilesets_Entrie();
				entrie.Description = _ctx.StringValue("DescribeFilesets.Entries["+ i +"].Description");
				entrie.FileSystemPath = _ctx.StringValue("DescribeFilesets.Entries["+ i +"].FileSystemPath");
				entrie.FsetId = _ctx.StringValue("DescribeFilesets.Entries["+ i +"].FsetId");
				entrie.Status = _ctx.StringValue("DescribeFilesets.Entries["+ i +"].Status");
				entrie.CreateTime = _ctx.StringValue("DescribeFilesets.Entries["+ i +"].CreateTime");
				entrie.UpdateTiem = _ctx.StringValue("DescribeFilesets.Entries["+ i +"].UpdateTiem");

				describeFilesetsResponse_entries.Add(entrie);
			}
			describeFilesetsResponse.Entries = describeFilesetsResponse_entries;
        
			return describeFilesetsResponse;
        }
    }
}
