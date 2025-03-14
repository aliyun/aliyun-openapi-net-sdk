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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribePlaybookReleasesResponseUnmarshaller
    {
        public static DescribePlaybookReleasesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePlaybookReleasesResponse describePlaybookReleasesResponse = new DescribePlaybookReleasesResponse();

			describePlaybookReleasesResponse.HttpResponse = _ctx.HttpResponse;
			describePlaybookReleasesResponse.RequestId = _ctx.StringValue("DescribePlaybookReleases.RequestId");

			DescribePlaybookReleasesResponse.DescribePlaybookReleases_Page page = new DescribePlaybookReleasesResponse.DescribePlaybookReleases_Page();
			page.TotalCount = _ctx.IntegerValue("DescribePlaybookReleases.Page.TotalCount");
			page.PageNumber = _ctx.IntegerValue("DescribePlaybookReleases.Page.PageNumber");
			page.PageSize = _ctx.IntegerValue("DescribePlaybookReleases.Page.PageSize");
			describePlaybookReleasesResponse.Page = page;

			List<DescribePlaybookReleasesResponse.DescribePlaybookReleases_Data> describePlaybookReleasesResponse_records = new List<DescribePlaybookReleasesResponse.DescribePlaybookReleases_Data>();
			for (int i = 0; i < _ctx.Length("DescribePlaybookReleases.Records.Length"); i++) {
				DescribePlaybookReleasesResponse.DescribePlaybookReleases_Data data = new DescribePlaybookReleasesResponse.DescribePlaybookReleases_Data();
				data.Id = _ctx.IntegerValue("DescribePlaybookReleases.Records["+ i +"].Id");
				data.GmtCreate = _ctx.LongValue("DescribePlaybookReleases.Records["+ i +"].GmtCreate");
				data.GmtModified = _ctx.LongValue("DescribePlaybookReleases.Records["+ i +"].GmtModified");
				data.PlaybookId = _ctx.LongValue("DescribePlaybookReleases.Records["+ i +"].PlaybookId");
				data.ReleaseUuid = _ctx.StringValue("DescribePlaybookReleases.Records["+ i +"].ReleaseUuid");
				data.Creator = _ctx.StringValue("DescribePlaybookReleases.Records["+ i +"].Creator");
				data.Description = _ctx.StringValue("DescribePlaybookReleases.Records["+ i +"].Description");
				data.TaskflowMd5 = _ctx.StringValue("DescribePlaybookReleases.Records["+ i +"].TaskflowMd5");
				data.FlowFlag = _ctx.IntegerValue("DescribePlaybookReleases.Records["+ i +"].FlowFlag");
				data.FlowTag = _ctx.IntegerValue("DescribePlaybookReleases.Records["+ i +"].FlowTag");

				describePlaybookReleasesResponse_records.Add(data);
			}
			describePlaybookReleasesResponse.Records = describePlaybookReleasesResponse_records;
        
			return describePlaybookReleasesResponse;
        }
    }
}
