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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeActiveVersionOfConfigGroupResponseUnmarshaller
    {
        public static DescribeActiveVersionOfConfigGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeActiveVersionOfConfigGroupResponse describeActiveVersionOfConfigGroupResponse = new DescribeActiveVersionOfConfigGroupResponse();

			describeActiveVersionOfConfigGroupResponse.HttpResponse = _ctx.HttpResponse;
			describeActiveVersionOfConfigGroupResponse.Status = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.Status");
			describeActiveVersionOfConfigGroupResponse.UpdateTime = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.UpdateTime");
			describeActiveVersionOfConfigGroupResponse.RequestId = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.RequestId");
			describeActiveVersionOfConfigGroupResponse.SeqId = _ctx.LongValue("DescribeActiveVersionOfConfigGroup.SeqId");
			describeActiveVersionOfConfigGroupResponse.Description = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.Description");
			describeActiveVersionOfConfigGroupResponse.CreateTime = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.CreateTime");
			describeActiveVersionOfConfigGroupResponse.VersionId = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.VersionId");
			describeActiveVersionOfConfigGroupResponse.ConfigGroupId = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.ConfigGroupId");
			describeActiveVersionOfConfigGroupResponse._Operator = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.Operator");
			describeActiveVersionOfConfigGroupResponse.BaseVersionId = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.BaseVersionId");
        
			return describeActiveVersionOfConfigGroupResponse;
        }
    }
}
