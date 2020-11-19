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
			describeActiveVersionOfConfigGroupResponse.RequestId = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.RequestId");
			describeActiveVersionOfConfigGroupResponse.VersionId = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.VersionId");
			describeActiveVersionOfConfigGroupResponse.ConfigGroupId = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.ConfigGroupId");
			describeActiveVersionOfConfigGroupResponse.BaseVersionId = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.BaseVersionId");
			describeActiveVersionOfConfigGroupResponse.Description = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.Description");
			describeActiveVersionOfConfigGroupResponse.SeqId = _ctx.LongValue("DescribeActiveVersionOfConfigGroup.SeqId");
			describeActiveVersionOfConfigGroupResponse.Status = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.Status");
			describeActiveVersionOfConfigGroupResponse._Operator = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.Operator");
			describeActiveVersionOfConfigGroupResponse.CreateTime = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.CreateTime");
			describeActiveVersionOfConfigGroupResponse.UpdateTime = _ctx.StringValue("DescribeActiveVersionOfConfigGroup.UpdateTime");
        
			return describeActiveVersionOfConfigGroupResponse;
        }
    }
}
