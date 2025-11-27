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
    public class DescribeComponentPlaybookResponseUnmarshaller
    {
        public static DescribeComponentPlaybookResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeComponentPlaybookResponse describeComponentPlaybookResponse = new DescribeComponentPlaybookResponse();

			describeComponentPlaybookResponse.HttpResponse = _ctx.HttpResponse;
			describeComponentPlaybookResponse.RequestId = _ctx.StringValue("DescribeComponentPlaybook.RequestId");

			List<DescribeComponentPlaybookResponse.DescribeComponentPlaybook_Data> describeComponentPlaybookResponse_playbooks = new List<DescribeComponentPlaybookResponse.DescribeComponentPlaybook_Data>();
			for (int i = 0; i < _ctx.Length("DescribeComponentPlaybook.Playbooks.Length"); i++) {
				DescribeComponentPlaybookResponse.DescribeComponentPlaybook_Data data = new DescribeComponentPlaybookResponse.DescribeComponentPlaybook_Data();
				data.DisplayName = _ctx.StringValue("DescribeComponentPlaybook.Playbooks["+ i +"].DisplayName");
				data.PlaybookUuid = _ctx.StringValue("DescribeComponentPlaybook.Playbooks["+ i +"].PlaybookUuid");
				data.OwnType = _ctx.StringValue("DescribeComponentPlaybook.Playbooks["+ i +"].OwnType");
				data.InputParams = _ctx.StringValue("DescribeComponentPlaybook.Playbooks["+ i +"].InputParams");
				data.OutputParams = _ctx.StringValue("DescribeComponentPlaybook.Playbooks["+ i +"].OutputParams");
				data.Description = _ctx.StringValue("DescribeComponentPlaybook.Playbooks["+ i +"].Description");
				data.TenantId = _ctx.StringValue("DescribeComponentPlaybook.Playbooks["+ i +"].TenantId");
				data.ParamType = _ctx.StringValue("DescribeComponentPlaybook.Playbooks["+ i +"].ParamType");

				describeComponentPlaybookResponse_playbooks.Add(data);
			}
			describeComponentPlaybookResponse.Playbooks = describeComponentPlaybookResponse_playbooks;
        
			return describeComponentPlaybookResponse;
        }
    }
}
