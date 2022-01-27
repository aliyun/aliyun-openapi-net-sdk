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
    public class DescribeModifyParameterLogResponseUnmarshaller
    {
        public static DescribeModifyParameterLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeModifyParameterLogResponse describeModifyParameterLogResponse = new DescribeModifyParameterLogResponse();

			describeModifyParameterLogResponse.HttpResponse = _ctx.HttpResponse;
			describeModifyParameterLogResponse.RequestId = _ctx.StringValue("DescribeModifyParameterLog.RequestId");

			List<DescribeModifyParameterLogResponse.DescribeModifyParameterLog_ChangelogsItem> describeModifyParameterLogResponse_changelogs = new List<DescribeModifyParameterLogResponse.DescribeModifyParameterLog_ChangelogsItem>();
			for (int i = 0; i < _ctx.Length("DescribeModifyParameterLog.Changelogs.Length"); i++) {
				DescribeModifyParameterLogResponse.DescribeModifyParameterLog_ChangelogsItem changelogsItem = new DescribeModifyParameterLogResponse.DescribeModifyParameterLog_ChangelogsItem();
				changelogsItem.ParameterValueAfter = _ctx.StringValue("DescribeModifyParameterLog.Changelogs["+ i +"].ParameterValueAfter");
				changelogsItem.ParameterName = _ctx.StringValue("DescribeModifyParameterLog.Changelogs["+ i +"].ParameterName");
				changelogsItem.EffectTime = _ctx.StringValue("DescribeModifyParameterLog.Changelogs["+ i +"].EffectTime");
				changelogsItem.ParameterValueBefore = _ctx.StringValue("DescribeModifyParameterLog.Changelogs["+ i +"].ParameterValueBefore");
				changelogsItem.ParameterValid = _ctx.StringValue("DescribeModifyParameterLog.Changelogs["+ i +"].ParameterValid");

				describeModifyParameterLogResponse_changelogs.Add(changelogsItem);
			}
			describeModifyParameterLogResponse.Changelogs = describeModifyParameterLogResponse_changelogs;
        
			return describeModifyParameterLogResponse;
        }
    }
}
