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
    public class DescribeEmgVulGroupResponseUnmarshaller
    {
        public static DescribeEmgVulGroupResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEmgVulGroupResponse describeEmgVulGroupResponse = new DescribeEmgVulGroupResponse();

			describeEmgVulGroupResponse.HttpResponse = context.HttpResponse;
			describeEmgVulGroupResponse.RequestId = context.StringValue("DescribeEmgVulGroup.RequestId");
			describeEmgVulGroupResponse.TotalCount = context.IntegerValue("DescribeEmgVulGroup.TotalCount");

			List<DescribeEmgVulGroupResponse.DescribeEmgVulGroup_EmgVulGroup> describeEmgVulGroupResponse_emgVulGroupList = new List<DescribeEmgVulGroupResponse.DescribeEmgVulGroup_EmgVulGroup>();
			for (int i = 0; i < context.Length("DescribeEmgVulGroup.EmgVulGroupList.Length"); i++) {
				DescribeEmgVulGroupResponse.DescribeEmgVulGroup_EmgVulGroup emgVulGroup = new DescribeEmgVulGroupResponse.DescribeEmgVulGroup_EmgVulGroup();
				emgVulGroup.AliasName = context.StringValue("DescribeEmgVulGroup.EmgVulGroupList["+ i +"].AliasName");
				emgVulGroup.PendingCount = context.IntegerValue("DescribeEmgVulGroup.EmgVulGroupList["+ i +"].PendingCount");
				emgVulGroup.Name = context.StringValue("DescribeEmgVulGroup.EmgVulGroupList["+ i +"].Name");
				emgVulGroup.GmtPublish = context.LongValue("DescribeEmgVulGroup.EmgVulGroupList["+ i +"].GmtPublish");
				emgVulGroup.Description = context.StringValue("DescribeEmgVulGroup.EmgVulGroupList["+ i +"].Description");
				emgVulGroup.Type = context.StringValue("DescribeEmgVulGroup.EmgVulGroupList["+ i +"].Type");
				emgVulGroup.Status = context.IntegerValue("DescribeEmgVulGroup.EmgVulGroupList["+ i +"].Status");
				emgVulGroup.Progress = context.IntegerValue("DescribeEmgVulGroup.EmgVulGroupList["+ i +"].Progress");
				emgVulGroup.GmtLastCheck = context.LongValue("DescribeEmgVulGroup.EmgVulGroupList["+ i +"].GmtLastCheck");

				describeEmgVulGroupResponse_emgVulGroupList.Add(emgVulGroup);
			}
			describeEmgVulGroupResponse.EmgVulGroupList = describeEmgVulGroupResponse_emgVulGroupList;
        
			return describeEmgVulGroupResponse;
        }
    }
}
