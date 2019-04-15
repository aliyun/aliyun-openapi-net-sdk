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
    public class DescribeEmgNoticeResponseUnmarshaller
    {
        public static DescribeEmgNoticeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEmgNoticeResponse describeEmgNoticeResponse = new DescribeEmgNoticeResponse();

			describeEmgNoticeResponse.HttpResponse = context.HttpResponse;
			describeEmgNoticeResponse.RequestId = context.StringValue("DescribeEmgNotice.RequestId");
			describeEmgNoticeResponse.TotalCount = context.IntegerValue("DescribeEmgNotice.TotalCount");

			List<DescribeEmgNoticeResponse.DescribeEmgNotice_EmgVulGroup> describeEmgNoticeResponse_emgVulGroupList = new List<DescribeEmgNoticeResponse.DescribeEmgNotice_EmgVulGroup>();
			for (int i = 0; i < context.Length("DescribeEmgNotice.EmgVulGroupList.Length"); i++) {
				DescribeEmgNoticeResponse.DescribeEmgNotice_EmgVulGroup emgVulGroup = new DescribeEmgNoticeResponse.DescribeEmgNotice_EmgVulGroup();
				emgVulGroup.AliasName = context.StringValue("DescribeEmgNotice.EmgVulGroupList["+ i +"].AliasName");
				emgVulGroup.Name = context.StringValue("DescribeEmgNotice.EmgVulGroupList["+ i +"].Name");
				emgVulGroup.GmtPublish = context.LongValue("DescribeEmgNotice.EmgVulGroupList["+ i +"].GmtPublish");
				emgVulGroup.Description = context.StringValue("DescribeEmgNotice.EmgVulGroupList["+ i +"].Description");
				emgVulGroup.Type = context.StringValue("DescribeEmgNotice.EmgVulGroupList["+ i +"].Type");
				emgVulGroup.Status = context.IntegerValue("DescribeEmgNotice.EmgVulGroupList["+ i +"].Status");

				describeEmgNoticeResponse_emgVulGroupList.Add(emgVulGroup);
			}
			describeEmgNoticeResponse.EmgVulGroupList = describeEmgNoticeResponse_emgVulGroupList;
        
			return describeEmgNoticeResponse;
        }
    }
}
