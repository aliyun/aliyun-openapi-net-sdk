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
    public class DescribePlaybooksResponseUnmarshaller
    {
        public static DescribePlaybooksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePlaybooksResponse describePlaybooksResponse = new DescribePlaybooksResponse();

			describePlaybooksResponse.HttpResponse = _ctx.HttpResponse;
			describePlaybooksResponse.RequestId = _ctx.StringValue("DescribePlaybooks.RequestId");

			DescribePlaybooksResponse.DescribePlaybooks_Page page = new DescribePlaybooksResponse.DescribePlaybooks_Page();
			page.TotalCount = _ctx.IntegerValue("DescribePlaybooks.Page.TotalCount");
			page.PageNumber = _ctx.IntegerValue("DescribePlaybooks.Page.PageNumber");
			page.PageSize = _ctx.IntegerValue("DescribePlaybooks.Page.PageSize");
			describePlaybooksResponse.Page = page;

			List<DescribePlaybooksResponse.DescribePlaybooks_Data> describePlaybooksResponse_playbooks = new List<DescribePlaybooksResponse.DescribePlaybooks_Data>();
			for (int i = 0; i < _ctx.Length("DescribePlaybooks.Playbooks.Length"); i++) {
				DescribePlaybooksResponse.DescribePlaybooks_Data data = new DescribePlaybooksResponse.DescribePlaybooks_Data();
				data.DisplayName = _ctx.StringValue("DescribePlaybooks.Playbooks["+ i +"].DisplayName");
				data.PlaybookUuid = _ctx.StringValue("DescribePlaybooks.Playbooks["+ i +"].PlaybookUuid");
				data.OwnType = _ctx.StringValue("DescribePlaybooks.Playbooks["+ i +"].OwnType");
				data.Active = _ctx.IntegerValue("DescribePlaybooks.Playbooks["+ i +"].Active");
				data.LastRuntime = _ctx.LongValue("DescribePlaybooks.Playbooks["+ i +"].LastRuntime");
				data.Permission = _ctx.IntegerValue("DescribePlaybooks.Playbooks["+ i +"].Permission");
				data.GmtCreate = _ctx.LongValue("DescribePlaybooks.Playbooks["+ i +"].GmtCreate");
				data.PlaybookStatus = _ctx.IntegerValue("DescribePlaybooks.Playbooks["+ i +"].PlaybookStatus");
				data.GmtModified = _ctx.StringValue("DescribePlaybooks.Playbooks["+ i +"].GmtModified");
				data.ParamType = _ctx.StringValue("DescribePlaybooks.Playbooks["+ i +"].ParamType");
				data.Description = _ctx.StringValue("DescribePlaybooks.Playbooks["+ i +"].Description");
				data.TenantId = _ctx.StringValue("DescribePlaybooks.Playbooks["+ i +"].TenantId");

				describePlaybooksResponse_playbooks.Add(data);
			}
			describePlaybooksResponse.Playbooks = describePlaybooksResponse_playbooks;
        
			return describePlaybooksResponse;
        }
    }
}
